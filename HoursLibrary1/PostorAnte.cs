using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoursLibrary1
{
    public class PostorAnte //Master class
    {
        public List<AMorPM> AMPM { get; set; }
       
        public PostorAnte() 
        {
            AMPM = new List<AMorPM>();
            
        }
    }
}
