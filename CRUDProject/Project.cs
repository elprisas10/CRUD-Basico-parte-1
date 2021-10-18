using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CRUDProject
{
    class Project
    {
        public int _projectsId { get; set; }
        public string _startP { get; set; }
        public string _finishP { get; set; }
        public string _descriptionP { get; set; }


       

        //instancias de la clase Crud
        private Crud crud = new Crud();

        //metodo para retornar los registros de la tabla project
        public MySqlDataReader getAllProjects()
        {
            string query = "SELECT projectId,startProject,finishProject,descriptionProject FROM project";

            //llamado al metodo select de la clase Crud
            return crud.select(query);
        }
        
        public Boolean newEditProject(string action)
        {
            if (action == "new" )
            {
                string query = "INSERT INTO project(startProject,finishProject,descriptionProject) VALUES" +
                    "('" + _startP + "', '" + _finishP + "', '" + _descriptionP + "')";
                crud.executeQuery(query);
                return true;
            }
            else if (action == "edit")
            {
                string query = "UPDATE project SET" +
                    "startProject='" + _startP +
                    "',finishProject='" + _finishP +
                    "',descriptionProject='" + _descriptionP + "'" +
                    "WHERE "+ 
                    "projectId='" + _projectsId + "'";
                crud.executeQuery(query);
                return true;
            }
            return false;

        }


        public Boolean deleteProject()
        {
            string query = "DELETE FROM project WHERE projectId='" + _projectsId + "'";
            crud.executeQuery(query);
            return true;
        }
    }

}
