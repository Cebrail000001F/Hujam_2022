using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Player.CameraData

{
    [CreateAssetMenu(menuName = "Camera")]
    public class CameraData : ScriptableObject
    {
        [SerializeField] private Vector3 _cameraOffset;
        [SerializeField] private float _lerpSpeed;
        public Vector3 CemeraOffset { get => _cameraOffset; }
        public float LerpSpeed { get => _lerpSpeed; }

    }
}