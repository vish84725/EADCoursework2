using EADCoursework2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EADCoursework2.DAL
{
    interface ITransactionService
    {
        Task<Payee> CreatePayee(Payee payee);
        Task<Payer> CreatePayer(Payer payer);
        Task<Income> CreateIncome(Income income);
        Task<Expense> CreateExpense(Expense expense);
        Task<List<Payer>> GetAllPayers();
        Task<List<Payee>> GetAllPayees();
        Task<List<Income>> GetAllIncome();
        Task<List<Expense>> GetAllExpense();
        Task<List<Income>> GetAllIncomeRange(List<Income> dto);
        Task<List<Expense>> GetAllExpenseRange(List<Expense> dto);

        Task<PredictionDTO> GetPrediction(PredictionDTO dto);
    }
}
