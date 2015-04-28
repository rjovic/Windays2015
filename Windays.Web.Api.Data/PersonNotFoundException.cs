using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windays.Web.Api.Data
{
    public class PersonNotFoundException : Exception
    {
        public PersonNotFoundException(string message)
            : base(message)
        {

        }
    }
}
