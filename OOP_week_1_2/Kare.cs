using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_week_1_2
{
    public class Kare
    {
        // Değişkenler
        public int kenar1;
        public int kenar2;

        // Alan hesaplayan metot
        public int AlanHesapla()
        {
            int alan = kenar1 * kenar2;
            return alan;
        }

        // Çevre hesaplayan metot
        public int CevreHesapla()
        {
            int cevre = 2 * (kenar1 + kenar2);
            return cevre;
        }
    }
}
