using DG.Tweening;
using UnityEngine;

public class Mover : AnimationTweener
{
    [SerializeField] private Vector3 _targetPosition;

    public override void Animate()
    {
        transform.DOMove(_targetPosition, Duration)
         .SetEase(EaseType)
         .SetLoops(Repeats, LoopType);
    }
}
