using Domain.Entities;
using Domain.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Command.Area
{
    public record AddAreaCommand(AreaEntities AreaEntities) : IRequest<AreaEntities>;
    public class AddAreaCommandHandler(IAreaResponsitories areaRepository)
       : IRequestHandler<AddAreaCommand, AreaEntities>
    {
        public async Task<AreaEntities> Handle(AddAreaCommand request, CancellationToken cancellationToken)
        {
            return await areaRepository.AddAreaAsync(request.AreaEntities);
        }
    }
}
