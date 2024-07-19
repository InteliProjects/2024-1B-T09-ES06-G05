using AutoMapper;
using CoreService.DTOs;
using CoreService.Models;

public class AutoMapperProfile : Profile
{
    // Mapping from UserDTO to UserModel
    public AutoMapperProfile()
    {
        CreateMap<UserDTO, UserModel>();
    }
}
