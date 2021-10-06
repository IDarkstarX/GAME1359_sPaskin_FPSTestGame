using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public static gameManager instance;

    public int ammo;
    public int score;

    void Start()
    {
        
        if(instance == null)
        {
            instance = this;
        }
        if (instance != null)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void goToScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}
