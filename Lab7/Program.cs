using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace consoleapp_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //род класс - собаки
            //наследники - банхары :3
            Dogs dog1 = new Dogs("Дымка", "Нигмир");
            Bankhars bankhar1 = new Bankhars("Джеки", "Дарина", 170, "ГАВ");
            Dogs dog2 = new Bankhars("Блэк", "Дольган", 210, "ГАВГАВ");
            
            dog1.Print();
            dog2.Print();
            bankhar1.Print();
            bankhar1.Voice();
            
            Bankhars bankhar2 = dog2 as Bankhars;
            bankhar2.Print();

            Dogs[] dogs = new Dogs[] { dog1, dog2, bankhar1, bankhar2 };
        }
    }

    public class Dogs
    {
        protected string _name;
        protected string _owner;
        
        public string Name => _name;
        public string Owner => _owner;

        public Dogs(string name, string owner)
        {
            _name = name;
            _owner = owner;
        }

        public virtual void Method()
        {
            Console.WriteLine("Dogs method");
        }

        public virtual void Voice()
        {
            Console.WriteLine("тяф");
        }

        public void Print()
        {
            Console.WriteLine($"Моя собака: {_name}");
            Console.WriteLine($"Хозяин: {_owner}");
        }
    }

    public class Bankhars : Dogs
    {
        private int _size;
        private string _voice;

        public Bankhars(string name, string owner, int size, string voice) : base(name, owner)
        {
            _name = name;
            _owner = owner;
            _size = size;
            _voice = voice;
        }

        public override void Method()
        {
            Console.WriteLine("Bankhars method");
        }

        public override void Voice()
        {
            Console.WriteLine("гав!");
        }

        public void Print()
        {
            Console.WriteLine($"Моя собака: {_name}");
            Console.WriteLine($"Хозяин: {_owner}");
        }
    }
}
