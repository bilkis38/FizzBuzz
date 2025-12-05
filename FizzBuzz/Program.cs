// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//FizzBuzz
 // Loop dari angka 1 hingga 100
        for (int i = 1; i <= 100; i++)
        {
            // Cek kondisi FizzBuzz
            if (i % 15 == 0) // Cek apakah habis dibagi 15 (yaitu habis dibagi 3 DAN 5)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0) // Cek apakah habis dibagi 3
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0) // Cek apakah habis dibagi 5
            {
                Console.WriteLine("Buzz");
            }
            else // Jika tidak habis dibagi 3, 5, atau 15
            {
                Console.WriteLine(i);
            }
        }