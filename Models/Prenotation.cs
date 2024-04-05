using System;
using galli.mingucci._5i.Progetto_E_Commerce;
public class Prenotation
{
    public int HoursPrenoted { get; set; }
    public int PeopleNumber { get; set; }
    public string? ChoosenCircuit { get; set; }
    public List<Bike>? ChoosenBikes { get; set; }
    public double PTotMoto { get; set; }
    public double CircuitPrice { get; set; }
    //[Key]
    public double TotalBill { get; set; }
    public DateTime Date {get; set;}

    //foreign key
    public User User {get; set;}
}
