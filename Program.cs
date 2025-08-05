namespace Reversenum
{
    internal class Program
    {
       public  static void Main(string[] args)
        {
            Reversenum obj = new Reversenum(); 

            obj.ReadData();    
            obj.Reverse();      
            obj.Display();
        }
    }
}
