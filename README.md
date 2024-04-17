[README EM PT-BR](https://github.com/IgorAntonio22/Library-Management-System-CSharp/blob/master/README-PTBR.md)

# Library Management System

Create an abstract class called "LibraryItem" that represents a generic library item. This class should contain the following attributes: title, author, and publication year. Additionally, it should have the following abstract methods: "borrow()", "return()", and "displayInformation()".

Create two concrete classes that inherit from the abstract class "LibraryItem": "Book" and "Magazine". Implement the abstract methods according to the expected behavior for each item.

Create an interface called "Borrowable" that contains the following methods: "checkAvailability()" and "getReturnDeadline()".

Ensure that the classes "Book" and "Magazine" implement the "Borrowable" interface and implement the methods according to the expected behavior for each item.

Create a class called "Library" that will be responsible for storing and managing the library items. This class should have an array or a list to store the items and the following methods: "addItem(LibraryItem item)", "removeItem(LibraryItem item)", "displayItems()", and "lendItem(LibraryItem item)".

In the main class of your program, create some objects of type "Book" and "Magazine", add them to the library, display the list of items, and perform some borrowings and returns to demonstrate the system's functionality.

Notes:

- Keep the code organized and indented.
- Use class, method, and instance naming conventions as shown in class.
- Utilize encapsulation, inheritance, polymorphism, and abstraction concepts appropriately.
- You can add other attributes and methods to the classes if necessary.
- For better understanding, comment the code explaining important points in the development.

