using System;

namespace RangeException
{
    class InvalidRangeException<T> : ApplicationException
    {
        private T start;
        private T end;

        public InvalidRangeException(string message, T start, T end, Exception inner)
            : base(message, inner)
        {
            this.Start = start;
            this.End = end;
        }

        public InvalidRangeException(string message, T start, T end)
            : this(message, start, end, null) 
        {
            this.Start = start;
            this.End = end;
        }

        public InvalidRangeException(T start, T end)
            : this(null, start, end, null)
        {
            this.Start = start;
            this.End = end;
        }


        public T Start { get; private set; }
        public T End { get; private set; }
    }
}