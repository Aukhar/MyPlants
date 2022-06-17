using System;

namespace MyPlants.View
{
    internal class MyConsole
    {
        private Controller.RecordController records;
        public MyConsole(string path)
        {
            try
            {
                records = new Controller.RecordController(path);
                Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Start()
        {
            PrintMenu();
            while (true)
            {
                try
                {
                    switch (GetStringConsole("Введите команду -").ToLower())
                    {
                        case "/help": PrintMenu(); break;
                        case "/get": GetPlants(); break;
                        case "/add": AddPlants(); break;
                        case "/exit": return;
                        default:
                            Console.WriteLine("Неизвестная команда!"); break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        private void AddPlants()
        {
            string NameOfDrink = GetStringConsole("Введите название растения");
            string TypeOfDrink = GetStringConsole("Укажите тип растения : (к примеру: роза, кустарник и тд) ");
            records.add(NameOfDrink, TypeOfDrink);
            Console.WriteLine("Растение добавлено :)");
            GetPlants();
        }
        private void GetPlants()
        {
            if (records.Records.Count == 0)
            {
                Console.WriteLine("Добавленные растения отсутствуют!");
                return;
            }
            foreach (var item in records.Records)
            {
                Console.WriteLine(item);
            }
        }
        private void PrintMenu()
        {
            Console.WriteLine("/help - список команд");
            Console.WriteLine("/get - получить список растений");
            Console.WriteLine("/add - добавить новое растение");
            Console.WriteLine("/exit - выход из программы");
        }
        private string GetStringConsole(string v)
        {
            Console.WriteLine(v);
            var s = Console.ReadLine();
            if (string.IsNullOrEmpty(s))
            {
                Console.WriteLine("Некорректный ввод!");
                return GetStringConsole(v);
            }
            return s.TrimStart().TrimEnd();
        }
    }
}