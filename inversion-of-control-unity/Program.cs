using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace inversion_of_control_unity
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();

            /* 
             * Registers all the dependencies
             */
            container.RegisterType<Customer>();
            container.RegisterType<Idal, SQLServer>();
            //container.RegisterType<Idal, Oracle>();

            /* 
             * Resolves the depedencies
             */
            Customer customer = container.Resolve<Customer>();

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
