using System;
using System.Windows.Forms;

namespace LogiMapper
{
    partial class ControllerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControllerForm));
            this.controllerPicBox = new System.Windows.Forms.PictureBox();
            this.yButton = new System.Windows.Forms.Button();
            this.xButton = new System.Windows.Forms.Button();
            this.bButton = new System.Windows.Forms.Button();
            this.aButton = new System.Windows.Forms.Button();
            this.dPadUpButton = new System.Windows.Forms.Button();
            this.dPadRightButton = new System.Windows.Forms.Button();
            this.dPadLeftButton = new System.Windows.Forms.Button();
            this.dPadDownButton = new System.Windows.Forms.Button();
            this.rightStickUpButton = new System.Windows.Forms.Button();
            this.rightStickRightButton = new System.Windows.Forms.Button();
            this.rightStickDownButton = new System.Windows.Forms.Button();
            this.rightStickLeftButton = new System.Windows.Forms.Button();
            this.leftStickUpButton = new System.Windows.Forms.Button();
            this.leftStickLeftButton = new System.Windows.Forms.Button();
            this.leftStickDownButton = new System.Windows.Forms.Button();
            this.leftStickRightButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.rtButton = new System.Windows.Forms.Button();
            this.rbButton = new System.Windows.Forms.Button();
            this.lbButton = new System.Windows.Forms.Button();
            this.ltButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.allButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.controllerPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // controllerPicBox
            // 
            this.controllerPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.controllerPicBox.Image = ((System.Drawing.Image)(resources.GetObject("controllerPicBox.Image")));
            this.controllerPicBox.Location = new System.Drawing.Point(124, 20);
            this.controllerPicBox.Name = "controllerPicBox";
            this.controllerPicBox.Size = new System.Drawing.Size(757, 526);
            this.controllerPicBox.TabIndex = 0;
            this.controllerPicBox.TabStop = false;
            // 
            // yButton
            // 
            this.yButton.Location = new System.Drawing.Point(881, 121);
            this.yButton.Name = "yButton";
            this.yButton.Size = new System.Drawing.Size(120, 30);
            this.yButton.TabIndex = 1;
            this.yButton.UseVisualStyleBackColor = true;
            this.yButton.Click += new System.EventHandler(this.yButton_Click);
            // 
            // xButton
            // 
            this.xButton.Location = new System.Drawing.Point(881, 153);
            this.xButton.Name = "xButton";
            this.xButton.Size = new System.Drawing.Size(120, 30);
            this.xButton.TabIndex = 1;
            this.xButton.UseVisualStyleBackColor = true;
            this.xButton.Click += new System.EventHandler(this.xButton_Click);
            // 
            // bButton
            // 
            this.bButton.Location = new System.Drawing.Point(881, 185);
            this.bButton.Name = "bButton";
            this.bButton.Size = new System.Drawing.Size(120, 30);
            this.bButton.TabIndex = 1;
            this.bButton.UseVisualStyleBackColor = true;
            this.bButton.Click += new System.EventHandler(this.bButton_Click);
            // 
            // aButton
            // 
            this.aButton.Location = new System.Drawing.Point(882, 217);
            this.aButton.Name = "aButton";
            this.aButton.Size = new System.Drawing.Size(120, 30);
            this.aButton.TabIndex = 1;
            this.aButton.UseVisualStyleBackColor = true;
            this.aButton.Click += new System.EventHandler(this.aButton_Click);
            // 
            // dPadUpButton
            // 
            this.dPadUpButton.Location = new System.Drawing.Point(5, 121);
            this.dPadUpButton.Name = "dPadUpButton";
            this.dPadUpButton.Size = new System.Drawing.Size(120, 30);
            this.dPadUpButton.TabIndex = 1;
            this.dPadUpButton.UseVisualStyleBackColor = true;
            this.dPadUpButton.Click += new System.EventHandler(this.dPadUpButton_Click);
            // 
            // dPadRightButton
            // 
            this.dPadRightButton.Location = new System.Drawing.Point(5, 153);
            this.dPadRightButton.Name = "dPadRightButton";
            this.dPadRightButton.Size = new System.Drawing.Size(120, 30);
            this.dPadRightButton.TabIndex = 1;
            this.dPadRightButton.UseVisualStyleBackColor = true;
            this.dPadRightButton.Click += new System.EventHandler(this.dPadRightButton_Click);
            // 
            // dPadLeftButton
            // 
            this.dPadLeftButton.Location = new System.Drawing.Point(5, 185);
            this.dPadLeftButton.Name = "dPadLeftButton";
            this.dPadLeftButton.Size = new System.Drawing.Size(120, 30);
            this.dPadLeftButton.TabIndex = 1;
            this.dPadLeftButton.UseVisualStyleBackColor = true;
            this.dPadLeftButton.Click += new System.EventHandler(this.dPadLeftButton_Click);
            // 
            // dPadDownButton
            // 
            this.dPadDownButton.Location = new System.Drawing.Point(5, 217);
            this.dPadDownButton.Name = "dPadDownButton";
            this.dPadDownButton.Size = new System.Drawing.Size(120, 30);
            this.dPadDownButton.TabIndex = 1;
            this.dPadDownButton.UseVisualStyleBackColor = true;
            this.dPadDownButton.Click += new System.EventHandler(this.dPadDownButton_Click);
            // 
            // rightStickUpButton
            // 
            this.rightStickUpButton.Location = new System.Drawing.Point(882, 309);
            this.rightStickUpButton.Name = "rightStickUpButton";
            this.rightStickUpButton.Size = new System.Drawing.Size(120, 30);
            this.rightStickUpButton.TabIndex = 1;
            this.rightStickUpButton.UseVisualStyleBackColor = true;
            this.rightStickUpButton.Click += new System.EventHandler(this.rightStickUpButton_Click);
            // 
            // rightStickRightButton
            // 
            this.rightStickRightButton.Location = new System.Drawing.Point(882, 341);
            this.rightStickRightButton.Name = "rightStickRightButton";
            this.rightStickRightButton.Size = new System.Drawing.Size(120, 30);
            this.rightStickRightButton.TabIndex = 1;
            this.rightStickRightButton.UseVisualStyleBackColor = true;
            this.rightStickRightButton.Click += new System.EventHandler(this.rightStickRightButton_Click);
            // 
            // rightStickDownButton
            // 
            this.rightStickDownButton.Location = new System.Drawing.Point(882, 373);
            this.rightStickDownButton.Name = "rightStickDownButton";
            this.rightStickDownButton.Size = new System.Drawing.Size(120, 30);
            this.rightStickDownButton.TabIndex = 1;
            this.rightStickDownButton.UseVisualStyleBackColor = true;
            this.rightStickDownButton.Click += new System.EventHandler(this.rightStickDownButton_Click);
            // 
            // rightStickLeftButton
            // 
            this.rightStickLeftButton.Location = new System.Drawing.Point(882, 405);
            this.rightStickLeftButton.Name = "rightStickLeftButton";
            this.rightStickLeftButton.Size = new System.Drawing.Size(120, 30);
            this.rightStickLeftButton.TabIndex = 1;
            this.rightStickLeftButton.UseVisualStyleBackColor = true;
            this.rightStickLeftButton.Click += new System.EventHandler(this.rightStickLeftButton_Click);
            // 
            // leftStickUpButton
            // 
            this.leftStickUpButton.Location = new System.Drawing.Point(5, 309);
            this.leftStickUpButton.Name = "leftStickUpButton";
            this.leftStickUpButton.Size = new System.Drawing.Size(120, 30);
            this.leftStickUpButton.TabIndex = 1;
            this.leftStickUpButton.UseVisualStyleBackColor = true;
            this.leftStickUpButton.Click += new System.EventHandler(this.leftStickUpButton_Click);
            // 
            // leftStickLeftButton
            // 
            this.leftStickLeftButton.Location = new System.Drawing.Point(5, 341);
            this.leftStickLeftButton.Name = "leftStickLeftButton";
            this.leftStickLeftButton.Size = new System.Drawing.Size(120, 30);
            this.leftStickLeftButton.TabIndex = 1;
            this.leftStickLeftButton.UseVisualStyleBackColor = true;
            this.leftStickLeftButton.Click += new System.EventHandler(this.leftStickLeftButton_Click);
            // 
            // leftStickDownButton
            // 
            this.leftStickDownButton.Location = new System.Drawing.Point(5, 373);
            this.leftStickDownButton.Name = "leftStickDownButton";
            this.leftStickDownButton.Size = new System.Drawing.Size(120, 30);
            this.leftStickDownButton.TabIndex = 1;
            this.leftStickDownButton.UseVisualStyleBackColor = true;
            this.leftStickDownButton.Click += new System.EventHandler(this.leftStickDownButton_Click);
            // 
            // leftStickRightButton
            // 
            this.leftStickRightButton.Location = new System.Drawing.Point(5, 405);
            this.leftStickRightButton.Name = "leftStickRightButton";
            this.leftStickRightButton.Size = new System.Drawing.Size(120, 30);
            this.leftStickRightButton.TabIndex = 1;
            this.leftStickRightButton.UseVisualStyleBackColor = true;
            this.leftStickRightButton.Click += new System.EventHandler(this.leftStickRightButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(653, 5);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(120, 30);
            this.startButton.TabIndex = 1;
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // rtButton
            // 
            this.rtButton.Location = new System.Drawing.Point(653, 37);
            this.rtButton.Name = "rtButton";
            this.rtButton.Size = new System.Drawing.Size(120, 30);
            this.rtButton.TabIndex = 1;
            this.rtButton.UseVisualStyleBackColor = true;
            this.rtButton.Click += new System.EventHandler(this.rtButton_Click);
            // 
            // rbButton
            // 
            this.rbButton.Location = new System.Drawing.Point(653, 69);
            this.rbButton.Name = "rbButton";
            this.rbButton.Size = new System.Drawing.Size(120, 30);
            this.rbButton.TabIndex = 1;
            this.rbButton.UseVisualStyleBackColor = true;
            this.rbButton.Click += new System.EventHandler(this.rbButton_Click);
            // 
            // lbButton
            // 
            this.lbButton.Location = new System.Drawing.Point(254, 69);
            this.lbButton.Name = "lbButton";
            this.lbButton.Size = new System.Drawing.Size(120, 30);
            this.lbButton.TabIndex = 1;
            this.lbButton.UseVisualStyleBackColor = true;
            this.lbButton.Click += new System.EventHandler(this.lbButton_Click);
            // 
            // ltButton
            // 
            this.ltButton.Location = new System.Drawing.Point(254, 37);
            this.ltButton.Name = "ltButton";
            this.ltButton.Size = new System.Drawing.Size(120, 30);
            this.ltButton.TabIndex = 1;
            this.ltButton.UseVisualStyleBackColor = true;
            this.ltButton.Click += new System.EventHandler(this.ltButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(254, 5);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(120, 30);
            this.backButton.TabIndex = 1;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // allButton
            // 
            this.allButton.Location = new System.Drawing.Point(12, 20);
            this.allButton.Name = "allButton";
            this.allButton.Size = new System.Drawing.Size(113, 28);
            this.allButton.TabIndex = 2;
            this.allButton.Text = "All";
            this.allButton.UseVisualStyleBackColor = true;
            this.allButton.Click += new System.EventHandler(this.allButton_Click);
            // 
            // ControllerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1007, 551);
            this.Controls.Add(this.allButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.ltButton);
            this.Controls.Add(this.lbButton);
            this.Controls.Add(this.rbButton);
            this.Controls.Add(this.rtButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.leftStickRightButton);
            this.Controls.Add(this.leftStickDownButton);
            this.Controls.Add(this.leftStickLeftButton);
            this.Controls.Add(this.leftStickUpButton);
            this.Controls.Add(this.rightStickLeftButton);
            this.Controls.Add(this.rightStickDownButton);
            this.Controls.Add(this.rightStickRightButton);
            this.Controls.Add(this.rightStickUpButton);
            this.Controls.Add(this.dPadDownButton);
            this.Controls.Add(this.dPadLeftButton);
            this.Controls.Add(this.dPadRightButton);
            this.Controls.Add(this.dPadUpButton);
            this.Controls.Add(this.aButton);
            this.Controls.Add(this.bButton);
            this.Controls.Add(this.xButton);
            this.Controls.Add(this.yButton);
            this.Controls.Add(this.controllerPicBox);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "ControllerForm";
            this.Text = "S";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ControllerForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.controllerPicBox)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.PictureBox controllerPicBox;
        private System.Windows.Forms.Button yButton;
        private System.Windows.Forms.Button xButton;
        private System.Windows.Forms.Button bButton;
        private System.Windows.Forms.Button aButton;
        private System.Windows.Forms.Button dPadUpButton;
        private System.Windows.Forms.Button dPadRightButton;
        private System.Windows.Forms.Button dPadLeftButton;
        private System.Windows.Forms.Button dPadDownButton;
        private System.Windows.Forms.Button rightStickUpButton;
        private System.Windows.Forms.Button rightStickRightButton;
        private System.Windows.Forms.Button rightStickDownButton;
        private System.Windows.Forms.Button rightStickLeftButton;
        private System.Windows.Forms.Button leftStickUpButton;
        private System.Windows.Forms.Button leftStickLeftButton;
        private System.Windows.Forms.Button leftStickDownButton;
        private System.Windows.Forms.Button leftStickRightButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button rtButton;
        private System.Windows.Forms.Button rbButton;
        private System.Windows.Forms.Button lbButton;
        private System.Windows.Forms.Button ltButton;
        private System.Windows.Forms.Button backButton;
        private Button allButton;
    }
}