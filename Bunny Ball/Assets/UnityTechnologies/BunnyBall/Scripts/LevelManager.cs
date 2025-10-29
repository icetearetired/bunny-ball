using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public string level1;
    public string level2;
    public string level3;

    public void loadLevel1()
    {
        SceneManager.LoadScene(level1);
    }
    public void loadLevel2()
    {
        SceneManager.LoadScene(level2);
    }
    public void loadLevel3()
    {
        SceneManager.LoadScene(level3);
    }

}
