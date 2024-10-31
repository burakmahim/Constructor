using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Bebek
    {
        // Property tanımlamaları
        public string _ad { get; set; }
        public string _soyad { get; set; }
        public DateTime _dogumTarihi { get; set; }

        // Default constructor
        public Bebek()
        {
            _dogumTarihi = DateTime.Now;
            Console.WriteLine("Ingaaaa");
        }

        // Ad ve Soyad parametreleri alan constructor
        public Bebek(string ad, string soyad)
        {
            _ad = ad;
            _soyad = soyad;
            _dogumTarihi = DateTime.Now;
            Console.WriteLine("Ingaaaa");
        }

        // Bebek bilgilerini yazdıran metot
        public void BebekBilgileriniYazdir()
        {
            Console.WriteLine($"Ad: {_ad}, Soyad: {_soyad}, Doğum Tarihi: {_dogumTarihi}");
        }
    }

}
