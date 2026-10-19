# Part 01 — Answers

---

## ShippingCostCalculator

- **What was the problem?**

  The class used a switch statement for all shipping companies. Adding a new company meant changing the existing code.

- **What did you change?**

  I created an interface and a separate class for each shipping company. Now, I can add a new company without changing the existing classes.

---

## OrderProcessor

- **What was the problem?**

  The class created the database and email objects by itself. This made it harder to change them.

- **What did you change?**

  I created two interfaces and passed the objects through the constructor. Now, I can change the database or email sender more easily.

---

## Notifications

- **What was the problem?**

  There were too many classes for email and SMS. We needed separate classes for urgent and scheduled messages.

- **What did you change?**

  I created an `INotificationChannel` interface and a `NotificationService`. Now, I can send urgent and scheduled messages without creating a new class for each case.

---

## Proof

- **New carrier file(s):** `AramexShippingCalculator.cs`, `FedExShippingCalculator.cs`, `DHLShippingCalculator.cs` (if they are separate files).
- **New notification channel file(s):** Write the name of the new channel file you added.
- **Existing classes left unchanged? (yes/no):** Write `Yes` or `No` based on your actual changes.