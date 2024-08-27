using DG.Tweening;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 _targetRotation;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private Ease _easeType;

    private void Start()
    {
        transform.DORotate(_targetRotation, _duration)
            .SetEase(_easeType)
            .SetLoops(_repeats, _loopType);
    }
}
