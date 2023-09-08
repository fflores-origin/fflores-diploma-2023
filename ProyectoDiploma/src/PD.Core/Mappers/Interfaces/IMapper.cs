using PD.Core.DTOs;
using PD.Entities;

namespace PD.Core.Mappers.Interfaces
{
    public interface IMapper<Entity, Dto> where Entity : BaseEntity where Dto : BaseDto
    {
        Entity Map(Dto dto);

        Dto Map(Entity entity);
    }
}