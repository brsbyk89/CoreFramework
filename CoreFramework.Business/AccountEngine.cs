using CoreFramework.Business.Contracts;
using CoreFramework.Data.Contracts;
using System;

namespace CoreFramework.Business
{
	public class AccountEngine : IAccountEngine
	{
		IAccountRepository _accountRepository;

		public AccountEngine(IAccountRepository accountRepository)
		{
			_accountRepository = accountRepository;
		}
		public int Add()
		{
			_accountRepository.Add("Ali", "qwert");
			return 5;
		}
	}
}
