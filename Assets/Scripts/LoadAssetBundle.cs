using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssetBundle : MonoBehaviour
{
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] string abName;
    [SerializeField] string[] assetNames;
    int index;
    int wait;
    bool isDone;

    // Start is called before the first frame update
    void Start()
    {
        isDone = true;
    }

    private void Update()
    {
        wait--;
        if(wait <= 0)
        {            
            wait = Random.Range(1, 5);
            var ab = AB.Load(abName);
            if (ab != null)
            {
                index++;
                if(index >= assetNames.Length)
                {
                    index = 0;
                }                                         
                var assetName = assetNames[index];                               
                spriteRenderer.sprite = ab.LoadAsset<Sprite>(assetName);
                ab.Unload(false);

                UnLoadUnusedAssets();                
            }
        }
    }


    void Done(AsyncOperation asyncOperation)
    {
        isDone = true;
    }

    void UnLoadUnusedAssets()
    {
        if (isDone)
        {
            isDone = false;
            var asyncOperation = Resources.UnloadUnusedAssets();
            asyncOperation.completed += Done;
        }
    }



}
