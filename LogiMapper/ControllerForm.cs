
using LogiMapper.Controllers;
using LogiMapper.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LogiMapper
{
    public partial class ControllerForm : Form
    {
        private ControllerFormController _controllerFormController;
        private List<Button> _buttons;
 
        public ControllerForm()
        {
            InitializeComponent();
            this._controllerFormController = new ControllerFormController();
            this._buttons = new List<Button>();
            this._buttons.Add(this.aButton);
            this._buttons.Add(this.bButton);
            this._buttons.Add(this.xButton);
            this._buttons.Add(this.yButton);
            this._buttons.Add(this.rtButton);
            this._buttons.Add(this.rbButton);
            this._buttons.Add(this.ltButton);
            this._buttons.Add(this.lbButton);
            this._buttons.Add(this.startButton);
            this._buttons.Add(this.backButton);
            this._buttons.Add(this.dPadUpButton);
            this._buttons.Add(this.dPadRightButton);
            this._buttons.Add(this.dPadDownButton);
            this._buttons.Add(this.dPadLeftButton);
            this._buttons.Add(this.leftStickUpButton);
            this._buttons.Add(this.leftStickRightButton);
            this._buttons.Add(this.leftStickDownButton);
            this._buttons.Add(this.leftStickLeftButton);
            this._buttons.Add(this.rightStickUpButton);
            this._buttons.Add(this.rightStickRightButton);
            this._buttons.Add(this.rightStickDownButton);
            this._buttons.Add(this.rightStickLeftButton);
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this._controllerFormController.startButtonWaiting(EInputXButton.Back);
            this.backButton.Focus();
        }

        private void ltButton_Click(object sender, EventArgs e)
        {
            this._controllerFormController.startButtonWaiting(EInputXButton.Lt);
            this.ltButton.Focus();
        }

        private void lbButton_Click(object sender, EventArgs e)
        {
            this._controllerFormController.startButtonWaiting(EInputXButton.Lb);
            this.lbButton.Focus();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this._controllerFormController.startButtonWaiting(EInputXButton.Start);
            this.startButton.Focus();
        }

        private void rtButton_Click(object sender, EventArgs e)
        {
            this._controllerFormController.startButtonWaiting(EInputXButton.Rt);
            this.rtButton.Focus();
        }

        private void rbButton_Click(object sender, EventArgs e)
        {
            this._controllerFormController.startButtonWaiting(EInputXButton.Rb);
            this.rbButton.Focus();
        }

        private void yButton_Click(object sender, EventArgs e)
        {
            this._controllerFormController.startButtonWaiting(EInputXButton.Y);
            this.yButton.Focus();
        }

        private void xButton_Click(object sender, EventArgs e)
        {
            this._controllerFormController.startButtonWaiting(EInputXButton.X);
            this.xButton.Focus();
        }

        private void bButton_Click(object sender, EventArgs e)
        {
            this._controllerFormController.startButtonWaiting(EInputXButton.B);
            this.bButton.Focus();
        }

        private void aButton_Click(object sender, EventArgs e)
        {
            this._controllerFormController.startButtonWaiting(EInputXButton.A);
            this.aButton.Focus();
        }

        private void rightStickUpButton_Click(object sender, EventArgs e)
        {
            this._controllerFormController.startButtonWaiting(EInputXButton.RightStickUp);
            this.rightStickUpButton.Focus();
        }

        private void rightStickRightButton_Click(object sender, EventArgs e)
        {
            this._controllerFormController.startButtonWaiting(EInputXButton.RightStickRight);
            this.rightStickRightButton.Focus();
        }

        private void rightStickDownButton_Click(object sender, EventArgs e)
        {
            this._controllerFormController.startButtonWaiting(EInputXButton.RightStickDown);
            this.rightStickDownButton.Focus();
        }

        private void rightStickLeftButton_Click(object sender, EventArgs e)
        {
            this._controllerFormController.startButtonWaiting(EInputXButton.RightStickLeft);
            this.rightStickLeftButton.Focus();
        }

        private void dPadUpButton_Click(object sender, EventArgs e)
        {
            this._controllerFormController.startButtonWaiting(EInputXButton.DPadUp);
            this.dPadUpButton.Focus();
        }

        private void dPadRightButton_Click(object sender, EventArgs e)
        {
            this._controllerFormController.startButtonWaiting(EInputXButton.DPadRight);
            this.dPadRightButton.Focus();
        }

        private void dPadLeftButton_Click(object sender, EventArgs e)
        {
            this._controllerFormController.startButtonWaiting(EInputXButton.DPadLeft);
            this.dPadRightButton.Focus();
        }

        private void dPadDownButton_Click(object sender, EventArgs e)
        {
            this._controllerFormController.startButtonWaiting(EInputXButton.DPadDown);
            this.dPadDownButton.Focus();
        }

        private void leftStickUpButton_Click(object sender, EventArgs e)
        {
            this._controllerFormController.startButtonWaiting(EInputXButton.LeftStickUp);
            this.leftStickUpButton.Focus();
        }

        private void leftStickLeftButton_Click(object sender, EventArgs e)
        {
            this._controllerFormController.startButtonWaiting(EInputXButton.LeftStickLeft);
            this.leftStickLeftButton.Focus();
        }

        private void leftStickDownButton_Click(object sender, EventArgs e)
        {
            this._controllerFormController.startButtonWaiting(EInputXButton.LeftStickDown);
            this.leftStickDownButton.Focus();
        }

        private void leftStickRightButton_Click(object sender, EventArgs e)
        {
            this._controllerFormController.startButtonWaiting(EInputXButton.LeftStrickRight);
            this.leftStickRightButton.Focus();
        }
        private void ControllerForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            EInputXButton? eInputXButton = this._controllerFormController.listenKeyDown(e.KeyChar);
            if(eInputXButton != null)
            {
                string key = e.KeyChar.ToString();
                switch (eInputXButton)
                {
                    case EInputXButton.A:
                        this.aButton.Text = key;
                        break;
                    case EInputXButton.B:
                        this.bButton.Text = key;
                        break;
                    case EInputXButton.X:
                        this.xButton.Text = key;
                        break;
                    case EInputXButton.Y:
                        this.yButton.Text = key;
                        break;
                    case EInputXButton.Start:
                        this.startButton.Text = key;
                        break;
                    case EInputXButton.Back:
                        this.backButton.Text = key;
                        break;
                    case EInputXButton.DPadDown:
                        this.dPadDownButton.Text = key;
                        break;
                    case EInputXButton.DPadLeft:
                        this.dPadLeftButton.Text = key;
                        break;
                    case EInputXButton.DPadRight:
                        this.dPadRightButton.Text = key;
                        break;
                    case EInputXButton.DPadUp:
                        this.dPadUpButton.Text = key;
                        break;
                    case EInputXButton.LeftStickDown:
                        this.leftStickDownButton.Text = key;
                        break;
                    case EInputXButton.LeftStickLeft:
                        this.leftStickLeftButton.Text = key;
                        break;
                    case EInputXButton.LeftStrickRight:
                        this.leftStickRightButton.Text = key;
                        break;
                    case EInputXButton.LeftStickUp:
                        this.leftStickUpButton.Text = key;
                        break;
                    case EInputXButton.RightStickDown:
                        this.rightStickDownButton.Text = key;
                        break;
                    case EInputXButton.RightStickLeft:
                        this.rightStickLeftButton.Text = key;
                        break;
                    case EInputXButton.RightStickRight:
                        this.rightStickRightButton.Text = key;
                        break;
                    case EInputXButton.RightStickUp:
                        this.rightStickUpButton.Text = key;
                        break;
                    case EInputXButton.Rt:
                        this.rtButton.Text = key;
                        break;
                    case EInputXButton.Rb:
                        this.rbButton.Text = key;
                        break;
                    case EInputXButton.Lt:
                        this.ltButton.Text = key;
                        break;
                    case EInputXButton.Lb:
                        this.lbButton.Text = key;
                        break;
                    default:
                        break;
                }
            }

        }

        //cycles through all buttons
        private void allButton_Click(object sender, EventArgs e)
        {
            this._buttons.ForEach(button => button.PerformClick());
        }
    }

}
