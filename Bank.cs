using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App17
{
    class Bank<T>
    {
    public T Number { get; set; }
    public int Balance { get; set; }
    public string? Name { get; set; }

        //public Bank(T num, string name, int balance)
        //{
        //    Number = num;
        //    Name = name;
        //    Balance = balance;
        //}

        public string GetInfo()
        {
            return $"{Number} {Name} {Balance}";
        }
        public void Input()
        {
            Console.WriteLine("Введите номер счета");
            Number =(T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            Console.WriteLine("Введите ФИО");
            Name = Console.ReadLine();
            Console.WriteLine("Введите Баланс");
            Balance = Convert.ToInt32(Console.ReadLine());
        }
     }
}