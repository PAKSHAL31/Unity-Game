using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cursor;
    public Button Buttonplay;
    public Button Buttonsettings;
    public Button Buttonhelp;
    public Button Buttonabout;
    public int help;
    public void Start()
    {
        help = PlayerPrefs.GetInt("help", 1);
        if(help !=1)
        {
            cursor.SetActive(false);
            Buttonplay.interactable = true;
            Buttonsettings.interactable = true;
            Buttonabout.interactable = true;

        }
        Button btnplay = Buttonplay.GetComponent<Button>();
            btnplay.onClick.AddListener(TaskOnMenuClick);
            Button btnsettings = Buttonsettings.GetComponent<Button>();
            btnsettings.onClick.AddListener(TaskOnSettingClick);
            Button btnhelp = Buttonhelp.GetComponent<Button>();
            btnhelp.onClick.AddListener(TaskOnHelpClick);
            Button btnabout = Buttonabout.GetComponent<Button>();
            btnabout.onClick.AddListener(TaskOnAboutClick);
    }

    void TaskOnSettingClick()
    {
        SceneManager.LoadScene("ASettings");
    }
    void TaskOnAboutClick()
    {
        SceneManager.LoadScene("About");
    }
    void TaskOnHelpClick()
    {
        PlayerPrefs.SetInt("help", 2);
        SceneManager.LoadScene("AHelp");
    }

    void TaskOnMenuClick()
    {
        SceneManager.LoadScene("ASelectLevels");
    }
    // Update is called once per frame
}
