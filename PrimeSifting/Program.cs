using PrimeSifting.Models;
using System;
using System.Collections.Generic;
namespace PrimeSifting
{
    public class Program
    {
        public static void Main(){
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            Sifter s = new Sifter(n);
            List<int> result = s.Sift();
            Console.WriteLine("Here are all the prime numbers up to that value");
            foreach(int i in result){
                Console.WriteLine(i);
            }
        }
    }
}