﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using HW;


namespace HW
{
    public class Message
    {
        public string? Text { get; set; }
        public DateTime DateTime { get; set; }
        public string? NickNameFrom { get; set; }
        public string? NickNameTo { get; set; }


        public string SerializeMessageToJson() => JsonSerializer.Serialize(this);

        public static Message? DeserializeFromJsonToMessage(string message) => JsonSerializer.Deserialize<Message>(message);

        public void PrintMessage()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"В {this.DateTime}\nДоставлено сообщение от {this.NickNameFrom} для {this.NickNameTo}\n {this.Text}";
        }
    }
}
