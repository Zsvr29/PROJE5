using System;

namespace PROJEM5
{
    class Program
    {
        static void Main(string[] args)
        {

            string ad, soyad, TC;
            Console.WriteLine(" Adınızı gırınız:");
            ad = Console.ReadLine();
            Console.WriteLine("Soyadınızı Gırınız:");
            soyad = Console.ReadLine();
            Console.WriteLine("TC nizi giriniz:");
            TC = Console.ReadLine();
            Console.WriteLine("Kaydınız Basarılı Bır Sekılde Olusturulmustur.");
             string model;
            int gunsys;
            int kira;
            Console.WriteLine("Modeller: BMW ,KIA,HONDA ,FIAT,HYUNDAI,IVECO,FORD,DACİA,TOYOTA,NISSAN");
            Console.WriteLine("Secmek ıstedınız modelı gırınız:");

            model = Console.ReadLine();
            switch (model)
            {
                case "BMW":
                    Console.WriteLine("Gunluk  Kıralama Fıyatı :1500 TL dır");
                    Console.WriteLine("Kac gun kıralayacaksınız?");
                    gunsys = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Kira Tutarı:");
                    kira = gunsys * 1500;
                    Console.WriteLine(kira);
                    break;

                case  "KIA":
                    Console.WriteLine("Gunluk Kıralama Fıyatı 1250 TL dır");
                    Console.WriteLine("Kac gun kıralayacaksınız?");
                    gunsys = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Kira Tutarı:");
                    kira = gunsys * 1250;
                    Console.WriteLine(kira);
                    break;
                 case "HONDA":
                    Console.WriteLine("Gunluk Kıralama Fıyatı 1200 TL dır ");
                    Console.WriteLine("Kac gun kıralayacaksınız?");
                    gunsys = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Kira Tutarı:");
                    kira = gunsys * 1200;
                    Console.WriteLine(kira);
                    break;

                case "FIAT":
                    Console.WriteLine("Gunluk Kıralama Fıyatı 1000  TL dır ");
                    Console.WriteLine("Kac gun kıralayacaksınız?");
                    gunsys = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Kira Tutarı:");
                    kira = gunsys * 1000;
                    Console.WriteLine(kira);
                    break;

                case "HYUNDAI":
                    Console.WriteLine("Gunluk kıralama 900 TL dır ");
                    Console.WriteLine("Kac gun kıralayacaksınız?");
                    gunsys = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Kira Tutarı:");
                    kira = gunsys * 900;
                    Console.WriteLine(kira);
                    break;
                case "IVECO":
                    Console.WriteLine("Gunluk kıralama 800 TL dır ");
                    Console.WriteLine("Kac gun kıralayacaksınız?");
                    gunsys = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Kira Tutarı:");
                    kira = gunsys * 800;
                    Console.WriteLine(kira);
                    break;

                case "FORD":
                    Console.WriteLine("Gunluk kıralama 750 TL dır");
                    Console.WriteLine("Kac gun kıralayacaksınız?");
                    gunsys = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Kira Tutarı:");
                    kira = gunsys * 750;
                    Console.WriteLine(kira);
                    break;

                case "DACİA":
                    Console.WriteLine("Gunluk kıralama 650 TL dır");
                    Console.WriteLine("Kac gun kıralayacaksınız?");
                    gunsys = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Kira Tutarı:");
                    kira = gunsys * 650;
                    Console.WriteLine(kira);
                    break;

                case "TOYOTA":
                    Console.WriteLine("Gunluk kıralama 500 TL dır ");
                    Console.WriteLine("Kac gun kıralayacaksınız?");
                    gunsys = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Kira Tutarı:");
                    kira = gunsys * 500;
                    Console.WriteLine(kira);
                    break;

                case "NISSAN":
                    Console.WriteLine("Gunluk kıralama 400 TL dır ");
                    Console.WriteLine("Kac gun kıralayacaksınız?");
                    gunsys = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Kira Tutarı:");
                    kira = gunsys * 400;
                    Console.WriteLine(kira);
                    break;

                default:
                    Console.WriteLine("Bu modelde arabamız  bulunmamaktadır.");
                    break;



            }
            Console.ReadLine();
        }
    }
}
