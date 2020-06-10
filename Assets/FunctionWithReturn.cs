using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionWithReturn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float area1 = CalculRectangleArea(4.0f , 6.0f);
        float area2 = CalculRectangleArea(5.0f , 5.0f);

        if (area1 > area2)
        {
            Debug.Log("エリア１の方が広い");
        }else if (area1 < area2)
        {
            Debug.Log("エリア２の方が広い");
        }
        else
        {
            Debug.Log("同じ広さ");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float CalculRectangleArea(float width , float height)
    {
        float result = width * height;
        return result;
    }
}
