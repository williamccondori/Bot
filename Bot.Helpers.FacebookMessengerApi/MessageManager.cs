using Bot.Helpers.FacebookMessengerApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Helpers.FacebookMessengerApi
{
    public class MessageManager
    {
        private string _AccessToken;
        private string _VersionApi;

        public MessageManager(string accessToken, string versionApi="2.6")
        {
            _AccessToken = accessToken;
            _VersionApi = versionApi;
        }

        public bool SendText(SendApiMessage sendApiMessage)
        {
            string url = string.Format("https://graph.facebook.com/v{0}/me/messages?access_token={1}", _VersionApi, _AccessToken);

            return true;
        }
    }
}
