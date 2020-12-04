using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        var controller = other.gameObject.GetComponent<PlayerBehaviour>();
        controller?.InflictDamage();
    }
}