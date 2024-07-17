using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

namespace DotweenEssentials
{
    public class ButtonScaleExample : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        public void OnPointerEnter(PointerEventData eventData)
        {
            transform.DOScale(new Vector3(1.2f, 1.2f), 0.2f);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            transform.DOScale(Vector3.one, 0.2f);

        }
    }
}