namespace Roti;
public class PabrikRotiBagel : PabrikRoti // Concrete Creator   
{
    public override IRoti BuatRoti()
    {
        return new RotiGandum();
    }
}