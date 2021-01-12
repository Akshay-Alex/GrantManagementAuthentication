using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using GrantManagementAuthentication.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GrantManagementAuthentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class DataController : ControllerBase
    {

        //DatabaseDbContext db = new DatabaseDbContext(); 
        // GET: api/<DataController>
        
        //[Authorize(AuthenticationSchemes =]
        List<ApplicationUser> users = new List<ApplicationUser>();
        [HttpGet]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public IEnumerable<ApplicationUser> Get()
        {
            users.Add(new ApplicationUser() { EmailAddress = "akshay", Password = "123" });
            return users;
            
            //return db.UserInfo.ToList() ;
        }

        
    }
}
