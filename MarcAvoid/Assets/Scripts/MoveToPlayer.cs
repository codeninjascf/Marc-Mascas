using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayer : MonoBehaviour
{
    public float moveSpeed = 1.5f;

    private Transform _player;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position,
        _player.position, moveSpeed * Time.deltaTime);
    }

    void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player").transform;
    }
}
