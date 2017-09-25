using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestWebApplication.Models
{
       public class CustomerMetadata
    {
        [StringLength(20)]
        [Display(Name ="customer Name")]
        public string customerName;

        [StringLength(20)]
        [Display(Name = "customer Surname")]
        public string customerSurname;

        [StringLength(50)]
        [Display(Name = "customer Address")]
        public string customerAddress;
    }
        public class AccountMetadata
        {
            [StringLength(50)]
            [Display(Name = "account Type")]
            public string accountType;

        }
       public class BankMetadata
        {

        }


}
