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
            this.SuspendLayout();
            // 
            // uxDateTimePicker
            // 
            this.uxDateTimePicker.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.uxDateTimePicker.Location = new System.Drawing.Point(26, 48);
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
            this.uxOnBox.Location = new System.Drawing.Point(251, 51);
            this.uxOnBox.Name = "uxOnBox";
            this.uxOnBox.Size = new System.Drawing.Size(42, 19);
            this.uxOnBox.TabIndex = 1;
            this.uxOnBox.Text = "On";
            this.uxOnBox.UseVisualStyleBackColor = false;
            this.uxOnBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // uxCancel
            // 
            this.uxCancel.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCancel.Location = new System.Drawing.Point(124, 108);
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
            this.uxSet.Location = new System.Drawing.Point(205, 97);
            this.uxSet.Name = "uxSet";
            this.uxSet.Size = new System.Drawing.Size(101, 34);
            this.uxSet.TabIndex = 3;
            this.uxSet.Text = "Set";
            this.uxSet.UseVisualStyleBackColor = true;
            this.uxSet.Click += new System.EventHandler(this.uxSet_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 143);
            this.Controls.Add(this.uxSet);
            this.Controls.Add(this.uxCancel);
            this.Controls.Add(this.uxOnBox);
            this.Controls.Add(this.uxDateTimePicker);
            this.Name = "AddForm";
            this.Text = "Add Alarm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker uxDateTimePicker;
        private System.Windows.Forms.CheckBox uxOnBox;
        private System.Windows.Forms.Button uxCancel;
        private System.Windows.Forms.Button uxSet;
    }
}