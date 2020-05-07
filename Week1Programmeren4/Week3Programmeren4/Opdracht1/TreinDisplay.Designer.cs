namespace Opdracht1
{
    partial class TreinDisplay
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelSpoor = new System.Windows.Forms.Label();
            this.labelAankomst = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(113, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Naam volgend station:";
            // 
            // labelSpoor
            // 
            this.labelSpoor.AutoSize = true;
            this.labelSpoor.Location = new System.Drawing.Point(12, 33);
            this.labelSpoor.Name = "labelSpoor";
            this.labelSpoor.Size = new System.Drawing.Size(113, 13);
            this.labelSpoor.TabIndex = 1;
            this.labelSpoor.Text = "Spoor volgend station:";
            // 
            // labelAankomst
            // 
            this.labelAankomst.AutoSize = true;
            this.labelAankomst.Location = new System.Drawing.Point(12, 56);
            this.labelAankomst.Name = "labelAankomst";
            this.labelAankomst.Size = new System.Drawing.Size(74, 13);
            this.labelAankomst.TabIndex = 2;
            this.labelAankomst.Text = "AankomstTijd:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // TreinDisplay
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 160);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAankomst);
            this.Controls.Add(this.labelSpoor);
            this.Controls.Add(this.labelName);
            this.Name = "TreinDisplay";
            this.Text = "TreinDisplay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSpoor;
        private System.Windows.Forms.Label labelAankomst;
        private System.Windows.Forms.Label label1;
    }
}