﻿namespace CMS
{
    partial class frm_DsaAdd
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
            this.lbl_ExistingDataOwner = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gb_DataOwner = new System.Windows.Forms.GroupBox();
            this.btn_NewDataOwner = new System.Windows.Forms.Button();
            this.gb_DsaFileDetails = new System.Windows.Forms.GroupBox();
            this.tb_FilePath = new System.Windows.Forms.TextBox();
            this.lbl_FilePath = new System.Windows.Forms.Label();
            this.tb_FileName = new System.Windows.Forms.TextBox();
            this.lbl_FileName = new System.Windows.Forms.Label();
            this.dtp_StartDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_ExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_StartDate = new System.Windows.Forms.Label();
            this.lbl_ExpiryDate = new System.Windows.Forms.Label();
            this.gb_AmendmentOf = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_AmendmentHelp = new System.Windows.Forms.Label();
            this.gb_GovernanceReq = new System.Windows.Forms.GroupBox();
            this.chkb_DSPT = new System.Windows.Forms.CheckBox();
            this.chkb_ISO27001 = new System.Windows.Forms.CheckBox();
            this.gb_Notes = new System.Windows.Forms.GroupBox();
            this.tb_AddNote = new System.Windows.Forms.TextBox();
            this.btn_AddNote = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.gb_Project = new System.Windows.Forms.GroupBox();
            this.lbx_ProjectsList = new System.Windows.Forms.ListBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.gb_DataOwner.SuspendLayout();
            this.gb_DsaFileDetails.SuspendLayout();
            this.gb_AmendmentOf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb_GovernanceReq.SuspendLayout();
            this.gb_Notes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.gb_Project.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_ExistingDataOwner
            // 
            this.lbl_ExistingDataOwner.AutoSize = true;
            this.lbl_ExistingDataOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ExistingDataOwner.Location = new System.Drawing.Point(6, 37);
            this.lbl_ExistingDataOwner.Name = "lbl_ExistingDataOwner";
            this.lbl_ExistingDataOwner.Size = new System.Drawing.Size(68, 20);
            this.lbl_ExistingDataOwner.TabIndex = 0;
            this.lbl_ExistingDataOwner.Text = "Existing";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(80, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // gb_DataOwner
            // 
            this.gb_DataOwner.Controls.Add(this.btn_NewDataOwner);
            this.gb_DataOwner.Controls.Add(this.comboBox1);
            this.gb_DataOwner.Controls.Add(this.lbl_ExistingDataOwner);
            this.gb_DataOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_DataOwner.Location = new System.Drawing.Point(12, 12);
            this.gb_DataOwner.Name = "gb_DataOwner";
            this.gb_DataOwner.Size = new System.Drawing.Size(261, 114);
            this.gb_DataOwner.TabIndex = 2;
            this.gb_DataOwner.TabStop = false;
            this.gb_DataOwner.Text = "Data Owner";
            // 
            // btn_NewDataOwner
            // 
            this.btn_NewDataOwner.Location = new System.Drawing.Point(41, 68);
            this.btn_NewDataOwner.Name = "btn_NewDataOwner";
            this.btn_NewDataOwner.Size = new System.Drawing.Size(167, 37);
            this.btn_NewDataOwner.TabIndex = 2;
            this.btn_NewDataOwner.Text = "New Data Owner";
            this.btn_NewDataOwner.UseVisualStyleBackColor = true;
            // 
            // gb_DsaFileDetails
            // 
            this.gb_DsaFileDetails.Controls.Add(this.tb_FilePath);
            this.gb_DsaFileDetails.Controls.Add(this.lbl_FilePath);
            this.gb_DsaFileDetails.Controls.Add(this.tb_FileName);
            this.gb_DsaFileDetails.Controls.Add(this.lbl_FileName);
            this.gb_DsaFileDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_DsaFileDetails.Location = new System.Drawing.Point(302, 12);
            this.gb_DsaFileDetails.Name = "gb_DsaFileDetails";
            this.gb_DsaFileDetails.Size = new System.Drawing.Size(486, 114);
            this.gb_DsaFileDetails.TabIndex = 3;
            this.gb_DsaFileDetails.TabStop = false;
            this.gb_DsaFileDetails.Text = "File Details";
            // 
            // tb_FilePath
            // 
            this.tb_FilePath.Location = new System.Drawing.Point(109, 65);
            this.tb_FilePath.Name = "tb_FilePath";
            this.tb_FilePath.Size = new System.Drawing.Size(371, 27);
            this.tb_FilePath.TabIndex = 3;
            // 
            // lbl_FilePath
            // 
            this.lbl_FilePath.AutoSize = true;
            this.lbl_FilePath.Location = new System.Drawing.Point(17, 68);
            this.lbl_FilePath.Name = "lbl_FilePath";
            this.lbl_FilePath.Size = new System.Drawing.Size(75, 20);
            this.lbl_FilePath.TabIndex = 2;
            this.lbl_FilePath.Text = "File Path";
            // 
            // tb_FileName
            // 
            this.tb_FileName.Location = new System.Drawing.Point(109, 24);
            this.tb_FileName.Name = "tb_FileName";
            this.tb_FileName.Size = new System.Drawing.Size(371, 27);
            this.tb_FileName.TabIndex = 1;
            // 
            // lbl_FileName
            // 
            this.lbl_FileName.AutoSize = true;
            this.lbl_FileName.Location = new System.Drawing.Point(17, 27);
            this.lbl_FileName.Name = "lbl_FileName";
            this.lbl_FileName.Size = new System.Drawing.Size(85, 20);
            this.lbl_FileName.TabIndex = 0;
            this.lbl_FileName.Text = "File Name";
            // 
            // dtp_StartDate
            // 
            this.dtp_StartDate.Checked = false;
            this.dtp_StartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_StartDate.Location = new System.Drawing.Point(130, 135);
            this.dtp_StartDate.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtp_StartDate.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtp_StartDate.Name = "dtp_StartDate";
            this.dtp_StartDate.ShowCheckBox = true;
            this.dtp_StartDate.Size = new System.Drawing.Size(226, 27);
            this.dtp_StartDate.TabIndex = 4;
            // 
            // dtp_ExpiryDate
            // 
            this.dtp_ExpiryDate.Checked = false;
            this.dtp_ExpiryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ExpiryDate.Location = new System.Drawing.Point(529, 135);
            this.dtp_ExpiryDate.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtp_ExpiryDate.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtp_ExpiryDate.Name = "dtp_ExpiryDate";
            this.dtp_ExpiryDate.ShowCheckBox = true;
            this.dtp_ExpiryDate.Size = new System.Drawing.Size(226, 27);
            this.dtp_ExpiryDate.TabIndex = 5;
            // 
            // lbl_StartDate
            // 
            this.lbl_StartDate.AutoSize = true;
            this.lbl_StartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StartDate.Location = new System.Drawing.Point(38, 140);
            this.lbl_StartDate.Name = "lbl_StartDate";
            this.lbl_StartDate.Size = new System.Drawing.Size(86, 20);
            this.lbl_StartDate.TabIndex = 6;
            this.lbl_StartDate.Text = "Start Date";
            // 
            // lbl_ExpiryDate
            // 
            this.lbl_ExpiryDate.AutoSize = true;
            this.lbl_ExpiryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ExpiryDate.Location = new System.Drawing.Point(427, 140);
            this.lbl_ExpiryDate.Name = "lbl_ExpiryDate";
            this.lbl_ExpiryDate.Size = new System.Drawing.Size(96, 20);
            this.lbl_ExpiryDate.TabIndex = 7;
            this.lbl_ExpiryDate.Text = "Expiry Date";
            // 
            // gb_AmendmentOf
            // 
            this.gb_AmendmentOf.Controls.Add(this.lbl_AmendmentHelp);
            this.gb_AmendmentOf.Controls.Add(this.dataGridView1);
            this.gb_AmendmentOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_AmendmentOf.Location = new System.Drawing.Point(12, 167);
            this.gb_AmendmentOf.Name = "gb_AmendmentOf";
            this.gb_AmendmentOf.Size = new System.Drawing.Size(776, 164);
            this.gb_AmendmentOf.TabIndex = 8;
            this.gb_AmendmentOf.TabStop = false;
            this.gb_AmendmentOf.Text = "Amendment of Previous DSA";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(763, 120);
            this.dataGridView1.TabIndex = 0;
            // 
            // lbl_AmendmentHelp
            // 
            this.lbl_AmendmentHelp.AutoSize = true;
            this.lbl_AmendmentHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AmendmentHelp.Location = new System.Drawing.Point(7, 18);
            this.lbl_AmendmentHelp.Name = "lbl_AmendmentHelp";
            this.lbl_AmendmentHelp.Size = new System.Drawing.Size(551, 17);
            this.lbl_AmendmentHelp.TabIndex = 1;
            this.lbl_AmendmentHelp.Text = "If this DSA amends an original agreement, select the row below containing the ori" +
    "ginal:";
            // 
            // gb_GovernanceReq
            // 
            this.gb_GovernanceReq.Controls.Add(this.chkb_ISO27001);
            this.gb_GovernanceReq.Controls.Add(this.chkb_DSPT);
            this.gb_GovernanceReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_GovernanceReq.Location = new System.Drawing.Point(12, 334);
            this.gb_GovernanceReq.Name = "gb_GovernanceReq";
            this.gb_GovernanceReq.Size = new System.Drawing.Size(223, 82);
            this.gb_GovernanceReq.TabIndex = 9;
            this.gb_GovernanceReq.TabStop = false;
            this.gb_GovernanceReq.Text = "Governance Requirements";
            // 
            // chkb_DSPT
            // 
            this.chkb_DSPT.AutoSize = true;
            this.chkb_DSPT.Location = new System.Drawing.Point(30, 24);
            this.chkb_DSPT.Name = "chkb_DSPT";
            this.chkb_DSPT.Size = new System.Drawing.Size(76, 24);
            this.chkb_DSPT.TabIndex = 0;
            this.chkb_DSPT.Text = "DSPT";
            this.chkb_DSPT.UseVisualStyleBackColor = true;
            // 
            // chkb_ISO27001
            // 
            this.chkb_ISO27001.AutoSize = true;
            this.chkb_ISO27001.Location = new System.Drawing.Point(30, 49);
            this.chkb_ISO27001.Name = "chkb_ISO27001";
            this.chkb_ISO27001.Size = new System.Drawing.Size(104, 24);
            this.chkb_ISO27001.TabIndex = 1;
            this.chkb_ISO27001.Text = "ISO27001";
            this.chkb_ISO27001.UseVisualStyleBackColor = true;
            // 
            // gb_Notes
            // 
            this.gb_Notes.Controls.Add(this.dataGridView2);
            this.gb_Notes.Controls.Add(this.btn_AddNote);
            this.gb_Notes.Controls.Add(this.tb_AddNote);
            this.gb_Notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Notes.Location = new System.Drawing.Point(241, 334);
            this.gb_Notes.Name = "gb_Notes";
            this.gb_Notes.Size = new System.Drawing.Size(547, 221);
            this.gb_Notes.TabIndex = 10;
            this.gb_Notes.TabStop = false;
            this.gb_Notes.Text = "Notes";
            // 
            // tb_AddNote
            // 
            this.tb_AddNote.Location = new System.Drawing.Point(6, 26);
            this.tb_AddNote.Multiline = true;
            this.tb_AddNote.Name = "tb_AddNote";
            this.tb_AddNote.Size = new System.Drawing.Size(448, 76);
            this.tb_AddNote.TabIndex = 0;
            // 
            // btn_AddNote
            // 
            this.btn_AddNote.Location = new System.Drawing.Point(460, 26);
            this.btn_AddNote.Name = "btn_AddNote";
            this.btn_AddNote.Size = new System.Drawing.Size(79, 76);
            this.btn_AddNote.TabIndex = 1;
            this.btn_AddNote.Text = "Add Note";
            this.btn_AddNote.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(7, 108);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(534, 108);
            this.dataGridView2.TabIndex = 2;
            // 
            // gb_Project
            // 
            this.gb_Project.Controls.Add(this.lbx_ProjectsList);
            this.gb_Project.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Project.Location = new System.Drawing.Point(12, 419);
            this.gb_Project.Name = "gb_Project";
            this.gb_Project.Size = new System.Drawing.Size(223, 136);
            this.gb_Project.TabIndex = 11;
            this.gb_Project.TabStop = false;
            this.gb_Project.Text = "Link With Project";
            // 
            // lbx_ProjectsList
            // 
            this.lbx_ProjectsList.FormattingEnabled = true;
            this.lbx_ProjectsList.ItemHeight = 20;
            this.lbx_ProjectsList.Location = new System.Drawing.Point(10, 27);
            this.lbx_ProjectsList.Name = "lbx_ProjectsList";
            this.lbx_ProjectsList.Size = new System.Drawing.Size(207, 104);
            this.lbx_ProjectsList.TabIndex = 0;
            // 
            // btn_OK
            // 
            this.btn_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OK.Location = new System.Drawing.Point(685, 561);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(103, 34);
            this.btn_OK.TabIndex = 12;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(576, 561);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(103, 34);
            this.btn_Cancel.TabIndex = 13;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // frm_DsaAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 602);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.gb_Project);
            this.Controls.Add(this.gb_Notes);
            this.Controls.Add(this.gb_GovernanceReq);
            this.Controls.Add(this.gb_AmendmentOf);
            this.Controls.Add(this.lbl_ExpiryDate);
            this.Controls.Add(this.lbl_StartDate);
            this.Controls.Add(this.dtp_ExpiryDate);
            this.Controls.Add(this.dtp_StartDate);
            this.Controls.Add(this.gb_DsaFileDetails);
            this.Controls.Add(this.gb_DataOwner);
            this.Name = "frm_DsaAdd";
            this.Text = "Add a New DSA";
            this.gb_DataOwner.ResumeLayout(false);
            this.gb_DataOwner.PerformLayout();
            this.gb_DsaFileDetails.ResumeLayout(false);
            this.gb_DsaFileDetails.PerformLayout();
            this.gb_AmendmentOf.ResumeLayout(false);
            this.gb_AmendmentOf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb_GovernanceReq.ResumeLayout(false);
            this.gb_GovernanceReq.PerformLayout();
            this.gb_Notes.ResumeLayout(false);
            this.gb_Notes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.gb_Project.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ExistingDataOwner;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox gb_DataOwner;
        private System.Windows.Forms.Button btn_NewDataOwner;
        private System.Windows.Forms.GroupBox gb_DsaFileDetails;
        private System.Windows.Forms.TextBox tb_FilePath;
        private System.Windows.Forms.Label lbl_FilePath;
        private System.Windows.Forms.TextBox tb_FileName;
        private System.Windows.Forms.Label lbl_FileName;
        private System.Windows.Forms.DateTimePicker dtp_StartDate;
        private System.Windows.Forms.DateTimePicker dtp_ExpiryDate;
        private System.Windows.Forms.Label lbl_StartDate;
        private System.Windows.Forms.Label lbl_ExpiryDate;
        private System.Windows.Forms.GroupBox gb_AmendmentOf;
        private System.Windows.Forms.Label lbl_AmendmentHelp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gb_GovernanceReq;
        private System.Windows.Forms.CheckBox chkb_ISO27001;
        private System.Windows.Forms.CheckBox chkb_DSPT;
        private System.Windows.Forms.GroupBox gb_Notes;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_AddNote;
        private System.Windows.Forms.TextBox tb_AddNote;
        private System.Windows.Forms.GroupBox gb_Project;
        private System.Windows.Forms.ListBox lbx_ProjectsList;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
    }
}