using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteScroller : MonoBehaviour
{
    [SerializeField] Vector2 _moveSpeed;
    private Vector2 _offset;
    private Material _material;
    void Start()
    {
        _material = GetComponent<SpriteRenderer>().material;
    }
    void Update()
    {
        _offset = _moveSpeed * Time.deltaTime;
        _material.mainTextureOffset += _offset;
    }
}
