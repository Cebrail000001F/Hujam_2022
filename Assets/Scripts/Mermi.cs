using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class Mermi : MonoBehaviour
{
    [SerializeField] private GameObject[] mermiler;
    [SerializeField] private GameObject dogmaNoktasi;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        for (int i = 0; i < mermiler.Length; i++)
        {
            if (collision.gameObject == mermiler[i])
            {
                gameObject.SetActive(false);
            }
        }             
    }
    /// <summary>
    /// Obje havuzunda aktif olmayan ilk objeyi aktif eder
    /// </summary>
    void mermiHavuzu()
    {
        for (int i = 0; i < mermiler.Length; i++)
        {
            if (!mermiler[i].activeInHierarchy)
            {
                mermiler[i].transform.position = dogmaNoktasi.transform.position;
                mermiler[i].SetActive(true);
                break;
            }
        }
    }
}