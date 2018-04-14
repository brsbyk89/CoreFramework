using CoreFramework.Business.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreFramework
{
	public class AccountController : Controller
	{
		private IAccountEngine _accountEngine;
		public AccountController(IAccountEngine accountEngine)
		{
			_accountEngine = accountEngine;
		}

		[HttpGet]
		public int Test()
		{


			return _accountEngine.Add();
		}
	}
}
