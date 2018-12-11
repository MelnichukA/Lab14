using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Lab8Lib;

namespace lab14
{
    class Program
    {
        static List<Pass> pasS;
        static void PrintSubs()
        {
            foreach (Pass pass in pasS)
            {
                Console.WriteLine(pass.Info().Replace('і', 'i'));
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {

            pasS = new List<Pass>();
            FileStream fs = new FileStream("lab13.pass", FileMode.Open);
            BinaryReader reader = new BinaryReader(fs);
            try
            {
                Pass pas;

                while (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    pas = new Pass();
                    for (int i = 1; i <= 8; i++)
                    {
                        switch (i)
                        {
                            case 1:
                                pas.Name = reader.ReadString();
                                break;

                            case 2:
                                pas.Country = reader.ReadString();
                                break;

                            case 3:
                                pas.Region = reader.ReadString();
                                break;

                            case 4:
                                pas.Place = reader.ReadString();
                                break;

                            case 5:
                                pas.Prop = reader.ReadString();
                                break;

                            case 6:
                                pas.PassNum = reader.ReadInt32();
                                break;

                            case 7:
                                pas.PassSer = reader.ReadString();
                                break;

                            case 8:
                                pas.HasMarried = reader.ReadBoolean();
                                break;
                        }
                    }
                    pasS.Add(pas);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Сталась помилка: {0}", ex.Message);
            }
            finally
            {
                reader.Close();
            }
            Console.WriteLine("    Не отсортированый список: {0}", pasS.Count);
            PrintSubs();
            pasS.Sort();
            Console.WriteLine("    Отсортированый список: {0}", pasS.Count);
            PrintSubs();
            Console.WriteLine("    Добавляем паспортные данные");
            Pass subNikita = new Pass("Виктор", "Италия", "Генуя", "Аренцано", "где-то", 945623, "ГУ", true);
            pasS.Add(subNikita);
            pasS.Sort();
            Console.WriteLine("    Паспортные данные: {0}", pasS.Count);
            PrintSubs();
            Console.WriteLine("    Удаляем последнюю строку:");
            pasS.RemoveAt(pasS.Count - 1);
            Console.WriteLine("    Обновленный список: {0}", pasS.Count);
            PrintSubs();
            Console.ReadKey();



        }
    }
}
