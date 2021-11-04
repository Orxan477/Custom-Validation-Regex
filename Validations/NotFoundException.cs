using System;
using System.Collections.Generic;
using System.Text;

namespace Validations
{
    class NotFoundException:Exception
    {
        public NotFoundException(string message) : base(message)
        {

        }
    }
}
