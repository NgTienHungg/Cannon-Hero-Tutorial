public class UIPlayScreen : UIScreen
{
    public void OnClickBackButton()
    {
        UIManager.Instance.PlayBackToHome();
    }
}