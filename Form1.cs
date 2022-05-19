using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Registration_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fname, lname, email, uname, add, course,dob;
            fname = textBox1.Text;
            lname = textBox2.Text;
            email = textBox3.Text;
            uname = textBox4.Text;
            add = textBox5.Text;
            course = comboBox4.Text;
            dob = dateTimePicker1.Text;

            string ConnectionString = "Data Source=ASHISHALF\\SQLEXPRESS;Initial Catalog=MyDB;Integrated Security=True";

            SqlConnection con = new SqlConnection(ConnectionString);

            con.Open();
            
            string query = "INSERT INTO data (FirstName, LastName, Email, College, Address, Course,DOB) VALUES ('" + fname + "','" + lname + "','" + email + "','" + uname + "','" + add + "','" + course + "','" + dob + "')";
           
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            
            con.Close();
            MessageBox.Show("Data Saved");
           
        }

        private void fname_validation(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "First Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, "");
            }
        }

        private void lname_validation(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                e.Cancel = true;
                textBox2.Focus();
                errorProvider1.SetError(textBox2, "Last Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox2, "");
            }
        }

        private void add_validation(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                e.Cancel = true;
                textBox5.Focus();
                errorProvider1.SetError(textBox5, "Address should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox5, "");
            }
        }

        private void uname_validation(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                e.Cancel = true;
                textBox4.Focus();
                errorProvider1.SetError(textBox4, "University Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox4, "");
            }
        }

        private void email_validation(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                e.Cancel = true;
                textBox3.Focus();
                errorProvider1.SetError(textBox3, "Email Id should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox3, "");
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            comboBox4.Text = " ";
            //dateTimePicker1.Text = " ";
        }
    }
}
