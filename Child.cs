using System;
using System.Collections.Generic;
using System.Text;

namespace LR62OP
{
    // List<T> Collection;

    public class Child
    {
       public  bool needReceipt;
        public static  List<Child> MyBoys { get;  set; } = new List<Child>();
      public  static int Days;
        public int[] DayNumber;
        public string[] Attend;

        public Child(int days)
        {
            needReceipt = false;
            this.DayNumber = new int[days];
            this.Attend = new string[days];
            string[] ChooseFrom = { "+", "-" };
            int AttendBool;
            Random rand = new Random();

            Days = days;
            for (int i = 0; i < days; i++)
            {
                AttendBool = rand.Next(ChooseFrom.Length);

                this.DayNumber[i] = i + 1;
                this.Attend[i] = ChooseFrom[AttendBool];
            }
            MyBoys.Add(this);
        }
 
        public void Output(int days)
        {
            for (int i = 0; i < days; i++)
            {
                Console.WriteLine("DAY " + DayNumber[i] + ":\t\t" + Attend[i]);
            }

        }



        }
    }
