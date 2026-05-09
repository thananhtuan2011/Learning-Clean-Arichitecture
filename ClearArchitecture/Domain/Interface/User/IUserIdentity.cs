
using Domain.Entities.User;
using Domain.Model;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Domain.Interface
{
    public interface IUserIdentity
    {
        Task<Jwt> Login(string email, string pass);
        Task<Jwt> SignIn(string email);
        Task<Jwt> RefreshToken(string refreshToken, string CompanyId);
        //Task<GetUserProfileDTO> GetUserProfile(Guid Id);
        ClaimsPrincipal GetPrincipalRefreshToken(string token);
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
        public string GenerateAccessToken(IEnumerable<Claim> claims);
        public string GenerateRefreshToken(IEnumerable<Claim> claims);
        //Task<PaginatedResponse<GetUserDTO>> GetAllUser(PaginatedRequest query);
        //Task<GetUserDTO> FindUserEmailAndCode(string  email, string  code);
        //Task<GetAllDataUserDTO> FindUserEmail(string email);  
        //Task<CheckTimerDTO> CheckTimer(Guid Id);
        //Task<GetUserDTO> FindId(Guid Id);
        //Task<bool> Update(UserUpdateDTO Id);
        //Task UpdateTimer(UpdateTimerDTO user,Guid Id);
        Task<bool> Insert(UserEntities user);
        //bool ChangePassWithToken(TokenPass tokenPass);
        //Task<List<GetUserDTO>> ListUser();
        //Task<Jwt> Register(RegisterUserDTO userDto);
        //UserBusinessStatus GetUserStatus(string businessId);
        //Task<ValidateInvitationResponse> ValidateInvitation(ValidateInvitationDto invitation);
    }
}
