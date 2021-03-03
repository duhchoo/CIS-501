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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uxSoundPicker = new System.Windows.Forms.ComboBox();
            this.uxSnoozePicker = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.uxSnoozePicker)).BeginInit();
            this.SuspendLayout();
            // 
            // uxEdit
            // 
            this.uxEdit.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEdit.Location = new System.Drawing.Point(207, 118);
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
            this.uxCancel.Location = new System.Drawing.Point(126, 129);
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
            this.uxOnBox.Location = new System.Drawing.Point(250, 12);
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
            this.uxDateTimePicker.Location = new System.Drawing.Point(25, 9);
            this.uxDateTimePicker.Name = "uxDateTimePicker";
            this.uxDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uxDateTimePicker.ShowUpDown = true;
            this.uxDateTimePicker.Size = new System.Drawing.Size(200, 24);
            this.uxDateTimePicker.TabIndex = 4;
            this.uxDateTimePicker.Value = new System.DateTime(2021, 2, 10, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "Snooze Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "Alarm Sound";
            // 
            // uxSoundPicker
            // 
            this.uxSoundPicker.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSoundPicker.FormattingEnabled = true;
            this.uxSoundPicker.Items.AddRange(new object[] {
            "Radar",
            "Beacon",
            "Chimes",
            "Circuit",
            "Reflection"});
            this.uxSoundPicker.Location = new System.Drawing.Point(12, 80);
            this.uxSoundPicker.Name = "uxSoundPicker";
            this.uxSoundPicker.Size = new System.Drawing.Size(121, 20);
            this.uxSoundPicker.TabIndex = 9;
            this.uxSoundPicker.Text = "- Choose -";
            // 
            // uxSnoozePicker
            // 
            this.uxSnoozePicker.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSnoozePicker.Location = new System.Drawing.Point(190, 81);
            this.uxSnoozePicker.Name = "uxSnoozePicker";
            this.uxSnoozePicker.Size = new System.Drawing.Size(118, 19);
            this.uxSnoozePicker.TabIndex = 12;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 164);
            this.Controls.Add(this.uxSnoozePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxSoundPicker);
            this.Controls.Add(this.uxEdit);
            this.Controls.Add(this.uxCancel);
            this.Controls.Add(this.uxOnBox);
            this.Controls.Add(this.uxDateTimePicker);
            this.Name = "EditForm";
            this.Text = "Edit Alarm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uxSnoozePicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxEdit;
        private System.Windows.Forms.Button uxCancel;
        private System.Windows.Forms.CheckBox uxOnBox;
        private System.Windows.Forms.DateTimePicker uxDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox uxSoundPicker;
        private System.Windows.Forms.NumericUpDown uxSnoozePicker;
    }
}