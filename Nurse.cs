using System;
using System.Collections.Generic;
using System.Text;

namespace LR62OP
{
    public class Nurse
    {
        public static Collect<Child> ChildCollectNu=new Collect<Child>();
        public static Collect<Child> SickKidos = new Collect<Child>();
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


            foreach (Child child in ChildCollectNu)
            {

                SickKidos.Add(new Child());
                for (int i = 0; i < Child.Days; i++)
                {

                    if (child.Attend[i].Contains("- GO TO NURSE TAKE RECEIPT"))
                        SickKidos.InfoOnChildren[SickKidos.InfoOnChildren.Count - 1].Add(child.Attend[i]);
                    else
                    {
                        SickKidos.InfoOnChildren[SickKidos.InfoOnChildren.Count - 1].Add(" ");
                    }
                }
            }
        }
        public void Output(int days)
        {
            int temp = 0;
            foreach (Child child in ChildCollectNu)
            {
               bool flag = false;
                temp++;
                
                for(int j=0; j<days; j++)
                {
                    if (child.Attend[j].Contains("- GO TO NURSE TAKE RECEIPT")){
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    Console.WriteLine("\nChild #\t" + (temp) + ":\n");

                    for (int i = 0; i < days; i++)
                    {
                        if (child.Attend[i] == "- GO TO NURSE TAKE RECEIPT")
                            Console.WriteLine("DAY " + (i + 1) + ":\t\t" + child.Attend[i]);
                    }
                }
            }
        }
    }

}
