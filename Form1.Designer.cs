namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btnCount = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCountResult = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.RichTextBox();
            this.btnCancle = new System.Windows.Forms.Button();
            this.txtTimersss = new System.Windows.Forms.RichTextBox();
            this.txtException = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(201, 85);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(138, 40);
            this.btnCount.TabIndex = 1;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.BtnCount_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 2;
            // 
            // txtCountResult
            // 
            this.txtCountResult.Location = new System.Drawing.Point(356, 93);
            this.txtCountResult.Name = "txtCountResult";
            this.txtCountResult.Size = new System.Drawing.Size(186, 22);
            this.txtCountResult.TabIndex = 4;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(201, 156);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(457, 67);
            this.txtArea.TabIndex = 6;
            this.txtArea.Text = "";
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(565, 86);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(93, 39);
            this.btnCancle.TabIndex = 7;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.BtnCancle_Click);
            // 
            // txtTimersss
            // 
            this.txtTimersss.Location = new System.Drawing.Point(201, 249);
            this.txtTimersss.Name = "txtTimersss";
            this.txtTimersss.Size = new System.Drawing.Size(457, 67);
            this.txtTimersss.TabIndex = 8;
            this.txtTimersss.Text = "";
            // 
            // txtException
            // 
            this.txtException.Location = new System.Drawing.Point(201, 336);
            this.txtException.Name = "txtException";
            this.txtException.Size = new System.Drawing.Size(457, 67);
            this.txtException.TabIndex = 9;
            this.txtException.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtException);
            this.Controls.Add(this.txtTimersss);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtCountResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCountResult;
        private System.Windows.Forms.RichTextBox txtArea;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.RichTextBox txtTimersss;
        private System.Windows.Forms.RichTextBox txtException;
    }
}

