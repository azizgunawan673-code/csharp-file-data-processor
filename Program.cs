using System;
using System.IO;

namespace ConsoleDataProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============================================");
            Console.WriteLine("   C# Data & File Automation Processor      ");
            Console.WriteLine("   Developed by: Asep Azis Gunawan          ");
            Console.WriteLine("============================================");
            Console.WriteLine();

            string fileName = "sample_data.txt";

            // Buat file sampel jika belum ada
            if (!File.Exists(fileName))
            {
                string[] defaultData = {
                    "Item: Laptop ProBook | Status: Processed | Price: 1500000",
                    "Item: USB Wi-Fi | Status: Pending | Price: 85000",
                    "Item: SSD SATA | Status: Processed | Price: 350000"
                };
                File.WriteAllLines(fileName, defaultData);
                Console.WriteLine($"[INFO] Created sample file: {fileName}");
            }

            // Membaca dan mengolah data dari file
            Console.WriteLine("\n[READING FILE DATA...]");
            string[] lines = File.ReadAllLines(fileName);
            int totalItems = 0;

            foreach (string line in lines)
            {
                totalItems++;
                Console.WriteLine($"  -> Row {totalItems}: {line}");
            }

            Console.WriteLine("\n--------------------------------------------");
            Console.WriteLine($"[SUCCESS] Total records processed: {totalItems}");
            Console.WriteLine("============================================");
        }
    }
}