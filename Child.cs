using System;
using System.Collections.Generic;
using System.Text;

namespace LR62OP
{
    class Child
    {
        int days;
     public int[] DayNumber;
    public    string Attend;


     public   Child(int days, int[] DayNumber,  string Attend)
        {
            for(int i=0; i<days; i++)
            {
                DayNumber[i] = i + 1;

            }
                this.Attend = Attend;
        }
    }
}
