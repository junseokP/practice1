using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remove2 : MonoBehaviour
{
    public float delay = 3;
    // Start is called before the first frame update
    // Start�Լ��� ���� ����� �־ Ű���带 �����ų� ���콺�� Ŭ���ϴ� ���� ��ȣ�ۿ� ���� �ڵ����� 3�ʵڿ� ���������
    void Start()
    {
        Destroy(gameObject, delay); // 3�� �ڿ� object�� �����
    }

    
}
