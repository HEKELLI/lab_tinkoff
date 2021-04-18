namespace CurRate
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.but_connect = new System.Windows.Forms.Button();
            this.text_box_token = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.but_form_portfolio = new System.Windows.Forms.Button();
            this.but_stocks = new System.Windows.Forms.Button();
            this.but_bonds = new System.Windows.Forms.Button();
            this.but_etfs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_connect
            // 
            this.but_connect.Location = new System.Drawing.Point(563, 9);
            this.but_connect.Name = "but_connect";
            this.but_connect.Size = new System.Drawing.Size(75, 23);
            this.but_connect.TabIndex = 0;
            this.but_connect.Text = "Connect";
            this.but_connect.UseVisualStyleBackColor = true;
            this.but_connect.Click += new System.EventHandler(this.but_connect_Click);
            // 
            // text_box_token
            // 
            this.text_box_token.Location = new System.Drawing.Point(12, 12);
            this.text_box_token.Name = "text_box_token";
            this.text_box_token.Size = new System.Drawing.Size(545, 20);
            this.text_box_token.TabIndex = 1;
            this.text_box_token.Text = "Введите токен для подключения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Статус подключения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Отключён";
            // 
            // but_form_portfolio
            // 
            this.but_form_portfolio.Location = new System.Drawing.Point(12, 78);
            this.but_form_portfolio.Name = "but_form_portfolio";
            this.but_form_portfolio.Size = new System.Drawing.Size(145, 23);
            this.but_form_portfolio.TabIndex = 4;
            this.but_form_portfolio.Text = "Портфолио";
            this.but_form_portfolio.UseVisualStyleBackColor = true;
            this.but_form_portfolio.Click += new System.EventHandler(this.but_form_portfolio_Click);
            // 
            // but_stocks
            // 
            this.but_stocks.Location = new System.Drawing.Point(12, 107);
            this.but_stocks.Name = "but_stocks";
            this.but_stocks.Size = new System.Drawing.Size(145, 23);
            this.but_stocks.TabIndex = 5;
            this.but_stocks.Text = "Акции";
            this.but_stocks.UseVisualStyleBackColor = true;
            this.but_stocks.Click += new System.EventHandler(this.but_stocks_Click);
            // 
            // but_bonds
            // 
            this.but_bonds.Location = new System.Drawing.Point(12, 136);
            this.but_bonds.Name = "but_bonds";
            this.but_bonds.Size = new System.Drawing.Size(145, 23);
            this.but_bonds.TabIndex = 6;
            this.but_bonds.Text = "Облигации";
            this.but_bonds.UseVisualStyleBackColor = true;
            this.but_bonds.Click += new System.EventHandler(this.but_bonds_Click);
            // 
            // but_etfs
            // 
            this.but_etfs.Location = new System.Drawing.Point(12, 165);
            this.but_etfs.Name = "but_etfs";
            this.but_etfs.Size = new System.Drawing.Size(145, 23);
            this.but_etfs.TabIndex = 7;
            this.but_etfs.Text = "ETF";
            this.but_etfs.UseVisualStyleBackColor = true;
            this.but_etfs.Click += new System.EventHandler(this.but_etfs_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(650, 203);
            this.Controls.Add(this.but_etfs);
            this.Controls.Add(this.but_bonds);
            this.Controls.Add(this.but_stocks);
            this.Controls.Add(this.but_form_portfolio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_box_token);
            this.Controls.Add(this.but_connect);
            this.Name = "MainForm";
            this.Text = "Главное меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_connect;
        private System.Windows.Forms.TextBox text_box_token;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button but_form_portfolio;
        private System.Windows.Forms.Button but_stocks;
        private System.Windows.Forms.Button but_bonds;
        private System.Windows.Forms.Button but_etfs;
    }
}

