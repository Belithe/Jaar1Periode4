namespace Opdracht1
{
    partial class ControlPanel
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
            this.btnVolgendStation = new System.Windows.Forms.Button();
            this.btn_turn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVolgendStation
            // 
            this.btnVolgendStation.Location = new System.Drawing.Point(99, 73);
            this.btnVolgendStation.Name = "btnVolgendStation";
            this.btnVolgendStation.Size = new System.Drawing.Size(194, 81);
            this.btnVolgendStation.TabIndex = 0;
            this.btnVolgendStation.Text = "Volgend Station";
            this.btnVolgendStation.UseVisualStyleBackColor = true;
            this.btnVolgendStation.Click += new System.EventHandler(this.btnVolgendStation_Click);
            // 
            // btn_turn
            // 
            this.btn_turn.Location = new System.Drawing.Point(157, 232);
            this.btn_turn.Name = "btn_turn";
            this.btn_turn.Size = new System.Drawing.Size(75, 23);
            this.btn_turn.TabIndex = 1;
            this.btn_turn.Text = "Turn around";
            this.btn_turn.UseVisualStyleBackColor = true;
            this.btn_turn.Visible = false;
            this.btn_turn.Click += new System.EventHandler(this.btn_turn_Click);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 286);
            this.Controls.Add(this.btn_turn);
            this.Controls.Add(this.btnVolgendStation);
            this.Name = "ControlPanel";
            this.Text = "Control Panel";
            this.Load += new System.EventHandler(this.ControlPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolgendStation;
        private System.Windows.Forms.Button btn_turn;
    }
}

