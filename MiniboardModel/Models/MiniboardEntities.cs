using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace MiniboardModel.Models
{
   public class MiniboardEntities : DbContext
   {
      public DbSet<Project> Projects { get; set; }
      public DbSet<Person> People { get; set; }
   }
}
