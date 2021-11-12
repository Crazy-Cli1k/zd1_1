using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace zd2_2
{
    class Program
    {
        //Колекция List
        /*Написать программу вывода на экран количества сотрудников, чей возраст кратен 3. Тип данных – коллекция.
        В текстовом файле записана информация о людях (фамилия, имя, отчество, возраст, вес через пробел). 
        Иванов Сергей Николаевич 21 64
        Петров Игорь Юрьевич 45 88
        Семёнов Михаил Алексеевич 20 70
        Пиманов Александр Дмитриевич 53 101
        Предусмотреть тестовые ситуации, проект выгрузить в репрозиторий*/
        static void Main(string[] args)
        {

            if (File.Exists("t.txt"))//проверка файла
            {
                StreamReader sr = new StreamReader("t.txt");//создание потока
                Console.WriteLine("Люди, возраст которых кратен 3:\n######");

                    List<string[]> Humans = new List<string[]>();
                    int Counter = 0;
                    
                    while (!sr.EndOfStream)//записываем
                    {
                        string str = sr.ReadLine();
                        Humans.Add(str.Split(' '));
                    }
                    sr.Close();
                try
                {
                    var a = Humans.Where(x => int.Parse(x[3]) % 3 == 0);//если возраст больше 3

                    foreach (string[] x in a)
                    {
                        Console.WriteLine(string.Join(" ", x));//выводим
                        Counter++;
                    }
                }
                catch { Console.WriteLine("Введены некорректные значения!"); }
                Console.WriteLine("######\nВсего людей: " + Counter);

                    Console.ReadKey();

            }else { Console.WriteLine("Файл не найден!"); }
        }
    }
}
    

