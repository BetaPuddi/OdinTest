using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceBundleManager : MonoBehaviour
{
    public AssetBundle blankItemAssetBundle;
    public static ResourceBundleManager Instance { get; private set; }
    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
        LoadblankItems();
    }
    public void LoadblankItems()
    {
        blankItemAssetBundle = AssetBundle.LoadFromFile("Assets/AssetBundles/blank");
    }
}
