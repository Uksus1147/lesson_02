using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 _direct;
    public float speed = 2;
    private void Awake()
    {
        _direct = Vector3.zero;
    }
    private void Update()
    {
        _direct.x = Input.GetAxis("Horizontal");
        _direct.z = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        Move();
    }
    private void Move()
    {
        Vector3 direction = _direct * speed * Time.fixedDeltaTime;
        transform.Translate(direction);
    }
}
