# Assignment 6 – Polygon Angle Sum Calculator (C#)

A C# console application that calculates the **sum of interior angles of a polygon** using the standard formula **(n − 2) × 180**.  
This project demonstrates **class creation**, **method definition**, **input validation**, and **exception handling through `TryParse()`**.

---

## Description
The program defines a `Polygon` class that contains a single public method, `SumPolygon()`, which computes the total sum of interior angles for any polygon based on the number of sides entered by the user.  
The main method (`Main()`) guides the user, allows them to choose between an example or manual input, validates data, and displays the result with formatted output.

---

## Features
- Prompts the user for the number of sides in a polygon.  
- Optionally demonstrates the formula with a hard-coded example (`n = 5`).  
- Validates input to ensure the number of sides is greater than 2.  
- Uses `int.TryParse()` for exception-safe numeric input conversion.  
- Outputs the computed sum of angles in degrees with descriptive formatting.  

---

## Core Logic
1. **Display instructions** describing the formula and expected input.  
2. **Prompt for demonstration**: if the user enters `Y`, the program uses `n = 5`; otherwise, it requests manual input.  
3. **Validate input**: loops until the user provides a valid integer > 2.  
4. **Instantiate the `Polygon` class** and call its `SumPolygon(int n)` method.  
5. **Display the result** using string interpolation and degree notation.

---

## Class and Method Structure
### `class Polygon`
Defines:
```csharp
public int SumPolygon(int n)
{
    return (n - 2) * 180;
}
