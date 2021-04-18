using EADCoursework2.Models;
using EADCoursework2.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EADCoursework2.DAL
{
    public class TransactionService: ITransactionService
    {
        private const String BASEURL = Constants.BASEURL;
        RemoteAccessService remoteAccessService = new RemoteAccessService();
        public async Task<Expense> CreateExpense(Expense expense)
        {
            try
            {
                remoteAccessService.WriteToXML<Expense>(expense);
                var ex = await MyWalletAPI<Expense>.PostRequest($"{BASEURL}api/transaction/expense", expense);
                if (ex != null && ex.TransactionId != 0)
                    remoteAccessService.ClearCachedObject<Expense>(expense);
                return ex;
            }
            catch (Exception e)
            {
                return new Expense();
            }
        }

        public async Task<Income> CreateIncome(Income income)
        {
            try
            {
                remoteAccessService.WriteToXML<Income>(income);
                var inc = await MyWalletAPI<Income>.PostRequest($"{BASEURL}api/transaction/income", income);
                if (inc != null && inc.TransactionId != 0)
                    remoteAccessService.ClearCachedObject<Income>(income);
                return inc;
            }
            catch (Exception e)
            {
                return new Income();
            }
        }

        public async Task<Payee> CreatePayee(Payee payee)
        {
            try
            {
                remoteAccessService.WriteToXML<Payee>(payee);
                var p = await MyWalletAPI<Payee>.PostRequest($"{BASEURL}api/transaction/payee", payee);
                if (p != null && p.PayeeId != 0)
                    remoteAccessService.ClearCachedObject<Payee>(payee);
                return p;
            }
            catch(Exception e)
            {
                return new Payee();
            }
        }

        public async Task<Payer> CreatePayer(Payer payer)
        {
            try
            {
                remoteAccessService.WriteToXML<Payer>(payer);
                var p = await MyWalletAPI<Payer>.PostRequest($"{BASEURL}api/transaction/payer", payer);
                if (p != null && p.PayerId != 0)
                    remoteAccessService.ClearCachedObject<Payer>(payer);
                return p;
            }
            catch (Exception e)
            {
                return new Payer();
            }
        }

        public async Task<List<Expense>> GetAllExpense()
        {
            try
            {
                var expenses = await MyWalletAPI<List<Expense>>.Get($"{BASEURL}api/transaction/expense");
                return expenses;
            }
            catch (Exception e)
            {
                return new List<Expense>();
            }
        }

        public async Task<List<Expense>> GetAllExpenseRange(List<Expense> dto)
        {
            try
            {
                var t = await MyWalletAPI<List<Expense>>.PostRequest($"{BASEURL}api/transaction/expense/range", dto);
                return t;
            }
            catch (Exception e)
            {
                return new List<Expense>();
            }
        }

        public async Task<List<Income>> GetAllIncome()
        {
            try
            {
                var incomes = await MyWalletAPI<List<Income>>.Get($"{BASEURL}api/transaction/income");
                return incomes;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<List<Income>> GetAllIncomeRange(List<Income> dto)
        {
            try
            {
                var t = await MyWalletAPI<List<Income>>.PostRequest($"{BASEURL}api/transaction/income/range", dto);
                return t;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<List<Payee>> GetAllPayees()
        {
            try
            {
                var payees = await MyWalletAPI<List<Payee>>.Get($"{BASEURL}api/transaction/payee");
                return payees;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<List<Payer>> GetAllPayers()
        {
            try
            {
                var payers = await MyWalletAPI<List<Payer>>.Get($"{BASEURL}api/transaction/payer");
                return payers;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
