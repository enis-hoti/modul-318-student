namespace TransportApplikation
{
    partial class Table
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
            this.lvdata = new System.Windows.Forms.ListView();
            this.gbconnection = new System.Windows.Forms.GroupBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtplace = new System.Windows.Forms.TextBox();
            this.gbconnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvdata
            // 
            this.lvdata.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lvdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvdata.HideSelection = false;
            this.lvdata.Location = new System.Drawing.Point(0, 89);
            this.lvdata.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvdata.Name = "lvdata";
            this.lvdata.Size = new System.Drawing.Size(1137, 567);
            this.lvdata.TabIndex = 3;
            this.lvdata.UseCompatibleStateImageBehavior = false;
            this.lvdata.View = System.Windows.Forms.View.List;
            // 
            // gbconnection
            // 
            this.gbconnection.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbconnection.Controls.Add(this.btnsearch);
            this.gbconnection.Controls.Add(this.txtplace);
            this.gbconnection.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbconnection.Location = new System.Drawing.Point(0, 0);
            this.gbconnection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbconnection.Name = "gbconnection";
            this.gbconnection.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbconnection.Size = new System.Drawing.Size(1137, 89);
            this.gbconnection.TabIndex = 2;
            this.gbconnection.TabStop = false;
            this.gbconnection.Text = "Verbindungen anzeigen";
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnsearch.Location = new System.Drawing.Point(919, 8);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(206, 77);
            this.btnsearch.TabIndex = 3;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            // 
            // txtplace
            // 
            this.txtplace.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtplace.Location = new System.Drawing.Point(9, 33);
            this.txtplace.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtplace.Name = "txtplace";
            this.txtplace.Size = new System.Drawing.Size(242, 34);
            this.txtplace.TabIndex = 0;
            this.txtplace.Text = "Ort";
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 656);
            this.Controls.Add(this.lvdata);
            this.Controls.Add(this.gbconnection);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Table";
            this.Text = "Table";
            this.Load += new System.EventHandler(this.Table_Load);
            this.gbconnection.ResumeLayout(false);
            this.gbconnection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvdata;
        private System.Windows.Forms.GroupBox gbconnection;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtplace;
    }
}