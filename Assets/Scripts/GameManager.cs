using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject ArrowPrefab;
    public GameObject Player;
    Vector3 playerPos;
    public GameObject hpGauge;
    int Life = 10;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MakeArrow", 0, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Life <= 0)
            SceneManager.LoadScene("GameScene");

        playerPos = Player.transform.position;
    }
    void MakeArrow()
    {
        float px = Random.Range(-3.0f, 4.0f);
        float py = playerPos.y + 6;
        Instantiate(ArrowPrefab, new Vector3(px, py, 0), Quaternion.identity);
    }
    public void DecreaseHp()
    {
        Life -= 1;
        hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
}