using Domain.Entities;
using Domain.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries
{
    public record GetAllAreaQueries() : IRequest<IEnumerable<AreaEntities>>;
    public class GetAllAreaQueriesHanlder(IAreaResponsitories areaRepository) : IRequestHandler<GetAllAreaQueries, IEnumerable<AreaEntities>>
    {
       public async Task<IEnumerable<AreaEntities>> Handle(GetAllAreaQueries query, CancellationToken cancellationToken)
    {
        return await areaRepository.GetArea();
    }
}
}
