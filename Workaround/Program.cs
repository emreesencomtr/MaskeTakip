using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();

            Vatandas vatandas1 = new Vatandas(); //bir tane vatandaş oluşturduk. 

            SelamVer(isim:"Emre");
            SelamVer(isim: "Semra");
            SelamVer(isim: "Merve");
            SelamVer();

            int sonuc = Topla(3,5);


            //Diziler // Arrays

            string ogrenci1 = "Emre";
            string ogrenci2 = "Berkay";
            string ogreenci3 = "Ali";

            //Console.WriteLine(ogrenci1);

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Emre";
            ogrenciler[1] = "Berkay";
            ogrenciler[2] = "Ali";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.Write(ogrenciler[i]);
            }

            string[] sehirler1 = new[] {"Ankara", "Elazığ","İstanbul" } ;
            //string[] sehirler3  = new string[3]; bu şekilde de yazılabilir
 
            string[] sehirler2 = new[] { "Tunceli", "İzmir", "Malatya" };

            sehirler2 = sehirler1; // sehirler2nin referansı eşittir sehirler1 referansıdır.
            sehirler1[0] = "Adana";  //referans tipini değiştin aynı referansa gittiği için ikisi de adana
            Console.WriteLine(sehirler2[0]); //

            //array, class, interface ve abstract referans tipliler 

            int sayi1 = 10;    // int, double, float ve bool değer tiplerdir. Stack üzerinde olur. Değer tiplerde değeri atarız.Dikkat referans tiplerde referans numarasına atanmaktadır.
            int sayi2 = 20;
            sayi2 = sayi1;
            sayi1 = 30;
            Console.WriteLine(sayi2); // 10 değeri verir. değeri atadı bitti sayi1 artık bitti değeri atandı. olay değer seviyesinde

            Person person1 = new Person();
            person1.FirstName = "EMRE";
            person1.LastName = "ESEN";
            person1.DateOfBirthYear = 1987;
            person1.NationalIdentity = 123;



            Person person2 = new Person();
            person2.FirstName = "Merve";

            foreach (string sehir in sehirler1)  //dizi formatında ki yapılara dönülmektedir. Diziler var ise foreach sehir takma isim (alias yani)
            {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler1 = new List<string> { "Ankara" ,"İzmir", "Elazığ", "Sivas"}; //3 elemanlı liste aslında bir dizi 
            yeniSehirler1.Add("Kayseri"); //Add ile listeye yeni bir eleman eklendi.
            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }


            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);













            Console.ReadLine();
        }

        static void SelamVer(string isim="isimsiz") //isim parametredir.
        {
            Console.WriteLine("Merhaba "  + isim);
        }

        static int Topla(int sayi1, int sayi2)

        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam: " +sonuc);
            return sonuc;
        }



        private static void Degiskenler()
        {
            string mesaj = "Selam";
            double tutar = 100.50; // db den gelir
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Emre";
            string soyad = "Esen";
            int dogumyili = 1987;
            long tcNo = 12345678910;


            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine(tutar);
            Console.WriteLine(mesaj);
            Console.WriteLine(tutar * 1.18);
        }
    }

    public class Vatandas
    {
        //public string Ad = "Emre";
        //public string Soyad = "Esen";
        //public int DogumYili = 1987;
        //public long TcNo = 12345678910;
        
        //pascal casing ( class, prop ve methodlar bu şekilde olacak)
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}
