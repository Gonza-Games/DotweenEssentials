using System;
using DG.Tweening;
using UnityEngine;

namespace DotweenEssentials
{
    public class DotweenDoPathExample : MonoBehaviour
    {
        private void Start()
        {
            transform.DOPath(new[]
            {
                new Vector3(1, 0, 0),
                new Vector3(2, 1, 0),
                new Vector3(5, 8, 0)
            }, 5);
        }
    }
}