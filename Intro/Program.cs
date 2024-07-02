using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("HW");


            Console.Write("Onur");
            Console.Write("True"); //Write metotu yanyana yazar.
            //Console.Read();


            byte birinci = 5;
            byte ikinci = 10;




            int ilk = 1000;
            int iki = 1500;



            Console.WriteLine(birinci);
            Console.WriteLine(ikinci);
            Console.WriteLine(ilk);



            //VERİ TİPLERİ
            //float
            float ondaliklisayi1 = 35.56f;
            double ondaliklisayi2 = 34.18;
            Console.WriteLine(ondaliklisayi1);
            Console.WriteLine(ondaliklisayi2);



            string isim = "Primat"; //metinsel

            bool kontrol = true; //sadece true yada false değerini tutar.
            bool kontrol2 = false;
            bool sonuc = 4 > 8;

            Console.WriteLine(isim);
            Console.WriteLine(sonuc);



            // Toplama Operatörü : +
            //Çıkarma Operatörü  : -
            //Çarpma Operatörü : *
            //Bölme Operatörü : /


            //Arttırma Operatörü : ++
            //Azaltma Operatörü : --


            //Büyüktür operatörü : >
            //Büyük ve eşittir operatörü : >=

            //Ve operatörü &&
            //Veya operatörü ||
            //Değil operatörü !







            int rakam1 = 5;
            int rakam2 = 10;

            rakam2++;

            int sonuc2 = rakam1 + rakam2;
            int sonuc3 = rakam2 - rakam1;
            int sonuc4 = rakam1 * rakam2;
            int sonuc5 = rakam2 / rakam1;

            bool checkEt = rakam1 == rakam2; //Eşittir.
            bool checkEt2 = rakam1 != rakam2; //Eşit Değildir.




            //DÖNÜŞTÜRMELER
            string sayi90 = "1";
            string sayi91 = "2";

            //1.DÖNÜŞÜM ÖRNEK
            int sayi92 = int.Parse(sayi90); //stringden int'e dönüşüm yapmış olduk. PARSE TÜRKÇEDE DÖNÜŞTÜR DEMEKTİR.

            //2.DÖNÜŞÜM ÖRNEK
            int x = Convert.ToInt32(sayi91);


            Console.WriteLine(sayi92);
            Console.WriteLine(sayi91);


            //INT VERİ TİPİNDEN STRİNG VERİ TİPİNE DÖNÜŞÜM YAPMAK

            int sayi100 = 10;
            int sayi200 = 20;

            string z = sayi100.ToString();
            string y = sayi200.ToString();

            Console.WriteLine(z);
            Console.WriteLine(y);





            Console.WriteLine(sonuc2);
            Console.WriteLine(sonuc3);
            Console.WriteLine(sonuc4);
            Console.WriteLine(sonuc5);
            Console.WriteLine(checkEt);
            Console.WriteLine(checkEt2);







            Console.WriteLine("Lütfen adınızı giriniz");

            string isimm = Console.ReadLine();


            Console.ReadLine(); //fonksiyonun sabit kalmasını sağlıyor.



        }
    }
}
