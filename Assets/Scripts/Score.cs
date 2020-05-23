using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int ScoreIndex;
    [SerializeField] Text ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = ScoreIndex.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Contador()
    {
        ScoreIndex++;
        ScoreText.text = ScoreIndex.ToString();
        return;
    }
}
