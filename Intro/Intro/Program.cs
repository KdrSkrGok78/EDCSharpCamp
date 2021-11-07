using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");//çıktı çıkarır    
            

            bool sistemeGirisYapmisMi = true;//değişken tanımlama şeklimiz

            if(sistemeGirisYapmisMi == true)//if(şart){kodlar}
            {
                Console.WriteLine("Ayarlar|Profil|Ana Sayfa");
            }
            //else if(alternatif şart){kodlar} - bu da alternatif şartımız varsa yazılan şart bloğumuz
            else //başka alternatif yoksa çalışacak kodlar
            {
                Console.WriteLine("Giriş Yap|Kayıt Ol");
            }




            Console.ReadLine();//konsolun kapanmasını engeller

        }
    }
}
