using DG.Tweening;
using UnityEngine;


public abstract class AnimationTweener : MonoBehaviour
{
    [field: SerializeField] public float Duration { get; private set; }
    [field: SerializeField] public int Repeats { get; private set; }
    [field: SerializeField] public LoopType LoopType { get; private set; }
    [field: SerializeField] public Ease EaseType { get; private set; }

    private void Start()
    {
        Animate();
    }

    public abstract void Animate();
}
