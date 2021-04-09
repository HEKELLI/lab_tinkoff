
namespace CurRate
{
    partial class PortfolioForm
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
            this.but_main_form = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_main_form
            // 
            this.but_main_form.Location = new System.Drawing.Point(12, 12);
            this.but_main_form.Name = "but_main_form";
            this.but_main_form.Size = new System.Drawing.Size(75, 23);
            this.but_main_form.TabIndex = 0;
            this.but_main_form.Text = "На главную";
            this.but_main_form.UseVisualStyleBackColor = true;
            this.but_main_form.Click += new System.EventHandler(this.but_main_form_Click);
            // 
            // PortfolioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.but_main_form);
            this.Name = "PortfolioForm";
            this.Text = "PortfolioForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_main_form;
    }
}