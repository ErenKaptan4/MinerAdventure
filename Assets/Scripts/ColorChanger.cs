using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] int count = 0;
    [SerializeField] Color[] colorList;

    public void ChangeColor()
    {
        if (count < colorList.Length)
        {
            gameObject.GetComponent<Image>().color = new Color(colorList[count].r, colorList[count].g, colorList[count].b);
            if(count == colorList.Length -1)
            {
                count = -1;
            }
            count += 1;
        }
        
    }
}
