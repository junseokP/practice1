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
        transform.Translate(0, delta, 0); //�ʴ� 5���ָ�ŭ�� �ӵ��� �������� �ö�
    }
}
