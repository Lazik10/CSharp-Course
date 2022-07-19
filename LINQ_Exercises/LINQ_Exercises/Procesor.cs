using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Exercises
{
    public class Procesor
    {
        public string Nazev { get; private set; }
        public int PocetJader { get; private set; }
        public int PocetVlaken { get; private set; }
        public double Frekvence { get; private set; }
        public decimal Cena { get; private set; }
        public int KusuSkladem { get; private set; }
        public int VyrovnacaciPamet { get; private set; }

        public Procesor(string nazev, int pocetJader, int pocetVlaken, double frekvence, int vyrovnacaciPamet, decimal cena, int kusuSkladem)
        {
            Nazev = nazev;
            PocetJader = pocetJader;
            PocetVlaken = pocetVlaken;
            Frekvence = frekvence;
            Cena = cena;
            KusuSkladem = kusuSkladem;
            VyrovnacaciPamet = vyrovnacaciPamet;
        }
    }

    public class ProcesorComparer : IComparer<Procesor>
    {
        public enum SortBy
        {
            Cena,
            KusuSkladem,
            Frekvence,
            PocetJader,
            Vlakna,
            VyrovnavaciPamet,
        }

        public ProcesorComparer(SortBy sortBy)
        {
            compareByFields = sortBy;
        }

        //Sort two employee Ages  
        public SortBy compareByFields = SortBy.Cena;

        public int Compare(Procesor? x, Procesor? y)
        {
            switch (compareByFields)
            {
                case SortBy.Cena:
                    return x.Cena.CompareTo(y.Cena);
                case SortBy.KusuSkladem:
                    return x.KusuSkladem.CompareTo(y.KusuSkladem);
                case SortBy.Frekvence:
                    return x.Frekvence.CompareTo(y.Frekvence);
                case SortBy.PocetJader:
                    {
                        int compare = x.PocetJader.CompareTo(y.PocetJader);
                        if (compare == 0)
                            compare = x.PocetVlaken.CompareTo(y.PocetVlaken);
                        return compare;
                    }
                case SortBy.Vlakna:
                    return x.PocetVlaken.CompareTo(y.PocetVlaken);
                case SortBy.VyrovnavaciPamet:
                    return x.VyrovnacaciPamet.CompareTo(y.VyrovnacaciPamet);
                default:
                    break;
            }
            return x.Cena.CompareTo(y.Cena);
        }
    }
}
