using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phonebook1
{
    public partial class Form1 : Form
    {
        DataTable contacts = new DataTable();
        bool editing = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            imetextBox.Text = contacts.Rows[contactsDataGrid.CurrentCell.RowIndex].ItemArray[0].ToString();
            prezimetextBox.Text = contacts.Rows[contactsDataGrid.CurrentCell.RowIndex].ItemArray[1].ToString();
            telefontextBox.Text = contacts.Rows[contactsDataGrid.CurrentCell.RowIndex].ItemArray[2].ToString();
            emailtextBox.Text = contacts.Rows[contactsDataGrid.CurrentCell.RowIndex].ItemArray[3].ToString();
            editing = true;
        }

        private void newbutton_Click(object sender, EventArgs e)
        {
            imetextBox.Text = "";
            prezimetextBox.Text = "";
            telefontextBox.Text = "";
            emailtextBox.Text = "";
           
        }

        private void loadbutton_Click(object sender, EventArgs e)
        {
            imetextBox.Text = contacts.Rows[contactsDataGrid.CurrentCell.RowIndex].ItemArray[0].ToString();
            prezimetextBox.Text = contacts.Rows[contactsDataGrid.CurrentCell.RowIndex].ItemArray[1].ToString();
            telefontextBox.Text = contacts.Rows[contactsDataGrid.CurrentCell.RowIndex].ItemArray[2].ToString();
            emailtextBox.Text = contacts.Rows[contactsDataGrid.CurrentCell.RowIndex].ItemArray[3].ToString();
           
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                contacts.Rows[contactsDataGrid.CurrentCell.RowIndex]["Ime"] = imetextBox.Text;
                contacts.Rows[contactsDataGrid.CurrentCell.RowIndex]["Prezime"] = prezimetextBox.Text;
                contacts.Rows[contactsDataGrid.CurrentCell.RowIndex]["Telefon"] = telefontextBox.Text;
                contacts.Rows[contactsDataGrid.CurrentCell.RowIndex]["E-mail"] = emailtextBox.Text;
            }
            else
            {
                contacts.Rows.Add(imetextBox.Text, prezimetextBox.Text, telefontextBox.Text,emailtextBox.Text);
            }
            imetextBox.Text = "";
            prezimetextBox.Text = "";
            telefontextBox.Text = "";
            emailtextBox.Text = "";
           
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                contacts.Rows[contactsDataGrid.CurrentCell.RowIndex].Delete();
            }
            catch(Exception ex) { Console.WriteLine("Not a valid row"); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contacts.Columns.Add("Ime");
            contacts.Columns.Add("Prezime");
            contacts.Columns.Add("Telefon");
            contacts.Columns.Add("E-mail");
            contactsDataGrid.DataSource = contacts;

        }
    }
}
