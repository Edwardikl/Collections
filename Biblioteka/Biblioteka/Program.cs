using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary d = new Dictionary(); 

            Console.Write("Введите ключ: ");
            string usersKey = Console.ReadLine();

            string r = d.viviodProverki(usersKey);
            Console.WriteLine(r);

            d.removeEl(usersKey);

            Console.WriteLine("Оставшиеся элементы:");
            d.viviodostavhihsa();

            d.Opystoshit();
            d.viviodostavhihsa();//для проверки, что там ничего нет
            Console.WriteLine("Все элементы удалены.");
        }

        class Dictionary
        {
            public Dictionary<string, string> d;

            public Dictionary()
            {
                d = new Dictionary<string, string>
                 {
                    { "10", "Edwardikl"},
                    { "23", "Runusov"},
                    { "56", "Paletal"},
                    { "45", "Foxi_all"},
                    { "3", "ZzZz..."},
                    { "9", "_Rip_"},
                    { "99", "Sexi-Dimka"},
                    { "57", "lol"},
                    { "62", "Zaraza"},
                    { "11", "228_zXz"}
                 };
            }

            public string viviodProverki(string key)
            {
                if (d.ContainsKey(key))
                {
                    return d[key];
                }
                else
                {
                    return $"Ключ '{key}' не найден в словаре.";
                }
            }

            public void removeEl(string key)
            {
                if (d.ContainsKey(key))
                {
                    d.Remove(key);
                }
            }

            public void viviodostavhihsa()
            {
                var keys = d.Keys.ToList(); // для получения списка ключей из словаря, чтобы перебрать в for

                for (int i = 0; i < keys.Count; i++)
                {
                    string key = keys[i];
                    string value = d[key];
                    Console.WriteLine($"Ключ: {key}, Значение: {value}");
                }
            }

            public void Opystoshit()
            {
                d.Clear();
            }
        }
    }
}
