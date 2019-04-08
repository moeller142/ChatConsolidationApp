using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ChatConsolidationApp
{
    public class SlackUserAPIClient : IUserInfoAPIClient
    {
        private HttpClient httpClient;
        private string basePath;
        private const string token = "token";
        private const string user = "user";


        public SlackUserAPIClient()
        {
            this.httpClient = new HttpClient();
            this.basePath = "https://slack.com/api/";
        }
        public async Task GetUserInfo(string userName)
        {
            var path = basePath + "user.info";
            var webClient = new WebClient();
            webClient.QueryString.Add(token, GetToken());
            webClient.QueryString.Add(user, userName);

            await webClient.DownloadStringTaskAsync(path);
        }

        private string GetToken()
        {
            return "xoxp-604326463415-603699746853-603188303076-b0e2028613e460d9c9b83ed11b4e2dea";
        }
    }
}
