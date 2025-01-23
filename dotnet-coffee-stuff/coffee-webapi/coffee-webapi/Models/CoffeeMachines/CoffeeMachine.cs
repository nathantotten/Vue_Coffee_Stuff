namespace coffee_webapi.Models.CoffeeMachines;

public class CoffeeMachine
{
    public int Id { get; set; }
    public string Manufacturer { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public decimal Price { get; set; }
}