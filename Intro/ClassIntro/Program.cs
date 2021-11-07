using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.Egitmeni = "Engin Demiroğ";
            kurs1.KursAdi = "C#";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.Egitmeni = "Engin Demiroğ";
            kurs2.KursAdi = "Java";
            kurs2.IzlenmeOrani = 86;//kurslarımızı tanımladık basit düzeyde

            Kurs kurs3 = new Kurs();
            kurs3.Egitmeni = "Engin Demiroğ";
            kurs3.KursAdi = "Python";
            kurs3.IzlenmeOrani = 72;

            Kurs[] kurslar = new Kurs[]
            {
                kurs1,kurs2,kurs3//kurs tipinde array oluşturduk
            };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }
            Console.ReadLine();
        }
    }

    class Kurs
    {//nesnelerimizi ve türevi şeylerimizi tanımlayabiliriz
        public string KursAdi { get; set; }//bunlarsa kursumuzun birer objesidir
        public string Egitmeni { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
