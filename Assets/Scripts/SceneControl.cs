using UnityEngine;
using UnityEngine.SceneManagement;


{
    public class SceneControl : MonoBehaviour
    {
        public void LoadScene(string scene)
        {
            print("���J����");
            SceneManager.LoadScene(scene);

     
         }

        public void Quit()
        {
            print("���}�C��");
            Application.Quit();
        }
    }
}

