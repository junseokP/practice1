using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBul2 : MonoBehaviour
{
    public float speed = 3;
    Vector2 dir;

    // Start is called before the first frame update
    void Start()
    {
        calDir();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 delPos = dir * speed * Time.deltaTime;
        transform.Translate(delPos);
    }

    void calDir()
    {
        GameObject targetObj = GameObject.FindWithTag("Hero");

       if(targetObj!=null)
        {
            Vector2 goal = targetObj.transform.position;
            dir = goal - (Vector2)transform.position;
            dir.Normalize();
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
