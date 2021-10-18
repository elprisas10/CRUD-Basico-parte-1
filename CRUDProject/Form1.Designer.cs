
namespace CRUDProject
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabs = new MetroFramework.Controls.MetroTabControl();
            this.tabForm = new MetroFramework.Controls.MetroTabPage();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.txtDescription = new MetroFramework.Controls.MetroTextBox();
            this.txtFinish = new MetroFramework.Controls.MetroTextBox();
            this.txtStart = new MetroFramework.Controls.MetroTextBox();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.ProjectList = new MetroFramework.Controls.MetroTabPage();
            this.dtgProjects = new System.Windows.Forms.DataGridView();
            this.Action = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.edit = new System.Windows.Forms.ToolStripMenuItem();
            this.delateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.New = new MetroFramework.Controls.MetroLink();
            this.tabs.SuspendLayout();
            this.tabForm.SuspendLayout();
            this.ProjectList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProjects)).BeginInit();
            this.Action.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabForm);
            this.tabs.Controls.Add(this.ProjectList);
            this.tabs.Location = new System.Drawing.Point(43, 83);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(617, 330);
            this.tabs.TabIndex = 0;
            this.tabs.UseSelectable = true;
            // 
            // tabForm
            // 
            this.tabForm.Controls.Add(this.metroButton3);
            this.tabForm.Controls.Add(this.btnCancel);
            this.tabForm.Controls.Add(this.metroButton1);
            this.tabForm.Controls.Add(this.txtDescription);
            this.tabForm.Controls.Add(this.txtFinish);
            this.tabForm.Controls.Add(this.txtStart);
            this.tabForm.Controls.Add(this.txtId);
            this.tabForm.Controls.Add(this.metroLabel6);
            this.tabForm.Controls.Add(this.metroLabel5);
            this.tabForm.Controls.Add(this.metroLabel4);
            this.tabForm.Controls.Add(this.metroLabel3);
            this.tabForm.Controls.Add(this.metroLabel2);
            this.tabForm.HorizontalScrollbarBarColor = true;
            this.tabForm.HorizontalScrollbarHighlightOnWheel = false;
            this.tabForm.HorizontalScrollbarSize = 10;
            this.tabForm.Location = new System.Drawing.Point(4, 38);
            this.tabForm.Name = "tabForm";
            this.tabForm.Size = new System.Drawing.Size(609, 288);
            this.tabForm.TabIndex = 0;
            this.tabForm.Text = "ProjectForm";
            this.tabForm.VerticalScrollbarBarColor = true;
            this.tabForm.VerticalScrollbarHighlightOnWheel = false;
            this.tabForm.VerticalScrollbarSize = 10;
            this.tabForm.Click += new System.EventHandler(this.tabForm_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(520, 215);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(75, 23);
            this.metroButton3.TabIndex = 13;
            this.metroButton3.Text = "Exit";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(193, 215);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.SystemColors.Control;
            this.metroButton1.Location = new System.Drawing.Point(40, 215);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 11;
            this.metroButton1.Text = "Save";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // txtDescription
            // 
            // 
            // 
            // 
            this.txtDescription.CustomButton.Image = null;
            this.txtDescription.CustomButton.Location = new System.Drawing.Point(263, 1);
            this.txtDescription.CustomButton.Name = "";
            this.txtDescription.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescription.CustomButton.TabIndex = 1;
            this.txtDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescription.CustomButton.UseSelectable = true;
            this.txtDescription.CustomButton.Visible = false;
            this.txtDescription.Lines = new string[0];
            this.txtDescription.Location = new System.Drawing.Point(183, 153);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.ShortcutsEnabled = true;
            this.txtDescription.Size = new System.Drawing.Size(285, 23);
            this.txtDescription.TabIndex = 10;
            this.txtDescription.UseSelectable = true;
            this.txtDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFinish
            // 
            // 
            // 
            // 
            this.txtFinish.CustomButton.Image = null;
            this.txtFinish.CustomButton.Location = new System.Drawing.Point(263, 1);
            this.txtFinish.CustomButton.Name = "";
            this.txtFinish.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFinish.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFinish.CustomButton.TabIndex = 1;
            this.txtFinish.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFinish.CustomButton.UseSelectable = true;
            this.txtFinish.CustomButton.Visible = false;
            this.txtFinish.Lines = new string[0];
            this.txtFinish.Location = new System.Drawing.Point(183, 112);
            this.txtFinish.MaxLength = 32767;
            this.txtFinish.Name = "txtFinish";
            this.txtFinish.PasswordChar = '\0';
            this.txtFinish.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFinish.SelectedText = "";
            this.txtFinish.SelectionLength = 0;
            this.txtFinish.SelectionStart = 0;
            this.txtFinish.ShortcutsEnabled = true;
            this.txtFinish.Size = new System.Drawing.Size(285, 23);
            this.txtFinish.TabIndex = 9;
            this.txtFinish.UseSelectable = true;
            this.txtFinish.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFinish.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtStart
            // 
            // 
            // 
            // 
            this.txtStart.CustomButton.Image = null;
            this.txtStart.CustomButton.Location = new System.Drawing.Point(263, 1);
            this.txtStart.CustomButton.Name = "";
            this.txtStart.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStart.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStart.CustomButton.TabIndex = 1;
            this.txtStart.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStart.CustomButton.UseSelectable = true;
            this.txtStart.CustomButton.Visible = false;
            this.txtStart.Lines = new string[0];
            this.txtStart.Location = new System.Drawing.Point(183, 70);
            this.txtStart.MaxLength = 32767;
            this.txtStart.Name = "txtStart";
            this.txtStart.PasswordChar = '\0';
            this.txtStart.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStart.SelectedText = "";
            this.txtStart.SelectionLength = 0;
            this.txtStart.SelectionStart = 0;
            this.txtStart.ShortcutsEnabled = true;
            this.txtStart.Size = new System.Drawing.Size(285, 23);
            this.txtStart.TabIndex = 8;
            this.txtStart.UseSelectable = true;
            this.txtStart.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStart.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(263, 1);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(183, 30);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(285, 23);
            this.txtId.TabIndex = 7;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(67, 70);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(78, 19);
            this.metroLabel6.TabIndex = 6;
            this.metroLabel6.Text = "ProjectStart";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(67, 157);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(115, 19);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "ProjectDescription";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(67, 112);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(82, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "ProjectFinish";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(67, 70);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(0, 0);
            this.metroLabel3.TabIndex = 3;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(67, 35);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "ProjectId1";
            // 
            // ProjectList
            // 
            this.ProjectList.Controls.Add(this.dtgProjects);
            this.ProjectList.HorizontalScrollbarBarColor = true;
            this.ProjectList.HorizontalScrollbarHighlightOnWheel = false;
            this.ProjectList.HorizontalScrollbarSize = 10;
            this.ProjectList.Location = new System.Drawing.Point(4, 38);
            this.ProjectList.Name = "ProjectList";
            this.ProjectList.Size = new System.Drawing.Size(609, 288);
            this.ProjectList.TabIndex = 1;
            this.ProjectList.Text = "ProjectList";
            this.ProjectList.VerticalScrollbarBarColor = true;
            this.ProjectList.VerticalScrollbarHighlightOnWheel = false;
            this.ProjectList.VerticalScrollbarSize = 10;
            // 
            // dtgProjects
            // 
            this.dtgProjects.AllowUserToAddRows = false;
            this.dtgProjects.AllowUserToDeleteRows = false;
            this.dtgProjects.AllowUserToResizeColumns = false;
            this.dtgProjects.AllowUserToResizeRows = false;
            this.dtgProjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgProjects.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dtgProjects.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtgProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProjects.ContextMenuStrip = this.Action;
            this.dtgProjects.Location = new System.Drawing.Point(19, 13);
            this.dtgProjects.MultiSelect = false;
            this.dtgProjects.Name = "dtgProjects";
            this.dtgProjects.ReadOnly = true;
            this.dtgProjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProjects.Size = new System.Drawing.Size(578, 272);
            this.dtgProjects.TabIndex = 2;
            this.dtgProjects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProjects_CellContentClick);
            // 
            // Action
            // 
            this.Action.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edit,
            this.delateToolStripMenuItem});
            this.Action.Name = "Action";
            this.Action.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Action.ShowImageMargin = false;
            this.Action.Size = new System.Drawing.Size(83, 48);
            this.Action.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Action.Text = "action";
            this.Action.UseCustomBackColor = true;
            this.Action.UseCustomForeColor = true;
            this.Action.UseStyleColors = true;
            this.Action.UseWaitCursor = true;
            // 
            // edit
            // 
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(82, 22);
            this.edit.Text = "edit";
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // delateToolStripMenuItem
            // 
            this.delateToolStripMenuItem.Name = "delateToolStripMenuItem";
            this.delateToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.delateToolStripMenuItem.Text = "Delate";
            this.delateToolStripMenuItem.Click += new System.EventHandler(this.delateToolStripMenuItem_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(43, 48);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(64, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "PROJECT";
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(114, 48);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(123, 23);
            this.New.TabIndex = 2;
            this.New.Text = "New Project";
            this.New.UseSelectable = true;
            this.New.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.New);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tabs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabs.ResumeLayout(false);
            this.tabForm.ResumeLayout(false);
            this.tabForm.PerformLayout();
            this.ProjectList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProjects)).EndInit();
            this.Action.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabs;
        private MetroFramework.Controls.MetroTabPage tabForm;
        private MetroFramework.Controls.MetroTextBox txtDescription;
        private MetroFramework.Controls.MetroTextBox txtFinish;
        private MetroFramework.Controls.MetroTextBox txtStart;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTabPage ProjectList;
        private System.Windows.Forms.DataGridView dtgProjects;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLink New;
        private MetroFramework.Controls.MetroContextMenu Action;
        private System.Windows.Forms.ToolStripMenuItem edit;
        private System.Windows.Forms.ToolStripMenuItem delateToolStripMenuItem;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}

