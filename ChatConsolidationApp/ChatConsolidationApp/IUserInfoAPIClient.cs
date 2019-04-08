using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatConsolidationApp
{
    public interface IUserInfoAPIClient
    {
        Task GetUserInfo(string userName);
        
    }
}
