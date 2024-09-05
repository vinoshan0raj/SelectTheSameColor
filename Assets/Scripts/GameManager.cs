using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private string[] tags = { "Red", "Black", "Pink" };
    GamerTimer gamerTimer;
    public Vector3 newSize = new Vector3(2f, 2f, 1f);
    internal readonly string randomTag;

    void Start()
    {
        int randomIndex = Random.Range(0, tags.Length);
        string randomTag = tags[randomIndex];
        GameObject randomTaggedObject = GameObject.FindWithTag(randomTag);
        if (randomTaggedObject != null)
        {
            randomTaggedObject.transform.localScale = newSize;
        }
        if (randomTaggedObject != null)
        {

            OnMouseDown(randomTag);
        }
    }
    void OnMouseDown(string ranDom)
    {
        
        if (gameObject.CompareTag(ranDom))
        {
            Destroy(gameObject);
        }
        else
        {
            gamerTimer.TimeMinus();
            if(gamerTimer.timeElapsed <0)
            {
                RestartGame();
            }
        }
    }

    void RestartGame()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }
}

