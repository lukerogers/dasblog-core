﻿using System.Collections.Generic;
using System.Runtime.InteropServices;
using DasBlog.Core.Security;
using Xunit;
using DasBlog.Core.Services;
using DasBlog.Core.Services.Interfaces;
using Microsoft.Extensions.Options;
using System.Linq;

namespace DasBlog.Tests.Services
{
	public class UserDataRepoTest
	{
		[Fact]
		public void ShouldLoadUsers()
		{
			IUserDataRepo repo = new UserDataRepo(
			  new Options<LocalUserDataOptions>{ Value = new LocalUserDataOptions{Path = string.Empty}});
			List<User> users = repo.LoadUsers().ToList();

			Assert.Single(users, u => u.Name == "admin");
		}
	}

	public class Options<T> : IOptions<T> where T : class, new()
	{
		public T Value { get; set; }
	}
}