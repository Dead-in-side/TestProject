using DG.Tweening;
using UnityEngine;

public class Rotator : AnimationTweener
{
    [SerializeField] private Vector3 _targetRotation;

    public override void Animate()
    {
        transform.DORotate(_targetRotation, Duration)
         .SetEase(EaseType)
         .SetLoops(Repeats, LoopType);
    }
}
