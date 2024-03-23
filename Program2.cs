using System;
using System.Text.RegularExpressions;

class Program2{
    public static void Main(string[] args){
        Console.WriteLine("enter a string");
        string input=Console.ReadLine();
        string pattern=@"\b(0[1-9]|1[0-2])(0[1-9]|[12]\d|3[01])(19|20)\d{2}\b";
        MatchCollection matches =Regex.Matches(input,pattern);

        foreach(Match match in matches){
            Console.WriteLine(match.Value);
        }
    }
    
}