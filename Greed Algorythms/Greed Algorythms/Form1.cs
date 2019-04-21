using System;
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
        static double percent = 10;
        SortedSet<Tuple<double, int, int>> Edges = new SortedSet<Tuple<double, int, int>>();

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
            Edges.Clear();
            textBox1.Clear();
            indexOfAccount = 1;
            txb_output.Clear();
        }
       

        private void btn_findAmountMoneyToSave_Click(object sender, EventArgs e)
        {
            txb_output.Clear();
            double weight;
            double start;
            double end;
            for (int i = 0;i < dgv_Accounts.RowCount; i++)
            {
                start = Convert.ToDouble(dgv_Accounts.Rows[i].Cells[1].Value);
                for (int j = i; j < dgv_Accounts.RowCount; j++)
                {
                    if (i != j)
                    {
                        end = Convert.ToDouble(dgv_Accounts.Rows[j].Cells[1].Value);
                        weight = ((start + end) - ((start + end) *(percent / 100)));
                        Edges.Add(new Tuple<double, int, int>(weight, i, j));
                    }
                }
            }

             /////////////////////////////
             foreach (var edge in Edges)
            {
                textBox1.Text += edge.ToString() + "\r\n";
            }
            ////////////////////////////

            int[] Comp = new int[dgv_Accounts.RowCount];
            for(int i = 0;i< dgv_Accounts.RowCount; i++)
            {
                Comp[i] = i;
            }

            int startComp, endComp, a, b;
            double Solution = 0;

            foreach (var Edge in Edges)
            {
                weight = Edge.Item1;
                startComp = Edge.Item2;
                endComp = Edge.Item3;

                if (Comp[startComp] != Comp[endComp])
                {
                    Solution += weight;
                    a = Comp[startComp];
                    b = Comp[endComp]; 

                    for(int i = 0;i < dgv_Accounts.RowCount; i++)
                    {
                        if(Comp[i] == b)
                        {
                            Comp[i] = a;
                        }
                    }

                }
            }

            txb_output.Text = Convert.ToString(Solution);

        }

    
    }
}
