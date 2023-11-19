public class UIManager : Singleton<UIManager>
{
    public UIScreen homeScreen;
    public UIScreen playScreen;
    public UIScreen gameOverScreen;

    private void Start()
    {
        // * HIDE ALL SCREENS
        homeScreen.Hide();
        playScreen.Hide();
        gameOverScreen.Hide();
        
        // * START GAME IN HERE
        homeScreen.Appear();
    }

    public void PlayGame()
    {
        homeScreen.Disappear();
        playScreen.Appear();
    }

    public void PlayBackToHome()
    {
        playScreen.Disappear();
        homeScreen.Appear();
    }

    public void GameOverBackToHome()
    {
        gameOverScreen.Disappear();
        homeScreen.Appear();
    }
    
    public void GameOver()
    {
        playScreen.Disappear();
        gameOverScreen.Appear();
    }

    public void ReplayGame()
    {
        gameOverScreen.Disappear();
        playScreen.Appear();
    }
}