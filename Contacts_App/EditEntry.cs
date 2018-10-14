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
    public partial class EditEntry : Form
    {
        private Form1 form1;
        int num;

        public EditEntry(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;

            fName.Text = form1.query[form1.listView1.FocusedItem.Index][0].ToString();
            lName.Text = form1.query[form1.listView1.FocusedItem.Index][1].ToString();
            dob.Text = form1.query[form1.listView1.FocusedItem.Index][2].ToString();
            addr.Text = form1.query[form1.listView1.FocusedItem.Index][3].ToString();
            phone.Text = form1.query[form1.listView1.FocusedItem.Index][4].ToString();
            email.Text = form1.query[form1.listView1.FocusedItem.Index][5].ToString();
            note.Text = form1.query[form1.listView1.FocusedItem.Index][6].ToString();

            num = form1.numbers[form1.listView1.FocusedItem.Index];

            Console.WriteLine(num);
            
        }

        private void accpt_Click(object sender, EventArgs e)
        {
            form1.connect_DB();
            form1.conn.Open();
            string sql = "UPDATE \"Contact\".\"Contacts\"" 
                + "SET \"Contact_ID\" = " + num + ", \"First Name\" = '" + fName.Text + "', \"Last Name\" = '" + lName.Text + "', \"Date of Birth\" = '" + dob.Text + "'," 
                + "\"Address\" = '" + addr.Text + "', \"Phone #\" = '" + phone.Text + "', \"Email\" = '" + email.Text + "', \"notes\" = '" + note.Text + "' " 
                + "WHERE \"Contact_ID\" = " + num;
            NpgsqlCommand cmd = new NpgsqlCommand(sql, form1.conn);
            cmd.ExecuteNonQuery();
            form1.conn.Close();
            form1.fillList(form1.conn);
            form1.listBox1.Items.Clear();
            Close();
        }
    }
}
