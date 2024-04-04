using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXGenItem : MonoBehaviour
{
    public GameObject Target;
    public float checkTime;
    void Update()
    {
        checkTime += Time.deltaTime;
        if(checkTime >= 1.0f)
        {
            checkTime = 0.0f;
            GameObject team = Instantiate(Target);
            team.transform.position = this.gameObject.transform.position;
            int.RandomNumderX = Random.Range(0, 8);
            int.RandomNumderY = Random.Range(0, 8);
            team.transform.position += new Vector3(RandomNumderX, RandomNumderY, 0.0f);

            Destroy(team, 2.0f);
        }
    }
}
