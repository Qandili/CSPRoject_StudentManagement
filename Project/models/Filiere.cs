using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.models
{
    class Filiere
    {
        private int id;
        private String nomFiliere;

        public Filiere(int id, string nomFiliere)
        {
            this.id = id;
            this.NomFiliere = nomFiliere;
        }

        public int Id { get => id; set => id = value; }
        public string NomFiliere { get => nomFiliere; set => nomFiliere = value; }
    }
}
