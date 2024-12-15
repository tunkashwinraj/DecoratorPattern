

# Decorator Pattern Example

This repository demonstrates the **Decorator Pattern** design pattern, which allows providing enhanced behavior to existing classes. The example is implemented in a **Windows Forms Application** with **C#**, and includes a basic **ShoppingCart** web application example as well. The main concept behind the Decorator Pattern is to provide multiple enhancements to a class's methods and to combine them in a flexible and reusable manner.

## Features

- **Windows Forms Application**: Implements the decorator pattern with components like `Component`, `DecoratorTime`, `DecoratorBday` to enhance the `Welcome` message.
- **Web Application**: Demonstrates how the decorator pattern can be applied in a shopping cart with different decorators for discounts, including:
  - **5% discount for purchases over $500**
  - **7.5% discount for first-time customers**
  - **10% discount during holiday sales**

## Files Overview

### Windows Forms Application

- **IComponent.cs**: Defines the base interface with `Welcome()` methods.
- **Component.cs**: Implements the base functionality of the `Welcome()` methods.
- **Decorator.cs**: An abstract base class for decorators.
- **DecoratorTime.cs**: Adds time information to the `Welcome()` message.
- **DecoratorBday.cs**: Adds a "Happy Birthday" message to the `Welcome()` message.

### Web Application

- **CartRow.cs**: Represents a row in the shopping cart with product details.
- **IShoppingCart.cs**: Base interface for shopping cart with a `ComputeTotal()` method.
- **ShoppingCart.cs**: The base shopping cart class implementing the `IShoppingCart` interface.
- **ShoppingCartBaseDecorator.cs**: The base class for all decorators in the shopping cart application.
- **ShoppingCartGT500Decorator.cs**: Provides a 5% discount for purchases greater than $500.
- **ShoppingCartFirstTimeCustomerDecorator.cs**: Provides a 7.5% discount for first-time customers.
- **ShoppingCartHolidaySaleDecorator.cs**: Provides a 10% discount for holiday sales.

### Example Usage

1. **Windows Forms**:
   - Run the `DecoratorPattern` project.
   - Click the `btnDecoratorSimple` button to see different decorators applied to the `Component` class (e.g., `DecoratorTime`, `DecoratorBday`).
   
2. **Web Application**:
   - The web application simulates a shopping cart.
   - When you enter quantities for three items and click the "Checkout" button, the total price is calculated with any applicable discounts (using the `ShoppingCart` class and its decorators).

## How to Run

1. Clone the repository or download the ZIP.
2. Open the solution in **Visual Studio**.
3. For the **Windows Forms Application**:
   - Build and run the project.
   - Click the button to see how different decorators are applied.
   
4. For the **Web Application**:
   - Open the `ShoppingCartDecoratorPattern` project.
   - Set `ShoppingCartCheckout.aspx` as the start page.
   - Build and run the web application to test the shopping cart functionality with decorators.

## Concepts

- **Decorator Pattern**: Allows us to dynamically add responsibilities to objects without altering their structure.
- **Flexible Enhancement**: Decorators can be applied in any order to achieve the desired combination of behavior.
- **Code Reusability**: You can use the same core component (`IComponent` or `IShoppingCart`) and add various decorators to customize its behavior.

## Benefits

- **Extensibility**: You can easily extend the functionality of an object without modifying its existing code.
- **Combining Behaviors**: Different decorators can be combined to produce the desired result, as demonstrated in both the Windows Forms and web application examples.

## Prerequisites

- **Visual Studio** (for Windows Forms application and Web Application).
- **.NET Framework** for Windows Forms.
- **ASP.NET** for the web application.

