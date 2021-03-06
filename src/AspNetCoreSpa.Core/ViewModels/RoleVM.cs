using System;
using System.Collections.Generic;
using AspNetCoreSpa.Core.Entities;

namespace AspNetCoreSpa.Core.ViewModels
{
    public class RoleVM
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public ICollection<AccountVM> Accounts { get; set; }  
    }
}