using CoreFramework.BusinessEntities;
using CoreFramework.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreFramework.Data.Repositories
{
	public class AccountRepository : IAccountRepository
	{
		private DataContext _dataContext;
		public AccountRepository(DataContext dataContext)
		{
			_dataContext = dataContext;
		}

		public Account Add(string userName, string password)
		{
			var account = new Account();
			account.UserName = userName;
			account.Password = password;
			account.CreationDate = DateTime.Now;

			_dataContext.AccountSet.Add(account);
			_dataContext.SaveChanges();

			return account;
		}
	}
}
