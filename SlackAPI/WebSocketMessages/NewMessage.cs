using System;

namespace SlackAPI.WebSocketMessages
{
    [SlackSocketRouting("message")]
    [SlackSocketRouting("message", "bot_message")]
    [SlackSocketRouting("message", "channel_join")]
    public class NewMessage : SlackSocketMessage
    {
        public string user;
        public string channel;
        public string text;
        public string team;
        public DateTime ts;
        public DateTime thread_ts;

        public NewMessage()
        {
            type = "message";
        }
    }
}
