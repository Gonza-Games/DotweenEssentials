using DG.Tweening;
using UnityEngine;

namespace DotweenEssentials
{
    public class DotweenMoveExample : MonoBehaviour
    {
        private void Start()
        {
            transform.DOMove(new Vector3(100, 0, 0), 10);
        }

    }
}