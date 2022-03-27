using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using vidly.Models;
using vidly.ViewModels;

namespace vidly.Controllers
{
    public class RoleClaimController : Controller
    {
        ApplicationDbContext _context;
        public RoleClaimController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: RoleClaim
        public ActionResult AllUsers()
        {
            var model = _context.Users.ToList();
            return View(model);
        }
        
        public ActionResult Details(string id)
        {
            var AccountHolder =  _context.Users.SingleOrDefault(x => x.Id == id);
            return View(AccountHolder);
        }
        public ActionResult AddRole(string id)
        {
            var userStore = new UserStore<ApplicationUser>(new ApplicationDbContext());
            var userMananger = new UserManager<ApplicationUser>(userStore);
            var roleStore = new RoleStore<IdentityRole>(new ApplicationDbContext());
            var roleManager = new RoleManager<IdentityRole>(roleStore);
            var roleList = new RoleList();
            
            var AccountHolder = _context.Users.SingleOrDefault(x => x.Id == id);
            var RoleExtraced = roleManager.Roles.Select(name=>name.Name).ToList();
            roleList.Id = AccountHolder.Id;
            roleList.Name = AccountHolder.UserName;
            roleList.Email = AccountHolder.Email;
            roleList.ZipCode = AccountHolder.ZipCode;
            roleList.Roles = new List<string>() { "Director", "Manager", "Member", "DG" };
            roleList.AssignedRole = new List<string>();
            if (RoleExtraced != null)
            {
                foreach (var item in RoleExtraced)
                {
                    if(userMananger.IsInRole(AccountHolder.Id,item))
                    roleList.AssignedRole.Add(item);
                }
            }
            return View(roleList);
        }
        [HttpPost]
        public ActionResult AddRole(string role, string id)
        {
            var roleStore = new RoleStore<IdentityRole>(new ApplicationDbContext());
            var roleManager = new RoleManager<IdentityRole>(roleStore);
            roleManager.CreateAsync(new IdentityRole(role));
            var userStore = new UserStore<ApplicationUser>(new ApplicationDbContext());
            var userMananger = new UserManager<ApplicationUser>(userStore);
            userMananger.AddToRole(id, role);
            return RedirectToAction("AllUsers");
        }
    }
}