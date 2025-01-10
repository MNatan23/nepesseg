using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nepesseg
{
    internal class Orszag
    {
      
        
            public string Orszagnev { get; private set; }
            public int Terulet { get; private set; }
            public string Nepesseg { get; private set; }
            public string Fovaros { get; private set; }
            public int FovarosNepesseg { get; private set; }

            public Orszag(string orszagnev, int terulet, int nepesseg, string fovaros, int fovarosNepesseg)
            {
                Orszagnev = orszagnev;
                Terulet = terulet;
                Nepesseg = nepesseg;
                Fovaros = fovaros;
                FovarosNepesseg = fovarosNepesseg;
            }

            public Orszag(string sor)
             
            {
            string[] s = sor.Split(';');
            Orszagnev = s[0];
            Terulet =int.Parse( s[1]);
            Nepesseg = s[2];
            Fovaros = s[3];
            FovarosNepesseg =int.Parse (s[4]);

                // Ebben a konstruktorban is elvégezheti az adatsor felbontását!
                // Ha nem ezt választja, akkor törölje ezt a konstruktort!
            }

            public override string ToString()
            {
                return "";
            }
        }
    }

