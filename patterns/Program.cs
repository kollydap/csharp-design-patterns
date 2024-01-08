// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Duck mallard = new MullardDuck();
// mallard.PerformQuack();

// UserAccount user = new FreeUserAccount("kola", 22);
// // Console.WriteLine(user.MAkePAYMENT());
// user.MAkePAYMENT(2000, 7000);

WeatherData weatherData = new WeatherData();

CurrentConditionDisplay currentConditionDisplay = new CurrentConditionDisplay(weatherData);

weatherData.SetMeasurements(20, 39, 90);

