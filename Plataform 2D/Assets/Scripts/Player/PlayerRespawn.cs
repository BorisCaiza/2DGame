using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public float checkPointPosittionX, checkPointPosittionY;

    
    
    private void Start()
    {
        if (PlayerPrefs.GetFloat("checkPointPosittionX")!=0)
        {
            transform.position = (new Vector2(PlayerPrefs.GetFloat("checkPointPosittionX"), PlayerPrefs.GetFloat("checkPointPosittionY")));
        }
    }


    public void reachedCheckPoint( float x, float y)
    {
        PlayerPrefs.SetFloat("checkPointPosittionX",x);
        PlayerPrefs.SetFloat("checkPointPosittionY",y);
    }
}
