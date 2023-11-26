using Microsoft.Extensions.Configuration;
using PD.Core.DTO;
using PD.Core.DTOs.Articulo;
using PD.Core.Interfaces;
using PD.Core.Mappers.Interfaces;
using PD.Entities;
using PD.Repositories.Interfaces;

namespace PD.Core
{
    public class ArticulosManager : IArticulosManager
    {
        private readonly IConfiguration _configuration;
        private readonly IArticuloRepository _repository;
        private readonly IArticulosMapper _articuloMapper;
        private readonly IListaRepository _listaRepository;

        public ArticulosManager(
            IConfiguration configuration,
            IArticuloRepository repository,
            IArticulosMapper articuloMapper,
            IListaRepository listaRepository)
        {
            _configuration = configuration;
            _repository = repository;
            _articuloMapper = articuloMapper;
            _listaRepository = listaRepository;
        }

        public Articulo CrearArticulo(ArticuloDTO dto)
        {
            var articulo = _articuloMapper.GetArticulo(dto);
            articulo.Imagen = CopyImange(dto.ImagePath, articulo.Id);

            if (dto.Id.HasValue && dto.Id != Guid.Empty)
            {
                return _repository.Update(articulo);
            }

            dto.Id = articulo.Id;
            articulo =_repository.Save(articulo);


            _listaRepository.UpdateArticuloLista(articulo);

            return articulo;
        }

        private string CopyImange(string imagePath, Guid id)
        {
            if (string.IsNullOrEmpty(imagePath))
                return "";

            var baseConfigPath = _configuration["InitialConfig:BaseImagePath"];
            var baseConfigImagesPath = _configuration["InitialConfig:ImagesPaths"];

            var baseImagePath = !string.IsNullOrEmpty(baseConfigImagesPath) ? baseConfigImagesPath : "";
            var basePath = string.IsNullOrEmpty(baseConfigPath) ? AppContext.BaseDirectory : baseConfigPath;

            var fileInfo = new FileInfo(imagePath);

            var path = Path.Combine(basePath, baseImagePath);

            if (!Directory.Exists(path)) Directory.CreateDirectory(path);

            var destinyPath = Path.Combine(path, $"{id}{fileInfo.Extension}");

            File.Copy(imagePath, destinyPath, true);

            return destinyPath;
        }

        public List<ArticuloListaDTO> GetList()
            => _articuloMapper.GetArticuloListas(_repository.GetAll().ToList());
    }
}