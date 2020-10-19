namespace XMLWeather
{
    partial class CurrentScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentScreen));
            this.cityOutput = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.currentOutput = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.conditionLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.humidValueLabel = new System.Windows.Forms.Label();
            this.humidityLabel = new System.Windows.Forms.Label();
            this.windLabel = new System.Windows.Forms.Label();
            this.windOutputLabel = new System.Windows.Forms.Label();
            this.updateLabel = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.White;
            this.cityOutput.Location = new System.Drawing.Point(13, 69);
            this.cityOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(301, 47);
            this.cityOutput.TabIndex = 22;
            this.cityOutput.Text = "City";
            // 
            // maxOutput
            // 
            this.maxOutput.BackColor = System.Drawing.Color.Transparent;
            this.maxOutput.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxOutput.ForeColor = System.Drawing.Color.Red;
            this.maxOutput.Location = new System.Drawing.Point(250, 107);
            this.maxOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(112, 51);
            this.maxOutput.TabIndex = 32;
            this.maxOutput.Text = "77\'";
            // 
            // minOutput
            // 
            this.minOutput.BackColor = System.Drawing.Color.Transparent;
            this.minOutput.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minOutput.ForeColor = System.Drawing.Color.Turquoise;
            this.minOutput.Location = new System.Drawing.Point(250, 150);
            this.minOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(112, 50);
            this.minOutput.TabIndex = 30;
            this.minOutput.Text = "77\'";
            // 
            // currentOutput
            // 
            this.currentOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentOutput.Font = new System.Drawing.Font("Century Gothic", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentOutput.ForeColor = System.Drawing.Color.Goldenrod;
            this.currentOutput.Location = new System.Drawing.Point(46, 109);
            this.currentOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentOutput.Name = "currentOutput";
            this.currentOutput.Size = new System.Drawing.Size(196, 84);
            this.currentOutput.TabIndex = 28;
            this.currentOutput.Text = "15\'C";
            this.currentOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(8, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 34);
            this.label3.TabIndex = 40;
            this.label3.Text = "Today";
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
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "5 Day";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(-7, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 33);
            this.label1.TabIndex = 64;
            this.label1.Text = "____________________________";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // conditionLabel
            // 
            this.conditionLabel.BackColor = System.Drawing.Color.Transparent;
            this.conditionLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionLabel.ForeColor = System.Drawing.Color.White;
            this.conditionLabel.Location = new System.Drawing.Point(212, 206);
            this.conditionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conditionLabel.Name = "conditionLabel";
            this.conditionLabel.Size = new System.Drawing.Size(127, 50);
            this.conditionLabel.TabIndex = 65;
            this.conditionLabel.Text = "Thunder";
            this.conditionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(-6, -5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 74);
            this.label2.TabIndex = 66;
            // 
            // humidValueLabel
            // 
            this.humidValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.humidValueLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidValueLabel.ForeColor = System.Drawing.Color.White;
            this.humidValueLabel.Location = new System.Drawing.Point(212, 325);
            this.humidValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.humidValueLabel.Name = "humidValueLabel";
            this.humidValueLabel.Size = new System.Drawing.Size(119, 40);
            this.humidValueLabel.TabIndex = 67;
            this.humidValueLabel.Text = "Hum%";
            this.humidValueLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // humidityLabel
            // 
            this.humidityLabel.BackColor = System.Drawing.Color.Transparent;
            this.humidityLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidityLabel.ForeColor = System.Drawing.Color.White;
            this.humidityLabel.Location = new System.Drawing.Point(13, 325);
            this.humidityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.humidityLabel.Name = "humidityLabel";
            this.humidityLabel.Size = new System.Drawing.Size(164, 40);
            this.humidityLabel.TabIndex = 68;
            this.humidityLabel.Text = "Humidity:";
            // 
            // windLabel
            // 
            this.windLabel.BackColor = System.Drawing.Color.Transparent;
            this.windLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windLabel.ForeColor = System.Drawing.Color.White;
            this.windLabel.Location = new System.Drawing.Point(13, 385);
            this.windLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.windLabel.Name = "windLabel";
            this.windLabel.Size = new System.Drawing.Size(164, 40);
            this.windLabel.TabIndex = 69;
            this.windLabel.Text = "Wind:";
            // 
            // windOutputLabel
            // 
            this.windOutputLabel.BackColor = System.Drawing.Color.Transparent;
            this.windOutputLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windOutputLabel.ForeColor = System.Drawing.Color.White;
            this.windOutputLabel.Location = new System.Drawing.Point(106, 385);
            this.windOutputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.windOutputLabel.Name = "windOutputLabel";
            this.windOutputLabel.Size = new System.Drawing.Size(225, 40);
            this.windOutputLabel.TabIndex = 70;
            this.windOutputLabel.Text = "Speed Dir";
            this.windOutputLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // updateLabel
            // 
            this.updateLabel.BackColor = System.Drawing.Color.Transparent;
            this.updateLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateLabel.ForeColor = System.Drawing.Color.White;
            this.updateLabel.Location = new System.Drawing.Point(4, 425);
            this.updateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.updateLabel.Name = "updateLabel";
            this.updateLabel.Size = new System.Drawing.Size(325, 67);
            this.updateLabel.TabIndex = 71;
            this.updateLabel.Text = "Last Updated:";
            this.updateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.searchLabel.TabIndex = 72;
            this.searchLabel.Text = "Search";
            this.searchLabel.Click += new System.EventHandler(this.searchLabel_Click);
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::XMLWeather.Properties.Resources.foggy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.updateLabel);
            this.Controls.Add(this.windOutputLabel);
            this.Controls.Add(this.windLabel);
            this.Controls.Add(this.humidityLabel);
            this.Controls.Add(this.humidValueLabel);
            this.Controls.Add(this.conditionLabel);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.currentOutput);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(333, 492);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label currentOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label conditionLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label humidValueLabel;
        private System.Windows.Forms.Label humidityLabel;
        private System.Windows.Forms.Label windLabel;
        private System.Windows.Forms.Label windOutputLabel;
        private System.Windows.Forms.Label updateLabel;
        private System.Windows.Forms.Label searchLabel;
    }
}
