using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private Target _target;
    [SerializeField] private float _timeRate = 2.0f;

    private void Start()
    {
        StartCoroutine(SpawnRepeating());
    }

    private void Spawn()
    {
        Enemy enemy = Instantiate(_enemyPrefab, transform.position, Quaternion.identity);
        enemy.Init(_target);
    }

    private IEnumerator SpawnRepeating()
    {
        WaitForSeconds wait = new WaitForSeconds(_timeRate);

        while (enabled)
        {
            Spawn();

            yield return wait;
        }
    }
}