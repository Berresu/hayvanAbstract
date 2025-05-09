using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public abstract class Hayvan
        {
            public abstract void SesCikar();

            public void Uyuma()
            {
                Console.WriteLine("Hayvan Uyuyor...zzz");
            }
        }

        public class Kedi : Hayvan
        {
            public override void SesCikar()
            {
                Console.WriteLine("Miyav miyav!");
            }
        }

        public class Kopek : Hayvan
        {
            public override void SesCikar()
            {
                Console.WriteLine("Hav hav!");
            }
        }

        public class Kus : Hayvan
        {
            public override void SesCikar()
            {
                Console.WriteLine("Cik cik!");
            }
        }

        static void Main(string[] args)
        {
            Hayvan kedi = new Kedi();
            kedi.SesCikar();
            kedi.Uyuma();

            Hayvan kopek = new Kopek();
            kopek.SesCikar();
            kopek.Uyuma();  

            Hayvan kus = new Kus();
            kus.SesCikar();
            kus.Uyuma();
        }
    }
}
