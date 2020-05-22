using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Button[] levelButtons;
    public Button Buttonback;
    // Start is called before the first frame update

        void Start()
      {
        Button btnback = Buttonback.GetComponent<Button>();
        btnback.onClick.AddListener(TaskOnBackClick);
        //PlayerPrefs.DeleteAll();
        int LTS = PlayerPrefs.GetInt("LTS",2);
         // Debug.Log(PlayerPrefs.GetInt("levelstart", 1));
          Debug.Log(LTS);
          for (int i = 0; i < levelButtons.Length; i++)
          {
              if(i + 2 > LTS)
                  levelButtons[i].interactable = false;
          }
      }
    void TaskOnBackClick()
    {
        SceneManager.LoadScene("AMenu");
    }
    public void Select (string levelName)
    {
        SceneManager.LoadScene(levelName);

    }
    // Update is called once per frame
    void Update()
    {
    }
}
