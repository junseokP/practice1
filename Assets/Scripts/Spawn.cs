using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject prefab;
    public Transform trans;

    // Update is called once per frame
    void Update()
    {
        // ���� ���콺�� Ŭ���ϸ�
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = trans.position; // ������ġ

            Instantiate(prefab, pos, Quaternion.identity); // prefab�� ������ �Ǿ �ǽð����� ������
        }
    }
}
