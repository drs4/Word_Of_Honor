using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordOfHonor
{
    public partial class FormMain : Form
    {
        private Random rand = new Random(System.DateTime.Now.Second);

        public FormMain()
        {
            InitializeComponent();
            tmrLong.Interval = rand.Next(1, 4) * 30 * 60000;

            ShowQuote();
            RegRun(Application.ExecutablePath, true);

        }


        private void CreateDatabase()
        {
            SQLiteConnection.CreateFile("QuotesDB.sqlite");
            SQLiteConnection m_connection = new SQLiteConnection("Data Source=QuotesDB.sqlite;Version=3;");
            m_connection.Open();

            string createQuotesTable = "CREATE TABLE `Quote` (" +
                                       "`Id`	INTEGER PRIMARY KEY AUTOINCREMENT," +
                                       "`Text`	TEXT," +
                                       "`Author`	TEXT," +
                                       "`From`	TEXT," +
                                       "`About`	TEXT" +
                                       ");";

            SQLiteCommand command = new SQLiteCommand(createQuotesTable, m_connection);
            command.ExecuteNonQuery();

        }

        public static void RegRun(string App_path, bool r)
        {
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
            if (r)
                key.SetValue("WordOfHonor", App_path);
            else
                key.DeleteValue("WordOfHonor");
            key.Close();
        }

        private void DeleteQuote(int id)
        {
            using (var db = new MyContext())
            {
                var quote = db.Quotes.Find(id);
                db.Quotes.Remove(quote);
                db.SaveChanges();
            }
        }



        private Quote GetQuote()
        {
            
            using (var db = new MyContext())
            {
                var quotes = db.Quotes.ToList();
                int num = rand.Next(quotes.Count);
                if (quotes.Count == 0) return new Quote();
                return quotes[num];
            }
        }

        private void ShowQuote()
        {
            var q = GetQuote();
            this.lblId.Text = q.Id.ToString();
            var author = !string.IsNullOrEmpty(q.Author) ? q.Author : "Someone";
            this.Text = author + " said once:";
            txtText.Text = q.Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                DeleteQuote(Convert.ToInt32(lblId.Text));
                ShowQuote();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var frmAdd = new AddForm();
            frmAdd.Id = Convert.ToInt32(lblId.Text);
            frmAdd.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frmAdd = new AddForm();
            frmAdd.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ShowQuote();
        }


        private void itmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
                ShowQuote();

                tmrShort.Enabled = false;
                tmrLong.Enabled = true;
                tmrLong.Interval = rand.Next(1, 4) * 30 * 60000;

            }
        }

        private void ntfIcon_DoubleClick(object sender, EventArgs e)
        {
            tmrShort.Enabled = true;
            tmrLong.Enabled = false;
            this.Show();

        }

        private void tmrLong_Tick(object sender, EventArgs e)
        {
            tmrLong.Enabled = false;
            tmrShort.Enabled = true;
            this.Show();

        }

        private void tmrShort_Tick(object sender, EventArgs e)
        {
            tmrShort.Enabled = false;
            tmrLong.Enabled = true;
            tmrLong.Interval = rand.Next(1, 4) * 30 * 60000;
            ShowQuote();

            this.Hide();

        }

        private void itmRun_Click(object sender, EventArgs e)
        {
            if (itmRun.Checked == false)
            {
                RegRun("", false);

            }
            else
            {
                RegRun(Application.ExecutablePath, true);
            }

        }

        private void txtText_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            txtText.Dock = DockStyle.None;

            const int margin = 5;
            RichTextBox rch = sender as RichTextBox;
            rch.ClientSize = new Size(
            e.NewRectangle.Width + margin,
            e.NewRectangle.Height + margin);

            this.Width = rch.Width + 20;
            this.Height = rch.Height + 40;

            txtText.Dock = DockStyle.Fill;
        }
    }
}
