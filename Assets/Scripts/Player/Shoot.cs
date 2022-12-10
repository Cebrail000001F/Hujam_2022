using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private GameObject projectTile;
    [SerializeField] private float projectTileSpeed;

    Coroutine firingCoroutineControl;
    void Update()
    {
        Fire();
    }
    private void Fire()
    {
        bool isFiring = Input.GetAxis("Fire1") != 0;
        if (isFiring && firingCoroutineControl == null)
            firingCoroutineControl = StartCoroutine(FiringCoroutine());
        else if (!isFiring && firingCoroutineControl != null)
        {
            StopCoroutine(firingCoroutineControl);
            firingCoroutineControl = null;
        }
    }
    IEnumerator FiringCoroutine()
    {
        while (true)
        {
            GameObject instance = Instantiate(projectTile, transform.position, Quaternion.identity);
            instance.GetComponent<Rigidbody2D>().velocity = transform.right * projectTileSpeed;
            Destroy(instance, 5f);
            float timeToNextProjectile = Random.Range(0.2f, 0f);
            yield return new WaitForSeconds(timeToNextProjectile);
        }
    }
}
