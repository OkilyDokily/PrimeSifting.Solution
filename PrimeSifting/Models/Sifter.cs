using System.Collections.Generic;
using System.Linq;

namespace PrimeSifting.Models
{
    public class Sifter
    {
        public List<string> _initalList;
        public Sifter(int number){
           string[] str = Enumerable.Repeat("O", number).ToArray();
           str[0] = "X";
           _initalList = new List<string>(str);
        }
    }
}