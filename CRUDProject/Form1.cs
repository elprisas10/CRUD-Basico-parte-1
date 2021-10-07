using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Project projects = new Project();
            projects._projectsId = 1;
            projects._startP = "fecha de que inicia el proyecto:5/10/2021";
            projects._finishP = "fecha en la que finaliza el proyecto:6/10/2021";
            projects._descriptionP = "projecto de programacion sobre CRUD basico parte 1";

            lstProjectInfo.Items.Add(projects.getInfo());
        }

        private void button2_Click(object sender, EventArgs e)
        {
        
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Project projects = new Project();
            projects._projectsId = Convert.ToInt32(textprojectId.Text);
            projects._startP = textProjectStart.Text;
            projects._finishP = textProjectFinish.Text;
            projects._descriptionP = textProjectDescription.Text;

            lstProjectInfo.Items.Add(projects.getProjectInfo());
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
