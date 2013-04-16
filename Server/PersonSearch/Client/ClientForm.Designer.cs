namespace Client
{
    partial class SearchForn
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnGetAllPersons = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listPersons = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(419, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnGetAllPersons
            // 
            this.btnGetAllPersons.Location = new System.Drawing.Point(419, 80);
            this.btnGetAllPersons.Name = "btnGetAllPersons";
            this.btnGetAllPersons.Size = new System.Drawing.Size(96, 23);
            this.btnGetAllPersons.TabIndex = 1;
            this.btnGetAllPersons.Text = "Get All Persons";
            this.btnGetAllPersons.UseVisualStyleBackColor = true;
            this.btnGetAllPersons.Click += new System.EventHandler(this.btnGetAllPersons_Click);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(112, 32);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(289, 20);
            this.textSearch.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search:";
            // 
            // listPersons
            // 
            this.listPersons.FormattingEnabled = true;
            this.listPersons.Location = new System.Drawing.Point(112, 58);
            this.listPersons.Name = "listPersons";
            this.listPersons.Size = new System.Drawing.Size(289, 355);
            this.listPersons.TabIndex = 4;
            // 
            // SearchForn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 443);
            this.Controls.Add(this.listPersons);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.btnGetAllPersons);
            this.Controls.Add(this.btnSearch);
            this.Name = "SearchForn";
            this.Text = "Search for Person";
            this.Load += new System.EventHandler(this.SearchForn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnGetAllPersons;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listPersons;
    }
}

