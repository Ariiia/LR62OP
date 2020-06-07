using System;
using System.Collections.Generic;
using System.Text;

namespace LR62OP
{
    public class Nurse
    {
        public static Collect<Child> ChildCollectNu=new Collect<Child>();
       public Nurse()
        {
            ChildCollectNu = Child.MyBoys;
           
        }


      
        public static void Check()
        {
            if (ChildCollectNu.InfoOnChildren.Count == 0)
            {
                Console.WriteLine("There are no children in the kindergarden");

            }
            else if (Child.Days <= 3)
            {
                Console.WriteLine("Not enough data to send to Nurse");

            }
            else
            {
                foreach (Child children in Child.MyBoys)
                {

                    for (int i = 3; i < Child.Days; i++)
                    {
                        if (children.needReceipt == true)
                        {

                            children.needReceipt = ((new Random()).Next(2) == 0) ? true : false;
                            children.Attend[i] = ((children.needReceipt) == false) ? "+" : "- GO TO NURSE TAKE RECEIPT";
                            continue;
                        }

                        if ((children.Attend[i - 2] == "-") && (children.Attend[i - 1] == "-") && (children.Attend[i] == "-") && (children.Attend[i - 3] == "-"))
                        { children.Attend[i - 2] = "- GO TO NURSE TAKE RECEIPT";
                            children.Attend[i - 1] = "- GO TO NURSE TAKE RECEIPT";
                            children.Attend[i] = "- GO TO NURSE TAKE RECEIPT";
                            children.Attend[i - 3] = "- GO TO NURSE TAKE RECEIPT";
                            children.needReceipt = true;
                            while (children.Attend[i] == "-")
                            {
                                children.Attend[i] = "- GO TO NURSE TAKE RECEIPT";
                                i++;
                            }
                         

                                children.needReceipt = ((new Random()).Next(2) == 0) ? true : false;
                                children.Attend[i] =  "- GO TO NURSE TAKE RECEIPT";
                                continue;
                            
                        }

                    }
                }

            } 
        }

    }
}
