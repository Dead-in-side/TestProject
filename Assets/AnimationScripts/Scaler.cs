using DG.Tweening;
using UnityEngine;

public class Scaler:MonoBehaviour
{
    [SerializeField] private Vector3 _targetScale;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private Ease _easeType;

    private void Start()
    {
        transform.DOScale(_targetScale, _duration)
            .SetEase(_easeType)
            .SetLoops(_repeats, _loopType);
    }
}
