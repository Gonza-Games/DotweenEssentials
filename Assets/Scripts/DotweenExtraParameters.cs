using System;
using DG.Tweening;
using UnityEngine;

namespace DotweenEssentials
{
    public class DotweenExtraParameters : MonoBehaviour
    {
        private void Start()
        {
            Time.timeScale = 0f;
            transform.DOMoveX(8, 4)
                .SetEase(Ease.InOutBounce)
                .SetUpdate(true);
        }
    }
}