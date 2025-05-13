using PaymentGateway.Domain;

namespace PaymentGateway.Services.Interfaces
{
    public interface IPaymentService
    {
        void ProcessPayment(Payment payment);
        PaymentStatus GetStatus(int paymentId);

        void CreatePayment(Payment newPayment);
    }
}