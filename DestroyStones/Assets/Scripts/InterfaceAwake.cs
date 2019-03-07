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
        SceneManager.LoadScene("StoneGame");
    }
}
