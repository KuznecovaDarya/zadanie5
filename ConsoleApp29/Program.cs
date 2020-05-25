using System;
using static System.Convert;
using static System.Console;
using System.Collections.Generic;

namespace ConsoleApp29
{
    class lab
    {
        public class student
        {
            public string id;
            public string fio;
            public string group;
            public string data;
        }
        public List<student> list = new List<student>();
        public void add(string id, string fio, string group, string data)
        {
            list.Add(new student() { id = id, fio = fio, group = group, data = data });
        }
        public void del(string id)
        {

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].id == id) list.RemoveAt(i); 
            }

        }
        public void izmenie(string id, string fio, string group, string data)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].id == id)
                {
                    list[i].fio = fio;
                    list[i].group = group;
                    list[i].data = data;
                }
            }
        }


        public void show()
        {

            foreach (var i in list)
            {
                Console.WriteLine(i.id + " " + i.fio + " " + i.group + " " + i.data);
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            lab a = new lab();
            WriteLine("1 - Добавление студента.\n2 - Изменение данных о студенте.\n3 - Удаление студента.\n4 - Вывод всех студентов.");
            int n = ToInt32(ReadLine());

            while (n > 0)
            {
                if (n == 1)
                {
                    WriteLine("ID: "); string id = ReadLine();
                    WriteLine("ФИО: "); string fio = ReadLine();
                    WriteLine("Группа: "); string group = ReadLine();
                    WriteLine("Дата: "); string data = ReadLine();

                    a.add(id, fio, group, data);
                    WriteLine("Введи следующее действие: ");
                    n = ToInt32(ReadLine());
                }
                else if (n == 2)
                {
                    WriteLine("Введи ID и измененные данные: ");
                    WriteLine("ID: "); string id = ReadLine();
                    WriteLine("ФИО: "); string fio = ReadLine();
                    WriteLine("Группа: "); string group = ReadLine();
                    WriteLine("Дата: "); string data = ReadLine();
                    a.izmenie(id, fio, group, data);
                    WriteLine("Введи следующее действие: ");
                    n = ToInt32(ReadLine());
                }
                else if (n == 3)
                {
                    WriteLine("Введи ID: ");
                    string id = ReadLine();
                    a.del(id);
                    WriteLine("Введи следующее действие: ");
                    n = ToInt32(ReadLine());
                }
                else if (n == 4)
                {
                    a.show();
                    WriteLine("Введи следующее действие: ");
                    n = ToInt32(ReadLine());
                }
            }
        }
    }
}
