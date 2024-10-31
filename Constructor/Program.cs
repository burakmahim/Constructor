using System;
using Constructor;

class Program
{
    static void Main(string[] args)
    {
        // Default constructor ile bebek nesnesi oluşturma
        Bebek bebek1 = new Bebek();
        bebek1._ad = "Ali";
        bebek1._soyad = "Kara";
        bebek1.BebekBilgileriniYazdir();

        Console.WriteLine();

        // Parametreli constructor ile bebek nesnesi oluşturma
        Bebek bebek2 = new Bebek("Ayşe", "Yılmaz");
        bebek2.BebekBilgileriniYazdir();
    }
}
