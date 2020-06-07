using System;
using System.Collections.Generic;
using System.Text;

namespace LR62OP
{
    class Child
    {
        
     public int[] DayNumber;
    public    string[] Attend;


     public   Child( int days)
        {
            this.DayNumber = new int[days];
            this.Attend = new string[days];
            string[] ChooseFrom = { "+", "-" };
            string AttendBool;
            Random rand = new Random();
            AttendBool = Convert.ToString(rand.Next(ChooseFrom.Length));
               
           
            for (int i=0; i<days; i++)
            {
                this.DayNumber = i + 1;

            }
        }
    }
}
