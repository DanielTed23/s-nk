using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sænk1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Velkommen til Knob til Km/t og omvendt konverteringsprogram!");

            while (true)
            {
                Console.WriteLine("Vælg en mulighed:");
                Console.WriteLine("1. Konverter Knob til Km/t");
                Console.WriteLine("2. Konverter Km/t til Knob");
                Console.WriteLine("0. Afslut programmet");
                Console.Write("Indtast dit valg: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 0:
                            Console.WriteLine("Farvel!");
                            return; // Afslut programmet, hvis valg er 0

                        case 1:
                            Console.Write("Indtast antal knob: ");
                            if (double.TryParse(Console.ReadLine(), out double knots))
                            {
                                // Brug klassen A til at konvertere knob til km/t
                                double kmPerHour = A.KnotsToKmPerHour(knots);
                                Console.WriteLine($"{knots} knob er {kmPerHour:F2} km/t.\n");
                            }
                            else
                            {
                                Console.WriteLine("Ugyldigt input. Prøv igen.\n");
                            }
                            break;

                        case 2:
                            Console.Write("Indtast antal km/t: ");
                            if (double.TryParse(Console.ReadLine(), out double kmPerHourInput))
                            {
                                // Brug klassen B til at konvertere km/t til knob
                                double knotsOutput = B.KmPerHourToKnots(kmPerHourInput);
                                Console.WriteLine($"{kmPerHourInput} km/t er {knotsOutput:F2} knob.\n");
                            }
                            else
                            {
                                Console.WriteLine("Ugyldigt input. Prøv igen.\n");
                            }
                            break;

                        default:
                            Console.WriteLine("Ukendt valg. Prøv igen.\n");
                            break;
                    }

                    Console.Write("Tryk på en tast for at fortsætte...");
                    Console.ReadKey();
                    Console.Clear(); // Sletter konsolindholdet, så det er tomt igen inden næste operation.
                }
                else
                {
                    Console.WriteLine("Ugyldigt input. Prøv igen.\n");
                }
            }
        }
    }
}