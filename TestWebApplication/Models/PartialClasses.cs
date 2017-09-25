using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestWebApplication.Models
{
    [MetadataType(typeof(CustomerMetadata))]
    public partial class Customer
    {
    }

    [MetadataType(typeof(AccountMetadata))]
    public partial class Account
    {
    }

    [MetadataType(typeof(BankMetadata))]
    public partial class Bank
    {
    }
}