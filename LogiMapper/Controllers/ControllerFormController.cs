
using LogiMapper.Enums;
using LogiMapper.Helpers;
using LogiMapper.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogiMapper.Controllers
{
    public class ControllerFormController
    {

        private XInputController _controller;
        private List<EInputXButton> _eInputXButtons;

        public ControllerFormController()
        {
            this._controller = new XInputController();
            this._eInputXButtons = EnumHelper.GetValues<EInputXButton>();
        }

        //resets button to null
        public void removEInputXButtonkey(EInputXButton eInputXButton)
        {
            this.setButtonKey(eInputXButton, null);
        }
        //set button value on controller
        public void setButtonKey(EInputXButton eInputXButton, char? key)
        {

            switch (eInputXButton)
            {
                case EInputXButton.A:
                    this._controller.a.key = key;
                    break;
                case EInputXButton.B:
                    this._controller.b.key = key;
                    break;
                case EInputXButton.X:
                    this._controller.x.key = key;
                    break;
                case EInputXButton.Y:
                    this._controller.y.key = key;
                    break;
                case EInputXButton.Start:
                    this._controller.start.key = key;
                    break;
                case EInputXButton.Back:
                    this._controller.back.key = key;
                    break;
                case EInputXButton.DPadDown:
                    this._controller.dPad.down.key = key;
                    break;
                case EInputXButton.DPadLeft:
                    this._controller.dPad.left.key = key;
                    break;
                case EInputXButton.DPadRight:
                    this._controller.dPad.right.key = key;
                    break;
                case EInputXButton.DPadUp:
                    this._controller.dPad.up.key = key;
                    break;
                case EInputXButton.LeftStickDown:
                    this._controller.leftStick.down.key = key;
                    break;
                case EInputXButton.LeftStickLeft:
                    this._controller.leftStick.left.key = key;
                    break;
                case EInputXButton.LeftStrickRight:
                    this._controller.leftStick.right.key = key;
                    break;
                case EInputXButton.LeftStickUp:
                    this._controller.leftStick.up.key = key;
                    break;
                case EInputXButton.RightStickDown:
                    this._controller.rightStick.down.key = key;
                    break;
                case EInputXButton.RightStickLeft:
                    this._controller.rightStick.left.key = key;
                    break;
                case EInputXButton.RightStickRight:
                    this._controller.rightStick.right.key = key;
                    break;
                case EInputXButton.RightStickUp:
                    this._controller.rightStick.up.key = key;
                    break;
                case EInputXButton.Rt:
                    this._controller.rt.key = key;
                    break;
                case EInputXButton.Rb:
                    this._controller.rb.key = key;
                    break;
                case EInputXButton.Lt:
                    this._controller.lt.key = key;
                    break;
                case EInputXButton.Lb:
                    this._controller.lb.key = key;
                    break;
                default:
                    break;
            }
        }

        //sets button to waiting for listen
        public void startButtonWaiting(EInputXButton eInputXButton)
        {
            switch (eInputXButton)
            {
                case EInputXButton.A:
                    this.resetAllWaiting();
                    this._controller.a.isWaiting = true;
                    this._controller.isWaiting = true;
                    break;
                case EInputXButton.B:
                    this.resetAllWaiting();
                    this._controller.b.isWaiting = true;
                    this._controller.isWaiting = true;
                    break;
                case EInputXButton.X:
                    this.resetAllWaiting();
                    this._controller.x.isWaiting = true;
                    this._controller.isWaiting = true;
                    break;
                case EInputXButton.Y:
                    this.resetAllWaiting();
                    this._controller.y.isWaiting = true;
                    this._controller.isWaiting = true;
                    break;
                case EInputXButton.Start:
                    this.resetAllWaiting();
                    this._controller.start.isWaiting = true;
                    this._controller.isWaiting = true;
                    break;
                case EInputXButton.Back:
                    this.resetAllWaiting();
                    this._controller.back.isWaiting = true;
                    this._controller.isWaiting = true;
                    break;
                case EInputXButton.DPadDown:
                    this.resetAllWaiting();
                    this._controller.dPad.down.isWaiting = true;
                    this._controller.isWaiting = true;
                    break;
                case EInputXButton.DPadLeft:
                    this.resetAllWaiting();
                    this._controller.dPad.left.isWaiting = true;
                    this._controller.isWaiting = true;
                    break;
                case EInputXButton.DPadRight:
                    this.resetAllWaiting();
                    this._controller.dPad.right.isWaiting = true;
                    this._controller.isWaiting = true;
                    break;
                case EInputXButton.DPadUp:
                    this.resetAllWaiting();
                    this._controller.dPad.up.isWaiting = true;
                    this._controller.isWaiting = true;
                    break;
                case EInputXButton.LeftStickDown:
                    this.resetAllWaiting();
                    this._controller.leftStick.down.isWaiting = true;
                    this._controller.isWaiting = true;
                    break;
                case EInputXButton.LeftStickLeft:
                    this.resetAllWaiting();
                    this._controller.leftStick.left.isWaiting = true;
                    this._controller.isWaiting = true;
                    break;
                case EInputXButton.LeftStrickRight:
                    this.resetAllWaiting();
                    this._controller.leftStick.right.isWaiting = true;
                    this._controller.isWaiting = true;
                    break;
                case EInputXButton.LeftStickUp:
                    this.resetAllWaiting();
                    this._controller.leftStick.up.isWaiting = true;
                    this._controller.isWaiting = true;
                    break;
                case EInputXButton.RightStickDown:
                    this.resetAllWaiting();
                    this._controller.rightStick.down.isWaiting = true;
                    this._controller.isWaiting = true;
                    break;
                case EInputXButton.RightStickLeft:
                    this.resetAllWaiting();
                    this._controller.rightStick.left.isWaiting = true;
                    this._controller.isWaiting = true;
                    break;
                case EInputXButton.RightStickRight:
                    this.resetAllWaiting();
                    this._controller.rightStick.right.isWaiting = true;
                    this._controller.isWaiting = true;
                    break;
                case EInputXButton.RightStickUp:
                    this.resetAllWaiting();
                    this._controller.rightStick.up.isWaiting = true;
                    this._controller.isWaiting = true;
                    break;
                case EInputXButton.Rt:
                    this.resetAllWaiting();
                    this._controller.rt.isWaiting = true;
                    this._controller.isWaiting = true;
                    break;
                case EInputXButton.Rb:
                    this.resetAllWaiting();
                    this._controller.rb.isWaiting = true;
                    this._controller.isWaiting = true;
                    break;
                case EInputXButton.Lt:
                    this.resetAllWaiting();
                    this._controller.lt.isWaiting = true;
                    this._controller.isWaiting = true;
                    break;
                case EInputXButton.Lb:
                    this.resetAllWaiting();
                    this._controller.lb.isWaiting = true;
                    this._controller.isWaiting = true;
                    break;
                default:
                    break;
            }
        }

        public void stopButtonWaiting(EInputXButton eInputXButton)
        {
            switch (eInputXButton)
            {
                case EInputXButton.A:
                    this._controller.a.isWaiting = false;
                    this._controller.isWaiting = false;
                    break;
                case EInputXButton.B:
                    this._controller.b.isWaiting = false;
                    this._controller.isWaiting = false;
                    break;
                case EInputXButton.X:
                    this._controller.x.isWaiting = false;
                    this._controller.isWaiting = false;
                    break;
                case EInputXButton.Y:
                    this._controller.y.isWaiting = false;
                    this._controller.isWaiting = false;
                    break;
                case EInputXButton.Start:
                    this._controller.start.isWaiting = false;
                    this._controller.isWaiting = false;
                    break;
                case EInputXButton.Back:
                    this._controller.back.isWaiting = false;
                    this._controller.isWaiting = false;
                    break;
                case EInputXButton.DPadDown:
                    this._controller.dPad.down.isWaiting = false;
                    this._controller.isWaiting = false;
                    break;
                case EInputXButton.DPadLeft:
                    this._controller.dPad.left.isWaiting = false;
                    this._controller.isWaiting = false;
                    break;
                case EInputXButton.DPadRight:
                    this._controller.dPad.right.isWaiting = false;
                    this._controller.isWaiting = false;
                    break;
                case EInputXButton.DPadUp:
                    this._controller.dPad.up.isWaiting = false;
                    this._controller.isWaiting = false;
                    break;
                case EInputXButton.LeftStickDown:
                    this._controller.leftStick.down.isWaiting = false;
                    this._controller.isWaiting = false;
                    break;
                case EInputXButton.LeftStickLeft:
                    this._controller.leftStick.left.isWaiting = false;
                    this._controller.isWaiting = false;
                    break;
                case EInputXButton.LeftStrickRight:
                    this._controller.leftStick.right.isWaiting = false;
                    this._controller.isWaiting = false;
                    break;
                case EInputXButton.LeftStickUp:
                    this._controller.leftStick.up.isWaiting = false;
                    this._controller.isWaiting = false;
                    break;
                case EInputXButton.RightStickDown:
                    this._controller.rightStick.down.isWaiting = false;
                    this._controller.isWaiting = false;
                    break;
                case EInputXButton.RightStickLeft:
                    this._controller.rightStick.left.isWaiting = false;
                    this._controller.isWaiting = false;
                    break;
                case EInputXButton.RightStickRight:
                    this._controller.rightStick.right.isWaiting = false;
                    this._controller.isWaiting = false;
                    break;
                case EInputXButton.RightStickUp:
                    this._controller.rightStick.up.isWaiting = false;
                    this._controller.isWaiting = false;
                    break;
                case EInputXButton.Rt:
                    this._controller.rt.isWaiting = false;
                    this._controller.isWaiting = false;
                    break;
                case EInputXButton.Rb:
                    this._controller.rb.isWaiting = false;
                    this._controller.isWaiting = false;
                    break;
                case EInputXButton.Lt:
                    this._controller.lt.isWaiting = false;
                    this._controller.isWaiting = false;
                    break;
                case EInputXButton.Lb:
                    this._controller.lb.isWaiting = false;
                    this._controller.isWaiting = false;
                    break;
                default:
                    break;
            }
        }

        //get button value 
        public char? getButtonKey(EInputXButton eInputXButton)
        {
            switch (eInputXButton)
            {
                case EInputXButton.A:
                    return this._controller.a.key;
                case EInputXButton.B:
                    return this._controller.b.key;
                case EInputXButton.X:
                    return this._controller.x.key;
                case EInputXButton.Y:
                    return this._controller.y.key;
                case EInputXButton.Start:
                    return this._controller.start.key;
                case EInputXButton.Back:
                    return this._controller.back.key;
                case EInputXButton.DPadDown:
                    return this._controller.dPad.down.key;
                case EInputXButton.DPadLeft:
                    return this._controller.dPad.left.key;
                case EInputXButton.DPadRight:
                    return this._controller.dPad.right.key;
                case EInputXButton.DPadUp:
                    return this._controller.dPad.up.key;
                case EInputXButton.LeftStickDown:
                    return this._controller.leftStick.down.key;
                case EInputXButton.LeftStickLeft:
                    return this._controller.leftStick.left.key;
                case EInputXButton.LeftStrickRight:
                    return this._controller.leftStick.right.key;
                case EInputXButton.LeftStickUp:
                    return this._controller.leftStick.up.key;
                case EInputXButton.RightStickDown:
                    return this._controller.rightStick.down.key;
                case EInputXButton.RightStickLeft:
                    return this._controller.rightStick.left.key;
                case EInputXButton.RightStickRight:
                    return this._controller.rightStick.right.key;
                case EInputXButton.RightStickUp:
                    return this._controller.rightStick.up.key;
                case EInputXButton.Rt:
                    return this._controller.rt.key;
                case EInputXButton.Rb:
                    return this._controller.rb.key;
                case EInputXButton.Lt:
                    return this._controller.lt.key;
                case EInputXButton.Lb:
                    return this._controller.lb.key;
                default:
                    return null; //error
            }
        }

        //get button wait 
        public bool isWaitingButton(EInputXButton eInputXButton)
        {
            switch (eInputXButton)
            {
                case EInputXButton.A:
                    return this._controller.a.isWaiting;
                case EInputXButton.B:
                    return this._controller.b.isWaiting;
                case EInputXButton.X:
                    return this._controller.x.isWaiting;
                case EInputXButton.Y:
                    return this._controller.y.isWaiting;
                case EInputXButton.Start:
                    return this._controller.start.isWaiting;
                case EInputXButton.Back:
                    return this._controller.back.isWaiting;
                case EInputXButton.DPadDown:
                    return this._controller.dPad.down.isWaiting;
                case EInputXButton.DPadLeft:
                    return this._controller.dPad.left.isWaiting;
                case EInputXButton.DPadRight:
                    return this._controller.dPad.right.isWaiting;
                case EInputXButton.DPadUp:
                    return this._controller.dPad.up.isWaiting;
                case EInputXButton.LeftStickDown:
                    return this._controller.leftStick.down.isWaiting;
                case EInputXButton.LeftStickLeft:
                    return this._controller.leftStick.left.isWaiting;
                case EInputXButton.LeftStrickRight:
                    return this._controller.leftStick.right.isWaiting;
                case EInputXButton.LeftStickUp:
                    return this._controller.leftStick.up.isWaiting;
                case EInputXButton.RightStickDown:
                    return this._controller.rightStick.down.isWaiting;
                case EInputXButton.RightStickLeft:
                    return this._controller.rightStick.left.isWaiting;
                case EInputXButton.RightStickRight:
                    return this._controller.rightStick.right.isWaiting;
                case EInputXButton.RightStickUp:
                    return this._controller.rightStick.up.isWaiting;
                case EInputXButton.Rt:
                    return this._controller.rt.isWaiting;
                case EInputXButton.Rb:
                    return this._controller.rb.isWaiting;
                case EInputXButton.Lt:
                    return this._controller.lt.isWaiting;
                case EInputXButton.Lb:
                    return this._controller.lb.isWaiting;
                default:
                    return false; //error
            }
        }

        //listens for keydown and then sets key
        public EInputXButton? listenKeyDown(char key)
        {

            if (this._controller.isWaiting && !this.isKeyAssigned(key))
            {
                foreach (EInputXButton eInputXButton in this._eInputXButtons)
                {

                    if (this.isWaitingButton(eInputXButton))
                    {
                        this.setButtonKey(eInputXButton, key);
                        this.stopButtonWaiting(eInputXButton);
                        return eInputXButton;
                    }

                }
            }
            return null; //none
        }


        //check if key is already assigned
        private bool isKeyAssigned(char key)
        {
            return this._controller.a.key == key ||
                this._controller.b.key == key ||
                this._controller.x.key == key ||
                this._controller.y.key == key ||
                this._controller.rt.key == key ||
                this._controller.rb.key == key ||
                this._controller.lt.key == key ||
                this._controller.lb.key == key ||
                this._controller.back.key == key ||
                this._controller.start.key == key ||
                this._controller.dPad.left.key == key ||
                this._controller.dPad.right.key == key ||
                this._controller.dPad.up.key == key ||
                this._controller.dPad.down.key == key ||
                this._controller.leftStick.left.key == key ||
                this._controller.leftStick.right.key == key ||
                this._controller.leftStick.up.key == key ||
                this._controller.leftStick.down.key == key ||
                this._controller.rightStick.left.key == key ||
                this._controller.rightStick.right.key == key ||
                this._controller.rightStick.up.key == key ||
                this._controller.rightStick.down.key == key;
    
        }
        //resets all isWaiting to false
        private void resetAllWaiting()
        {
            this._controller.a.isWaiting = false;
            this._controller.b.isWaiting = false;
            this._controller.x.isWaiting = false;
            this._controller.y.isWaiting = false;
            this._controller.start.isWaiting = false;
            this._controller.back.isWaiting = false;
            this._controller.dPad.down.isWaiting = false;
            this._controller.dPad.left.isWaiting = false;
            this._controller.dPad.right.isWaiting = false;
            this._controller.dPad.up.isWaiting = false;
            this._controller.leftStick.down.isWaiting = false;
            this._controller.leftStick.left.isWaiting = false;
            this._controller.leftStick.right.isWaiting = false;
            this._controller.leftStick.up.isWaiting = false;
            this._controller.rightStick.down.isWaiting = false;
            this._controller.rightStick.left.isWaiting = false;
            this._controller.rightStick.right.isWaiting = false;
            this._controller.rightStick.up.isWaiting = false;
            this._controller.rt.isWaiting = false;
            this._controller.rb.isWaiting = false;
            this._controller.lt.isWaiting = false;
            this._controller.lb.isWaiting = false;
            this._controller.isWaiting = false;
        }


    }
}
