using System;
using System.Collections.Generic;
using System.Text;

namespace Task11_2
{
    class Caller
    {
        Test11_2 test = new Test11_2();
        public void Call123()
        {
            test.First();
            test.Second();
            test.Third();

        }
        public void Call213()
        {
            test.Second();
            test.First();
            test.Third();
        }
        public void Call231()
        {
            test.Second();
            test.Third();
            test.First();
        }
        public void Call321()
        {
            test.Third();
            test.Second();
            test.First();
        }
    }
}
