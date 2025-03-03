namespace tpmod3_103022300069
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
            formNama = new TextBox();
            btnSubmit = new Button();
            lblOutput = new Label();
            SuspendLayout();
            // 
            // formNama
            // 
            formNama.Location = new Point(164, 165);
            formNama.Name = "formNama";
            formNama.Size = new Size(291, 23);
            formNama.TabIndex = 0;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(255, 128, 0);
            btnSubmit.Font = new Font("Segoe UI", 12F);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(478, 157);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(105, 37);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblOutput
            // 
            lblOutput.BackColor = Color.FromArgb(255, 128, 0);
            lblOutput.Font = new Font("Segoe UI", 12F);
            lblOutput.ForeColor = Color.White;
            lblOutput.Location = new Point(164, 219);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(419, 31);
            lblOutput.TabIndex = 2;
            lblOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblOutput);
            Controls.Add(btnSubmit);
            Controls.Add(formNama);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox formNama;
        private Button btnSubmit;
        private Label lblOutput;
    }
}
