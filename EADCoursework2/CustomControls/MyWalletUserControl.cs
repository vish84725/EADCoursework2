using EADCoursework2.DAL;
using EADCoursework2.Forms;
using EADCoursework2.Models;
using EADCoursework2.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EADCoursework2.CustomControls
{
    public partial class MyWalletUserControl : UserControl
    {
        public User LoggedInUser { get; set; }
        private ITransactionService mTransactionService;
        public MyWalletUserControl()
        {
            InitializeComponent();
        }

        private void MyWalletUserControl_Load(object sender, EventArgs e)
        {
            InitializeUIComponents();
            Init();
            LoadData();
        }

        #region Private Methods
        public async void LoadData()
        {
            try
            {
               if(mTransactionService!= null)
                {
                    var summary = await mTransactionService.GetWalletSummary();
                    if (summary != null)
                    {
                        lblMonthlyAmount.Text = $"Rs. {summary.LastMonthBalance}";
                        lblWeeklyAmount.Text = $"Rs. {summary.LastWeekBalance}";
                        lblTotalAmount.Text = $"Rs. {summary.CurrentBalance}";
                    }
                }

            }
            catch(Exception e)
            {

            }
        }
        private void Init()
        {
            try
            {
                mTransactionService = new TransactionService();
            }
            catch(Exception)
            {

            }
        }
        private void InitializeUIComponents()
        {
            //set background color
            this.BackColor = Constants.MW_Gray;
        }
        #endregion

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            AddTransaction form = new AddTransaction();
            form.User = LoggedInUser;
            form.ReloadSummaryViewCallback = this.LoadData;
            form.ShowDialog();
        }

        private void btnAddPayeePayer_Click(object sender, EventArgs e)
        {
            AddPayerPayee form = new AddPayerPayee();
            form.Show();
        }

        private void btnFinancialStatus_Click(object sender, EventArgs e)
        {
            PredictFinancialStatus form = new PredictFinancialStatus();
            form.ShowDialog();
        }

        private void btnallTansactions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon!");
        }
    }
}
