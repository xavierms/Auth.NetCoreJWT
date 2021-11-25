using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auth.Demo
{
    public interface IJwtAuthenticationManager
    {
        string Authenticate(string username, string password);
    }
}
