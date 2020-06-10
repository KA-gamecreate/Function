using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CulculateTriangle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float area = CulculateTriangleArea(10, 10);
        if (area > 25)
        {
            Debug.Log("広いね！");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    float CulculateTriangleArea(float width, float height)
    {
        float result = width * height / 2;
        return result;
    }
}
