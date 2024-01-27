﻿using WAD_17191.Application.Interfaces;
using WAD_17191.Domain.Models;
using WAD_17191.Infrastructure.AppData;

namespace WAD_17191.Infrastructure.Repositories
{
	public class UserRepository : Repository<User>, IUserRepo
	{
		public UserRepository(ApplicationDbContext context) : base(context)
		{
		}
	}
}
