using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAsuDeposu
{
    public class SuDeposu
    {
        public event EventHandler<SuTastiEventArgs> Tasti;

        private readonly decimal _kapasite;
        public decimal Kapasite { get { return _kapasite; } }
        public decimal SuMiktarı { get; private set; }
        public decimal DolulukOrani => SuMiktarı / Kapasite;
        public SuDeposu(decimal kapasite)
        {
            _kapasite = kapasite;
        }
        public void SuEkle(decimal miktar)
        {
            if (miktar < 0)
            {
                throw new ArgumentException("Eklenecek su miktarı sıfırdan küçük olamaz");
            }
            SuMiktarı += miktar;

            if (SuMiktarı > Kapasite)
            {
                decimal tasanMiktar = SuMiktarı - Kapasite;

                if (Tasti != null)
                    Tasti(this, new SuTastiEventArgs(tasanMiktar));
                SuMiktarı = Kapasite;
            }
        }
    }
}
