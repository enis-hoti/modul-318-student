namespace TransportApplikation
{
    partial class Connection_Details
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbldeparture = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblarrival = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Abfahrt:";
            // 
            // lbldeparture
            // 
            this.lbldeparture.AutoSize = true;
            this.lbldeparture.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldeparture.Location = new System.Drawing.Point(148, 9);
            this.lbldeparture.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldeparture.Name = "lbldeparture";
            this.lbldeparture.Size = new System.Drawing.Size(0, 29);
            this.lbldeparture.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ankunft: ";
            // 
            // lblarrival
            // 
            this.lblarrival.AutoSize = true;
            this.lblarrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblarrival.Location = new System.Drawing.Point(148, 38);
            this.lblarrival.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblarrival.Name = "lblarrival";
            this.lblarrival.Size = new System.Drawing.Size(0, 29);
            this.lblarrival.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dauer: ";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.Location = new System.Drawing.Point(148, 67);
            this.lbltime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(0, 29);
            this.lbltime.TabIndex = 5;
            // 
            // Connection_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(487, 102);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblarrival);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbldeparture);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Connection_Details";
            this.Text = "Connection_Details";
            this.Load += new System.EventHandler(this.Connection_Details_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldeparture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblarrival;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbltime;
    }
}