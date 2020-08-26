using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
   public interface IEmail
    {
        string SendMail(string From, string To);
    }
}
