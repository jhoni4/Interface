using System;

namespace ConsoleApplication
{
    public class Wolf : Icanine
    {
        public int GestationDay{get;set;}
        public string CoatColor{get;set;}
        // public string range{get;set;}
        public string CommonName{get;set;}
        public bool IsDomesticated{get;set;}
        public string GetRange(string name) {
            return $"Range for {this.CommonName}";
        }

    }
}    