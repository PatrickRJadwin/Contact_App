using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Contacts_App
{
    public partial class AddNew : Form
    {
        private Form1 form1;
        public List<int> numbers = new List<int>() { 0 };
        
        public AddNew(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
            form1.connect_DB();
            form1.conn.Open();
            string sql = "SELECT \"Contact_ID\" FROM \"Contact\".\"Contacts\"";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, form1.conn);
            NpgsqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                numbers.Add(rdr.GetInt32(0));
            }
            Console.WriteLine(numbers.Count);
            form1.conn.Close();
        }

        private void accpt_Click(object sender, EventArgs e)
        {
            int num = numbers.Count;
            string sql = "INSERT INTO \"Contact\".\"Contacts\" VALUES ('"
                 + num + "','" + fName.Text + "','" + lName.Text + "','" + dob.Text + "','" + addr.Text + "','" + phone.Text + "','" 
                + email.Text + "','" + note.Text + "')";
            form1.connect_DB();
            form1.conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(sql, form1.conn);
            cmd.ExecuteNonQuery();
            form1.conn.Close();
            form1.fillList(form1.conn);
            Console.WriteLine(numbers.Count);
            form1.numbers.Add(numbers.Count);
            Close();
        }
        
    }
}
