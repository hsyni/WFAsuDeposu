using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAsuDeposu
{
    public class SuTastiEventArgs : EventArgs
    {
        public decimal TasanMiktar { get; private set; }

        public SuTastiEventArgs(decimal tasanMiktar)
        {
            TasanMiktar = tasanMiktar;
        }
    }
}
