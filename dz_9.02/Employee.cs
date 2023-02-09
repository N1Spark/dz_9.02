using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_9._02
{
    public class Employee
    {
        private string FIO { get; set; }
        private string birthday { get; set; }
        private static int tel;
        private string email { get; set; }
        private string post { get; set; }
        private string post_descrip { get; set; }
        private int payday { get; set; }

        public Employee() { }
        public Employee(string f, string b, string e, string p, string p_d, int pay)
        {
            FIO = f;
            birthday = b;
            email = e;
            post = p;
            post_descrip = p_d;
            payday=pay;
        }
        static Employee()
        {
            Console.Write("Введите номер телефона: ");
            tel = Convert.ToInt32(Console.ReadLine());
        }
        public void Print()
        {
            Console.WriteLine($"Full name: {FIO};\nBirthday: {birthday};\nTel: {tel};\nEmail: {email};\nPost: {post};\nPost description: {post_descrip}.");
        }
        public override string ToString()
        {
            return $"Full name: {FIO};\nBirthday: {birthday};\nTel: {tel};\nEmail: {email};\nPost: {post};\nPost description: {post_descrip}.";
        }

        public static Employee operator +(Employee a, int b)
        {
            a.payday += b;
            return a;
        }
        public static Employee operator -(Employee a, int b)
        {
            a.payday -= b;
            return a;
        }
        public static bool operator ==(Employee a, Employee b)
        {
            if(a.payday==b.payday)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Employee a,Employee b)
        {
            if (a.payday != b.payday)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator<(Employee a, Employee b) => (a.payday < b.payday);
        public static bool operator >(Employee a, Employee b) => !(a.payday < b.payday);
    }
}
