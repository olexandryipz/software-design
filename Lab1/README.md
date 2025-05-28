# Warehouse Application

This project demonstrates the implementation of a warehouse inventory system with money and product management.

## Principles of Programming Demonstrated

### 1. DRY (Don't Repeat Yourself)  
- Money operations are encapsulated in the `Money` class ([Money.cs](Money.cs), lines 1-25).  
- Price decrease logic is only implemented once inside `Product.DecreasePrice` ([Product.cs](Product.cs), lines 15-26).

### 2. KISS (Keep It Simple, Stupid)  
- Methods are small and focused, e.g., `ReceiveProduct` in `Reporting` class simply finds or adds product ([Reporting.cs](Reporting.cs), lines 10-22).  
- No unnecessary complexity or deeply nested logic.

### 3. SOLID Principles  
- **S**: Single Responsibility — each class has a clear responsibility: `Money` for money, `Product` for product details, `WarehouseItem` for stock records, `Reporting` for inventory operations.  
- **O**: Open/Closed — classes can be extended (e.g., add new product types) without modifying existing code.  
- **L**: Liskov Substitution — if subclasses were added (e.g., different currencies), they could substitute base classes without breaking functionality.  
- **I**: Interface Segregation — although no interfaces were added, responsibilities are separated clearly per class.  
- **D**: Dependency Inversion — higher-level classes like `Reporting` depend on abstractions (`Product`), not concrete implementations.

### 4. YAGNI (You Aren't Gonna Need It)  
- Only necessary features are implemented; for example, no unused methods or over-engineered features.

### 5. Composition Over Inheritance  
- Instead of deep inheritance, classes are composed (e.g., `WarehouseItem` contains a `Product`) ([WarehouseItem.cs](WarehouseItem.cs), lines 5-20).

### 6. Program to Interfaces, Not Implementations  
- Although not explicitly used, the design allows easy interface introduction (e.g., `IProduct`).

### 7. Fail Fast  
- The `ShipProduct` method immediately reports insufficient stock to avoid silent failures ([Reporting.cs](Reporting.cs), lines 24-33).

---

## Project Structure

- `Money.cs` — Money representation  
- `Product.cs` — Product details  
- `WarehouseItem.cs` — Stock item in warehouse  
- `Reporting.cs` — Inventory and shipping logic  
- `Program.cs` — Main program entry and testing  

---

## Running the program

Run `Program.cs` to see a demonstration of receiving products, applying discounts, shipping, and reporting inventory.
