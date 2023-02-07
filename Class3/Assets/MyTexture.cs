using UnityEngine;

public class MyTexture : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Texture2D texture = new Texture2D(8, 8); // Number in () is quality of texture
        texture.filterMode = FilterMode.Point; // Minecraft filter
        GetComponent<Renderer>().material.mainTexture = texture;

        for(int y = 0; y < texture.height; y++)
        {
            for(int x = 0; x < texture.width; x++)
            {
                // y % 2 = 1 (odd number as 1, 3, 5, 7, 9)
                // y % 2 = 0 (even number as 2, 4, 6, 8, 10)
                
                // Color color = ((x & y) != 0 ? Color.white : Color.gray);
                
                Color color;
                if ((y % 2) == 0) // (y == 3) // ((x & y) != 0)
                    color = Color.white;
                else
                    color = Color.gray;

                texture.SetPixel(x, y, color);
            }
        }
        texture.Apply();
    }
}