using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    [SerializeField] private GameObject _mainCamera;
    private Camera camera;
    [SerializeField] private float _moveSpeed = 4f;
    Action OpenMouthDel;

    void Start()
    {
        camera = _mainCamera.GetComponent<Camera>();
    }

    void Update()
    {
    }

    private void FixedUpdate()
    {
        if(Input.GetAxis("Vertical") != 0)
        {
            Movement();
        }
        RotateOnMove();
    }

    private Vector3 GetPlayerOffset()
    {
        float move = Input.GetAxis("Vertical");
        Vector3 offset = new Vector3(move, 0.0f, 0.0f);
        return offset;
    }
    private Vector3 Movement()
    {
        var translateTo = (GetPlayerOffset() * _moveSpeed * Time.fixedDeltaTime);
        transform.Translate(translateTo);
        return translateTo;
    }
    private void RotateOnMove()
    {
        float moveRotate = Input.GetAxis("Horizontal");
        transform.Rotate(0.0f, moveRotate, 0.0f);
    }
}
