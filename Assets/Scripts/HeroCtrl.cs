using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroControl : MonoBehaviour
{
    public float moveSpeed = 3;
    public float spinSpeed = 180;

    public GameObject missile;
    public int HP = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Ű���� ���� ����Ű�� ������
        if (Input.GetKey("up"))
        {
            float delta = moveSpeed * Time.deltaTime;
            transform.Translate(0, delta, 0); // y�� ���� �������� 3��ŭ �̵�
        }

        // Ű���� �Ʒ��� ����Ű�� ������
        if (Input.GetKey("down"))
        {
            float delta = moveSpeed * Time.deltaTime;
            transform.Translate(0, -delta, 0); // y�� ���� �������� 3��ŭ �̵�
        }

        // Ű���� ���� Ű�� ������
        if (Input.GetKey("left"))
        {
            float delta = spinSpeed * Time.deltaTime;
            transform.Rotate(0, 0, delta); // �ݽð� �������� �ʴ� 180�� ȸ��
        }

        // Ű���� ������ Ű�� ������
        if (Input.GetKey("right"))
        {
            float delta = spinSpeed * Time.deltaTime;
            transform.Rotate(0, 0, -delta); // �ð� �������� �ʴ� 180�� ȸ��
        }

        // �����̽��ٸ� ������
        if (Input.GetKeyDown("space"))
        {
            Vector3 pos = gameObject.transform.position; // ��ũ��Ʈ�� �����ϰ��ִ� ������Ʈ�� ���� ��ġ
            Quaternion rot = gameObject.transform.rotation; // ��ũ��Ʈ�� �����ϰ��ִ� ������Ʈ�� ���� ����
            Instantiate(missile, pos, rot); // ������Ʈ���� �̻��� ����
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        string cgTag = collision.gameObject.tag;
        if (cgTag=="Enemy")
        {
            HP-=2;
            
        }

        if (cgTag=="EnemyBul")
        {
            HP--;
        }

        print(HP);

        if(HP<=0)
            {
                Destroy(gameObject);
            }
        
    }
}
