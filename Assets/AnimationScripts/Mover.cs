using DG.Tweening;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _targetPosition;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private Ease _easeType;

    private void Start()
    {
        transform.DOMove(_targetPosition, _duration)
            .SetEase(_easeType)
            .SetLoops(_repeats,_loopType);
    }
}
