using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening; 

public class TweenTest : MonoBehaviour
{
    Sequence sequence;
    Tween tween;
    // Start is called before the first frame update
    void Start()
    {
        //Twenn ���� 
        //Tween = transform.DOMoveX
        //transform.DOMoveX(5, 2);               //�� ������Ʈ�� 2�ʵ��� X�� 5�� �̵���Ų��.
        //transform.DORotate(new Vector3(0, 0, 180), 2);      //�� ������Ʈ�� 2�ʵ��� z������ 180�� ȸ�� ��Ų��.
        //transform.DOScale(new Vector3(2, 2, 2), 2);         //�� ������Ʈ�� 2�ʵ��� Scale�� 2�� 

        //��ü �ּ� �� �ּ� ���� Ctrl + K + C , Crtl + K + U

        //Sequence sequence = DOTween.Sequence();
        //sequence.Append(transform.DOMoveX(5, 2));
        //sequence.Append(transform.DORotate(new Vector3(0, 0, 180), 2));
        //sequence.Append(transform.DOScale(new Vector3(2, 2, 2), 2));

        //transform.DOMoveX(5, 2).SetEase(Ease.OutBounce);               //Ease �ɼ��� ����Ͽ� �ٿ�� ȿ�� ����
        //transform.DOShakeRotation(22, new Vector3(0, 0, 90), 10, 90); //ȸ���� Z�� 90�� ����10, ���� 90���� ���� �ش�.

        //transform.DOMoveX(5, 2).SetEase(Ease.OutBounce).OnComplete(TweenEnd);

        sequence = DOTween.Sequence();              //Tween�� �̾ ������� ���� �����ִ� ����
        sequence.Append(transform.DOMoveX(5, 1));            //Tween ����
        sequence.SetLoops(-1, LoopType.Yoyo);                //Tween ������·� ��

    }

    void TweenEnd()
    {
        gameObject.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sequence.Kill();
            //tween,kill();
        }
    }
}
