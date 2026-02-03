namespace CarsListWeb.Models;

public class AppSettings
{
    public List<RepositorySetting> Repositories { get; set; } = [];
}

public class RepositorySetting
{
    public string Model { get; set; } = string.Empty;
    public int Year { get; set; }
    public decimal MinPrice { get; set; }
    public decimal MaxPrice { get; set; }
}
