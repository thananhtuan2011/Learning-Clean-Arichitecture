using Domain.Entities;
using Domain.Entities.User;
using Domain.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Command.User
{
   
    public record RegisterUserCommand(UserEntities userEntities) : IRequest<bool>;
    public class RegisterUserCommandHandler(IUserIdentity userRepository)
       : IRequestHandler<RegisterUserCommand, bool>
    {
        public async Task<bool> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            return await userRepository.Insert(request.userEntities);
        }

       
    }
}
