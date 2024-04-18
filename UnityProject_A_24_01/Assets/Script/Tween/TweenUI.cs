using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TweenUI : MonoBehaviour
{

    public float duration = 1f;                       //시간값 선언
    private Image image;                              //UI image 에 접근
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();           //컨포넌트 가져오기
        image.DOFade(0f, duration);              //페이드 효과
        
        image.DOPlay();                          //
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
