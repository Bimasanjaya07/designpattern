namespace Roti;
public class PabrikRotiTawar : PabrikRoti
{
    public override IRoti BuatRoti()
    {
        return new RotiGandum();
    }
}