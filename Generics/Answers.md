
# Step 2 — A store for courses

## What is the same?

Both StudentStore and CourseStore use a List to store objects.
Both classes have Add, GetById, GetAll, and Remove methods.
Both GetById methods return null if the requested item is not found.

## What is different?

StudentStore stores Student objects and works with student properties such as Id and Name.
CourseStore stores Course objects and works with course properties such as Id, Title, and Price.

The methods have almost the same implementation, but the types and property names are different.

# Step 3 — One class for both

## Compiler Error

'T' does not contain a definition for 'id' and no accessible extension method 'id' accepting a first argument of type 'T' could be found (are you missing a using directive or an assembly reference?)

## Why does the compiler reject it?

The compiler does not know if T has an Id property because T can represent any type. Student and Course have an Id property, but other types may not. Therefore, the compiler cannot guarantee that item.Id is valid for every possible type T.

# Step 7 — Prove it in Main

## Why must `new Store<string>()` not compile?

`Store<T>` has the constraint `where T : IHasId`. The `string` type does not implement `IHasId`, so `Store<string>` violates the generic constraint and causes a compile-time error.

## Search — What is the common name for the kind of class built in Steps 4 and 5?

The common name is a **Generic Repository**. It provides reusable operations for storing and retrieving different entity types through one generic implementation.