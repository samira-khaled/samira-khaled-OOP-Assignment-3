# Part 02 — answers

---

## Reports

- **What was the problem?**  
  The three report exporters had duplicated code for loading, validating, and saving report data.

- **What did you change?**  
  I created an abstract `ReportExporter` class that contains the common export steps. Each exporter implements its own `Format` method for CSV, JSON, or Text.

- **Why did you choose that approach?**  
  I used the Template Method pattern because it keeps the common steps in one place while allowing each exporter to format the data differently. An abstract class is suitable because the exporters share both behavior and a common workflow.

---

## Enrollment

- **What was the problem?**  
  `Program.cs` created four services and called them one by one in the correct order, making the enrollment process complicated for the caller.

- **What did you change?**  
  I used the Facade pattern by putting the enrollment steps inside `EnrollmentService`. The caller now enrolls a student by calling `Enroll` once.

- **Why did you choose that approach?**  
  The Facade simplifies the enrollment process by providing one entry point. The caller no longer needs to know how the four services work or the order in which they must be called.