namespace TransportApplikation
{
    partial class Main
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
            this.lbltitle = new System.Windows.Forms.Label();
            this.gbdeparture = new System.Windows.Forms.GroupBox();
            this.btntablesearch = new System.Windows.Forms.Button();
            this.txttableplace = new System.Windows.Forms.TextBox();
            this.gbconnection = new System.Windows.Forms.GroupBox();
            this.btnconnectionsearch = new System.Windows.Forms.Button();
            this.txtconnectiontime = new System.Windows.Forms.TextBox();
            this.txtconnectionarrival = new System.Windows.Forms.TextBox();
            this.txtconnectiondeparture = new System.Windows.Forms.TextBox();
            this.gbdeparture.SuspendLayout();
            this.gbconnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbltitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(0, 0);
            this.lbltitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(903, 77);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Fahrplan";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbdeparture
            // 
            this.gbdeparture.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbdeparture.Controls.Add(this.btntablesearch);
            this.gbdeparture.Controls.Add(this.txttableplace);
            this.gbdeparture.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbdeparture.Location = new System.Drawing.Point(450, 77);
            this.gbdeparture.Margin = new System.Windows.Forms.Padding(2);
            this.gbdeparture.Name = "gbdeparture";
            this.gbdeparture.Padding = new System.Windows.Forms.Padding(2);
            this.gbdeparture.Size = new System.Drawing.Size(453, 395);
            this.gbdeparture.TabIndex = 1;
            this.gbdeparture.TabStop = false;
            this.gbdeparture.Text = "Abfahrtstabelle";
            // 
            // btntablesearch
            // 
            this.btntablesearch.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btntablesearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntablesearch.Location = new System.Drawing.Point(8, 199);
            this.btntablesearch.Margin = new System.Windows.Forms.Padding(2);
            this.btntablesearch.Name = "btntablesearch";
            this.btntablesearch.Size = new System.Drawing.Size(440, 187);
            this.btntablesearch.TabIndex = 4;
            this.btntablesearch.Text = "Suchen";
            this.btntablesearch.UseVisualStyleBackColor = false;
            this.btntablesearch.Click += new System.EventHandler(this.btntablesearch_Click);
            // 
            // txttableplace
            // 
            this.txttableplace.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txttableplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttableplace.Location = new System.Drawing.Point(8, 35);
            this.txttableplace.Margin = new System.Windows.Forms.Padding(2);
            this.txttableplace.Name = "txttableplace";
            this.txttableplace.Size = new System.Drawing.Size(442, 34);
            this.txttableplace.TabIndex = 4;
            this.txttableplace.Text = "Ort";
            // 
            // gbconnection
            // 
            this.gbconnection.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbconnection.Controls.Add(this.btnconnectionsearch);
            this.gbconnection.Controls.Add(this.txtconnectiontime);
            this.gbconnection.Controls.Add(this.txtconnectionarrival);
            this.gbconnection.Controls.Add(this.txtconnectiondeparture);
            this.gbconnection.Location = new System.Drawing.Point(0, 77);
            this.gbconnection.Margin = new System.Windows.Forms.Padding(2);
            this.gbconnection.Name = "gbconnection";
            this.gbconnection.Padding = new System.Windows.Forms.Padding(2);
            this.gbconnection.Size = new System.Drawing.Size(450, 395);
            this.gbconnection.TabIndex = 2;
            this.gbconnection.TabStop = false;
            this.gbconnection.Text = "Verbindungen anzeigen";
            // 
            // btnconnectionsearch
            // 
            this.btnconnectionsearch.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnconnectionsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconnectionsearch.Location = new System.Drawing.Point(5, 199);
            this.btnconnectionsearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnconnectionsearch.Name = "btnconnectionsearch";
            this.btnconnectionsearch.Size = new System.Drawing.Size(440, 187);
            this.btnconnectionsearch.TabIndex = 3;
            this.btnconnectionsearch.Text = "Suchen";
            this.btnconnectionsearch.UseVisualStyleBackColor = false;
            this.btnconnectionsearch.Click += new System.EventHandler(this.btnconnectionsearch_Click);
            // 
            // txtconnectiontime
            // 
            this.txtconnectiontime.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtconnectiontime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconnectiontime.Location = new System.Drawing.Point(4, 139);
            this.txtconnectiontime.Margin = new System.Windows.Forms.Padding(2);
            this.txtconnectiontime.Name = "txtconnectiontime";
            this.txtconnectiontime.Size = new System.Drawing.Size(442, 34);
            this.txtconnectiontime.TabIndex = 2;
            this.txtconnectiontime.Text = "Zeit (HH:MM)";
            // 
            // txtconnectionarrival
            // 
            this.txtconnectionarrival.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtconnectionarrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconnectionarrival.Location = new System.Drawing.Point(4, 75);
            this.txtconnectionarrival.Margin = new System.Windows.Forms.Padding(2);
            this.txtconnectionarrival.Name = "txtconnectionarrival";
            this.txtconnectionarrival.Size = new System.Drawing.Size(442, 34);
            this.txtconnectionarrival.TabIndex = 1;
            this.txtconnectionarrival.Text = "Zielort";
            // 
            // txtconnectiondeparture
            // 
            this.txtconnectiondeparture.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtconnectiondeparture.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconnectiondeparture.Location = new System.Drawing.Point(4, 35);
            this.txtconnectiondeparture.Margin = new System.Windows.Forms.Padding(2);
            this.txtconnectiondeparture.Name = "txtconnectiondeparture";
            this.txtconnectiondeparture.Size = new System.Drawing.Size(442, 34);
            this.txtconnectiondeparture.TabIndex = 0;
            this.txtconnectiondeparture.Text = "Startort";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 472);
            this.Controls.Add(this.gbconnection);
            this.Controls.Add(this.gbdeparture);
            this.Controls.Add(this.lbltitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.gbdeparture.ResumeLayout(false);
            this.gbdeparture.PerformLayout();
            this.gbconnection.ResumeLayout(false);
            this.gbconnection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.GroupBox gbdeparture;
        private System.Windows.Forms.GroupBox gbconnection;
        private System.Windows.Forms.TextBox txtconnectionarrival;
        private System.Windows.Forms.TextBox txtconnectiondeparture;
        private System.Windows.Forms.Button btnconnectionsearch;
        private System.Windows.Forms.TextBox txtconnectiontime;
        private System.Windows.Forms.Button btntablesearch;
        private System.Windows.Forms.TextBox txttableplace;
    }
}

