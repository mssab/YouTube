   private void button1_Click(object sender, EventArgs e)
        {
            XmlReader file;
            file = XmlReader.Create("file.xml", new XmlReaderSettings());
            DataSet ds = new DataSet();
            DataView dv;
            ds.ReadXml(file);
            dv = new DataView(ds.Tables[0]);
            dv.Sort = "Name";
            int i = dv.Find(textBox1.Text);
            if (i == -1)
            {
                MessageBox.Show(" nicht gefunden");
            }
            else
            {
                MessageBox.Show(dv[i]["Name"].ToString() + "gefunden");
            }

}