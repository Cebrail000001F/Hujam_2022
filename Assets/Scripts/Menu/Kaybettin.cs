using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kaybettin : MonoBehaviour
{
    private GameObject[] dusman;
    Camera _camera;

    void Start()
    {
        dusman = GameObject.FindGameObjectsWithTag("dusman");
        _camera = Camera.main;
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
                if (gameObject.transform.localScale.x > dusman[i].transform.localScale.x)
                {
                    _camera.orthographicSize += 0.5f;
                    dusman[i].SetActive(false);
                    gameObject.transform.localScale = new Vector2(gameObject.transform.localScale.x + dusman[i].transform.localScale.x * 0.2f, gameObject.transform.localScale.y + dusman[i].transform.localScale.y * 0.2f);
                }
            }
        }
    }
    public void LoadA(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}
