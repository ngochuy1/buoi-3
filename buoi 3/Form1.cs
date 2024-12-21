using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buoi_3
{
    public partial class Form1 : Form
    {
        private List<Nguoi> people;
        public Form1()
        {
            InitializeComponent();
            people = new List<Nguoi>();
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            people.Add(new Nguoi("Nguyen", "Anh", "0123456789"));
            people.Add(new Nguoi("Tran", "Bao", "0987654321"));
            people.Add(new Nguoi("Le", "Minh", "0234567890"));
            people.Add(new Nguoi("Pham", "Hieu", "0345678901"));
            foreach (var person in people)
            {
                dataGridView1.Rows.Add(person.LastName, person.FirstName, person.Phone);
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string lastName = txtLN.Text;  
            string firstName = txtfn.Text; 
            string phone = txtp.Text;   

            people.Add(new Nguoi(lastName, firstName, phone));

            dataGridView1.Rows.Add(lastName, firstName, phone);

            txtLN.Clear();
            txtfn.Clear();
            txtp.Clear();
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                string lastName = txtLN.Text;
                string firstName = txtfn.Text;
                string phone = txtp.Text;
                people[index].LastName = lastName;
                people[index].FirstName = firstName;
                people[index].Phone = phone;
                dataGridView1.SelectedRows[0].Cells[0].Value = lastName;
                dataGridView1.SelectedRows[0].Cells[1].Value = firstName;
                dataGridView1.SelectedRows[0].Cells[2].Value = phone;
            }
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                people.RemoveAt(index);
                dataGridView1.Rows.RemoveAt(index);
            }
        }
    }
}
