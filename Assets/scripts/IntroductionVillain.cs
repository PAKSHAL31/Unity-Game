using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class IntroductionVillain : MonoBehaviour
{
    public GameObject intro;
    public Button ButtonOK;
    public int count;
    // Start is called before the first frame update
    void Start()
    {
        count = PlayerPrefs.GetInt("count", 1);
        if (count != 1)
            intro.SetActive(false);
        Button btnOK = ButtonOK.GetComponent<Button>();
        btnOK.onClick.AddListener(TaskOnOKClick);
    }
    void TaskOnOKClick()
    {
        intro.SetActive(false);
        PlayerPrefs.SetInt("count", 2);
    }

}
