using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/Input/ControllersDatabase")]
public class ControllersDatabase : ScriptableObject
{
	[Serializable]
	public struct VibrationProfile
	{
		public float impactIntensity;

		public float impactDuration;

		public float trembleStart;

		public float trembleDuration;
	}

	public enum VibrationMaterial
	{
		Pick,
		Ax,
		Spade,
		Hoe,
		SickleSwing,
		SickleCut
	}

	public ControllerInfo[] ControllersInfo;

	public VibrationProfile PickProfile = new VibrationProfile
	{
		impactIntensity = 1f,
		impactDuration = 0.15f,
		trembleStart = 0.25f,
		trembleDuration = 0.15f
	};

	public VibrationProfile AxProfile = new VibrationProfile
	{
		impactIntensity = 0.5f,
		impactDuration = 0.15f,
		trembleStart = 0.15f,
		trembleDuration = 0.35f
	};

	public VibrationProfile ShovelProfile = new VibrationProfile
	{
		impactIntensity = 0.55f,
		impactDuration = 0.15f,
		trembleStart = 0.18f,
		trembleDuration = 0.03f
	};

	public VibrationProfile HoeProfile = new VibrationProfile
	{
		impactIntensity = 0.45f,
		impactDuration = 0.05f,
		trembleStart = 0.12f,
		trembleDuration = 0.12f
	};

	public VibrationProfile SickleSwingProfile = new VibrationProfile
	{
		impactIntensity = 0.15f,
		impactDuration = 0.03f,
		trembleStart = 0.05f,
		trembleDuration = 0.05f
	};

	public VibrationProfile SickleCutProfile = new VibrationProfile
	{
		impactIntensity = 0.8f,
		impactDuration = 0.1f,
		trembleStart = 0f,
		trembleDuration = 0f
	};

	public string BBBCHMLKPCG(ControllerInfo AKKFEAFGBCH)
	{
		List<ControllerInfo> list = new List<ControllerInfo>(ControllersInfo);
		list.Add(AKKFEAFGBCH);
		ControllersInfo = list.ToArray();
		return AKKFEAFGBCH.nameID;
	}

	public string KKDIDMIGHGF(ControllerInfo AKKFEAFGBCH)
	{
		List<ControllerInfo> list = new List<ControllerInfo>(ControllersInfo);
		list.Add(AKKFEAFGBCH);
		ControllersInfo = list.ToArray();
		return AKKFEAFGBCH.nameID;
	}

	public string KDJHBMMBKIC(ControllerInfo AKKFEAFGBCH)
	{
		List<ControllerInfo> list = new List<ControllerInfo>(ControllersInfo);
		list.Add(AKKFEAFGBCH);
		ControllersInfo = list.ToArray();
		return AKKFEAFGBCH.nameID;
	}

	public string INKFHHJAEKK(ControllerInfo AKKFEAFGBCH)
	{
		List<ControllerInfo> list = new List<ControllerInfo>(ControllersInfo);
		list.Add(AKKFEAFGBCH);
		ControllersInfo = list.ToArray();
		return AKKFEAFGBCH.nameID;
	}

	public VibrationProfile DEGLJNICPIO(VibrationMaterial GGHLHODEPIK)
	{
		return GGHLHODEPIK switch
		{
			VibrationMaterial.Pick => PickProfile, 
			VibrationMaterial.Ax => AxProfile, 
			VibrationMaterial.Spade => ShovelProfile, 
			VibrationMaterial.Hoe => HoeProfile, 
			VibrationMaterial.SickleSwing => SickleSwingProfile, 
			VibrationMaterial.SickleCut => SickleCutProfile, 
			_ => PickProfile, 
		};
	}

	public string FFOEDPFGHPO(ControllerInfo AKKFEAFGBCH)
	{
		List<ControllerInfo> list = new List<ControllerInfo>(ControllersInfo);
		list.Add(AKKFEAFGBCH);
		ControllersInfo = list.ToArray();
		return AKKFEAFGBCH.nameID;
	}

	public string AOEHNCNEFCM(ControllerInfo AKKFEAFGBCH)
	{
		List<ControllerInfo> list = new List<ControllerInfo>(ControllersInfo);
		list.Add(AKKFEAFGBCH);
		ControllersInfo = list.ToArray();
		return AKKFEAFGBCH.nameID;
	}

