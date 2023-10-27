using PD.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD.Core.Interfaces
{
    public interface ICategoriaManager
    {
        public IList<CategoriaDto> GetList();
    }
}
