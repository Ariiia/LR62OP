using System;
using System.Collections.Generic;
using System.Text;

namespace LR62OP
{
    public class Collect<T1>
    {
        public List<List<T1>> InfoOnChildren { get; set; }
        public Collect(List<List<T1>> Info)
        {
            InfoOnChildren = Info;
        }
        public void ChooseIllChildren()
        {
            for (int i = 0; i < InfoOnChildren.Count; i++)
            {
                
            }
        }
    }

}