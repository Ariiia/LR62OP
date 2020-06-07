using System;
using System.Collections.Generic;
using System.Text;

namespace LR62OP
{
    class Child
    {

        public int[] DayNumber;
        public string[] Attend;


        public Child(int days)
        {
            this.DayNumber = new int[days];
            this.Attend = new string[days];
            string[] ChooseFrom = { "+", "-" };
            int AttendBool;
            Random rand = new Random();


            for (int i = 0; i < days; i++)
            {
                AttendBool = rand.Next(ChooseFrom.Length);

                this.DayNumber[i] = i + 1;
                this.Attend[i] = ChooseFrom[AttendBool];
            }
        }

        public void Output(int days)
        {
            for (int i = 0; i < days; i++)
            {
                Console.WriteLine("DAY " + DayNumber[i] + ":\t\t"+Attend[i]);
            }

        }

    }
}