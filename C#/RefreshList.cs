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