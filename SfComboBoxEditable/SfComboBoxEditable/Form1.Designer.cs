namespace SfComboBoxEditable
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
            this.sfComboBox1 = new Syncfusion.WinForms.ListView.SfComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sfComboBox1
            // 
            this.sfComboBox1.Location = new System.Drawing.Point(268, 195);
            this.sfComboBox1.Name = "sfComboBox1";
            this.sfComboBox1.Size = new System.Drawing.Size(234, 60);
            this.sfComboBox1.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sfComboBox1.TabIndex = 0;
            this.sfComboBox1.SelectedIndexChanged += new System.EventHandler(this.sfComboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.CaptionButtonColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sfComboBox1);
            this.Name = "Form1";
            this.Text = "SfComboBox_AutoCompleteMode";
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.WinForms.ListView.SfComboBox sfComboBox1;
    }
}

