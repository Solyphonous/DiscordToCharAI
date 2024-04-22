namespace DiscordToCharAI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            openfile = new Button();
            Selected = new Label();
            Convert = new Button();
            debuglabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 15);
            label1.Name = "label1";
            label1.Size = new Size(187, 20);
            label1.TabIndex = 0;
            label1.Text = "Select JSON file to convert:";
            // 
            // openfile
            // 
            openfile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            openfile.Location = new Point(25, 38);
            openfile.Name = "openfile";
            openfile.Size = new Size(275, 29);
            openfile.TabIndex = 1;
            openfile.Text = "Open file...";
            openfile.UseVisualStyleBackColor = true;
            openfile.Click += openfile_Click;
            // 
            // Selected
            // 
            Selected.AutoSize = true;
            Selected.Location = new Point(25, 70);
            Selected.Name = "Selected";
            Selected.Size = new Size(206, 20);
            Selected.TabIndex = 2;
            Selected.Text = "Selected file: No file selected!";
            // 
            // Convert
            // 
            Convert.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Convert.Location = new Point(25, 93);
            Convert.Name = "Convert";
            Convert.Size = new Size(275, 29);
            Convert.TabIndex = 3;
            Convert.Text = "Convert";
            Convert.UseVisualStyleBackColor = true;
            Convert.Click += Convert_Click;
            // 
            // debuglabel
            // 
            debuglabel.AutoSize = true;
            debuglabel.Location = new Point(25, 125);
            debuglabel.Name = "debuglabel";
            debuglabel.Size = new Size(0, 20);
            debuglabel.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 193);
            Controls.Add(debuglabel);
            Controls.Add(Convert);
            Controls.Add(Selected);
            Controls.Add(openfile);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "DiscToCharAI";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button openfile;
        private Label Selected;
        private Button Convert;
        private Label debuglabel;
    }
}
