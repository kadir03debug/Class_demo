using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri Musteri_1 = new Musteri();
            Musteri_Manager Manager = new Musteri_Manager();
            Musteri_1.Musteri_Adi = "kadir";
            Musteri_1.Musteri_Id = 0;
            Musteri_1.Musteri_KİMLİKNo = "33333333";

            Manager.Ekle();
            Manager.Guncelle();
            Manager.Sil();
            
        }
    }
}
