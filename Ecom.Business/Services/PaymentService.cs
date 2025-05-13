using System;
using PaymentGateway.Data.Interfaces;
using PaymentGateway.Data.Repositories;
using PaymentGateway.Domain;
using PaymentGateway.Services.Interfaces;

namespace PaymentGateway.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository _repository;


        public PaymentService(IPaymentRepository repository)
        {
            _repository = repository;
        }

        public void CreatePayment(Payment newPayment)
        {
            newPayment.PaymentDate = DateTime.Now;
            newPayment.PaymentStatus = PaymentStatus.PENDING;
            _repository.Add(newPayment); // This assumes your repository has Add()
        }
        public void ProcessPayment(Payment payment)
        {
            payment.PaymentStatus = PaymentStatus.COMPLETED; // Simulate successful payment
            payment.PaymentDate = DateTime.Now;
            _repository.Add(payment);
            _repository.Save();
        }

        public PaymentStatus GetStatus(int paymentId)
        {
            var payment = _repository.GetById(paymentId);
            return payment?.PaymentStatus ?? PaymentStatus.FAILED;
        }
    }
}