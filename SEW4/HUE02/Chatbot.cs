using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUE02
{
    internal class Chatbot
    {
        public void StartChat()
        {
            string path_answers_german = @"C:\Users\jakob\OneDrive - HBLFA Francisco Josephinum\4.Klasse\SEW\HUE\HUE02\answers_german.txt";
            string path_answers_english = @"C:\Users\jakob\OneDrive - HBLFA Francisco Josephinum\4.Klasse\SEW\HUE\HUE02\answers_english.txt";
            string path_random_german = @"C:\Users\jakob\OneDrive - HBLFA Francisco Josephinum\4.Klasse\SEW\HUE\HUE02\random_german.txt";
            string path_random_english = @"C:\Users\jakob\OneDrive - HBLFA Francisco Josephinum\4.Klasse\SEW\HUE\HUE02\random_english.txt";


            string content = System.IO.File.ReadAllText(path_answers_german);
            string[] answer = content.Split("\n");

            Dictionary<string, string> zeilen = new Dictionary<string, string>();

            int[] splits = new int[10];

            foreach (string s in answer)
            {
                int found = s.IndexOf(":");
                s.Substring(0, found);      //zeichen vor:
                s.Substring(found + 1);     //zeichen nach:
                zeilen.Add(s.Substring(0, found).ToString(), s.Substring(found + 1).ToString());
            }

            string content2 = System.IO.File.ReadAllText(path_answers_english);
            string[] answer2 = content.Split("\n");

            Dictionary<string, string> zeilen2 = new Dictionary<string, string>();

            int[] splits3 = new int[10];

            foreach (string s2 in answer2)
            {
                int found2 = s2.IndexOf(":");
                s2.Substring(0, found2);      //zeichen vor:
                s2.Substring(found2 + 1);     //zeichen nach:
                zeilen2.Add(s2.Substring(0, found2).ToString(), s2.Substring(found2 + 1).ToString());
            }

            string content3 = System.IO.File.ReadAllText(path_random_german);
            string[] answer3 = content3.Split("\n");
            List<string> zeilen3 = new List<string>();

            foreach (string s3 in answer3)
            {
                zeilen3.Add(s3);
            }


            string content4 = System.IO.File.ReadAllText(path_random_english);
            string[] answer4 = content4.Split("\n");
            List<string> zeilen4 = new List<string>();

            foreach (string s4 in answer4)
            {
                zeilen4.Add(s4);
            }

            Console.WriteLine("Bitte wähle deine Sprache aus | Please choose your language (D=Deutsch|E=Englisch)");
            string language = Console.ReadLine();

            if (language == "D")
            {
                Console.WriteLine("Hallo, bitte beginne eine Konversation!");
                while (true)
                {

                    int x = 0;
                    string eingabe = Console.ReadLine();
                    string[] split = eingabe.Split(" ");

                    for (int i = 0; i < split.Length; i++)
                    {
                        split[i].ToLower();
                    }

                    if (eingabe == "bye")
                    {
                        Console.WriteLine("Ciau!");
                        break;
                    }

                    foreach (string eingabe1 in split)
                    {
                        foreach (string wort in zeilen.Keys)
                        {
                            if (eingabe1 == wort)
                            {
                                Console.WriteLine("Charly: " + zeilen[wort]);
                                break;
                                x = 1;
                            }
                            if (x == 0)
                            {

                                Random rand = new Random();
                                int random = rand.Next(0, zeilen2.Count());
                                string[] zeilen5 = zeilen3.ToArray();
                                Console.WriteLine(zeilen5[random]);
                                break;
                            }
                        }
                        break;
                    }
                }
            }

            if (language == "E")
            {
                Console.WriteLine("Hello, please start your conversation!");
                while (true)
                {

                    int x = 0;
                    string eingabe2 = Console.ReadLine();
                    string[] split2 = eingabe2.Split(" ");

                    for (int i = 0; i < split2.Length; i++)
                    {
                        split2[i].ToLower();
                    }

                    if (eingabe2 == "bye")
                    {
                        Console.WriteLine("Ciau!");
                        break;
                    }

                    foreach (string eingabe1 in split2)
                    {
                        foreach (string wort3 in zeilen2.Keys)
                        {
                            if (eingabe1 == wort3)
                            {
                                Console.WriteLine("Charly: " + zeilen2[wort3] + "x");
                                break;
                                x = 1;
                            }
                            //if (x == 0)
                            //{
                            //    Random rand = new Random();
                            //    int random = rand.Next(0, zeilen2.Count());
                            //    string[] zeilen6 = zeilen4.ToArray();
                            //    Console.WriteLine(zeilen6[random]);
                            //    break;
                            //}
                        }
                        break;
                    }
                }
            }

        }

    }
}
