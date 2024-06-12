using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remove : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // 마우스 오른쪽버튼을 클릭하면
        if (Input.GetMouseButtonDown(1)) 
        {
            Destroy(gameObject); // object 제거
        }
    }
}
