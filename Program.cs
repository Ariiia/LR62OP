using System;

namespace LR62OP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Отобразить информацию о детях, которым необходимо принести медицинскую справку.");
            Console.WriteLine("Kariavka Dariia, 10 variant, level B(C)");
            Console.WriteLine("Please Enter number of children");
            int days = 15;//number of days in kindergarden
            int ChildSize = 3;// Convert.ToInt32(Console.ReadLine());
            Child[] children = new Child[ChildSize];//array of children

            for (int i = 0; i < ChildSize; i++)
            { 
                    children[i] = new Child(days);
             }

            //OUTPUT
            for (int i = 0; i < ChildSize; i++)
            {
                Console.WriteLine("\nChild #\t" + (i + 1)+":\n");
                children[i].Output(days);
              
            }


        }
    }
}
