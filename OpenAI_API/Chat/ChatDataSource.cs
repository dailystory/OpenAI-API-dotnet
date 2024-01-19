using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAI_API.Chat
{
    public class ChatDataSource
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("parameters")]
        public object Parameters { get; set; }
    }
}
