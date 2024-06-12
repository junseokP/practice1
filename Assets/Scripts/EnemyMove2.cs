using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove2 : MonoBehaviour
{
    public float speed = 3;
    Vector2 dir;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ChangeDir(3f));

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 delPos = dir * speed * Time.deltaTime;
        transform.Translate(delPos);
    }

    IEnumerator ChangeDir(float del)
    {
        GameObject targetObj = GameObject.FindWithTag("Hero");

        while (targetObj != null)
        {
            Vector2 goal = targetObj.transform.position;
            dir = goal - (Vector2)transform.position;
            dir.Normalize();

            float changeTime = Random.Range(1f, del);
            yield return new WaitForSeconds(changeTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        string cgTag = collision.gameObject.tag;
        if (cgTag=="Hero"||cgTag=="HeroBul")
        {
            Destroy(gameObject);

            ScoreMng.inst.AddScore(20);
        }
    }
}
