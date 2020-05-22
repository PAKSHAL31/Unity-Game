using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Settings : MonoBehaviour
{
    public Button Buttonreset;
    public Button Buttonback;
    public Button ButtonOK;
    public GameObject Panel;
    // Start is called before the first frame update
    void Start()
    {
        Button btnreset = Buttonreset.GetComponent<Button>();
        btnreset.onClick.AddListener(TaskOnResetClick);
        Button btnback = Buttonback.GetComponent<Button>();
        btnback.onClick.AddListener(TaskOnBackClick);
        Button btnok = ButtonOK.GetComponent<Button>();
        btnok.onClick.AddListener(TaskOnOKClick);
    }
    void TaskOnResetClick()
    {
        PlayerPrefs.DeleteAll();
        Panel.SetActive(true);
    }

    void TaskOnOKClick()
    {
        Panel.SetActive(false);
    }
    void TaskOnBackClick()
    {
        SceneManager.LoadScene("AMenu");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
