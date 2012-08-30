using System;
using System.Linq;
using System.Windows.Forms;
using MiniboardModel.Models;


namespace MiniboardView
{
   public partial class Form1 : Form
   {
      private MiniboardEntities context;

      public Form1()
      {
         context = new MiniboardEntities();
         InitializeComponent();
      }

      private void PeopleListView_Initialized(object sender, EventArgs e)
      {
         PeopleListView.DataSource = context.People.ToList<Person>();
      }

      private void ProjectGridView_Initialize(object sender, EventArgs e)
      {
         ProjectGridView.DataSource = context.Projects.ToList<Project>();
      }

      private void AddPerson_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (IsEnterKey(e.KeyChar))
         {
            var name = AddPerson.Text;
            context.People.Add(new Person(name));
            context.SaveChanges();
         }
      }

      private void AddProject_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (IsEnterKey(e.KeyChar))
         {
            var name = AddProject.Text;
            context.Projects.Add(new Project(name));
            context.SaveChanges();
         }
      }

      private bool IsEnterKey(int key) {
         return key == 13;
      }

      private void ProjectGridView_CellValidating(object sender, Telerik.WinControls.UI.CellValidatingEventArgs e)
      {
         if (e.Value != null)
         {
            var peep = context.People.Where(person => person.Name == (string)e.Value);
            var ShellProject = context.Projects.Where(project => project.Name == "Shell");
            var shellLeads = ShellProject.Select(project => project.TeamLeads.Add(peep));
         }
      }
   }
}
