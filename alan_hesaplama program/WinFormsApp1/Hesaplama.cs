using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1;


namespace WinFormsApp1
{
    class Hesaplama
    {
        public double karealan(int sayi1)
        {
            return sayi1 * sayi1;
        }

        public  double ucgenalan(int sayi1,int sayi2)
        {
            return (sayi1 * sayi2)/2;
        }

        public  double kupalan(int sayi1)
        {
            return sayi1 * sayi1 * 6;
        }

        public  double dairealan(int sayi1)
        {
            return 3.14 * sayi1;
        }
    }
}
