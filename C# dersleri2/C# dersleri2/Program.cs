using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__dersleri2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /* Console.Write("Lütfen şifreyi giriniz");
             string pasword;
             pasword = Console.ReadLine();
             if(pasword == "abcd") 
             {
                 Console.Write("Şifre dogru:");
             }
             else 
             {
                 Console.Write("Şifre yanliş:");
             }
             Console.WriteLine();
             Console.ReadLine();*/
            //#region if 
            /*string capital, country;
            Console.Write("Ülkeyi giriniz");
            country = Console.ReadLine();

            
            Console.Write("Başkenti giriniz");
            capital = Console.ReadLine();
           if(capital =="Ankara"&country=="Türkiye")
            {
                Console.Write("Veriler doğrulandı:");
            }
            else
            {
                Console.Write("Veriler Yanlış:");
            }
           
            int Number;
            Console.Write("Lütfen Numara Giriniz:");
            Number=int.Parse(Console.ReadLine());
            if(Number==13) 
            {
                Console.WriteLine("Numara Doğru:");
            }
            else 
            {

                Console.WriteLine("Numara Yanlış:");
            } 
            Console.WriteLine();
            Console.ReadLine();
            int exam1 , exam2 ,exam3,average;
            string result="Hata!!";
            Console.Write("Sınav1:");
            exam1 =int.Parse(Console.ReadLine());
            Console.Write("Sınav2:");
            exam2 = int.Parse(Console.ReadLine());
            Console.Write("Sınav3:");
            exam3 = int.Parse(Console.ReadLine());
           
            average =(exam1 + exam2 + exam3)/3;
            Console.Write("Sınavların Ortalaması:"+average);
            if(average >0 & average<=50)
            {

                result = "Sonuc Vasat:";
            }
            if (average > 50 & average <= 70)
             {

                result = "Sonuc Orta";
            }
             if(average > 70 & average <= 84)
            {

                result = "Sonuc İyi";
            }
            if (average > 84)
            {

                result = "Sonuc  çok İyi"+ "tebrikler!!";
            }
            Console.Write(result);

            Console.ReadLine();

            Console.Write("Lütfen Şehir adı giriniz");
            string username=Console.ReadLine();
            if(username !="admin") 
            {
                Console.Write("Bu kullanıcı adı kabul edilemez:");
            }
            else
            {
                Console.Write("Hoş Geldiniz.");
            }
            Console.ReadLine();
            #endregion*/
            // #region Mod İşlemleri
            /*
            int Number;
            Number = 26;
            int result = Number % 5;
            Console.WriteLine(result);
            Console.Write("1. sayıyı giriniz:");
            int Number1=int.Parse(Console.ReadLine());
            Console.Write("2. sayıyı giriniz:");
            int Number2 = int.Parse(Console.ReadLine());
             int result = Number1 % Number2;
            Console.Write("1.sayının 2. sayıya bölümünden kalan:"+result);
            Console.Write("Lütfen sayı giriniz:");
            int number=int.Parse(Console.ReadLine());   
            if(number % 2 ==0) 
            {
                Console.Write("Sayı Çiftir:");
            }
            else {

                Console.Write( "Sayı Tektir." );
            }
            char team;
            Console.WriteLine("Takım Sembolü Giriniz:");
            team=char.Parse(Console.ReadLine());    
            if(team =='g'| team== 'G')
            {
                Console.Write("Galatasary:");
            }
            if (team == 'f' | team == 'F')
            {
                Console.Write("Fenerbahce:");
            }
            if (team == 'b' | team == 'B')
            {
                Console.Write("Bursaspor:");
            }
           
            Console.WriteLine("*****C# Eğitim Kampı Resturantı*****");
            Console.WriteLine();
            Console.WriteLine("-----------------");
            Console.WriteLine("1-Ana yemekler:");
            Console.WriteLine("2-Corba:");
            Console.WriteLine("3-Pizzalarr:");
            Console.WriteLine("4-İçecekler:");
            Console.WriteLine("4-Tatlılar:");
            Console.WriteLine("-----------------");
            Console.WriteLine();
            String MenuItem;
            Console.WriteLine("Detaları Görmek istediğiniz menü seçenekleri:");
            MenuItem= Console.ReadLine();
            if(MenuItem == "1") 
            {
                Console.WriteLine();
                Console.WriteLine("----------------Ana yemekler-----------------");
                Console.WriteLine();
                Console.WriteLine("1-Köri soslu tavuk");
                Console.WriteLine("2- Kızartma tabağı");
                Console.WriteLine("3-Fasulye pilav");
                Console.WriteLine("4-Fırında Somon");
                Console.WriteLine("5-Patlıcanlı Musakka");
                Console.WriteLine("----------------Ana yemekler-----------------");
                Console.WriteLine();
            }
            if (MenuItem == "2")
            {
                Console.WriteLine();
                Console.WriteLine("----------------Çorbalarr-----------------");
                Console.WriteLine();
                Console.WriteLine("1-Mercimek Çorbası");
                Console.WriteLine("2- EzoGelin Corbası");
                Console.WriteLine("3-Tarhana Çorbası");
                Console.WriteLine("4-İşkembe Çorbası");
                Console.WriteLine("----------------Corbalar-----------------");
                Console.WriteLine();
            }
            if (MenuItem == "3")
            {
                Console.WriteLine();
                Console.WriteLine("----------------Pizzalar-----------------");
                Console.WriteLine();
                Console.WriteLine("1-Akdeniz Pizza");
                Console.WriteLine("2- Margerita Pizza");
                Console.WriteLine("3-Tavuklu Pizza");
                Console.WriteLine("----------------Pizzalar-----------------");
                Console.WriteLine();
            }
            if (MenuItem == "4")
            {
                Console.WriteLine();
                Console.WriteLine("----------------İçecekler-----------------");
                Console.WriteLine();
                Console.WriteLine("1-Meyve Suyu");
                Console.WriteLine("2- Ayran");
                Console.WriteLine("3-Çay");
                Console.WriteLine("4-Kuşburnu");
                Console.WriteLine("----------------İçecekler-----------------");
                Console.WriteLine();
            }
            if (MenuItem == "5")
            {
                Console.WriteLine();
                Console.WriteLine("----------------Tatlılar-----------------");
                Console.WriteLine();
                Console.WriteLine("1-Kemalpaşa");
                Console.WriteLine("2- Süt Helvası");
                Console.WriteLine("3-Tel Kadayıf");
                Console.WriteLine("4-Sütlac");
                Console.WriteLine("----------------Tatlılar-----------------");
                Console.WriteLine();
            }
            #endregion
            Console.Read(); */
            /* #region switch case


             Console.Write("Lütfen ay giriniz:");
             int montNumber = int.Parse(Console.ReadLine());
             Console.WriteLine();

             switch(montNumber)
             {
                 case 1: Console.Write("Ocak"); break;
                 case 2: Console.Write("Şubat"); break;
                 case 3: Console.Write("Mart"); break;
                 case 4: Console.Write("Nisan"); break;
                 case 5: Console.Write("Mayıs"); break;
                 case 6: Console.Write("Haziran"); break;
                 case 7: Console.Write("Temmuz"); break;
                 case 8: Console.Write("Agustos"); break;
                 case 9: Console.Write("Eylül"); break;
                 case 10: Console.Write("Ekim"); break;
                 case 11: Console.Write("Kasım"); break;
                 case 12: Console.Write("Aralık"); break;
                 default: Console.WriteLine("Hatalı Giriş Yaptınız:"+"!!");break;


             }
             Console.ReadLine();
             #endregion*/

            /* #region  switch case Hesab Makinesi Uygulaması
             int number1, number2 , result;
             char seymbol;
             Console.WriteLine("1.Sayıyı Giriniz:");
             number1=int.Parse(Console.ReadLine());
             Console.WriteLine(" 2.Sayıyı Giriniz:");
             number2 = int.Parse(Console.ReadLine());


             Console.WriteLine("Yapmak istediğiniz ilemi giriniz");
             seymbol=char.Parse(Console.ReadLine());
             switch (seymbol)
             {
                 case '+':
                     result = number1+number2; 
                     Console.Write("Toplam:"+result); break;

                 case '-':
                     result = number1-number2;
                     Console.Write("Fark:" + result); break;

                 case '*':
                     result = number1 * number2;
                     Console.Write("Çarpım:" + result); break;

                 case '/':
                     result = number1 / number2;
                     Console.Write("Bölüm:" + result); break;
             } 
             Console.ReadLine();
             #endregion*/




        }
    }
}
