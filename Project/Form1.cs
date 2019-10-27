using System;
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
 
        private void Form1_Load(object sender, EventArgs e)
        {
            //here we are instanciating our source of data in other word our database
            var data = new ClassLinqDataContext();
            //this is a data source whoch contains columns and rows that we will insert in our data grid view
            //adding columns
            table = new DataTable();
            table.Columns.Add("id_filiere", typeof(int));
            table.Columns.Add("nom_filiere", typeof(string));
            //fetching data from filiere table using linq commands
            var x = from c in data.filiere
                    select c;
            // looping on X whoch contains elements selected from database
            foreach (var i in x)
            {
                table.Rows.Add(i.Id_filiere, i.Nom_filiere);
            }
           //asigning datatable to the gridview 
            dataGridView1.DataSource = table;

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
    }
}
