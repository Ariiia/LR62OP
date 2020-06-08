using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LR62OP
{
    public class Collect<T1>
    {
        public List<T1> InfoOnChildren { get; set; }
        public Collect()
        {
            InfoOnChildren = new List<T1>();
        }

        public IEnumerator GetEnumerator() {
            for (int i = 0; i < InfoOnChildren.Count; i++)
            {
                yield return InfoOnChildren[i];
            }
        }
        
        public void Add(T1 name)
        {
            InfoOnChildren.Add(name);
        }

        public T1 this[int i]{
            get { return InfoOnChildren[i]; }

            set { InfoOnChildren[i] = value; }
            }
        public void ChooseIllChildren()
        {
            for (int i = 0; i < InfoOnChildren.Count; i++)
            {
                
            }
        }
    }

}