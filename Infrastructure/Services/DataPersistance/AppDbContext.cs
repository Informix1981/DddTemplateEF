using Application.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.DataPersistance
{
    /// <summary>
    /// Entity Framwork Class
    /// </summary>
    public class AppDbContext : DbContext, IAppDbContext
    {
        /// <summary>
        /// Dbcontext constructor
        /// </summary>
        /// <param name="options">options related to database type</param>
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        /// <summary>
        /// Code first desciption of database tables properties and relations
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Exemple: modify EntityName with required model name
            //modelBuilder.Entity<EntityName>(entity =>
            //{
            //    entity.HasKey(e => e.KeyProperyName).HasName("PrimaryKey_EntityName");
            //    entity.ToTable("TableName");
            //    entity.Property(e => e.Property1Name).HasMaxLength(30);
            //    entity.Property(e => e.Property2Name).HasColumnType("nvarchar(max)");
            //    entity.Property(e => e.Property3Name).HasMaxLength(30);
            //});
        }
        /// <summary>
        /// Save context changes
        /// </summary>
        void IAppDbContext.SaveChanges() => base.SaveChanges();
    }
}
