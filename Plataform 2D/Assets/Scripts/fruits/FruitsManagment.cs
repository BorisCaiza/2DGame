using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FruitsManagment : MonoBehaviour
{

    public Text levelCleared;

    private void Update()
    {
        AllFruitsCollected();
    }

    public void AllFruitsCollected()
    {
        if (transform.childCount == 0)
        {
            Debug.Log("No te quedan Frutas");
            levelCleared.gameObject.SetActive(true);
            Invoke("ChanceScene",1);
        }

    }



    private void ChanceScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}