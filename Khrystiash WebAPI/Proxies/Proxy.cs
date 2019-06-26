using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Khrystiash_WebAPI.Services;

namespace Khrystiash_WebAPI.Proxies
{
    public class Proxy: IProxy
    {
        private IService service;

        public Proxy(IService service)
        {
            this.service = service;
        }

        public bool isPalindrome(string str)
        {
            return service.isPalindrome(str);
        }
    }
}
