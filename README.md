# Practichna 1

## Task 1 №1.9
Converting minutes to hours and minutes
Write a program that reads an integer number specifying the duration in minutes and converts
it to hours and minutes.

Input: an integer non-negative (number of minutes).

Output: If the value is correct, the program calculates the equivalent duration in
hours and minutes and displays it in the format “H hours M minutes”, where H is the number of full
hours and M is the remainder in minutes. If an incorrect or negative value is entered, display
“Invalid input”.

<br>Examples:
<br>Inputs:
<br>40
<br>180
<br>126
<br>-14
<br>abc

<br>Outputs:
<br>0 hours 40 minutes
<br>3 hours 0 minutes
<br>2 hours 6 minutes
<br>Invalid input
<br>Invalid input


## Task 2 №2.10
Checking multiplicity 10
Write a program that checks whether the entered integer is a multiple of 10.

Input: Integer number

Output: If the value is correct, the program outputs “Multiple of 10” if the number
is divisible by 10 without remainder, or “Not a multiple of 10” if not. If the entered value is not an
integer, output “Invalid input”.

<br>Examples:
<br>Inputs:
<br>20
<br>140
<br>8
<br>156
<br>abc

<br>Outputs:
<br>Multiple of 10
<br>Multiple of 10
<br>Not a multiple of 10
<br>Not a multiple of 10
<br>Invalid input


## Task 3 №3.7
Name of the number
Write a program that displays the name of a given digit (0–9) in English.

Input: an integer number from 0 to 9.

Output: Input: if the value corresponds to a number between 0 and 9, the program outputs the corresponding word:
“Zero”, “One”, “Two”, “Three”, “Four”, “Five”, “Six”, “Seven”, ‘Eight’ or “Nine”. If the entered
number is not in the range 0–9 or is not an integer, display “Invalid input”.

<br>Examples:
<br>Inputs:
<br>0
<br>2
<br>7
<br>120
<br>abc

<br>Outputs:
<br>Zero
<br>Two
<br>Seven
<br>Invalid input
<br>Invalid input


## Task 4 №4.10
Number of roots of a quadratic equation Equation
Write a program that determines the number of real roots of the quadratic equation 
ax^2 + bx + c = 0 based on the coefficients a, b, c.

Input: three numbers (coefficients a, b, c).

Output: If the values are correct (numerical), the program analyzes the coefficients. If a = 0,
display “Not a quadratic” (the equation is not quadratic). Otherwise, the discriminant D
= b^2 - 4ac is calculated and, based on its value, the following is displayed: “Two roots” if D > 0; 
“One root” if D = 0; "No real roots“ if D < 0. If incorrect data is entered, display ”Invalid input".

<br>Examples:
<br>Inputs:
<br>2 -5 3
<br>1 -6 9
<br>2 3 5
<br>0 1 4
<br>a b c

<br>Outputs: 
<br>Two Roots
<br>One Root
<br>No real roots
<br>Not a quadratic
<br>Invalid Input
