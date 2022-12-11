using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float _force;
    private Vector3 _mousePos;
    private Camera _mainCam;
    private Rigidbody2D _rb;
    void Start()
    {
        _mainCam = Camera.main;
        _rb = GetComponent<Rigidbody2D>();

        _mousePos = _mainCam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = _mousePos - transform.position;
        Vector3 rotation = transform.position - _mousePos;
        _rb.velocity = new Vector2(direction.x, direction.y).normalized * _force;
        float rot = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot + 90);
    }


    void Update()
    {

    }
}
