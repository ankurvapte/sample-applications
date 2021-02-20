using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dependency_injection
{
    class Program
    {
        static void Main(string[] args)
        {
            // TeacherService student = new TeacherService();
            BusinessLogicService service = new BusinessLogicService(new TeacherService());

            Console.ReadKey();
        }

        public class BusinessLogicService
        {
            private IService service;

            public BusinessLogicService(IService _service)
            {
                this.service = _service;
                this.service.GetFirstName();
                this.service.GetLastName();
            }
        }

        public interface IService
        {
            void GetFirstName();
            void GetLastName();
        }

        public class StudentService : IService
        {
            public void GetFirstName()
            {
                Console.Write("Ankur");
            }

            public void GetLastName()
            {
                Console.Write("Apte");
            }
        }

        public class TeacherService : IService
        {
            public void GetFirstName()
            {
                Console.Write("Sujata");
            }

            public void GetLastName()
            {
                Console.Write("Apte");
            }
        }
    }
}
