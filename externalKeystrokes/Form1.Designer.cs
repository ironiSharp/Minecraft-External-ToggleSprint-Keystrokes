
namespace externalKeystrokes
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
            this.components = new System.ComponentModel.Container();
            this.btnW = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.LMButton = new System.Windows.Forms.Button();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.RMButton = new System.Windows.Forms.Button();
            this.sprintTimer = new System.Windows.Forms.Timer(this.components);
            this.toggleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnW
            // 
            this.btnW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnW.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnW.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.btnW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnW.Location = new System.Drawing.Point(95, 431);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(75, 71);
            this.btnW.TabIndex = 0;
            this.btnW.Text = "W";
            this.btnW.UseVisualStyleBackColor = false;
            // 
            // btnS
            // 
            this.btnS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnS.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnS.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.btnS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnS.Location = new System.Drawing.Point(95, 508);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(75, 72);
            this.btnS.TabIndex = 1;
            this.btnS.Text = "S";
            this.btnS.UseVisualStyleBackColor = false;
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnD.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.btnD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnD.Location = new System.Drawing.Point(176, 508);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(75, 72);
            this.btnD.TabIndex = 2;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = false;
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnA.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.btnA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnA.Location = new System.Drawing.Point(14, 508);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(75, 72);
            this.btnA.TabIndex = 3;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = false;
            // 
            // LMButton
            // 
            this.LMButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LMButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LMButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LMButton.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.LMButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.LMButton.Location = new System.Drawing.Point(14, 586);
            this.LMButton.Name = "LMButton";
            this.LMButton.Size = new System.Drawing.Size(116, 72);
            this.LMButton.TabIndex = 4;
            this.LMButton.Text = "LMB";
            this.LMButton.UseVisualStyleBackColor = false;
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 10;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // RMButton
            // 
            this.RMButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.RMButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.RMButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RMButton.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.RMButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.RMButton.Location = new System.Drawing.Point(135, 586);
            this.RMButton.Name = "RMButton";
            this.RMButton.Size = new System.Drawing.Size(116, 72);
            this.RMButton.TabIndex = 5;
            this.RMButton.Text = "RMB";
            this.RMButton.UseVisualStyleBackColor = false;
            // 
            // sprintTimer
            // 
            this.sprintTimer.Interval = 20;
            this.sprintTimer.Tick += new System.EventHandler(this.sprintTimer_Tick);
            // 
            // toggleLabel
            // 
            this.toggleLabel.AutoSize = true;
            this.toggleLabel.Font = new System.Drawing.Font("Segoe UI Light", 24F);
            this.toggleLabel.ForeColor = System.Drawing.Color.White;
            this.toggleLabel.Location = new System.Drawing.Point(12, 33);
            this.toggleLabel.Name = "toggleLabel";
            this.toggleLabel.Size = new System.Drawing.Size(312, 45);
            this.toggleLabel.TabIndex = 6;
            this.toggleLabel.Text = "[(Toggle Sprint: False)]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 676);
            this.Controls.Add(this.toggleLabel);
            this.Controls.Add(this.RMButton);
            this.Controls.Add(this.LMButton);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnW);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Keystrokes/Toggle Sprint";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnW;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button LMButton;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Button RMButton;
        private System.Windows.Forms.Timer sprintTimer;
        private System.Windows.Forms.Label toggleLabel;
    }
}

