using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _timeBetweenSpawns;

    private float _nextSpawnTime;


    private void Update()
    {
        if (Time.time > _nextSpawnTime)
        {
            Instantiate(_enemy, _spawnPoints[Random.Range(0, _spawnPoints.Length)].position, Quaternion.identity);
            _nextSpawnTime = Time.time + _timeBetweenSpawns;
        }
    }
}
