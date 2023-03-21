using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLA2
{
    internal class PropSample
    {
        public int ChildCount2;

        private int _childCount;
        public int ChildCount
        {
            get
            {
                if (_childCount == 0) return 18;
                else
                return _childCount;
            }

            set
            {
                if(value > 12)
                    _childCount = value;
            }
        }


        // propfull
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        

    }
}
