using System;
using System.Collections.Generic;
using System.Text;

namespace LR62OP
{
    public class Headmisstress
    {
        public static int cost = 500;

        public static List<int> Sum = new List<int>();
        public static Collect<Child> ChildCollectMi=new Collect<Child>();
        public Headmisstress()
        {
            ChildCollectMi= Child.MyBoys;
        }

        public static void ReceiptForParents()
        {
            if (Child.Days < 30)
                Console.WriteLine("Not enought days to calculate price");
            else
            {
                foreach (Child element in ChildCollectMi)
                {
                    int sum = 0;
                    bool pay = true;
                    for (int i = 0; i < Child.Days; i++)
                    {
                        if (i % 30 < 10 && i > 30 ) {
                            pay = false;

                            while (i % 30 < 10 && i > 30 && !pay&&i<Child.Days-1)
                            {
                                sum = ((element.Attend[i]) == "+") ? sum += cost : sum;
                                pay = ((new Random()).Next(7) == 1) ? true:false;   
                                i++;
                            }

                            if(pay)
                            sum = 0;
                        }
                        if (!pay)
                        {
                            pay = ((new Random()).Next(7) == 1) ? true : false;
                            element.Attend[i] = "- PAY DEBTS FOR YOUR CHILD";
                            continue;
                        }

                        sum = ((element.Attend[i]) == "+") ? sum += cost : sum;

                    }
                    Sum.Add(sum);
                }

            }
        }

       



        
    }
}
