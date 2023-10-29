using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace tortiki
{
    internal class menuosnova
    {
        private static int pos2;
        private static List<menu2> zakaz = new List<menu2>();
        private static List<menu1> men1 = new List<menu1>();
        private static List<menu2> men2 = new List<menu2>();
        public void menu()
        {
           List<string> menstr = new List<string>();
           string men02 = "";
           int men02int = 0;
           string men03 = "";
           int men03int = 0;
           string men04 = "";
           int men04int = 0;
           int price = 0;
            menu1 menu01 = new menu1();
            menu01.zapi1 = "Заказ тортов в тортичной У ДЯДИ ЯРИКА, тортЫ на ваш выбор";
            menu01.zapi2 = "Выберити комплектующие торта";
            menu01.zapi3 = "----------------------------------------------------------";
            menu01.zapi4 = "  Форма торта";
            menu01.zapi5 = "  Размер торта";
            menu01.zapi6 = "  Вкус коржей";
            menu01.zapi7 = "  Количестко коржей";
            menu01.zapi8 = "  Глазурь";
            menu01.zapi9 = "  Декор";
            menu01.zapi10 = "  Конец заказа";
            menu01.zapi11 = "*********************************************************";
            menu01.zapi12 = "Цена: ";

            menu2 menu02 = new menu2();
            menu02.zapi1 = "Для выхода выберите пункт 'Ничего'";
            menu02.zapi2 = "Выберите пункт из меню:";
            menu02.zapi3 = "-------------------------";
            menu02.zapi4 = "  Параллелепипед";
            menu02.zapi5 =  500;
            menu02.zapi6 = "  Корпус нахима";
            menu02.zapi7 = 200;
            menu02.zapi8 = "  Корпус нежки";
            menu02.zapi9 = 800;
            menu02.zapi10 = "  Ничего(Выйти)";

            menu2 menu03 = new menu2();
            menu03.zapi1 = "Для выхода выберите пункт 'Ничего'";
            menu03.zapi2 = "Выберите пункт из меню:";
            menu03.zapi3 = "-------------------------";
            menu03.zapi4 = "  Большой";
            menu03.zapi5 = 700;
            menu03.zapi6 = "  Средний";
            menu03.zapi7 = 500;
            menu03.zapi8 = "  Маленький";
            menu03.zapi9 = 300;
            menu03.zapi10 = "  Ничего(Выйти)";

            menu2 menu04 = new menu2();
            menu04.zapi1 = "Для выхода выберите пункт 'Ничего'";
            menu04.zapi2 = "Выберите пункт из меню:";
            menu04.zapi3 = "-------------------------";
            menu04.zapi4 = "  Слабости";
            menu04.zapi5 = 100;
            menu04.zapi6 = "  Отчаяния";
            menu04.zapi7 = 300;
            menu04.zapi8 = "  Вкусный";
            menu04.zapi9 = 1000;
            menu04.zapi10 = "  Ничего(Выйти)";

            menu2 menu05 = new menu2();
            menu05.zapi1 = "Для выхода выберите пункт 'Ничего'";
            menu05.zapi2 = "Выберите пункт из меню:";
            menu05.zapi3 = "-------------------------";
            menu05.zapi4 = "  Два";
            menu05.zapi5 = 200;
            menu05.zapi6 = "  Три";
            menu05.zapi7 = 400;
            menu05.zapi8 = "  Пять";
            menu05.zapi9 = 600;
            menu05.zapi10 = "  Ничего(Выйти)";

            menu2 menu06 = new menu2();
            menu06.zapi1 = "Для выхода выберите пункт 'Ничего'";
            menu06.zapi2 = "Выберите пункт из меню:";
            menu06.zapi3 = "-------------------------";
            menu06.zapi4 = "  Шоколадная";
            menu06.zapi5 =  100;
            menu06.zapi6 = "  Клубничная";
            menu06.zapi7 =  300;
            menu06.zapi8 = "  Белая";
            menu06.zapi9 = 500;
            menu06.zapi10 = "  Ничего(Выйти)";

            menu2 menu07 = new menu2();
            menu07.zapi1 = "Для выхода выберите пункт 'Ничего'";
            menu07.zapi2 = "Выберите пункт из меню:";
            menu07.zapi3 = "-------------------------";
            menu07.zapi4 = "  Фрукты";
            menu07.zapi5 = 400;
            menu07.zapi6 = "  Овощи";
            menu07.zapi7 = 300;
            menu07.zapi8 = "  Посыпка";
            menu07.zapi9 = 500;
            menu07.zapi10 = "  Ничего(Выйти)";

            men1.Add(menu01);


            men2.Add(menu02);
            men2.Add(menu03);
            men2.Add(menu04);
            men2.Add(menu05);
            men2.Add(menu06);
            men2.Add(menu07);
            do
            {
                for (int i = 0; i == 0; i++)
                {
                    Console.WriteLine(men1[i].zapi1);
                    Console.WriteLine(men1[i].zapi2);
                    Console.WriteLine(men1[i].zapi3);
                    Console.WriteLine(men1[i].zapi4);
                    Console.WriteLine(men1[i].zapi5);
                    Console.WriteLine(men1[i].zapi6);
                    Console.WriteLine(men1[i].zapi7);
                    Console.WriteLine(men1[i].zapi8);
                    Console.WriteLine(men1[i].zapi9);
                    Console.WriteLine(men1[i].zapi10);
                    Console.WriteLine(men1[i].zapi11);
                    Console.WriteLine(men1[i].zapi12 + price);
                    Console.WriteLine("Ваш заказ:");

                    foreach (var item in zakaz)
                    {
                        if (pos2 == 3)
                        {
                            Console.WriteLine(item.zapi4);
                        }
                        if (pos2 == 4)
                        {
                            Console.WriteLine(item.zapi6);
                        }
                        if (pos2 == 5)
                        {
                            Console.WriteLine(item.zapi8);
                        }
                    }
                }
                int pos = strelka.show(3, 9);
                if (pos != 9)
                {
                    ConsoleKeyInfo key;
                    do
                    {
                       
                        key = Console.ReadKey();
                        Console.Clear();
                        for (int i = pos-3; i == pos-3; i++)
                        {
                            Console.WriteLine(men2[i].zapi1);
                            Console.WriteLine(men2[i].zapi2);
                            Console.WriteLine(men2[i].zapi3);
                            Console.WriteLine(men2[i].zapi4 + " - " + men2[i].zapi5);
                            Console.WriteLine(men2[i].zapi6 + " - " + men2[i].zapi7);
                            Console.WriteLine(men2[i].zapi8 + " - " + men2[i].zapi9);
                            Console.WriteLine(men2[i].zapi10);
                            pos2 = strelka.show(3, 6);
                            if (pos2 == 3 || pos2 == 4 || pos2 == 5)
                            {
                                for (int i2 = pos-3; i2 == pos-3; i2++)
                                {
                                    men02 = Convert.ToString(men2[i].zapi4);
                                    men02int = Convert.ToInt32(men2[i].zapi5);
                                    men03 = Convert.ToString(men2[i].zapi6);
                                    men03int = Convert.ToInt32(men2[i].zapi7);
                                    men04 = Convert.ToString(men2[i].zapi8);
                                    men04int = Convert.ToInt32(men2[i].zapi9);
                                }
                                zakaz.Add(men2[i]);
                                if (pos2 == 3)
                                {
                                    price += men02int;
                                    menstr.Add(men02);
                                }
                                if (pos2 == 4)
                                {
                                    price += men03int;
                                    menstr.Add(men03);
                                }
                                if (pos2 == 5)
                                {
                                    price += men04int;
                                    menstr.Add(men04);
                                }
                            }
                        }
                    } while (key.Key == ConsoleKey.Escape);
                }
                if (pos == 9)
                {
                    Console.Clear();
                    Console.WriteLine("Не подавитесь...");
                    DateTime a = DateTime.Now;
                    string data = Convert.ToString(a);
                    string pricestr = Convert.ToString(price);
                    File.AppendAllText("C:\\Users\\MSI-MODERN-14\\OneDrive\\Desktop\\текст.txt", "Заказ от: ");
                    File.AppendAllText("C:\\Users\\MSI-MODERN-14\\OneDrive\\Desktop\\текст.txt", data);
                    File.AppendAllText("C:\\Users\\MSI-MODERN-14\\OneDrive\\Desktop\\текст.txt", " ");
                    File.AppendAllText("C:\\Users\\MSI-MODERN-14\\OneDrive\\Desktop\\текст.txt", "\n\tЦена: ");
                    File.AppendAllText("C:\\Users\\MSI-MODERN-14\\OneDrive\\Desktop\\текст.txt", pricestr);
                    File.AppendAllText("C:\\Users\\MSI-MODERN-14\\OneDrive\\Desktop\\текст.txt", " ");
                    File.AppendAllText("C:\\Users\\MSI-MODERN-14\\OneDrive\\Desktop\\текст.txt", "\nВаш тортик: ");
                    File.AppendAllLines("C:\\Users\\MSI-MODERN-14\\OneDrive\\Desktop\\текст.txt", menstr);
                    break;
                }
                Console.Clear();
            } while (true);
        }
    }
}