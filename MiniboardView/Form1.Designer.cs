namespace MiniboardView
{
   partial class Form1
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
         Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
         Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
         Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
         Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
         this.personBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
         this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
         this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
         this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
         this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
         this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
         this.personBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
         this.PeopleListView = new Telerik.WinControls.UI.RadListView();
         this.object_2d8b3bc5_7757_49f0_b696_d79944cf08d1 = new Telerik.WinControls.RootRadElement();
         this.object_9d1e0f44_8bdc_4484_851b_5381c7c7950d = new Telerik.WinControls.RootRadElement();
         this.object_4ad4b03b_7b55_4b05_97f9_8d139921fb73 = new Telerik.WinControls.RootRadElement();
         this.AddPerson = new System.Windows.Forms.TextBox();
         this.ProjectGridView = new Telerik.WinControls.UI.RadGridView();
         this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.AddProject = new System.Windows.Forms.TextBox();
         ((System.ComponentModel.ISupportInitialize)(this.personBindingNavigator)).BeginInit();
         this.personBindingNavigator.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.PeopleListView)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.ProjectGridView)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
         this.SuspendLayout();
         // 
         // personBindingNavigator
         // 
         this.personBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
         this.personBindingNavigator.BindingSource = this.personBindingSource;
         this.personBindingNavigator.CountItem = this.bindingNavigatorCountItem;
         this.personBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
         this.personBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.personBindingNavigatorSaveItem});
         this.personBindingNavigator.Location = new System.Drawing.Point(0, 0);
         this.personBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
         this.personBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
         this.personBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
         this.personBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
         this.personBindingNavigator.Name = "personBindingNavigator";
         this.personBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
         this.personBindingNavigator.Size = new System.Drawing.Size(881, 25);
         this.personBindingNavigator.TabIndex = 0;
         this.personBindingNavigator.Text = "bindingNavigator1";
         // 
         // bindingNavigatorAddNewItem
         // 
         this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
         this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
         this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorAddNewItem.Text = "Add new";
         // 
         // personBindingSource
         // 
         this.personBindingSource.DataSource = typeof(MiniboardModel.Models.Person);
         // 
         // bindingNavigatorCountItem
         // 
         this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
         this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
         this.bindingNavigatorCountItem.Text = "of {0}";
         this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
         // 
         // bindingNavigatorDeleteItem
         // 
         this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
         this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
         this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorDeleteItem.Text = "Delete";
         // 
         // bindingNavigatorMoveFirstItem
         // 
         this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
         this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
         this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorMoveFirstItem.Text = "Move first";
         // 
         // bindingNavigatorMovePreviousItem
         // 
         this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
         this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
         this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorMovePreviousItem.Text = "Move previous";
         // 
         // bindingNavigatorSeparator
         // 
         this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
         this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
         // 
         // bindingNavigatorPositionItem
         // 
         this.bindingNavigatorPositionItem.AccessibleName = "Position";
         this.bindingNavigatorPositionItem.AutoSize = false;
         this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
         this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
         this.bindingNavigatorPositionItem.Text = "0";
         this.bindingNavigatorPositionItem.ToolTipText = "Current position";
         // 
         // bindingNavigatorSeparator1
         // 
         this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
         this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
         // 
         // bindingNavigatorMoveNextItem
         // 
         this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
         this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
         this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorMoveNextItem.Text = "Move next";
         // 
         // bindingNavigatorMoveLastItem
         // 
         this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
         this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
         this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorMoveLastItem.Text = "Move last";
         // 
         // bindingNavigatorSeparator2
         // 
         this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
         this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
         // 
         // personBindingNavigatorSaveItem
         // 
         this.personBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.personBindingNavigatorSaveItem.Enabled = false;
         this.personBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("personBindingNavigatorSaveItem.Image")));
         this.personBindingNavigatorSaveItem.Name = "personBindingNavigatorSaveItem";
         this.personBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
         this.personBindingNavigatorSaveItem.Text = "Save Data";
         // 
         // PeopleListView
         // 
         this.PeopleListView.DisplayMember = "Name";
         this.PeopleListView.GroupItemSize = new System.Drawing.Size(200, 20);
         this.PeopleListView.ItemSize = new System.Drawing.Size(200, 20);
         this.PeopleListView.Location = new System.Drawing.Point(12, 66);
         this.PeopleListView.Name = "PeopleListView";
         this.PeopleListView.Size = new System.Drawing.Size(80, 359);
         this.PeopleListView.TabIndex = 1;
         this.PeopleListView.Text = "radListView1";
         this.PeopleListView.Initialized += new System.EventHandler(this.PeopleListView_Initialized);
         // 
         // object_2d8b3bc5_7757_49f0_b696_d79944cf08d1
         // 
         this.object_2d8b3bc5_7757_49f0_b696_d79944cf08d1.MinSize = new System.Drawing.Size(25, 25);
         this.object_2d8b3bc5_7757_49f0_b696_d79944cf08d1.Name = "object_2d8b3bc5_7757_49f0_b696_d79944cf08d1";
         this.object_2d8b3bc5_7757_49f0_b696_d79944cf08d1.StretchHorizontally = true;
         this.object_2d8b3bc5_7757_49f0_b696_d79944cf08d1.StretchVertically = true;
         this.object_2d8b3bc5_7757_49f0_b696_d79944cf08d1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
         // 
         // object_9d1e0f44_8bdc_4484_851b_5381c7c7950d
         // 
         this.object_9d1e0f44_8bdc_4484_851b_5381c7c7950d.Name = "object_9d1e0f44_8bdc_4484_851b_5381c7c7950d";
         this.object_9d1e0f44_8bdc_4484_851b_5381c7c7950d.StretchHorizontally = true;
         this.object_9d1e0f44_8bdc_4484_851b_5381c7c7950d.StretchVertically = true;
         this.object_9d1e0f44_8bdc_4484_851b_5381c7c7950d.Visibility = Telerik.WinControls.ElementVisibility.Visible;
         // 
         // object_4ad4b03b_7b55_4b05_97f9_8d139921fb73
         // 
         this.object_4ad4b03b_7b55_4b05_97f9_8d139921fb73.Name = "object_4ad4b03b_7b55_4b05_97f9_8d139921fb73";
         this.object_4ad4b03b_7b55_4b05_97f9_8d139921fb73.StretchHorizontally = true;
         this.object_4ad4b03b_7b55_4b05_97f9_8d139921fb73.StretchVertically = true;
         this.object_4ad4b03b_7b55_4b05_97f9_8d139921fb73.Visibility = Telerik.WinControls.ElementVisibility.Visible;
         // 
         // AddPerson
         // 
         this.AddPerson.Location = new System.Drawing.Point(12, 40);
         this.AddPerson.Name = "AddPerson";
         this.AddPerson.Size = new System.Drawing.Size(80, 20);
         this.AddPerson.TabIndex = 2;
         this.AddPerson.Text = "Add Person";
         this.AddPerson.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddPerson_KeyPress);
         // 
         // ProjectGridView
         // 
         this.ProjectGridView.BackColor = System.Drawing.SystemColors.Control;
         this.ProjectGridView.BeginEditMode = Telerik.WinControls.RadGridViewBeginEditMode.BeginEditOnEnter;
         this.ProjectGridView.Cursor = System.Windows.Forms.Cursors.Default;
         this.ProjectGridView.EnterKeyMode = Telerik.WinControls.UI.RadGridViewEnterKeyMode.EnterMovesToNextRow;
         this.ProjectGridView.Font = new System.Drawing.Font("Segoe UI", 8.25F);
         this.ProjectGridView.ForeColor = System.Drawing.SystemColors.ControlText;
         this.ProjectGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
         this.ProjectGridView.Location = new System.Drawing.Point(131, 66);
         // 
         // ProjectGridView
         // 
         gridViewDecimalColumn1.DataType = typeof(int);
         gridViewDecimalColumn1.EnableExpressionEditor = false;
         gridViewDecimalColumn1.FieldName = "ProjectId";
         gridViewDecimalColumn1.HeaderText = "ProjectId";
         gridViewDecimalColumn1.IsAutoGenerated = true;
         gridViewDecimalColumn1.IsVisible = false;
         gridViewDecimalColumn1.Name = "ProjectId";
         gridViewTextBoxColumn1.EnableExpressionEditor = false;
         gridViewTextBoxColumn1.FieldName = "Name";
         gridViewTextBoxColumn1.HeaderText = "Name";
         gridViewTextBoxColumn1.IsAutoGenerated = true;
         gridViewTextBoxColumn1.Name = "Name";
         gridViewTextBoxColumn1.Width = 38;
         gridViewTextBoxColumn2.DataType = typeof(System.Collections.Generic.List<MiniboardModel.Models.Person>);
         gridViewTextBoxColumn2.EnableExpressionEditor = false;
         gridViewTextBoxColumn2.FieldName = "TeamLeads";
         gridViewTextBoxColumn2.HeaderText = "TeamLeads";
         gridViewTextBoxColumn2.IsAutoGenerated = true;
         gridViewTextBoxColumn2.Name = "TeamLeads";
         gridViewTextBoxColumn2.Width = 64;
         gridViewTextBoxColumn3.DataType = typeof(System.Collections.Generic.List<MiniboardModel.Models.Person>);
         gridViewTextBoxColumn3.EnableExpressionEditor = false;
         gridViewTextBoxColumn3.FieldName = "TeamMembers";
         gridViewTextBoxColumn3.HeaderText = "TeamMembers";
         gridViewTextBoxColumn3.IsAutoGenerated = true;
         gridViewTextBoxColumn3.Name = "TeamMembers";
         gridViewTextBoxColumn3.Width = 83;
         this.ProjectGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
         this.ProjectGridView.MasterTemplate.DataSource = this.projectBindingSource;
         this.ProjectGridView.MasterTemplate.EnableAlternatingRowColor = true;
         this.ProjectGridView.Name = "ProjectGridView";
         this.ProjectGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
         this.ProjectGridView.ShowGroupPanel = false;
         this.ProjectGridView.Size = new System.Drawing.Size(708, 359);
         this.ProjectGridView.TabIndex = 3;
         this.ProjectGridView.Text = "ProjectGridView";
         this.ProjectGridView.CellValidating += new Telerik.WinControls.UI.CellValidatingEventHandler(this.ProjectGridView_CellValidating);
         this.ProjectGridView.Initialized += new System.EventHandler(this.ProjectGridView_Initialize);
         // 
         // projectBindingSource
         // 
         this.projectBindingSource.DataSource = typeof(MiniboardModel.Models.Project);
         // 
         // AddProject
         // 
         this.AddProject.Location = new System.Drawing.Point(131, 40);
         this.AddProject.Name = "AddProject";
         this.AddProject.Size = new System.Drawing.Size(195, 20);
         this.AddProject.TabIndex = 4;
         this.AddProject.Text = "Add a Project";
         this.AddProject.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddProject_KeyPress);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(881, 437);
         this.Controls.Add(this.AddProject);
         this.Controls.Add(this.ProjectGridView);
         this.Controls.Add(this.AddPerson);
         this.Controls.Add(this.PeopleListView);
         this.Controls.Add(this.personBindingNavigator);
         this.Name = "Form1";
         this.Text = "radRibbonBar1";
         ((System.ComponentModel.ISupportInitialize)(this.personBindingNavigator)).EndInit();
         this.personBindingNavigator.ResumeLayout(false);
         this.personBindingNavigator.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.PeopleListView)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.ProjectGridView)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.BindingSource personBindingSource;
      private System.Windows.Forms.BindingNavigator personBindingNavigator;
      private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
      private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
      private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
      private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
      private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
      private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
      private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
      private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
      private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
      private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
      private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
      private System.Windows.Forms.ToolStripButton personBindingNavigatorSaveItem;
      private System.Windows.Forms.BindingSource projectBindingSource;
      private Telerik.WinControls.UI.RadListView PeopleListView;
      private Telerik.WinControls.RootRadElement object_2d8b3bc5_7757_49f0_b696_d79944cf08d1;
      private Telerik.WinControls.RootRadElement object_9d1e0f44_8bdc_4484_851b_5381c7c7950d;
      private Telerik.WinControls.RootRadElement object_4ad4b03b_7b55_4b05_97f9_8d139921fb73;
      private System.Windows.Forms.TextBox AddPerson;
      private Telerik.WinControls.UI.RadGridView ProjectGridView;
      private System.Windows.Forms.TextBox AddProject;
      private Telerik.WinControls.UI.RadGridView MasterTemplate;
   }
}

