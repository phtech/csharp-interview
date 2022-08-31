using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public interface  IVehicle
    {
        int GetNumberOfWheels();
        int GetTopSpeed();
        string Color { get; set; }
    }

    // Create two classes that implement this interface

    // One class should be a Motorcycle, the other a Truck

    // Create an instance of each class
    // A green motorcycle with a top speed of 200mph
    // An Orange truck (go Beavers) with a top speed of 95mph
    
}
