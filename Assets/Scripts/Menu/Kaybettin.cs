using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kaybettin : MonoBehaviour
{
    private SetActiveObjects _setActiveObjects;
    private GameObject[] dusman;
    Camera _camera;
    private Animator _anim;
    void Start()
    {
        dusman = GameObject.FindGameObjectsWithTag("dusman");
        _camera = Camera.main;
        _setActiveObjects = GetComponent<SetActiveObjects>();
        _anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        for (int i = 0; i < dusman.Length; i++)
        {
            if (collision.gameObject == dusman[i])
            {
                if (gameObject.transform.localScale.x < dusman[i].transform.localScale.x)
                {
                    _anim.SetTrigger("explosion");
                    StartCoroutine(waitingDeath());
                }
                if (gameObject.transform.localScale.x > dusman[i].transform.localScale.x)
                {
                    _camera.orthographicSize += 0.2f;
                    dusman[i].SetActive(false);
                    gameObject.transform.localScale = new Vector2(gameObject.transform.localScale.x + dusman[i].transform.localScale.x * 0.2f, gameObject.transform.localScale.y + dusman[i].transform.localScale.y * 0.2f);
                    _setActiveObjects.ChangesSprite();

                }
            }
        }
    }
    IEnumerator waitingDeath()
    {
        yield return new WaitForSeconds(1f);
        LoadA("OyunBitis");
    }
    public void LoadA(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}
