namespace Ch4Case3_Moon
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.summaryButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.invisibleRadioButton = new System.Windows.Forms.RadioButton();
            this.blueRadioButton = new System.Windows.Forms.RadioButton();
            this.dvdRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.memberCheckBox = new System.Windows.Forms.CheckBox();
            this.newReleaseCheckBox = new System.Windows.Forms.CheckBox();
            this.totalTExtBox = new System.Windows.Forms.TextBox();
            this.subtotalTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(435, 60);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(137, 29);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(435, 104);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(137, 33);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear for next item";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.Enabled = false;
            this.orderButton.Location = new System.Drawing.Point(435, 153);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(138, 32);
            this.orderButton.TabIndex = 2;
            this.orderButton.Text = "Order Complete";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // summaryButton
            // 
            this.summaryButton.Enabled = false;
            this.summaryButton.Location = new System.Drawing.Point(435, 201);
            this.summaryButton.Name = "summaryButton";
            this.summaryButton.Size = new System.Drawing.Size(137, 32);
            this.summaryButton.TabIndex = 3;
            this.summaryButton.Text = "Summary";
            this.summaryButton.UseVisualStyleBackColor = true;
            this.summaryButton.Click += new System.EventHandler(this.summaryButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.ForeColor = System.Drawing.Color.Red;
            this.exitButton.Location = new System.Drawing.Point(253, 265);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(350, 171);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.invisibleRadioButton);
            this.groupBox1.Controls.Add(this.blueRadioButton);
            this.groupBox1.Controls.Add(this.dvdRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(54, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 173);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Format";
            // 
            // invisibleRadioButton
            // 
            this.invisibleRadioButton.AutoSize = true;
            this.invisibleRadioButton.Checked = true;
            this.invisibleRadioButton.Location = new System.Drawing.Point(101, 65);
            this.invisibleRadioButton.Name = "invisibleRadioButton";
            this.invisibleRadioButton.Size = new System.Drawing.Size(14, 13);
            this.invisibleRadioButton.TabIndex = 2;
            this.invisibleRadioButton.TabStop = true;
            this.invisibleRadioButton.UseVisualStyleBackColor = true;
            this.invisibleRadioButton.Visible = false;
            this.invisibleRadioButton.CheckedChanged += new System.EventHandler(this.invisibleRadioButton_CheckedChanged);
            // 
            // blueRadioButton
            // 
            this.blueRadioButton.AutoSize = true;
            this.blueRadioButton.Location = new System.Drawing.Point(28, 99);
            this.blueRadioButton.Name = "blueRadioButton";
            this.blueRadioButton.Size = new System.Drawing.Size(68, 17);
            this.blueRadioButton.TabIndex = 1;
            this.blueRadioButton.TabStop = true;
            this.blueRadioButton.Text = "Blue-Ray";
            this.blueRadioButton.UseVisualStyleBackColor = true;
            // 
            // dvdRadioButton
            // 
            this.dvdRadioButton.AutoSize = true;
            this.dvdRadioButton.Location = new System.Drawing.Point(28, 42);
            this.dvdRadioButton.Name = "dvdRadioButton";
            this.dvdRadioButton.Size = new System.Drawing.Size(48, 17);
            this.dvdRadioButton.TabIndex = 0;
            this.dvdRadioButton.TabStop = true;
            this.dvdRadioButton.Text = "DVD";
            this.dvdRadioButton.UseVisualStyleBackColor = true;
            this.dvdRadioButton.CheckedChanged += new System.EventHandler(this.dvdRadioButton_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.memberCheckBox);
            this.groupBox2.Controls.Add(this.newReleaseCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(241, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(121, 173);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // memberCheckBox
            // 
            this.memberCheckBox.AutoSize = true;
            this.memberCheckBox.Location = new System.Drawing.Point(29, 89);
            this.memberCheckBox.Name = "memberCheckBox";
            this.memberCheckBox.Size = new System.Drawing.Size(64, 17);
            this.memberCheckBox.TabIndex = 1;
            this.memberCheckBox.Text = "Member";
            this.memberCheckBox.UseVisualStyleBackColor = true;
            // 
            // newReleaseCheckBox
            // 
            this.newReleaseCheckBox.AutoSize = true;
            this.newReleaseCheckBox.Location = new System.Drawing.Point(27, 41);
            this.newReleaseCheckBox.Name = "newReleaseCheckBox";
            this.newReleaseCheckBox.Size = new System.Drawing.Size(90, 17);
            this.newReleaseCheckBox.TabIndex = 0;
            this.newReleaseCheckBox.Text = "New Release";
            this.newReleaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // totalTExtBox
            // 
            this.totalTExtBox.Location = new System.Drawing.Point(113, 262);
            this.totalTExtBox.Name = "totalTExtBox";
            this.totalTExtBox.Size = new System.Drawing.Size(100, 20);
            this.totalTExtBox.TabIndex = 7;
            // 
            // subtotalTextBox
            // 
            this.subtotalTextBox.Location = new System.Drawing.Point(113, 378);
            this.subtotalTextBox.Name = "subtotalTextBox";
            this.subtotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.subtotalTextBox.TabIndex = 8;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(126, 33);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 9;
            this.nameTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Subtotal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Movie name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(615, 448);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.subtotalTextBox);
            this.Controls.Add(this.totalTExtBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.summaryButton);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button summaryButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton blueRadioButton;
        private System.Windows.Forms.RadioButton dvdRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox memberCheckBox;
        private System.Windows.Forms.CheckBox newReleaseCheckBox;
        private System.Windows.Forms.TextBox totalTExtBox;
        private System.Windows.Forms.TextBox subtotalTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton invisibleRadioButton;
    }
}

