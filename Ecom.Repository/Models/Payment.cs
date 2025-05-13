using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGateway.Domain;
public enum PaymentStatus
{
    PENDING,
    COMPLETED,
    FAILED
}


public class Payment
{
    public int PaymentId { get; set; }        //Primary Key
    public int OrderId { get; set; }          //Foreign Key
    public decimal Amount { get; set; }       //Amount to be paid
    public PaymentStatus PaymentStatus { get; set; } //Enum Status
    public DateTime PaymentDate { get; set; }
}

