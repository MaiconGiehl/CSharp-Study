using System;
using Exercise.Entities;

namespace Exercise.Service
{
    class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;
        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;
            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double newQuota = basicQuota + _onlinePaymentService.Interest(basicQuota, i);
                double fullQuota = newQuota + _onlinePaymentService.PaymentFee(newQuota);
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}