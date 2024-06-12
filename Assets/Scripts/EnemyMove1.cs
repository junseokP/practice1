using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove1 : MonoBehaviour
{
    public float speed = 3;
    Vector2 hs; //��ũ�� ���� ������ 
    Vector2 dir; //����

    // Start is called before the first frame update
    void Start()
    {
        hs.x = Camera.main.orthographicSize;
        hs.y = Camera.main.aspect * hs.x;

        StartCoroutine(ChangeDir(1f));
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 del = dir * speed * Time.deltaTime;
        transform.Translate(del);
    }

    IEnumerator ChangeDir(float del)
    {
        Vector2 goal;

        while (true)
        {
            goal.x = Random.Range(-hs.x, hs.x);
            goal.y = Random.Range(-hs.y, hs.y);

            dir = goal - (Vector2)transform.position;
            dir.Normalize();

            float delay = Random.Range(1f, del);
            yield return new WaitForSeconds(delay);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        string cgTag = collision.gameObject.tag;
        if (cgTag=="Hero"||cgTag=="HeroBul")
        {
            Destroy(gameObject);

            ScoreMng.inst.AddScore(10);
        }
    }
}
