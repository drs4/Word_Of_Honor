using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using WordOfHonor.Models;

namespace WordOfHonor
{
    public partial class AddForm : Form
    {
        public int Id = 0;
        private static readonly HttpClient client = new HttpClient();
        public AddForm()
        {
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            if (Id != 0)
            {
                var q = GetQuote(Id);
                txtText.Text = q.Text;
                txtAuthor.Text = q.Author;
                txtFrom.Text = q.From;
                txtAbout.Text = q.About;
            }
        }

        private Quote GetQuote(int id)
        {

            using (var db = new MyContext())
            {

                return db.Quotes.Find(id);
            }
        }


        private void AddQuote(Quote quote)
        {
            using (var db = new MyContext())
            {

                db.Quotes.Add(quote);
                db.SaveChanges();
            }
        }

        private void UpdateQuote(Quote quote)
        {
            using (var db = new MyContext())
            {
                db.Entry(quote).State = EntityState.Modified;
                db.SaveChanges();
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtText.Text))
            {
                MessageBox.Show("Invalid Quote!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Quote q = new Quote
            {
                Text = txtText.Text,
                Author = txtAuthor.Text,
                From = txtFrom.Text,
                About = txtAbout.Text,
            };
            if (Id != 0)
            {
                q.Id = Id;
                UpdateQuote(q);
            }
            else
            {
                AddQuote(q);
            }

            this.Hide();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtText.Text))
            {
                MessageBox.Show("Invalid Quote!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Quote q = new Quote
            {
                Text = txtText.Text,
                Author = txtAuthor.Text,
                From = txtFrom.Text,
                About = txtAbout.Text,
            };
            if (Id != 0)
            {
                q.Id = Id;
                UpdateQuote(q);
                Id = 0;
            }
            else
            {
                AddQuote(q);
            }

            txtText.Clear();
            txtAuthor.Clear();
            txtFrom.Clear();
            txtAbout.Clear();

        }

        private async void btnGetQuote_Click(object sender, EventArgs e)
        {
            try
            {
                var responseString = await client.GetStringAsync("https://talaikis.com/api/quotes/random/ ");
                var q = JsonConvert.DeserializeObject<APIQuote>(responseString);
                txtText.Text = q.quote;
                txtAuthor.Text = q.author;
                txtFrom.Text = q.cat;
            }
            catch (Exception)
            {

                MessageBox.Show("No internet Connection!", "Filed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btnAdd100_Click(object sender, EventArgs e)
        {

            try
            {
                var responseString = await client.GetStringAsync("https://talaikis.com/api/quotes/ ");
                var q = JsonConvert.DeserializeObject<APIQuote[]>(responseString);

                using (var db = new MyContext())
                {
                    foreach (var apiQuote in q)
                    {
                        db.Quotes.Add(new Quote
                        {
                            Text = apiQuote.quote,
                            Author = apiQuote.author,
                            From = apiQuote.cat,
                        });
                    }
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No internet Connection!", "Filed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
