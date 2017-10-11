//---------------------------------------------- 
// SoundEngineer.cs (c) 2006 by Charles Petzold 
//---------------------------------------------- 
class SoundEngineer : Musician
{
    /* Guarantees that the base method is excecuted first
     * but this method doesn't add anything to the base
     * 
     * Every constructor with parameters has to be included
     * in the derived classes. Even if not adding to it*/
    public SoundEngineer(string strName)
        : base(strName)
    {
    }
    /*Calls the base method but add's a % to it*/
    public override decimal CalculatePay()
    {
        return 1.75m * base.CalculatePay();
    }
}