using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoesListe
{
    public class Video
    {
        public Video(string Name, int vZeit, DateTime erdatum,DateTime hochdatum )
        {
              this.Name = Name;
              this.vZeit = vZeit;
              this.erdatum = erdatum;
            this.hochdatum = hochdatum;
        }

        public string Name { set; get; }
        public int vZeit { set; get; }
        public DateTime  erdatum { set; get; }
        public DateTime  hochdatum { set; get; }


        public Video(string Name, string vZeit, string erdatum, string hochdatum)
         {
            this.Name = Convert.ToString(Name.Trim());

            int dummy = 0;
            if (int.TryParse(vZeit, out dummy) == true)
            {
                this.vZeit = dummy;
            }
            else
            {
                this.vZeit = 0;
            }

            this.erdatum = Convert.ToDateTime(erdatum);
            this.hochdatum = Convert.ToDateTime(hochdatum);

        }
    }
}