namespace Alarm501
{
    partial class AddForm
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
            this.uxDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.uxOnBox = new System.Windows.Forms.CheckBox();
            this.uxCancel = new System.Windows.Forms.Button();
            this.uxSet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uxSnoozePicker = new System.Windows.Forms.NumericUpDown();
            this.uxSoundPicker = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.uxSnoozePicker)).BeginInit();
            this.SuspendLayout();
            // 
            // uxDateTimePicker
            // 
            this.uxDateTimePicker.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.uxDateTimePicker.Location = new System.Drawing.Point(28, 21);
            this.uxDateTimePicker.Name = "uxDateTimePicker";
            this.uxDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uxDateTimePicker.ShowUpDown = true;
            this.uxDateTimePicker.Size = new System.Drawing.Size(200, 24);
            this.uxDateTimePicker.TabIndex = 0;
            this.uxDateTimePicker.Value = new System.DateTime(2021, 2, 10, 0, 0, 0, 0);
            this.uxDateTimePicker.ValueChanged += new System.EventHandler(this.uxDateTimePicker_ValueChanged);
            // 
            // uxOnBox
            // 
            this.uxOnBox.AutoSize = true;
            this.uxOnBox.BackColor = System.Drawing.Color.Transparent;
            this.uxOnBox.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxOnBox.Location = new System.Drawing.Point(253, 24);
            this.uxOnBox.Name = "uxOnBox";
            this.uxOnBox.Size = new System.Drawing.Size(42, 19);
            this.uxOnBox.TabIndex = 1;
            this.uxOnBox.Text = "On";
            this.uxOnBox.UseVisualStyleBackColor = false;
            // 
            // uxCancel
            // 
            this.uxCancel.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCancel.Location = new System.Drawing.Point(124, 130);
            this.uxCancel.Name = "uxCancel";
            this.uxCancel.Size = new System.Drawing.Size(75, 23);
            this.uxCancel.TabIndex = 2;
            this.uxCancel.Text = "Cancel";
            this.uxCancel.UseVisualStyleBackColor = true;
            this.uxCancel.Click += new System.EventHandler(this.uxCancel_Click);
            // 
            // uxSet
            // 
            this.uxSet.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSet.Location = new System.Drawing.Point(205, 119);
            this.uxSet.Name = "uxSet";
            this.uxSet.Size = new System.Drawing.Size(101, 34);
            this.uxSet.TabIndex = 3;
            this.uxSet.Text = "Set";
            this.uxSet.UseVisualStyleBackColor = true;
            this.uxSet.Click += new System.EventHandler(this.uxSet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "Snooze Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "Alarm Sound";
            // 
            // uxSnoozePicker
            // 
            this.uxSnoozePicker.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSnoozePicker.Location = new System.Drawing.Point(188, 81);
            this.uxSnoozePicker.Name = "uxSnoozePicker";
            this.uxSnoozePicker.Size = new System.Drawing.Size(118, 19);
            this.uxSnoozePicker.TabIndex = 15;
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
            this.uxSoundPicker.TabIndex = 14;
            this.uxSoundPicker.Text = "- Choose -";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 165);
            this.Controls.Add(this.uxSnoozePicker);
            this.Controls.Add(this.uxSoundPicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxSet);
            this.Controls.Add(this.uxCancel);
            this.Controls.Add(this.uxOnBox);
            this.Controls.Add(this.uxDateTimePicker);
            this.Name = "AddForm";
            this.Text = "Add Alarm";
            ((System.ComponentModel.ISupportInitialize)(this.uxSnoozePicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker uxDateTimePicker;
        private System.Windows.Forms.CheckBox uxOnBox;
        private System.Windows.Forms.Button uxCancel;
        private System.Windows.Forms.Button uxSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown uxSnoozePicker;
        private System.Windows.Forms.ComboBox uxSoundPicker;
    }
}