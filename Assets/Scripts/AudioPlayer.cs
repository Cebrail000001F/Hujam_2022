using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    private AudioSource _audioSource;
    public static AudioPlayer _instance;

    public static AudioPlayer Instance

    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<AudioPlayer>();
                if (_instance == null)
                {
                    _instance = new GameObject("Game Manager").AddComponent<AudioPlayer>();
                }

            }
            return _instance;
        }
    }
    private void Awake()
    {
        if (_instance != null) //fazladan obje oluşturmamak için
            Destroy(this);
        DontDestroyOnLoad(this); //yok etme audiomanager için kullanılabilir
        _audioSource = GetComponent<AudioSource>();

    }
    public void Play(AudioClip clip)
    {
      
            _audioSource.clip = clip;
            _audioSource.Play();
       

    }
}


