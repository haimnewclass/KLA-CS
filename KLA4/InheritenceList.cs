using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLA4
{
    
    public class InheritenceList
    {
        protected int MAX {
            get { return arr.Length; }
          }
        private string[] arr = new string[100];
        private int idx = 0;

        public int Length
        {
            get { return arr.Length; }
            private set
            {

            }
        }
        public void Add(string item)
        {
            arr[idx] = item;
            idx++;
        }
        public string Fetch()
        {
            idx--;
            string str = arr[idx];
            return str;

        }
    }

    internal class ComplexList : InheritenceList
    { 
        public void Run()
        {
            
        }
    }



}
