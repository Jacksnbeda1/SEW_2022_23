using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            //-----------------------------
            string content2 = System.IO.File.ReadAllText(path_answers_english);
            string[] answer2 = content2.Split("\n");
            
            Dictionary<string, string> zeilen2 = new Dictionary<string, string>();

            int[] splits2 = new int[10];

            foreach (string s in answer2)
            {
                int found = s.IndexOf(":");
                //s.Substring(0, found);      //zeichen vor:
                //s.Substring(found + 1);     //zeichen nach:
                zeilen2.Add(s.Substring(0, found).ToString(), s.Substring(found + 1).ToString());
            }
            //----------------------------------
            string content3 = System.IO.File.ReadAllText(path_random_german);
            string[] answer3 = content3.Split("\n");
            List<string> zeilen3 = new List<string>();

            foreach (string s3 in answer3)
            {
                zeilen3.Add(s3);
            }

            //-------------------------------------
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

                    int x = 0 ;
                    string eingabe = Console.ReadLine();
                    string[] split = eingabe.Split(" ");
                    string[] splitlower = new string[25];

                    for (int i = 0; i < split.Length; i++)
                    {

                      splitlower[i] = split[i].ToLower();
                    }

                    if (eingabe == "bye")
                    {
                        Console.WriteLine("Ciau!");
                        break;
                    }

                    foreach (string eingabe1 in splitlower)
                    {
                        foreach (string wort in zeilen.Keys)
                        {
                            if (eingabe1 == wort)
                            {
                                Console.WriteLine("Charly: " + zeilen[wort]);                               
                                x = 1;
                                break;
                            }
                            
                        }

                        
                    }
                    if (x==0)
                    {
                        Random rand = new Random();
                        int random = rand.Next(0, zeilen3.Count());
                        string[] zeilen5 = zeilen3.ToArray();
                        Console.WriteLine(zeilen5[random]);
                    }
                    
                }
            }

            if (language == "E")
            {
                Console.WriteLine("Hello, please start your conversation!");
                while (true)
                {

                    int x = 0;
                    string eingabe = Console.ReadLine();
                    string[] split = eingabe.Split(" ");
                    string[] splitlower = new string[25];

                    for (int i = 0; i < split.Length; i++)
                    {
                        splitlower[i] = split[i].ToLower();
                        Console.WriteLine(splitlower[i]);
                    }

                    if (eingabe == "bye")
                    {
                        Console.WriteLine("Ciau!");
                        break;
                    }

                    foreach (string eingabe2 in splitlower)
                    {
                        foreach (string wort1 in zeilen2.Keys)
                        {
                            if (eingabe2== wort1)
                            {
                                Console.WriteLine("Charly: " + zeilen2[wort1]);
                                x = 1;
                                break;
                            }

                        }

                        
                    }
                    if (x == 0)
                    {
                        Random rand = new Random();
                        int random = rand.Next(0, zeilen4.Count());
                        string[] zeilen5 = zeilen4.ToArray();
                        Console.WriteLine(zeilen5[random]);
                    }

                }
            }

        }

    }
}
