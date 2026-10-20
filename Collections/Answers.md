# Collections — Answers

## 1. What is IReadOnlyDictionary?

`IReadOnlyDictionary` stores data as key-value pairs. It allows us to read values and search for keys, but it does not provide methods to add or remove items.

## 2. How is IReadOnlyDictionary different from Dictionary?

`Dictionary` allows us to add, change, and remove items.
`IReadOnlyDictionary` allows us to read the data only through its interface.

A public method may return `IReadOnlyDictionary` when other parts of the program only need to read the data. This helps protect the data from changes through the returned reference.

However, the original dictionary can still change if another part of the program can access and modify it.

## 3. What is SortedDictionary?

`SortedDictionary` stores key-value pairs and keeps them sorted by key. By default, the keys are sorted in ascending order.

## 4. How is SortedDictionary different from Dictionary?

`Dictionary` is usually faster when searching for a key. Its average lookup time is O(1), but it does not guarantee sorting by key.

`SortedDictionary` keeps the keys sorted, but searching for a key usually takes O(log n).

## 5. When would you choose SortedDictionary?

I would use `SortedDictionary` when I need the keys to stay sorted while adding or removing items.

I would use `Dictionary` when I need fast searching and do not need the keys to be sorted.


## Task 2.2 — Pick the Collection

### S1 — Find a student by national ID
**Collection:** `Dictionary`

**Why:** It provides fast lookup by key, so finding a student by national ID is efficient.

### S2 — Course tags without duplicates
**Collection:** `HashSet`

**Why:** It stores unique values, so the same tag cannot be added more than once.

### S3 — Student grades in the order they were entered
**Collection:** `List`

**Why:** It keeps the grades in order and allows the same grade to appear more than once.

### S4 — A public method returns a read-only course price list
**Collection:** `IReadOnlyDictionary`

**Why:** It allows callers to read prices without providing methods to add or change items through this interface.

### S5 — Timetable always printed in time order
**Collection:** `SortedDictionary`

**Why:** It keeps sessions sorted by their start time, even when new sessions are added.

### S6 — Results are looped over once and the caller may stop early
**Collection:** `IEnumerable`

**Why:** It allows the caller to process results one by one and stop early without needing a complete list.