using Project.models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        DataTable table;
        ClassLinqDataContext dataContext;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void filiere_Click(object sender, EventArgs e)
        {

        }
 
        private void loadData()
        {
            //this is a data source whoch contains columns and rows that we will insert in our data grid view
            //adding columns
            table = new DataTable();
            table.Columns.Add("id_filiere", typeof(int));
            table.Columns.Add("nom_filiere", typeof(string));
            //fetching data from filiere table using linq commands
            var x = from c in dataContext.filiere
                    select c;
            // looping on X whoch contains elements selected from database
            foreach (var i in x)
            {
                table.Rows.Add(i.Id_filiere, i.Nom_filiere);
            }
            //asigning datatable to the gridview 
            dataGridView1.DataSource = table;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //here we are instanciating our source of data in other word our database
            dataContext = new ClassLinqDataContext();
            loadData();

        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            var data = new ClassLinqDataContext();
            var filiere = new filiere();
            if (filiere_name.Text.Equals(""))
            {
                message.Text = "invalid input, please insert a name";
            }
            else
            {
                filiere.Nom_filiere = filiere_name.Text;
                data.filiere.InsertOnSubmit(filiere);
                data.SubmitChanges();
                table.Rows.Add(filiere.Id_filiere, filiere.Nom_filiere);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Filiere fil;
            String newfiliere="z";
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                //string nom_filiere = Convert.ToString(selectedRow.Cells["nom_filiere"].Value);
                using (updateFiliere update = new updateFiliere(Convert.ToString(selectedRow.Cells["nom_filiere"].Value)))
                {
                    if (update.ShowDialog() == DialogResult.OK)
                    {
                        newfiliere = update.text;
                    }
                }
                string nom_filiere = (newfiliere);
                message.Text = newfiliere;
                int id_filiere = Convert.ToInt32(selectedRow.Cells["id_filiere"].Value);
                fil= new Filiere(id_filiere,nom_filiere);
     
                var x = (from c in dataContext.filiere
                         where c.Id_filiere == fil.Id
                         select c).SingleOrDefault();
                x.Id_filiere = fil.Id;
                x.Nom_filiere = fil.NomFiliere;
                dataContext.SubmitChanges();
                loadData();
                dataGridView1.Update();
                dataGridView1.Refresh();
            }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Update the labels to reflect changes to the selection.
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                string a = Convert.ToString(selectedRow.Cells["nom_filiere"].Value);
                filiere_name.Text = a;


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Filiere fil;
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                //string nom_filiere = Convert.ToString(selectedRow.Cells["nom_filiere"].Value);
                string nom_filiere = Convert.ToString(selectedRow.Cells["id_filiere"].Value);
                int id_filiere = Convert.ToInt32(selectedRow.Cells["id_filiere"].Value);
                fil = new Filiere(id_filiere, nom_filiere);

                var x = (from c in dataContext.filiere
                         where c.Id_filiere == fil.Id
                         select c).SingleOrDefault();
                dataContext.filiere.DeleteOnSubmit(x);
                dataContext.SubmitChanges();
                loadData();
                dataGridView1.Update();
                dataGridView1.Refresh();
            }
        }
        //this func fill the combo box in the etudiant page 
        private void FillSearchByCneBox1()
        {
            //SchoolDbDataContext data = new SchoolDbDataContext();
            //var x = from c in data.Etudiants select c;
            //foreach (var i in x)
            //{
            //    searchByCneBox1.Items.Add(i.cne);
            //}

        }
        private void Etudiant_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
