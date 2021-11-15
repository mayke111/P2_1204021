using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204021
{
   public class murid
    {
        private string nama;
        private string hobby;
        
        public murid (string nama, string hobby)

            {
                this.nama = nama;
                this.hobby = hobby;
            }

        public string Nama
            {
                get
                    {
                        return nama;
                    }
                set
                    {
                         nama = value;
                    }
           }
        public string Hobby
        {
            get
            {
                return hobby;
            }
            set
            {
                hobby = value;
            }
        }
    }
}
