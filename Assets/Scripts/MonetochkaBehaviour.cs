using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonetochkaBehaviour : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        var controller = other.GetComponent<PlayerBehaviour>();
        controller?.AddMoney(1);
        Destroy(this.gameObject);
    }
}
