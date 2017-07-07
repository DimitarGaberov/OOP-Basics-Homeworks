# OOP-Basics-Homeworks

1. Define Bank Account Class
Create a class named BankAccount.
The class should have private fields for:
 id: int
 balance: double
The class should also have public properties for:
 ID: int
 Balance: double

2. Methods
Create a class BankAccount (you can use class from previous task)
The class should have private fields for:
 id: int
 balance: double
The class should also have properties for:
© Software University Foundation (softuni.org). This work is licensed under the CC-BY- NC-SA license.
Follow us: Page 5 of 5
 ID: int
 Balance: double
 Deposit(Double amount): void
 Withdraw(Double amount): void
Override the method ToString().

3. Test Client
Create a test client that tests your BankAccount class.
Support the following commands:
 Create {Id}
 Deposit {Id} {Amount}
 Withdraw {Id} {Amount}
 Print {Id}
 End
© Software University Foundation (softuni.org). This work is licensed under the CC-BY- NC-SA license.
Follow us: Page 5 of 5
If you try to create an account with existing Id, print "Account already exists".
If you try to perform an operation on non-existing account with existing Id, print "Account does not exist".
If you try to withdraw an amount larger than the balance, print "Insufficient balance".
The Print command should print &quot;Account ID{id}, balance {balance}&quot;. Round the balance to the second digit after
the decimal separator.

4. Define Person Class
Create a Person class.
The class should have private fields for:
 Name: string
 Age: int
 Accounts: List<BankAccount>;
The class should have constructors:
 Person(string name, int age)
 Person(string name, int age, List<BankAccount> accounts)
The class should also have public methods for:
 GetBalance(): double

Defining Classes Exercise:
1.Define a class Person with public fields for name and age.
2.Creating Constructors
Add 3 constructors to the Person class from the last task, use constructor chaining to reuse code:
1. The first should take no arguments and produce a person with name “No name” and age = 1.
2. The second should accept only an integer number for the age and produce a person with name “No name”
and age equal to the passed parameter.
3. The third one should accept a string for the name and an integer for the age and should produce a person
with the given name and age.
P3. Oldest Family Member
Create class Person with fields name and age. Create a class Family. The class should have list of people, method for
adding members (void AddMember(Person member)) and a method returning the oldest family member (Person
GetOldestMember()). Write a program that reads name and age for N people and add them to the family. Then
print the name and age of the oldest member.

Problem 4. Opinion Poll
Using the Person class, write a program that reads from the console N lines of personal information and then prints
all people whose age is more than 30 years, sorted in alphabetical order.

Problem 5. Date Modifier
Create a class DateModifier which stores the difference of the days between two Dates. It should have a method
which takes two string parameters representing a date as strings and calculates the difference in the days between
them.

Problem 6. Company Roster
Define a class Employee that holds the following information: name, salary, position, department, email and age.
The name, salary, position and department are mandatory while the rest are optional.
© Software University Foundation (softuni.org). This work is licensed under the CC-BY- NC-SA license.
Follow us: Page 10 of 11
Your task is to write a program which takes N lines of employees from the console and calculates the department
with the highest average salary and prints for each employee in that department his name, salary, email and age –
sorted by salary in descending order. If an employee doesn’t have an email – in place of that field you should print
“n/a” instead, if he doesn’t have an age – print “-1” instead. The salary should be printed to two decimal places
after the seperator.

Problem 7. Speed Racing
Your task is to implement a program that keeps track of cars and their fuel and supports methods for moving the
cars. Define a class Car that keeps track of a car’s Model, fuel amount, fuel consumption for 1 kilometer and
distance traveled. A Car’s Model is unique - there will never be 2 cars with the same model.
On the first line of the input you will receive a number N – the number of cars you need to track, on each of the
next N lines you will receive information for a car in the following format “&lt;Model&gt; &lt;FuelAmount&gt;
&lt;FuelConsumptionFor1km&gt;”, all cars start at 0 kilometers traveled.
After the N lines, until the command “End” is received, you will receive a commands in the following format “Drive
&lt;CarModel&gt; &lt;amountOfKm&gt;”. Implement a method in the Car class to calculate whether or not a car can move
that distance, if it can the car’s fuel amount should be reduced by the amount of used fuel and its distance traveled
should be increased by the amount of kilometers traveled, otherwise the car should not move (Its fuel amount and
distance traveled should stay the same) and you should print on the console “Insufficient fuel for the drive”. After
the “End” command is received, print each car and its current fuel amount and distance traveled in the format
“&lt;Model&gt; &lt;fuelAmount&gt; &lt;distanceTraveled&gt;”, where the fuel amount should be printed to two decimal places
after the separator.

Problem 8. Raw Data
You are the owner of a courier company and want to make a system for tracking your cars and their cargo. Define a
class Car that holds information about model, engine, cargo and a collection of exactly 4 tires. The engine, cargo
and tire should be separate classes, create a constructor that receives all information about the Car and creates and
initializes its inner components (engine, cargo and tires).
On the first line of input you will receive a number N - the amount of cars you have, on each of the next N lines you
will receive information about a car in the format “&lt;Model&gt; &lt;EngineSpeed&gt; &lt;EnginePower&gt; &lt;CargoWeight&gt;
&lt;CargoType&gt; &lt;Tire1Pressure&gt; &lt;Tire1Age&gt; &lt;Tire2Pressure&gt; &lt;Tire2Age&gt; &lt;Tire3Pressure&gt; &lt;Tire3Age&gt;
&lt;Tire4Pressure&gt; &lt;Tire4Age&gt;” where the speed, power, weight and tire age are integers, tire pressure is a double.
After the N lines you will receive a single line with one of 2 commands “fragile” or “flamable” , if the command is
“fragile” print all cars whose Cargo Type is “fragile” with a tire whose pressure is &lt; 1, if the command is “flamable”
print all cars whose Cargo Type is “flamable” and have Engine Power &gt; 250. The cars should be printed in order of
appearing in the input.

Problem 9. Rectangle Intersection
Create a class Rectangle. It should consist of an ID, width, height and the coordinates of its top left corner
(horizontal and vertical). Create a method which receives as a parameter another Rectangle, checks if the two
rectangles intersect and returns true or false.
On the first line you will receive the number of rectangles – N and the number of intersection checks – M. On the
next N lines, you will get the rectangles with their ID, width, height and coordinates. On the last M lines, you will
get pairs of IDs which represent rectangles. Print if each of the pairs intersect.
© Software University Foundation (softuni.org). This work is licensed under the CC-BY- NC-SA license.
Follow us: Page 10 of 11
You will always receive valid data. There is no need to check if a rectangle exists.
