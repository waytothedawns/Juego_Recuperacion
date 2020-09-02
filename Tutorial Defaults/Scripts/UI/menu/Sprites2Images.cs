using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sprites2Images : MonoBehaviour
{
    public bool convert;

    private void OnValidate()
    {
        if (convert)
        {
            DoConvert();
            convert = false;
        }
    }

    void DoConvert()
    {
        GameObject newGO = new GameObject(transform.name + "_UI");

        for (int i = 1; i <= transform.childCount; i++)
        {
            for (int j = 0; j < transform.childCount; j++)
            {
                SpriteRenderer spriteRenderer = transform.GetChild(j).GetComponent<SpriteRenderer>();
                if (spriteRenderer.sortingOrder == i)
                {
                    Convert(transform.GetChild(j), newGO.transform);
                }
            }
        }
    }

    void Convert(Transform cTransform, Transform newParent)
    {
        SpriteRenderer spriteRenderer = cTransform.GetComponent<SpriteRenderer>();
        GameObject newGO = new GameObject(cTransform.name + "_UI");
        newGO.transform.parent = newParent;

        if (spriteRenderer)
        {
            // Create the image component,
            // set it to the proper size
            Image image = newGO.AddComponent<Image>();
            image.sprite = spriteRenderer.sprite;
            image.SetNativeSize();

            // Position it
            newGO.transform.localPosition = cTransform.localPosition * image.sprite.pixelsPerUnit * 2;
            newGO.transform.localRotation = cTransform.localRotation;
            newGO.transform.localScale = cTransform.localScale;
        }
    }
}
