using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Manager : MonoBehaviour
{
    public enum Levels { Menu = 0, Level01=1, Level02 = 2 };
    public void ChangeLevel(Levels level)
    {
        SceneManager.LoadScene((int)level);
    }
    public void ChangeLevel(int index)
    {
        SceneManager.LoadScene(index);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            ChangeLevel(1);
        }
    }
}
