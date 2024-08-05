using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    private UIDocument document;
    private Button botaojogar;

    private void Awake()
    {
        document = GetComponent<UIDocument>();
        botaojogar = document.rootVisualElement.Q<Button>("btn_jogar");
        botaojogar.RegisterCallback<ClickEvent>(OnPlayGame);
    }

    void OnPlayGame(ClickEvent evt) 
    {
        SceneManager.LoadScene("Main");
    }
}
