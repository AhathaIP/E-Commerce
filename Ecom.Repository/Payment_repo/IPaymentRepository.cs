using PaymentGateway.Domain;

namespace PaymentGateway.Data.Interfaces
{
    public interface IPaymentRepository
    {
        void Add(Payment payment);
        Payment GetById(int id);
        void Save();
    }
}