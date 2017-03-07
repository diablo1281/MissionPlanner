namespace MissionPlanner
{
    partial class SAE_package_setting
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
            this.area_box = new System.Windows.Forms.NumericUpDown();
            this.myLabel4 = new MissionPlanner.Controls.MyLabel();
            this.weight_box = new System.Windows.Forms.NumericUpDown();
            this.myLabel3 = new MissionPlanner.Controls.MyLabel();
            this.air_box = new System.Windows.Forms.NumericUpDown();
            this.myLabel2 = new MissionPlanner.Controls.MyLabel();
            this.drag_box = new System.Windows.Forms.NumericUpDown();
            this.myLabel1 = new MissionPlanner.Controls.MyLabel();
            this.apply_button = new MissionPlanner.Controls.MyButton();
            this.cancel_button = new MissionPlanner.Controls.MyButton();
            ((System.ComponentModel.ISupportInitialize)(this.area_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weight_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.air_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drag_box)).BeginInit();
            this.SuspendLayout();
            // 
            // area_box
            // 
            this.area_box.DecimalPlaces = 3;
            this.area_box.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.area_box.Location = new System.Drawing.Point(106, 102);
            this.area_box.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.area_box.Name = "area_box";
            this.area_box.Size = new System.Drawing.Size(80, 20);
            this.area_box.TabIndex = 15;
            // 
            // myLabel4
            // 
            this.myLabel4.Location = new System.Drawing.Point(12, 99);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.resize = false;
            this.myLabel4.Size = new System.Drawing.Size(88, 23);
            this.myLabel4.TabIndex = 14;
            this.myLabel4.Text = "Area";
            // 
            // weight_box
            // 
            this.weight_box.DecimalPlaces = 3;
            this.weight_box.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.weight_box.Location = new System.Drawing.Point(106, 73);
            this.weight_box.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.weight_box.Name = "weight_box";
            this.weight_box.Size = new System.Drawing.Size(80, 20);
            this.weight_box.TabIndex = 13;
            // 
            // myLabel3
            // 
            this.myLabel3.Location = new System.Drawing.Point(12, 70);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.resize = false;
            this.myLabel3.Size = new System.Drawing.Size(88, 23);
            this.myLabel3.TabIndex = 12;
            this.myLabel3.Text = "Weigth";
            // 
            // air_box
            // 
            this.air_box.DecimalPlaces = 3;
            this.air_box.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.air_box.Location = new System.Drawing.Point(106, 44);
            this.air_box.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.air_box.Name = "air_box";
            this.air_box.Size = new System.Drawing.Size(80, 20);
            this.air_box.TabIndex = 11;
            // 
            // myLabel2
            // 
            this.myLabel2.Location = new System.Drawing.Point(12, 41);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.resize = false;
            this.myLabel2.Size = new System.Drawing.Size(88, 23);
            this.myLabel2.TabIndex = 10;
            this.myLabel2.Text = "Air density";
            // 
            // drag_box
            // 
            this.drag_box.DecimalPlaces = 3;
            this.drag_box.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.drag_box.Location = new System.Drawing.Point(106, 15);
            this.drag_box.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.drag_box.Name = "drag_box";
            this.drag_box.Size = new System.Drawing.Size(80, 20);
            this.drag_box.TabIndex = 9;
            // 
            // myLabel1
            // 
            this.myLabel1.Location = new System.Drawing.Point(12, 12);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.resize = false;
            this.myLabel1.Size = new System.Drawing.Size(88, 23);
            this.myLabel1.TabIndex = 8;
            this.myLabel1.Text = "Drag coefficient";
            // 
            // apply_button
            // 
            this.apply_button.Location = new System.Drawing.Point(116, 226);
            this.apply_button.Name = "apply_button";
            this.apply_button.Size = new System.Drawing.Size(75, 23);
            this.apply_button.TabIndex = 16;
            this.apply_button.Text = "Apply";
            this.apply_button.UseVisualStyleBackColor = true;
            this.apply_button.Click += new System.EventHandler(this.apply_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(197, 226);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 17;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // SAE_package_setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.apply_button);
            this.Controls.Add(this.area_box);
            this.Controls.Add(this.myLabel4);
            this.Controls.Add(this.weight_box);
            this.Controls.Add(this.myLabel3);
            this.Controls.Add(this.air_box);
            this.Controls.Add(this.myLabel2);
            this.Controls.Add(this.drag_box);
            this.Controls.Add(this.myLabel1);
            this.Name = "SAE_package_setting";
            this.Text = "SAE_package_setting";
            ((System.ComponentModel.ISupportInitialize)(this.area_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weight_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.air_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drag_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MyLabel myLabel1;
        private System.Windows.Forms.NumericUpDown drag_box;
        private Controls.MyLabel myLabel2;
        private System.Windows.Forms.NumericUpDown air_box;
        private Controls.MyLabel myLabel3;
        private System.Windows.Forms.NumericUpDown weight_box;
        private Controls.MyLabel myLabel4;
        private System.Windows.Forms.NumericUpDown area_box;
        private Controls.MyButton apply_button;
        private Controls.MyButton cancel_button;
    }
}