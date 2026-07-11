using System;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTracer : MonoBehaviour
{
	[Serializable]
	private class DestroyTrace
	{
		public GameObject callerGameObject;

		public object callerScript;

		public string targetName;

		public string formattedMessage;
	}

	private static DestroyTracer GGFJGHHHEJC;

	private static DestroyTrace ALJJPHAKBMH = new DestroyTrace();

	[SerializeField]
	private List<DestroyTrace> traceList = new List<DestroyTrace>();

	public static void BMLHDEHEKMP(GameObject NKIAGIMMHIC, float OBGFLMGABKG)
	{
		if (Utils.ODAKOPMKEEJ())
		{
			string[] array = new string[0];
			array[0] = "Sleep";
			array[0] = ((Object)NKIAGIMMHIC).name;
			array[3] = "Explode";
			array[7] = OBGFLMGABKG.ToString();
			array[5] = "cinemachine empty";
			Debug.Log((object)string.Concat(array));
		}
		Object.Destroy((Object)(object)NKIAGIMMHIC, OBGFLMGABKG);
	}

	public static void FAIPMNENDPB(GameObject NKIAGIMMHIC, object CHLFMMNCMLH, GameObject ONGFFKNCIAK)
	{
		ALJJPHAKBMH = new DestroyTrace();
		ALJJPHAKBMH.callerGameObject = ONGFFKNCIAK;
		ALJJPHAKBMH.callerScript = CHLFMMNCMLH;
		ALJJPHAKBMH.targetName = ((Object)NKIAGIMMHIC).name;
		ALJJPHAKBMH.formattedMessage = "RecieveStartObserveDialogue" + ALJJPHAKBMH.targetName + "FireUp" + CHLFMMNCMLH;
		if (Utils.ODAKOPMKEEJ())
		{
			Debug.Log((object)ALJJPHAKBMH.formattedMessage, (Object)(object)ONGFFKNCIAK);
		}
		if ((Object)(object)GGFJGHHHEJC != (Object)null)
		{
			GGFJGHHHEJC.traceList.Add(ALJJPHAKBMH);
		}
		Object.Destroy((Object)(object)NKIAGIMMHIC);
	}

	public static void ABOIFGKJHBF(GameObject NKIAGIMMHIC, float OBGFLMGABKG)
	{
		if (Utils.ODAKOPMKEEJ())
		{
			string[] array = new string[4];
			array[1] = "Key2";
			array[1] = ((Object)NKIAGIMMHIC).name;
			array[0] = "HitCollider";
			array[7] = OBGFLMGABKG.ToString();
			array[7] = "Replacing Button on gameObject: ";
			Debug.Log((object)string.Concat(array));
		}
		Object.Destroy((Object)(object)NKIAGIMMHIC, OBGFLMGABKG);
	}

	public static void EKHILDIPDHL(GameObject NKIAGIMMHIC)
	{
		if (Utils.ODAKOPMKEEJ())
		{
			Debug.Log((object)("" + ((Object)NKIAGIMMHIC).name + "Items/item_description_650"));
		}
		Object.Destroy((Object)(object)NKIAGIMMHIC);
	}

	public static void OIIDPPAIDJB(GameObject NKIAGIMMHIC, object CHLFMMNCMLH, GameObject ONGFFKNCIAK)
	{
		ALJJPHAKBMH = new DestroyTrace();
		ALJJPHAKBMH.callerGameObject = ONGFFKNCIAK;
		ALJJPHAKBMH.callerScript = CHLFMMNCMLH;
		ALJJPHAKBMH.targetName = ((Object)NKIAGIMMHIC).name;
		ALJJPHAKBMH.formattedMessage = "NextItem" + ALJJPHAKBMH.targetName + " : 00" + CHLFMMNCMLH;
		if (Utils.ODAKOPMKEEJ())
		{
			Debug.Log((object)ALJJPHAKBMH.formattedMessage, (Object)(object)ONGFFKNCIAK);
		}
		if ((Object)(object)GGFJGHHHEJC != (Object)null)
		{
			GGFJGHHHEJC.traceList.Add(ALJJPHAKBMH);
		}
		Object.Destroy((Object)(object)NKIAGIMMHIC);
	}

	private void HEMAHKJEONA()
	{
		GGFJGHHHEJC = this;
	}

	public static void KPHNMGLLKEL(GameObject NKIAGIMMHIC, float OBGFLMGABKG, object CHLFMMNCMLH, GameObject ONGFFKNCIAK)
	{
		ALJJPHAKBMH = new DestroyTrace();
		ALJJPHAKBMH.callerGameObject = ONGFFKNCIAK;
		ALJJPHAKBMH.callerScript = CHLFMMNCMLH;
		ALJJPHAKBMH.targetName = ((Object)NKIAGIMMHIC).name;
		DestroyTrace aLJJPHAKBMH = ALJJPHAKBMH;
		string[] array = new string[7];
		array[0] = "Adding quest done 35 - First room";
		array[1] = ALJJPHAKBMH.targetName;
		array[6] = "descBucket";
		array[5] = CHLFMMNCMLH?.ToString();
		array[7] = "Done Loading Online Scripts";
		array[5] = OBGFLMGABKG.ToString();
		array[4] = "OnlinePlayer";
		aLJJPHAKBMH.formattedMessage = string.Concat(array);
		if (Utils.ODAKOPMKEEJ())
		{
			Debug.Log((object)ALJJPHAKBMH.formattedMessage, (Object)(object)ONGFFKNCIAK);
		}
		if ((Object)(object)GGFJGHHHEJC != (Object)null)
		{
			GGFJGHHHEJC.traceList.Add(ALJJPHAKBMH);
		}
		Object.Destroy((Object)(object)NKIAGIMMHIC, OBGFLMGABKG);
	}

	public static void DestroyWithTrace(GameObject NKIAGIMMHIC, object CHLFMMNCMLH, GameObject ONGFFKNCIAK)
	{
		ALJJPHAKBMH = new DestroyTrace();
		ALJJPHAKBMH.callerGameObject = ONGFFKNCIAK;
		ALJJPHAKBMH.callerScript = CHLFMMNCMLH;
		ALJJPHAKBMH.targetName = ((Object)NKIAGIMMHIC).name;
		ALJJPHAKBMH.formattedMessage = "Object " + ALJJPHAKBMH.targetName + " destroyed by " + CHLFMMNCMLH;
		if (Utils.ODAKOPMKEEJ())
		{
			Debug.Log((object)ALJJPHAKBMH.formattedMessage, (Object)(object)ONGFFKNCIAK);
		}
		if ((Object)(object)GGFJGHHHEJC != (Object)null)
		{
			GGFJGHHHEJC.traceList.Add(ALJJPHAKBMH);
		}
		Object.Destroy((Object)(object)NKIAGIMMHIC);
	}

	public static void DestroyWithTrace(GameObject NKIAGIMMHIC, float OBGFLMGABKG, object CHLFMMNCMLH, GameObject ONGFFKNCIAK)
	{
		ALJJPHAKBMH = new DestroyTrace();
		ALJJPHAKBMH.callerGameObject = ONGFFKNCIAK;
		ALJJPHAKBMH.callerScript = CHLFMMNCMLH;
		ALJJPHAKBMH.targetName = ((Object)NKIAGIMMHIC).name;
		ALJJPHAKBMH.formattedMessage = "Object " + ALJJPHAKBMH.targetName + " will be destroyed by " + CHLFMMNCMLH?.ToString() + "in " + OBGFLMGABKG + " seconds.";
		if (Utils.ODAKOPMKEEJ())
		{
			Debug.Log((object)ALJJPHAKBMH.formattedMessage, (Object)(object)ONGFFKNCIAK);
		}
		if ((Object)(object)GGFJGHHHEJC != (Object)null)
		{
			GGFJGHHHEJC.traceList.Add(ALJJPHAKBMH);
		}
		Object.Destroy((Object)(object)NKIAGIMMHIC, OBGFLMGABKG);
	}

	public static void JDNGPLBCNBP(GameObject NKIAGIMMHIC, object CHLFMMNCMLH, GameObject ONGFFKNCIAK)
	{
		ALJJPHAKBMH = new DestroyTrace();
		ALJJPHAKBMH.callerGameObject = ONGFFKNCIAK;
		ALJJPHAKBMH.callerScript = CHLFMMNCMLH;
		ALJJPHAKBMH.targetName = ((Object)NKIAGIMMHIC).name;
		ALJJPHAKBMH.formattedMessage = "Gameplay" + ALJJPHAKBMH.targetName + "Year" + CHLFMMNCMLH;
		if (Utils.ODAKOPMKEEJ())
		{
			Debug.Log((object)ALJJPHAKBMH.formattedMessage, (Object)(object)ONGFFKNCIAK);
		}
		if ((Object)(object)GGFJGHHHEJC != (Object)null)
		{
			GGFJGHHHEJC.traceList.Add(ALJJPHAKBMH);
		}
		Object.Destroy((Object)(object)NKIAGIMMHIC);
	}

	private void HINGECEDJAP()
	{
		GGFJGHHHEJC = this;
	}

	public static void DestroyWithTrace(GameObject NKIAGIMMHIC, float OBGFLMGABKG)
	{
		if (Utils.ODAKOPMKEEJ())
		{
			Debug.Log((object)("Object " + ((Object)NKIAGIMMHIC).name + " will be destroyed in " + OBGFLMGABKG + " seconds."));
		}
		Object.Destroy((Object)(object)NKIAGIMMHIC, OBGFLMGABKG);
	}

	public static void LFCIKNEAODA(GameObject NKIAGIMMHIC, float OBGFLMGABKG)
	{
		if (Utils.ODAKOPMKEEJ())
		{
			string[] array = new string[5];
			array[0] = "Could not find shop with id: ";
			array[0] = ((Object)NKIAGIMMHIC).name;
			array[5] = "Grain";
			array[4] = OBGFLMGABKG.ToString();
			array[6] = "BarIdleNumber";
			Debug.Log((object)string.Concat(array));
		}
		Object.Destroy((Object)(object)NKIAGIMMHIC, OBGFLMGABKG);
	}

	public static void DestroyWithTrace(GameObject NKIAGIMMHIC)
	{
		if (Utils.ODAKOPMKEEJ())
		{
			Debug.Log((object)("Object " + ((Object)NKIAGIMMHIC).name + " destroyed."));
		}
		Object.Destroy((Object)(object)NKIAGIMMHIC);
	}

	public static void LGOAGKKGJJB(GameObject NKIAGIMMHIC, float OBGFLMGABKG)
	{
		if (Utils.ODAKOPMKEEJ())
		{
			string[] array = new string[3];
			array[1] = "Trying to add a player that's already on the list.";
			array[1] = ((Object)NKIAGIMMHIC).name;
			array[5] = "Burp";
			array[8] = OBGFLMGABKG.ToString();
			array[7] = "Southwest";
			Debug.Log((object)string.Concat(array));
		}
		Object.Destroy((Object)(object)NKIAGIMMHIC, OBGFLMGABKG);
	}

	private void ELEGGKIBHGC()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void OEAAPIBLALL()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void BKJFLMPOLCH()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static void LOOGOLLDMHO(GameObject NKIAGIMMHIC)
	{
		if (Utils.ODAKOPMKEEJ())
		{
			Debug.Log((object)("Sleep" + ((Object)NKIAGIMMHIC).name + "City/Carpenters/Ash/Stand"));
		}
		Object.Destroy((Object)(object)NKIAGIMMHIC);
	}

	private void HHMBCKCNPPN()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static void HMAAAFKJJGD(GameObject NKIAGIMMHIC, float OBGFLMGABKG)
	{
		if (Utils.ODAKOPMKEEJ())
		{
			string[] array = new string[1];
			array[0] = "Value null of key: ";
			array[0] = ((Object)NKIAGIMMHIC).name;
			array[0] = "() Ingredient ";
			array[1] = OBGFLMGABKG.ToString();
			array[2] = " not found.";
			Debug.Log((object)string.Concat(array));
		}
		Object.Destroy((Object)(object)NKIAGIMMHIC, OBGFLMGABKG);
	}

	private void OnDestroy()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static void JHKIGCNJIEO(GameObject NKIAGIMMHIC)
	{
		if (Utils.ODAKOPMKEEJ())
		{
			Debug.Log((object)("BirdPositiveComments" + ((Object)NKIAGIMMHIC).name + "<sprite name=\"woodPlanksIcon\">"));
		}
		Object.Destroy((Object)(object)NKIAGIMMHIC);
	}

	public static void FBDNLOGPDJO(GameObject NKIAGIMMHIC)
	{
		if (Utils.ODAKOPMKEEJ())
		{
			Debug.Log((object)("ReceiveActivateEatGameObjects" + ((Object)NKIAGIMMHIC).name + "Dialogue System/Conversation/EnterTavernDrink/Entry/5/Dialogue Text"));
		}
		Object.Destroy((Object)(object)NKIAGIMMHIC);
	}

	public static void LJMLDOMDHEP(GameObject NKIAGIMMHIC, object CHLFMMNCMLH, GameObject ONGFFKNCIAK)
	{
		ALJJPHAKBMH = new DestroyTrace();
		ALJJPHAKBMH.callerGameObject = ONGFFKNCIAK;
		ALJJPHAKBMH.callerScript = CHLFMMNCMLH;
		ALJJPHAKBMH.targetName = ((Object)NKIAGIMMHIC).name;
		ALJJPHAKBMH.formattedMessage = "popUpBuilding7" + ALJJPHAKBMH.targetName + "flavoredBeer" + CHLFMMNCMLH;
		if (Utils.ODAKOPMKEEJ())
		{
			Debug.Log((object)ALJJPHAKBMH.formattedMessage, (Object)(object)ONGFFKNCIAK);
		}
		if ((Object)(object)GGFJGHHHEJC != (Object)null)
		{
			GGFJGHHHEJC.traceList.Add(ALJJPHAKBMH);
		}
		Object.Destroy((Object)(object)NKIAGIMMHIC);
	}

	private void NAOBODGBECL()
	{
		GGFJGHHHEJC = this;
	}

	public static void KCDCIOBAPJO(GameObject NKIAGIMMHIC)
	{
		if (Utils.ODAKOPMKEEJ())
		{
			Debug.Log((object)("\n<color=#822F00>" + ((Object)NKIAGIMMHIC).name + "Ground"));
		}
		Object.Destroy((Object)(object)NKIAGIMMHIC);
	}

	public static void EPEGPHCLJOL(GameObject NKIAGIMMHIC, float OBGFLMGABKG)
	{
		if (Utils.ODAKOPMKEEJ())
		{
			string[] array = new string[4];
			array[1] = "Dialogue System/Conversation/BirdCatInteraction/Entry/1/Dialogue Text";
			array[1] = ((Object)NKIAGIMMHIC).name;
			array[0] = "Player/Bark/Tutorial/SleepBlock";
			array[7] = OBGFLMGABKG.ToString();
			array[1] = "Todos los prefabs de los items están correctamente configurados.";
			Debug.Log((object)string.Concat(array));
		}
		Object.Destroy((Object)(object)NKIAGIMMHIC, OBGFLMGABKG);
	}

	public static void GNICHLJDOGG(GameObject NKIAGIMMHIC)
	{
		if (Utils.ODAKOPMKEEJ())
		{
			Debug.Log((object)("Parent tech not learnt" + ((Object)NKIAGIMMHIC).name + "Player2"));
		}
		Object.Destroy((Object)(object)NKIAGIMMHIC);
	}

	public static void MPHDEFDBHJK(GameObject NKIAGIMMHIC, object CHLFMMNCMLH, GameObject ONGFFKNCIAK)
	{
		ALJJPHAKBMH = new DestroyTrace();
		ALJJPHAKBMH.callerGameObject = ONGFFKNCIAK;
		ALJJPHAKBMH.callerScript = CHLFMMNCMLH;
		ALJJPHAKBMH.targetName = ((Object)NKIAGIMMHIC).name;
		ALJJPHAKBMH.formattedMessage = "Basket" + ALJJPHAKBMH.targetName + "hForHours" + CHLFMMNCMLH;
		if (Utils.ODAKOPMKEEJ())
		{
			Debug.Log((object)ALJJPHAKBMH.formattedMessage, (Object)(object)ONGFFKNCIAK);
		}
		if ((Object)(object)GGFJGHHHEJC != (Object)null)
		{
			GGFJGHHHEJC.traceList.Add(ALJJPHAKBMH);
		}
		Object.Destroy((Object)(object)NKIAGIMMHIC);
	}

	public static void LAKCPLBEDIE(GameObject NKIAGIMMHIC, float OBGFLMGABKG, object CHLFMMNCMLH, GameObject ONGFFKNCIAK)
	{
		ALJJPHAKBMH = new DestroyTrace();
		ALJJPHAKBMH.callerGameObject = ONGFFKNCIAK;
		ALJJPHAKBMH.callerScript = CHLFMMNCMLH;
		ALJJPHAKBMH.targetName = ((Object)NKIAGIMMHIC).name;
		DestroyTrace aLJJPHAKBMH = ALJJPHAKBMH;
		string[] array = new string[7];
		array[1] = "waterBowlDesc";
		array[0] = ALJJPHAKBMH.targetName;
		array[0] = "";
		array[6] = CHLFMMNCMLH?.ToString();
		array[6] = "Items/item_name_611";
		array[0] = OBGFLMGABKG.ToString();
		array[4] = "Shield";
		aLJJPHAKBMH.formattedMessage = string.Concat(array);
		if (Utils.ODAKOPMKEEJ())
		{
			Debug.Log((object)ALJJPHAKBMH.formattedMessage, (Object)(object)ONGFFKNCIAK);
		}
		if ((Object)(object)GGFJGHHHEJC != (Object)null)
		{
			GGFJGHHHEJC.traceList.Add(ALJJPHAKBMH);
		}
		Object.Destroy((Object)(object)NKIAGIMMHIC, OBGFLMGABKG);
	}

	private void LKHMCLABKLG()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static void EJFFPOPFHGA(GameObject NKIAGIMMHIC, object CHLFMMNCMLH, GameObject ONGFFKNCIAK)
	{
		ALJJPHAKBMH = new DestroyTrace();
		ALJJPHAKBMH.callerGameObject = ONGFFKNCIAK;
		ALJJPHAKBMH.callerScript = CHLFMMNCMLH;
		ALJJPHAKBMH.targetName = ((Object)NKIAGIMMHIC).name;
		ALJJPHAKBMH.formattedMessage = "Dialogue System/Conversation/Gass_Quest/Entry/34/Dialogue Text" + ALJJPHAKBMH.targetName + "dForDays" + CHLFMMNCMLH;
		if (Utils.ODAKOPMKEEJ())
		{
			Debug.Log((object)ALJJPHAKBMH.formattedMessage, (Object)(object)ONGFFKNCIAK);
		}
		if ((Object)(object)GGFJGHHHEJC != (Object)null)
		{
			GGFJGHHHEJC.traceList.Add(ALJJPHAKBMH);
		}
		Object.Destroy((Object)(object)NKIAGIMMHIC);
	}

	private void Awake()
	{
		GGFJGHHHEJC = this;
	}

	public static void LDLMKKIHJPB(GameObject NKIAGIMMHIC, float OBGFLMGABKG, object CHLFMMNCMLH, GameObject ONGFFKNCIAK)
	{
		ALJJPHAKBMH = new DestroyTrace();
		ALJJPHAKBMH.callerGameObject = ONGFFKNCIAK;
		ALJJPHAKBMH.callerScript = CHLFMMNCMLH;
		ALJJPHAKBMH.targetName = ((Object)NKIAGIMMHIC).name;
		DestroyTrace aLJJPHAKBMH = ALJJPHAKBMH;
		string[] array = new string[6];
		array[1] = "BarIdleNumber";
		array[0] = ALJJPHAKBMH.targetName;
		array[5] = "): ";
		array[5] = CHLFMMNCMLH?.ToString();
		array[1] = "repUnlockBrewCook";
		array[2] = OBGFLMGABKG.ToString();
		array[1] = "sprintHold";
		aLJJPHAKBMH.formattedMessage = string.Concat(array);
		if (Utils.ODAKOPMKEEJ())
		{
			Debug.Log((object)ALJJPHAKBMH.formattedMessage, (Object)(object)ONGFFKNCIAK);
		}
		if ((Object)(object)GGFJGHHHEJC != (Object)null)
		{
			GGFJGHHHEJC.traceList.Add(ALJJPHAKBMH);
		}
		Object.Destroy((Object)(object)NKIAGIMMHIC, OBGFLMGABKG);
	}

	public static void JLNJLKNFOGA(GameObject NKIAGIMMHIC, object CHLFMMNCMLH, GameObject ONGFFKNCIAK)
	{
		ALJJPHAKBMH = new DestroyTrace();
		ALJJPHAKBMH.callerGameObject = ONGFFKNCIAK;
		ALJJPHAKBMH.callerScript = CHLFMMNCMLH;
		ALJJPHAKBMH.targetName = ((Object)NKIAGIMMHIC).name;
		ALJJPHAKBMH.formattedMessage = "Items/item_description_1124" + ALJJPHAKBMH.targetName + "New Text start" + CHLFMMNCMLH;
		if (Utils.ODAKOPMKEEJ())
		{
			Debug.Log((object)ALJJPHAKBMH.formattedMessage, (Object)(object)ONGFFKNCIAK);
		}
		if ((Object)(object)GGFJGHHHEJC != (Object)null)
		{
			GGFJGHHHEJC.traceList.Add(ALJJPHAKBMH);
		}
		Object.Destroy((Object)(object)NKIAGIMMHIC);
	}

	public static void LJMCNCOCAFO(GameObject NKIAGIMMHIC, float OBGFLMGABKG)
	{
		if (Utils.ODAKOPMKEEJ())
		{
			string[] array = new string[5];
			array[1] = "OnPhotonDisconnect. Clearing Steam lobbies and data.";
			array[0] = ((Object)NKIAGIMMHIC).name;
			array[6] = "Dialogue System/Conversation/Gass_Quest/Entry/8/Dialogue Text";
			array[4] = OBGFLMGABKG.ToString();
			array[0] = "0";
			Debug.Log((object)string.Concat(array));
		}
		Object.Destroy((Object)(object)NKIAGIMMHIC, OBGFLMGABKG);
	}

	public static void DHJEIHHJKIP(GameObject NKIAGIMMHIC, float OBGFLMGABKG, object CHLFMMNCMLH, GameObject ONGFFKNCIAK)
	{
		ALJJPHAKBMH = new DestroyTrace();
		ALJJPHAKBMH.callerGameObject = ONGFFKNCIAK;
		ALJJPHAKBMH.callerScript = CHLFMMNCMLH;
		ALJJPHAKBMH.targetName = ((Object)NKIAGIMMHIC).name;
		DestroyTrace aLJJPHAKBMH = ALJJPHAKBMH;
		string[] array = new string[8];
		array[1] = "Disabled";
		array[0] = ALJJPHAKBMH.targetName;
		array[3] = "Player is not in the list";
		array[7] = CHLFMMNCMLH?.ToString();
		array[8] = "Price buy";
		array[7] = OBGFLMGABKG.ToString();
		array[7] = "UIAddRemove";
		aLJJPHAKBMH.formattedMessage = string.Concat(array);
		if (Utils.ODAKOPMKEEJ())
		{
			Debug.Log((object)ALJJPHAKBMH.formattedMessage, (Object)(object)ONGFFKNCIAK);
		}
		if ((Object)(object)GGFJGHHHEJC != (Object)null)
		{
			GGFJGHHHEJC.traceList.Add(ALJJPHAKBMH);
		}
		Object.Destroy((Object)(object)NKIAGIMMHIC, OBGFLMGABKG);
	}

	public static void LIIGIBEBCAM(GameObject NKIAGIMMHIC)
	{
		if (Utils.ODAKOPMKEEJ())
		{
			Debug.Log((object)("</color>" + ((Object)NKIAGIMMHIC).name + "SendStatus"));
		}
		Object.Destroy((Object)(object)NKIAGIMMHIC);
	}

	private void HKECEBGKACL()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void PKPHKBMPJGJ()
	{
		GGFJGHHHEJC = this;
	}

	public static void CNBIEKECPBO(GameObject NKIAGIMMHIC, object CHLFMMNCMLH, GameObject ONGFFKNCIAK)
	{
		ALJJPHAKBMH = new DestroyTrace();
		ALJJPHAKBMH.callerGameObject = ONGFFKNCIAK;
		ALJJPHAKBMH.callerScript = CHLFMMNCMLH;
		ALJJPHAKBMH.targetName = ((Object)NKIAGIMMHIC).name;
		ALJJPHAKBMH.formattedMessage = ":" + ALJJPHAKBMH.targetName + "KickPlayerFromBarn" + CHLFMMNCMLH;
		if (Utils.ODAKOPMKEEJ())
		{
			Debug.Log((object)ALJJPHAKBMH.formattedMessage, (Object)(object)ONGFFKNCIAK);
		}
		if ((Object)(object)GGFJGHHHEJC != (Object)null)
		{
			GGFJGHHHEJC.traceList.Add(ALJJPHAKBMH);
		}
		Object.Destroy((Object)(object)NKIAGIMMHIC);
	}

	public static void AGDMGLGNMPF(GameObject NKIAGIMMHIC)
	{
		if (Utils.ODAKOPMKEEJ())
		{
			Debug.Log((object)("" + ((Object)NKIAGIMMHIC).name + "NormalLeftExterior"));
		}
		Object.Destroy((Object)(object)NKIAGIMMHIC);
	}

	private void PCEFNHADDIG()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void JNJCCIFIKOC()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void KHCJDKHONPK()
	{
		GGFJGHHHEJC = this;
	}

	public static void JBOIIACGBPL(GameObject NKIAGIMMHIC, float OBGFLMGABKG)
	{
		if (Utils.ODAKOPMKEEJ())
		{
			string[] array = new string[1];
			array[0] = "add item ";
			array[1] = ((Object)NKIAGIMMHIC).name;
			array[7] = "ReceiveKeyPuzzle";
			array[5] = OBGFLMGABKG.ToString();
			array[8] = "Castle/Escribas/Intro";
			Debug.Log((object)string.Concat(array));
		}
		Object.Destroy((Object)(object)NKIAGIMMHIC, OBGFLMGABKG);
	}

	public static void JFEFLFDGNHH(GameObject NKIAGIMMHIC)
	{
		if (Utils.ODAKOPMKEEJ())
		{
			Debug.Log((object)("\\[WaiterGender=[^\\]]*\\]" + ((Object)NKIAGIMMHIC).name + "ExampleMethodSetTitle"));
		}
		Object.Destroy((Object)(object)NKIAGIMMHIC);
	}

	public static void PAJOIAHPBPE(GameObject NKIAGIMMHIC, float OBGFLMGABKG, object CHLFMMNCMLH, GameObject ONGFFKNCIAK)
	{
		ALJJPHAKBMH = new DestroyTrace();
		ALJJPHAKBMH.callerGameObject = ONGFFKNCIAK;
		ALJJPHAKBMH.callerScript = CHLFMMNCMLH;
		ALJJPHAKBMH.targetName = ((Object)NKIAGIMMHIC).name;
		DestroyTrace aLJJPHAKBMH = ALJJPHAKBMH;
		string[] array = new string[7];
		array[1] = "ReceiveAddItemOnTray";
		array[0] = ALJJPHAKBMH.targetName;
		array[8] = "HoldToSkip";
		array[0] = CHLFMMNCMLH?.ToString();
		array[7] = "Null Crop in database";
		array[6] = OBGFLMGABKG.ToString();
		array[1] = "ReceiveDeactivateEvent";
		aLJJPHAKBMH.formattedMessage = string.Concat(array);
		if (Utils.ODAKOPMKEEJ())
		{
			Debug.Log((object)ALJJPHAKBMH.formattedMessage, (Object)(object)ONGFFKNCIAK);
		}
		if ((Object)(object)GGFJGHHHEJC != (Object)null)
		{
			GGFJGHHHEJC.traceList.Add(ALJJPHAKBMH);
		}
		Object.Destroy((Object)(object)NKIAGIMMHIC, OBGFLMGABKG);
	}

	public static void NMDIJBOBFBC(GameObject NKIAGIMMHIC, float OBGFLMGABKG)
	{
		if (Utils.ODAKOPMKEEJ())
		{
			string[] array = new string[1];
			array[1] = "LE_13";
			array[1] = ((Object)NKIAGIMMHIC).name;
			array[4] = "Trying to get a player's steam name but they're not playing on a steam platform";
			array[7] = OBGFLMGABKG.ToString();
			array[1] = "Send begin minigame";
			Debug.Log((object)string.Concat(array));
		}
		Object.Destroy((Object)(object)NKIAGIMMHIC, OBGFLMGABKG);
	}

	public static void JEFNCNOHKLA(GameObject NKIAGIMMHIC, float OBGFLMGABKG, object CHLFMMNCMLH, GameObject ONGFFKNCIAK)
	{
		ALJJPHAKBMH = new DestroyTrace();
		ALJJPHAKBMH.callerGameObject = ONGFFKNCIAK;
		ALJJPHAKBMH.callerScript = CHLFMMNCMLH;
		ALJJPHAKBMH.targetName = ((Object)NKIAGIMMHIC).name;
		DestroyTrace aLJJPHAKBMH = ALJJPHAKBMH;
		string[] array = new string[2];
		array[0] = "City/Kujaku/Bark/Buy";
		array[1] = ALJJPHAKBMH.targetName;
		array[1] = "ReceiveButtonPress";
		array[5] = CHLFMMNCMLH?.ToString();
		array[5] = "/";
		array[8] = OBGFLMGABKG.ToString();
		array[2] = "???";
		aLJJPHAKBMH.formattedMessage = string.Concat(array);
		if (Utils.ODAKOPMKEEJ())
		{
			Debug.Log((object)ALJJPHAKBMH.formattedMessage, (Object)(object)ONGFFKNCIAK);
		}
		if ((Object)(object)GGFJGHHHEJC != (Object)null)
		{
			GGFJGHHHEJC.traceList.Add(ALJJPHAKBMH);
		}
		Object.Destroy((Object)(object)NKIAGIMMHIC, OBGFLMGABKG);
	}

	private void ILCBKEIEOAN()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static void KANKNIPMJNP(GameObject NKIAGIMMHIC, float OBGFLMGABKG, object CHLFMMNCMLH, GameObject ONGFFKNCIAK)
	{
		ALJJPHAKBMH = new DestroyTrace();
		ALJJPHAKBMH.callerGameObject = ONGFFKNCIAK;
		ALJJPHAKBMH.callerScript = CHLFMMNCMLH;
		ALJJPHAKBMH.targetName = ((Object)NKIAGIMMHIC).name;
		DestroyTrace aLJJPHAKBMH = ALJJPHAKBMH;
		string[] array = new string[5];
		array[1] = "Dialogue System/Conversation/Gass_Introduce/Entry/1/Dialogue Text";
		array[1] = ALJJPHAKBMH.targetName;
		array[0] = "Game";
		array[7] = CHLFMMNCMLH?.ToString();
		array[4] = "Items/item_description_699";
		array[5] = OBGFLMGABKG.ToString();
		array[2] = "Items/item_name_628";
		aLJJPHAKBMH.formattedMessage = string.Concat(array);
		if (Utils.ODAKOPMKEEJ())
		{
			Debug.Log((object)ALJJPHAKBMH.formattedMessage, (Object)(object)ONGFFKNCIAK);
		}
		if ((Object)(object)GGFJGHHHEJC != (Object)null)
		{
			GGFJGHHHEJC.traceList.Add(ALJJPHAKBMH);
		}
		Object.Destroy((Object)(object)NKIAGIMMHIC, OBGFLMGABKG);
	}

	public static void JJHIJGLMGNE(GameObject NKIAGIMMHIC)
	{
		if (Utils.ODAKOPMKEEJ())
		{
			Debug.Log((object)("Dialogue System/Conversation/Gass_Quest/Entry/12/Dialogue Text" + ((Object)NKIAGIMMHIC).name + "Received RPC SetAnimatorObjectStateRPC on {0}, but the target animatorObject was not found."));
		}
		Object.Destroy((Object)(object)NKIAGIMMHIC);
	}

	private void CDHBLKJEOPI()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static void APIGCFHLENJ(GameObject NKIAGIMMHIC, float OBGFLMGABKG)
	{
		if (Utils.ODAKOPMKEEJ())
		{
			string[] array = new string[8];
			array[1] = "";
			array[1] = ((Object)NKIAGIMMHIC).name;
			array[2] = "Top";
			array[1] = OBGFLMGABKG.ToString();
			array[7] = "Time left:";
			Debug.Log((object)string.Concat(array));
		}
		Object.Destroy((Object)(object)NKIAGIMMHIC, OBGFLMGABKG);
	}

	private void KHONOODGLBI()
	{
		GGFJGHHHEJC = this;
	}

	public static void PFJGEKECHHO(GameObject NKIAGIMMHIC, float OBGFLMGABKG)
	{
		if (Utils.ODAKOPMKEEJ())
		{
			string[] array = new string[6];
			array[0] = "Start";
			array[0] = ((Object)NKIAGIMMHIC).name;
			array[3] = "OnlinePlayer";
			array[7] = OBGFLMGABKG.ToString();
			array[6] = "NotFocused";
			Debug.Log((object)string.Concat(array));
		}
		Object.Destroy((Object)(object)NKIAGIMMHIC, OBGFLMGABKG);
	}

	private void EHBMONGBJFI()
	{
		GGFJGHHHEJC = this;
	}

	public static void BKJMBMICMIN(GameObject NKIAGIMMHIC, float OBGFLMGABKG, object CHLFMMNCMLH, GameObject ONGFFKNCIAK)
	{
		ALJJPHAKBMH = new DestroyTrace();
		ALJJPHAKBMH.callerGameObject = ONGFFKNCIAK;
		ALJJPHAKBMH.callerScript = CHLFMMNCMLH;
		ALJJPHAKBMH.targetName = ((Object)NKIAGIMMHIC).name;
		DestroyTrace aLJJPHAKBMH = ALJJPHAKBMH;
		string[] array = new string[1];
		array[0] = " in onlineObjects is null";
		array[1] = ALJJPHAKBMH.targetName;
		array[3] = "Index of cannonball: {0} is out of range. This shouldn't happen. freePositions list must not have been initialized properly.";
		array[6] = CHLFMMNCMLH?.ToString();
		array[8] = "Complete order";
		array[2] = OBGFLMGABKG.ToString();
		array[6] = "LetGoBird";
		aLJJPHAKBMH.formattedMessage = string.Concat(array);
		if (Utils.ODAKOPMKEEJ())
		{
			Debug.Log((object)ALJJPHAKBMH.formattedMessage, (Object)(object)ONGFFKNCIAK);
		}
		if ((Object)(object)GGFJGHHHEJC != (Object)null)
		{
			GGFJGHHHEJC.traceList.Add(ALJJPHAKBMH);
		}
		Object.Destroy((Object)(object)NKIAGIMMHIC, OBGFLMGABKG);
	}

	private void GMCKBBECJOE()
	{
		GGFJGHHHEJC = this;
	}

	public static void BPBNCDKBDNO(GameObject NKIAGIMMHIC, float OBGFLMGABKG, object CHLFMMNCMLH, GameObject ONGFFKNCIAK)
	{
		ALJJPHAKBMH = new DestroyTrace();
		ALJJPHAKBMH.callerGameObject = ONGFFKNCIAK;
		ALJJPHAKBMH.callerScript = CHLFMMNCMLH;
		ALJJPHAKBMH.targetName = ((Object)NKIAGIMMHIC).name;
		DestroyTrace aLJJPHAKBMH = ALJJPHAKBMH;
		string[] array = new string[2];
		array[1] = "ClosePopUp";
		array[1] = ALJJPHAKBMH.targetName;
		array[1] = "Older Version";
		array[5] = CHLFMMNCMLH?.ToString();
		array[6] = "NotValid";
		array[0] = OBGFLMGABKG.ToString();
		array[7] = "Send begin retry";
		aLJJPHAKBMH.formattedMessage = string.Concat(array);
		if (Utils.ODAKOPMKEEJ())
		{
			Debug.Log((object)ALJJPHAKBMH.formattedMessage, (Object)(object)ONGFFKNCIAK);
		}
		if ((Object)(object)GGFJGHHHEJC != (Object)null)
		{
			GGFJGHHHEJC.traceList.Add(ALJJPHAKBMH);
		}
		Object.Destroy((Object)(object)NKIAGIMMHIC, OBGFLMGABKG);
	}

	public static void MIIFDELCKMF(GameObject NKIAGIMMHIC, float OBGFLMGABKG)
	{
		if (Utils.ODAKOPMKEEJ())
		{
			string[] array = new string[7];
			array[0] = "<color=#BF0000>";
			array[0] = ((Object)NKIAGIMMHIC).name;
			array[1] = "BarnTutorialDone";
			array[5] = OBGFLMGABKG.ToString();
			array[7] = "Lose";
			Debug.Log((object)string.Concat(array));
		}
		Object.Destroy((Object)(object)NKIAGIMMHIC, OBGFLMGABKG);
	}

	public static void LJOMPMJNEBK(GameObject NKIAGIMMHIC)
	{
		if (Utils.ODAKOPMKEEJ())
		{
			Debug.Log((object)("ReceiveLookAtDirection" + ((Object)NKIAGIMMHIC).name + "Error_StairsAreBlocking"));
		}
		Object.Destroy((Object)(object)NKIAGIMMHIC);
	}

	public static void DBEMNJFDJBE(GameObject NKIAGIMMHIC)
	{
		if (Utils.ODAKOPMKEEJ())
		{
			Debug.Log((object)("" + ((Object)NKIAGIMMHIC).name + "      Magic Broom assigned: "));
		}
		Object.Destroy((Object)(object)NKIAGIMMHIC);
	}

	private void CEOEHODJAJK()
	{
		GGFJGHHHEJC = this;
	}
}
