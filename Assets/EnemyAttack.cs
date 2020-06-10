using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AttackEnemy("ゾンビ"　, 20);
        AttackEnemy("お化け", 80);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void AttackEnemy(string everyname, int damage)
    {
        Debug.Log(everyname + "に" + damage + "のダメージ！");
    }
}
