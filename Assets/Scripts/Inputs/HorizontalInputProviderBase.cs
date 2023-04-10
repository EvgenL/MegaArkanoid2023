using UnityEngine;

namespace DefaultNamespace
{
    public abstract class HorizontalInputProviderBase : MonoBehaviour
    {
        public abstract float GetCurrentInput(float currentPosition, float speed);
    }
}