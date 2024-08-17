namespace Roti;
public class PabrikRotiGandum : PabrikRoti
{
    public override IRoti BuatRoti()
    {
        return new RotiGandum();
    }
}