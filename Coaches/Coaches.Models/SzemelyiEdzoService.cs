using Coaches.Models;

public class SzemelyiEdzoService
{
    private readonly MyDnndatabaseContext _context;

    public SzemelyiEdzoService(MyDnndatabaseContext context)
    {
        _context = context;
    }

    public void AddEdzo(string nev, int oraber)
    {
        var edzo = new SzemelyiEdzok
        {
            Nev = nev,
            Oraber = oraber
        };

        _context.SzemelyiEdzok.Add(edzo);
        _context.SaveChanges();
    }
}
