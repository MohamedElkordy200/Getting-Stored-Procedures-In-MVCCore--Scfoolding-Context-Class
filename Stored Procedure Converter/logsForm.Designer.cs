namespace AsyadCapital.Base.EntitiesConverterMVCToCore
{
    partial class logsForm
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
            this.txt_Logs = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txt_Logs
            // 
            this.txt_Logs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Logs.Location = new System.Drawing.Point(3, 2);
            this.txt_Logs.Name = "txt_Logs";
            this.txt_Logs.Size = new System.Drawing.Size(794, 454);
            this.txt_Logs.TabIndex = 0;
            this.txt_Logs.Text = "";
            // 
            // logsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Logs);
            this.Name = "logsForm";
            this.Text = "Logs ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txt_Logs;
    }
}