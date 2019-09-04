namespace AsyadCapital.Base.EntitiesConverterMVCToCore
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
            this.txt_Source = new System.Windows.Forms.RichTextBox();
            this.lbl_enterContexttext = new System.Windows.Forms.Label();
            this.lbl_CovertedContext = new System.Windows.Forms.Label();
            this.txt_Target = new System.Windows.Forms.RichTextBox();
            this.btn_convert = new System.Windows.Forms.Button();
            this.btn_copyConverted = new System.Windows.Forms.Button();
            this.lbl_ChooseProvider = new System.Windows.Forms.Label();
            this.cmb_DBProvider = new System.Windows.Forms.ComboBox();
            this.lbl_enterConnectionStting = new System.Windows.Forms.Label();
            this.txt_ConnectionString = new System.Windows.Forms.TextBox();
            this.btn_openFile = new System.Windows.Forms.Button();
            this.btn_test = new System.Windows.Forms.Button();
            this.lbl_load = new System.Windows.Forms.Label();
            this.btn_SaveConvetedFile = new System.Windows.Forms.Button();
            this.Logs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Source
            // 
            this.txt_Source.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Source.ForeColor = System.Drawing.Color.Black;
            this.txt_Source.Location = new System.Drawing.Point(9, 47);
            this.txt_Source.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Source.Name = "txt_Source";
            this.txt_Source.Size = new System.Drawing.Size(604, 325);
            this.txt_Source.TabIndex = 0;
            this.txt_Source.Text = "";
            // 
            // lbl_enterContexttext
            // 
            this.lbl_enterContexttext.AutoSize = true;
            this.lbl_enterContexttext.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_enterContexttext.ForeColor = System.Drawing.Color.Green;
            this.lbl_enterContexttext.Location = new System.Drawing.Point(9, 7);
            this.lbl_enterContexttext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_enterContexttext.Name = "lbl_enterContexttext";
            this.lbl_enterContexttext.Size = new System.Drawing.Size(245, 26);
            this.lbl_enterContexttext.TabIndex = 1;
            this.lbl_enterContexttext.Text = "Enter Your Context Text";
            // 
            // lbl_CovertedContext
            // 
            this.lbl_CovertedContext.AutoSize = true;
            this.lbl_CovertedContext.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CovertedContext.ForeColor = System.Drawing.Color.Green;
            this.lbl_CovertedContext.Location = new System.Drawing.Point(613, 7);
            this.lbl_CovertedContext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_CovertedContext.Name = "lbl_CovertedContext";
            this.lbl_CovertedContext.Size = new System.Drawing.Size(186, 26);
            this.lbl_CovertedContext.TabIndex = 3;
            this.lbl_CovertedContext.Text = "Conveted Context";
            // 
            // txt_Target
            // 
            this.txt_Target.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Target.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Target.ForeColor = System.Drawing.Color.Black;
            this.txt_Target.Location = new System.Drawing.Point(618, 47);
            this.txt_Target.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Target.Name = "txt_Target";
            this.txt_Target.Size = new System.Drawing.Size(656, 325);
            this.txt_Target.TabIndex = 2;
            this.txt_Target.Text = "";
            // 
            // btn_convert
            // 
            this.btn_convert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_convert.ForeColor = System.Drawing.Color.Red;
            this.btn_convert.Location = new System.Drawing.Point(180, 381);
            this.btn_convert.Margin = new System.Windows.Forms.Padding(2);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(110, 31);
            this.btn_convert.TabIndex = 4;
            this.btn_convert.Text = "Convert  Now";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.Btn_convert_Click);
            // 
            // btn_copyConverted
            // 
            this.btn_copyConverted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_copyConverted.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_copyConverted.ForeColor = System.Drawing.Color.Red;
            this.btn_copyConverted.Location = new System.Drawing.Point(294, 380);
            this.btn_copyConverted.Margin = new System.Windows.Forms.Padding(2);
            this.btn_copyConverted.Name = "btn_copyConverted";
            this.btn_copyConverted.Size = new System.Drawing.Size(63, 33);
            this.btn_copyConverted.TabIndex = 5;
            this.btn_copyConverted.Text = "Copy ";
            this.btn_copyConverted.UseVisualStyleBackColor = true;
            this.btn_copyConverted.Click += new System.EventHandler(this.Btn_copyConverted_Click);
            // 
            // lbl_ChooseProvider
            // 
            this.lbl_ChooseProvider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ChooseProvider.AutoSize = true;
            this.lbl_ChooseProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ChooseProvider.ForeColor = System.Drawing.Color.Green;
            this.lbl_ChooseProvider.Location = new System.Drawing.Point(741, 421);
            this.lbl_ChooseProvider.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ChooseProvider.Name = "lbl_ChooseProvider";
            this.lbl_ChooseProvider.Size = new System.Drawing.Size(131, 16);
            this.lbl_ChooseProvider.TabIndex = 6;
            this.lbl_ChooseProvider.Text = "Choose DB Provider";
            // 
            // cmb_DBProvider
            // 
            this.cmb_DBProvider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_DBProvider.FormattingEnabled = true;
            this.cmb_DBProvider.Items.AddRange(new object[] {
            "SqlParameter",
            "MySqlParameter"});
            this.cmb_DBProvider.Location = new System.Drawing.Point(890, 421);
            this.cmb_DBProvider.Name = "cmb_DBProvider";
            this.cmb_DBProvider.Size = new System.Drawing.Size(295, 21);
            this.cmb_DBProvider.TabIndex = 7;
            // 
            // lbl_enterConnectionStting
            // 
            this.lbl_enterConnectionStting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_enterConnectionStting.AutoSize = true;
            this.lbl_enterConnectionStting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_enterConnectionStting.ForeColor = System.Drawing.Color.Green;
            this.lbl_enterConnectionStting.Location = new System.Drawing.Point(741, 392);
            this.lbl_enterConnectionStting.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_enterConnectionStting.Name = "lbl_enterConnectionStting";
            this.lbl_enterConnectionStting.Size = new System.Drawing.Size(146, 16);
            this.lbl_enterConnectionStting.TabIndex = 8;
            this.lbl_enterConnectionStting.Text = "Enter Connection String";
            // 
            // txt_ConnectionString
            // 
            this.txt_ConnectionString.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ConnectionString.Location = new System.Drawing.Point(890, 388);
            this.txt_ConnectionString.Name = "txt_ConnectionString";
            this.txt_ConnectionString.Size = new System.Drawing.Size(295, 20);
            this.txt_ConnectionString.TabIndex = 9;
            // 
            // btn_openFile
            // 
            this.btn_openFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_openFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_openFile.ForeColor = System.Drawing.Color.Red;
            this.btn_openFile.Location = new System.Drawing.Point(9, 382);
            this.btn_openFile.Margin = new System.Windows.Forms.Padding(2);
            this.btn_openFile.Name = "btn_openFile";
            this.btn_openFile.Size = new System.Drawing.Size(167, 31);
            this.btn_openFile.TabIndex = 11;
            this.btn_openFile.Text = "Open File To Convert";
            this.btn_openFile.UseVisualStyleBackColor = true;
            this.btn_openFile.Click += new System.EventHandler(this.Btn_openFile_Click);
            // 
            // btn_test
            // 
            this.btn_test.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_test.ForeColor = System.Drawing.Color.Red;
            this.btn_test.Location = new System.Drawing.Point(1203, 387);
            this.btn_test.Margin = new System.Windows.Forms.Padding(2);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(70, 24);
            this.btn_test.TabIndex = 13;
            this.btn_test.Text = "Test";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // lbl_load
            // 
            this.lbl_load.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_load.AutoSize = true;
            this.lbl_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_load.ForeColor = System.Drawing.Color.Green;
            this.lbl_load.Location = new System.Drawing.Point(546, 468);
            this.lbl_load.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_load.Name = "lbl_load";
            this.lbl_load.Size = new System.Drawing.Size(0, 16);
            this.lbl_load.TabIndex = 14;
            // 
            // btn_SaveConvetedFile
            // 
            this.btn_SaveConvetedFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_SaveConvetedFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveConvetedFile.ForeColor = System.Drawing.Color.Red;
            this.btn_SaveConvetedFile.Location = new System.Drawing.Point(361, 381);
            this.btn_SaveConvetedFile.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SaveConvetedFile.Name = "btn_SaveConvetedFile";
            this.btn_SaveConvetedFile.Size = new System.Drawing.Size(68, 33);
            this.btn_SaveConvetedFile.TabIndex = 15;
            this.btn_SaveConvetedFile.Text = "Save ";
            this.btn_SaveConvetedFile.UseVisualStyleBackColor = true;
            this.btn_SaveConvetedFile.Click += new System.EventHandler(this.btn_SaveConvetedFile_Click);
            // 
            // Logs
            // 
            this.Logs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Logs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs.ForeColor = System.Drawing.Color.Red;
            this.Logs.Location = new System.Drawing.Point(433, 382);
            this.Logs.Margin = new System.Windows.Forms.Padding(2);
            this.Logs.Name = "Logs";
            this.Logs.Size = new System.Drawing.Size(73, 33);
            this.Logs.TabIndex = 16;
            this.Logs.Text = "Logs";
            this.Logs.UseVisualStyleBackColor = true;
            this.Logs.Click += new System.EventHandler(this.btn_logs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 493);
            this.Controls.Add(this.Logs);
            this.Controls.Add(this.btn_SaveConvetedFile);
            this.Controls.Add(this.lbl_load);
            this.Controls.Add(this.btn_test);
            this.Controls.Add(this.btn_openFile);
            this.Controls.Add(this.txt_ConnectionString);
            this.Controls.Add(this.lbl_enterConnectionStting);
            this.Controls.Add(this.cmb_DBProvider);
            this.Controls.Add(this.lbl_ChooseProvider);
            this.Controls.Add(this.btn_copyConverted);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.lbl_CovertedContext);
            this.Controls.Add(this.txt_Target);
            this.Controls.Add(this.lbl_enterContexttext);
            this.Controls.Add(this.txt_Source);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sp Conveter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txt_Source;
        private System.Windows.Forms.Label lbl_enterContexttext;
        private System.Windows.Forms.Label lbl_CovertedContext;
        private System.Windows.Forms.RichTextBox txt_Target;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.Button btn_copyConverted;
        private System.Windows.Forms.ComboBox cmb_DBProvider;
        private System.Windows.Forms.Label lbl_ChooseProvider;
        private System.Windows.Forms.TextBox txt_ConnectionString;
        private System.Windows.Forms.Label lbl_enterConnectionStting;
        private System.Windows.Forms.Button btn_openFile;
        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.Label lbl_load;
        private System.Windows.Forms.Button btn_SaveConvetedFile;
        private System.Windows.Forms.Button Logs;
    }
}

