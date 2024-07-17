using DG.Tweening;
using UnityEngine;

namespace DotweenEssentials
{
    public class DotweenRotateExample : MonoBehaviour
    {
        private void Start()
        {
            transform.DORotate(new Vector3(180, 180, 180), 4);
        }
    }
}