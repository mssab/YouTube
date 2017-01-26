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
using System.Xml;


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

            //  if((dia == System.Windows.Forms.DialogResult.OK) || (dia==System.Windows.Forms.DialogResult.Retry))
            if (dia == System.Windows.Forms.DialogResult.OK)
            {
                //Adding(fm.TextboxTitle.Text, fm.TextboxZeit.Text, fm.dateTimePicker1.Text, fm.dateTimePicker2.Text);

                Video v = new Video(fm.TextboxTitle.Text, fm.TextboxZeit.Text, fm.dateTimePicker1.Text, fm.dateTimePicker2.Text);
                videos.Add(v);
                //Adding(v);
                this.RefreshList();
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
            listViewVideos.Columns.Add("Titel", 150);
            listViewVideos.Columns.Add("Zeit", 20);
            listViewVideos.Columns.Add("Erstellung Datum", 150);
            listViewVideos.Columns.Add("Hochladung Datum", 150);
        }

        public void RefreshList()
        {
            listViewVideos.Items.Clear();

            foreach (Video video in this.videos)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = video.Name;
                lvi.SubItems.Add(video.vZeit.ToString());
                lvi.SubItems.Add(video.erdatum.ToShortDateString());
                lvi.SubItems.Add(video.hochdatum.ToShortDateString());
                lvi.Tag = video;
                listViewVideos.Items.Add(lvi);
            }
        }

        public void Adding(Video video)
        {
            //ListViewItem lvi = new ListViewItem();
            //lvi.Text = video.Name;
            //lvi.SubItems.Add(video.vZeit.ToString());
            //lvi.SubItems.Add(video.erdatum.ToShortDateString());
            //lvi.SubItems.Add(video.hochdatum.ToShortDateString());
            //listViewVideos.Items.Add(lvi);
            //lvi.Tag = video;

            //VidListFm fm1 = new VidListFm();
            //listViewVideos.Items.Add(video.Name.ToString());
            //listViewVideos.Items.Add(video.vZeit.ToString());

            //listViewVideos.Items.Add(video.erdatum.ToString());
            //listViewVideos.Items.Add(video.hochdatum.ToString());

            //string[] row = { fm1.TextboxTitle.Text, zeit, erDatum, hochDatum };
            // ListViewItem item = new ListViewItem(row);

        }

        private void listViewVideos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Video video = listViewVideos.SelectedItems[0].Tag as Video;
            if (video != null)
            {
                VidListFm fr = new VidListFm();
                fr.TextboxTitle.Text = video.Name;
                fr.TextboxZeit.Text = video.vZeit.ToString();
                fr.dateTimePicker1.Text = video.erdatum.ToShortDateString();
                fr.dateTimePicker2.Text = video.hochdatum.ToShortDateString();
                
                fr.ShowDialog();

                //Video v = new Video(video.Name, video.vZeit.ToString(), video.erdatum.ToShortDateString(), video.hochdatum.ToShortDateString());
                //videos.Add(v);
                //Adding(v);
                //Adding(video);
                video.Name = fr.TextboxTitle.Text;
                video.vZeit= Convert.ToInt32( fr.TextboxZeit.Text);
                video.erdatum = Convert.ToDateTime(fr.dateTimePicker1.Text);
                video.hochdatum = Convert.ToDateTime(fr.dateTimePicker2.Text);
                this.RefreshList();
                
            }
                        
            // ((ListView)sender).SelectedItems[0];

            
            //ListViewItem lvi = new ListViewItem();
            //lvi.Text = video.Name;

            //lvi.SubItems.Add(video.vZeit.ToString());
            //lvi.SubItems.Add(video.erdatum.ToShortDateString());
            //lvi.SubItems.Add(video.hochdatum.ToShortDateString());
            //listViewVideos.Items.Add(lvi);


            //String file = listViewVideos.SelectedItems.ToString();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                XmlTextWriter xr = new XmlTextWriter(saveFileDialog1.FileName, Encoding.Unicode);
                xr.WriteStartDocument();
                xr.WriteStartElement("XMLFILE");



                //if ((myStream = saveFileDialog1.OpenFile()) != null)
                //{
            ////         listViewVideos.Items.Clear();

            ////foreach (Video video in this.videos)
            ////{
            //ListViewItem lvi = new ListViewItem();

            //string s = lvi.SubItems[0].Text +" " + Convert.ToString(lvi.SubItems[1].Text) + " " + lvi.SubItems[2].Text + "" + lvi.SubItems[3].Text + "";
            //       // myStream.Write(s);
                    //ListViewItem lvi = new ListViewItem();
                    //xr.WriteString(lvi.SubItems[0].Text );//+" " + lvi.SubItems[1].Text + " " + lvi.SubItems[2].Text + "" + lvi.SubItems[3].Text + "");
                   
                    foreach (ListViewItem item in listViewVideos.Items)
                    {
                        xr.WriteStartElement("Item");
                        xr.WriteString(item.ToString());
                        xr.WriteEndElement();
                    }
                    
                    xr.WriteEndElement();
                    xr.WriteEndDocument();
                    xr.Close();

               //  s = saveFileDialog1.FileName;
                //    myStream.Close();
                //}
            }



            //try
            //{
            //    using (System.IO.TextWriter tw = new System.IO.StreamWriter(@"C:\listViewContent.txt"))
            //    {
            //        foreach (ListViewItem item in listViewVideos.Items)
            //        {
            //            tw.WriteLine(item.Text);
            //            for (int a = 1; a <= 3; a++)
            //            {
            //                tw.WriteLine(item.SubItems[a].Text);
            //            }
            //        }
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("TEXT FILE NOT FOUND");
            }


            //Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            //dlg.FileName = "DumpFile1"; 
            //dlg.DefaultExt = ".txt"; 
            //dlg.Filter = "Text files (.txt)|*.txt"; 

            //// Show save file dialog box
            //Nullable<bool> result = dlg.ShowDialog();

            //// Process save file dialog box results
            //if (result == true)
            //{
            //    // Save document
            //    string filename = dlg.FileName;

            //    File.WriteAllLines(filename, array, Encoding.UTF8); //array is your array of strings
            }
            //using (TextWriter tw = new StreamWriter(@"C:\\listViewContent.txt"))
            //{
            //    foreach (ListViewItem item in listViewVideos.Items)
            //    {
            //        tw.WriteLine(item.Text);
            //    }
            //}
        //       using (SaveFileDialog sfd=new SaveFileDialog {filter="TXT|*.txt",Validatnames=true})
        //    {
        //    if(sfd.showDialog()== dialogresult.ok)
        //        {
        //            using()
        //        }
        //}
            

            //using (var tw = new StreamWriter("liste"))
            //{
            //    foreach (ListViewItem item in listViewVideos.Items)
            //    {
            //        tw.WriteLine(item.Text);
                    
            //    }
            //}

      
}