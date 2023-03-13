using UnityEngine;

public class Class2Worksheet1 : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        int hp = 100;
        int mp = 200;

        hp = hp - 20; // Something take your hp -20
        
        Debug.Log("START");
        
        // if and else if == 1 condition
        // if and else    == 1 condition
        // if and if      == 2 conditions
        
        // ----------------------------------
        if ((hp > 50) && (mp > 100))
        {
            Debug.Log("Life is ok!");
        }
        else
        {
            Debug.Log("You DOOM!");
        }
        // ----------------------------------
        if (hp > 90)
        {
            Debug.Log("hp is high");
        }
        else if (hp > 50)
        {
            Debug.Log("hp is medium");
        }
        else if (hp > 20)
        {
            Debug.Log("hp is low");
        }
        else
        {
            Debug.Log("hp is very low");
        }
        
        // ----------------------------------
        if (hp == 100)
        {
            Debug.Log("hp is full");
        }
        
        Debug.Log("END");
    }
}