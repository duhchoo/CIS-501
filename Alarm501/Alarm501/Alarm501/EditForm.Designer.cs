namespace Alarm501
{
    partial class EditForm
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
            this.uxEdit = new System.Windows.Forms.Button();
            this.uxCancel = new System.Windows.Forms.Button();
            this.uxOnBox = new System.Windows.Forms.CheckBox();
            this.uxDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // uxEdit
            // 
            this.uxEdit.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEdit.Location = new System.Drawing.Point(209, 98);
            this.uxEdit.Name = "uxEdit";
            this.uxEdit.Size = new System.Drawing.Size(101, 34);
            this.uxEdit.TabIndex = 7;
            this.uxEdit.Text = "Edit";
            this.uxEdit.UseVisualStyleBackColor = true;
            this.uxEdit.Click += new System.EventHandler(this.uxEdit_Click);
            // 
            // uxCancel
            // 
            this.uxCancel.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCancel.Location = new System.Drawing.Point(128, 109);
            this.uxCancel.Name = "uxCancel";
            this.uxCancel.Size = new System.Drawing.Size(75, 23);
            this.uxCancel.TabIndex = 6;
            this.uxCancel.Text = "Cancel";
            this.uxCancel.UseVisualStyleBackColor = true;
            this.uxCancel.Click += new System.EventHandler(this.uxCancel_Click);
            // 
            // uxOnBox
            // 
            this.uxOnBox.AutoSize = true;
            this.uxOnBox.BackColor = System.Drawing.Color.Transparent;
            this.uxOnBox.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxOnBox.Location = new System.Drawing.Point(255, 52);
            this.uxOnBox.Name = "uxOnBox";
            this.uxOnBox.Size = new System.Drawing.Size(42, 19);
            this.uxOnBox.TabIndex = 5;
            this.uxOnBox.Text = "On";
            this.uxOnBox.UseVisualStyleBackColor = false;
            // 
            // uxDateTimePicker
            // 
            this.uxDateTimePicker.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.uxDateTimePicker.Location = new System.Drawing.Point(30, 49);
            this.uxDateTimePicker.Name = "uxDateTimePicker";
            this.uxDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uxDateTimePicker.ShowUpDown = true;
            this.uxDateTimePicker.Size = new System.Drawing.Size(200, 24);
            this.uxDateTimePicker.TabIndex = 4;
            this.uxDateTimePicker.Value = new System.DateTime(2021, 2, 10, 0, 0, 0, 0);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 144);
            this.Controls.Add(this.uxEdit);
            this.Controls.Add(this.uxCancel);
            this.Controls.Add(this.uxOnBox);
            this.Controls.Add(this.uxDateTimePicker);
            this.Name = "EditForm";
            this.Text = "Edit Alarm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxEdit;
        private System.Windows.Forms.Button uxCancel;
        private System.Windows.Forms.CheckBox uxOnBox;
        private System.Windows.Forms.DateTimePicker uxDateTimePicker;
    }
}