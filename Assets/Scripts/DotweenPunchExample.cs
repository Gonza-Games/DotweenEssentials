using DG.Tweening;
using UnityEngine;

namespace DotweenEssentials
{
    public class DotweenPunchExample : MonoBehaviour
    {
        private void Start()
        {
            //transform.DOPunchPosition(new Vector3(1, 1, 1), 2);
            //transform.DOPunchRotation(new Vector3(0, 0, 30), 2);
            transform.DOPunchScale(new Vector3(1.2f, 1.2f, 1.2f), 2);
        }
    }
}