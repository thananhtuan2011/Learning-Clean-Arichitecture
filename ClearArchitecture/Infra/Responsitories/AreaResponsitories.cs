using Domain.Entities;
using Domain.Interface;
using Infra.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Responsitories
{
    internal class AreaResponsitories(AppDbContext dbContext) : IAreaResponsitories
    {
        public async Task<AreaEntities> AddAreaAsync(AreaEntities entity)
        {
            await dbContext.Areas.AddAsync(entity);
            await dbContext.SaveChangesAsync();
            return entity;
        }

        public Task<bool> DeleteAreaAsync(Guid customerId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<AreaEntities>> GetArea()
        {
           var data= await dbContext.Areas.ToListAsync();
            return data;
        }

        public Task<AreaEntities> GetAreaByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<AreaEntities> UpdateAreaByAsync(Guid customerId, AreaEntities entity)
        {
            throw new NotImplementedException();
        }
    }
}
