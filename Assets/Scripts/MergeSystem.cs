using choco;
using System;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

namespace KID
{
    /// <summary>
    /// 合成
    /// </summary>
    [DefaultExecutionOrder(0)]
    public class MergeSystem : MonoBehaviour
    {
        [Header("所有史萊姆預製物")]
        public GameObject[] prefabslimes;
        public static MergeSystem instance;
        private bool canMerge = true;

        public void Awake()
        {
            instance = this;

        }
        public void Merge(int _index,Vector2 _point)


        {
            if (canMerge)
            {
                canMerge = false;
                
                print("<color=#99F>合成</color>");
                GameObject tempSlimes = Instantiate(prefabslimes[_index], _point, Quaternion.identity);
                tempSlimes.GetComponent<Rigidbody2D>().gravityScale = 1;
                Invoke("CanMerge", 0.1f);
                scoreManager.instance.AddScore(_index);
            
            }
          


        }

        private void CanMerge()
        {
            canMerge=true;
        }
    }

}

