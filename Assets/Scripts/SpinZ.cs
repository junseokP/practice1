using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinZ : MonoBehaviour
{
    public float degree = 360;
    // Update is called once per frame
    void Update()
    {
        float delta = degree * Time.deltaTime;
        transform.Rotate(0, 0, delta); // 초당 Z축 방향으로 360도 회전
    }
}
