using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IAreaResponsitories
    {
        Task<IEnumerable<AreaEntities>> GetArea();
        Task<AreaEntities> GetAreaByIdAsync(Guid id);
        Task<AreaEntities> AddAreaAsync(AreaEntities entity);
        Task<AreaEntities> UpdateAreaByAsync(Guid customerId, AreaEntities entity);
        Task<bool> DeleteAreaAsync(Guid customerId);
    }
}
