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
    }
}
