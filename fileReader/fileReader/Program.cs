// Program odczytujący informacje z pliku tekstowego, zlokalizowanego w katalogu pliku wykonywalnego
// Jakub Kopiszka, III TPI

// Zdeklarowanie używanych bibliotek
//
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

// Przestrzeń nazw

namespace fileReader
{
    // Klasa programu
    internal class Program
    {
        // Zdeklarowanie klasy i konstruktora wyjątku pustego pliku
        public class fileEmptyException : Exception { public fileEmptyException(string message) : base(message) { } };

        // Funkcja główna programu
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Zastosowanie kodowania UTF-8 dla konsoli
            Console.WriteLine("File reader!"); // Intro do programu

            try
            {
                string text = File.ReadAllText("data.txt"); // Próba odczytania pliku.
                Console.WriteLine(text); // Próba wypisania pobranych danych z pliku.
                if (text.Length == 0)
                {
                    throw new fileEmptyException("Plik pusty"); // Wyrzucenie wyjątku, jeżeli plik jest pusty.
                }
            }
            catch (FileNotFoundException msg)
            {
                Console.WriteLine(msg.Message); // Informacja o nie znalezieniu pliku.
                Console.WriteLine("Missing file creation..."); // Komunikat o tworzeniu nowego pliku

                // Tworzenie nowego pliku
                using FileStream datafile = File.Create("data.txt"); 
                {
                    const string dane = "Dane!";
                    byte[] daneBytes = new UTF8Encoding(true).GetBytes(dane);
                    datafile.Write(daneBytes, 0, daneBytes.Length);
                }
            }
            catch (IOException msg)
            {
                Console.WriteLine(msg.Message); // Obsługa wyjątku błędu odczytu pliku
            }
            catch (fileEmptyException msg)
            {
                Console.WriteLine(msg.Message); // Obsługa wyjątku pustego pliku
            }
            catch (Exception e) { Console.WriteLine("Unhandled error occured: " + e.Message); }
            // Obsługa nieprzewidzianego wyjątku
        }
    }
}
