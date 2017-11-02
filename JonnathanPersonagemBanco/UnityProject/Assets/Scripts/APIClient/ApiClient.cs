using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Networking;

public class ApiClient : MonoBehaviour
{
    private const string _baseUrl = "http://localhost:62982/API/";

    List<Character> _characters;

    // Use this for initialization
    void Start()
    {

        StartCoroutine(GetItensApiAsync());
    }

    //private IEnumerator PostItemApiAsync()
    //{
    //    WWWForm form = new WWWForm();

    //    form.AddField("Nome", "ItemFromUnity");
    //    form.AddField("Descricao", "Item enviado por POST para Unity");
    //    form.AddField("DanoMaximo", "5");
    //    form.AddField("Raridade", "5");
    //    form.AddField("TipoItemID", "2");

    //    using (UnityWebRequest request = UnityWebRequest.Post(_baseUrl + "/Itens/Create", form))
    //    {
    //        yield return request.Send();

    //        if (request.isNetworkError || request.isHttpError)
    //        {
    //            Debug.Log(request.error);
    //        }
    //        else
    //        {
    //            Debug.Log("Envio do item efetuado com sucesso!");
    //        }
    //    }
    //}

    IEnumerator GetItensApiAsync()
    {
        UnityWebRequest request = UnityWebRequest.Get(_baseUrl + "/Characters");
        yield return request.Send();

        if (request.isNetworkError || request.isHttpError)
        {
            Debug.Log(request.error);
        }
        else
        {
            string response = request.downloadHandler.text;
            //print("" + response);

            byte[] bytes = request.downloadHandler.data;

            _characters = JsonHelper.GetJsonArray<Character>(response).ToList();

            //foreach (var i in _characters)
            //{
            //    ImprimirItem(i);
            //}

            UIManager.Instance.UpdateTexts(_characters[0]);

        }
    }

    private void ImprimirItem(Character i)
    {
        Debug.Log("---------- Dados Objeto ----------");
        Debug.Log("======== " + i.Nome + " ===============");
        Debug.Log("Id: " + i.CharacterID);

        //Debug.Log("Descricao: " + i.Descricao);
        //Debug.Log("DanoMaximo: " + i.DanoMaximo);
        //Debug.Log("Raridade: " + i.Raridade);
        //Debug.Log("Tipo Item: " + i.TipoItemID);

    }
}
