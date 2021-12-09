using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemies : MonoBehaviour
{
    public float health = 50f;

    //Reference of AI movement
    public Transform Player;
    public float MoveSpeed = 4;
    public float MaxDist = 10;
    public float MinDist = 1;

    //AI attacking player
    public float attackInterval;
    private float _attackIntervalTimer;

    public int damage;

    //Reference to Nav-mesh for movement
    public NavMeshAgent _agent;
    public GameObject player;

    //Reference to player as target
    public Transform playerTarget;

    // Start is called before the first frame update
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
       player = GameObject.Find("Player");
       transform.LookAt(Player);

        if (Vector3.Distance(transform.position, Player.position) >= MinDist)
        {
            transform.position += transform.forward * MoveSpeed * Time.deltaTime;
            if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
            {
                //Here Call any function U want Like Shoot at here or something
            }
        }

    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}

