using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class collectshuriken : MonoBehaviour
{
    public TextMeshProUGUI countText;
    private int shuriken;

    public AudioSource collectAudio;

    private void Start()
    {
        shuriken = 0;
        SetCountText();
    }


    void SetCountText()
    {
        countText.text = "" + shuriken.ToString();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("star"))
        {
            other.gameObject.SetActive(false);
            collectAudio.Play();
            shuriken ++;
            SetCountText();
        }

        if (other.gameObject.CompareTag("FinL"))
        {
            if (shuriken >= 6)
            {
                SceneManager.LoadScene("GameOverWin");
            }
            else{
                SceneManager.LoadScene("GameOverLoss");
            }

           
        }

    }
}
