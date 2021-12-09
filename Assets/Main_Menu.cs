using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Main_Menu : MonoBehaviour
{
    public string SceneName;

    public Image FadeUI;

    public GameObject Buttons;

    public void Awake()
    {
        FadeUI.CrossFadeAlpha(0, 0, true);
    }
    // Start is called before the first frame update
    public void Play()
    {
        FadeUI.CrossFadeAlpha(1, 1, true);
        Buttons.SetActive(false);
        StartCoroutine(ChangeScene());   
        
    }

    // Update is called once per frame
    public void Quit()
    {
        print("QUIT GAME");
        Application.Quit();
    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadSceneAsync(SceneName);
    }
}
