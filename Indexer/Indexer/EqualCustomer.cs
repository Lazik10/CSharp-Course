using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal class EqualCustomer
    {
        public string jmeno;
        public string prijmeni;
        public DateTime datumNarozeni;

        public EqualCustomer(string jmeno, string prijmeni, DateTime datumNarozeni)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.datumNarozeni = datumNarozeni;
        }

        // přepsání metody Equals
        public override bool Equals(object? obj)
        {
            // kontrola typu objektu a hodnoty pomocí níže přetíženého operátoru
            return ((obj is EqualCustomer) && (this == (EqualCustomer)obj));
        }

        // přetížení i operátoru == (nebere se z Equals!)
        public static bool operator ==(EqualCustomer a, EqualCustomer b)
        {
            return ((a.jmeno == b.jmeno) && (a.prijmeni == b.prijmeni) && (a.datumNarozeni == b.datumNarozeni));
        }

        // při přetížení operátoru == musíme přetížit i operátor !=, využijeme k tomu hodnotu ==
        public static bool operator !=(EqualCustomer a, EqualCustomer b)
        {
            return !(a == b);
        }

        // přepsání generování hash kódu objektu (nutné pro přetížení metody Equals())
        public override int GetHashCode()
        {
            return jmeno.GetHashCode() ^ prijmeni.GetHashCode() ^ datumNarozeni.GetHashCode();
            // u číselných atributů (např. typu int) je hashkód přímo jejich hodnota
        }

        public override string ToString()
        {
            return jmeno + " " + prijmeni + " " + datumNarozeni.ToLongDateString();
        }
    }
}
