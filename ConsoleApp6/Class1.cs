using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public  class Class1
    {
        public string[]arr=new string[6];
        
        public bool Method()
        {
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = Console.ReadLine();
            }
            foreach(string i in arr)
            {                
                    //for(int j=0;j<6;j++)
                    //{
                    //if (i[j]==)
                    //}                
            }
            return true;
        }
    }
}
