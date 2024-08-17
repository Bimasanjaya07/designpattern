namespace Roti;
class Program
{
    static void Main()
    {
        RotiGandum rotiGandum = new RotiGandum();
        rotiGandum.Resep();
        rotiGandum.Panggang();

        RotiBagel rotiBagel = new RotiBagel();
        rotiBagel.Resep();
        rotiBagel.Panggang();

        RotiTawar rotiTawar = new RotiTawar();
        rotiTawar.Resep();
        rotiTawar.Panggang();
    }
}
