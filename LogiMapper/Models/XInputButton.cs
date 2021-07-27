using System;
using System.Collections.Generic;
using System.Text;

namespace LogiMapper.Models
{
    public class XInputButton
    {
        public XInputButton()
        {
            this.isWaiting = false;
        }
        public char? key { get; set; }
        public bool isWaiting { get; set; }
    }
}
