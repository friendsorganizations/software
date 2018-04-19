using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_software
{
    public partial class stock : Form
    {
        public stock()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 m = new Form1();
            this.Hide();
            m.Show();
        }
        DataTable t = new DataTable();
        int selected_row;
        private void stock_Load(object sender, EventArgs e)
        {
            sellToolStripMenuItem.Enabled = false;
            t.Columns.Add("Name", typeof(string));
            t.Columns.Add("Formula", typeof(string));
            t.Columns.Add("Type", typeof(string));
            t.Columns.Add("Quantity", typeof(int));
            t.Columns.Add("Price", typeof(int));
            t.Columns.Add("Expiry date", typeof(string));
            dataGridView1.DataSource = t;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dial = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dial == DialogResult.Yes)
            {
                Application.Exit();
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            bool prc_spec = true;
            bool qn_spec = true;
            bool exp_spec = true;
            localhost.Service1 s = new localhost.Service1();
            s.add(textBox1.Text, comboBox1.Text, textBox2.Text, int.Parse(textBox10.Text), prc_spec, int.Parse(textBox9.Text),qn_spec, DateTime.Parse(dateTimePicker1.Text), exp_spec);
            t.Rows.Add(textBox1.Text, textBox2.Text, comboBox1.Text, int.Parse(textBox9.Text), int.Parse(textBox10.Text), dateTimePicker1.Value);


            MessageBox.Show("Product added ");
          
            


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            selected_row=dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(selected_row);
          
          
            localhost.Service1 w = new localhost.Service1();
            string nm = dataGridView1.Rows[selected_row].Cells[0].ToString();
            string tp = dataGridView1.Rows[selected_row].Cells[2].ToString();
            w.delete_product(tp, nm);
            MessageBox.Show("Deleted successfully");


           
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            DataGridViewRow r = dataGridView1.Rows[selected_row];
       
         r.Cells[3].Value = textBox4.Text;
            r.Cells[4].Value = textBox3.Text;
    
        }

        private void cmdCellClick(object sender, DataGridViewCellEventArgs e)
        {
            selected_row = e.RowIndex;
            DataGridViewRow r = dataGridView1.Rows[selected_row];
      
            textBox4.Text = r.Cells[3].Value.ToString();
            textBox3.Text = r.Cells[4].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
       

        }
    }
}
