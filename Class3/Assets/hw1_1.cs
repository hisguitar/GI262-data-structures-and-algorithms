using UnityEngine;

public class hw1_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Texture2D texture = new Texture2D(16, 16); // Number in () is quality of texture
        texture.filterMode = FilterMode.Point; // Minecraft filter
        GetComponent<Renderer>().material.mainTexture = texture;

        for(int y = 0; y < texture.height; y++)
        {
            for(int x = 0; x < texture.width; x++)
            {
                Color color;
                if (y % 2 == 0)
                {
                    if (x % 2 == 0)
                    { color = Color.black; }
                    
                    else
                    { color = Color.white; }
                }
                else
                {
                    if (x % 2 == 0)
                    { color = Color.white; }
                    
                    else
                    { color = Color.black; }
                }

                texture.SetPixel(x, y, color);
            }
        }
        texture.Apply();
    }
}