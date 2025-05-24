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

    private bool c1 = true; // 1번 커스텀
    private bool c2 = false; // 2번 커스텀
    private bool c3 = false; // 3번 커스텀
    private bool c4 = false; // 4번 커스텀

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ReturnButton.onClick.AddListener(OnReturnButton); // Return 버튼 클릭 시 호출되는 함수 등록
        player1.onClick.AddListener(OnPlayer1Clicked); // 1번 플레이어 버튼 클릭 시 호출되는 함수 등록
        player2.onClick.AddListener(OnPlayer2Clicked); // 2번 플레이어 버튼 클릭 시 호출되는 함수 등록
        player3.onClick.AddListener(OnPlayer3Clicked); // 3번 플레이어 버튼 클릭 시 호출되는 함수 등록
        player4.onClick.AddListener(OnPlayer4Clicked); // 4번 플레이어 버튼 클릭 시 호출되는 함수 등록
    }

    void OnReturnButton()
    {
        Debug.Log("Return 버튼 클릭됨");
        SceneManager.LoadScene("MainUI");
    }
    void OnPlayer1Clicked()
    {
        int value = 200;
        Debug.Log("1번 커스텀");
        PlayerPrefs.SetInt("key", 0);
        PlayerPrefs.Save();
    }
    void OnPlayer2Clicked()
    {
        int value = 300;
        Debug.Log("2번 커스텀");
        PlayerPrefs.SetInt("key", 1);
        PlayerPrefs.Save();
    }
    void OnPlayer3Clicked()
    {
        int value = 300;
        Debug.Log("3번 커스텀");
        PlayerPrefs.SetInt("key", 2);
        PlayerPrefs.Save();
    }
    void OnPlayer4Clicked()
    {
        int value = 300;
        Debug.Log("4번 커스텀");
        PlayerPrefs.SetInt("key", 3);
        PlayerPrefs.Save();
    }

    void buy(int value, bool check)
    {
        int money = PlayerPrefs.GetInt("sumscore", 0); //현재 저장된 재화 가치 불러오기
        if (money - value != 0)
        {
            PlayerPrefs.SetInt("sumscore", money - value); //재화 가치 업데이트
            PlayerPrefs.Save(); //변경사항 저장
            Debug.Log("재화 업데이트 및 구매 완료");
            check = true; // 구매 완료 상태로 변경
        }
        else
        {
            Debug.Log("재화 부족으로 구매 실패");
        }
    }

    void CheckBought(int value, bool check)
    {
        if (check)
        {
            Debug.Log("이미 구매한 아이템");
        }
        else
        {
            Debug.Log("구매 완료 또는 구매 실패");
            buy(value, check); // 아이템 구매 함수 호출
        }
    }
}