using System;
namespace Algoritma
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            int index;
            Console.WriteLine("Kelime Giriniz");
            word = Console.ReadLine();
            Console.WriteLine("Silmek istediğiniz harfi giriniz");
            index = int.Parse(Console.ReadLine());

            DeleteLetter(word,index);
        }
        static void DeleteLetter(string text,int x)
        {
            char[] letterArray = text.ToCharArray();
            letterArray = letterArray.Where((source,index)=>index != x).ToArray();
            Console.WriteLine(letterArray);
        }
        
    }
}