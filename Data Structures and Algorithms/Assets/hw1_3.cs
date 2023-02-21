using UnityEngine;

public class hw1_3 : MonoBehaviour
{
    void Start()
    {
        Texture2D texture = new Texture2D(64, 64);
        texture.filterMode = FilterMode.Point;
        GetComponent<Renderer>().material.mainTexture = texture;

        for (int x = 0; x < texture.width; x++)
        {
            int i = Mathf.RoundToInt((texture.height / 2) * (1 + Mathf.Sin((float)x / texture.width * Mathf.PI * 2f)));
            for (int y = 0; y < texture.height; y++)
            {
                if (y == i)
                {
                    texture.SetPixel(x, y, Color.red);
                }
                else
                {
                    texture.SetPixel(x, y, Color.black);
                }
            }
        }
        
        texture.Apply();
    }
}