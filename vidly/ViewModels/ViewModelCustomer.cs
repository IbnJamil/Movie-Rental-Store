using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vidly.Models;

namespace vidly.ViewModels
{
    public class ViewModelCustomer
    {
        public Customers customers { get; set; }
        public IEnumerable<MemberShipTypes> membershiptype { get; set; }

    }
}