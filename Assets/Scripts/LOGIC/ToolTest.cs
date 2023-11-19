using UnityEngine;
using Sirenix.OdinInspector;

public class ToolTest : MonoBehaviour
{
    [Button]
    public void TestGameOver()
    {
        Debug.LogWarning("GameOver");
        UIManager.Instance.GameOver();
    }
}