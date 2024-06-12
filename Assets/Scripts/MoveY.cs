using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveY : MonoBehaviour
{
    public float speed = 5;
    
    // Update is called once per frame
    void Update()
    {
        float delta = speed*Time.deltaTime;
        transform.Translate(0, delta, 0); //초당 5유닛만큼의 속도로 위쪽으로 올라감
    }
}
