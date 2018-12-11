using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8Lib
{
    public class ProcessorException : Exception
    {
        public ProcessorException(string message) : base(message) { }
    }

    public class InvalidSerException : Exception
    {
        public InvalidSerException() : base("Неверная серия паспорта") { }
    }
}
