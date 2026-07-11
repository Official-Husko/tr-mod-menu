using System.IO;
using UnityEngine;

namespace psai.net;

internal class PlatformLayerUnity : IPlatformLayer
{
	public static readonly string NAME_OF_CHANNELS_CHILDNODE = "psaiChannels";

	private static GameObject s_psaiObject;

	private Stream m_stream;

	private GameObject _psaiChannelsNode;

	public static GameObject PsaiGameObject
	{
		get
		{
			if ((Object)(object)s_psaiObject == (Object)null)
			{
				s_psaiObject = ((Component)PsaiCoreManager.HFBLDMHFBDJ).gameObject;
			}
			return s_psaiObject;
		}
	}

	void IPlatformLayer.Initialize()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		if ((Object)(object)PsaiGameObject != (Object)null)
		{
			_psaiChannelsNode = new GameObject();
			((Object)_psaiChannelsNode).name = NAME_OF_CHANNELS_CHILDNODE;
			_psaiChannelsNode.transform.parent = PsaiGameObject.transform;
		}
	}

	void IPlatformLayer.Release()
	{
		if ((Object)(object)_psaiChannelsNode != (Object)null && ((Object)_psaiChannelsNode).name.Equals(NAME_OF_CHANNELS_CHILDNODE))
		{
			Object.DestroyImmediate((Object)(object)_psaiChannelsNode);
		}
	}

	private Stream GetStreamOnPsaiSoundtrackFile(TextAsset textAsset)
	{
		if ((Object)(object)textAsset != (Object)null)
		{
			m_stream = new MemoryStream(textAsset.bytes);
			return m_stream;
		}
		return null;
	}

	public string ConvertFilePathForPlatform(string originalPath)
	{
		string text = originalPath.Replace('\\', '/');
		string text2 = "";
		if (text.Contains("/"))
		{
			return Path.GetDirectoryName(text) + "/" + Path.GetFileNameWithoutExtension(text);
		}
		return Path.GetFileNameWithoutExtension(text);
	}

	public Stream GetStreamOnPsaiSoundtrackFile(string fullFilePathWithinResourcesDir)
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		if (LogLevel.info <= Logger.Instance.LogLevel)
		{
			string argText = "PlatformLayerUnity::GetStreamOnPsaiSoundtrackFile(): trying to load " + fullFilePathWithinResourcesDir;
			Logger.Instance.Log(argText, LogLevel.info);
		}
		string text = ConvertFilePathForPlatform(fullFilePathWithinResourcesDir);
		if (LogLevel.info <= Logger.Instance.LogLevel)
		{
			Logger.Instance.Log("Trying to load '" + text + "' from Resources.", LogLevel.info);
		}
		TextAsset val = new TextAsset();
		val = (TextAsset)Resources.Load(text, typeof(TextAsset));
		if ((Object)(object)val == (Object)null)
		{
			Logger.Instance.Log("Loading failed! No psai soundtrack file could be found within the Resources folder at '" + text + "'", LogLevel.errors);
			return null;
		}
		if (LogLevel.info <= Logger.Instance.LogLevel)
		{
			Logger.Instance.Log("File was found.", LogLevel.info);
		}
		return GetStreamOnPsaiSoundtrackFile(val);
	}
}
