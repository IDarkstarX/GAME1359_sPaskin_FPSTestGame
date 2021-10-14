using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class displayAmmo : MonoBehaviour
{

    [SerializeField]
    Text ammoText;

    [SerializeField]
    Text livesText;

    [SerializeField]
    Text scoreText;

    void Start()
    {
        ammoText.text = "Ammo: " + gameManager.instance.ammo;
        livesText.text = "Lives: " + gameManager.instance.lives;
        scoreText.text = "Score: " + gameManager.instance.score;
    }

    void Update()
    {
        ammoText.text = "Ammo: " + gameManager.instance.ammo;
        livesText.text = "Lives: " + gameManager.instance.lives;
        scoreText.text = "Score: " + gameManager.instance.score;
    }
}