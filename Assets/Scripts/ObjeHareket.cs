using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjeHareket : MonoBehaviour
{
    Rigidbody2D Obje;
    [SerializeField] float hiz;
    [SerializeField] float hareketx;
    [SerializeField] float harekety;
    void Start()
    {
        Obje= GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        Obje.velocity = new Vector2(hareketx * hiz, harekety * hiz);
    }
}
