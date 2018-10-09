
using System;

namespace Tilfeldige_Firkanter
{
    class Program
    {
        static void Main(string[] args)
        {
            var cell = new VirtualScreenCell();
            cell.AddLowerLeftCorner();
            cell.AddVertical();
            cell.GetCharacter();
            cell.GetCharacter();
            Console.WriteLine(cell.GetCharacter());
        }
    }
}
