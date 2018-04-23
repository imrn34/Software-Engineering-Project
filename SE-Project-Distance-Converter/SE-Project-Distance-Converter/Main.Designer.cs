namespace SE_Project_Distance_Converter
{
    partial class Main
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
            this.lefttext = new System.Windows.Forms.TextBox();
            this.righttext = new System.Windows.Forms.TextBox();
            this.leftcom = new System.Windows.Forms.ComboBox();
            this.rightcom = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lefttext
            // 
            this.lefttext.Location = new System.Drawing.Point(149, 90);
            this.lefttext.Name = "lefttext";
            this.lefttext.Size = new System.Drawing.Size(120, 20);
            this.lefttext.TabIndex = 0;
            this.lefttext.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lefttext_MouseClick);
            // 
            // righttext
            // 
            this.righttext.Location = new System.Drawing.Point(285, 90);
            this.righttext.Name = "righttext";
            this.righttext.Size = new System.Drawing.Size(120, 20);
            this.righttext.TabIndex = 0;
            this.righttext.MouseClick += new System.Windows.Forms.MouseEventHandler(this.righttext_MouseClick);
            // 
            // leftcom
            // 
            this.leftcom.FormattingEnabled = true;
            this.leftcom.Items.AddRange(new object[] {
            "Milimeter (mm)",
            "Centimeter (cm)",
            "Meter (m)",
            "Kilometer (km)"});
            this.leftcom.Location = new System.Drawing.Point(149, 60);
            this.leftcom.Name = "leftcom";
            this.leftcom.Size = new System.Drawing.Size(120, 21);
            this.leftcom.TabIndex = 1;
            this.leftcom.SelectedIndexChanged += new System.EventHandler(this.leftcom_SelectedIndexChanged);
            // 
            // rightcom
            // 
            this.rightcom.FormattingEnabled = true;
            this.rightcom.Items.AddRange(new object[] {
            "Milimeter (mm)",
            "Centimeter (cm)",
            "Meter (m)",
            "Kilometer (km)"});
            this.rightcom.Location = new System.Drawing.Point(285, 60);
            this.rightcom.Name = "rightcom";
            this.rightcom.Size = new System.Drawing.Size(120, 21);
            this.rightcom.TabIndex = 2;
            this.rightcom.SelectedIndexChanged += new System.EventHandler(this.rightcom_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 165);
            this.Controls.Add(this.rightcom);
            this.Controls.Add(this.leftcom);
            this.Controls.Add(this.righttext);
            this.Controls.Add(this.lefttext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lefttext;
        private System.Windows.Forms.TextBox righttext;
        private System.Windows.Forms.ComboBox leftcom;
        private System.Windows.Forms.ComboBox rightcom;
    }
}

