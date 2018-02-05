using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.ViewModels
{
    public class MembershipType
    {
        public byte ID { get; set; }
        public short SignupFee { get; set; }
        public byte Duration { get; set; }
        public byte DiscountRate { get; set; }
        public string  Name { get; set; }

    }
}