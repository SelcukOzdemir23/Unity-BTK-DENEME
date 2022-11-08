using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManagerMenuScene : MonoBehaviour
{
    public GameObject dataBoard;
   
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public void PlayButton()
    {
        SceneManager.LoadScene(1);
    }
    public void DataBoardButton()

    {
        DataManager.Instance.LoadData();

        dataBoard.transform.GetChild(1).GetComponent<Text>().text ="Edilen Atış Sayısı: " +DataManager.Instance.totalShotBullet.ToString();
        dataBoard.transform.GetChild(2).GetComponent<Text>().text ="Öldürülen Düşman Sayısı: "+ DataManager.Instance.totalEnemyKilled.ToString();
        dataBoard.SetActive(true);

    }
    public void XButton()
    {
        dataBoard.SetActive(false);
    }
    
}
