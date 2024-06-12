using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;

    public float interval = 1;

    Vector2 hs;
    // Start is called before the first frame update
    void Start()
    {
        hs.x = Camera.main.orthographicSize -2;
        hs.y = Camera.main.aspect * hs.x -2;

        StartCoroutine(Spawn(interval));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Spawn(float delta)
    {
        while(true)
        {
            Vector2 targetPos;
            targetPos.x = Random.Range(-hs.x,hs.x);
            targetPos.y = Random.Range(-hs.y,hs.y);

            int numType = Random.Range(0, 4);
            if (numType==0)
            {
                Instantiate(enemy1,targetPos,transform.rotation);
            }
            if (numType==1)
            {
                Instantiate(enemy2,targetPos,transform.rotation);
            }
            if (numType==2)
            {
                Instantiate(enemy3,targetPos,transform.rotation);
            }
            if (numType==3)
            {
                Instantiate(enemy4,targetPos,transform.rotation);
            }

            yield return new WaitForSeconds(delta);
        }
    }
}
