public void Filtering1()
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
                string value = textBox1.Text.ToLower();

                for (int i = listViewVideos.Items.Count - 1; -1 < i; i--)
                {

                    if (listViewVideos.Items[i].Text.ToLower().StartsWith(value) == false)
                    {
                        listViewVideos.Items[i].Remove();
                    }
                }


            }
          
}