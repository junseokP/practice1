using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remove2 : MonoBehaviour
{
    public float delay = 3;
    // Start is called before the first frame update
    // Start함수에 삭제 명령을 넣어서 키보드를 누르거나 마우스를 클릭하는 등의 상호작용 없이 자동으로 3초뒤에 사라지게함
    void Start()
    {
        Destroy(gameObject, delay); // 3초 뒤에 object가 사라짐
    }

    
}
