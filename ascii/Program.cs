using System.Formats.Asn1;
using System.Xml.Linq;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int assciv = Convert.ToInt32(Console.ReadLine()); //asing the int value
            //char value = (char)assciv; //coverting integer value of character ascii
            //Console.WriteLine(value); // ans the chatechter of 65
            
            //char va = 'H'; //charecter
            //int sb= (int)va;// coverting charecter value of integer ascii
            //Console.WriteLine("the value of h is "+sb); //ans the interger of h

            int bh =Convert.ToInt32(Console.ReadLine());
             //char hb = (char)bh;

            while(bh<=127)
            {
                char hb = (char)bh;
                Console.WriteLine("value of assci is" +hb);
                ++bh;
            }
            
        }
    }
}
