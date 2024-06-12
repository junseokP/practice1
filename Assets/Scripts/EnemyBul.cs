using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBul : MonoBehaviour
{
    public float speed = 3;
    Vector2 hs; //��ũ�� ���� ������ 
    Vector2 dir; //����

    // Start is called before the first frame update
    void Start()
    {
        hs.x = Camera.main.orthographicSize;
        hs.y = Camera.main.aspect * hs.x;

        CalDir();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 del = dir * speed * Time.deltaTime;
        transform.Translate(del);
    }

    void CalDir()
    {
        Vector2 goal;
        goal.x = Random.Range(-hs.x, hs.x);
        goal.y = Random.Range(-hs.y, hs.y);

        dir = goal - (Vector2)transform.position;
        dir.Normalize();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
