using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrowserApp
{
    public partial class Form1 : Form
    {
        List<Ulubiona> listaUlubionych;
        public Form1()
        {
            InitializeComponent();
            listaUlubionych= new List<Ulubiona>();
            OdczytajUlubione();
            OdswiezUlubione();


        }

        private void OdswiezUlubione()
        {
            favouriteCB.DataSource = null;
            favouriteCB.DataSource = listaUlubionych;
        }

        private void OdczytajUlubione()
        {

            using(StreamReader sr= new StreamReader(@"C:\Users\Gim_Lic\Documents\ulubione\ulubione.txt"))
            {
                string line;
                while((line= sr.ReadLine()) !=null)
                {
                    string[] elementy = line.Split('|');
                    Ulubiona ul = new Ulubiona(elementy[1], elementy[0]);
                    listaUlubionych.Add(ul);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(searchBoxTxt.Text);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            searchBoxTxt.Text = "https://";
            webBrowser1.Navigate("www.gazeta.pl");
            nextToolStripMenuItem.Enabled = false;

           
        }

        private void nextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            searchBoxTxt.Text = webBrowser1.Url.ToString();
            if(webBrowser1.CanGoForward)
            {
                nextToolStripMenuItem.Enabled = true;
            }
            else
            {
                nextToolStripMenuItem.Enabled = false;
            }
            if(webBrowser1.CanGoBack)
            {
                previousToolStripMenuItem.Enabled = true;
            }
            else
            {
                previousToolStripMenuItem.Enabled = false;

            }
        }

        private void previousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nextToolStripMenuItem.Enabled = true;
            webBrowser1.GoBack();
        }

        private void addToFavBtn_Click(object sender, EventArgs e)
        {
            string url = searchBoxTxt.Text;
            string tytulStrony = webBrowser1.Document.Title;
            ZapiszDoUlubionych(new Ulubiona(tytulStrony,url));
        }
        private void ZapiszDoUlubionych(Ulubiona strona )
        {
            listaUlubionych.Add(strona);
            OdswiezUlubione();
            ZapiszDoUlubionychDoPliku(strona);
        }

        private void ZapiszDoUlubionychDoPliku(Ulubiona ulubiona)
        {
            string fileTxt = @"C:\Users\Gim_Lic\Documents\ulubione.txt";
            if (!File.Exists(fileTxt))
                File.Create(fileTxt);

            using(StreamWriter sw = new StreamWriter(fileTxt, true))
            {
                sw.WriteLine(String.Format("{0}|{1}", ulubiona.url, ulubiona.ToString()));
            }

           
        }

        private void favouriteCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ulubiona strona = (Ulubiona)favouriteCB.SelectedItem;
            searchBoxTxt.Text = strona.url;
            webBrowser1.Navigate(strona.url);
        }

        private void searchBoxTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void reload_DockChanged(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }
    }
}
