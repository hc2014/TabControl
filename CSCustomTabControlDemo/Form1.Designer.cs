
namespace CSCustomTabControlDemo
{
    partial class Form1
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
            this.customTabControl3 = new System.Windows.Forms.CustomTabControl();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.tabPage13 = new System.Windows.Forms.TabPage();
            this.tabPage14 = new System.Windows.Forms.TabPage();
            this.tabPage15 = new System.Windows.Forms.TabPage();
            this.customTabControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // customTabControl3
            // 
            this.customTabControl3.Controls.Add(this.tabPage11);
            this.customTabControl3.Controls.Add(this.tabPage12);
            this.customTabControl3.Controls.Add(this.tabPage13);
            this.customTabControl3.Controls.Add(this.tabPage14);
            this.customTabControl3.Controls.Add(this.tabPage15);
            this.customTabControl3.DisplayStyle = System.Windows.Forms.TabStyle.Rounded;
            // 
            // 
            // 
            this.customTabControl3.DisplayStyleProvider.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.customTabControl3.DisplayStyleProvider.BorderColorHot = System.Drawing.SystemColors.ControlDark;
            this.customTabControl3.DisplayStyleProvider.BorderColorSelected = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.customTabControl3.DisplayStyleProvider.CloserColor = System.Drawing.Color.Blue;
            this.customTabControl3.DisplayStyleProvider.CloserColorActive = System.Drawing.Color.White;
            this.customTabControl3.DisplayStyleProvider.FocusColor = System.Drawing.Color.Empty;
            this.customTabControl3.DisplayStyleProvider.FocusTrack = false;
            this.customTabControl3.DisplayStyleProvider.HotTrack = true;
            this.customTabControl3.DisplayStyleProvider.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.customTabControl3.DisplayStyleProvider.Opacity = 1F;
            this.customTabControl3.DisplayStyleProvider.Overlap = 5;
            this.customTabControl3.DisplayStyleProvider.Padding = new System.Drawing.Point(6, 3);
            this.customTabControl3.DisplayStyleProvider.Radius = 10;
            this.customTabControl3.DisplayStyleProvider.SelectCloserColor = System.Drawing.Color.White;
            this.customTabControl3.DisplayStyleProvider.ShowTabCloser = true;
            this.customTabControl3.DisplayStyleProvider.TextColor = System.Drawing.SystemColors.ControlText;
            this.customTabControl3.DisplayStyleProvider.TextColorDisabled = System.Drawing.SystemColors.ControlDark;
            this.customTabControl3.DisplayStyleProvider.TextColorSelected = System.Drawing.Color.White;
            this.customTabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customTabControl3.HotTrack = true;
            this.customTabControl3.Location = new System.Drawing.Point(0, 0);
            this.customTabControl3.Name = "customTabControl3";
            this.customTabControl3.SelectedIndex = 0;
            this.customTabControl3.Size = new System.Drawing.Size(1172, 682);
            this.customTabControl3.TabIndex = 4;
            // 
            // tabPage11
            // 
            this.tabPage11.BackColor = System.Drawing.Color.White;
            this.tabPage11.ImageKey = "2.png";
            this.tabPage11.Location = new System.Drawing.Point(4, 23);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(1164, 655);
            this.tabPage11.TabIndex = 0;
            this.tabPage11.Text = "Allgemein";
            // 
            // tabPage12
            // 
            this.tabPage12.ImageKey = "(none)";
            this.tabPage12.Location = new System.Drawing.Point(4, 23);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage12.Size = new System.Drawing.Size(1164, 655);
            this.tabPage12.TabIndex = 1;
            this.tabPage12.Text = "tabPage12";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // tabPage13
            // 
            this.tabPage13.ImageKey = "brush3.png";
            this.tabPage13.Location = new System.Drawing.Point(4, 23);
            this.tabPage13.Name = "tabPage13";
            this.tabPage13.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage13.Size = new System.Drawing.Size(1164, 655);
            this.tabPage13.TabIndex = 2;
            this.tabPage13.Text = "tabPage13";
            this.tabPage13.UseVisualStyleBackColor = true;
            // 
            // tabPage14
            // 
            this.tabPage14.ImageKey = "calculator.png";
            this.tabPage14.Location = new System.Drawing.Point(4, 23);
            this.tabPage14.Name = "tabPage14";
            this.tabPage14.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage14.Size = new System.Drawing.Size(1164, 655);
            this.tabPage14.TabIndex = 3;
            this.tabPage14.Text = "tabPage14";
            this.tabPage14.UseVisualStyleBackColor = true;
            // 
            // tabPage15
            // 
            this.tabPage15.ImageKey = "cd_music.png";
            this.tabPage15.Location = new System.Drawing.Point(4, 23);
            this.tabPage15.Name = "tabPage15";
            this.tabPage15.Size = new System.Drawing.Size(1164, 655);
            this.tabPage15.TabIndex = 4;
            this.tabPage15.Text = "tabPage15";
            this.tabPage15.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 682);
            this.Controls.Add(this.customTabControl3);
            this.Name = "Form1";
            this.Text = "W";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.customTabControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CustomTabControl customTabControl3;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.TabPage tabPage12;
        private System.Windows.Forms.TabPage tabPage13;
        private System.Windows.Forms.TabPage tabPage14;
        private System.Windows.Forms.TabPage tabPage15;
    }
}