using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CustomUI : MonoBehaviour
{
    public Button ReturnButton;
    public Button player1;
    public Button player2;
    public Button player3;
    public Button player4;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerPrefs.SetInt("key", 0);
        PlayerPrefs.Save();
        ReturnButton.onClick.AddListener(OnReturnButton);
        player1.onClick.AddListener(OnPlayer1Clicked);
        player2.onClick.AddListener(OnPlayer2Clicked);
        player3.onClick.AddListener(OnPlayer3Clicked);
        player4.onClick.AddListener(OnPlayer4Clicked);
        
    }

    void OnReturnButton()
    {
        Debug.Log("Return 버튼 클릭됨");
        SceneManager.LoadScene("MainUI");
    }
    void OnPlayer1Clicked()
    {
        Debug.Log("1번 커스텀");
        PlayerPrefs.SetInt("key", 0);
        PlayerPrefs.Save();
    }
    void OnPlayer2Clicked()
    {
        Debug.Log("2번 커스텀");
        PlayerPrefs.SetInt("key", 1);
        PlayerPrefs.Save();
    }
    void OnPlayer3Clicked()
    {
        Debug.Log("3번 커스텀");
        PlayerPrefs.SetInt("key", 2);
        PlayerPrefs.Save();
    }
    void OnPlayer4Clicked()
    {
        Debug.Log("4번 커스텀");
        PlayerPrefs.SetInt("key", 3);
        PlayerPrefs.Save();
    }
}
