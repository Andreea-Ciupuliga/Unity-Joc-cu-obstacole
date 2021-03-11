using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//pt cand vrem sa schimbam scena sau sa dam reload la scena curenta

public class gameManager : MonoBehaviour
{
     //gameManager -> cu ajutorul lui vom incepe un joc nou dupa ce pierdem 
     
    bool gameHasEnded = false;//pt a ne afisa "Game Over" doar o data
    public float restartDelay = 1f;
    public GameObject CompleteLevelUI;//este o referinta la UI ca sa il putem activa cand terminam un lvl

    public void CompleteLevel()
    {
        CompleteLevelUI.SetActive(true);

    }

    public void EndGame()
    {
        if(gameHasEnded==false)
        {
            gameHasEnded = true;
            Debug.Log("game over");
            Invoke("restart",restartDelay); //jocul o ia iar de la capat dar cu o mica intarziere 
        }
    }
    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //ne da numele scenei curente si ii dam load
    }
}
