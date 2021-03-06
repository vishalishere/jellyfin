using System.Collections.Generic;

namespace Emby.Dlna
{
    public class EventSubscriptionResponse
    {
        public string Content { get; set; }
        public string ContentType { get; set; }

        public Dictionary<string, string> Headers { get; set; }

        public EventSubscriptionResponse()
        {
            Headers = new Dictionary<string, string>();
        }
    }
}
