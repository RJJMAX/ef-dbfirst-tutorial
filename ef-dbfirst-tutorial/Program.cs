using Microsoft.EntityFrameworkCore;
using ef_dbfirst_tutorial.Models;
using ef_dbfirst_tutorial;

//get all
var ordlCtrl = new OrderLinesController();

//var ordLines = await ordlCtrl.GetByIdAsync(1);

//Console.WriteLine(ordLines);

//ordLines.OrdersId = 2;

//await ordlCtrl.UpdateAsync(ordLines);

//new line
var order = new OrderLine() {
    Id = 0,
    OrdersId = 1,
    Product = "Echo",
    Description = "Amazon Echo",
    Quantity = 3,
    Price = 100
};

var success = await ordlCtrl.InsertAsync(order);
Console.WriteLine(success ? "Deleted" : "It Failed");


//Console.WriteLine(ord);

//var orderTotal = ord.OrderLines.Sum(x => x.Price * x.Quantity);

//Console.WriteLine($"Order Total is {orderTotal:C}");

//orders.ForEach(ord => Console.WriteLine(ord));

//ordLine.OrdersId = 2;
//await ordlCtrl.UpdateAsync(ordLine);



///////////////////////////////////////////////


//var orders = await ordlCtrl.GetAllAsync();


//orders.ForEach(ordlCtrl => Console.WriteLine(ordLines));








//var ordCtrl = new OrdersController();

//bool success = await ordCtrl.DeleteAsync(27);





//var custCtrl = new CustomersController();

//var success = await custCtrl.DeleteAsync(36);

//var bootcamp = await custCtrl.GetByIdAsync(36);

//bootcamp.Sales = 5000;

//var success = await custCtrl.UpdateAsync(bootcamp);

/////////////ADD/////////////
//var cust = new Customer() {
//    Id = 0,
//    Name = "Bootcamp",
//    City = "Corpus Christi",
//    State = "TX",
//    Sales = 0,
//    Active = true
//};

//var success = await custCtrl.InsertAsync(cust);




//var order = await ordCtrl.GetByIdAsync(1);
//Console.WriteLine(order);
//var orders = await ordCtrl.GetAllAsync(1);
//var orders = await ordCtrl.GetAllAsync();
//var orders = await _context.Orders.ToListAsync();
//orders.ForEach(x => Console.WriteLine(x.Description));


//Console.WriteLine(success ? "OK" : "Failed");

//////////////GET BY ID////////////////////
//var cust = await custCtrl.GetByIdAsync(1);
//foreach (var cust in await custCtrl.GetAllAsync()) {
//    Console.WriteLine(cust.Name);
//}

//Console.WriteLine(cust.Name);





//var dbc = new SalesdbContext();

////var customer = await GetById(1);

//var customers = await GetAll();

//foreach (var cust in customers) { 
//Console.WriteLine(cust.Name);
//}
//////////////GET ALL/////////////////
//async Task<List<Customer>> GetAll() {
//        return await dbc.Customers.ToListAsync();
//    }

////Console.WriteLine(cust.Name);

//async Task<Customer> GetById(int id) { 
//        return await dbc.Customers.FindAsync(id);


//}


//var ordersWithCusomers = from o in dbc.Orders
//                         join c in dbc.Customers
//                            on o.CustomerId equals c.Id
//                            orderby c.Name
//                         select new {
//                             Id = o.Id,
//                             Desc = o.Description,
//                             Customer = c.Name
//                         };

//foreach(var oc in ordersWithCusomers) {
//    Console.WriteLine($"{oc.Id,2} | {oc.Desc,-30} | {oc.Customer,-30}");
//}

//var orders = from o in dbc.Orders
//             select o;

//foreach(var order in orders) {
//    Console.WriteLine(order.Description);
//}

//var customers = dbc.Customers.Where(x => x.City == "Cincinnati")
//                            .OrderByDescending(x => x.Sales)
//                            .ToList();

//foreach(var customer in customers) {
//    Console.WriteLine(customer.Name);

//}
//var order = new Order() {
//    Id = 0,
//    Date = new DateTime(2023, 2, 23), Description = "New Kroger Order", CustomerId = 1
//};