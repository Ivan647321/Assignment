namespace Assignment_1
{
    partial class frmSuggestion
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
            this.lblSuggestion = new System.Windows.Forms.Label();
            this.txtSuggestion = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.panelControl = new System.Windows.Forms.Panel();
            this.btnSuggestion = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCompetition = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnTraning = new System.Windows.Forms.Button();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSuggestion
            // 
            this.lblSuggestion.AutoSize = true;
            this.lblSuggestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuggestion.Location = new System.Drawing.Point(15, 81);
            this.lblSuggestion.Name = "lblSuggestion";
            this.lblSuggestion.Size = new System.Drawing.Size(351, 46);
            this.lblSuggestion.TabIndex = 13;
            this.lblSuggestion.Text = "Send Suggestion:";
            // 
            // txtSuggestion
            // 
            this.txtSuggestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuggestion.Location = new System.Drawing.Point(57, 140);
            this.txtSuggestion.Multiline = true;
            this.txtSuggestion.Name = "txtSuggestion";
            this.txtSuggestion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSuggestion.Size = new System.Drawing.Size(664, 260);
            this.txtSuggestion.TabIndex = 14;
            this.txtSuggestion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSuggestion_KeyDown);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(321, 428);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(125, 47);
            this.btnSend.TabIndex = 15;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelControl.Controls.Add(this.btnSuggestion);
            this.panelControl.Controls.Add(this.btnLogout);
            this.panelControl.Controls.Add(this.btnCompetition);
            this.panelControl.Controls.Add(this.btnPayment);
            this.panelControl.Controls.Add(this.btnProfile);
            this.panelControl.Controls.Add(this.btnTraning);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(765, 64);
            this.panelControl.TabIndex = 16;
            // 
            // btnSuggestion
            // 
            this.btnSuggestion.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnSuggestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuggestion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSuggestion.Location = new System.Drawing.Point(388, 12);
            this.btnSuggestion.Name = "btnSuggestion";
            this.btnSuggestion.Size = new System.Drawing.Size(124, 40);
            this.btnSuggestion.TabIndex = 10;
            this.btnSuggestion.Text = "Sugesstion";
            this.btnSuggestion.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Location = new System.Drawing.Point(656, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(97, 40);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnCompetition
            // 
            this.btnCompetition.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCompetition.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnCompetition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompetition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompetition.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCompetition.Location = new System.Drawing.Point(254, 12);
            this.btnCompetition.Name = "btnCompetition";
            this.btnCompetition.Size = new System.Drawing.Size(122, 40);
            this.btnCompetition.TabIndex = 8;
            this.btnCompetition.Text = "Competiton";
            this.btnCompetition.UseVisualStyleBackColor = false;
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPayment.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPayment.Location = new System.Drawing.Point(120, 16);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPayment.Size = new System.Drawing.Size(110, 33);
            this.btnPayment.TabIndex = 7;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnProfile.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProfile.Location = new System.Drawing.Point(522, 12);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(117, 40);
            this.btnProfile.TabIndex = 6;
            this.btnProfile.Text = "Edit Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            // 
            // btnTraning
            // 
            this.btnTraning.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnTraning.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnTraning.FlatAppearance.BorderSize = 0;
            this.btnTraning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraning.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTraning.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTraning.Location = new System.Drawing.Point(12, 12);
            this.btnTraning.Name = "btnTraning";
            this.btnTraning.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTraning.Size = new System.Drawing.Size(95, 40);
            this.btnTraning.TabIndex = 1;
            this.btnTraning.Text = "Training";
            this.btnTraning.UseVisualStyleBackColor = false;
            // 
            // frmSuggestion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(765, 538);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSuggestion);
            this.Controls.Add(this.lblSuggestion);
            this.Name = "frmSuggestion";
            this.Text = "label";
            this.panelControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSuggestion;
        private System.Windows.Forms.TextBox txtSuggestion;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Button btnSuggestion;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCompetition;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnTraning;
    }
}