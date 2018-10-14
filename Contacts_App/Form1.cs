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
        public List<List<object>> query = new List<List<object>>();
        public List<int> numbers = new List<int>();
        public List<string> listBoxTxt = new List<string>() { "First Name: " , "Last Name: " , "Date of Birth: " , "Address: " , "Phone #: " , "Email: " , "Note: "};
        public Form1()
        {
            InitializeComponent();
            connect_DB();
            fillList(conn);
            
        }
        public void connect_DB()
        {
            string connstring = "Server=127.0.0.1; Port=5432; User ID=postgres; Password=irobot97; Database=Contacts;";
            conn = new NpgsqlConnection(connstring);
        }
        public void fillList(NpgsqlConnection conn)
        {
            conn.Open();
            string sql = "SELECT * FROM \"Contact\".\"Contacts\" ORDER BY \"Contact_ID\" ASC";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
            NpgsqlDataReader rdr = cmd.ExecuteReader();
            listView1.Items.Clear();
            query.Clear();
            while (rdr.Read())
            {
                List<object> tempList = new List<object>();
                numbers.Add(rdr.GetInt32(0));
                ListViewItem lv = new ListViewItem(rdr.GetInt32(0).ToString());
                lv.SubItems.Add(rdr.GetString(1).ToString());
                tempList.Add(rdr.GetString(1).ToString());
                lv.SubItems.Add(rdr.GetString(2).ToString());
                tempList.Add(rdr.GetString(2));
                tempList.Add(rdr.GetString(3));
                tempList.Add(rdr.GetString(4));
                tempList.Add(rdr.GetString(5));
                tempList.Add(rdr.GetString(6));
                tempList.Add(rdr.GetString(7));
                listView1.Items.Add(lv);
                query.Add(tempList);
            }
            conn.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(query[listView1.FocusedItem.Index].Count);
            listBox1.Items.Clear();
            for (int i = 0; i < query[listView1.FocusedItem.Index].Count; i++)
            {
                listBox1.Items.Add(listBoxTxt[i] + query[listView1.FocusedItem.Index][i].ToString());
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            connect_DB();
            conn.Open();
            int dig = listView1.FocusedItem.Index + 1;
            string sql = "DELETE FROM \"Contact\".\"Contacts\" WHERE \"Contact_ID\" = " + dig.ToString();
            NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            fillList(conn);
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var addNew = new AddNew(this))
            {
                addNew.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var edit = new EditEntry(this))
            {
                edit.ShowDialog();
            }
        }
    }
}
