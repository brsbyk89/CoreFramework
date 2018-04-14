using CoreFramework.BusinessEntities;
using CoreFramework.Data.Contracts;
using Microsoft.EntityFrameworkCore;
using System;

namespace CoreFramework.Data
{
    public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options) { }
		public DbSet<Account> AccountSet { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
		}
	}
}
