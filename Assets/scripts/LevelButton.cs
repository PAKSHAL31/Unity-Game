using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class LevelButton : MonoBehaviour
{
    public Button Buttonlevel;
    public string lname;
    void Start()
    {
        Button btnlevel = Buttonlevel.GetComponent<Button>();
        btnlevel.onClick.AddListener(TaskOnLevelClick);
    }

    void TaskOnLevelClick()
    {
        SceneManager.LoadScene(lname);
    }
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
