using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_9._02
{
    class Credit
    {
        public string Num_Card { get; set; }
        public string name { get; set; }
        public int CVC { get; set; }
        public string Data_End { get; set; }
        public int money { get; set; }

        public Credit()
        {

        }
        public Credit(string n_c, string n, int c, string d)
        {
            Num_Card = n_c;
            name = n;
            CVC = c;
            Data_End = d;
        }

        public void Print()
        {
            Console.WriteLine($"Num_Card: {Num_Card};\nName: {name};\nCVC: {CVC};\nData End: {Data_End}.");
        }
        public override string ToString()
        {
            return $"Num_Card: {Num_Card};\nName: {name};\nCVC: {CVC};\nData End: {Data_End}.";
        }

        public static Credit operator +(Credit a, int b)
        {
            a.money += b;
            return a;
        }
        public static Credit operator -(Credit a, int b)
        {
            a.money -= b;
            return a;
        }
        public static bool operator ==(Credit a, Credit b)
        {
            if (a.CVC == b.CVC)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Credit a, Credit b)
        {
            if (a.CVC != b.CVC)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(Credit a, Credit b) => (a.CVC < b.CVC);
        public static bool operator >(Credit a, Credit b) => !(a.CVC < b.CVC);
    }
}
