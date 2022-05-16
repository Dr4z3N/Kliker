namespace Clicker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.upgradeButton = new System.Windows.Forms.Button();
            this.buttonLevelTextBox = new System.Windows.Forms.TextBox();
            this.frequencyammount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.frequency = new System.Windows.Forms.Button();
            this.quantity = new System.Windows.Forms.Button();
            this.quantityammount = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.BlueViolet;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // upgradeButton
            // 
            resources.ApplyResources(this.upgradeButton, "upgradeButton");
            this.upgradeButton.BackColor = System.Drawing.Color.LimeGreen;
            this.upgradeButton.ForeColor = System.Drawing.Color.BlueViolet;
            this.upgradeButton.Name = "upgradeButton";
            this.upgradeButton.UseVisualStyleBackColor = false;
            this.upgradeButton.Click += new System.EventHandler(this.UpgradeButton_Click);
            // 
            // buttonLevelTextBox
            // 
            resources.ApplyResources(this.buttonLevelTextBox, "buttonLevelTextBox");
            this.buttonLevelTextBox.Name = "buttonLevelTextBox";
            this.buttonLevelTextBox.ReadOnly = true;
            // 
            // frequencyammount
            // 
            resources.ApplyResources(this.frequencyammount, "frequencyammount");
            this.frequencyammount.Name = "frequencyammount";
            this.frequencyammount.ReadOnly = true;
            this.frequencyammount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.BlueViolet;
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // frequency
            // 
            resources.ApplyResources(this.frequency, "frequency");
            this.frequency.Name = "frequency";
            this.frequency.UseVisualStyleBackColor = true;
            this.frequency.Click += new System.EventHandler(this.A1UpgradeInterval_Click);
            // 
            // quantity
            // 
            resources.ApplyResources(this.quantity, "quantity");
            this.quantity.Name = "quantity";
            this.quantity.UseVisualStyleBackColor = true;
            this.quantity.Click += new System.EventHandler(this.A1UpgradeAmount_Click);
            // 
            // quantityammount
            // 
            resources.ApplyResources(this.quantityammount, "quantityammount");
            this.quantityammount.Name = "quantityammount";
            this.quantityammount.ReadOnly = true;
            this.quantityammount.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Title
            // 
            resources.ApplyResources(this.Title, "Title");
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.ForeColor = System.Drawing.Color.BlueViolet;
            this.Title.Name = "Title";
            this.Title.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Title);
            this.Controls.Add(this.quantityammount);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.frequency);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.frequencyammount);
            this.Controls.Add(this.buttonLevelTextBox);
            this.Controls.Add(this.upgradeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Button upgradeButton;
        private TextBox buttonLevelTextBox;
        private TextBox frequencyammount;
        private Label label2;
        private Button frequency;
        private Button quantity;
        private TextBox quantityammount;
        private Label Title;
    }
}