using System;namespace ConsoleApp1 { class Program { static void Main(string[] args) { while (true) { Console.Write("Enter a number: "); string xStr = Console.ReadLine(); if (xStr == "exit") { break; } decimal x = 0; x = Convert.ToDecimal(xStr); for (decimal i = 1; i <= x; i++) { decimal modulusX = x % i; if (modulusX == 0) { Console.WriteLine($"Number is divisible by {i}"); } } } } } }
