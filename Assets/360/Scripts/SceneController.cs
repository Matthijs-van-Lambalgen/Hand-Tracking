using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("HandsDemoScene");
    }

    public void MKBWerkplaats()
    {
        SceneManager.LoadScene("MKB Werkplaats");
    }

    public void Cartesius()
    {
        SceneManager.LoadScene("Cartesius");
    }

    public void Celciushuis()
    {
        SceneManager.LoadScene("Celciushuis");
    }

    public void HUOekra�neProject()
    {
        SceneManager.LoadScene("HU Oekra�ne Project");
    }

    public void BruggenbouwersGrensverleggers()
    {
        SceneManager.LoadScene("Bruggenbouwers en Grensverleggers");
    }

    public void Overvecht()
    {
        SceneManager.LoadScene("Overvecht");
    }
}
