using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Parcalanma : MonoBehaviour
{
    [SerializeField] GameObject[] altObjeler;
   
    void Start()
    {
       
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
            for (int i = 0; i < altObjeler.Length; i++)
            {
            if (collision.gameObject.CompareTag("mermi"))
            {
                gameObject.SetActive(false);
                altObjeler[i].SetActive(true);
            }
            }
    }
}
