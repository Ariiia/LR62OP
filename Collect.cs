using System;
using System.Collections.Generic;
using System.Text;

namespace LR62OP
{
    public class Collect<T1>
    {
        public List<T1> InfoOnChildren { get; set; }
        public Collect(List<T1> Info)
        {
            InfoOnChildren = Info;
        }

        public void Add(T1 name)
        {
            InfoOnChildren.Add(name);
        }
        public void ChooseIllChildren()
        {
            for (int i = 0; i < InfoOnChildren.Count; i++)
            {
                
            }
        }
    }

}