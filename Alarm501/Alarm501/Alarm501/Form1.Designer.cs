namespace Alarm501
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.uxEdit = new System.Windows.Forms.Button();
            this.uxAdd = new System.Windows.Forms.Button();
            this.uxSnooze = new System.Windows.Forms.Button();
            this.uxStop = new System.Windows.Forms.Button();
            this.uxAlarmStatus = new System.Windows.Forms.TextBox();
            this.uxAlarmList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // uxEdit
            // 
            this.uxEdit.Enabled = false;
            this.uxEdit.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEdit.Location = new System.Drawing.Point(12, 11);
            this.uxEdit.Name = "uxEdit";
            this.uxEdit.Size = new System.Drawing.Size(113, 43);
            this.uxEdit.TabIndex = 0;
            this.uxEdit.Text = "Edit";
            this.uxEdit.UseVisualStyleBackColor = true;
            this.uxEdit.Click += new System.EventHandler(this.uxEdit_Click);
            // 
            // uxAdd
            // 
            this.uxAdd.Font = new System.Drawing.Font("Garamond", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAdd.Location = new System.Drawing.Point(136, 11);
            this.uxAdd.Name = "uxAdd";
            this.uxAdd.Size = new System.Drawing.Size(113, 43);
            this.uxAdd.TabIndex = 1;
            this.uxAdd.Text = "+";
            this.uxAdd.UseVisualStyleBackColor = true;
            this.uxAdd.Click += new System.EventHandler(this.uxAdd_Click);
            // 
            // uxSnooze
            // 
            this.uxSnooze.Enabled = false;
            this.uxSnooze.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSnooze.Location = new System.Drawing.Point(12, 322);
            this.uxSnooze.Name = "uxSnooze";
            this.uxSnooze.Size = new System.Drawing.Size(113, 43);
            this.uxSnooze.TabIndex = 2;
            this.uxSnooze.Text = "Snooze";
            this.uxSnooze.UseVisualStyleBackColor = true;
            this.uxSnooze.Click += new System.EventHandler(this.uxSnooze_Click);
            // 
            // uxStop
            // 
            this.uxStop.Enabled = false;
            this.uxStop.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStop.Location = new System.Drawing.Point(136, 322);
            this.uxStop.Name = "uxStop";
            this.uxStop.Size = new System.Drawing.Size(113, 43);
            this.uxStop.TabIndex = 3;
            this.uxStop.Text = "Stop";
            this.uxStop.UseVisualStyleBackColor = true;
            this.uxStop.Click += new System.EventHandler(this.uxStop_Click);
            // 
            // uxAlarmStatus
            // 
            this.uxAlarmStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uxAlarmStatus.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAlarmStatus.Location = new System.Drawing.Point(12, 284);
            this.uxAlarmStatus.Name = "uxAlarmStatus";
            this.uxAlarmStatus.ReadOnly = true;
            this.uxAlarmStatus.Size = new System.Drawing.Size(237, 20);
            this.uxAlarmStatus.TabIndex = 5;
            this.uxAlarmStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uxAlarmList
            // 
            this.uxAlarmList.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAlarmList.FormattingEnabled = true;
            this.uxAlarmList.ItemHeight = 20;
            this.uxAlarmList.Location = new System.Drawing.Point(12, 60);
            this.uxAlarmList.Name = "uxAlarmList";
            this.uxAlarmList.Size = new System.Drawing.Size(237, 204);
            this.uxAlarmList.TabIndex = 6;
            this.uxAlarmList.SelectedIndexChanged += new System.EventHandler(this.uxAlarmList_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(261, 377);
            this.Controls.Add(this.uxAlarmList);
            this.Controls.Add(this.uxAlarmStatus);
            this.Controls.Add(this.uxStop);
            this.Controls.Add(this.uxSnooze);
            this.Controls.Add(this.uxAdd);
            this.Controls.Add(this.uxEdit);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Alarm501";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxEdit;
        private System.Windows.Forms.Button uxAdd;
        private System.Windows.Forms.Button uxSnooze;
        private System.Windows.Forms.Button uxStop;
        private System.Windows.Forms.TextBox uxAlarmStatus;
        private System.Windows.Forms.ListBox uxAlarmList;
    }
}

