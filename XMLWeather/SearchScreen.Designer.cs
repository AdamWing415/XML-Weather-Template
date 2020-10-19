namespace XMLWeather
{
    partial class SearchScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchScreen));
            this.searchLabel = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.todayLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sugestLabel = new System.Windows.Forms.Label();
            this.StratfordLabel = new System.Windows.Forms.Label();
            this.WaterlooLabel = new System.Windows.Forms.Label();
            this.LondonLabel = new System.Windows.Forms.Label();
            this.TorontoLabel = new System.Windows.Forms.Label();
            this.NiagaraLabel = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // searchLabel
            // 
            this.searchLabel.BackColor = System.Drawing.Color.Transparent;
            this.searchLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ForeColor = System.Drawing.Color.White;
            this.searchLabel.Image = ((System.Drawing.Image)(resources.GetObject("searchLabel.Image")));
            this.searchLabel.Location = new System.Drawing.Point(223, 12);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(110, 34);
            this.searchLabel.TabIndex = 89;
            this.searchLabel.Text = "Search";
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Image = ((System.Drawing.Image)(resources.GetObject("forecastLabel.Image")));
            this.forecastLabel.Location = new System.Drawing.Point(117, 12);
            this.forecastLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(110, 34);
            this.forecastLabel.TabIndex = 87;
            this.forecastLabel.Text = "5 Day";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // todayLabel
            // 
            this.todayLabel.BackColor = System.Drawing.Color.Transparent;
            this.todayLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayLabel.ForeColor = System.Drawing.Color.White;
            this.todayLabel.Image = ((System.Drawing.Image)(resources.GetObject("todayLabel.Image")));
            this.todayLabel.Location = new System.Drawing.Point(9, 12);
            this.todayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(110, 34);
            this.todayLabel.TabIndex = 86;
            this.todayLabel.Text = "Today";
            this.todayLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(213, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 33);
            this.label5.TabIndex = 88;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 74);
            this.label2.TabIndex = 90;
            // 
            // sugestLabel
            // 
            this.sugestLabel.BackColor = System.Drawing.Color.Transparent;
            this.sugestLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sugestLabel.ForeColor = System.Drawing.Color.White;
            this.sugestLabel.Location = new System.Drawing.Point(9, 246);
            this.sugestLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sugestLabel.Name = "sugestLabel";
            this.sugestLabel.Size = new System.Drawing.Size(268, 34);
            this.sugestLabel.TabIndex = 91;
            this.sugestLabel.Text = "Suggested Locations:";
            // 
            // StratfordLabel
            // 
            this.StratfordLabel.BackColor = System.Drawing.Color.Transparent;
            this.StratfordLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StratfordLabel.ForeColor = System.Drawing.Color.White;
            this.StratfordLabel.Location = new System.Drawing.Point(10, 292);
            this.StratfordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StratfordLabel.Name = "StratfordLabel";
            this.StratfordLabel.Size = new System.Drawing.Size(267, 34);
            this.StratfordLabel.TabIndex = 92;
            this.StratfordLabel.Text = "- Stratford";
            this.StratfordLabel.Click += new System.EventHandler(this.StratfordLabel_Click);
            // 
            // WaterlooLabel
            // 
            this.WaterlooLabel.BackColor = System.Drawing.Color.Transparent;
            this.WaterlooLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaterlooLabel.ForeColor = System.Drawing.Color.White;
            this.WaterlooLabel.Location = new System.Drawing.Point(9, 331);
            this.WaterlooLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WaterlooLabel.Name = "WaterlooLabel";
            this.WaterlooLabel.Size = new System.Drawing.Size(268, 34);
            this.WaterlooLabel.TabIndex = 93;
            this.WaterlooLabel.Text = "- Waterloo";
            this.WaterlooLabel.Click += new System.EventHandler(this.WaterlooLabel_Click);
            // 
            // LondonLabel
            // 
            this.LondonLabel.BackColor = System.Drawing.Color.Transparent;
            this.LondonLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LondonLabel.ForeColor = System.Drawing.Color.White;
            this.LondonLabel.Location = new System.Drawing.Point(9, 370);
            this.LondonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LondonLabel.Name = "LondonLabel";
            this.LondonLabel.Size = new System.Drawing.Size(268, 34);
            this.LondonLabel.TabIndex = 94;
            this.LondonLabel.Text = "- London";
            this.LondonLabel.Click += new System.EventHandler(this.LondonLabel_Click);
            // 
            // TorontoLabel
            // 
            this.TorontoLabel.BackColor = System.Drawing.Color.Transparent;
            this.TorontoLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TorontoLabel.ForeColor = System.Drawing.Color.White;
            this.TorontoLabel.Location = new System.Drawing.Point(9, 409);
            this.TorontoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TorontoLabel.Name = "TorontoLabel";
            this.TorontoLabel.Size = new System.Drawing.Size(268, 34);
            this.TorontoLabel.TabIndex = 95;
            this.TorontoLabel.Text = "- Toronto";
            this.TorontoLabel.Click += new System.EventHandler(this.TorontoLabel_Click);
            // 
            // NiagaraLabel
            // 
            this.NiagaraLabel.BackColor = System.Drawing.Color.Transparent;
            this.NiagaraLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NiagaraLabel.ForeColor = System.Drawing.Color.White;
            this.NiagaraLabel.Location = new System.Drawing.Point(9, 448);
            this.NiagaraLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NiagaraLabel.Name = "NiagaraLabel";
            this.NiagaraLabel.Size = new System.Drawing.Size(268, 34);
            this.NiagaraLabel.TabIndex = 96;
            this.NiagaraLabel.Text = "- Niagara";
            this.NiagaraLabel.Click += new System.EventHandler(this.NiagaraLabel_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.Color.White;
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBox.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.ForeColor = System.Drawing.Color.DimGray;
            this.SearchBox.Location = new System.Drawing.Point(15, 216);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(303, 29);
            this.SearchBox.TabIndex = 97;
            this.SearchBox.Text = " Search Cities";
            this.SearchBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SearchBox_MouseClick);
            // 
            // SearchPicBox
            // 
            this.SearchPicBox.BackColor = System.Drawing.Color.White;
            this.SearchPicBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchPicBox.BackgroundImage")));
            this.SearchPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchPicBox.Location = new System.Drawing.Point(291, 218);
            this.SearchPicBox.Name = "SearchPicBox";
            this.SearchPicBox.Size = new System.Drawing.Size(25, 25);
            this.SearchPicBox.TabIndex = 98;
            this.SearchPicBox.TabStop = false;
            this.SearchPicBox.Click += new System.EventHandler(this.SearchPicBox_Click);
            // 
            // SearchScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::XMLWeather.Properties.Resources.clear;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.SearchPicBox);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.NiagaraLabel);
            this.Controls.Add(this.TorontoLabel);
            this.Controls.Add(this.LondonLabel);
            this.Controls.Add(this.WaterlooLabel);
            this.Controls.Add(this.StratfordLabel);
            this.Controls.Add(this.sugestLabel);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.todayLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Name = "SearchScreen";
            this.Size = new System.Drawing.Size(333, 492);
            ((System.ComponentModel.ISupportInitialize)(this.SearchPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sugestLabel;
        private System.Windows.Forms.Label StratfordLabel;
        private System.Windows.Forms.Label WaterlooLabel;
        private System.Windows.Forms.Label LondonLabel;
        private System.Windows.Forms.Label TorontoLabel;
        private System.Windows.Forms.Label NiagaraLabel;
        private System.Windows.Forms.PictureBox SearchPicBox;
        public System.Windows.Forms.TextBox SearchBox;
    }
}
