using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    [Header("Config")]
    [SerializeField] private Image vidaplayer;
    [SerializeField] private TextMeshProUGUI vidaTMP;

    private float vidaActual;
    private float vidaMax;

    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update

 
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ActualizarUIPersonaje();
    }
    private void ActualizarUIPersonaje()
    {
        vidaplayer.fillAmount = Mathf.Lerp(vidaplayer.fillAmount, vidaActual / vidaMax, 10f * Time.deltaTime);
        vidaTMP.text = $"{vidaActual}/{vidaMax}";
    }
    public void ActualizarVidaPersonaje(float pVidaActual, float pVidaMax)
    {
        vidaActual = pVidaActual;
            vidaMax = pVidaMax;
    }
}
