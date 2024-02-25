using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace RheaChatBot.Models
{
    [ContentProperty("Value")]
    public class ReceiveItem
    {
        public String Value { get; set; } = String.Empty;
    }
}
