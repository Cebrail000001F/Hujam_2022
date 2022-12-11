using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class ObjeHareket : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] private float hiz;
    float degerx;
    float degery;
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
        degerx = Random.Range(-5, 5);
        degery = Random.Range(-5, 5);
    }
    void Update()
    {
        rb.velocity = new Vector2(degerx* hiz, degery*hiz);
    }
}
