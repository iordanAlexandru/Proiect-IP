namespace Proiect_Ip
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
            this.lightsButton = new System.Windows.Forms.Button();
            this.tvButton = new System.Windows.Forms.Button();
            this.garageButton = new System.Windows.Forms.Button();
            this.speakersButton = new System.Windows.Forms.Button();
            this.gatesButton = new System.Windows.Forms.Button();
            this.windowsButton = new System.Windows.Forms.Button();
            this.logsArea = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.onOffButton = new System.Windows.Forms.CheckBox();
            this.exc_but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lightsButton
            // 
            this.lightsButton.Enabled = false;
            this.lightsButton.Location = new System.Drawing.Point(12, 73);
            this.lightsButton.Name = "lightsButton";
            this.lightsButton.Size = new System.Drawing.Size(107, 49);
            this.lightsButton.TabIndex = 0;
            this.lightsButton.Text = "Lights";
            this.lightsButton.UseVisualStyleBackColor = true;
            this.lightsButton.Click += new System.EventHandler(this.lightsButton_click);
            // 
            // tvButton
            // 
            this.tvButton.Enabled = false;
            this.tvButton.Location = new System.Drawing.Point(136, 73);
            this.tvButton.Name = "tvButton";
            this.tvButton.Size = new System.Drawing.Size(110, 49);
            this.tvButton.TabIndex = 1;
            this.tvButton.Text = "TV";
            this.tvButton.UseVisualStyleBackColor = true;
            this.tvButton.Click += new System.EventHandler(this.tvButton_Click);
            // 
            // garageButton
            // 
            this.garageButton.Enabled = false;
            this.garageButton.Location = new System.Drawing.Point(136, 132);
            this.garageButton.Name = "garageButton";
            this.garageButton.Size = new System.Drawing.Size(110, 54);
            this.garageButton.TabIndex = 2;
            this.garageButton.Text = "Garage";
            this.garageButton.UseVisualStyleBackColor = true;
            this.garageButton.Click += new System.EventHandler(this.garageButton_Click);
            // 
            // speakersButton
            // 
            this.speakersButton.Enabled = false;
            this.speakersButton.Location = new System.Drawing.Point(12, 132);
            this.speakersButton.Name = "speakersButton";
            this.speakersButton.Size = new System.Drawing.Size(107, 54);
            this.speakersButton.TabIndex = 3;
            this.speakersButton.Text = "Speakers";
            this.speakersButton.UseVisualStyleBackColor = true;
            this.speakersButton.Click += new System.EventHandler(this.speakersButton_Click);
            // 
            // gatesButton
            // 
            this.gatesButton.Enabled = false;
            this.gatesButton.Location = new System.Drawing.Point(136, 196);
            this.gatesButton.Name = "gatesButton";
            this.gatesButton.Size = new System.Drawing.Size(110, 49);
            this.gatesButton.TabIndex = 4;
            this.gatesButton.Text = "Gates";
            this.gatesButton.UseVisualStyleBackColor = true;
            this.gatesButton.Click += new System.EventHandler(this.gatesButton_Click);
            // 
            // windowsButton
            // 
            this.windowsButton.Enabled = false;
            this.windowsButton.Location = new System.Drawing.Point(12, 196);
            this.windowsButton.Name = "windowsButton";
            this.windowsButton.Size = new System.Drawing.Size(107, 49);
            this.windowsButton.TabIndex = 5;
            this.windowsButton.Text = "Windows";
            this.windowsButton.UseVisualStyleBackColor = true;
            this.windowsButton.Click += new System.EventHandler(this.windowsButton_Click);
            // 
            // logsArea
            // 
            this.logsArea.Location = new System.Drawing.Point(4, 349);
            this.logsArea.Multiline = true;
            this.logsArea.Name = "logsArea";
            this.logsArea.Size = new System.Drawing.Size(242, 230);
            this.logsArea.TabIndex = 6;
            this.logsArea.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Logs";
            // 
            // clearButton
            // 
            this.clearButton.Enabled = false;
            this.clearButton.Location = new System.Drawing.Point(24, 284);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 46);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // onOffButton
            // 
            this.onOffButton.AutoSize = true;
            this.onOffButton.Location = new System.Drawing.Point(172, 23);
            this.onOffButton.Name = "onOffButton";
            this.onOffButton.Size = new System.Drawing.Size(59, 17);
            this.onOffButton.TabIndex = 12;
            this.onOffButton.Text = "On/Off";
            this.onOffButton.UseVisualStyleBackColor = true;
            this.onOffButton.CheckedChanged += new System.EventHandler(this.onOffButton_CheckedChanged);
            // 
            // exc_but
            // 
            this.exc_but.Enabled = false;
            this.exc_but.Location = new System.Drawing.Point(156, 284);
            this.exc_but.Name = "exc_but";
            this.exc_but.Size = new System.Drawing.Size(75, 46);
            this.exc_but.TabIndex = 13;
            this.exc_but.Text = "Exc Gen";
            this.exc_but.UseVisualStyleBackColor = true;
            this.exc_but.Click += new System.EventHandler(this.button_exc);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 591);
            this.Controls.Add(this.exc_but);
            this.Controls.Add(this.onOffButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logsArea);
            this.Controls.Add(this.windowsButton);
            this.Controls.Add(this.gatesButton);
            this.Controls.Add(this.speakersButton);
            this.Controls.Add(this.garageButton);
            this.Controls.Add(this.tvButton);
            this.Controls.Add(this.lightsButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lightsButton;
        private System.Windows.Forms.Button tvButton;
        private System.Windows.Forms.Button garageButton;
        private System.Windows.Forms.Button speakersButton;
        private System.Windows.Forms.Button gatesButton;
        private System.Windows.Forms.Button windowsButton;
        private System.Windows.Forms.TextBox logsArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.CheckBox onOffButton;
        private System.Windows.Forms.Button exc_but;
    }
}

