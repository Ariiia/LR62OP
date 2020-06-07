using System;

namespace LR62OP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Отобразить информацию о детях, которым необходимо принести медицинскую справку.");
            Console.WriteLine("Kariavka Dariia, 10 variant, level B(C)");
            Console.WriteLine("Please Enter number of children");
            int days = 30;//number of days in kindergarden
            int ChildSize = 1;// Convert.ToInt32(Console.ReadLine());
            Child[] children = new Child[ChildSize];//array of children
            int[] Daynumber = new int[days];//array of daynumbers
            Random rand = new Random();
            string[] ChooseFrom = { "+", "-"};
            string AttendBool;
            for (int i = 0; i < ChildSize; i++)
            { for (int j = 0; j < days; j++) {
                    AttendBool = Convert.ToString(rand.Next(ChooseFrom.Length));
                    children[i] = new Child(30, j, AttendBool);
             } }
        }
    }
}
