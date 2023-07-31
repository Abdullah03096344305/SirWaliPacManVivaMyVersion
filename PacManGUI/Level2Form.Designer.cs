
namespace PacManGUI
{
    partial class Level2Form
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
            this.components = new System.ComponentModel.Container();
            this.gameLoop = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.labelStarValue = new System.Windows.Forms.Label();
            this.Health = new System.Windows.Forms.Label();
            this.labelHealthValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScoreValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameLoop
            // 
            this.gameLoop.Enabled = true;
            this.gameLoop.Tick += new System.EventHandler(this.gameLoop_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(375, 620);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Star: ";
            // 
            // labelStarValue
            // 
            this.labelStarValue.AutoSize = true;
            this.labelStarValue.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStarValue.ForeColor = System.Drawing.Color.White;
            this.labelStarValue.Location = new System.Drawing.Point(449, 620);
            this.labelStarValue.Name = "labelStarValue";
            this.labelStarValue.Size = new System.Drawing.Size(52, 22);
            this.labelStarValue.TabIndex = 10;
            this.labelStarValue.Text = "label1";
            // 
            // Health
            // 
            this.Health.AutoSize = true;
            this.Health.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Health.ForeColor = System.Drawing.Color.White;
            this.Health.Location = new System.Drawing.Point(186, 620);
            this.Health.Name = "Health";
            this.Health.Size = new System.Drawing.Size(65, 22);
            this.Health.TabIndex = 9;
            this.Health.Text = "Health: ";
            // 
            // labelHealthValue
            // 
            this.labelHealthValue.AutoSize = true;
            this.labelHealthValue.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHealthValue.ForeColor = System.Drawing.Color.White;
            this.labelHealthValue.Location = new System.Drawing.Point(260, 620);
            this.labelHealthValue.Name = "labelHealthValue";
            this.labelHealthValue.Size = new System.Drawing.Size(52, 22);
            this.labelHealthValue.TabIndex = 8;
            this.labelHealthValue.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 620);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Score: ";
            // 
            // lblScoreValue
            // 
            this.lblScoreValue.AutoSize = true;
            this.lblScoreValue.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreValue.ForeColor = System.Drawing.Color.White;
            this.lblScoreValue.Location = new System.Drawing.Point(86, 620);
            this.lblScoreValue.Name = "lblScoreValue";
            this.lblScoreValue.Size = new System.Drawing.Size(52, 22);
            this.lblScoreValue.TabIndex = 6;
            this.lblScoreValue.Text = "label1";
            // 
            // Level2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1345, 651);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelStarValue);
            this.Controls.Add(this.Health);
            this.Controls.Add(this.labelHealthValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblScoreValue);
            this.Name = "Level2Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level2Form";
            this.Load += new System.EventHandler(this.Level2Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameLoop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelStarValue;
        private System.Windows.Forms.Label Health;
        private System.Windows.Forms.Label labelHealthValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScoreValue;
    }
}