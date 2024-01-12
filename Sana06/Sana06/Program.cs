using ClassLibrary1;

Console.WriteLine("Hello");

var array = new Human[5];

array[0] = new Human("Artem", "Levchenko", new DateTime(2006, 01, 08));
array[1] = new Entrant(array[0], 176f, 9.5f, "ZEL");
array[2] = new Student("Andrii", "Kravchenko", new DateTime(2005, 06, 28), 1, "IPZ", "FICT", "ZTU");
array[3] = new Teacher("Volodymyr", "Bondar", new DateTime(1994, 03, 9), "Math teacher", "FICT", "ZTU");
array[4] = new LibraryUser(array[0], 1077, new DateTime(2023, 12, 21), 4m);