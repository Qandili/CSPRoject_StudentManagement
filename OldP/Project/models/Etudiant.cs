using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.models
{
    class Etudiant
    {
        private String id;
        private String cne;
        private String nom;
        private String prenom;
        private String sexe;
        private DateTime datedenaissance;
        private String adresse;
        private long telephone;
        private int id_filiere;

        public Etudiant(string id, string cne, string nom, string prenom, string sexe, DateTime datedenaissance, string adresse, long telephone,int id_filiere)
        {
            this.id = id;
            this.cne = cne;
            this.nom = nom;
            this.prenom = prenom;
            this.sexe = sexe;
            this.datedenaissance = datedenaissance;
            this.adresse = adresse;
            this.telephone = telephone;
            this.id_filiere=id_filiere;

        }

        public string Id { get => id; set => id = value; }
        public string Cne { get => cne; set => cne = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Sexe { get => sexe; set => sexe = value; }
        public DateTime Datedenaissance { get => datedenaissance; set => datedenaissance = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public long Telephone { get => telephone; set => telephone = value; }
        public int Id_filiere { get => id_filiere; set => id_filiere = value; }
    }
}
