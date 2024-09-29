// Program pobierający liczbę od użytkownika i obliczający pierwiastek kwadratowy.
// Jakub Kopiszka, III TPI

// Zdeklarowanie używanych bibliotek
//
using System;
using System.ComponentModel.Design.Serialization;

// Przestrzeń nazw

namespace mathExpections
{
    // Klasa programu
    internal class Program
    {
        // Zdeklarowanie klasy i konstruktora wyjątku liczby ujemnej
        public class negativeNumberException : Exception { public negativeNumberException(string message) : base(message) { } };

        // Funkcja główna programu
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Zastosowanie kodowania UTF-8 dla konsoli
            Console.WriteLine("Root calculator"); // Intro do programu

            try
            {
                Console.WriteLine("Podaj liczbe do obliczenia: ");
                string rslt = Console.ReadLine(); // Pobranie liczby
                double rsltDb = Convert.ToDouble(rslt); // Skonwertowanie typu ze string do double
                if (rsltDb < 0) // Weryfikacja podanej liczby
                {
                    throw new negativeNumberException("Liczba ujemna - nie można wykonać obliczeń!"); // Wyrzucenie wyjątku
                                                                                                      // jeżeli
                                                                                                      // liczba jest ujemna
                                                                                                      
                }
                else
                {
                    double Root = Math.Sqrt(rsltDb); // Operacja pierwiastkowania
                    Console.WriteLine("Wynik: " + Root); // Wydruk wyniku
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Zły format liczby - nie można kontynuować!"); // Obsluga wyjatku nieprawidlowego formatu
            }
            catch (negativeNumberException msg)
            {
                Console.WriteLine(msg.Message); // Obsługa wyjątku liczby ujemnej
            }
            catch (Exception e) { Console.WriteLine("Unhandled error occured: " + e.Message); }
            // Obsługa nieprzewidzianego wyjątku
        }
    }
}
