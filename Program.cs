using System;

namespace SehirBolgeleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Şehir Bölge Bulma Programı");
            Console.WriteLine("--------------------------");

            Console.Write("Bir şehir giriniz: ");
            string sehir = Console.ReadLine().ToLower();

            string bolge = BolgeBul(sehir);

            if (bolge == null)
            {
                Console.WriteLine("Girdiğiniz şehir veri tabanında bulunamadı.");
            }
            else
            {
                Console.WriteLine($"{sehir} şehri {bolge} bölgesindedir.");
            }

            Console.ReadLine();
        }

        static string BolgeBul(string a)
        {
            if (a == "ankara" || a == "konya" || a == "kayseri" || a == "sivas" ||
                a == "yozgat" || a == "nevşehir" || a == "niğde" || a == "kırşehir" ||
                a == "kırıkkale" || a == "karaman" || a == "eskişehir" || a == "çankırı")
                return "İç Anadolu";

            else if (a == "trabzon" || a == "rize" || a == "ordu" || a == "giresun" ||
                     a == "samsun" || a == "sinop" || a == "tokat" || a == "bolu" ||
                     a == "zonguldak" || a == "kastamonu" || a == "bartın" ||
                     a == "karabük" || a == "amasya")
                return "Karadeniz";

            else if (a == "istanbul" || a == "kocaeli" || a == "sakarya" || a == "bursa" ||
                     a == "bilecik" || a == "yalova" || a == "balıkesir" ||
                     a == "çanakkale" || a == "edirne" || a == "tekirdağ" ||
                     a == "kırklareli")
                return "Marmara";

            else if (a == "izmir" || a == "manisa" || a == "afyonkarahisar" ||
                     a == "denizli" || a == "uşak" || a == "kütahya" ||
                     a == "aydın" || a == "muğla")
                return "Ege";

            else if (a == "antalya" || a == "adana" || a == "hatay" || a == "osmaniye" ||
                     a == "kahramanmaraş" || a == "ısparta" || a == "burdur" ||
                     a == "mersin")
                return "Akdeniz";

            else if (a == "van" || a == "bitlis" || a == "muş" || a == "ağrı" ||
                     a == "kars" || a == "ığdır" || a == "ardahan" || a == "tunceli" ||
                     a == "bingöl" || a == "erzincan" || a == "erzurum" ||
                     a == "malatya" || a == "elazığ" || a == "hakkari")
                return "Doğu Anadolu";

            else if (a == "diyarbakır" || a == "mardin" || a == "batman" || a == "şırnak" ||
                     a == "gaziantep" || a == "kilis" || a == "adıyaman" ||
                     a == "siirt" || a == "şanlıurfa")
                return "Güneydoğu Anadolu";

            return null;
        }
    }
}
