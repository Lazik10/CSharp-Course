using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Collections
{
    internal class Dictionary // NonGenericVariant is HashTable !!! 
    {
        /// Dictionary
        // - has unique keys
        // - items stored in these keys are values
        // - used when we are looking for an item by its attribute
        // - it DOESN'T guarantee the same position of items!!! if we loop through each time the result can be different!!!
        // - 

        /// Methods
        // Add(key, value)              - adds new key and assigns a value to it
        // Clear()                      - clears all keys in a dictionary
        // ContainsKey(key)             - returns true if key exists in a dictionary
        // ContainsValue(value)         - returns true if value exists in a dictionary
        // Count                        - returns number of keys in a Dictionary
        // Keys                         - returns collection of keys in a Dictionary
        // Remove(key)                  - removes key from a Dictionary
        // TryGetValue(key, out value)  - tries to return a value, if it fails it returns false
        // Values                       - reutrns collection of values

        /// Different initializations:

        //      Dictionary<string, string> dictionary = new Dictionary<string, string>();
        //      dictionary.Add("cat", "kočka");
        //      dictionary.Add("mouse", "myš");
        //      dictionary.Add("computer", "počítač");

        //      var slovnik = new Dictionary<string, string>
        //      {
        //          ["cat"] = "kočka",
        //          ["mouse"] = "myš",
        //          ["computer"] = "počítač"
        //      };

        // OLD!!!
        //      var slovnik = new Dictionary<string, string>
        //      {
        //          { "cat", "kočka" },
        //          { "mouse", "myš" },
        //          { "computer", "počítač" }
        //      };
    }
}
