using System;

class Example1{
    public static void Main(string[] args){
         Console.WriteLine("Enter the height:");
         int height=int.Parse(Console.ReadLine());
         for(int i=0;i<height;i++){
            for(int j=0;j<height-i-1;j++){
                Console.Write(" ");
            }
            for(int k=0;k<2*i+1;k++){
                Console.Write("*");
            }
            Console.WriteLine();
         }

    }
}

