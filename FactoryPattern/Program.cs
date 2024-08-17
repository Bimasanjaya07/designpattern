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
        IRoti rotiPutih = pabrikRotiTawar.BuatRoti();
        rotiPutih.Resep();
        rotiPutih.Panggang();

        PabrikRoti pabrikRotiBagel = new PabrikRotiBagel();
        IRoti rotiMultigrain = pabrikRotiBagel.BuatRoti();
        rotiMultigrain.Resep();
        rotiMultigrain.Panggang();
    }
}
