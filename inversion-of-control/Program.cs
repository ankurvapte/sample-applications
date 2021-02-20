using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inversion_of_control
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(new Oracle());
            customer.Add();
            Console.ReadKey();
        }

        class Customer
        {
            private Idal dal;

            public Customer(Idal _dal)
            {
                dal = _dal;
            }

            public bool Validate()
            {
                return true;
            }

            public void Add()
            {
                if (Validate()) dal.Add();
            }
        }

        interface Idal
        {
            void Add();
        }

        public class SQLServer : Idal
        {
            public void Add()
            { }
        }

        public class Oracle : Idal
        {
            public void Add()
            { }
        }
    }
}
