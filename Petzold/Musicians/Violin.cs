//--------------------------------------- 
// Violin.cs (c) 2006 by Charles Petzold 
//--------------------------------------- 
class Violin : Musician
{
    int numBrokenStrings;

    /* Calls the base for constructing the musician's name 
     *  and adds a field to the default constructor */
    public Violin(string strName, int numBrokenStrings)
        : base(strName)
    {
        this.numBrokenStrings = numBrokenStrings;
    }
    /* With the new field numBrokenStrings, implements 
     * a new CalculatePay() method
     */
    public override decimal CalculatePay()
    {
        return 125 - 50 * numBrokenStrings;
    }
}