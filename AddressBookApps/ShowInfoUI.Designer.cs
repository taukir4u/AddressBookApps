namespace AddressBookApps
{
    partial class ShowInfoUI
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
            this.showAllListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // showAllListView
            // 
            this.showAllListView.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.showAllListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.showAllListView.Location = new System.Drawing.Point(12, 21);
            this.showAllListView.Name = "showAllListView";
            this.showAllListView.Size = new System.Drawing.Size(569, 396);
            this.showAllListView.TabIndex = 0;
            this.showAllListView.UseCompatibleStateImageBehavior = false;
            this.showAllListView.View = System.Windows.Forms.View.Details;
            this.showAllListView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "First Name";
            this.columnHeader1.Width = 104;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Last Name";
            this.columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Email";
            this.columnHeader3.Width = 198;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mobile/Phone";
            this.columnHeader4.Width = 151;
            // 
            // ShowInfoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 429);
            this.Controls.Add(this.showAllListView);
            this.Name = "ShowInfoUI";
            this.Text = "ShowInfoUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView showAllListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}