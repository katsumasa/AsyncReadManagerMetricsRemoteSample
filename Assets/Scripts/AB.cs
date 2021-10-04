using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


public class AB
{	
	public static AssetBundle Load(string assetBundleName)
    {
		var path = Path.Combine(GetAssetBundlePath(), assetBundleName);
		return AssetBundle.LoadFromFile(path);
    }
	

	private static string GetAssetBundlePath()
	{
#if UNITY_ANDROID && !UNITY_EDITOR

		var path = "file://" + Path.Combine(Application.streamingAssetsPath,"AssetBundle");
#else
		var path = Path.Combine(Application.streamingAssetsPath, "AssetBundle");
		
#endif
		switch (Application.platform)
		{
			case RuntimePlatform.WindowsEditor:
			case RuntimePlatform.WindowsPlayer:
				return Path.Combine(path,"Windows");
			case RuntimePlatform.OSXEditor:
			case RuntimePlatform.OSXPlayer:
				return Path.Combine(path,"OSX");
			case RuntimePlatform.Android:
				return Path.Combine(path,"Android");
			case RuntimePlatform.IPhonePlayer:
				return Path.Combine(path,"iOS");
			default:
				return Path.Combine(path,"etc");
		}
	}
}
