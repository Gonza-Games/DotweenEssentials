using System;
using DG.Tweening;
using UnityEngine;

namespace DotweenEssentials
{
    public class DotweenShakeExample : MonoBehaviour
    {
        private void Start()
        {
            transform.DOShakePosition(2, new Vector3(5, 0, 0), 2);
            //transform.DOShakeRotation(2);
            //transform.DOShakeScale(2);
        }
    }
}