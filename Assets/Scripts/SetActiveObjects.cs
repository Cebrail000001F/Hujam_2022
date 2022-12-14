using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerMove;

public class SetActiveObjects : MonoBehaviour
{
    [SerializeField] private GameObject[] planets;

    [SerializeField] private Animator _anim;
    [SerializeField] Transform _bulletTransform;
    PlayerMove.PlayerMove playerMove;
    Shoot shoot;
    Camera camera;

    private void Start()
    {

        shoot = GetComponent<Shoot>();
        playerMove = GetComponent<PlayerMove.PlayerMove>();
        camera = Camera.main;
    }
    public void ChangesSprite()
    {
        if (gameObject.transform.lossyScale.x >= 3f && gameObject.transform.localScale.x <= 3.5f)
        {
            planets[0].SetActive(false);
            planets[1].SetActive(true);

        }
        if (gameObject.transform.localScale.x >= 3.5f && gameObject.transform.localScale.x <= 5f)
        {
            planets[1].SetActive(false);
            planets[2].SetActive(true);
            shoot.scaleX = 3f;
            shoot.scaleY = 3f;
        }
        if (gameObject.transform.localScale.x >= 6f && gameObject.transform.localScale.x <= 10f)
        {
            planets[2].SetActive(false);
            planets[3].SetActive(true);
            shoot.scaleX = 4f;
            shoot.scaleY = 4f;
            camera.orthographicSize = 55.00f;
        }
        if (gameObject.transform.localScale.x >= 10f && gameObject.transform.localScale.x <= 20f)
        {
            planets[3].SetActive(false);
            planets[4].SetActive(true);
            camera.orthographicSize = 55.00f;
        }
        if (gameObject.transform.localScale.x >= 20f && gameObject.transform.localScale.x <= 25f)
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
