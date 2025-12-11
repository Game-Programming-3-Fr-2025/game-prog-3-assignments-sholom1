using UnityEngine;
using UnityEngine.InputSystem;

namespace Final
{
    public class Example : MonoBehaviour
    {
        public void OnInteract(InputAction.CallbackContext context)
        {
            if (context.ReadValueAsButton())
            {
                Debug.Log("I interacted with something!!");
            }
        }
    }
}
