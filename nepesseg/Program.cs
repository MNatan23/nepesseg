using System.Threading.Channels;

namespace nepesseg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Orszag> orszagok = new();
            foreach (var sor in File.ReadAllLines("adatok-utf8.txt").Skip(1))

                foreach (var g in orszagok);
                {
                if (true)
                {

                }
                }
            {

                orszagok.Add(new Orszag(sor));
            }
            Console.WriteLine($"4.feladat \n A beolvasott országainak száma {orszagok.Count}");
        }
        
    }
}
