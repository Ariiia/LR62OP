using System;
using System.Collections.Generic;
using System.Text;

namespace LR62OP
{
    // List<T> Collection;

    public class Child
    {
        public int UnPaidDays = 0;
        public bool needReceipt;
        public static Collect<Child> MyBoys { get; set; } = new Collect<Child>();
        public static int Days;
        public int[] DayNumber;
        public List<string>Attend;
        public Child() {
            this.Attend = new List<string>();
        }
        public Child(int days)
        {
            needReceipt = false;
            this.DayNumber = new int[days];
            this.Attend = new List<string>();
            string[] ChooseFrom = { "+", "-" };
            int AttendBool=0;
            Days = days;
            for (int i = 0; i < days; i++)
            {
                AttendBool = ((new Random()).Next(ChooseFrom.Length));

                this.DayNumber[i] = i + 1;
                this.Attend.Add (ChooseFrom[AttendBool]);
            }
            MyBoys.Add(this);
        }

        public void Add(string s)
        {
            Attend.Add(s);
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
