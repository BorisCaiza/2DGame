using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DamageObject : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.GetComponent<PlayerRespawn>().PlayerDamaged();
           // SceneManager.LoadScene("Lose");
        }
    }
}
