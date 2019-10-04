using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KalliPoshApp.Models
{
    public class Customers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        public byte MembershipTypeId { get; set; }
        public string MembershipName { get; set; }

    }
}