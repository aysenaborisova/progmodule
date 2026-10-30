/*
using System;
using System.Collections.Generic;

class Task4
{
    static void Main()
    {
        Dictionary<string, string> book = new Dictionary<string, string>();

        while (true)
        {
            Console.WriteLine("Команды: добавить, поиск, просмотр, выход");
            Console.Write("Введите команду: ");
            string command = Console.ReadLine();

            if (command == "выход")
            {
                break;
            }
            else if (command == "добавить")
            {
                Console.Write("Введите имя: ");
                string name = Console.ReadLine();
                Console.Write("Введите номер телефона: ");
                string phone = Console.ReadLine();
                book[name] = phone;
                Console.WriteLine("Контакт добавлен");
            }
            else if (command == "поиск")
            {
                Console.Write("Введите имя: ");
                string name = Console.ReadLine();
                if (book.ContainsKey(name))
                {
                    Console.WriteLine(name + ": " + book[name]);
                }
                else
                {
                    Console.WriteLine("Контакт не найден");
                }
            }
            else if (command == "просмотр")
            {
                foreach (var contact in book)
                {
                    Console.WriteLine(contact.Key + ": " + contact.Value);
                }
            }
            else
            {
                Console.WriteLine("Неизвестная команда");
            }
        }
    }
}
*/
