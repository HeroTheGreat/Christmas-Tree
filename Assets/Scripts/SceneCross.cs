using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneCross : MonoBehaviour
{
public void FirstScene()
    {
        Debug.Log("Loading...");
        SceneManager.LoadScene(sceneName:"GameScene");
        SceneManager.UnloadSceneAsync(sceneName:"FirstScene");
    }
    public void ReturnGame()
    {
        Debug.Log("Loading...");
        SceneManager.LoadScene(sceneName: "FirstScene");
        SceneManager.UnloadSceneAsync(sceneName: "FinishScene");
    }
    public void Failed()
    {
        Debug.Log("Loading...");
        SceneManager.LoadScene(sceneName: "FirstScene");
        SceneManager.UnloadSceneAsync(sceneName: "GameScene");
    }
    public void Refresh()
    {
        SceneManager.LoadScene(sceneName: "GameScene");
    }
}
