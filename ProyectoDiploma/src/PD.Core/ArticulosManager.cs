using Microsoft.Extensions.Configuration;
using PD.Core.DTO;
using PD.Core.DTOs.Articulo;
using PD.Core.Interfaces;
using PD.Core.Mappers.Interfaces;
using PD.Repositories.Interfaces;

namespace PD.Core
{
    public class ArticulosManager : IArticulosManager
    {
        private readonly IConfiguration _configuration;
        private readonly IArticuloRepository _repository;
        private readonly IArticulosMapper _articuloMapper;

        public ArticulosManager(
            IConfiguration configuration,
            IArticuloRepository repository,
            IArticulosMapper articuloMapper)
        {
            _configuration = configuration;
            _repository = repository;
            _articuloMapper = articuloMapper;
        }

        public void CrearArticulo(ArticuloDTO articulo)
        {
            var id = Guid.NewGuid();
            articulo.Id = id;
            var art = _articuloMapper.GetArticulo(articulo);
            art.Imagen = CopyImange(articulo.ImagePath, id);

            _repository.Save(art);
        }

        private string CopyImange(string imagePath, Guid id)
        {
            if (string.IsNullOrEmpty(imagePath))
                return "";

            var baseConfigPath = _configuration["InitalConfig:BaseImagePath"];
            var baseConfigImagesPath = _configuration["InitalConfig:ImagesPaths"];

            var baseImagePath = string.IsNullOrEmpty(baseConfigImagesPath) ? baseConfigImagesPath : "";
            var basePath = string.IsNullOrEmpty(baseConfigPath) ? AppContext.BaseDirectory : baseConfigPath;

            var destinyPath = Path.Combine(basePath, baseImagePath, id.ToString());

            File.Copy(imagePath, destinyPath);

            return destinyPath;
        }

        public List<ArticuloListaDTO> GetList()
            => _articuloMapper.GetArticuloListas(_repository.GetAll().ToList());
    }
}