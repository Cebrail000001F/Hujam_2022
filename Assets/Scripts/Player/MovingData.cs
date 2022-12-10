using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player.Move
{
    [CreateAssetMenu(menuName = "Player/Moving")]
    public class MovingData : ScriptableObject
    {

        [SerializeField] private float _speed;
        public float Speed { get => _speed; }


    }
}