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
    public partial class Form1 : Form
    {
        public NpgsqlConnection conn;
        public List<int> ids = new List<int>();
        public Form1()
        {
            InitializeComponent();
            connect_DB();
            fillList(conn);
            conn.Close();
        }
        public void connect_DB()
        {
            string connstring = "Server=127.0.0.1; Port=5432; User ID=postgres; Password=irobot97; Database=Contacts;";
            conn = new NpgsqlConnection(connstring);
            conn.Open();
        }
        public void fillList(NpgsqlConnection conn)
        {
            string sql = "SELECT \"Contact_ID\", \"First Name\", \"Last Name\" FROM \"Contact\".\"Contacts\"";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
            NpgsqlDataReader rdr = cmd.ExecuteReader();
            listView1.Items.Clear();
            while (rdr.Read())
            {
                ListViewItem lv = new ListViewItem(rdr.GetInt32(0).ToString());
                ids.Add(rdr.GetInt32(0));
                lv.SubItems.Add(rdr.GetString(1).ToString());
                lv.SubItems.Add(rdr.GetString(2).ToString());
                listView1.Items.Add(lv);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connstring = "Server=127.0.0.1; Port=5432; User ID=postgres; Password=irobot97; Database=Contacts;";
                conn = new NpgsqlConnection(connstring);
                conn.Open();
                string sql = "SELECT \"Contact_ID\", \"First Name\", \"Last Name\", \"Date of Birth\", \"Address\", \"Phone #\", \"Email\" FROM \"Contact\".\"Contacts\" WHERE \"Contact_ID\" = " + listView1.SelectedIndices; 
                
                List<string> entries = new List<string>() { "First Name: ", "Last Name: ", "Date of Birth: ", "Address: ", "Phone #: ", "Email: " };

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                NpgsqlDataReader rdr = cmd.ExecuteReader();

                listBox1.Items.Clear();
                while (rdr.Read())
                {
                    Console.Write(rdr.GetString(1).ToString());
                    Console.Write(rdr.GetString(2).ToString());
                    Console.Write(rdr.GetString(3).ToString());
                    Console.Write(rdr.GetString(4).ToString());
                    Console.Write(rdr.GetString(5).ToString());
                    Console.Write(rdr.GetString(6).ToString());
                }
                conn.Close();
            }
            catch (NpgsqlException)
            {
                MessageBox.Show(System.Environment.StackTrace.ToString(), "Err");
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show(System.Environment.StackTrace.ToString(), "Err");
            }
        }
    }
}
