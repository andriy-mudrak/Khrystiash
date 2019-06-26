using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Khrystiash_WebAPI.Services
{
    public class Service: IService
    {
        public bool isPalindrome( string str )
        {
            str = Regex.Replace(str, "[^A-Za-z0-9]", "").ToLower();
            int size = str.Length;

            for ( int i = 0; i < size / 2; i++ )
            {
                if ( str [i] != str [size - i - 1] )
                    return  false;
            }
            return true;
        }
    }
}
