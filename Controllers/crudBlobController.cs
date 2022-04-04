using FieldforceCareersSolution.DBContexts;
using FieldforceCareersSolution.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace EFCoreMySQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserGroupController : ControllerBase
    {
        private MyDBContext myDbContext;

        public UserGroupController(MyDBContext context)
        {
            myDbContext = context;
        }

        //[HttpGet]
        //public IList<UserGroup> Get()
        //{
        //    return (this.myDbContext.UserGroups.ToList());
        //}
    }
}