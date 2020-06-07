using System;
using System.Collections.Generic;
using System.Text;

namespace LR62OP
{
 public   class Headmisstress
    {
        public static int cost=500;

        List<int> Sum = new List<int>();

        public static void ReceiptForParents()
        {
            if (Child.Days < 30)
                Console.WriteLine("Not enought days to calculate");
            else
            {
                foreach (Child element in Child.MyBoys ) {
                    int sum = 0;

                    for (int i = 0; i < Child.Days; i++)
                    {
                        sum = ((element.Attend[i]) == "+") ? sum += cost : sum; 

                    } }
            }



        }

    }
}
