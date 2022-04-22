using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpike : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player Damaged");
            Destroy(other.gameObject);
        }
    }
}
