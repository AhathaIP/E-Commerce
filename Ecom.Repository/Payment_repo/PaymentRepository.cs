using Ecom.Repository;
using PaymentGateway.Data.Interfaces;
using PaymentGateway.Domain;

namespace PaymentGateway.Data.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly AppDbContext _context;

        public PaymentRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Payment payment)
        {
            _context.Payments.Add(payment);
            _context.SaveChanges();
        }

        public Payment GetById(int id) => _context.Payments.Find(id);

        public void Save() => _context.SaveChanges();
    }
}