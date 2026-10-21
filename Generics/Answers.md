
# Step 2 — A store for courses

## What is the same?

Both StudentStore and CourseStore use a List to store objects.
Both classes have Add, GetById, GetAll, and Remove methods.
Both GetById methods return null if the requested item is not found.

## What is different?

StudentStore stores Student objects and works with student properties such as Id and Name.
CourseStore stores Course objects and works with course properties such as Id, Title, and Price.

The methods have almost the same implementation, but the types and property names are different.
