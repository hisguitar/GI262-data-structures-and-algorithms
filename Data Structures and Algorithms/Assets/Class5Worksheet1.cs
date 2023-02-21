using UnityEngine;

public class Class5Worksheet1 : MonoBehaviour
{
    string myName()
    {
        return "IronMan";
    }

    /*public string doGrade(int _score)
    {
        string result;
        if(_score > 80)
        {
            return "A";
        }
        else if(_score > 70)
        {
            return "B";
        }
        else if(_score > 60)
        {
            return "C";
        }
        else if(_score > 50)
        {
            return "D";
        }
        else
        {
            return "F";
        }
    }*/
    // -----------------------
    // Overloading Method
    int add(int a, int b)
    {
        return a + b;
    }
    float add(float a, float b)
    {
        return a + b;
    }
    int add(int a, int b, int c)
    {
        return a * b * c;
    }
    // Start is called before the first frame update
    private void Start()
    {
        // Debug.Log(doGrade(55));
        // -----------------------
        // Overloading Method
        Debug.Log(add(1, 2));
        Debug.Log(add(1, 2, 3));
    }
}