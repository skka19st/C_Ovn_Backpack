using System;
using System.Collections.Generic;

namespace Backpack
{
    class Program
    {
        static void Main(string[] args)
        {
            // en lista för att lagra föremål
            var ryggsacken = new List<string>();

            // loop som avslutas med val '4'
            bool fortsatt = true;
            while (fortsatt) 
            {
                // ledinfo till skärmen
                string svar = SkrivUtMeny();

                // innehållet i variabeln 'svar' testas
                switch(svar)
                {
                    // lägga till föremål
                    case "1":
                        // endast 6 föremål är tillåtna
                        if (ryggsacken.Count < 6)
                        {
                            Console.WriteLine("vad vill du lägga till?");
                            string adderaDetta = Console.ReadLine();
                            ryggsacken.Add(adderaDetta);
                        }
                        else 
                        {
                            Console.WriteLine("tyvärr, ryggsäcken är full!");
                        }                        
                        break;
                    // skriv ut innehållet
                    case "2":
                        Console.WriteLine("detta har du packat ner:");
                        foreach (var rad in ryggsacken)
                        {
                            Console.WriteLine(rad);
                        }
                        break;
                    // rensa innehållet, sist inlagda föremål
                    case "3":
                        // finns det något i ryggsäcken?
                        if (ryggsacken.Count > 0)
                        {
                            int indSista = ryggsacken.Count - 1;
                            ryggsacken.RemoveAt(indSista);
                            Console.WriteLine("senast inlagda föremål borttaget!");
                        }
                        else
                        {
                            Console.WriteLine("ryggsäcken är redan tom!");
                        }
                        break;
                    // avsluta
                    case "4":
                        Console.WriteLine("hej då, tack för idag!");
                        fortsatt = false;
                        break;
                    // 'default' är hopsamlingsheat för 'icke träff'
                    default:
                        Console.WriteLine("Ange 1, 2, 3 eller 4");
                        break;
                }
            }            
        }
        static string SkrivUtMeny()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Välkommen till ryggsäcken!");
            Console.WriteLine("[1] Lägg till ett föremål");
            Console.WriteLine("[2] Skriv ut innehållet");
            Console.WriteLine("[3] Rensa innehållet");
            Console.WriteLine("[4] Avsluta");

            // ta in svar från skärmen
            string menySvar = Console.ReadLine();
            return menySvar;
        }
    }
}
