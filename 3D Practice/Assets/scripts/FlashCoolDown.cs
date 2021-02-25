using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FlashCoolDown : MonoBehaviour
{
    public float CD = 5;
    public GameObject fillskill;
    private Image filledImage;
    private float timer = 0;
    public bool IsStartTimer = false;

    private void Start()
    {
        filledImage = fillskill.GetComponent<Image>();
    }
    private void Update()
    {
        if (IsStartTimer)
        {
            timer += Time.deltaTime;
            filledImage.fillAmount = (CD - timer) / CD;
        }
        if (timer >= CD)
        {
            filledImage.fillAmount = 0;
            timer = 0;
            IsStartTimer = false;
        }
    }
    public void OnCool()
    {
        IsStartTimer = true;
    }
}
