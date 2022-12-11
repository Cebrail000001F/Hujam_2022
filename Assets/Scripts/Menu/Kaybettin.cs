using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kaybettin : MonoBehaviour
{
    private GameObject[] dusman;
    void Start()
    {
        dusman = GameObject.FindGameObjectsWithTag("dusman");
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        for (int i = 0; i < dusman.Length; i++)
        {
           
            if (collision.gameObject == dusman[i])
            {
                if (gameObject.transform.localScale.x < dusman[i].transform.localScale.x)
                {
                    LoadA("OyunBitis");
                }
            }
        }
        
    }
    public void LoadA(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}
