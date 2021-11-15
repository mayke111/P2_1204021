using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204021
{
    public class citaCita: murid
     {
        protected string cita;
        
        public citaCita (string hobby, string cita)
            :base (hobby, cita)
        {
            this.cita = cita;
            this.Nama = "myisha";
            this.Hobby = hobby;
        }

        public string Cita
        {
            get
            {
                return cita;
            }
            set
            {
                cita = value;
            }
        }
    }
}
