using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InterfaceFinal : MonoBehaviour
{
    public Text textThrown;
    public Text textDestroyed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textThrown.text = "Number of Stones: " + GameManager.currentNumberStonesThrown;
        textDestroyed.text = "Points: " + GameManager.currentPoints;
    }

    public void Click()
    {
        SceneManager.LoadScene("Awake");
    }

    public void RetryClick()
    {
        GameManager.currentNumberStonesThrown = 0;
        GameManager.currentNumberDestroyedStones = 0;
        GameManager.currentNumberLives = 3;
        GameManager.currentPoints = 0;
        SceneManager.LoadScene("StoneGame");
    }
}
