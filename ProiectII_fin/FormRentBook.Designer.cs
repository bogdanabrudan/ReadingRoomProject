
namespace ProiectII_fin
{
    partial class FormRentBook
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
            this.byName = new System.Windows.Forms.RadioButton();
            this.byAuthor = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.btnRent = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxPublisher = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // byName
            // 
            this.byName.AutoSize = true;
            this.byName.Location = new System.Drawing.Point(82, 51);
            this.byName.Name = "byName";
            this.byName.Size = new System.Drawing.Size(128, 21);
            this.byName.TabIndex = 0;
            this.byName.TabStop = true;
            this.byName.Text = "by Book\'s Name";
            this.byName.UseVisualStyleBackColor = true;
            // 
            // byAuthor
            // 
            this.byAuthor.AutoSize = true;
            this.byAuthor.Location = new System.Drawing.Point(215, 51);
            this.byAuthor.Name = "byAuthor";
            this.byAuthor.Size = new System.Drawing.Size(138, 21);
            this.byAuthor.TabIndex = 1;
            this.byAuthor.TabStop = true;
            this.byAuthor.Text = "by Author\'s Name";
            this.byAuthor.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filter:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(82, 78);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(271, 22);
            this.txtName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(467, 68);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(105, 47);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(645, 277);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(89, 50);
            this.btnRent.TabIndex = 7;
            this.btnRent.Text = "RENT";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 49;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(548, 303);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(594, 149);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(194, 22);
            this.textBoxName.TabIndex = 10;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(594, 177);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.ReadOnly = true;
            this.textBoxAuthor.Size = new System.Drawing.Size(194, 22);
            this.textBoxAuthor.TabIndex = 11;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(594, 205);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.ReadOnly = true;
            this.textBoxYear.Size = new System.Drawing.Size(194, 22);
            this.textBoxYear.TabIndex = 13;
            // 
            // textBoxPublisher
            // 
            this.textBoxPublisher.Location = new System.Drawing.Point(594, 233);
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.ReadOnly = true;
            this.textBoxPublisher.Size = new System.Drawing.Size(194, 22);
            this.textBoxPublisher.TabIndex = 14;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(594, 121);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(194, 22);
            this.textBoxID.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(591, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Selected Book:";
            // 
            // FormRentBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPublisher);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.byAuthor);
            this.Controls.Add(this.byName);
            this.Name = "FormRentBook";
            this.Text = "FormRentBook";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton byName;
        private System.Windows.Forms.RadioButton byAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxPublisher;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label3;
    }
}