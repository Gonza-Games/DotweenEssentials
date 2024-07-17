using System;
using DG.Tweening;
using UnityEngine;

namespace DotweenEssentials
{
    public class DotweenSequenceExample : MonoBehaviour
    {
        [SerializeField] private GameObject _gameObject;
        
        private Sequence _sequence;
        private Tweener _tweener;
        private void Start()
        {
            _sequence = DOTween.Sequence();
            _sequence.Append(transform.DOMoveX(5, 1))
                .AppendInterval(2)
                .AppendCallback(IntervalFinished)
                .Append(transform.DOMoveY(5, 1))
                .Append(transform.DOMoveZ(5, 1))
                //.SetLoops(-1, LoopType.Yoyo);
                .OnComplete(OnComplete)
                .OnKill(OnKill)
                .SetLink(_gameObject);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                _tweener?.Kill();
                _tweener = transform.DOMoveX(-10, 2);
            }
        }

        private void IntervalFinished()
        {
            Debug.Log("Interval finished");
        }

        private void OnComplete()
        {
            Debug.Log("OnComplete");
        }

        private void OnKill()
        {
            Debug.Log("OnKill");
        }

        private void OnDestroy()
        {
            _sequence?.Kill();
        }
    }
}