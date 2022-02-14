using App17;
//Console.WriteLine("Введите числовой номер счета");
//int numInt = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите ФИО");
//string name = Console.ReadLine();
//Console.WriteLine("Введите Баланс");
//int balance = Convert.ToInt32(Console.ReadLine());

//Bank<int> bank1 = new Bank<int>(numInt, name,balance );
//Console.WriteLine(bank1.GetInfo());

//Console.WriteLine("Введите строковый номер счета");
//string numString = Console.ReadLine();
//Console.WriteLine("Введите ФИО");
//name = Console.ReadLine();
//Console.WriteLine("Введите Баланс");
//balance = Convert.ToInt32(Console.ReadLine());

//Bank<string> bank2 = new Bank<string>( numString, name,balance);
//Console.WriteLine(bank2.GetInfo());
Bank<int> bank1 = new Bank<int>();
bank1.Input();
Console.WriteLine(bank1.GetInfo());

Bank<string> bank2 = new Bank<string>();
bank2.Input();
Console.WriteLine(bank2.GetInfo());





