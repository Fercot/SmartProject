using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBehaviour : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed = 5f;

    private int coins = 0;
    private int health = 100;
    private Vector3 move;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        move = rb.velocity;

        if (Input.GetKey("d"))
        {
            move.x = speed;
        }
        else if (Input.GetKey("a"))
        {
            move.x = speed * -1;
        }
        else
        {
            move.x = 0;
        }

        if (Input.GetKey("space"))
        {
            move.y = speed;
        }

        rb.velocity = move;
    }

    public void AddMoney(int amount)
    {
        coins += amount;
    }

    public void Respawn()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void InflictDamage()
    {
        health -= 20;
        if (health < 0)
        {
            Respawn();
        }
    }
}
