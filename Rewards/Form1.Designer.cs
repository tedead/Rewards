namespace Rewards {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnPick = new System.Windows.Forms.Button();
            this.lstPickRewards = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtCoinCount = new System.Windows.Forms.TextBox();
            this.lblCoins = new System.Windows.Forms.Label();
            this.lblPickCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPick
            // 
            this.btnPick.Font = new System.Drawing.Font("Calibri", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPick.Location = new System.Drawing.Point(12, 326);
            this.btnPick.Name = "btnPick";
            this.btnPick.Size = new System.Drawing.Size(66, 23);
            this.btnPick.TabIndex = 0;
            this.btnPick.Text = "Pick";
            this.btnPick.UseVisualStyleBackColor = true;
            this.btnPick.Click += new System.EventHandler(this.btnPick_Click);
            // 
            // lstPickRewards
            // 
            this.lstPickRewards.Font = new System.Drawing.Font("Calibri", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPickRewards.FormattingEnabled = true;
            this.lstPickRewards.ItemHeight = 15;
            this.lstPickRewards.Location = new System.Drawing.Point(13, 31);
            this.lstPickRewards.Name = "lstPickRewards";
            this.lstPickRewards.Size = new System.Drawing.Size(422, 289);
            this.lstPickRewards.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Calibri", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(84, 326);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(66, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtCoinCount
            // 
            this.txtCoinCount.Font = new System.Drawing.Font("Calibri", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoinCount.Location = new System.Drawing.Point(13, 393);
            this.txtCoinCount.Name = "txtCoinCount";
            this.txtCoinCount.ReadOnly = true;
            this.txtCoinCount.Size = new System.Drawing.Size(100, 23);
            this.txtCoinCount.TabIndex = 3;
            this.txtCoinCount.Text = "0";
            this.txtCoinCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCoins
            // 
            this.lblCoins.AutoSize = true;
            this.lblCoins.Font = new System.Drawing.Font("Calibri", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoins.Location = new System.Drawing.Point(12, 374);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(69, 15);
            this.lblCoins.TabIndex = 4;
            this.lblCoins.Text = "Coin count:";
            // 
            // lblPickCount
            // 
            this.lblPickCount.AutoSize = true;
            this.lblPickCount.Font = new System.Drawing.Font("Calibri", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPickCount.Location = new System.Drawing.Point(13, 13);
            this.lblPickCount.Name = "lblPickCount";
            this.lblPickCount.Size = new System.Drawing.Size(90, 15);
            this.lblPickCount.TabIndex = 5;
            this.lblPickCount.Text = "Orders Picked: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 616);
            this.Controls.Add(this.lblPickCount);
            this.Controls.Add(this.lblCoins);
            this.Controls.Add(this.txtCoinCount);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lstPickRewards);
            this.Controls.Add(this.btnPick);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPick;
        private System.Windows.Forms.ListBox lstPickRewards;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtCoinCount;
        private System.Windows.Forms.Label lblCoins;
        private System.Windows.Forms.Label lblPickCount;
    }
}

