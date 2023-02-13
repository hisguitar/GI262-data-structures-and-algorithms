using System.Collections;
using UnityEngine;

public class Class6Worksheet1 : MonoBehaviour
{
    // You can use Dictionary replace to Hashtable (All same)
    // Dictionary better than Hashtable (but hard to use) // KeyValuePair<TKey,TValue>

    public class aventure
    {
        public string hero;
        public string name;
    }

    // Start is called before the first frame update
    void Start()
    {
        aventure a1 = new aventure();
        a1.hero = "IronMan";
        a1.name = "Tony Stark";

        aventure a2 = new aventure();
        a2.hero = "Hulk";
        a2.name = "Bruce Branner";

        Hashtable myHash = new Hashtable();

        myHash.Add("A0005200", a1); // string key ["A0005200"] - a1
        myHash.Add(5, a2); // int key[5] - a2

        Debug.Log( ((aventure) myHash["A0005200"]).hero ); // Print hero by "string key"
        Debug.Log(((aventure)myHash[5]).name); // Print name of hero by "int key"

        /*myHash.Add("A0005200", "Peter Parker");
        myHash.Add("A0077225", "Tony Stark");
        myHash.Add("A1144660", "Bruch Branner");

        ICollection keys = myHash.Keys; // Keys
        ICollection values = myHash.Values; // Values*/

        // Print 1 key
        /*Debug.Log(myHash["A0005200"]);*/
        // ----------------------------------------------------
        // Print all keys
        /*foreach (string k in keys)
        {
            Debug.Log(k);
        }*/
        // ----------------------------------------------------
        // Print all values
        /*foreach (string v in myHash.Values)
        {
            Debug.Log(v);
        }*/
        // ----------------------------------------------------
        // Print element (All keys & values) // --- Recomend this
        /*foreach (DictionaryEntry element in myHash)
        {
            Debug.Log(element.Key + " = " + element.Value);
        }*/

        // myHash.Clear();
    }
}