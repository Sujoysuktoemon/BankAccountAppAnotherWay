using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BankAccountAppAnotherWay
{
    public partial class AccountUI : Form
    {
        private Account anAccount;

        public AccountUI()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            anAccount = new Account(accountNumberTextBox.Text, customerNameTextBox.Text);
            MessageBox.Show("Account created");
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(amountTextBox.Text);
            string msg = anAccount.Deposit(amount);
            MessageBox.Show(msg);
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {

        }

        private void reportButton_Click(object sender, EventArgs e)
        {

        }
    }
}
