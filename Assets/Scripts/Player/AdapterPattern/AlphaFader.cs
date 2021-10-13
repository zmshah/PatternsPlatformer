// Written by Nishitha
//Adapter pattern

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlphaFader : MonoBehaviour
{
    ColorAdapter colorAdapter;
    float fade_percentage = 1;

    // Start is called before the first frame update
    private void Start()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        Image image = GetComponent<Image>();
        if (spriteRenderer != null)
        {
            colorAdapter = new AdaptedSpriteRender(spriteRenderer);
        }
        else
        {
            colorAdapter = new AdaptedImage(image);
        }
     }

    // Update is called once per frame
    private void update()
    {
        if (Input.GetKeyDown("space"))
        {
            FadeFunction();
        }
    }

    // This modifies the color and fade.
    public void FadeFunction()
    {
        fade_percentage = Random.Range(0f, 1f);
        colorAdapter.color = new Color(
            colorAdapter.color.r,
            colorAdapter.color.g,
            colorAdapter.color.b,
            fade_percentage);
    }
}
