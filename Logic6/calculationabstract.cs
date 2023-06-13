using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic06
{
    public abstract class calculationabstract
    {
        public abstract int jumlah(int x, int y);
        public abstract int kurang(int x, int y);
    }

    public class testturunann : calculationabstract //cara menurunkan abstract
    {
        public override int jumlah(int x, int y)
        {
            return x + y;
        }
        public override int kurang(int x, int y)
        {
            return x - y ;
        }
        
    }
}
