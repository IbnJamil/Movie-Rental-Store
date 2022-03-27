using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vidly.ViewModels
{
    public class RoleList
    {
        public string Id { get; set; }
        public List<string> Roles { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string ZipCode { get; set; }
        public List<string> AssignedRole { get; set; }
    }
}