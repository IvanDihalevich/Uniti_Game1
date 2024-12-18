using UnityEngine;

namespace Code
{
    internal sealed class MoveView : MonoBehaviour
    {
        [SerializeField]
        private MoverX _moverX;

        private void Update()
        {
            if (_moverX.Speed > 0)
            {
                transform.localScale = new Vector3(
                    Mathf.Abs(transform.localScale.x),
                    transform.localScale.y,
                    transform.localScale.z
                );
            }
            else if (_moverX.Speed < 0)
            {
                transform.localScale = new Vector3(
                    -Mathf.Abs(transform.localScale.x),
                    transform.localScale.y,
                    transform.localScale.z
                );
            }
        }
    }
}