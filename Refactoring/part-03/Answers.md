# Part 03 — answers

---

## BlockedUsers

- **Time complexity before:** `O(n * m)`
- **Time (ms) before:** `50 ms`
- **What did you change?**  
  I converted the blocked IDs list into a `HashSet<int>` to make lookups faster.
- **Time complexity after:** `O(n + m)` on average
- **Time (ms) after:** `3 ms`
- **Found before and after:** `5000` (unchanged)

---

## Students

- **What was the problem?**  
  The program printed only the first three students, but `StudentCatalog` created all one million students before returning them.

- **What did you change?**  
  I changed `StudentCatalog` to use lazy evaluation with `IEnumerable<Student>` and `yield return`. Students are now created only when requested, so the remaining students are not created when the program stops after the first three.