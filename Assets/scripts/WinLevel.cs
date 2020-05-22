using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class WinLevel : MonoBehaviour
{
    public Text level;
    public string currentLevel;
    public Button Buttonhome;
    public Button Buttonnext;
    public string lname;

    // Start is called before the first frame update
    void Start()
    {
        Button btnhome = Buttonhome.GetComponent<Button>();
        btnhome.onClick.AddListener(TaskOnHomeClick);
        Button btnnext = Buttonnext.GetComponent<Button>();
        btnnext.onClick.AddListener(TaskOnNextClick);
    }

    void TaskOnHomeClick()
    {
        SceneManager.LoadScene("AMenu");
    }

    void TaskOnNextClick()
    {
        SceneManager.LoadScene(lname);
    }
    // Update is called once per frame
    void Update()
    {
        level.text = currentLevel;
    }
}
