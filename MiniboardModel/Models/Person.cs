using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace MiniboardModel.Models
{
   public class Person
   {
      [Key]
      public string Name { get; set; }
      public string ImagePath { get; set; }

      public Person() { }

      public Person(string name)
      {
         this.Name = name;
      }
   }
}
