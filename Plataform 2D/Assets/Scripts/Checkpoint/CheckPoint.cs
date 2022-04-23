using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<PlayerRespawn>().reachedCheckPoint(transform.position.x, transform.position.y);

            GetComponent<Animator>().enabled = true;
        }
    }
}
