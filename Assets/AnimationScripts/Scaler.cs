using DG.Tweening;
using UnityEngine;

public class Scaler:AnimationTweener
{
    [SerializeField] private Vector3 _targetScale;

    public override void Animate()
    {
        transform.DOScale(_targetScale, Duration)
         .SetEase(EaseType)
         .SetLoops(Repeats, LoopType);
    }
}
