namespace PraktikumADO
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
            txtHasil = new TextBox();
            btnConnect = new Button();
            btnHitungMhs = new Button();
            btnHitungMk = new Button();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(198, 100);
            label1.Name = "label1";
            label1.Size = new Size(55, 25);
            label1.TabIndex = 0;
            label1.Text = "Hasil";
            label1.Click += label1_Click;
            // 
            // txtHasil
            // 
            txtHasil.Location = new Point(278, 102);
            txtHasil.Name = "txtHasil";
            txtHasil.Size = new Size(414, 23);
            txtHasil.TabIndex = 1;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(178, 210);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(75, 23);
            btnConnect.TabIndex = 2;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click_1;
            // 
            // btnHitungMhs
            // 
            btnHitungMhs.Location = new Point(310, 210);
            btnHitungMhs.Name = "btnHitungMhs";
            btnHitungMhs.Size = new Size(108, 23);
            btnHitungMhs.TabIndex = 3;
            btnHitungMhs.Text = "Hitung Mhs";
            btnHitungMhs.UseVisualStyleBackColor = true;
            btnHitungMhs.Click += btnHitungMhs_Click;
            // 
            // btnHitungMk
            // 
            btnHitungMk.Location = new Point(472, 210);
            btnHitungMk.Name = "btnHitungMk";
            btnHitungMk.Size = new Size(75, 23);
            btnHitungMk.TabIndex = 4;
            btnHitungMk.Text = "Hitung Mk";
            btnHitungMk.UseVisualStyleBackColor = true;
            btnHitungMk.Click += btnHitungMk_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(617, 210);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(btnHitungMk);
            Controls.Add(btnHitungMhs);
            Controls.Add(btnConnect);
            Controls.Add(txtHasil);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtHasil;
        private Button btnConnect;
        private Button btnHitungMhs;
        private Button btnHitungMk;
        private Button btnUpdate;
    }
}
