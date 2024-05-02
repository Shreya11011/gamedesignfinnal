using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody enemyRb;
    private GameObject playerGoal;
    private SpawnManagerX spawnmanagerX;
    public float speed;

    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();  
        playerGoal = GameObject.Find("Player Goal");
        spawnmanagerX = GameObject.Find("Spawn Manager").GetComponent<SpawnManagerX>();
        speed = spawnmanagerX.enemySpeed;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed);
    }
}
