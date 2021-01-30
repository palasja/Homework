using System;
using System.Collections.Generic;
using System.Text;

namespace Task4_3
{

    class Cat
    {
        public delegate void myDelegate();
        public event myDelegate WakeUpEvent;

        public void WakeUp() 
        {
            WakeUpEvent();
        }
    }
}
