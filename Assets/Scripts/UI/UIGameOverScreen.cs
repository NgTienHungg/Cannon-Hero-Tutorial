using UnityEngine;

public class UIGameOverScreen : UIScreen
{
    public void OnClickReplayButton()
    {
        UIManager.Instance.ReplayGame();
    }
    
    public void OnClickHomeButton()
    {
        UIManager.Instance.GameOverBackToHome();
    }
    
    public void OnClickShopButton()
    {
        Debug.Log("On Click Rank Button");
    }
    
    public void OnClickRateButton()
    {
        Debug.Log("On Click Rate Button");
    }
    
    public void OnClickShareButton()
    {
        Debug.Log("On Click S2B Button");
    }
}
