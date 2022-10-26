using System;

namespace Lab_03_2
{

class Program


{

    class Car : IEquatable<Car> {
        string _name;
        string _engine;
        short _maxSpeed;

        public Car (string name, string engine, short maxSpeed){
            _name = name;
            _engine = engine;
            _maxSpeed = maxSpeed;
            Console.WriteLine($"Created new car: {_name}, {_engine}, {_maxSpeed}км/ч");
        }

        public string Name {get  => _name ; set => _name = value;}
        public string Engine {get  => _engine ; set => _engine = value;}

        public override string ToString(){
            return _name;
        }
        
        public bool Equals (Car? other) => other.ToString() == this.ToString();

    }

    class CarsCatalog {

        Car[] ?_cars;
        public int Length{ get => _cars.Length; }

        public CarsCatalog(Car[] src){
            _cars = new Car[src.Length];
            for (int i = 0 ; i < src.Length ; i ++){
                _cars[i] = src[i];
            }
        }

        public string this[int index]{
            get => _cars[index].Name + ", " + _cars[index].Engine;
        }

    }


static void Main(string[] args){

    Car test1 = new Car("Лада","Крутой",5000);
    Car test2 = new Car("Лада","Крутой",5000);
    Console.WriteLine($"{test1.Equals(test2)}");
    Car test3 = new Car("Мерс","Не крутой",100);
    Console.WriteLine($"{test1.Equals(test3)}");

    Car[] testArray = { new Car("Лада","Крутой",5000),
                        new Car("Мерс","Не крутой",100),
                        new Car("Тойота Труено АЕ86","Самый вообще лучший",10000) };

    CarsCatalog testCatalog = new CarsCatalog(testArray);

    for (int i = 0 ; i < testCatalog.Length ; i++){
        Console.WriteLine(testCatalog[i]);
    }


}


}


}