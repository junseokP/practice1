using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remove : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // ���콺 �����ʹ�ư�� Ŭ���ϸ�
        if (Input.GetMouseButtonDown(1)) 
        {
            Destroy(gameObject); // object ����
        }
    }
}
