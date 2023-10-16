using Abstract;
using İnterface;
using System;

namespace Deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KöpekBalığı köpekBalığı = new KöpekBalığı();
            köpekBalığı.Yazdir();
            Balina balina = new Balina();
            balina.Yazdir();
            Papağan papağan = new Papağan();
            papağan.Yazdir();
            Kanarya kanarya= new Kanarya();
            kanarya.Yazdir();
            HalkalıSolucan halkalıSolucan = new HalkalıSolucan();
            halkalıSolucan.Yazdir();
            YuvarlakSolucan yuvarlakSolucan = new YuvarlakSolucan();
            yuvarlakSolucan.Yazdir();
            Yılan yılan = new Yılan();
            yılan.Yazdir();
            Timsah timsah = new Timsah();
            timsah.Yazdir();
            
            Console.WriteLine("*********************************************************************************");

            KılıçBalığı kılıçBalığı = new KılıçBalığı();
            kılıçBalığı.Yazdir();
            Yunus yunus = new Yunus();
            yunus.Yazdir();
            AğaçKakan ağaçKakan = new AğaçKakan();
            ağaçKakan.Yazdir();
            Kartal kartal = new Kartal();
            kartal.Yazdir();
            KılımsıSolucan kılımsıSolucan = new KılımsıSolucan();
            kılımsıSolucan.Yazdir();
            HortumluSolucan hortumluSolucan = new HortumluSolucan();
            hortumluSolucan.Yazdir();
            Kaplumbağa kaplumbağa = new Kaplumbağa();
            kaplumbağa.Yazdir();
            Kertenkele kertenkele = new Kertenkele();
            kertenkele.Yazdir();
        }
    }
}
