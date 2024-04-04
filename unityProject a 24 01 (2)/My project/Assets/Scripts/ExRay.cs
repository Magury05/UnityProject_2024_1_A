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
        if (Input.GetMouseButtonDown(1))                   //GetMouseButtonDown(1) 오른쪽 버튼 마우스가 눌렸을 때
        {
            Ray cast = Camera.main.ScreenPointToRay(Input.mousePosition);       //Ray를 쏘고 충돌할 물체의 값을 Hit 넣기 위한 정의

            RaycastHit hit;                                                     //Ray를 쏘고 충돌할 물체의 값을 hit 넣기 위한 정의

            if(Physics.Raycast(cast, out hit))                                  //충돌후에 값이 hit 있을 경우
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
