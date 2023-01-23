using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class3Worksheet2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // int[] myArray = new int[5]; // 5(x) Element
        // int[] myArray2 = { 11, 22, 33, 44, 55 }; // 5(x) Element
        // int[] myArray3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // 10(x) Element
        int[,] myArray4 = new int[5, 5]; // 5(x) * 5(y) = 25(table) Element

        // Debug.Log(myArray2[0]);
        // --------------------------------------------------------------------
        /* for(int x = 0; x < 5; x++)
        {
            Debug.Log(myArray[x]);
        } */
        // --------------------------------------------------------------------
        /* for(int x = 0; x < myArray3.Length; x++)
        {
            Debug.Log(myArray3[x]);
        } */
        // --------------------------------------------------------------------
        for (int x = 0; x < 5; x++)
        {
            for(int y = 0; y < 5; y++)
            {
                myArray4[x, y] = 1; // Set the position of x,y to be 1
            }
            /* Overview of this loop is
            x = 0 & y = 1,2,3,4 || x = 1 & y = 1,2,3,4 || x = 3 & y = 1,2,3,4 */
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}