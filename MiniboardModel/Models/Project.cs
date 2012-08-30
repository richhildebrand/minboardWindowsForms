using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniboardModel.Models
{
   public class Project
   {
      public int ProjectId { get; set; }
      public string Name { get; set; }
      public List<Person> TeamLeads { get; set; }
      public List<Person> TeamMembers { get; set; }

      public Project() { }

      public Project(string name)
      {
         this.Name = name;
      }
   }
}
