using UnityEngine;

namespace Code
{
    public class PlayerInputX : MonoBehaviour
    {
        private const string AxisHorizontal = "Horizontal";
        
        [SerializeField]
        private MoverX _mover;

        private void Update()
        {
            float input = Input.GetAxis(AxisHorizontal);
            _mover.Move(input);
        }
    }
}