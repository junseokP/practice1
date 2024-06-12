using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn2 : MonoBehaviour
{
    public GameObject prefab;

    // Update is called once per frame
    void Update()
    {
        // 스페이스바를 누르면
        if (Input.GetKeyDown("space"))
        {
            Instantiate(prefab); // 미사일 오브젝트 생성
        }
    }
}
