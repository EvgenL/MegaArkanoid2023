using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class PlayerMoveController : MonoBehaviour
    {
        [Range(0f, 2f)] [SerializeField] private float _speed = 1f;
        [SerializeField] private float _levelBorderX;
        private HorizontalInputProviderBase _horizontalInputProvider;

        private void Start()
        {
#if UNITY_EDITOR
            _horizontalInputProvider = FindObjectOfType<MouseHorizontalInput>();
#else
            _horizontalInputProvider = FindObjectOfType<TouchHorizontalInput>();   
#endif
        }

        private void FixedUpdate()
        {
            var position = transform.position;

            position.x = _horizontalInputProvider.GetCurrentInput(position.x, _speed);
             
            position.x = Mathf.Clamp(position.x, -_levelBorderX, _levelBorderX);
            
            transform.position = position;
        }
    }
}