using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerController : MonoBehaviour
{
    [SerializeField] EnemyController _enemyPrefab;

    [SerializeField] float _spawnSpeed = 1f;
    [SerializeField] float _spawnMaxTime = 5f;
    [SerializeField] float _spawnMinTime = 1f;
    [SerializeField] float _yMaxBorder = 1.7f;

    float _counter;
    float _spawnRandomTime;

    private void Awake()
    {
        _spawnRandomTime= Random.Range(_spawnMinTime, _spawnMaxTime);
        _counter = 0f;
    }

    [ContextMenu(nameof(SpawnProcess))]
    void SpawnProcess()
    {
        float randomValue=Random.Range(_yMaxBorder,-_yMaxBorder);
        Vector2 spawnPosition = new Vector2(transform.position.x,randomValue);

        Instantiate(_enemyPrefab, spawnPosition, Quaternion.identity);
        _counter = 0f;
    }
    private void Update()
    {
        _counter += Time.deltaTime * _spawnSpeed;

        if (_counter >= _spawnRandomTime)
        {
            SpawnProcess();
            _counter = 0f;
            _spawnRandomTime = Random.Range(_spawnMinTime, _spawnMaxTime);
        }
    }
}
