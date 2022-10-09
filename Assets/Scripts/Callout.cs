using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Callout : MonoBehaviour
{
    [SerializeField] Image image;

    // Start is called before the first frame update

    private void Awake()
    {
        ImageInvisible();
    }
    void Start()
    {
        
        
        StartCoroutine(Fade());
    }

    void ImageInvisible()
    {
        var tempColor = image.color;
        tempColor.a = 0f;
        image.color = tempColor;
    }


    IEnumerator Fade()
    {

        var tempColor = image.color;
        
        for (float alpha = 0f; alpha < 1f; alpha += 0.1f)
        {
            tempColor.a += 0.1f;
            image.color = tempColor;
            yield return new WaitForSeconds(.1f);
        }
    }

}
