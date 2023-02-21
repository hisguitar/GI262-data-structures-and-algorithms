using UnityEngine;

public class hw1_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Texture2D texture = new Texture2D(32, 32);
        texture.filterMode = FilterMode.Point; // Minecraft filter
        GetComponent<Renderer>().material.mainTexture = texture;

        for(int y = 0; y < texture.height; y++)
        {
            for(int x = 0; x < texture.width; x++)
            {
                Color color;
                if (y/2 < x)
                {
                    if (x < texture.width/2)
                    { color = Color.green; }
                    
                    else if (x >= texture.width/2 && texture.width-y/2 > x+1)
                    { color = Color.green; }
                    
                    else
                    { color = Color.black; }
                }
                else
                {
                    color = Color.black;
                }

                texture.SetPixel(x, y, color);
            }
        }
        texture.Apply();
    }
}