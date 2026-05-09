using Application.DTO;
using Domain.Entities.User;
using Domain.Interface;
using Domain.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.User
{
    public record LoginQueries(RequestLoginDTO requestLogin) : IRequest<Jwt>;
    public class RegisterUserCommandHandler(IUserIdentity userRepository)
       : IRequestHandler<LoginQueries, Jwt>
    {
        public async Task<Jwt> Handle(LoginQueries request, CancellationToken cancellationToken)
        {
            return await userRepository.Login(request.requestLogin.Email, request.requestLogin.Password);
        }


    }
}
