namespace VehicleSystem
{
    partial class VehicleSystemUi
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
            this.vehicleNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.regNoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.minSpeedTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maxSpeedTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.averageSpeedTextBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.enterButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.vehicleListView = new System.Windows.Forms.ListView();
            this.vehicleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.regNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.averageSpeed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.showListButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.vehicleNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle Name";
            // 
            // vehicleNameTextBox
            // 
            this.vehicleNameTextBox.Location = new System.Drawing.Point(91, 33);
            this.vehicleNameTextBox.Name = "vehicleNameTextBox";
            this.vehicleNameTextBox.Size = new System.Drawing.Size(117, 20);
            this.vehicleNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Reg. No";
            // 
            // regNoTextBox
            // 
            this.regNoTextBox.Location = new System.Drawing.Point(91, 84);
            this.regNoTextBox.Name = "regNoTextBox";
            this.regNoTextBox.Size = new System.Drawing.Size(117, 20);
            this.regNoTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Speed";
            // 
            // speedTextBox
            // 
            this.speedTextBox.Location = new System.Drawing.Point(91, 152);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.Size = new System.Drawing.Size(100, 20);
            this.speedTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Min Speed";
            // 
            // minSpeedTextBox
            // 
            this.minSpeedTextBox.Location = new System.Drawing.Point(91, 194);
            this.minSpeedTextBox.Name = "minSpeedTextBox";
            this.minSpeedTextBox.Size = new System.Drawing.Size(100, 20);
            this.minSpeedTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Max Speed";
            // 
            // maxSpeedTextBox
            // 
            this.maxSpeedTextBox.Location = new System.Drawing.Point(91, 221);
            this.maxSpeedTextBox.Name = "maxSpeedTextBox";
            this.maxSpeedTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxSpeedTextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Average Speed";
            // 
            // averageSpeedTextBox
            // 
            this.averageSpeedTextBox.Location = new System.Drawing.Point(91, 256);
            this.averageSpeedTextBox.Name = "averageSpeedTextBox";
            this.averageSpeedTextBox.Size = new System.Drawing.Size(100, 20);
            this.averageSpeedTextBox.TabIndex = 1;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(261, 81);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(261, 152);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 2;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(261, 218);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 2;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kilo/Hour";
            // 
            // vehicleListView
            // 
            this.vehicleListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.vehicleName,
            this.regNo,
            this.averageSpeed});
            this.vehicleListView.Location = new System.Drawing.Point(368, 81);
            this.vehicleListView.Name = "vehicleListView";
            this.vehicleListView.Size = new System.Drawing.Size(319, 195);
            this.vehicleListView.TabIndex = 3;
            this.vehicleListView.UseCompatibleStateImageBehavior = false;
            this.vehicleListView.View = System.Windows.Forms.View.Details;
            // 
            // vehicleName
            // 
            this.vehicleName.Text = "Vehicle Name";
            this.vehicleName.Width = 81;
            // 
            // regNo
            // 
            this.regNo.Text = "Refistration Number";
            this.regNo.Width = 106;
            // 
            // averageSpeed
            // 
            this.averageSpeed.Text = "AverageSpeed";
            this.averageSpeed.Width = 90;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(368, 14);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(238, 20);
            this.searchTextBox.TabIndex = 5;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(612, 12);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // showListButton
            // 
            this.showListButton.Location = new System.Drawing.Point(486, 52);
            this.showListButton.Name = "showListButton";
            this.showListButton.Size = new System.Drawing.Size(75, 23);
            this.showListButton.TabIndex = 2;
            this.showListButton.Text = "Show List";
            this.showListButton.UseVisualStyleBackColor = true;
            this.showListButton.Click += new System.EventHandler(this.showListButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Enter Speed Value for ";
            // 
            // vehicleNameLabel
            // 
            this.vehicleNameLabel.AutoSize = true;
            this.vehicleNameLabel.Location = new System.Drawing.Point(136, 127);
            this.vehicleNameLabel.Name = "vehicleNameLabel";
            this.vehicleNameLabel.Size = new System.Drawing.Size(0, 13);
            this.vehicleNameLabel.TabIndex = 8;
            // 
            // VehicleSystemUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 308);
            this.Controls.Add(this.vehicleNameLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.vehicleListView);
            this.Controls.Add(this.showListButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.averageSpeedTextBox);
            this.Controls.Add(this.maxSpeedTextBox);
            this.Controls.Add(this.minSpeedTextBox);
            this.Controls.Add(this.speedTextBox);
            this.Controls.Add(this.regNoTextBox);
            this.Controls.Add(this.vehicleNameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VehicleSystemUi";
            this.Text = "Vehicle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vehicleNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox regNoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox minSpeedTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox maxSpeedTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox averageSpeedTextBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView vehicleListView;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ColumnHeader vehicleName;
        private System.Windows.Forms.ColumnHeader regNo;
        private System.Windows.Forms.ColumnHeader averageSpeed;
        private System.Windows.Forms.Button showListButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label vehicleNameLabel;
    }
}

