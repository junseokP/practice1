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
        // 좌측 마우스를 클릭하면
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = trans.position; // 생성위치

            Instantiate(prefab, pos, Quaternion.identity); // prefab이 복제가 되어서 실시간으로 생성됨
        }
    }
}
