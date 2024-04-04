using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExRay : MonoBehaviour
{
    public Text UIText;
    public int Point;
    void Update()
    {
        if (Input.GetMouseButtonDown(1))                   //GetMouseButtonDown(1) ������ ��ư ���콺�� ������ ��
        {
            Ray cast = Camera.main.ScreenPointToRay(Input.mousePosition);       //Ray�� ��� �浹�� ��ü�� ���� Hit �ֱ� ���� ����

            RaycastHit hit;                                                     //Ray�� ��� �浹�� ��ü�� ���� hit �ֱ� ���� ����

            if(Physics.Raycast(cast, out hit))                                  //�浹�Ŀ� ���� hit ���� ���
            {
                Debug.Log(hit.collider.gameObject.name);
                Debug.DrawLine(cast.origin, hit.point, Color.red, 2.0f);

                if (hit.collider.gameObject.tag == "Target")
                {
                    Destroy(hit.collider.gameObject);
                }
            }
        }

    }
}
