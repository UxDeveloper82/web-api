using sites4u.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sites4u.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
