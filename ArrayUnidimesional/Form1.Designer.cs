namespace ArrayUnidimesional
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
            txtPersons = new TextBox();
            btnSave = new Button();
            label2 = new Label();
            lblAges = new Label();
            btnAccept = new Button();
            txtAges = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(187, 9);
            label1.Name = "label1";
            label1.Size = new Size(452, 37);
            label1.TabIndex = 0;
            label1.Text = "PEOPLE INSIDE YOUR HOUSE";
            // 
            // txtPersons
            // 
            txtPersons.Location = new Point(109, 92);
            txtPersons.Name = "txtPersons";
            txtPersons.Size = new Size(243, 27);
            txtPersons.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(651, 316);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(222, 43);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(250, 191);
            label2.Name = "label2";
            label2.Size = new Size(416, 26);
            label2.TabIndex = 3;
            label2.Text = "Ages of the people inside your house:";
            // 
            // lblAges
            // 
            lblAges.AutoSize = true;
            lblAges.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAges.Location = new Point(35, 260);
            lblAges.Name = "lblAges";
            lblAges.Size = new Size(32, 31);
            lblAges.TabIndex = 4;
            lblAges.Text = "...";
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(496, 82);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(222, 47);
            btnAccept.TabIndex = 5;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // txtAges
            // 
            txtAges.Location = new Point(334, 332);
            txtAges.Name = "txtAges";
            txtAges.Size = new Size(243, 27);
            txtAges.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(234, 271);
            label3.Name = "label3";
            label3.Size = new Size(145, 20);
            label3.TabIndex = 7;
            label3.Text = "Example(3): 23,45,32";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(918, 535);
            Controls.Add(label3);
            Controls.Add(txtAges);
            Controls.Add(btnAccept);
            Controls.Add(lblAges);
            Controls.Add(label2);
            Controls.Add(btnSave);
            Controls.Add(txtPersons);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPersons;
        private Button btnSave;
        private Label label2;
        private Label lblAges;
        private Button btnAccept;
        private TextBox txtAges;
        private Label label3;
    }
}
