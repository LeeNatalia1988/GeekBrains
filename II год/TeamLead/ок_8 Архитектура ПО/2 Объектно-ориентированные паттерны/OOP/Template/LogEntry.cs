using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Template
{
    public class LogEntry
    {
        private string? text { get; }

        public string GetText()
        {
            return text;
        }

        public LogEntry(string text)
        {
            this.text = text;
        }

    }
}
