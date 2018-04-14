using CoreFramework.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreFramework.Data.Contracts
{
    public interface IAccountRepository : IDataRepository
	{
		Account Add(string userName, string password);
    }
}
