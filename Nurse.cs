using System;
using System.Collections.Generic;
using System.Text;

namespace LR62OP
{
    public class Nurse
    {

   

        public static void Check()
        {
            if (Child.MyBoys.Count == 0)
            {
                Console.WriteLine("There are no children in the kindergarden");

            }
            else if (Child.Days <= 3)
            {
                Console.WriteLine("Not enough data to send to Nurse");

            }
            else
            {
                foreach (var children in Child.MyBoys)
                {

                    for (int i = 3; i < Child.Days; i++)
                    {
                        if (children.needReceipt == true)
                        {

                            children.needReceipt = ((new Random()).Next(2) == 0) ? true : false;
                            children.Attend[i] = ((children.needReceipt) == false) ? "+" : "-";
                            continue;
                        }

                        if ((children.Attend[i - 2] == "-") && (children.Attend[i - 1] == "-") && (children.Attend[i] == "-") && (children.Attend[i - 3] == "-"))
                        {
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

    }
}
