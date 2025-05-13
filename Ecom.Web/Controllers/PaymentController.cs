using Microsoft.AspNetCore.Mvc;
using PaymentGateway.Domain;
using PaymentGateway.Services.Interfaces;


namespace YourProject.Controllers
{
    public class PaymentController : Controller
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Create(Payment payment)
        {

            _paymentService.CreatePayment(payment);
            return RedirectToAction("Success");
        }

        [HttpPost]
        public IActionResult ProcessPayment(Payment payment)
        {
            if (ModelState.IsValid)
            {
                _paymentService.ProcessPayment(payment);
                return RedirectToAction("Success");
            }
            return View(payment);
        }

        public IActionResult GetPaymentStatus(int id)
        {
            var status = _paymentService.GetStatus(id);
            return Json(new { paymentId = id, status });
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}