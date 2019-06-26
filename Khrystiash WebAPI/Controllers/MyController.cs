using Khrystiash_WebAPI.Proxies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Khrystiash_WebAPI.Controllers
{
    [Route( "api/[controller]" )]
    [ApiController]
    public class MyController: Controller
    {
        private IProxy iProxy;

        public MyController( IProxy iProxy )
        {
            this.iProxy = iProxy;
        }

        [HttpGet( "{str}" )]
        public ActionResult<bool> Get( string str )
        {
            return iProxy.isPalindrome(str);
        }
    }
}
