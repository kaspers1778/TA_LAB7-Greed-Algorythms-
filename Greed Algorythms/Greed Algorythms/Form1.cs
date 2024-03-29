﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greed_Algorythms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int indexOfAccount = 1;
        static double percent;
               
        SortedSet<double> AccountsSet = new SortedSet<double>();
        

        private void btn_addAccount_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(mtb_addAccountMoney.Text) >= 0 && Convert.ToInt32(mtb_addAccountMoney.Text) <= 10000)
                {
                    dgv_Accounts.Rows.Add(indexOfAccount, Convert.ToInt32(mtb_addAccountMoney.Text));
                    indexOfAccount++;
                    mtb_addAccountMoney.Clear();
                }
                else
                {
                    MessageBox.Show("Incorrect Data" + "\r\n" + "Amount of money on account should be in range of 10000");
                }
            }
            catch
            {
                MessageBox.Show("Incorrect Data" + "\r\n" + "You need to enter amount of money");
            }
        }

        Random money = new Random();

        private void btn_randomAccount_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(mtb_randomAccountsAmount.Text) >= 0 && Convert.ToInt32(mtb_randomAccountsAmount.Text) <= (100000 - dgv_Accounts.RowCount) && mtb_randomAccountsAmount.Text != null)
                {
                    for (int i = 0; i < Convert.ToInt32(mtb_randomAccountsAmount.Text); i++)
                    {
                        dgv_Accounts.Rows.Add(indexOfAccount, money.Next(0, 10000));
                        indexOfAccount++;
                    }
                    mtb_randomAccountsAmount.Clear();
                }
                else
                {
                    MessageBox.Show("Incorrect Data" + "\r\n" + "Amount of accounts should be in range of 100000");
                }
            }
            catch
            {
                MessageBox.Show("Incorrect Data" + "\r\n" + "You need to enter amount of accounts");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            dgv_Accounts.Rows.Clear();
            AccountsSet.Clear();
            indexOfAccount = 1;
            txb_output.Clear();
        }
       

        private void btn_findAmountMoneyToSave_Click(object sender, EventArgs e)
        {
            txb_output.Clear();
            try
            {
                percent = Convert.ToInt32(mtb_percent.Text);
            }
            catch
            {
                MessageBox.Show("Incorrect Data" + "\r\n" + "Percent shoud be integer in range 20");
            }

            SortedSet<double> tmpAccountsSet = AccountsSet;

            for (int i = 0; i < dgv_Accounts.RowCount; i++)
            {
                tmpAccountsSet.Add(Convert.ToDouble(dgv_Accounts.Rows[i].Cells[1].Value));
            }
            double firstMin = 0, secondMin = 0;
            while (tmpAccountsSet.Count != 1)
            {
                firstMin = tmpAccountsSet.Min;
                tmpAccountsSet.Remove(tmpAccountsSet.Min);
                secondMin = tmpAccountsSet.Min;
                tmpAccountsSet.Remove(tmpAccountsSet.Min);
                tmpAccountsSet.Add((firstMin + secondMin)*(1 - percent/100));
                
            }
            txb_output.Text = tmpAccountsSet.Min.ToString();
            tmpAccountsSet.Clear();
        }

    }
}
