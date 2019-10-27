using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.models
{
    class Filiere
    {
        private String id;
        private String nomFiliere;

        public Filiere(string id, string nomFiliere)
        {
            this.id = id;
            this.NomFiliere = nomFiliere;
        }

        public string Id { get => id; set => id = value; }
        public string NomFiliere { get => nomFiliere; set => nomFiliere = value; }
    }
}
