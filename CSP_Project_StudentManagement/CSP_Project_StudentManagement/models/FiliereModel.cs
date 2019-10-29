using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP_Project_StudentManagement.models
{
    class FiliereModel
    {
        private int id;
        private String nomFiliere;

        public FiliereModel(int id, string nomFiliere)
        {
            this.id = id;
            this.NomFiliere = nomFiliere;
        }

        public int Id { get => id; set => id = value; }
        public string NomFiliere { get => nomFiliere; set => nomFiliere = value; }
    }
}
