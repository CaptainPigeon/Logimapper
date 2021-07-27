namespace LogiMapper
{
    partial class LogiMapperForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.logiMapperTabControl = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // logiMapperTabControl
            // 
            this.logiMapperTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.logiMapperTabControl.Location = new System.Drawing.Point(0, 0);
            this.logiMapperTabControl.Name = "logiMapperTabControl";
            this.logiMapperTabControl.SelectedIndex = 0;
            this.logiMapperTabControl.Size = new System.Drawing.Size(966, 599);
            this.logiMapperTabControl.TabIndex = 3;
            // 
            // backTextbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 625);
            this.Controls.Add(this.logiMapperTabControl);
            this.IsMdiContainer = true;
            this.Name = "backTextbox";
            this.Text = "LogiMapper";
   
            this.ResumeLayout(false);

        }

        #endregion

   
        private System.Windows.Forms.TabControl logiMapperTabControl;
    }
}

