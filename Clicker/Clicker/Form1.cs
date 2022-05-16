namespace Clicker
{
    public partial class Form1 : Form
    {
        int cash;
        int buttonLevel;
        int A1Ammount;
        int A1Interval;
        public Form1()
        {
            InitializeComponent();
            cash = 0;
            buttonLevel = 1;
            A1Ammount = 10;
            A1Interval = 0;
            frequencyammount.Text = A1Ammount.ToString();
            quantityammount.Text = A1Interval.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            cash += (int)Math.Pow(10, buttonLevel-1);
            label1.Text = "Wy³udzony Hajs z Podatków: $"+cash.ToString();
        }

        private void UpgradeButton_Click(object sender, EventArgs e)
        {
            int upgradeCost = (int)Math.Pow(10, buttonLevel);
            if (cash >= upgradeCost)
            {
                buttonLevel++;
                buttonLevelTextBox.Text = buttonLevel.ToString();
                cash -= upgradeCost;
                label1.Text = "Wy³udzony Hajs z Podatków: $" + cash.ToString();
                string nextUpgradeCost = "($" + Math.Pow(10, buttonLevel).ToString() + ")";
                upgradeButton.Text = "Upgrade\n" + nextUpgradeCost;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void A1UpgradeAmount_Click(object sender, EventArgs e)
        {
             
        }

        private void A1UpgradeInterval_Click(object sender, EventArgs e)
        {
            int upgradeCost = A1Interval * 100;
            if (cash >= upgradeCost)
            {
                quantityammount.Text = A1Interval.ToString();
                if (!quantity.Enabled)
                    quantity.Enabled = true;
                cash -= upgradeCost;

            }
        }

        private void A1Tick(object sender, EventArgs e)
        {
            cash += A1Ammount;
            label1.Text = "Wy³udzony Hajs z Podatków: $" + cash.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}