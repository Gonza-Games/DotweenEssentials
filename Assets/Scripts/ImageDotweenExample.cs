using DG.Tweening;
using UnityEngine;

namespace DotweenEssentials
{
    public class ImageDotweenExample : MonoBehaviour
    {
        private void Start()
        {
            GetComponent<RectTransform>().DOAnchorPos(new Vector2(1800, 0), 2);
        }
        
    }
}