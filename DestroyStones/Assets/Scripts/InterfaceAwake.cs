using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InterfaceAwake : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Nos aseguramos que es 0, ya que de Final vendremos aqui y no seran 0
        GameManager.currentNumberStonesThrown = 0;
        GameManager.currentNumberDestroyedStones = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click()
    {
        Time.timeScale = 3.0f;
        SceneManager.LoadScene("StoneGame");
    }

    public void EasyClick()
    {
        Time.timeScale = 2.0f;
        SceneManager.LoadScene("StoneGame");
    }

    public void HardClick()
    {
        Time.timeScale = 4.0f;
        SceneManager.LoadScene("StoneGame");
    }
}
