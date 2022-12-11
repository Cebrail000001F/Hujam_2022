using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerMove;

public class SetActiveObjects : MonoBehaviour
{
    [SerializeField] private GameObject[] planets;
    [SerializeField] private Animator _anim;
    PlayerMove.PlayerMove playerMove;
    Shoot shoot;

    private void Start()
    {

        shoot = GetComponent<Shoot>();
        playerMove = GetComponent<PlayerMove.PlayerMove>();
    }
    public void ChangesSprite()
    {
        if (gameObject.transform.lossyScale.x >= 3f && gameObject.transform.localScale.x <= 3.5f)
        {
            planets[0].SetActive(false);
            planets[1].SetActive(true);
            print("3f oldum");
        }
        if (gameObject.transform.localScale.x >= 3.5f && gameObject.transform.localScale.x <= 5f)
        {
            planets[1].SetActive(false);
            planets[2].SetActive(true);
        }
        if (gameObject.transform.localScale.x >= 10f && gameObject.transform.localScale.x <= 5f)
        {
            planets[2].SetActive(false);
            planets[3].SetActive(true);
        }
        if (gameObject.transform.localScale.x >= 15f && gameObject.transform.localScale.x <= 10f)
        {
            planets[3].SetActive(false);
            planets[4].SetActive(true);
        }
        if (gameObject.transform.localScale.x >= 20f && gameObject.transform.localScale.x <= 15f)
        {
            planets[4].SetActive(false);
            playerMove.enabled = false;
            shoot.enabled = false;
            StartCoroutine(BlackHoleWait());
        }
    }
    IEnumerator BlackHoleWait()
    {
        _anim.SetTrigger("explosion");
        yield return new WaitForSeconds(1.5f);
        planets[5].SetActive(true);

    }
}
