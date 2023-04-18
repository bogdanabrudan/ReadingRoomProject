
namespace ProiectII_fin
{
    partial class FormProfile
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelUniv = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Bauhaus 93", 36.31305F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelTitle.Location = new System.Drawing.Point(23, 35);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(342, 67);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Your Profile";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Location = new System.Drawing.Point(53, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 1);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Location = new System.Drawing.Point(384, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 75);
            this.panel3.TabIndex = 11;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Berlin Sans FB", 11.26957F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelUsername.Location = new System.Drawing.Point(64, 181);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(90, 21);
            this.labelUsername.TabIndex = 12;
            this.labelUsername.Text = "Username";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Berlin Sans FB", 11.26957F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelName.Location = new System.Drawing.Point(94, 217);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(60, 21);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "Name";
            // 
            // labelUniv
            // 
            this.labelUniv.AutoSize = true;
            this.labelUniv.Font = new System.Drawing.Font("Berlin Sans FB", 11.26957F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUniv.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelUniv.Location = new System.Drawing.Point(65, 256);
            this.labelUniv.Name = "labelUniv";
            this.labelUniv.Size = new System.Drawing.Size(89, 21);
            this.labelUniv.TabIndex = 14;
            this.labelUniv.Text = "University";
            this.labelUniv.Click += new System.EventHandler(this.labelUniv_Click);
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Berlin Sans FB", 11.26957F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelPhone.Location = new System.Drawing.Point(26, 298);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(128, 21);
            this.labelPhone.TabIndex = 15;
            this.labelPhone.Text = "Phone number";
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(754, 506);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelUniv);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelTitle);
            this.Name = "FormProfile";
            this.Text = "FormProfile";
            this.Load += new System.EventHandler(this.FormProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelUniv;
        private System.Windows.Forms.Label labelPhone;
    }
}