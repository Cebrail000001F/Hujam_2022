using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Player.CameraData
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private CameraData _cameraData;
        [SerializeField] private Transform _target;
       
        private Camera cameraBoyutu;

      
        private void Update()
        {
            this.transform.position = Vector3.Lerp(this.transform.position, _target.position + _cameraData.CemeraOffset, Time.deltaTime * _cameraData.LerpSpeed);
            
        }
    }
}