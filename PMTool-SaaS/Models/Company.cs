using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PMTool_SaaS.Models
{
    public class Company
    {

        public int CompanyId { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public virtual ICollection<ApplicationUser> Users { get; set; }
    }
}