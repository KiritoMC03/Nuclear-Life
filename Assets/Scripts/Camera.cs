using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    private Vector3 _distanceToPlayer;
    void Start()
    {
        _distanceToPlayer = transform.position - _player.transform.position;
    }

    void Update()
    {
        
    }

    private void LateUpdate()
    {
        Move();
    }

    internal void Move()
    {
        transform.position = _player.transform.position + _distanceToPlayer;
    }
}
