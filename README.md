PropertiesUsageExamples

This project demonstrates the usage of properties in C#. Properties provide controlled access to fields, allowing for validation and encapsulation in object-oriented programming. This project includes examples of how to define, validate, and manage data using properties in a C# class.
Project Structure

The Person class in Program.cs demonstrates:

    Simple Properties with Getters and Setters: Using properties like Name to manage values with validation.
    Read-Only Property: Using Country as a read-only property set at initialization.
    Calculated Property: Using IsAdult to determine adulthood based on age.
    Encapsulation and Data Validation: Ensuring valid data with customized set methods in properties.

Code Examples

In this project, we cover:

    Using properties to encapsulate fields and apply data validation.
    Defining read-only properties for values that should not change after initialization.
    Implementing calculated properties with only get accessors for read-only computed data.

Example Output

    Name: Alice, Age: 25, Country: USA, IsAdult: True
    Name cannot be empty.
    Age must be between 0 and 120.
    Updated Name: Bob, Updated Age: 30

How to Run

    Clone the repository.
    Open the project in your preferred C# IDE.
    Run the Program.cs file to observe the usage of properties in data management with encapsulation and validation.

Purpose

This project is intended for intermediate to advanced C# learners who want to understand how to use properties to manage data effectively with encapsulation and validation.



