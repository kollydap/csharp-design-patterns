// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Duck mallard = new MullardDuck();
// mallard.PerformQuack();

// UserAccount user = new FreeUserAccount("kola", 22);
// Console.WriteLine(user.MAkePAYMENT());
// user.MAkePAYMENT(2000, 7000);

// WeatherData weatherData = new WeatherData();

// CurrentConditionDisplay currentConditionDisplay = new CurrentConditionDisplay(weatherData);

// // weatherData.SetMeasurements(20, 39, 90);
// PublishingCompany publishingCompany = new PublishingCompany();

// PunchNewsPaper punchNewsPaper = new PunchNewsPaper(publishingCompany);
// SunNewsPaper sunNewsPaper = new SunNewsPaper(publishingCompany);

// for (int i = 0; i < 10; i++)
// {
//     publishingCompany.UpdateData("kolawole is the top guy", i);
// }


// Users users = new Student("Osagie", 1, 200);
// users.SortUser();
// Users teachers = new Teacher("Osagie", 1, 200);
// teachers.SortUser();
// teachers.ChangeSortMethod()

Beverage beverage = new HouseBlend();
beverage = new Mocha(beverage);
Console.WriteLine(beverage.Cost());

Vehicle vehicle = new Benz();
vehicle = new YokohomaTyres(vehicle);
Console.WriteLine(vehicle.Cost());

// Singleton singleton = new Singleton();GIT 
Cache cache = new Cache();
