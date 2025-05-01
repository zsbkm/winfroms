using Coaches.Models;
using System.Linq;

public class EdzoTorlesService
{
    private readonly MyDnndatabaseContext _context;

    public EdzoTorlesService(MyDnndatabaseContext context)
    {
        _context = context;
    }

    public bool ProbalTorolni(int edzoId)
    {
        var szerepel = _context.Foglalasok.Any(f => f.SzemelyiEdzoId == edzoId);
        var edzo = _context.SzemelyiEdzok.FirstOrDefault(x => x.Id == edzoId);

        if (edzo == null) return false;

        if (szerepel)
        {
            edzo.Aktiv = false;
        }
        else
        {
            _context.SzemelyiEdzok.Remove(edzo);
        }

        _context.SaveChanges();
        return true;
    }
}
