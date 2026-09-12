using Unity.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    [SerializeField] private GameObject _coin;
    [SerializeField] private float _minSpawnTime = .1f;
    [SerializeField] private float _maxSpawnTime = .5f; 
    private float _spawnRate;
    private void spawnCoin()
    {
        Instantiate(_coin, transform.position, Quaternion.identity);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _spawnRate = Random.Range(_minSpawnTime, _maxSpawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
        _spawnRate -= Time.deltaTime;
        if (_spawnRate <= 0)
        {
            spawnCoin();
            _spawnRate = Random.Range(_minSpawnTime, _maxSpawnTime );
        }
        

    }
}
