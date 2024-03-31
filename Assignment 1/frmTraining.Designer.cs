namespace Assignment_1
{
    partial class frmTraining
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
            this.btnEnroll = new System.Windows.Forms.Button();
            this.lblTrain = new System.Windows.Forms.Label();
            this.clbTraining = new System.Windows.Forms.CheckedListBox();
            this.lblTrainList = new System.Windows.Forms.Label();
            this.dgvTrainList = new System.Windows.Forms.DataGridView();
            this.trainingScheBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new Assignment_1.Database1DataSet1();
            this.trainingScheTableAdapter = new Assignment_1.Database1DataSet1TableAdapters.TrainingScheTableAdapter();
            this.btnUnenroll = new System.Windows.Forms.Button();
            this.panelControl = new System.Windows.Forms.Panel();
            this.btnSuggestion = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCompetition = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnTraning = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingScheBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnroll
            // 
            this.btnEnroll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnroll.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnEnroll.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEnroll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnroll.Location = new System.Drawing.Point(481, 373);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(117, 37);
            this.btnEnroll.TabIndex = 2;
            this.btnEnroll.Text = "Enroll";
            this.btnEnroll.UseVisualStyleBackColor = false;
            this.btnEnroll.Click += new System.EventHandler(this.btnEnroll_Click);
            // 
            // lblTrain
            // 
            this.lblTrain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTrain.AutoSize = true;
            this.lblTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrain.Location = new System.Drawing.Point(177, 67);
            this.lblTrain.Name = "lblTrain";
            this.lblTrain.Size = new System.Drawing.Size(437, 46);
            this.lblTrain.TabIndex = 3;
            this.lblTrain.Text = "To Enroll Any Training";
            // 
            // clbTraining
            // 
            this.clbTraining.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbTraining.CheckOnClick = true;
            this.clbTraining.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbTraining.FormattingEnabled = true;
            this.clbTraining.Items.AddRange(new object[] {
            ""});
            this.clbTraining.Location = new System.Drawing.Point(73, 357);
            this.clbTraining.Name = "clbTraining";
            this.clbTraining.Size = new System.Drawing.Size(386, 79);
            this.clbTraining.TabIndex = 8;
            this.clbTraining.SelectedIndexChanged += new System.EventHandler(this.clbTraining_SelectedIndexChanged);
            // 
            // lblTrainList
            // 
            this.lblTrainList.AutoSize = true;
            this.lblTrainList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainList.Location = new System.Drawing.Point(12, 132);
            this.lblTrainList.Name = "lblTrainList";
            this.lblTrainList.Size = new System.Drawing.Size(198, 32);
            this.lblTrainList.TabIndex = 15;
            this.lblTrainList.Text = "Training Lists";
            // 
            // dgvTrainList
            // 
            this.dgvTrainList.AllowUserToAddRows = false;
            this.dgvTrainList.AllowUserToDeleteRows = false;
            this.dgvTrainList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTrainList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrainList.Location = new System.Drawing.Point(73, 167);
            this.dgvTrainList.Name = "dgvTrainList";
            this.dgvTrainList.ReadOnly = true;
            this.dgvTrainList.RowHeadersWidth = 51;
            this.dgvTrainList.RowTemplate.Height = 24;
            this.dgvTrainList.Size = new System.Drawing.Size(680, 150);
            this.dgvTrainList.TabIndex = 18;
            // 
            // trainingScheBindingSource
            // 
            this.trainingScheBindingSource.DataMember = "TrainingSche";
            this.trainingScheBindingSource.DataSource = this.database1DataSet1BindingSource;
            // 
            // database1DataSet1BindingSource
            // 
            this.database1DataSet1BindingSource.DataSource = this.database1DataSet1;
            this.database1DataSet1BindingSource.Position = 0;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trainingScheTableAdapter
            // 
            this.trainingScheTableAdapter.ClearBeforeFill = true;
            // 
            // btnUnenroll
            // 
            this.btnUnenroll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnenroll.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnUnenroll.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnUnenroll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUnenroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnenroll.Location = new System.Drawing.Point(618, 373);
            this.btnUnenroll.Name = "btnUnenroll";
            this.btnUnenroll.Size = new System.Drawing.Size(117, 37);
            this.btnUnenroll.TabIndex = 19;
            this.btnUnenroll.Text = "UnEnroll";
            this.btnUnenroll.UseVisualStyleBackColor = false;
            this.btnUnenroll.Click += new System.EventHandler(this.btnUnenroll_Click);
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
            this.panelControl.TabIndex = 20;
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
            // frmTraining
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(765, 538);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.btnUnenroll);
            this.Controls.Add(this.dgvTrainList);
            this.Controls.Add(this.lblTrainList);
            this.Controls.Add(this.btnEnroll);
            this.Controls.Add(this.lblTrain);
            this.Controls.Add(this.clbTraining);
            this.Name = "frmTraining";
            this.Text = "frmTraining";
            this.Load += new System.EventHandler(this.frmTraining_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingScheBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEnroll;
        private System.Windows.Forms.Label lblTrain;
        private System.Windows.Forms.CheckedListBox clbTraining;
        private System.Windows.Forms.Label lblTrainList;
        private System.Windows.Forms.DataGridView dgvTrainList;
        private System.Windows.Forms.BindingSource database1DataSet1BindingSource;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource trainingScheBindingSource;
        private Database1DataSet1TableAdapters.TrainingScheTableAdapter trainingScheTableAdapter;
        private System.Windows.Forms.Button btnUnenroll;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Button btnSuggestion;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCompetition;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnTraning;
    }
}