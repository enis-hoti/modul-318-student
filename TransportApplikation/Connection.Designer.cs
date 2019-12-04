namespace TransportApplikation
{
    partial class Connection
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
            this.gbconnection = new System.Windows.Forms.GroupBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txttime = new System.Windows.Forms.TextBox();
            this.txtarrival = new System.Windows.Forms.TextBox();
            this.txtdeparture = new System.Windows.Forms.TextBox();
            this.lvdata = new System.Windows.Forms.ListView();
            this.gbconnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbconnection
            // 
            this.gbconnection.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbconnection.Controls.Add(this.btnsearch);
            this.gbconnection.Controls.Add(this.txttime);
            this.gbconnection.Controls.Add(this.txtarrival);
            this.gbconnection.Controls.Add(this.txtdeparture);
            this.gbconnection.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbconnection.Location = new System.Drawing.Point(0, 0);
            this.gbconnection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbconnection.Name = "gbconnection";
            this.gbconnection.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbconnection.Size = new System.Drawing.Size(1133, 89);
            this.gbconnection.TabIndex = 0;
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
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txttime
            // 
            this.txttime.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txttime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttime.Location = new System.Drawing.Point(614, 33);
            this.txttime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txttime.Name = "txttime";
            this.txttime.Size = new System.Drawing.Size(149, 34);
            this.txttime.TabIndex = 2;
            this.txttime.Text = "Zeit (HH:MM)";
            // 
            // txtarrival
            // 
            this.txtarrival.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtarrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtarrival.Location = new System.Drawing.Point(254, 33);
            this.txtarrival.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtarrival.Name = "txtarrival";
            this.txtarrival.Size = new System.Drawing.Size(242, 34);
            this.txtarrival.TabIndex = 1;
            this.txtarrival.Text = "Zielort";
            // 
            // txtdeparture
            // 
            this.txtdeparture.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtdeparture.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdeparture.Location = new System.Drawing.Point(9, 33);
            this.txtdeparture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtdeparture.Name = "txtdeparture";
            this.txtdeparture.Size = new System.Drawing.Size(242, 34);
            this.txtdeparture.TabIndex = 0;
            this.txtdeparture.Text = "Startort";
            // 
            // lvdata
            // 
            this.lvdata.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lvdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvdata.HideSelection = false;
            this.lvdata.Location = new System.Drawing.Point(0, 89);
            this.lvdata.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvdata.Name = "lvdata";
            this.lvdata.Size = new System.Drawing.Size(1133, 455);
            this.lvdata.TabIndex = 1;
            this.lvdata.UseCompatibleStateImageBehavior = false;
            this.lvdata.View = System.Windows.Forms.View.List;
            this.lvdata.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvdata_MouseDoubleClick);
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 544);
            this.Controls.Add(this.lvdata);
            this.Controls.Add(this.gbconnection);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Connection";
            this.Text = "Connection";
            this.Load += new System.EventHandler(this.Connection_Load);
            this.gbconnection.ResumeLayout(false);
            this.gbconnection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbconnection;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txttime;
        private System.Windows.Forms.TextBox txtarrival;
        private System.Windows.Forms.TextBox txtdeparture;
        private System.Windows.Forms.ListView lvdata;
    }
}