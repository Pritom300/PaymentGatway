using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hellow_payment.Models
{
    public class BookPurchaseVM : Book
    {
       public string Nonce { get; set; }
    }
}
