using System;
using System.Collections.Generic;
using System.Text;

namespace LR62OP
{
    public class Collect<T>
    {
       public List<T> InfoOnChildren { get; set; }
        public Collect(List<T> Info)
        {
            InfoOnChildren = Info;
        }
    }

}