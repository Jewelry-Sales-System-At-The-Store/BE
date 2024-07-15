using BusinessObjects.Models;
using DAO.Dao;
using Repositories.Interface;

namespace Repositories.Implementation;

public class PaymentRepository : IPaymentRepository
{ 
    private readonly PaymentDao _paymentDao;

    public PaymentRepository(PaymentDao paymentDao)
    {
        _paymentDao = paymentDao;
    }

    public async Task<Payment> Create(Payment entity)
    {
        return await _paymentDao.CreatePayment(entity);
    }

    public async Task<Payment?> UpdatePaymentStatus(string id, PaymentStatus paymentStatus)
    {
        return await _paymentDao.UpdatePaymentStatus(id, paymentStatus);
    }

    public async Task<Payment?> GetPaymentByBillId(string billId)
    {
        return await _paymentDao.GetPaymentByBillId(billId);
    }
}