using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Image LoadingBarImg;
    public GameObject LoadingPannel;

    // Start is called before the first frame update
    private void Start()
    {
        LoadingPannel.SetActive(true);
        LoadingBarImg.fillAmount = 0;
    }

    // Update is called once per frame
    private void Update()
    {
        LoadingBarImg.fillAmount += Time.deltaTime;
        if (LoadingBarImg.fillAmount == 1)
        {
            LoadingPannel.SetActive(false);
        }
    }

    public void onPlayButtonCLick()
    {
        SceneManager.LoadScene(1);
    }
}