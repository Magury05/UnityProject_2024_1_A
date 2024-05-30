using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SoundScripts.instance.PlaySound("BackGround");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SoundScripts.instance.PlaySound("Cannon");
        }
    }
}
