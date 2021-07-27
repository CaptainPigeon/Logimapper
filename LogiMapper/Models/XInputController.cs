using System;
using System.Collections.Generic;
using System.Text;

namespace LogiMapper.Models
{
    public class XInputController
    {
        public XInputController()
        {
            this.leftStick = new XInputDirections();
            this.rightStick = new XInputDirections();
            this.dPad = new XInputDirections();
            this.a = new XInputButton();
            this.b = new XInputButton();
            this.x = new XInputButton();
            this.y = new XInputButton();
            this.rt = new XInputButton();
            this.rb = new XInputButton();
            this.lt = new XInputButton();
            this.lb = new XInputButton();
            this.start = new XInputButton();
            this.back = new XInputButton();
            this.isWaiting = false;
        }
        public XInputDirections leftStick { get; set; }
        public XInputDirections rightStick { get; set; }
        public XInputDirections dPad { get; set; }
        public XInputButton a { get; set; }
        public XInputButton b { get; set; }
        public XInputButton x { get; set; }
        public XInputButton y { get; set; }
        public XInputButton lt { get; set; }
        public XInputButton lb { get; set; }
        public XInputButton rt { get; set; }
        public XInputButton rb { get; set; }
        public XInputButton start { get; set; }
        public XInputButton back { get; set; }
        public bool isWaiting { get; set; }
    }
}
