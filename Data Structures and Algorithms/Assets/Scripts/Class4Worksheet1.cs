using System.Collections.Generic;
using UnityEngine;

public class Class4Worksheet1 : MonoBehaviour
{
    List<int> myListInt = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        myListInt.Add(13);
        myListInt.Add(69);
        myListInt.Add(77);

        myListInt.Insert(1, 88);

        myListInt.RemoveAt(2);

        for (int i = 0; i < myListInt.Count; i++)
        {
            Debug.Log(myListInt[i]);
        }
    }
}