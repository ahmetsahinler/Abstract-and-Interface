using System;
namespace Abstract
{

    abstract class Hayvan
    {
        abstract public void hayvan();
        abstract public void isim();
    }
    abstract class Omurgalılar : Hayvan
    {
        abstract public void omurgalı();
    }
    abstract class Balıklar : Omurgalılar
    {
        abstract public void balık();
    }
    class KöpekBalığı : Balıklar
    {
        public override void hayvan(){Console.Write("Hayvan; ");}
        public override void omurgalı(){ Console.Write("Omurgalı; ");}
        public override void balık(){Console.Write("Balık; ");}
        public override void isim(){Console.WriteLine("Köpek Balığı");}
        public void Yazdir()
        {
            hayvan(); omurgalı(); balık(); isim();
        }
    }
    class Balina : Balıklar
    {
        public override void hayvan(){Console.Write("Hayvan; ");}
        public override void omurgalı(){Console.Write("Omurgalı; ");}
        public override void balık(){Console.Write("Balık; ");}
        public override void isim(){Console.WriteLine("Balina");}
        public void Yazdir()
        {
            hayvan(); omurgalı(); balık(); isim();
        }
    }
    abstract class Kuşlar : Omurgalılar
    {
        abstract public void kuş();
    }
    class Papağan : Kuşlar
    {
        public override void hayvan(){Console.Write("Hayvan; "); }
        public override void omurgalı(){Console.Write("Omurgalı; ");}
        public override void kuş(){Console.Write("Kuş; ");}
        public override void isim(){Console.WriteLine("Papağan");}
        public void Yazdir()
        {
            hayvan(); omurgalı(); kuş(); isim();
        }
    }
    class Kanarya : Kuşlar
    {
        public override void hayvan(){Console.Write("Hayvan; ");}
        public override void omurgalı(){Console.Write("Omurgalı; ");}
        public override void kuş(){Console.Write("Kuş; ");}
        public override void isim(){ Console.WriteLine("Kanarya");}
        public void Yazdir()
        {
            hayvan(); omurgalı(); kuş(); isim();
        }
    }

    abstract class Omurgasız : Hayvan
    {
        abstract public void omurgasız();
    }
    abstract class Solucanlar : Omurgasız
    {
        abstract public void solucan();
    }
    class YuvarlakSolucan : Solucanlar
    {
        public override void hayvan(){Console.Write("Hayvan; ");}
        public override void omurgasız(){Console.Write("Omurgasız; ");}
        public override void solucan(){Console.Write("Solucan; ");}
        public override void isim(){Console.WriteLine("Yuvarlak Solucan");}
        public void Yazdir()
        {
            hayvan(); omurgasız(); solucan(); isim();
        }
    }
    class HalkalıSolucan : Solucanlar
    {
        public override void hayvan(){Console.Write("Hayvan; ");}
        public override void omurgasız(){Console.Write("Omurgasız; ");}
        public override void solucan(){Console.Write("Solucan; ");}
        public override void isim(){Console.WriteLine("Halkalı Solucan");}
        public void Yazdir()
        {
            hayvan(); omurgasız(); solucan(); isim();
        }
    }
    abstract class Sürüngenler : Omurgasız
    {
        abstract public void sürüngen();
    }
    class Yılan : Sürüngenler
    {
        public override void hayvan(){Console.Write("Hayvan; ");}
        public override void omurgasız(){Console.Write("Omurgasız; ");}
        public override void sürüngen(){Console.Write("Sürüngen; ");}
        public override void isim(){Console.WriteLine("Yılan");}
        public void Yazdir()
        {
            hayvan(); omurgasız(); sürüngen(); isim();
        }
    }
    class Timsah : Sürüngenler
    {
        public override void hayvan(){Console.Write("Hayvan; ");}
        public override void omurgasız(){Console.Write("Omurgasız; ");}
        public override void sürüngen(){Console.Write("Sürüngen; ");}
        public override void isim(){Console.WriteLine("Timsah");}
        public void Yazdir()
        {
            hayvan(); omurgasız(); sürüngen(); isim();
        }
    }

}