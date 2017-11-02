using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public static UIManager Instance = null;

    [Header("Texts")] public Text NomeText;
    public Text OrigemText;
    public Text HistoriaText;
    public Text IdadeText;
    public Text RacaText;

    private void Awake()
    {
        Instance = this;
    }
    

    public void UpdateTexts(Character character)
    {
        NomeText.text = "Nome: " + character.Nome;
        OrigemText.text = "Origem: " + character.Origem;
        HistoriaText.text = "Historia: " + character.Historia;
        IdadeText.text = "Idade: " + character.Idade;
        RacaText.text = "Raca: " + character.Raca;
    }
}
