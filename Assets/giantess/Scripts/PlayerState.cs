using UnityEngine;

namespace Giantess
{
    public class PlayerState : MonoBehaviour
    {
        [field: SerializeField] public PlayerMovementState CurrentPlayerMovementState { get; private set; } = PlayerMovementState.Idling;

        public enum PlayerMovementState
        {
            Idling,
            Walking,
            Running,
            Sprinting,
            Jumping,
            Falling,
            Strafing
        }
    }
}