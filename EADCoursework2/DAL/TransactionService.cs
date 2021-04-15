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
