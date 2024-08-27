using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextChanger : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private Ease _easeType;

    private Text _text;

    private void Awake()
    {
        _text = GetComponent<Text>();
    }

    private void Start()
    {
       DOTween.Sequence()
            .Append(_text.DOText("Меняем текст", _duration))
            .Append(_text.DOText(" Добавляем новый", _duration).SetRelative())
            .Append(_text.DOText("Взламываем", _duration, true,ScrambleMode.Uppercase))
            .SetEase(_easeType)
            .SetLoops(_repeats);
    }
}
