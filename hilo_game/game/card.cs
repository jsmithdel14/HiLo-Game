public class Card
{
    public int value = 0;
    
    public Card(int value=0)
    {
        this.value = value;
    }

    public void Pull()
    {
        Random pull = new Random();
        value = pull.Next(1,14);
        
         
    }
    public int getValue(){
        return value;
    }
}
