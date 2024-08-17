namespace Roti;
public class PabrikRotiBagel : PabrikRoti
{
    public override IRoti BuatRoti()
    {
        return new RotiGandum();
    }
}