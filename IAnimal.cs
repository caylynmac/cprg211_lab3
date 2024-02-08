using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal interface IAnimal
    {
        //fields must be properties! default public!
        string name { get; set; }
        string colour {  get; set; }
        string height { get; set; }
        string age { get; set; }

        void Eat(); //all methods in interface are abstract by default 

        void Cry();
    }
}
