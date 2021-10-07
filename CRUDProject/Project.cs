using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDProject
{
    class Project
    {
        public int _projectsId { get; set; }
        public string _startP { get; set; }
        public string _finishP { get; set; }
        public string _descriptionP { get; set; }


        public Project()
        {
            
        }

        public Project(int projectsId, string start, string finish, string description)
        {
            _projectsId = projectsId;
            _startP = start;
            _finishP = finish;
            _descriptionP = description;
        }

        public string getProjectInfo()
        {
            return " ID: " + _projectsId + " Inicio: " + _startP +
                " Final: " + _finishP + " Descripcion: " + _descriptionP;
        }

        public string getInfo()
        {
            return " ID: " + _projectsId + " Inicio: " + _startP +
                " Final: " + _finishP + " Descripcion: " + _descriptionP;
        }
    }

}
