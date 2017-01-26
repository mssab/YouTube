//Save file 

private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isSaveDenied)
            {
                MessageBox.Show("Die Versionsnummer wurde geändert. Die Datei darf nicht unter gleichem Namen gespeichert werden!");
            }
            else
            {
                isLastFileModified = false;
                speichernToolStripMenuItem.Enabled = false;
                isSaveDenied = false;
                this.Text = lastFilename + " - Parametrierungseditor Direkt";
                if (!mParam.Save(lastFilename))
                {
                    MessageBox.Show(mParam.LastError);
                }
            }
}