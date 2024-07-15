using BusinessObjects.Models;
using Repositories.Interface.GenericRepository;

namespace Repositories.Interface;

public interface IPaymentRepository
{
    Task<Payment> Create(Payment entity);
    Task<Payment?> UpdatePaymentStatus(string id, PaymentStatus paymentStatus);
    Task<Payment?> GetPaymentByBillId(string billId);
}