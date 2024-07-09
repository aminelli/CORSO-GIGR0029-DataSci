namespace WinFormBruno
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
            btnSaluta = new Button();
            txtMessagio = new TextBox();
            SuspendLayout();
            // 
            // btnSaluta
            // 
            btnSaluta.Location = new Point(45, 63);
            btnSaluta.Name = "btnSaluta";
            btnSaluta.Size = new Size(75, 23);
            btnSaluta.TabIndex = 0;
            btnSaluta.Text = "Saluta";
            btnSaluta.UseVisualStyleBackColor = true;
            btnSaluta.Click += btnSaluta_Click;
            // 
            // txtMessagio
            // 
            txtMessagio.Location = new Point(45, 23);
            txtMessagio.Name = "txtMessagio";
            txtMessagio.Size = new Size(247, 23);
            txtMessagio.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 124);
            Controls.Add(txtMessagio);
            Controls.Add(btnSaluta);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaluta;
        private TextBox txtMessagio;
    }
}
