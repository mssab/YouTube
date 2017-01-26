using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoesListe
{
    public partial class Form1 : Form
    {
        List<Video> videos = new List<Video>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            VidListFm fm = new VidListFm();
            DialogResult dia = fm.ShowDialog();

            if (dia == System.Windows.Forms.DialogResult.OK)
            {
                //Adding(fm.TextboxTitle.Text, fm.TextboxZeit.Text, fm.dateTimePicker1.Text, fm.dateTimePicker2.Text);

                Video v = new Video(fm.TextboxTitle.Text, fm.TextboxZeit.Text, fm.dateTimePicker1.Text, fm.dateTimePicker2.Text);
                videos.Add(v);
                Adding(v);
            }

            //videos.Add(
       
        }

        private void listViewVideos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listViewVideos.View = View.Details;
            listViewVideos.FullRowSelect = true;
            listViewVideos.Columns.Add("Titel",150);
            listViewVideos.Columns.Add("Zeit", 20);
            listViewVideos.Columns.Add("Erstellung Datum", 150);
            listViewVideos.Columns.Add("Hochladung Datum", 150);
        }


        public void Adding(Video video)
        {
            
            
            video.Name.ToString();  //= Convert.ToString(Name);
            video.vZeit.ToString();  // = Convert.ToInt32();
            video.erdatum.ToString(); // = Convert.ToDateTime();
            video.hochdatum.ToString(); // = Convert.ToDateTime();
            
            //string[] row = { TextboxTitle.Text, zeit, erDatum, hochDatum };
            //ListViewItem item = new ListViewItem(row);
            //listViewVideos.Items.Add(item);
        }

        /*
        public void Adding(string Titel, string zeit, string erDatum, string hochDatum)
        {
            string[] row = { Titel, zeit,erDatum,hochDatum};
            ListViewItem item = new ListViewItem(row);
            listViewVideos.Items.Add(item);

        }
         * */

     
    }
}