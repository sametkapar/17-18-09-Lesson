using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyKavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Insan ins = new Insan();
            ins.isimAl("Murtaza");
            Console.WriteLine(ins.isimGetir());

            ins.setSoyisim("Şuayipoğlu");
            Console.WriteLine(ins.getSoyisim());
            ins.Yas = 26;
            Console.WriteLine(ins.Yas);

            ins.Dogumyeri = "İzmir";
            Console.WriteLine(ins.Dogumyeri);

        }
    }
}
