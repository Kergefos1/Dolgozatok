using ConsoleApp1;

Vehicle vehicle = new Vehicle("ABC-123", 2002, true);
Vehicle vehicle2 = new Vehicle("CBF-423", 2003, true);
Vehicle vehicle3 = new Vehicle("ABG-223", 2004, false);
Vehicle vehicle4 = new Vehicle("ABD-537", 0, true);
Console1 console = new Console1();
List<Vehicle> vehicles = new();

vehicle.TopUp(2000);
vehicle2.TopUp(5000);
vehicle3.TopUp(4500);

vehicle.Park(3);
vehicle4.Park(2);
vehicle2.Park(0);

vehicles.Add(vehicle);
vehicles.Add(vehicle2);
vehicles.Add(vehicle3);
vehicles.Add(vehicle4);

console.ShowMessage("szia");
console.ShowVehicle(vehicle);
console.ShowVehicles(vehicles);

//A Main-ben hozz létre egy parkolóházat, amelynek kapacitása eggyel kisebb, mint a listád hossza,
//és próbáld meg felvenni az összes járművet. Írasd ki a parkolóház nevét, kapacitását és a felvett
//járművek számát a Vehicles property segítségével

Garage gar = new Garage("Szombathely", 4);

