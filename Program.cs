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
            Console.WriteLine("\tWELCOME TO KINDERGARDEN");
            Console.WriteLine("\tWOOBYY-BOO");
            Console.WriteLine("Please Enter number of children");
            int ChildSize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("days?");
            int days  =Convert.ToInt32(Console.ReadLine());//number of days in kindergarden
            
            Child[] children = new Child[ChildSize];//array of children

            for (int i = 0; i < ChildSize; i++)
            {
                children[i] = new Child(days);
            }

            //OUTPUT
            for (int i = 0; i < ChildSize; i++)
            {
                Console.WriteLine("\nChild #\t" + (i + 1) + ":\n");
                children[i].Output(days);

            }
            Nurse nurse = new Nurse();
            Headmisstress headmisstress = new Headmisstress();
            Nurse.Check();
            Headmisstress.ReceiptForParents();

            for (int i = 0; i < ChildSize; i++)
            {
                Console.WriteLine("\nChild #\t" + (i + 1) + ":\n");
                children[i].Output(days);

            }

        }
    }
}
