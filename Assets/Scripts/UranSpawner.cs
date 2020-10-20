using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UranSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _terrain;
    [SerializeField] private GameObject _uranRock;
    [SerializeField] private GameObject _uranRockContainer;
    private Vector3 _terrainSize;
    private double _terrainWidth;
    private double _terrainLength;
    private double _terrainVerticalOffset;

    void Start()
    {
        _terrainSize = _terrain.GetComponent<Terrain>().terrainData.size;
        _terrainWidth = _terrainSize.x;
        _terrainLength = _terrainSize.z;
        _terrainVerticalOffset = _terrain.transform.position.y;

        for (int i = 0; i < 100; i++)
        {
            SpawnUran(_terrainWidth, _terrainLength);
        }
    }

    void Update()
    {
        
    }

    private void SpawnUran(double terrWidth, double terrLength)
    {
        var randomXPos = Random.Range(0, (float)terrWidth);
        var randomZPos = Random.Range(0, (float)terrLength);
        var verticalPos = (float)_terrainVerticalOffset + 20;

        var spawnPosition = new Vector3(randomXPos, verticalPos, randomZPos);

        Instantiate(_uranRock, spawnPosition, Quaternion.identity, _uranRockContainer.transform);
    }
}
