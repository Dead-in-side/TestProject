using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class Repainter : AnimationTweener
{
    [SerializeField] private Color _color;

    private Renderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    public override void Animate()
    {
        _renderer.material.DOColor(_color, Duration)
        .SetEase(EaseType)
        .SetLoops(Repeats);
    }
}
