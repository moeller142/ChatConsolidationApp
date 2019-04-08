using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatConsolidationApp
{

    public class SlackUser : BaseUser
    {
        public SlackUser(string userName) : base(ChatService.Slack, userName, new SlackUserAPIClient())
        {
        }

        public override void PopulateUser()
        {

        }

        public string ID { get; set; }
        public string TeamID { get; set; }
        public string Name { get; set; }
        public bool Deleted { get; set; }
        public string Color { get; set; }
        public string RealName { get; set; }
        public string Tz { get; set; }
        public string TzLabel { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsOwner { get; set; }
        public bool IsPrimaryOwner { get; set; }
        public bool IsUltaRestriced { get; set; }
        public bool IsBot { get; set; }
        public bool IsStranger { get; set; }
        public DateTime Updated { get; set; }
        public bool IsAppUser { get; set; }
        public bool Has2Fa { get; set; }
        public string Locale { get; set; }
    }
}
