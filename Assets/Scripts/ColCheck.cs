using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColCheck : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        print("�浹");

    }

    void OnCollisionStay2D(Collision2D collision)
    {
        print("����");
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        print("�и�");
    }

}
