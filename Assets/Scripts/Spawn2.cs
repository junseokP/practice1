using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn2 : MonoBehaviour
{
    public GameObject prefab;

    // Update is called once per frame
    void Update()
    {
        // �����̽��ٸ� ������
        if (Input.GetKeyDown("space"))
        {
            Instantiate(prefab); // �̻��� ������Ʈ ����
        }
    }
}
