namespace Roti;
class Program
{
    static void Main()
    {
        PabrikRoti pabrikRotiGandum = new PabrikRotiGandum();
        IRoti rotiGandum = pabrikRotiGandum.BuatRoti();
        rotiGandum.Resep();
        rotiGandum.Panggang();

        PabrikRoti pabrikRotiTawar = new PabrikRotiTawar();
        IRoti rotiTawar = pabrikRotiTawar.BuatRoti();
        rotiTawar.Resep();
        rotiTawar.Panggang();

        PabrikRoti pabrikRotiBagel = new PabrikRotiBagel();
        IRoti rotiBagel = pabrikRotiBagel.BuatRoti();
        rotiBagel.Resep();
        rotiBagel.Panggang();
    }
}
