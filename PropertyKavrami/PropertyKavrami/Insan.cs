using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyKavrami
{
    internal class Insan
    {
        public string isim; //field
        string soyisim; //field
        private int yas;

        //Proterty

        public int Yas
        {
            get { return yas; }
            set {
                if (value > 10)
                {
                    yas = value; // parametre olarak atadığı değer value
                }
                else
                {
                    Console.WriteLine("Yas uygun değil");
                }  
            }  
        }
        public string Dogumyeri{ get; set; }

        //AutoImplamentedProperty
        public void isimAl(string isim)
        {
            this.isim = isim;
        }
        public string isimGetir()
        {
            return isim;
        }
        public void setSoyisim(string data)
        {
            soyisim = data;
        }
        public string getSoyisim()
        {
            return soyisim;
        }
    }
}
