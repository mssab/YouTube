    if (numericUpDownDimension.Value == 2)
            {
                if (numericUpDownDimension.Value == 1)
                {
                    groupBox1y.Enabled = true; groupBox_Z.Enabled = false; 
                }
                else
                {
                    groupBox1y.Enabled = true; groupBox_Z.Enabled = true;
                }
                
            }
            else
            {
                groupBox1y.Enabled =true; groupBox_Z.Enabled = false;
            }
            if (numericUpDownDimension.Value == 0) { groupBox1y.Enabled = false; groupBox_Z.Enabled = false; }
