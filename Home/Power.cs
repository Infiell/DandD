namespace DandD.Home
{
    internal class Power
    {
        public int PowerPerPoint { get; set; } = 10;
    }

    public class PowerCalc
    {
        public int Calculator(int pointStrength, int pointsConstitution, int pointsDexterity, int pointsIntelligence, int pointsWisdom, 
            int pointsCharisma)
        {
            var PPP = new Power().PowerPerPoint;
            return (pointStrength + pointsConstitution + pointsDexterity + pointsIntelligence + pointsWisdom + pointsCharisma) * PPP;
        }
    }
}
