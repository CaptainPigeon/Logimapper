using System;
using System.Collections.Generic;
using System.Text;

namespace LogiMapper.Models
{
    public class XInputDirections
    {
        public XInputDirections()
        {
            this.left = new XInputButton();
            this.right = new XInputButton();
            this.up = new XInputButton();
            this.down = new XInputButton();
        }
        public XInputButton left { get; set; }
        public XInputButton right { get; set; }
        public XInputButton up { get; set; }
        public XInputButton down { get; set; }
    }
}
