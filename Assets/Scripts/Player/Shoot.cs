using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private GameObject _projectTile;
    [SerializeField] private Transform _ptRotateParent;
    [SerializeField] private float _projectTileSpeed;
    [SerializeField] private float _timeBetweenFiring = 0.3f;
    [SerializeField] AudioClip fireSFX;
    private AudioPlayer _audioPlayer;
    private Coroutine _firingCoroutineControl;
    float _timer = 0;

    private void Start()
    {
        if (GameObject.FindGameObjectWithTag("Audio") == true)
            _audioPlayer = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioPlayer>();

    }
    void Update()
    {
        Fire();


    }
    private void Fire()
    {
        bool isFiring = Input.GetAxis("Fire1") != 0;
        if (!isFiring)
        {
            _timer += Time.deltaTime;
        }
        if (isFiring && _firingCoroutineControl == null && _timer > _timeBetweenFiring)
        {
            _firingCoroutineControl = StartCoroutine(FiringCoroutine());
            _timer = 0;
            if (_audioPlayer != null)
                AudioPlayer.Instance.Play(fireSFX);

        }
        else if (!isFiring && _firingCoroutineControl != null)
        {
            StopCoroutine(_firingCoroutineControl);
            _firingCoroutineControl = null;
        }
    }
    IEnumerator FiringCoroutine()
    {
        while (true)
        {

            GameObject instance = Instantiate(_projectTile, _ptRotateParent.transform.position, Quaternion.identity);
            //instance.GetComponent<Rigidbody2D>().velocity = transform.right * _projectTileSpeed;
            Destroy(instance, 5f);
            float timeToNextProjectile = Random.Range(0.5f, 1f);
            yield return new WaitForSeconds(timeToNextProjectile);
        }
    }
}
