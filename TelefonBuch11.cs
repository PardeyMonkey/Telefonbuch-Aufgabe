using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonBuch
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<string> Nummerliste = new List<string>();
            bool run = true;
            while (run == true)
            {
                Console.WriteLine("Gebe '1' in die Konsole ein um eine neue Nummer einzufügen und gebe '2' ein um die bereits gespeicherten Nummern zu öffnen.");

                int Auswahl = int.Parse(Console.ReadLine());

                if (Auswahl == 1)
                {
                    //Gehe zu der eingabe von einer Telefonnummer

                    Console.WriteLine("Trage hier eine neue Nummer in das Telefonbuch ein");
                    string Nummer = Console.ReadLine();
                    Console.WriteLine("Die Nummer " + Nummer + " wurde im Telefonbuch gespeichert.");
                    Nummerliste.Add(Nummer);
                }
                else if (Auswahl == 2)
                {
                    //Gehe zur liste von den eingespeicherten Telefonnummern 
                    Console.WriteLine("Hier sind die gespeicherten Nummern");
                    int zähler = 1;
                    foreach (string nummer in Nummerliste)
                    {
                        Console.WriteLine(zähler + ". " + nummer);
                        zähler++;
                    }
                    //Nummerliste von Auswahl 1 auf 2 rüberbringen und wechsel zwischen eingabe und Telefonbuch wechseln
                    Console.WriteLine("Drücken Sie eine Beliebige Tasten um fortzufahren...");
                    Console.ReadKey();
                }
                else if (Auswahl == 3)
                {
                    run = false;
                }
            }

        }
       


    }
    
}