	public VibrationProfile ADHLDBCFNEI(VibrationMaterial GGHLHODEPIK)
	{
		return GGHLHODEPIK switch
		{
			VibrationMaterial.Pick => PickProfile, 
			VibrationMaterial.Ax => AxProfile, 
			VibrationMaterial.Spade => ShovelProfile, 
			VibrationMaterial.Hoe => HoeProfile, 
			VibrationMaterial.SickleSwing => SickleSwingProfile, 
			VibrationMaterial.SickleCut => SickleCutProfile, 
			_ => PickProfile, 
		};
	}

	public string LGFAFECLGDD(ControllerInfo AKKFEAFGBCH)
	{
		List<ControllerInfo> list = new List<ControllerInfo>(ControllersInfo);
		list.Add(AKKFEAFGBCH);
		ControllersInfo = list.ToArray();
		return AKKFEAFGBCH.nameID;
	}

	public VibrationProfile KEAEICCKADI(VibrationMaterial GGHLHODEPIK)
	{
		return GGHLHODEPIK switch
		{
			VibrationMaterial.Pick => PickProfile, 
			VibrationMaterial.Ax => AxProfile, 
			VibrationMaterial.Spade => ShovelProfile, 
			VibrationMaterial.Hoe => HoeProfile, 
			VibrationMaterial.SickleSwing => SickleSwingProfile, 
			VibrationMaterial.SickleCut => SickleCutProfile, 
			_ => PickProfile, 
		};
	}

	public string LEPLOLGJMGB(ControllerInfo AKKFEAFGBCH)
	{
		List<ControllerInfo> list = new List<ControllerInfo>(ControllersInfo);
		list.Add(AKKFEAFGBCH);
		ControllersInfo = list.ToArray();
		return AKKFEAFGBCH.nameID;
	}

	public string ADJIJOPKPHD(ControllerInfo AKKFEAFGBCH)
	{
		List<ControllerInfo> list = new List<ControllerInfo>(ControllersInfo);
		list.Add(AKKFEAFGBCH);
		ControllersInfo = list.ToArray();
		return AKKFEAFGBCH.nameID;
	}

	public VibrationProfile HILDOLKBODI(VibrationMaterial GGHLHODEPIK)
	{
		return GGHLHODEPIK switch
		{
			VibrationMaterial.Pick => PickProfile, 
			VibrationMaterial.Ax => AxProfile, 
			VibrationMaterial.Spade => ShovelProfile, 
			VibrationMaterial.Hoe => HoeProfile, 
			VibrationMaterial.SickleSwing => SickleSwingProfile, 
			VibrationMaterial.SickleCut => SickleCutProfile, 
			_ => PickProfile, 
		};
	}

	public string PFGLJHJOELP(ControllerInfo AKKFEAFGBCH)
	{
		List<ControllerInfo> list = new List<ControllerInfo>(ControllersInfo);
		list.Add(AKKFEAFGBCH);
		ControllersInfo = list.ToArray();
		return AKKFEAFGBCH.nameID;
	}

	public VibrationProfile DIPDMLJBDHG(VibrationMaterial GGHLHODEPIK)
	{
		return GGHLHODEPIK switch
		{
			VibrationMaterial.Pick => PickProfile, 
			VibrationMaterial.Ax => AxProfile, 
			VibrationMaterial.Spade => ShovelProfile, 
			VibrationMaterial.Hoe => HoeProfile, 
			VibrationMaterial.SickleSwing => SickleSwingProfile, 
			VibrationMaterial.SickleCut => SickleCutProfile, 
			_ => PickProfile, 
		};
	}

	public string MDMIEDHALEG(ControllerInfo AKKFEAFGBCH)
	{
		List<ControllerInfo> list = new List<ControllerInfo>(ControllersInfo);
		list.Add(AKKFEAFGBCH);
		ControllersInfo = list.ToArray();
		return AKKFEAFGBCH.nameID;
	}

	public string CBKOILDFFHM(ControllerInfo AKKFEAFGBCH)
	{
		List<ControllerInfo> list = new List<ControllerInfo>(ControllersInfo);
		list.Add(AKKFEAFGBCH);
		ControllersInfo = list.ToArray();
		return AKKFEAFGBCH.nameID;
	}
}
