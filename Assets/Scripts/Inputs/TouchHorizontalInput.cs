using UnityEngine;

namespace DefaultNamespace
{
    public class TouchHorizontalInput : HorizontalInputProviderBase
    {
        [SerializeField] private BallLauncher _ballLauncher;
        
        private bool _ballWasLaunched = false;

        private void Awake()
        {
            _ballLauncher.OnLaunched += OnBallLaunched;
        }

        private void OnBallLaunched()
        {
            _ballWasLaunched = true;
        }

        public override float GetCurrentInput(float currentPosition, float speed)
        {
            if (!_ballWasLaunched) return 0f;
            return Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
        }
    }
}