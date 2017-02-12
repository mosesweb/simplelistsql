using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UppgiftSphinxly
{
    public partial class ProduktkatalogForm : Form
    {
        ShowData showdata = new ShowData();

        public ProduktkatalogForm()
        {
            InitializeComponent();
            showdata.LoadSQL();
            listBox1.DataSource = showdata.list;
            listBox1.DisplayMember = "Name";
            ShowHiddenAdd();

            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (showdata.list.Count > 0)
            {
                var selectedArticle = listBox1.SelectedItem as Article;
                int lastindex = listBox1.SelectedIndex;
                //showdata.ClearList();
                showdata.DeleteRow(selectedArticle.Name); // ta bort row från databasen
                showdata.list.Clear(); // ta bort alla article items från listan
                showdata.LoadSQL(); // ladda in alla igen
                showdata.list.ResetBindings();
                if (showdata.list.Count != 0)
                {
                    if (lastindex != 0)
                    {
                        listBox1.SetSelected(lastindex - 1, true);
                    }
                    else {
                        listBox1.SetSelected(0, true);
                    }
                }
            }
            else
            {
                MessageBox.Show("Inga artiklar att ta bort.");
            }
            ShowHiddenAdd();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedArticle = listBox1.SelectedItem as Article;
            label1.Text = "Produkt: " + selectedArticle.Name;
            textBox1.Text = selectedArticle.Description;
            label2.Text = "Pris: " + selectedArticle.Price + " SEK";
            label3.Text = "Unikt ID: " + selectedArticle.ID;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            label4.Text = "";
            showdata.list.Clear(); // ta bort alla article items från listan
            showdata.AddRecords(); // ladda in alla igen
            showdata.list.ResetBindings();
            listBox1.SetSelected(0, true); // Gör så att listBox1_SelectedIndexChanged körs


        }
        private void EmptyLabels()
        {
            label1.Text = "Produkt: ";
            label2.Text = "Pris: ";
            label3.Text = "Unikt ID: ";
            textBox1.Text = "";
        }
        private void ShowHiddenAdd()
        {
            /* Kolla om det är slut på produkter. Isåfall visa knapp och meddelande*/
            if (showdata.list.Count == 0)
            {
                label4.Text = "Klicka på Fyll på för att fylla på med nya produkter";
                EmptyLabels();
                button2.Visible = true;
                
            }
            else
            {
                button2.Visible = false;
                label4.Text = "";
            }
        }
    }
}
