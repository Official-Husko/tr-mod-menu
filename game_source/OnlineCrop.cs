using UnityEngine;

public class OnlineCrop : OnlineObject
{
	private enum JDBLOKANBMI
	{
		Harvest
	}

	public CropSetter cropSetter;

	public static void FGNJOJGOANE(Vector2 IMOBLFMHKOD, int MNBNGGHHMBB, int BEIPALOAAJJ)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager.instance.SendPlantCrop(IMOBLFMHKOD, MNBNGGHHMBB, BEIPALOAAJJ);
	}

	public static void EDALKCEAFFB(Vector2 IMOBLFMHKOD, int MNBNGGHHMBB, int BEIPALOAAJJ)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager.instance.SendPlantCrop(IMOBLFMHKOD, MNBNGGHHMBB, BEIPALOAAJJ);
	}

	private void KACEOJDPLKB()
	{
		if (OnlineManager.PlayingOnline() && !((Object)(object)cropSetter == (Object)null) && uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
		}
	}

	public override void ReceiveAction(byte FACPEEACCMH)
	{
		if (FACPEEACCMH == 0)
		{
			cropSetter.harvestable.Harvest(1, CDPAMNIPPEC: false);
		}
	}

	public static void EDHIDEBBCBM(Vector2 IMOBLFMHKOD, int MNBNGGHHMBB, int BEIPALOAAJJ)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager.instance.SendPlantCrop(IMOBLFMHKOD, MNBNGGHHMBB, BEIPALOAAJJ);
	}

	public void NPGKOJBFBJP()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void LIGIHMCMLAE()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void EMKKDOFCELB()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public static void GHBLPHFOLGA(Vector2 IMOBLFMHKOD, int MNBNGGHHMBB, int BEIPALOAAJJ)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager.instance.SendPlantCrop(IMOBLFMHKOD, MNBNGGHHMBB, BEIPALOAAJJ);
	}

	private void GNGADDPBJDC()
	{
		if (OnlineManager.PlayingOnline() && !((Object)(object)cropSetter == (Object)null) && uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
		}
	}

	private void HCEDMLJNOBL()
	{
		if (OnlineManager.PlayingOnline() && !((Object)(object)cropSetter == (Object)null) && uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
		}
	}

	public void IKACPOGJPFC()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	private void Start()
	{
		if (OnlineManager.PlayingOnline() && !((Object)(object)cropSetter == (Object)null) && uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
		}
	}

	public static void Plant(Vector2 IMOBLFMHKOD, int MNBNGGHHMBB, int BEIPALOAAJJ)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager.instance.SendPlantCrop(IMOBLFMHKOD, MNBNGGHHMBB, BEIPALOAAJJ);
	}

	public static void NFAPMDEINEL(Vector2 IMOBLFMHKOD, int MNBNGGHHMBB, int BEIPALOAAJJ)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager.instance.SendPlantCrop(IMOBLFMHKOD, MNBNGGHHMBB, BEIPALOAAJJ);
	}

	public static void JHPJJCMHKAE(Vector2 IMOBLFMHKOD, int MNBNGGHHMBB, int BEIPALOAAJJ)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager.instance.SendPlantCrop(IMOBLFMHKOD, MNBNGGHHMBB, BEIPALOAAJJ);
	}

	private void CAIJLMJBMLA()
	{
		if (OnlineManager.PlayingOnline() && !((Object)(object)cropSetter == (Object)null) && uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
		}
	}

	public void Harvest()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void NLMBIEHMEDI()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public override void ObjectConfiguration()
	{
		base.ObjectConfiguration();
		Debug.Log((object)("Get Components " + ((Object)((Component)this).gameObject).name));
		cropSetter = ((Component)this).GetComponent<CropSetter>();
		cropSetter.onlineObject = this;
	}

	public void OMCDEOEKKMH()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void MBGLEHAOOJA()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	private void HJDLNCOAKIK()
	{
		if (OnlineManager.PlayingOnline() && !((Object)(object)cropSetter == (Object)null) && uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
		}
	}

	public static void AEMGMBEGGBI(Vector2 IMOBLFMHKOD, int MNBNGGHHMBB, int BEIPALOAAJJ)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager.instance.SendPlantCrop(IMOBLFMHKOD, MNBNGGHHMBB, BEIPALOAAJJ);
	}

	private void PKBHEKHOAAA()
	{
		if (OnlineManager.PlayingOnline() && !((Object)(object)cropSetter == (Object)null) && uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
		}
	}

	public void DEELDIABAIJ()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void NHEEPBACFGC()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	private void BELOIFKPNMM()
	{
		if (OnlineManager.PlayingOnline() && !((Object)(object)cropSetter == (Object)null) && uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
		}
	}

	public static void GBGFIKENLJI(Vector2 IMOBLFMHKOD, int MNBNGGHHMBB, int BEIPALOAAJJ)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager.instance.SendPlantCrop(IMOBLFMHKOD, MNBNGGHHMBB, BEIPALOAAJJ);
	}

	public static void IIEFHCCOLMK(Vector2 IMOBLFMHKOD, int MNBNGGHHMBB, int BEIPALOAAJJ)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager.instance.SendPlantCrop(IMOBLFMHKOD, MNBNGGHHMBB, BEIPALOAAJJ);
	}

	public static void IDFOBKKDNDD(Vector2 IMOBLFMHKOD, int MNBNGGHHMBB, int BEIPALOAAJJ)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager.instance.SendPlantCrop(IMOBLFMHKOD, MNBNGGHHMBB, BEIPALOAAJJ);
	}

	public void DICADAHODHD()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void NDBHJOJEBOD()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void MEBOPGKFIII()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public static void HNGNGPNEOBO(Vector2 IMOBLFMHKOD, int MNBNGGHHMBB, int BEIPALOAAJJ)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager.instance.SendPlantCrop(IMOBLFMHKOD, MNBNGGHHMBB, BEIPALOAAJJ);
	}

	public void JHNJKGIFGOH()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public static void ICLGEMDBBDK(Vector2 IMOBLFMHKOD, int MNBNGGHHMBB, int BEIPALOAAJJ)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager.instance.SendPlantCrop(IMOBLFMHKOD, MNBNGGHHMBB, BEIPALOAAJJ);
	}

	private void BNIKICAEIND()
	{
		if (OnlineManager.PlayingOnline() && !((Object)(object)cropSetter == (Object)null) && uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
		}
	}

	public void KEGKOHHAPHE()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public static void JEMPEMGEBAE(Vector2 IMOBLFMHKOD, int MNBNGGHHMBB, int BEIPALOAAJJ)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager.instance.SendPlantCrop(IMOBLFMHKOD, MNBNGGHHMBB, BEIPALOAAJJ);
	}
}
