using UnityEngine;
using System.Collections;

namespace KID
{
    public class GameManager : MonoBehaviour
    {

        [SerializeField, Header("�����e���s��")]
        private CanvasGroup groupFinal;
        [SerializeField, Header("����")]
        private ControlSystem controlSystem;
        [SerializeField, Header("�ͦ��t��")]
        private SpawnSystem spawnSystem;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            print($"<color=#f69>�I�쪺���� : {collision.name}</color>");
            StartCoroutine(FadeIn());
        }

        private IEnumerator FadeIn()
        {

            controlSystem.enabled = false;
            spawnSystem.enabled = false;

            for (int i = 0; i < 10; i++)
            {

                groupFinal.alpha += 0.1f;
                yield return new WaitForSeconds(0.05f);
            }

            groupFinal.interactable = true;
            groupFinal.blocksRaycasts = true;
        }
        private void Awake()
        {
            StartCoroutine(Test());
            for (int i = 0; i < 1000; i++)
            {
                print("����");
            }
        }
        private IEnumerator Test()
        {
            print("�Ĥ@��");
            yield return new WaitForSeconds(1);
            print("�ĤG��");
            yield return new WaitForSeconds(3);
            print("�ĤT��");
            yield return new WaitForSeconds(1);
            print("�ĥ|��");
        }
    }
}
