using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class IntroductionScript : MonoBehaviour
{
    public GameObject intro;
    public Button ButtonOK;
    public int counter;

    // Start is called before the first frame update
    void Start()
    {
        counter = PlayerPrefs.GetInt("counter", 1);
        if (counter != 1)
            intro.SetActive(false);
        Button btnOK = ButtonOK.GetComponent<Button>();
        btnOK.onClick.AddListener(TaskOnOKClick);
    }

    void TaskOnOKClick()
    {
        intro.SetActive(false);
        PlayerPrefs.SetInt("counter", 2);
    }
}
