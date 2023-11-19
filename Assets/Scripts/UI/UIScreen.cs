using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(CanvasGroup))]
public class UIScreen : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    public float appearDuration = 0.3f;
    public float disappearDuration = 0.2f;

    // * GET COMPONENTS IN EDITOR
    protected virtual void OnValidate()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }

    // * RESET EVERYTHING IN SCREEN
    public virtual void Hide()
    {
        gameObject.SetActive(false);

        canvasGroup.DOKill();
        canvasGroup.alpha = 0f;
        canvasGroup.interactable = false;
    }

    // * APPEAR WITH CUSTOM ANIMATION
    public virtual void Appear()
    {
        gameObject.SetActive(true);
       
        canvasGroup.interactable = true;
        canvasGroup.DOFade(1f, appearDuration);
    }

    // * DISAPPEAR WITH CUSTOM ANIMATION
    public virtual void Disappear()
    {
        canvasGroup.interactable = false;
        canvasGroup.DOFade(0f, disappearDuration)
            .OnComplete(Hide);
    }
}