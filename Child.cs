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
        static int Days;
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
  public static void Check()
        {
            if (MyBoys.Count == 0)
            {
                Console.WriteLine("There are no children in the kindergarden");

            }
            else if (Days<=3)
            {
                Console.WriteLine("Not enough data to send to Nurse");

            }
            else
            {
                double Rnd;
                foreach(var children in MyBoys)
                {

                    for (int i = 3; i < Days; i++)
                    {
                        if (children.needReceipt == true)
                        {

                            children.needReceipt = ((new Random()).Next(2) == 0) ? true : false;
                        }

                        if ((children.Attend[i-2]=="-")&&( children.Attend[i - 1]=="-")&& (children.Attend[i] == "-")&& (children.Attend[i - 3] == "-")){
                            children.needReceipt = true;
                            while (children.Attend[i] == "-")
                            {
                                i++;
                            }
                            
                    }

                    }
                }

            }
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
