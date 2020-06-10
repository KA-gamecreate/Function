using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionWithArg : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ShowRectangleArea(4,6);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ShowRectangleArea(float width , float height)
    {
        float area = width * height;
        Debug.Log("面積は"　+ area + "です！");
    }

    void ShowSquareArea(float width)
    {
        float area = width * width;
        Debug.Log("面積は" + area + "です！");
    }

    void HelloYourName(string yourName)
    {
        Debug.Log("Hello " +yourName + " !");
    }
}
