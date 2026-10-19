using RefactoringLab;

var aramexShipping = new AramexShippingCalculator();
var fedexShipping = new FedExShippingCalculator();
var dhlShipping = new DHLShippingCalculator();


//Console.WriteLine($"FedEx 2kg → {fedexShipping.Calculate(2)}");
//Console.WriteLine($"DHL 2kg → {dhlShipping.Calculate(2)}");

var shippingCostCalculator = new ShippingCostCalculator(aramexShipping);
Console.WriteLine($"Aramex 2kg → {shippingCostCalculator.Calculate(2)}");


Console.WriteLine();




var processor = new OrderProcessor(new SqlOrderRepository(), new SmtpEmailSender());
processor.Process(1001, "customer@example.com");
Console.WriteLine();


var EmailService = new NotificationService(new EmailNotification());

EmailService.Send(
    "customer@example.com",
    "Your order ships tomorrow",
    isUrgent: true,
    sendAt: DateTime.Today.AddHours(18));

var smsService = new NotificationService(new SmsNotification());

smsService.Send(
    "+201000000000",
    "OTP 4821",
    isUrgent: true);