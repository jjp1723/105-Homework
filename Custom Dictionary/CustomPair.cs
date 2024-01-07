using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Dictionary
{
    class CustomPair<T>
    {
        //Fields
        protected T key;
        protected T val;



        //Field Properties
        //Key Get/Set Property
        public T Key
        {
            get
            {
                return key;
            }
            set
            {
                key = value;
            }
        }

        //Value Get/Set Property
        public T Value
        {
            get
            {
                return val;
            }
            set
            {
                val = value;
            }
        }



        //Parameterized Constructor
        public CustomPair(T kee, T vaal)
        {
            key = kee;
            val = vaal;
        }
    }
}
