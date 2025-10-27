using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerWinLose : MonoBehaviour
{
    public TMP_Text WINTEXT;
    public TMP_Text LOSETEXT;
    public Image kotakdoang;
    public Button restart;
    public Button exit;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Win"))
        {
            WINTEXT.gameObject.SetActive(true);
            kotakdoang.gameObject.SetActive(true);
            restart.gameObject.SetActive(true);
            exit.gameObject.SetActive(true);
            Time.timeScale = 0f;

        }

        if(collision.gameObject.CompareTag("Musuh Bang"))
        {
            LOSETEXT.gameObject.SetActive(true);
            kotakdoang.gameObject.SetActive(true);
            restart.gameObject.SetActive(true);
            exit.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
