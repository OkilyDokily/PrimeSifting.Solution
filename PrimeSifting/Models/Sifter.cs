using System.Collections.Generic;
using System.Linq;
using System;
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

        public List<int> Sift(){
            int index = 2;
            while(true){
                int ic = index * 2;
                while(true){
                    if(ic > _initalList.Count){
                        break;
                    }
                    _initalList[(ic-1)] = "X";
                    ic+=index;
                }
                index++;
                if(index > _initalList.Count){
                    break;
                }
            }
            return OperateOnFinalList(); 
        }

        public List<int> OperateOnFinalList(){
            List<int> pl = new List<int>();
            
            int index = 1;
            foreach(string str in _initalList){
                if (str == "O"){
                    pl.Add(index);
                }
                index++;
            }
          
            return pl;
        }
    }
}