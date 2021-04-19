using EADCoursework2.DAL;
using EADCoursework2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EADCoursework2.Forms
{
    public partial class PredictFinancialStatus : Form
    {
        private ITransactionService mTransactionService;
        public PredictFinancialStatus()
        {
            InitializeComponent();
        }

        private bool Init()
        {
            try
            {
                mTransactionService = new TransactionService();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
        private void InitializeUIComponents()
        {
            datePicker.LabelKey = "Date";
            lblLabel.Visible = false;
            lblValue.Visible = false;
        }

        private async Task<double> GetPrediction(PredictionDTO dto)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                var prediction = await mTransactionService.GetPrediction(dto);
                return prediction.PredictionValue;
            }
            catch(Exception)
            {
                return 0;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void PredictFinancialStatus_Load(object sender, EventArgs e)
        {
            InitializeUIComponents();
            if (Init())
            {

            }
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            double prediction = await GetPrediction(new PredictionDTO()
            {
                PredictionDate = datePicker.Date
            }) ;

            SetData(prediction);
        }

        private void SetData(double prediction)
        {
            lblLabel.Text = $"My Financial Status On {datePicker.Date.ToLongDateString()} will be ";
            lblValue.Text = $"Rs. {prediction}";

            lblLabel.Visible = true;
            lblValue.Visible = true;
        }
    }
}
