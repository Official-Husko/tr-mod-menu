using UnityEngine;
using psai.net;

public static class Options
{
	private static int PJDEFCHOLBM;

	private static int IBEOJFJKPNF;

	private static int BAJNGHLDKFH;

	private static int EODPFIAONKK;

	private static int IJNILBPIEDO;

	public static int DJLJFDPNCPI
	{
		get
		{
			return PJDEFCHOLBM;
		}
		set
		{
			PJDEFCHOLBM = value;
			Sound.GGFJGHHHEJC.audioMixer.SetFloat("SFXVolume", Sound.LevelToDB(Mathf.Lerp(0f, 15f, (float)PJDEFCHOLBM * 0.1f * ((float)PJDEFCHOLBM * 0.1f))));
			PlayerPrefs.SetInt("sfxLevel", PJDEFCHOLBM);
			PlayerPrefs.Save();
		}
	}

	public static int DCIGBKPCLCK
	{
		get
		{
			return IBEOJFJKPNF;
		}
		set
		{
			IBEOJFJKPNF = value;
			PsaiCore.Instance.SetVolume(Mathf.Lerp(0f, 0.35f, (float)IBEOJFJKPNF * 0.1f * ((float)IBEOJFJKPNF * 0.1f)));
			PlayerPrefs.SetInt("musicLevel", IBEOJFJKPNF);
			PlayerPrefs.Save();
		}
	}

	public static bool AAFBLMLIJPH
	{
		get
		{
			return PlayerPrefs.GetInt("chatSounds", 1) == 1;
		}
		set
		{
			PlayerPrefs.SetInt("chatSounds", value ? 1 : 0);
			PlayerPrefs.Save();
		}
	}

	public static int IIKOHJMGJIG
	{
		get
		{
			return BAJNGHLDKFH;
		}
		set
		{
			BAJNGHLDKFH = value;
			PlayerPrefs.SetInt("cursorSensitivity", BAJNGHLDKFH);
			PlayerPrefs.Save();
		}
	}

	public static int OIJKKLHIGDD
	{
		get
		{
			return EODPFIAONKK;
		}
		set
		{
			EODPFIAONKK = value;
			PlayerPrefs.SetInt("christmasActivated", EODPFIAONKK);
			PlayerPrefs.Save();
		}
	}

	public static int GPFJCMAGGAO
	{
		get
		{
			return IJNILBPIEDO;
		}
		set
		{
			IJNILBPIEDO = value;
			PlayerPrefs.SetInt("halloweenActivated", IJNILBPIEDO);
			PlayerPrefs.Save();
		}
	}
}
