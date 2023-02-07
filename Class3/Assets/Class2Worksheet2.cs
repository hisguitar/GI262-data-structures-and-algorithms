using UnityEngine;

public class Class2Worksheet2 : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        int choice = 0;

        switch (choice)
        {
            case 0: {
                        Debug.Log("Choice 1");
                        break;
                }
            case 1: {
                        Debug.Log("Choice 2");
                        break; 
                    }
            case 2: {Debug.Log("Choice 3"); break;}
            default: {Debug.Log("Choice Unknown"); break;}
        }
    }
}