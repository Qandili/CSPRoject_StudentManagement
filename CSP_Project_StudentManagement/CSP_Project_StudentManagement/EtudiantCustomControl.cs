using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSP_Project_StudentManagement
{
    public partial class EtudiantCustomControl : UserControl
    {
        StudentDataClasseDataContext dataContext;
        public EtudiantCustomControl()
        {
            InitializeComponent();
        }
        private void EtudiantCustomControl_Load(object sender, EventArgs e)
        {
            FillSearchByCneBox1();
            FillSearchByFiliere();
        }
        private void FillSearchByCneBox1()
        {
            dataContext = new StudentDataClasseDataContext();
            var x = from c in dataContext.Students select c;
            foreach (var i in x)
            {
                searchByCneBox1.Items.Add(i.cne);
            }
            searchByCneBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            searchByCneBox1.AutoCompleteSource = AutoCompleteSource.ListItems;

        }
        private void FillSearchByFiliere()
        {
            dataContext = new StudentDataClasseDataContext();
            var x = from f in dataContext.Filieres select f;
            foreach (var i in x)
            {
                comboBoxFiliere.Items.Add(i.Nom_filiere);
            }

            comboBoxFiliere.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxFiliere.AutoCompleteSource = AutoCompleteSource.ListItems;

        }
        private void button7_Click(object sender, EventArgs e)
        {

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void searchByCneBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataContext = new StudentDataClasseDataContext();
            //selectionner les donnees de la personne choisie dans comboBox
            var x = (from t in dataContext.Students
                     join f in dataContext.Filieres on
                     t.id_fil equals f.Id_filiere
                     where t.cne.ToString() == searchByCneBox1.Text
                     select new { t.cne, t.nom, t.prenom, t.sexe, t.date_naiss, t.adresse, t.telephone, f.Nom_filiere }).SingleOrDefault();
            textBox1.Text = x.cne.ToString();
            textBox2.Text = x.nom;
            textBox3.Text = x.prenom;
            if (x.sexe == 'F') radioButton1.Focus();
            else radioButton2.Focus();
            dateTimePicker1.Value = (DateTime)x.date_naiss;
            textBox4.Text = x.adresse;
            textBox5.Text = x.telephone;
            comboBoxFiliere.Text = x.Nom_filiere;


        }
    }
}
