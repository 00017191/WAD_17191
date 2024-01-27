using AutoMapper;
using WAD_17191.Application.DTOs;
using WAD_17191.Domain.Models;

namespace WAD_17191.Application.Mapping
{
	public class Mapper : Profile
	{
		public Mapper() 
		{
			CreateMap<User, UserDto>();
			CreateMap<FitnessActivity, ActivityDto>();
		}
	}
}
