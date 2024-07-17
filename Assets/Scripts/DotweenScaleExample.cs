using DG.Tweening;
using UnityEngine;

namespace DotweenEssentials
{
    public class DotweenScaleExample : MonoBehaviour
    {
        private void Start()
        {
            transform.DOScale(new Vector3(1.5f, 1.5f, 1.5f), 2);
        }
    }
}