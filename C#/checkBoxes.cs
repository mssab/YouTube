public void test()
        {
            Double j = 0;
            Double x = 0;
            CheckBox[] boxes = new CheckBox[30];
            boxes[0] = checkBox1;
            boxes[1] = checkBox2;
            boxes[2] = checkBox3;
            boxes[3] = checkBox4;
            boxes[4] = checkBox5;
            boxes[5] = checkBox6;
            boxes[6] = checkBox7;
            boxes[7] = checkBox8;
            boxes[8] = checkBox9;
            boxes[9] =  checkBox10;
            boxes[10] = checkBox11;
            boxes[11] = checkBox12;
            boxes[12] = checkBox13;
            boxes[13] = checkBox14;
            boxes[14] = checkBox15;
            boxes[15] = checkBox16;
            boxes[16] = checkBox17;
            boxes[17] = checkBox18;
            boxes[18] = checkBox19;
            boxes[19] = checkBox20;
            boxes[20] = checkBox21;
            boxes[21] = checkBox22;
            boxes[22] = checkBox23;
            boxes[23] = checkBox24;
            boxes[24] = checkBox25;
            boxes[25] = checkBox26;
            boxes[26] = checkBox27;
            boxes[27] = checkBox28;
            boxes[28] = checkBox29;
            boxes[29] = checkBox30;


            for (int i = 0; i < 30; i++)
            {
                if (boxes[i].Checked == true && boxes[i].Enabled)
                {
                    x = (int)Math.Pow(2, i);
                    
                    x = x + j;
                    j = x;
               }
                else 
                {
                    
                    j = 0;
                   
                }
                
            }
            
            textBox1.Text = x.ToString();
}