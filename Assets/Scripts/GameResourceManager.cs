using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceBundleManager : MonoBehaviour
{
    public AssetBundle emptyItemAssetBundle;
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
        LoadEmptyItems();
    }
    public void LoadEmptyItems()
    {
        emptyItemAssetBundle = AssetBundle.LoadFromFile("Assets/AssetBundles/items/empty");
    }
}
