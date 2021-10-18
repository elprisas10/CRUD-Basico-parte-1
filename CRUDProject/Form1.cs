using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRUDProject
{
    public partial class Form1 : Form
    {
        private string action = "";
        public Form1()

        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabs.TabPages.Remove(tabForm);

            fillDataGridView();
            controlsDisable();

       


           
           
        
        }


        public void fillDataGridView()
        {
            Project project = new Project();



            dtgProjects.Columns.Add("projectId", "PROJECT ID");
            dtgProjects.Columns.Add("start", "START");
            dtgProjects.Columns.Add("finish", "FINISH");
            dtgProjects.Columns.Add("description", "DESCRIPTION");

            MySqlDataReader dataReader = project.getAllProjects();

            while(dataReader.Read())
            {
                dtgProjects.Rows.Add(dataReader.GetValue(0), dataReader.GetValue(1), dataReader.GetValue(2), dataReader.GetValue(3));
            }

        }

        public void clearDataGridView()
        {
            dtgProjects.Columns.Clear();
            dtgProjects.Rows.Clear();
        }


        public void controlsDisable()
        {
            txtId.Enabled = false;
            txtStart.Enabled = false;
            txtFinish.Enabled = false;
            txtDescription.Enabled = false;
        }

        public void controlsEnable()
        {
            txtId.Enabled = false;
            txtStart.Enabled = true;
            txtFinish.Enabled = true;
            txtDescription.Enabled = true;
        }

        public void clearControls()
        {
            txtId.Text = "";
            txtStart.Text = "";
            txtFinish.Text = "";
            txtDescription.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
        
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lstProjectInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void dtgProject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
          
            

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabForm_Click(object sender, EventArgs e)
        {

        }

        private void dtgProjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            tabs.TabPages.Remove(tabForm);
            tabs.TabPages.Add(ProjectList);
            tabs.TabPages[0].Text = "EDIT PROJECT";

            action = "edit";
            controlsEnable();
            

            txtId.Visible = true;
            txtId.ReadOnly = true;
            metroLabel2.Visible = true;
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            tabs.TabPages.Add(tabForm);
            tabs.TabPages.Remove(ProjectList);
            tabs.TabPages[0].Text = "NEW PROJECT";

            txtId.Visible = false;
            txtStart.Focus();
            action = "new";
            controlsEnable();
            clearControls();
           
        }

        private void edit_Click(object sender, EventArgs e)
        {
            tabs.TabPages.Remove(ProjectList);
            tabs.TabPages.Add(tabForm);
            tabs.TabPages[0].Text = "EDIT PROJECT";
            controlsEnable();

            txtId.Visible = true;
            txtId.ReadOnly = true;

            txtId.Text = dtgProjects.CurrentRow.Cells[0].Value.ToString();
            txtStart.Text = dtgProjects.CurrentRow.Cells[1].Value.ToString();
            txtFinish.Text = dtgProjects.CurrentRow.Cells[2].Value.ToString();
            txtDescription.Text = dtgProjects.CurrentRow.Cells[3].Value.ToString();

            action = "edit";
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (txtStart.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Debe escribir el titulo", "VALIDACION",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStart.Focus();
            }
            else
            {
                Project project = new Project();
                if (action == "edit")
                {
                    project._projectsId = Convert.ToInt32(txtId.Text);
                }
                project._startP = txtStart.Text;
                project._finishP = txtStart.Text;
                project._descriptionP = txtDescription.Text;

                string mensaje = "Esta seguro que desea guardar el registro?";
                if (MetroFramework.MetroMessageBox.Show(this, mensaje, "CONFIRMACION",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    if (project.newEditProject(action))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Los datos se han guardado exitosamente",
                            "CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        MetroFramework.MetroMessageBox.Show(this, "Los datos  no se han guardado",
                            "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    clearControls();
                    controlsDisable();
                    fillDataGridView();
                    tabs.TabPages.Remove(tabForm);
                    tabs.TabPages.Add(ProjectList);
                    tabs.TabPages[0].Text = "PROJECT LIST";
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Desea cancelar?";
            if (MetroFramework.MetroMessageBox.Show(this, mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                clearControls();
                controlsDisable();


                tabs.TabPages.Remove(tabForm);
                tabs.TabPages.Add(ProjectList);
                tabs.TabPages[0].Text = "PROJECT LIST";
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Desea salir?";
            if (MetroFramework.MetroMessageBox.Show(this, mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void delateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mensaje = "Esta seguro que desea eliminar el registro?";
            if (MetroFramework.MetroMessageBox.Show(this, mensaje, "CONFIRMACION",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Project project = new Project();
                project._projectsId = Convert.ToInt32(dtgProjects.CurrentRow.Cells[0].Value);

                if (project.deleteProject())
                {
                    MetroFramework.MetroMessageBox.Show(this, "Los datos se han eliminado exitosamente!",
                       "CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    fillDataGridView();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Los datos  no se han podido eliminar",
                      "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
