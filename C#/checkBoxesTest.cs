 public void checkboxTest()
        {
            double j = 0;
            double x = 0;
            CheckBox[] boxes = new CheckBox[16];
            boxes[0] = Behave1;
            boxes[1] = Behave2;
            boxes[2] = Behave3;
            boxes[3] = Behave4;
            boxes[4] = Behave5;
            boxes[5] = Behave6;
            boxes[6] = Behave7;
            boxes[7] = Behave8;
            boxes[8] = Behave9;
            boxes[9] = Behave10;
            boxes[10] = Behave11;
            boxes[11] = Behave12;
            boxes[12] = Behave13;
            boxes[13] = Behave14;
            boxes[14] = Behave15;
            boxes[15] = Behave16;


            UInt32 uMaske = 0;

            UInt32.TryParse(textBoxValue.Text, out uMaske);
            if ((uMaske > 0) && (uMaske <= 65535))
                for (int i = 0; i < 16; i++)
                {
                    //double result=double.Parse(textBoxValue.Text);
                    if (boxes[i].Enabled)
                    {
                        // if (((double)Math.Pow(2, i)) / 2 == result / 2)

                        boxes[i].Checked = false;
                    }

                    if ((uMaske & (1 << i)) != 0)
                    {
                        boxes[i].Checked = true;
                    }
                   

                }

            else
            {

                MessageBox.Show("Keine gültige Zahl!");
            }

}