using System;

namespace hwk10
{
    internal class Tread
    {
        private Action start;

        public Tread(Action start)
        {
            this.start = start;
        }
    }
}