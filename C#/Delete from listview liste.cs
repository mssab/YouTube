 //Delete from listview liste
 public void deleteVideos()
        {
            for (int i = 0; i < listViewVideos.Items.Count; i++)
            {

                if (listViewVideos.Items[i].Selected == true)
                {
                    Video video = listViewVideos.Items[i].Tag as Video;
                    videos.Remove(video);
                }
            }
            RefreshList();
}