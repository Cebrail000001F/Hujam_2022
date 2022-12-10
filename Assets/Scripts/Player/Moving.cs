using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Player.Move
{

    public class Moving : MonoBehaviour
    {
        [SerializeField] private MovingData _movingData;
        Vector2 minBounds, maxBounds;
        Rigidbody2D rig2d;
        private void Awake()
        {
            rig2d = GetComponent<Rigidbody2D>();
        }
        private void Start()
        {

        }
        private void Update()
        {
            MovingLimit();
            Moves();
        }
        private void MovingLimit()
        {
            Camera camera = Camera.main;
            minBounds = camera.ViewportToWorldPoint(new Vector2(0, 0));
            maxBounds = camera.ViewportToWorldPoint(new Vector2(1, 1));
        }
        private void Moves()
        {

            float _horizontal = Input.GetAxis("Horizontal");
            float _vertical = Input.GetAxis("Vertical");
            Vector2 delta = new Vector2(_horizontal, _vertical) * _movingData.Speed * Time.deltaTime;
            Vector2 newPos = new Vector2();
            newPos.x = Mathf.Clamp(transform.position.x + delta.x, minBounds.x + 0.5f, maxBounds.x - 0.5f);
            newPos.y = transform.position.y + delta.y;
            transform.position = newPos;
        }

    }
}