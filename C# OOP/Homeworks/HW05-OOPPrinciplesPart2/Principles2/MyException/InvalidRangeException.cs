using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principles2.MyException
{
    public class InvalidRangeException<T> : ApplicationException
    {
        private T startRange;
        private T endRange;

        public InvalidRangeException(string msg, T startRange, T endRange, Exception ex)
            : base(msg, ex)
        {
            this.StartRange = startRange;
            this.EndRange = endRange;
        }

        public InvalidRangeException(string msg, T startRange, T endRange)
            : this(string.Format("{0}\nShould be in range {1} to {2}", msg, startRange, endRange), startRange, endRange, null)
        {
        }

        public T StartRange
        {
            get { return this.startRange; }
            set { this.startRange = value; }
        }

        public T EndRange
        {
            get { return this.endRange; }
            set { this.endRange = value; }
        }
    }
}
