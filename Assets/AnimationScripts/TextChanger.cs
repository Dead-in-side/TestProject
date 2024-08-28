using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextChanger : AnimationTweener
{
    private Text _text;

    private void Awake()
    {
        _text = GetComponent<Text>();
    }

    public override void Animate()
    {
        DOTween.Sequence()
        .Append(_text.DOText("������ �����", Duration))
        .Append(_text.DOText(" ��������� �����", Duration).SetRelative())
        .Append(_text.DOText("����������", Duration, true, ScrambleMode.Uppercase))
        .SetEase(EaseType)
        .SetLoops(Repeats);
    }
}
