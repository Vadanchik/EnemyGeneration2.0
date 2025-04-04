using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private Target _target;
    [SerializeField] private float _timeRate = 2.0f;

    private void Start()
    {
        InvokeRepeating(nameof(Spawn), 0, _timeRate);
    }

    private void Spawn()
    {
        Enemy enemy = Instantiate(_enemyPrefab, transform.position, Quaternion.identity);
        enemy.Init(_target);
    }
}