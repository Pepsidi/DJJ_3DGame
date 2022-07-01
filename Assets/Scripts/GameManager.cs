using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public RawImage image01;
    public RawImage image02;
    public RawImage image03;

    float tempColor = 255;
    void Start()
    {
        
    }
    void Update()
    {
        tempColor--;
        ImageChange();
    }
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Restart()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
      Time.timeScale = 1f;
    }
    void Pause()
    {
      //pauseMenuUI.SetActive(true);
      //Time.timeScale = 0f;
    }
    
    public void ResumeGame()
    {
      //pauseMenuUI.SetActive(false);
      //Time.timeScale = 1f;
    
    }
    public void Quit()
    {
      Application.Quit();
    }
    void ImageChange()
    {
        image01.color = new Color(image01.color.r, image01.color.g, image01.color.b,tempColor);
        
    }
}
