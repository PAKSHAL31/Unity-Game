using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LooseLevel : MonoBehaviour
{
    public Text level;
    public string currentLevel;
    public Button Buttonhome;
    public Button Buttonretry;
    // Start is called before the first frame update
    void Start()
    {
        Button btnhome = Buttonhome.GetComponent<Button>();
        btnhome.onClick.AddListener(TaskOnHomeClick);
        Button btnret = Buttonretry.GetComponent<Button>();
        btnret.onClick.AddListener(TaskOnRetryClick);
    }

    void TaskOnHomeClick()
    {
        SceneManager.LoadScene("AMenu");
    }

    void TaskOnRetryClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    // Update is called once per frame
    void Update()
    {
        level.text = currentLevel;
    }
}
