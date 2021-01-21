using System;
using System.Collections.Generic;
using System.Text;

namespace Float.Application.Exceptions
{
   public class ValidationExceptions : Exception
    {
        public ValidationExceptions() : base("One or more validation failures occured")
        {
            Errors = new List<string>();
        }

        public List<string> Errors { get; }

        public ValidationExceptions(IEnumerable<string> failures) : this()
        {
            foreach (var failure in failures)
            {
                Errors.Add(failure);
            }    
        }

    }
}
