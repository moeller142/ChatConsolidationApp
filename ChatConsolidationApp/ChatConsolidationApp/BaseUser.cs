using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatConsolidationApp
{
    public enum ChatService { Slack };

    public abstract class BaseUser
    {
        public string serviceUserName;
        public ChatService chatService;
        private IUserInfoAPIClient apiClient;
        public BaseUser(ChatService service, string userName, IUserInfoAPIClient apiClient)
        {
            this.serviceUserName = userName;
            this.chatService = service;
            this.apiClient = apiClient;
            this.PopulateUser();
        }

        public abstract void PopulateUser();

    }
}
