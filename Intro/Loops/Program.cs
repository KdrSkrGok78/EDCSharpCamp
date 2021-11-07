using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 15;//tanımlama yaptık
            int deger = 0;
            for (int i = 0; i <= length; i++)//i'yi her seferinde bir arttırır şartı sağlamayana kadar döngü ilerler(sayaç;şart;artış)
            {
                deger = deger + i;
            }

            string[] kurslar = new string[]
            {
                "Java","Python","C#"
            };
            
            for(int j= 0; j<kurslar.Length; j++)//sınr kursların elemanının sayısı kadar oldu j=0 dedik çünkü dizilerin indisi 0dan başlar
            {
                Console.WriteLine(kurslar[j]);//kursların j'ninci elemanını yazdırdık
            }

            foreach (string kurs in kurslar)
            {
                //dizi temelli yapıları tek tek dönmeye yarıyor

                Console.WriteLine(kurs);//direk dolaştırdığımız için kurs değişkenimizi yazabiliriz
            }
            Console.WriteLine(deger);
            Console.ReadLine();
        }
    }
}
