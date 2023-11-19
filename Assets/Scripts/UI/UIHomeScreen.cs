using DG.Tweening;
using UnityEngine;

public class UIHomeScreen : UIScreen
{
    [Header("Top buttons")]
    [SerializeField] private RectTransform musicButton;
    [SerializeField] private RectTransform soundButton;
    [SerializeField] private float startMusicSoundButtonX = -100f;
    [SerializeField] private float targetMusicButtonX;
    [SerializeField] private float targetSoundButtonX;

    [Header("Bottom buttons")]
    [SerializeField] private RectTransform bottomButtons;
    [SerializeField] private float startBottomButtonsY = -200f;
    [SerializeField] private float targetBottomButtonsY = 300f;

    protected override void OnValidate()
    {
        base.OnValidate();
        targetMusicButtonX = musicButton.anchoredPosition.x;
        targetSoundButtonX = soundButton.anchoredPosition.x;
    }

    public override void Hide()
    {
        base.Hide();
        
        musicButton.DOKill();
        musicButton.anchoredPosition = new Vector2(startMusicSoundButtonX, 0f);
        
        soundButton.DOKill();
        soundButton.anchoredPosition = new Vector2(startMusicSoundButtonX, 0f);

        bottomButtons.DOKill();
        bottomButtons.anchoredPosition = new Vector2(0f, startBottomButtonsY);
    }

    public override void Appear()
    {
        base.Appear();

        musicButton.DOAnchorPosX(targetMusicButtonX, 0.4f)
            .SetEase(Ease.OutQuart);

        soundButton.DOAnchorPosX(targetSoundButtonX, 0.4f)
            .SetEase(Ease.OutQuart)
            .SetDelay(0.1f);

        bottomButtons.DOAnchorPosY(targetBottomButtonsY, 0.5f)
            .SetEase(Ease.OutBack);
    }
    
    public void OnClickPlayButton()
    {
        Debug.Log("On Click Play Button");
        UIManager.Instance.PlayGame();
    }

    public void OnClickNoAdsButton()
    {
        Debug.Log("On Click No Ads Button");
    }

    public void OnClickRankButton()
    {
        Debug.Log("On Click Rank Button");
    }

    public void OnClickRateButton()
    {
        Debug.Log("On Click Rate Button");
    }

    public void OnClickS2BButton()
    {
        Debug.Log("On Click S2B Button");
    }

    public void OnClickShopButton()
    {
        Debug.Log("On Click Shop Button");
    }
}