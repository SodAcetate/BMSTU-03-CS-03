using System;

namespace Lab_03_3
{
    class Program
    {

        class Currency{

            double _value;
            public double Value {get => _value; set => _value = value;}

            public Currency(double value){
                _value = value;
                
            }

        }

        class CurrencyUSD : Currency{
            public CurrencyUSD(double value) : base(value) { }
            public static implicit operator CurrencyEUR(CurrencyUSD val) => new CurrencyEUR(val.Value*1.01);
            public static implicit operator CurrencyRUB(CurrencyUSD val) => new CurrencyRUB(val.Value*60.87);
        }
        class CurrencyEUR : Currency{
            public CurrencyEUR(double value) : base(value) { }
            public static implicit operator CurrencyRUB(CurrencyEUR val) => new CurrencyRUB(val.Value*60.21);
            public static implicit operator CurrencyUSD(CurrencyEUR val) => new CurrencyUSD(val.Value*0.99);

        }
        class CurrencyRUB : Currency{
            public CurrencyRUB(double value) : base(value) { }
            public static implicit operator CurrencyUSD(CurrencyRUB val) => new CurrencyUSD(val.Value*0.016);
            public static implicit operator CurrencyEUR(CurrencyRUB val) => new CurrencyEUR(val.Value*0.016);
            
        }

        static void Main(string[] args)
        {
            
            CurrencyRUB roubles = new CurrencyRUB(1000);
            CurrencyUSD dollars = (CurrencyUSD)roubles;
            CurrencyEUR euros = (CurrencyEUR)roubles;
            Console.WriteLine($"1000 roubles is {dollars.Value} dollars");
            Console.WriteLine($"1000 roubles is {euros.Value} euros");

            euros.Value = 1000;
            roubles = (CurrencyRUB)euros;
            dollars = (CurrencyUSD)euros;
            Console.WriteLine($"1000 euros is {dollars.Value} dollars");
            Console.WriteLine($"1000 euros is {roubles.Value} roubles");

            dollars.Value = 1000;
            roubles = (CurrencyRUB)dollars;
            euros = (CurrencyEUR)dollars;
            Console.WriteLine($"1000 dollars is {euros.Value} euros");
            Console.WriteLine($"1000 dollars is {roubles.Value} roubles");

        }

    }
}