using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic06
{
    public class mamalia
    {
        public virtual string pindah ()
        {
            //Console.WriteLine("berlari..."); 
            return "Berlari...";
        }
    }
    public class kucing : mamalia
    {

    }
    public class paus : mamalia
    {
        public override string pindah ()
        {
            //Console.WriteLine("Berenang...");
            return "Berenang...";
        }
    }
}
