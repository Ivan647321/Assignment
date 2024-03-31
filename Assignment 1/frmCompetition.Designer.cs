namespace Assignment_1
{
    partial class frmCompetition
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCompetition = new System.Windows.Forms.DataGridView();
            this.competitionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet4 = new Assignment_1.Database1DataSet4();
            this.lblCompetition = new System.Windows.Forms.Label();
            this.panelControl = new System.Windows.Forms.Panel();
            this.btnSuggestion = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCompetition = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnTraning = new System.Windows.Forms.Button();
            this.database1DataSet1 = new Assignment_1.Database1DataSet();
            this.competitionTableAdapter = new Assignment_1.Database1DataSet4TableAdapters.CompetitionTableAdapter();
            this.lblWin = new System.Windows.Forms.Label();
            this.lblShowWin = new System.Windows.Forms.Label();
            this.lblLose = new System.Windows.Forms.Label();
            this.lblShowLose = new System.Windows.Forms.Label();
            this.competitionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet4)).BeginInit();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCompetition
            // 
            this.dgvCompetition.AllowUserToAddRows = false;
            this.dgvCompetition.AllowUserToDeleteRows = false;
            this.dgvCompetition.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompetition.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCompetition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompetition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.competitionNameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn});
            this.dgvCompetition.DataSource = this.competitionBindingSource;
            this.dgvCompetition.Location = new System.Drawing.Point(80, 136);
            this.dgvCompetition.Name = "dgvCompetition";
            this.dgvCompetition.ReadOnly = true;
            this.dgvCompetition.RowHeadersWidth = 51;
            this.dgvCompetition.RowTemplate.Height = 24;
            this.dgvCompetition.Size = new System.Drawing.Size(608, 264);
            this.dgvCompetition.TabIndex = 13;
            // 
            // competitionBindingSource
            // 
            this.competitionBindingSource.DataMember = "Competition";
            this.competitionBindingSource.DataSource = this.database1DataSet4;
            // 
            // database1DataSet4
            // 
            this.database1DataSet4.DataSetName = "Database1DataSet4";
            this.database1DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblCompetition
            // 
            this.lblCompetition.AutoSize = true;
            this.lblCompetition.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetition.Location = new System.Drawing.Point(287, 78);
            this.lblCompetition.Name = "lblCompetition";
            this.lblCompetition.Size = new System.Drawing.Size(201, 38);
            this.lblCompetition.TabIndex = 14;
            this.lblCompetition.Text = "Competition";
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
            this.panelControl.TabIndex = 15;
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
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // competitionTableAdapter
            // 
            this.competitionTableAdapter.ClearBeforeFill = true;
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.Location = new System.Drawing.Point(112, 451);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(112, 25);
            this.lblWin.TabIndex = 16;
            this.lblWin.Text = "Total Win:";
            // 
            // lblShowWin
            // 
            this.lblShowWin.AutoSize = true;
            this.lblShowWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowWin.Location = new System.Drawing.Point(230, 451);
            this.lblShowWin.Name = "lblShowWin";
            this.lblShowWin.Size = new System.Drawing.Size(64, 25);
            this.lblShowWin.TabIndex = 17;
            this.lblShowWin.Text = "label2";
            this.lblShowWin.Click += new System.EventHandler(this.lblShowWin_Click);
            // 
            // lblLose
            // 
            this.lblLose.AutoSize = true;
            this.lblLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLose.Location = new System.Drawing.Point(436, 451);
            this.lblLose.Name = "lblLose";
            this.lblLose.Size = new System.Drawing.Size(121, 25);
            this.lblLose.TabIndex = 18;
            this.lblLose.Text = "Total Lose:";
            // 
            // lblShowLose
            // 
            this.lblShowLose.AutoSize = true;
            this.lblShowLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowLose.Location = new System.Drawing.Point(563, 451);
            this.lblShowLose.Name = "lblShowLose";
            this.lblShowLose.Size = new System.Drawing.Size(64, 25);
            this.lblShowLose.TabIndex = 19;
            this.lblShowLose.Text = "label4";
            // 
            // competitionNameDataGridViewTextBoxColumn
            // 
            this.competitionNameDataGridViewTextBoxColumn.DataPropertyName = "competitionName";
            this.competitionNameDataGridViewTextBoxColumn.HeaderText = "Competition Name";
            this.competitionNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.competitionNameDataGridViewTextBoxColumn.Name = "competitionNameDataGridViewTextBoxColumn";
            this.competitionNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.competitionNameDataGridViewTextBoxColumn.Width = 180;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            this.timeDataGridViewTextBoxColumn.Width = 125;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            this.locationDataGridViewTextBoxColumn.Width = 125;
            // 
            // frmCompetition
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(765, 538);
            this.Controls.Add(this.lblShowLose);
            this.Controls.Add(this.lblLose);
            this.Controls.Add(this.lblShowWin);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.lblCompetition);
            this.Controls.Add(this.dgvCompetition);
            this.Name = "frmCompetition";
            this.Text = "frmCompetition";
            this.Load += new System.EventHandler(this.frmCompetition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet4)).EndInit();
            this.panelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCompetition;
        private System.Windows.Forms.Label lblCompetition;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Button btnSuggestion;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCompetition;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnTraning;
        private Database1DataSet database1DataSet1;
        private Database1DataSet4 database1DataSet4;
        private System.Windows.Forms.BindingSource competitionBindingSource;
        private Database1DataSet4TableAdapters.CompetitionTableAdapter competitionTableAdapter;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Label lblShowWin;
        private System.Windows.Forms.Label lblLose;
        private System.Windows.Forms.Label lblShowLose;
        private System.Windows.Forms.DataGridViewTextBoxColumn competitionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
    }
}