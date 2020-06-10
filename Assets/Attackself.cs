using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attackself : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Attack(60);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Attack(int damage)
    {
        Debug.Log("自分に" + damage + "のダメージ！");

    }
}
