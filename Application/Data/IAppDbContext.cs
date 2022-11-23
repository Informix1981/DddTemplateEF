using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Data
{
    public interface IAppDbContext
    {
        //public DbSet<Entity_Type> EntitiesName {get; set;}
        //...
        public void SaveChanges();
        public void Dispose();
    }
}
