using FastCarServer.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCarServer.Application.Common.Interfaces
{
    public interface ISendVerificationCode
    {
        Task SendCode(ApplicationUser user);
    }
}
