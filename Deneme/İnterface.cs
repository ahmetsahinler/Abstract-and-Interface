using System;
namespace İnterface
{
    interface IHayvan
    {
        void İsim(); void AyakSayisi(); void SolunumTürü(); void YaşamAlanı(); void BeslenmeŞekli();
    }
    interface  IOmurgalı : IHayvan
    {

    }
    interface IBalık : IOmurgalı
    {

    }
    class KılıçBalığı : IBalık
    {
        public void İsim() { Console.Write("KılıçBalığı = "); }
        public void AyakSayisi() { Console.Write("Ayak Sayısı: 0, "); }
        public void BeslenmeŞekli() { Console.Write("Beslenme Şekli: Etçil, "); }
        public void SolunumTürü() { Console.Write("Solunum Türü: Solungaçlarla, "); }
        public void YaşamAlanı() { Console.WriteLine("Yaşam Alanı: Okyanus/Deniz "); }
        public void Yazdir()
        {
            İsim();AyakSayisi();BeslenmeŞekli();SolunumTürü();YaşamAlanı();
        }
    }
    class Yunus : IBalık
    {
        public void İsim() { Console.Write("Yunus = "); }
        public void AyakSayisi() { Console.Write("Ayak Sayısı: 0, "); }
        public void BeslenmeŞekli() { Console.Write("Beslenme Şekli: Etçil, "); }
        public void SolunumTürü() { Console.Write("Solunum Türü: Solungaçlarla, "); }
        public void YaşamAlanı() { Console.WriteLine("Yaşam Alanı: Deniz/Nehir "); }
        public void Yazdir()
        {
            İsim();AyakSayisi(); BeslenmeŞekli(); SolunumTürü(); YaşamAlanı();
        }
    }
    interface IKuş : IOmurgalı
    {

    }
    class AğaçKakan : IKuş
    {
        public void İsim() { Console.Write("AğaçKakan = "); }
        public void AyakSayisi() { Console.Write("Ayak Sayısı: 2, "); }
        public void BeslenmeŞekli() { Console.Write("Beslenme Şekli: Etçil, "); }
        public void SolunumTürü() { Console.Write("Solunum Türü: Akciğer, "); }
        public void YaşamAlanı() { Console.WriteLine("Yaşam Alanı: Orman "); }
        public void Yazdir()
        {
            İsim();AyakSayisi(); BeslenmeŞekli(); SolunumTürü(); YaşamAlanı();
        }
    }
    class Kartal : IKuş
    {
        public void İsim() { Console.Write("Kartal = "); }
        public void AyakSayisi() { Console.Write("Ayak Sayısı: 2, "); }
        public void BeslenmeŞekli() { Console.Write("Beslenme Şekli: Etçil, "); }
        public void SolunumTürü() { Console.Write("Solunum Türü: Akciğer, "); }
        public void YaşamAlanı() { Console.WriteLine("Yaşam Alanı: Dağ/Orman "); }
        public void Yazdir()
        {
            İsim();AyakSayisi(); BeslenmeŞekli(); SolunumTürü(); YaşamAlanı();
        }
    }
    interface IOmurgasız : IHayvan
    {

    }
    interface ISolucan : IOmurgasız
    {

    }
    class KılımsıSolucan : ISolucan
    {
        public void İsim() { Console.Write("KılımsıSolucan = "); }
        public void AyakSayisi() { Console.Write("Ayak Sayısı: 0, "); }
        public void BeslenmeŞekli() { Console.Write("Beslenme Şekli: Otçul, "); }
        public void SolunumTürü() { Console.Write("Solunum Türü: Deri, "); }
        public void YaşamAlanı() { Console.WriteLine("Yaşam Alanı: Toprak "); }
        public void Yazdir()
        {
            İsim();AyakSayisi(); BeslenmeŞekli(); SolunumTürü(); YaşamAlanı();
        }
    }
    class HortumluSolucan : ISolucan
    {
        public void İsim() { Console.Write("HortumluSolucan = "); }
        public void AyakSayisi() { Console.Write("Ayak Sayısı: 0, "); }
        public void BeslenmeŞekli() { Console.Write("Beslenme Şekli: Otçul, "); }
        public void SolunumTürü() { Console.Write("Solunum Türü: Deri, "); }
        public void YaşamAlanı() { Console.WriteLine("Yaşam Alanı: Toprak "); }
        public void Yazdir()
        {
            İsim();AyakSayisi(); BeslenmeŞekli(); SolunumTürü(); YaşamAlanı();
        }
    }
    interface ISürüngen : IOmurgasız
    {

    }
    class Kaplumbağa : ISürüngen
    {
        public void İsim() { Console.Write("Kaplumbağa = "); }
        public void AyakSayisi() { Console.Write("Ayak Sayısı: 4, "); }
        public void BeslenmeŞekli() { Console.Write("Beslenme Şekli: Otçul, "); }
        public void SolunumTürü() { Console.Write("Solunum Türü: Akciğer, "); }
        public void YaşamAlanı() { Console.WriteLine("Yaşam Alanı: Kara/Deniz "); }
        public void Yazdir()
        {
            İsim();AyakSayisi(); BeslenmeŞekli(); SolunumTürü(); YaşamAlanı();
        }
    }
    class Kertenkele : ISürüngen
    {
        public void İsim() { Console.Write("Kertenkele = "); }
        public void AyakSayisi() { Console.Write("Ayak Sayısı: 4, "); }
        public void BeslenmeŞekli() { Console.Write("Beslenme Şekli: Etçil/Otçul, "); }
        public void SolunumTürü() { Console.Write("Solunum Türü: Akciğer, "); }
        public void YaşamAlanı() { Console.WriteLine("Yaşam Alanı: Toprak "); }
        public void Yazdir()
        {
            İsim(); AyakSayisi(); BeslenmeŞekli(); SolunumTürü(); YaşamAlanı();
        }
    }

}
