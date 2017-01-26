 string value = textBox1.Text.ToLower();
            
            RefreshList();
            for (int i = listViewVideos.Items.Count - 1; -1 < i; i--)
            {
                if
                (listViewVideos.Items[i].Text.ToLower().StartsWith(value) == false)
                {
                    listViewVideos.Items[i].Remove();
                }
} 