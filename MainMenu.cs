using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject optionsMenu;
    [SerializeField] PostProcessProfile ppp;
    [SerializeField] Camera mainCamera;
    [SerializeField] Toggle graphicsToggle;
    [SerializeField] AudioMixer audioMixer;
    [SerializeField] Slider musicSlider;
    [SerializeField] Slider effectSlider;
    [SerializeField] AudioSource selectSound;
    [SerializeField] GameObject musicObject;

    private void Start()
    {
        DontDestroyOnLoad(musicObject);
    }

    public void play()
    {
        selectSound.Play();
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void options()
    {
        selectSound.Play();
        optionsMenu.SetActive(true); 
        mainMenu.SetActive(false);
    }
    public void quit()
    {
        selectSound.Play();
        Application.Quit();
    }
    public void back()
    {
        selectSound.Play();
        optionsMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
    public void graphics()
    {
        selectSound.Play();
        if (graphicsToggle.isOn == false)
        {
            mainCamera.GetComponent<PostProcessVolume>().enabled = false;
        } else
        {
            mainCamera.GetComponent<PostProcessVolume>().enabled = true;
        }
    }
    public void music()
    {
        audioMixer.SetFloat("MusicVolume", musicSlider.value);
    }
    public void effect()
    {
        audioMixer.SetFloat("EffectsVolume", effectSlider.value);
    }
}
