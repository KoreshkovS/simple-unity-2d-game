using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Player _player;

    private void Start()
    {
        _player = FindObjectOfType<Player>();
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, _player.transform.position, _speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Hole")
        {
            _player.AddScore();
            Destroy(gameObject);
        }
        if (collision.tag == "Player")
        {
            _player.TakeDamage();
            _speed = 0;
            transform.parent = _player.transform;
        }
    }
}
