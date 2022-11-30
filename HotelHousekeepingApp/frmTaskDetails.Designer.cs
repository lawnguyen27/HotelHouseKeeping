namespace HotelHousekeepingApp
{
    partial class frmTaskDetails
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
            this.lbTaskIDTag = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbTaskID = new System.Windows.Forms.Label();
            this.cboTaskStatus = new System.Windows.Forms.ComboBox();
            this.dtpDateCreate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbTaskIDTag
            // 
            this.lbTaskIDTag.AutoSize = true;
            this.lbTaskIDTag.Location = new System.Drawing.Point(87, 49);
            this.lbTaskIDTag.Name = "lbTaskIDTag";
            this.lbTaskIDTag.Size = new System.Drawing.Size(51, 20);
            this.lbTaskIDTag.TabIndex = 0;
            this.lbTaskIDTag.Text = "TaskID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "MemberID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "RoomNumber";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "MemberName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "DateCreate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "TaskStatus";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(183, 104);
            this.txtMemberID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(172, 27);
            this.txtMemberID.TabIndex = 1;
            this.txtMemberID.TextChanged += new System.EventHandler(this.txtMemberID_TextChanged);
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Location = new System.Drawing.Point(183, 163);
            this.txtRoomNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(172, 27);
            this.txtRoomNumber.TabIndex = 1;
            this.txtRoomNumber.TextChanged += new System.EventHandler(this.txtRoomID_TextChanged);
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(183, 220);
            this.txtMemberName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(172, 27);
            this.txtMemberName.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSave.Location = new System.Drawing.Point(120, 419);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 31);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCancel.Location = new System.Drawing.Point(270, 419);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 31);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbTaskID
            // 
            this.lbTaskID.AutoSize = true;
            this.lbTaskID.Location = new System.Drawing.Point(183, 49);
            this.lbTaskID.Name = "lbTaskID";
            this.lbTaskID.Size = new System.Drawing.Size(0, 20);
            this.lbTaskID.TabIndex = 3;
            // 
            // cboTaskStatus
            // 
            this.cboTaskStatus.FormattingEnabled = true;
            this.cboTaskStatus.Items.AddRange(new object[] {
            "Processing",
            "Done"});
            this.cboTaskStatus.Location = new System.Drawing.Point(183, 332);
            this.cboTaskStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboTaskStatus.Name = "cboTaskStatus";
            this.cboTaskStatus.Size = new System.Drawing.Size(172, 28);
            this.cboTaskStatus.TabIndex = 4;
            // 
            // dtpDateCreate
            // 
            this.dtpDateCreate.CustomFormat = "dd/MM/yyyy";
            this.dtpDateCreate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateCreate.Location = new System.Drawing.Point(183, 279);
            this.dtpDateCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDateCreate.Name = "dtpDateCreate";
            this.dtpDateCreate.Size = new System.Drawing.Size(172, 27);
            this.dtpDateCreate.TabIndex = 5;
            this.dtpDateCreate.Value = new System.DateTime(2022, 11, 5, 0, 0, 0, 0);
            // 
            // frmTaskDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 620);
            this.Controls.Add(this.dtpDateCreate);
            this.Controls.Add(this.cboTaskStatus);
            this.Controls.Add(this.lbTaskID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtRoomNumber);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTaskIDTag);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTaskDetails";
            this.Text = "frmTaskDetails";
            this.Load += new System.EventHandler(this.frmTaskDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbTaskIDTag;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtMemberID;
        private TextBox txtRoomNumber;
        private TextBox txtMemberName;
        private Button btnSave;
        private Button btnCancel;
        private Label lbTaskID;
        private ComboBox cboTaskStatus;
        private DateTimePicker dtpDateCreate;
    }
}