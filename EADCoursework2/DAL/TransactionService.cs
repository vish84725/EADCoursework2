﻿using EADCoursework2.Models;
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

        public async Task<Expense> CreateExpense(Expense expense)
        {
            try
            {
                var ex = await MyWalletAPI<Expense>.PostRequest($"{BASEURL}api/transaction/expense", expense);
                return ex;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<Income> CreateIncome(Income income)
        {
            try
            {
                var inc = await MyWalletAPI<Income>.PostRequest($"{BASEURL}api/transaction/income", income);
                return inc;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<Payee> CreatePayee(Payee payee)
        {
            try
            {
                var p = await MyWalletAPI<Payee>.PostRequest($"{BASEURL}api/transaction/payee", payee);
                return p;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public async Task<Payer> CreatePayer(Payer payer)
        {
            try
            {
                var p = await MyWalletAPI<Payer>.PostRequest($"{BASEURL}api/transaction/payer", payer);
                return p;
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
