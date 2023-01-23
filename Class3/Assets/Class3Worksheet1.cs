using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class3Worksheet1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*
        //Before check
        while (comp(1, 0))
        {
            Debug.Log("Hello");
        }

        // After check
        do
        {
            Debug.Log("Hello");
        } while (comp(1, 0));*/


        for(int x = 0; x < 3; x++)
        {
            for(int y = 0; y < 2; y++)
            {
                for(int z = 0; z < 1; z++)
                {

                }
            }
        }
    }
    
    bool comp(int a, int b)
    {
        return a == b;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}