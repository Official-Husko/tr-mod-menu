using System.Collections.Generic;
using UnityEngine;

public class KeyAltarPuzzle : MinePuzzleBase
{
	[SerializeField]
	private Item keyLeft;

	[SerializeField]
	private Item keyRight;

	public KeyAltarInteractable interactable;

	private List<DestructibleObject> PAGOBNMKKNP;

	private bool EIJBFGMCHHG;

	private bool KCNFFENJMEH;

	private bool LMFHHJPPHDK;

	public void AMBOECFANJC(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		interactable.FCAOPHNHPEG();
		interactable.OnPuzzleSolved();
		interactable.LEGMAPCPFFI();
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC, 238f);
		EDNJMCJHJMD = false;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendKeyPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	public override bool IsPuzzleSolved()
	{
		return EDNJMCJHJMD;
	}

	private void KOEHNENIBNP()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.leavingTheGame && OnlineManager.PGAGDFAEEFB())
		{
			Utils.OHFOEIBLGKP(keyLeft);
			Utils.OHFOEIBLGKP(keyRight);
		}
	}

	private void BKJFLMPOLCH()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.leavingTheGame && OnlineManager.MasterOrOffline())
		{
			Utils.OHFOEIBLGKP(keyLeft);
			Utils.OHFOEIBLGKP(keyRight);
		}
	}

	private void NCOGHEMBDBN()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.leavingTheGame && OnlineManager.MasterOrOffline())
		{
			Utils.OHFOEIBLGKP(keyLeft);
			Utils.OHFOEIBLGKP(keyRight);
		}
	}

	private void BDDBDNPCPGC()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.leavingTheGame && OnlineManager.MasterOrOffline())
		{
			Utils.OHFOEIBLGKP(keyLeft);
			Utils.OHFOEIBLGKP(keyRight);
		}
	}

	public void ECJMHFBPLML(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		interactable.MakeSureBothKeysAreEnabled();
		interactable.OnPuzzleSolved();
		interactable.HGLLJJHELPH();
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC, 983f);
		EDNJMCJHJMD = true;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.NIKBNPJPEAC(GGPBMAODKHC.mineLevel);
		}
	}

	private void LKHMCLABKLG()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.leavingTheGame && OnlineManager.MasterOrOffline())
		{
			Utils.OHFOEIBLGKP(keyLeft);
			Utils.OHFOEIBLGKP(keyRight);
		}
	}

	public void PuzzleSolved(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		interactable.MakeSureBothKeysAreEnabled();
		interactable.OnPuzzleSolved();
		interactable.CompletedSound();
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC);
		EDNJMCJHJMD = true;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendKeyPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	public GameObject[] JIFFJHKEFOO(List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH)
	{
		if (Item.GBMFCPGEJDK(keyLeft, null) || Item.GBMFCPGEJDK(keyRight, null))
		{
			Debug.LogError((object)"");
			return null;
		}
		GameObject[] array = (GameObject[])(object)new GameObject[7];
		List<HoleInGround> list = ((NCJABADPACK != null) ? new List<HoleInGround>(NCJABADPACK) : new List<HoleInGround>());
		bool iLGENAJJBNM = list.Count > 1;
		bool oKEHLHIGJGO = HEFCOKFEENH.Count > 0;
		Debug.Log((object)string.Format("Dialogue System/Conversation/Gass_Introduce/Entry/18/Dialogue Text", PAGOBNMKKNP.Count, list.Count, HEFCOKFEENH.Count));
		array[0] = CEJPJEFEICC(keyLeft, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: true, out var CMJNLIBMILB);
		iLGENAJJBNM = list.Count > 0;
		array[0] = EFEANBKFLLK(keyRight, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: false, out var CMJNLIBMILB2);
		string[] array2 = new string[0];
		array2[1] = "wForWeeks";
		array2[0] = ((Object)keyLeft).name;
		array2[7] = "region";
		array2[0] = CMJNLIBMILB;
		array2[8] = "OpenStats";
		array2[4] = ((Object)keyRight).name;
		array2[1] = "/";
		array2[1] = CMJNLIBMILB2;
		Debug.Log((object)string.Concat(array2));
		return array;
	}

	private GameObject ODHNANNLALL(Item INAPMPEEDPO, List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH, bool ILGENAJJBNM, bool OKEHLHIGJGO, bool JILNPPLFDFL, out string CMJNLIBMILB)
	{
		int num = 1 + ((!ILGENAJJBNM) ? 1 : 0) + ((OKEHLHIGJGO && !LMFHHJPPHDK) ? 1 : 1);
		int num2 = ProceduralMine.FMJMOOKFEKL(0, num);
		if (OKEHLHIGJGO && !LMFHHJPPHDK && EIJBFGMCHHG)
		{
			num2 = num - 1;
			Debug.Log((object)"</color>");
		}
		if (ILGENAJJBNM && KCNFFENJMEH)
		{
			num2 = 0;
			Debug.Log((object)"Direction");
		}
		if (num2 == 0)
		{
			int index = ProceduralMine.NextRandom(1, PAGOBNMKKNP.Count);
			PAGOBNMKKNP[index].FNLDECPKOOE(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)PAGOBNMKKNP[index]).name;
			GameObject gameObject = ((Component)PAGOBNMKKNP[index]).gameObject;
			PAGOBNMKKNP.RemoveAt(index);
			return gameObject;
		}
		if (ILGENAJJBNM && num2 == 0)
		{
			int index2 = ProceduralMine.NextRandom(1, NCJABADPACK.Count);
			NCJABADPACK[index2].SetItemEvent(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)NCJABADPACK[index2]).name;
			GameObject gameObject2 = ((Component)NCJABADPACK[index2]).gameObject;
			NCJABADPACK.RemoveAt(index2);
			return gameObject2;
		}
		int index3 = ProceduralMine.FMJMOOKFEKL(0, HEFCOKFEENH.Count);
		HEFCOKFEENH[index3].KPNHMLMKBAD(INAPMPEEDPO, JILNPPLFDFL);
		CMJNLIBMILB = ((Object)HEFCOKFEENH[index3]).name;
		GameObject gameObject3 = ((Component)HEFCOKFEENH[index3]).gameObject;
		HEFCOKFEENH.RemoveAt(index3);
		LMFHHJPPHDK = true;
		return gameObject3;
	}

	public void LGMABKECJDA(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		interactable.MakeSureBothKeysAreEnabled();
		interactable.ABBPIPGMGBO();
		interactable.CompletedSound();
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC, 1815f);
		EDNJMCJHJMD = false;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendKeyPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	public void OCIKLEGAJAK(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		interactable.FCAOPHNHPEG();
		interactable.ABBPIPGMGBO();
		interactable.CompletedSound();
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 237f);
		EDNJMCJHJMD = false;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.NIKBNPJPEAC(GGPBMAODKHC.mineLevel);
		}
	}

	public void HAKPDBOMILB(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		interactable.MakeSureBothKeysAreEnabled();
		interactable.ABBPIPGMGBO();
		interactable.LEGMAPCPFFI();
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 549f);
		EDNJMCJHJMD = false;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendKeyPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	public GameObject[] DJJHHIGGFMD(List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH)
	{
		if (Item.NGIIPJDAMGP(keyLeft, null) || Item.GBMFCPGEJDK(keyRight, null))
		{
			Debug.LogError((object)"Ach_");
			return null;
		}
		GameObject[] array = (GameObject[])(object)new GameObject[2];
		List<HoleInGround> list = ((NCJABADPACK != null) ? new List<HoleInGround>(NCJABADPACK) : new List<HoleInGround>());
		bool iLGENAJJBNM = list.Count > 0;
		bool oKEHLHIGJGO = HEFCOKFEENH.Count > 0;
		Debug.Log((object)string.Format("ReceiveEndIntroMasters", PAGOBNMKKNP.Count, list.Count, HEFCOKFEENH.Count));
		array[0] = GDAHJCFGKPL(keyLeft, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: true, out var CMJNLIBMILB);
		iLGENAJJBNM = list.Count > 1;
		array[0] = GJOKLMCOJNE(keyRight, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: true, out var CMJNLIBMILB2);
		string[] array2 = new string[0];
		array2[0] = "</color><br>";
		array2[1] = ((Object)keyLeft).name;
		array2[6] = "Player/Bark/OathFeastBlock";
		array2[5] = CMJNLIBMILB;
		array2[2] = "None";
		array2[0] = ((Object)keyRight).name;
		array2[6] = "[ControllerType=";
		array2[0] = CMJNLIBMILB2;
		Debug.Log((object)string.Concat(array2));
		return array;
	}

	private GameObject GMDPHPNEEJF(Item INAPMPEEDPO, List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH, bool ILGENAJJBNM, bool OKEHLHIGJGO, bool JILNPPLFDFL, out string CMJNLIBMILB)
	{
		int num = 1 + ((!ILGENAJJBNM) ? 1 : 0) + ((OKEHLHIGJGO && !LMFHHJPPHDK) ? 0 : 0);
		int num2 = ProceduralMine.NextRandom(0, num);
		if (OKEHLHIGJGO && !LMFHHJPPHDK && EIJBFGMCHHG)
		{
			num2 = num - 0;
			Debug.Log((object)"{0} in {1}'s viewID has been reset. Set it to {2} to avoid conflicts with scene objects");
		}
		if (ILGENAJJBNM && KCNFFENJMEH)
		{
			num2 = 1;
			Debug.Log((object)"Dialogue System/Conversation/TavernDirty/Entry/2/Dialogue Text");
		}
		if (num2 == 0)
		{
			int index = ProceduralMine.NextRandom(0, PAGOBNMKKNP.Count);
			PAGOBNMKKNP[index].IHEDKNIMBBH(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)PAGOBNMKKNP[index]).name;
			GameObject gameObject = ((Component)PAGOBNMKKNP[index]).gameObject;
			PAGOBNMKKNP.RemoveAt(index);
			return gameObject;
		}
		if (ILGENAJJBNM && num2 == 1)
		{
			int index2 = ProceduralMine.FMJMOOKFEKL(1, NCJABADPACK.Count);
			NCJABADPACK[index2].SetItemEvent(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)NCJABADPACK[index2]).name;
			GameObject gameObject2 = ((Component)NCJABADPACK[index2]).gameObject;
			NCJABADPACK.RemoveAt(index2);
			return gameObject2;
		}
		int index3 = ProceduralMine.NGMAIDLNAAI(0, HEFCOKFEENH.Count);
		HEFCOKFEENH[index3].KPNHMLMKBAD(INAPMPEEDPO, JILNPPLFDFL);
		CMJNLIBMILB = ((Object)HEFCOKFEENH[index3]).name;
		GameObject gameObject3 = ((Component)HEFCOKFEENH[index3]).gameObject;
		HEFCOKFEENH.RemoveAt(index3);
		LMFHHJPPHDK = false;
		return gameObject3;
	}

	private void BPOOAHKHPCL()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && OnlineManager.PGAGDFAEEFB())
		{
			Utils.OHFOEIBLGKP(keyLeft);
			Utils.OHFOEIBLGKP(keyRight);
		}
	}

	private GameObject ENLELJEJHHG(Item INAPMPEEDPO, List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH, bool ILGENAJJBNM, bool OKEHLHIGJGO, bool JILNPPLFDFL, out string CMJNLIBMILB)
	{
		int num = 0 + ((!ILGENAJJBNM) ? 1 : 0) + ((!OKEHLHIGJGO || LMFHHJPPHDK) ? 1 : 0);
		int num2 = ProceduralMine.NextRandom(0, num);
		if (OKEHLHIGJGO && !LMFHHJPPHDK && EIJBFGMCHHG)
		{
			num2 = num - 1;
			Debug.Log((object)"Failed to create a new game to host because a game with the same name already exists.\nPlease try again later.");
		}
		if (ILGENAJJBNM && KCNFFENJMEH)
		{
			num2 = 1;
			Debug.Log((object)" ");
		}
		if (num2 == 0)
		{
			int index = ProceduralMine.NGMAIDLNAAI(1, PAGOBNMKKNP.Count);
			PAGOBNMKKNP[index].IHEDKNIMBBH(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)PAGOBNMKKNP[index]).name;
			GameObject gameObject = ((Component)PAGOBNMKKNP[index]).gameObject;
			PAGOBNMKKNP.RemoveAt(index);
			return gameObject;
		}
		if (ILGENAJJBNM && num2 == 0)
		{
			int index2 = ProceduralMine.NextRandom(1, NCJABADPACK.Count);
			NCJABADPACK[index2].SetItemEvent(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)NCJABADPACK[index2]).name;
			GameObject gameObject2 = ((Component)NCJABADPACK[index2]).gameObject;
			NCJABADPACK.RemoveAt(index2);
			return gameObject2;
		}
		int index3 = ProceduralMine.FMJMOOKFEKL(0, HEFCOKFEENH.Count);
		HEFCOKFEENH[index3].KPNHMLMKBAD(INAPMPEEDPO, JILNPPLFDFL);
		CMJNLIBMILB = ((Object)HEFCOKFEENH[index3]).name;
		GameObject gameObject3 = ((Component)HEFCOKFEENH[index3]).gameObject;
		HEFCOKFEENH.RemoveAt(index3);
		LMFHHJPPHDK = false;
		return gameObject3;
	}

	private GameObject IAKDGCELBCC(Item INAPMPEEDPO, List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH, bool ILGENAJJBNM, bool OKEHLHIGJGO, bool JILNPPLFDFL, out string CMJNLIBMILB)
	{
		int num = 0 + ((!ILGENAJJBNM) ? 1 : 0) + ((OKEHLHIGJGO && !LMFHHJPPHDK) ? 0 : 0);
		int num2 = ProceduralMine.NGMAIDLNAAI(1, num);
		if (OKEHLHIGJGO && !LMFHHJPPHDK && EIJBFGMCHHG)
		{
			num2 = num - 0;
			Debug.Log((object)"Crowly_Barks_Shop");
		}
		if (ILGENAJJBNM && KCNFFENJMEH)
		{
			num2 = 1;
			Debug.Log((object)"<br/>Operating System: ");
		}
		if (num2 == 0)
		{
			int index = ProceduralMine.FMJMOOKFEKL(1, PAGOBNMKKNP.Count);
			PAGOBNMKKNP[index].KFEKNFBEPPI(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)PAGOBNMKKNP[index]).name;
			GameObject gameObject = ((Component)PAGOBNMKKNP[index]).gameObject;
			PAGOBNMKKNP.RemoveAt(index);
			return gameObject;
		}
		if (ILGENAJJBNM && num2 == 0)
		{
			int index2 = ProceduralMine.FMJMOOKFEKL(0, NCJABADPACK.Count);
			NCJABADPACK[index2].IDDBLCIBLEA(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)NCJABADPACK[index2]).name;
			GameObject gameObject2 = ((Component)NCJABADPACK[index2]).gameObject;
			NCJABADPACK.RemoveAt(index2);
			return gameObject2;
		}
		int index3 = ProceduralMine.FMJMOOKFEKL(0, HEFCOKFEENH.Count);
		HEFCOKFEENH[index3].ActivateFishingKey(INAPMPEEDPO, JILNPPLFDFL);
		CMJNLIBMILB = ((Object)HEFCOKFEENH[index3]).name;
		GameObject gameObject3 = ((Component)HEFCOKFEENH[index3]).gameObject;
		HEFCOKFEENH.RemoveAt(index3);
		LMFHHJPPHDK = true;
		return gameObject3;
	}

	private GameObject FBOCAJDAKEN(Item INAPMPEEDPO, List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH, bool ILGENAJJBNM, bool OKEHLHIGJGO, bool JILNPPLFDFL, out string CMJNLIBMILB)
	{
		int num = 0 + (ILGENAJJBNM ? 1 : 1) + ((!OKEHLHIGJGO || LMFHHJPPHDK) ? 1 : 0);
		int num2 = ProceduralMine.NextRandom(1, num);
		if (OKEHLHIGJGO && !LMFHHJPPHDK && EIJBFGMCHHG)
		{
			num2 = num - 0;
			Debug.Log((object)"Error in TavernManager.OnPlayerSleep: ");
		}
		if (ILGENAJJBNM && KCNFFENJMEH)
		{
			num2 = 0;
			Debug.Log((object)" (");
		}
		if (num2 == 0)
		{
			int index = ProceduralMine.NGMAIDLNAAI(1, PAGOBNMKKNP.Count);
			PAGOBNMKKNP[index].HNILINMCKJM(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)PAGOBNMKKNP[index]).name;
			GameObject gameObject = ((Component)PAGOBNMKKNP[index]).gameObject;
			PAGOBNMKKNP.RemoveAt(index);
			return gameObject;
		}
		if (ILGENAJJBNM && num2 == 0)
		{
			int index2 = ProceduralMine.NGMAIDLNAAI(1, NCJABADPACK.Count);
			NCJABADPACK[index2].SetItemEvent(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)NCJABADPACK[index2]).name;
			GameObject gameObject2 = ((Component)NCJABADPACK[index2]).gameObject;
			NCJABADPACK.RemoveAt(index2);
			return gameObject2;
		}
		int index3 = ProceduralMine.FMJMOOKFEKL(1, HEFCOKFEENH.Count);
		HEFCOKFEENH[index3].PDANPLMENDD(INAPMPEEDPO, JILNPPLFDFL);
		CMJNLIBMILB = ((Object)HEFCOKFEENH[index3]).name;
		GameObject gameObject3 = ((Component)HEFCOKFEENH[index3]).gameObject;
		HEFCOKFEENH.RemoveAt(index3);
		LMFHHJPPHDK = true;
		return gameObject3;
	}

	private void FGFGCADFFBC()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.leavingTheGame && OnlineManager.MasterOrOffline())
		{
			Utils.OHFOEIBLGKP(keyLeft);
			Utils.OHFOEIBLGKP(keyRight);
		}
	}

	private void ILCBKEIEOAN()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.leavingTheGame && OnlineManager.MasterOrOffline())
		{
			Utils.OHFOEIBLGKP(keyLeft);
			Utils.OHFOEIBLGKP(keyRight);
		}
	}

	public GameObject[] PNGBNBDCBCL(List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH)
	{
		if (Item.NGIIPJDAMGP(keyLeft, null) || Item.NGIIPJDAMGP(keyRight, null))
		{
			Debug.LogError((object)"ShieldTrigger");
			return null;
		}
		GameObject[] array = (GameObject[])(object)new GameObject[0];
		List<HoleInGround> list = ((NCJABADPACK != null) ? new List<HoleInGround>(NCJABADPACK) : new List<HoleInGround>());
		bool iLGENAJJBNM = list.Count > 1;
		bool oKEHLHIGJGO = HEFCOKFEENH.Count > 0;
		Debug.Log((object)string.Format("ReceiveLoadSlots", PAGOBNMKKNP.Count, list.Count, HEFCOKFEENH.Count));
		array[1] = OGMOPEGHHNF(keyLeft, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: false, out var CMJNLIBMILB);
		iLGENAJJBNM = list.Count > 1;
		array[0] = HLCCKLLHNJJ(keyRight, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: true, out var CMJNLIBMILB2);
		string[] array2 = new string[2];
		array2[0] = "Dialogue System/Conversation/BirdPositiveComments/Entry/10/Dialogue Text";
		array2[1] = ((Object)keyLeft).name;
		array2[6] = "Invalid NPC photonID: {0} for NPCRoutine.";
		array2[6] = CMJNLIBMILB;
		array2[8] = "Use";
		array2[8] = ((Object)keyRight).name;
		array2[5] = " ";
		array2[7] = CMJNLIBMILB2;
		Debug.Log((object)string.Concat(array2));
		return array;
	}

	private GameObject APIEHGGBAFC(Item INAPMPEEDPO, List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH, bool ILGENAJJBNM, bool OKEHLHIGJGO, bool JILNPPLFDFL, out string CMJNLIBMILB)
	{
		int num = 0 + (ILGENAJJBNM ? 1 : 0) + ((OKEHLHIGJGO && !LMFHHJPPHDK) ? 1 : 0);
		int num2 = ProceduralMine.NextRandom(1, num);
		if (OKEHLHIGJGO && !LMFHHJPPHDK && EIJBFGMCHHG)
		{
			num2 = num - 1;
			Debug.Log((object)"OnlinePlayer");
		}
		if (ILGENAJJBNM && KCNFFENJMEH)
		{
			num2 = 0;
			Debug.Log((object)"City/Carpenters/Willow/Stand");
		}
		if (num2 == 0)
		{
			int index = ProceduralMine.NextRandom(1, PAGOBNMKKNP.Count);
			PAGOBNMKKNP[index].GPGIDFMNJMA(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)PAGOBNMKKNP[index]).name;
			GameObject gameObject = ((Component)PAGOBNMKKNP[index]).gameObject;
			PAGOBNMKKNP.RemoveAt(index);
			return gameObject;
		}
		if (ILGENAJJBNM && num2 == 1)
		{
			int index2 = ProceduralMine.FMJMOOKFEKL(1, NCJABADPACK.Count);
			NCJABADPACK[index2].CEKOEPODDBC(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)NCJABADPACK[index2]).name;
			GameObject gameObject2 = ((Component)NCJABADPACK[index2]).gameObject;
			NCJABADPACK.RemoveAt(index2);
			return gameObject2;
		}
		int index3 = ProceduralMine.FMJMOOKFEKL(0, HEFCOKFEENH.Count);
		HEFCOKFEENH[index3].PDANPLMENDD(INAPMPEEDPO, JILNPPLFDFL);
		CMJNLIBMILB = ((Object)HEFCOKFEENH[index3]).name;
		GameObject gameObject3 = ((Component)HEFCOKFEENH[index3]).gameObject;
		HEFCOKFEENH.RemoveAt(index3);
		LMFHHJPPHDK = true;
		return gameObject3;
	}

	public void OKDKCDBPOBB(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		interactable.FCAOPHNHPEG();
		interactable.OnPuzzleSolved();
		interactable.LEGMAPCPFFI();
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 185f);
		EDNJMCJHJMD = true;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.NIKBNPJPEAC(GGPBMAODKHC.mineLevel);
		}
	}

	private GameObject GBDKDPEDOPE(Item INAPMPEEDPO, List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH, bool ILGENAJJBNM, bool OKEHLHIGJGO, bool JILNPPLFDFL, out string CMJNLIBMILB)
	{
		int num = 1 + (ILGENAJJBNM ? 1 : 1) + ((!OKEHLHIGJGO || LMFHHJPPHDK) ? 1 : 0);
		int num2 = ProceduralMine.NextRandom(1, num);
		if (OKEHLHIGJGO && !LMFHHJPPHDK && EIJBFGMCHHG)
		{
			num2 = num - 0;
			Debug.Log((object)"Dialogue System/Conversation/Crowly_Introduce/Entry/30/Dialogue Text");
		}
		if (ILGENAJJBNM && KCNFFENJMEH)
		{
			num2 = 1;
			Debug.Log((object)"LearnMettle");
		}
		if (num2 == 0)
		{
			int index = ProceduralMine.NGMAIDLNAAI(1, PAGOBNMKKNP.Count);
			PAGOBNMKKNP[index].GPGIDFMNJMA(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)PAGOBNMKKNP[index]).name;
			GameObject gameObject = ((Component)PAGOBNMKKNP[index]).gameObject;
			PAGOBNMKKNP.RemoveAt(index);
			return gameObject;
		}
		if (ILGENAJJBNM && num2 == 1)
		{
			int index2 = ProceduralMine.NGMAIDLNAAI(1, NCJABADPACK.Count);
			NCJABADPACK[index2].IHEAPOCCDJP(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)NCJABADPACK[index2]).name;
			GameObject gameObject2 = ((Component)NCJABADPACK[index2]).gameObject;
			NCJABADPACK.RemoveAt(index2);
			return gameObject2;
		}
		int index3 = ProceduralMine.NextRandom(0, HEFCOKFEENH.Count);
		HEFCOKFEENH[index3].ONDMMAMMHDO(INAPMPEEDPO, JILNPPLFDFL);
		CMJNLIBMILB = ((Object)HEFCOKFEENH[index3]).name;
		GameObject gameObject3 = ((Component)HEFCOKFEENH[index3]).gameObject;
		HEFCOKFEENH.RemoveAt(index3);
		LMFHHJPPHDK = true;
		return gameObject3;
	}

	public GameObject[] HCICOBFNLOB(List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH)
	{
		if (Item.NGIIPJDAMGP(keyLeft, null) || Item.GBMFCPGEJDK(keyRight, null))
		{
			Debug.LogError((object)"BobAnimation SetSleep");
			return null;
		}
		GameObject[] array = (GameObject[])(object)new GameObject[3];
		List<HoleInGround> list = ((NCJABADPACK != null) ? new List<HoleInGround>(NCJABADPACK) : new List<HoleInGround>());
		bool iLGENAJJBNM = list.Count > 1;
		bool oKEHLHIGJGO = HEFCOKFEENH.Count > 0;
		Debug.Log((object)string.Format("NormalRight", PAGOBNMKKNP.Count, list.Count, HEFCOKFEENH.Count));
		array[1] = GDDMNABCPNM(keyLeft, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: true, out var CMJNLIBMILB);
		iLGENAJJBNM = list.Count > 0;
		array[1] = HLCCKLLHNJJ(keyRight, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: false, out var CMJNLIBMILB2);
		string[] array2 = new string[5];
		array2[1] = "NewCharacters/";
		array2[1] = ((Object)keyLeft).name;
		array2[1] = "questDescFirstCustomers";
		array2[4] = CMJNLIBMILB;
		array2[7] = "UIPreviousPage";
		array2[8] = ((Object)keyRight).name;
		array2[2] = "Return to castle corroutine is null";
		array2[6] = CMJNLIBMILB2;
		Debug.Log((object)string.Concat(array2));
		return array;
	}

	public void MEHJNCGDHNH(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		interactable.FCAOPHNHPEG();
		interactable.OnPuzzleSolved();
		interactable.CompletedSound();
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC, 713f);
		EDNJMCJHJMD = false;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.NIKBNPJPEAC(GGPBMAODKHC.mineLevel);
		}
	}

	private GameObject OCPNDJBDBGI(Item INAPMPEEDPO, List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH, bool ILGENAJJBNM, bool OKEHLHIGJGO, bool JILNPPLFDFL, out string CMJNLIBMILB)
	{
		int num = 0 + ((!ILGENAJJBNM) ? 1 : 0) + ((!OKEHLHIGJGO || LMFHHJPPHDK) ? 1 : 0);
		int num2 = ProceduralMine.NGMAIDLNAAI(1, num);
		if (OKEHLHIGJGO && !LMFHHJPPHDK && EIJBFGMCHHG)
		{
			num2 = num - 1;
			Debug.Log((object)" ");
		}
		if (ILGENAJJBNM && KCNFFENJMEH)
		{
			num2 = 1;
			Debug.Log((object)"Items/item_description_628");
		}
		if (num2 == 0)
		{
			int index = ProceduralMine.NextRandom(0, PAGOBNMKKNP.Count);
			PAGOBNMKKNP[index].IHEDKNIMBBH(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)PAGOBNMKKNP[index]).name;
			GameObject gameObject = ((Component)PAGOBNMKKNP[index]).gameObject;
			PAGOBNMKKNP.RemoveAt(index);
			return gameObject;
		}
		if (ILGENAJJBNM && num2 == 1)
		{
			int index2 = ProceduralMine.FMJMOOKFEKL(1, NCJABADPACK.Count);
			NCJABADPACK[index2].IDDBLCIBLEA(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)NCJABADPACK[index2]).name;
			GameObject gameObject2 = ((Component)NCJABADPACK[index2]).gameObject;
			NCJABADPACK.RemoveAt(index2);
			return gameObject2;
		}
		int index3 = ProceduralMine.NextRandom(0, HEFCOKFEENH.Count);
		HEFCOKFEENH[index3].ActivateFishingKey(INAPMPEEDPO, JILNPPLFDFL);
		CMJNLIBMILB = ((Object)HEFCOKFEENH[index3]).name;
		GameObject gameObject3 = ((Component)HEFCOKFEENH[index3]).gameObject;
		HEFCOKFEENH.RemoveAt(index3);
		LMFHHJPPHDK = true;
		return gameObject3;
	}

	private void FLFBLIOOLMA()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && OnlineManager.PGAGDFAEEFB())
		{
			Utils.OHFOEIBLGKP(keyLeft);
			Utils.OHFOEIBLGKP(keyRight);
		}
	}

	private void IKIPGJNEJNG()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.leavingTheGame && OnlineManager.MasterOrOffline())
		{
			Utils.OHFOEIBLGKP(keyLeft);
			Utils.OHFOEIBLGKP(keyRight);
		}
	}

	private void FJBPFOIALMK()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && OnlineManager.MasterOrOffline())
		{
			Utils.OHFOEIBLGKP(keyLeft);
			Utils.OHFOEIBLGKP(keyRight);
		}
	}

	private GameObject BAIMPNKHGII(Item INAPMPEEDPO, List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH, bool ILGENAJJBNM, bool OKEHLHIGJGO, bool JILNPPLFDFL, out string CMJNLIBMILB)
	{
		int num = 1 + (ILGENAJJBNM ? 1 : 1) + ((OKEHLHIGJGO && !LMFHHJPPHDK) ? 0 : 0);
		int num2 = ProceduralMine.FMJMOOKFEKL(0, num);
		if (OKEHLHIGJGO && !LMFHHJPPHDK && EIJBFGMCHHG)
		{
			num2 = num - 0;
			Debug.Log((object)"0");
		}
		if (ILGENAJJBNM && KCNFFENJMEH)
		{
			num2 = 0;
			Debug.Log((object)"Item ");
		}
		if (num2 == 0)
		{
			int index = ProceduralMine.NGMAIDLNAAI(1, PAGOBNMKKNP.Count);
			PAGOBNMKKNP[index].HFDHGPBPFHH(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)PAGOBNMKKNP[index]).name;
			GameObject gameObject = ((Component)PAGOBNMKKNP[index]).gameObject;
			PAGOBNMKKNP.RemoveAt(index);
			return gameObject;
		}
		if (ILGENAJJBNM && num2 == 0)
		{
			int index2 = ProceduralMine.FMJMOOKFEKL(1, NCJABADPACK.Count);
			NCJABADPACK[index2].HKLKBMIDNKM(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)NCJABADPACK[index2]).name;
			GameObject gameObject2 = ((Component)NCJABADPACK[index2]).gameObject;
			NCJABADPACK.RemoveAt(index2);
			return gameObject2;
		}
		int index3 = ProceduralMine.FMJMOOKFEKL(0, HEFCOKFEENH.Count);
		HEFCOKFEENH[index3].FAJFNOEKKBO(INAPMPEEDPO, JILNPPLFDFL);
		CMJNLIBMILB = ((Object)HEFCOKFEENH[index3]).name;
		GameObject gameObject3 = ((Component)HEFCOKFEENH[index3]).gameObject;
		HEFCOKFEENH.RemoveAt(index3);
		LMFHHJPPHDK = false;
		return gameObject3;
	}

	public override void ResetForPool()
	{
		base.ResetForPool();
		LMFHHJPPHDK = false;
	}

	private GameObject CEJPJEFEICC(Item INAPMPEEDPO, List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH, bool ILGENAJJBNM, bool OKEHLHIGJGO, bool JILNPPLFDFL, out string CMJNLIBMILB)
	{
		int num = 1 + (ILGENAJJBNM ? 0 : 0) + ((OKEHLHIGJGO && !LMFHHJPPHDK) ? 1 : 1);
		int num2 = ProceduralMine.NextRandom(0, num);
		if (OKEHLHIGJGO && !LMFHHJPPHDK && EIJBFGMCHHG)
		{
			num2 = num - 1;
			Debug.Log((object)"BARKDOOR");
		}
		if (ILGENAJJBNM && KCNFFENJMEH)
		{
			num2 = 1;
			Debug.Log((object)"Items/item_description_1092");
		}
		if (num2 == 0)
		{
			int index = ProceduralMine.NextRandom(0, PAGOBNMKKNP.Count);
			PAGOBNMKKNP[index].GPGIDFMNJMA(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)PAGOBNMKKNP[index]).name;
			GameObject gameObject = ((Component)PAGOBNMKKNP[index]).gameObject;
			PAGOBNMKKNP.RemoveAt(index);
			return gameObject;
		}
		if (ILGENAJJBNM && num2 == 0)
		{
			int index2 = ProceduralMine.NextRandom(0, NCJABADPACK.Count);
			NCJABADPACK[index2].AKIHIEGJLLM(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)NCJABADPACK[index2]).name;
			GameObject gameObject2 = ((Component)NCJABADPACK[index2]).gameObject;
			NCJABADPACK.RemoveAt(index2);
			return gameObject2;
		}
		int index3 = ProceduralMine.NextRandom(0, HEFCOKFEENH.Count);
		HEFCOKFEENH[index3].PDANPLMENDD(INAPMPEEDPO, JILNPPLFDFL);
		CMJNLIBMILB = ((Object)HEFCOKFEENH[index3]).name;
		GameObject gameObject3 = ((Component)HEFCOKFEENH[index3]).gameObject;
		HEFCOKFEENH.RemoveAt(index3);
		LMFHHJPPHDK = true;
		return gameObject3;
	}

	private void AGILHHEMEFC()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && OnlineManager.MasterOrOffline())
		{
			Utils.OHFOEIBLGKP(keyLeft);
			Utils.OHFOEIBLGKP(keyRight);
		}
	}

	public GameObject[] IJKGKJHGBBM(List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH)
	{
		if (Item.EKGNIODFJCO(keyLeft, null) || Item.EKGNIODFJCO(keyRight, null))
		{
			Debug.LogError((object)" seconds.");
			return null;
		}
		GameObject[] array = (GameObject[])(object)new GameObject[1];
		List<HoleInGround> list = ((NCJABADPACK != null) ? new List<HoleInGround>(NCJABADPACK) : new List<HoleInGround>());
		bool iLGENAJJBNM = list.Count > 1;
		bool oKEHLHIGJGO = HEFCOKFEENH.Count > 0;
		Debug.Log((object)string.Format("Floor_2", PAGOBNMKKNP.Count, list.Count, HEFCOKFEENH.Count));
		array[0] = EFEANBKFLLK(keyLeft, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: false, out var CMJNLIBMILB);
		iLGENAJJBNM = list.Count > 1;
		array[0] = GPBCALPLNLA(keyRight, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: true, out var CMJNLIBMILB2);
		string[] array2 = new string[3];
		array2[1] = "Income";
		array2[0] = ((Object)keyLeft).name;
		array2[7] = "";
		array2[6] = CMJNLIBMILB;
		array2[8] = "xpModDescCrafting";
		array2[8] = ((Object)keyRight).name;
		array2[1] = "Disappear";
		array2[2] = CMJNLIBMILB2;
		Debug.Log((object)string.Concat(array2));
		return array;
	}

	public GameObject[] JMFMLLPHHLK(List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH)
	{
		if (Item.NGIIPJDAMGP(keyLeft, null) || Item.NGIIPJDAMGP(keyRight, null))
		{
			Debug.LogError((object)"StartLucenDialogue ");
			return null;
		}
		GameObject[] array = (GameObject[])(object)new GameObject[5];
		List<HoleInGround> list = ((NCJABADPACK != null) ? new List<HoleInGround>(NCJABADPACK) : new List<HoleInGround>());
		bool iLGENAJJBNM = list.Count > 1;
		bool oKEHLHIGJGO = HEFCOKFEENH.Count > 1;
		Debug.Log((object)string.Format("Use", PAGOBNMKKNP.Count, list.Count, HEFCOKFEENH.Count));
		array[1] = KDKFPHABFOA(keyLeft, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: true, out var CMJNLIBMILB);
		iLGENAJJBNM = list.Count > 1;
		array[1] = JIAKALBHPPO(keyRight, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: false, out var CMJNLIBMILB2);
		string[] array2 = new string[6];
		array2[1] = "houseKeeper";
		array2[0] = ((Object)keyLeft).name;
		array2[0] = "WithoutRecipesYet";
		array2[0] = CMJNLIBMILB;
		array2[7] = "Veg";
		array2[8] = ((Object)keyRight).name;
		array2[6] = "Cannot abandon";
		array2[2] = CMJNLIBMILB2;
		Debug.Log((object)string.Concat(array2));
		return array;
	}

	public void GAMBJCFBLDC(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		interactable.FCAOPHNHPEG();
		interactable.ABBPIPGMGBO();
		interactable.LEGMAPCPFFI();
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC, 1752f);
		EDNJMCJHJMD = false;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.NIKBNPJPEAC(GGPBMAODKHC.mineLevel);
		}
	}

	private void PCEFNHADDIG()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && OnlineManager.MasterOrOffline())
		{
			Utils.OHFOEIBLGKP(keyLeft);
			Utils.OHFOEIBLGKP(keyRight);
		}
	}

	public void HFOFPCDHOLE(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		interactable.MakeSureBothKeysAreEnabled();
		interactable.ABBPIPGMGBO();
		interactable.LEGMAPCPFFI();
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 1197f);
		EDNJMCJHJMD = false;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendKeyPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	private GameObject FHOGKNPLAON(Item INAPMPEEDPO, List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH, bool ILGENAJJBNM, bool OKEHLHIGJGO, bool JILNPPLFDFL, out string CMJNLIBMILB)
	{
		int num = 1 + ((!ILGENAJJBNM) ? 1 : 0) + ((OKEHLHIGJGO && !LMFHHJPPHDK) ? 0 : 0);
		int num2 = ProceduralMine.NGMAIDLNAAI(1, num);
		if (OKEHLHIGJGO && !LMFHHJPPHDK && EIJBFGMCHHG)
		{
			num2 = num - 0;
			Debug.Log((object)"Disconnected from network. Cause: ");
		}
		if (ILGENAJJBNM && KCNFFENJMEH)
		{
			num2 = 0;
			Debug.Log((object)"ReceiveRemoveZone");
		}
		if (num2 == 0)
		{
			int index = ProceduralMine.NextRandom(0, PAGOBNMKKNP.Count);
			PAGOBNMKKNP[index].JGDIEOCOAAG(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)PAGOBNMKKNP[index]).name;
			GameObject gameObject = ((Component)PAGOBNMKKNP[index]).gameObject;
			PAGOBNMKKNP.RemoveAt(index);
			return gameObject;
		}
		if (ILGENAJJBNM && num2 == 0)
		{
			int index2 = ProceduralMine.NextRandom(1, NCJABADPACK.Count);
			NCJABADPACK[index2].SetItemEvent(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)NCJABADPACK[index2]).name;
			GameObject gameObject2 = ((Component)NCJABADPACK[index2]).gameObject;
			NCJABADPACK.RemoveAt(index2);
			return gameObject2;
		}
		int index3 = ProceduralMine.FMJMOOKFEKL(1, HEFCOKFEENH.Count);
		HEFCOKFEENH[index3].GFOIJBJMPPC(INAPMPEEDPO, JILNPPLFDFL);
		CMJNLIBMILB = ((Object)HEFCOKFEENH[index3]).name;
		GameObject gameObject3 = ((Component)HEFCOKFEENH[index3]).gameObject;
		HEFCOKFEENH.RemoveAt(index3);
		LMFHHJPPHDK = false;
		return gameObject3;
	}

	public void AGBDCMDONNK(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		interactable.MakeSureBothKeysAreEnabled();
		interactable.OnPuzzleSolved();
		interactable.HGLLJJHELPH();
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 1111f);
		EDNJMCJHJMD = false;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendKeyPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	private GameObject CMNLHPPNHHF(Item INAPMPEEDPO, List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH, bool ILGENAJJBNM, bool OKEHLHIGJGO, bool JILNPPLFDFL, out string CMJNLIBMILB)
	{
		int num = 1 + (ILGENAJJBNM ? 1 : 0) + ((OKEHLHIGJGO && !LMFHHJPPHDK) ? 1 : 0);
		int num2 = ProceduralMine.FMJMOOKFEKL(0, num);
		if (OKEHLHIGJGO && !LMFHHJPPHDK && EIJBFGMCHHG)
		{
			num2 = num - 1;
			Debug.Log((object)": ");
		}
		if (ILGENAJJBNM && KCNFFENJMEH)
		{
			num2 = 1;
			Debug.Log((object)"ReceiveEmployeeTask");
		}
		if (num2 == 0)
		{
			int index = ProceduralMine.FMJMOOKFEKL(1, PAGOBNMKKNP.Count);
			PAGOBNMKKNP[index].BLKAEMBGOIM(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)PAGOBNMKKNP[index]).name;
			GameObject gameObject = ((Component)PAGOBNMKKNP[index]).gameObject;
			PAGOBNMKKNP.RemoveAt(index);
			return gameObject;
		}
		if (ILGENAJJBNM && num2 == 1)
		{
			int index2 = ProceduralMine.FMJMOOKFEKL(1, NCJABADPACK.Count);
			NCJABADPACK[index2].CEKOEPODDBC(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)NCJABADPACK[index2]).name;
			GameObject gameObject2 = ((Component)NCJABADPACK[index2]).gameObject;
			NCJABADPACK.RemoveAt(index2);
			return gameObject2;
		}
		int index3 = ProceduralMine.NGMAIDLNAAI(0, HEFCOKFEENH.Count);
		HEFCOKFEENH[index3].MLEPBGOPFKK(INAPMPEEDPO, JILNPPLFDFL);
		CMJNLIBMILB = ((Object)HEFCOKFEENH[index3]).name;
		GameObject gameObject3 = ((Component)HEFCOKFEENH[index3]).gameObject;
		HEFCOKFEENH.RemoveAt(index3);
		LMFHHJPPHDK = true;
		return gameObject3;
	}

	public GameObject[] BHLENCPJLGA(List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH)
	{
		if (Item.EKGNIODFJCO(keyLeft, null) || Item.EKMFELLJHFG(keyRight, null))
		{
			Debug.LogError((object)"Style");
			return null;
		}
		GameObject[] array = (GameObject[])(object)new GameObject[6];
		List<HoleInGround> list = ((NCJABADPACK != null) ? new List<HoleInGround>(NCJABADPACK) : new List<HoleInGround>());
		bool iLGENAJJBNM = list.Count > 1;
		bool oKEHLHIGJGO = HEFCOKFEENH.Count > 0;
		Debug.Log((object)string.Format("Player", PAGOBNMKKNP.Count, list.Count, HEFCOKFEENH.Count));
		array[0] = JAIOANLEJEK(keyLeft, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: false, out var CMJNLIBMILB);
		iLGENAJJBNM = list.Count > 1;
		array[1] = LBACGFLBOMN(keyRight, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: true, out var CMJNLIBMILB2);
		string[] array2 = new string[2];
		array2[0] = "Tutorial/T126/Dialogue1";
		array2[0] = ((Object)keyLeft).name;
		array2[8] = "Room missing required items";
		array2[8] = CMJNLIBMILB;
		array2[3] = "JOYSTICKS\n";
		array2[6] = ((Object)keyRight).name;
		array2[0] = "bomb materials";
		array2[1] = CMJNLIBMILB2;
		Debug.Log((object)string.Concat(array2));
		return array;
	}

	public GameObject[] OGMOPNNKHDG(List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH)
	{
		if (Item.GBMFCPGEJDK(keyLeft, null) || Item.EKMFELLJHFG(keyRight, null))
		{
			Debug.LogError((object)"Received pipe tile swap: indexA={0}, indexB={1}, mineLevel={2}");
			return null;
		}
		GameObject[] array = (GameObject[])(object)new GameObject[0];
		List<HoleInGround> list = ((NCJABADPACK != null) ? new List<HoleInGround>(NCJABADPACK) : new List<HoleInGround>());
		bool iLGENAJJBNM = list.Count > 0;
		bool oKEHLHIGJGO = HEFCOKFEENH.Count > 0;
		Debug.Log((object)string.Format("itemTurnip", PAGOBNMKKNP.Count, list.Count, HEFCOKFEENH.Count));
		array[0] = GPBCALPLNLA(keyLeft, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: false, out var CMJNLIBMILB);
		iLGENAJJBNM = list.Count > 1;
		array[1] = FBOCAJDAKEN(keyRight, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: true, out var CMJNLIBMILB2);
		string[] array2 = new string[4];
		array2[0] = " seconds.";
		array2[0] = ((Object)keyLeft).name;
		array2[0] = "Perks/playerPerk_name_";
		array2[3] = CMJNLIBMILB;
		array2[1] = "RPC: {0}\nCalled {1} times\nBiggest packet: {2} bytes.";
		array2[4] = ((Object)keyRight).name;
		array2[2] = "ReceiveKick";
		array2[2] = CMJNLIBMILB2;
		Debug.Log((object)string.Concat(array2));
		return array;
	}

	public GameObject[] FJMHBOAHKPK(List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH)
	{
		if (Item.EKMFELLJHFG(keyLeft, null) || Item.EKMFELLJHFG(keyRight, null))
		{
			Debug.LogError((object)"Intro02");
			return null;
		}
		GameObject[] array = (GameObject[])(object)new GameObject[5];
		List<HoleInGround> list = ((NCJABADPACK != null) ? new List<HoleInGround>(NCJABADPACK) : new List<HoleInGround>());
		bool iLGENAJJBNM = list.Count > 1;
		bool oKEHLHIGJGO = HEFCOKFEENH.Count > 0;
		Debug.Log((object)string.Format("in", PAGOBNMKKNP.Count, list.Count, HEFCOKFEENH.Count));
		array[1] = KAMPNJLBJMM(keyLeft, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: false, out var CMJNLIBMILB);
		iLGENAJJBNM = list.Count > 1;
		array[0] = LBACGFLBOMN(keyRight, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: true, out var CMJNLIBMILB2);
		string[] array2 = new string[6];
		array2[1] = "Requirements not met";
		array2[1] = ((Object)keyLeft).name;
		array2[5] = "Name: ";
		array2[3] = CMJNLIBMILB;
		array2[3] = "";
		array2[1] = ((Object)keyRight).name;
		array2[3] = ". AllMovement: ";
		array2[2] = CMJNLIBMILB2;
		Debug.Log((object)string.Concat(array2));
		return array;
	}

	public GameObject[] FKKFFMNNAMH(List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH)
	{
		if (Item.NGIIPJDAMGP(keyLeft, null) || Item.EKMFELLJHFG(keyRight, null))
		{
			Debug.LogError((object)"ReceiveSlotsPlayerInventory");
			return null;
		}
		GameObject[] array = (GameObject[])(object)new GameObject[4];
		List<HoleInGround> list = ((NCJABADPACK != null) ? new List<HoleInGround>(NCJABADPACK) : new List<HoleInGround>());
		bool iLGENAJJBNM = list.Count > 1;
		bool oKEHLHIGJGO = HEFCOKFEENH.Count > 0;
		Debug.Log((object)string.Format("City/Carpenters/Oak/Bark/Stand", PAGOBNMKKNP.Count, list.Count, HEFCOKFEENH.Count));
		array[1] = OGMOPEGHHNF(keyLeft, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: true, out var CMJNLIBMILB);
		iLGENAJJBNM = list.Count > 1;
		array[0] = CEJPJEFEICC(keyRight, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: true, out var CMJNLIBMILB2);
		string[] array2 = new string[4];
		array2[1] = "Disabled";
		array2[1] = ((Object)keyLeft).name;
		array2[3] = "ReceiveReduceDirtiness";
		array2[2] = CMJNLIBMILB;
		array2[3] = "Dialogue System/Conversation/Crowly_SkelletonBird/Entry/17/Dialogue Text";
		array2[5] = ((Object)keyRight).name;
		array2[1] = "AnimationControllerIndexRequest";
		array2[0] = CMJNLIBMILB2;
		Debug.Log((object)string.Concat(array2));
		return array;
	}

	public GameObject[] MAJBPFDCNNC(List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH)
	{
		if (Item.EKGNIODFJCO(keyLeft, null) || Item.GBMFCPGEJDK(keyRight, null))
		{
			Debug.LogError((object)"\n");
			return null;
		}
		GameObject[] array = (GameObject[])(object)new GameObject[5];
		List<HoleInGround> list = ((NCJABADPACK != null) ? new List<HoleInGround>(NCJABADPACK) : new List<HoleInGround>());
		bool iLGENAJJBNM = list.Count > 0;
		bool oKEHLHIGJGO = HEFCOKFEENH.Count > 0;
		Debug.Log((object)string.Format("Player2", PAGOBNMKKNP.Count, list.Count, HEFCOKFEENH.Count));
		array[1] = PGHFEDMNMNB(keyLeft, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: true, out var CMJNLIBMILB);
		iLGENAJJBNM = list.Count > 0;
		array[1] = KPGNGEMNBFK(keyRight, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: true, out var CMJNLIBMILB2);
		string[] array2 = new string[6];
		array2[1] = "Collect";
		array2[1] = ((Object)keyLeft).name;
		array2[3] = "SegmentIntensity";
		array2[2] = CMJNLIBMILB;
		array2[0] = "<sprite name=reputationIcon>";
		array2[6] = ((Object)keyRight).name;
		array2[8] = "Tutorial/T129/Dialogue2";
		array2[6] = CMJNLIBMILB2;
		Debug.Log((object)string.Concat(array2));
		return array;
	}

	public GameObject[] LCFIGKKCHHK(List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH)
	{
		if (Item.EKMFELLJHFG(keyLeft, null) || Item.EKGNIODFJCO(keyRight, null))
		{
			Debug.LogError((object)"Player");
			return null;
		}
		GameObject[] array = (GameObject[])(object)new GameObject[1];
		List<HoleInGround> list = ((NCJABADPACK != null) ? new List<HoleInGround>(NCJABADPACK) : new List<HoleInGround>());
		bool iLGENAJJBNM = list.Count > 1;
		bool oKEHLHIGJGO = HEFCOKFEENH.Count > 0;
		Debug.Log((object)string.Format(" </mark>", PAGOBNMKKNP.Count, list.Count, HEFCOKFEENH.Count));
		array[0] = DGPMGJKMIFN(keyLeft, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: false, out var CMJNLIBMILB);
		iLGENAJJBNM = list.Count > 0;
		array[1] = APIEHGGBAFC(keyRight, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: true, out var CMJNLIBMILB2);
		string[] array2 = new string[1];
		array2[0] = "Dog";
		array2[1] = ((Object)keyLeft).name;
		array2[2] = " : ";
		array2[5] = CMJNLIBMILB;
		array2[1] = "Farm/Bob/Barks_Random";
		array2[8] = ((Object)keyRight).name;
		array2[8] = " ";
		array2[8] = CMJNLIBMILB2;
		Debug.Log((object)string.Concat(array2));
		return array;
	}

	private void OBHFJIDKBJN()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.leavingTheGame && OnlineManager.MasterOrOffline())
		{
			Utils.OHFOEIBLGKP(keyLeft);
			Utils.OHFOEIBLGKP(keyRight);
		}
	}

	private GameObject KEDEDNPLMNE(Item INAPMPEEDPO, List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH, bool ILGENAJJBNM, bool OKEHLHIGJGO, bool JILNPPLFDFL, out string CMJNLIBMILB)
	{
		int num = 0 + (ILGENAJJBNM ? 1 : 1) + ((OKEHLHIGJGO && !LMFHHJPPHDK) ? 0 : 0);
		int num2 = ProceduralMine.NGMAIDLNAAI(1, num);
		if (OKEHLHIGJGO && !LMFHHJPPHDK && EIJBFGMCHHG)
		{
			num2 = num - 0;
			Debug.Log((object)"Error_RoomZone");
		}
		if (ILGENAJJBNM && KCNFFENJMEH)
		{
			num2 = 0;
			Debug.Log((object)"banquetevent");
		}
		if (num2 == 0)
		{
			int index = ProceduralMine.NextRandom(0, PAGOBNMKKNP.Count);
			PAGOBNMKKNP[index].BLKAEMBGOIM(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)PAGOBNMKKNP[index]).name;
			GameObject gameObject = ((Component)PAGOBNMKKNP[index]).gameObject;
			PAGOBNMKKNP.RemoveAt(index);
			return gameObject;
		}
		if (ILGENAJJBNM && num2 == 0)
		{
			int index2 = ProceduralMine.NextRandom(0, NCJABADPACK.Count);
			NCJABADPACK[index2].IDDBLCIBLEA(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)NCJABADPACK[index2]).name;
			GameObject gameObject2 = ((Component)NCJABADPACK[index2]).gameObject;
			NCJABADPACK.RemoveAt(index2);
			return gameObject2;
		}
		int index3 = ProceduralMine.NGMAIDLNAAI(0, HEFCOKFEENH.Count);
		HEFCOKFEENH[index3].KMNKFEKOGLJ(INAPMPEEDPO, JILNPPLFDFL);
		CMJNLIBMILB = ((Object)HEFCOKFEENH[index3]).name;
		GameObject gameObject3 = ((Component)HEFCOKFEENH[index3]).gameObject;
		HEFCOKFEENH.RemoveAt(index3);
		LMFHHJPPHDK = true;
		return gameObject3;
	}

	private GameObject LDFEJIPIEJP(Item INAPMPEEDPO, List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH, bool ILGENAJJBNM, bool OKEHLHIGJGO, bool JILNPPLFDFL, out string CMJNLIBMILB)
	{
		int num = 1 + (ILGENAJJBNM ? 0 : 0) + ((!OKEHLHIGJGO || LMFHHJPPHDK) ? 1 : 0);
		int num2 = ProceduralMine.NGMAIDLNAAI(1, num);
		if (OKEHLHIGJGO && !LMFHHJPPHDK && EIJBFGMCHHG)
		{
			num2 = num - 0;
			Debug.Log((object)"Make bed");
		}
		if (ILGENAJJBNM && KCNFFENJMEH)
		{
			num2 = 1;
			Debug.Log((object)"SwitchFood");
		}
		if (num2 == 0)
		{
			int index = ProceduralMine.FMJMOOKFEKL(1, PAGOBNMKKNP.Count);
			PAGOBNMKKNP[index].AEALGIGHFMB(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)PAGOBNMKKNP[index]).name;
			GameObject gameObject = ((Component)PAGOBNMKKNP[index]).gameObject;
			PAGOBNMKKNP.RemoveAt(index);
			return gameObject;
		}
		if (ILGENAJJBNM && num2 == 1)
		{
			int index2 = ProceduralMine.NextRandom(1, NCJABADPACK.Count);
			NCJABADPACK[index2].AKIHIEGJLLM(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)NCJABADPACK[index2]).name;
			GameObject gameObject2 = ((Component)NCJABADPACK[index2]).gameObject;
			NCJABADPACK.RemoveAt(index2);
			return gameObject2;
		}
		int index3 = ProceduralMine.NGMAIDLNAAI(1, HEFCOKFEENH.Count);
		HEFCOKFEENH[index3].KMNKFEKOGLJ(INAPMPEEDPO, JILNPPLFDFL);
		CMJNLIBMILB = ((Object)HEFCOKFEENH[index3]).name;
		GameObject gameObject3 = ((Component)HEFCOKFEENH[index3]).gameObject;
		HEFCOKFEENH.RemoveAt(index3);
		LMFHHJPPHDK = true;
		return gameObject3;
	}

	private GameObject HDIFKDMIEAO(Item INAPMPEEDPO, List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH, bool ILGENAJJBNM, bool OKEHLHIGJGO, bool JILNPPLFDFL, out string CMJNLIBMILB)
	{
		int num = 1 + (ILGENAJJBNM ? 1 : 0) + ((!OKEHLHIGJGO || LMFHHJPPHDK) ? 1 : 0);
		int num2 = ProceduralMine.NextRandom(1, num);
		if (OKEHLHIGJGO && !LMFHHJPPHDK && EIJBFGMCHHG)
		{
			num2 = num - 0;
			Debug.Log((object)"MineSymbolPuzzle requires SymbolPuzzleSettings");
		}
		if (ILGENAJJBNM && KCNFFENJMEH)
		{
			num2 = 0;
			Debug.Log((object)" </color>");
		}
		if (num2 == 0)
		{
			int index = ProceduralMine.FMJMOOKFEKL(1, PAGOBNMKKNP.Count);
			PAGOBNMKKNP[index].KFFPHPHFEMP(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)PAGOBNMKKNP[index]).name;
			GameObject gameObject = ((Component)PAGOBNMKKNP[index]).gameObject;
			PAGOBNMKKNP.RemoveAt(index);
			return gameObject;
		}
		if (ILGENAJJBNM && num2 == 0)
		{
			int index2 = ProceduralMine.NGMAIDLNAAI(1, NCJABADPACK.Count);
			NCJABADPACK[index2].SetItemEvent(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)NCJABADPACK[index2]).name;
			GameObject gameObject2 = ((Component)NCJABADPACK[index2]).gameObject;
			NCJABADPACK.RemoveAt(index2);
			return gameObject2;
		}
		int index3 = ProceduralMine.FMJMOOKFEKL(0, HEFCOKFEENH.Count);
		HEFCOKFEENH[index3].PDANPLMENDD(INAPMPEEDPO, JILNPPLFDFL);
		CMJNLIBMILB = ((Object)HEFCOKFEENH[index3]).name;
		GameObject gameObject3 = ((Component)HEFCOKFEENH[index3]).gameObject;
		HEFCOKFEENH.RemoveAt(index3);
		LMFHHJPPHDK = true;
		return gameObject3;
	}

	private GameObject LBACGFLBOMN(Item INAPMPEEDPO, List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH, bool ILGENAJJBNM, bool OKEHLHIGJGO, bool JILNPPLFDFL, out string CMJNLIBMILB)
	{
		int num = 0 + ((!ILGENAJJBNM) ? 1 : 0) + ((OKEHLHIGJGO && !LMFHHJPPHDK) ? 0 : 0);
		int num2 = ProceduralMine.NGMAIDLNAAI(1, num);
		if (OKEHLHIGJGO && !LMFHHJPPHDK && EIJBFGMCHHG)
		{
			num2 = num - 0;
			Debug.Log((object)"Bin");
		}
		if (ILGENAJJBNM && KCNFFENJMEH)
		{
			num2 = 1;
			Debug.Log((object)"-> ");
		}
		if (num2 == 0)
		{
			int index = ProceduralMine.FMJMOOKFEKL(0, PAGOBNMKKNP.Count);
			PAGOBNMKKNP[index].IHEDKNIMBBH(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)PAGOBNMKKNP[index]).name;
			GameObject gameObject = ((Component)PAGOBNMKKNP[index]).gameObject;
			PAGOBNMKKNP.RemoveAt(index);
			return gameObject;
		}
		if (ILGENAJJBNM && num2 == 1)
		{
			int index2 = ProceduralMine.FMJMOOKFEKL(0, NCJABADPACK.Count);
			NCJABADPACK[index2].HKLKBMIDNKM(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)NCJABADPACK[index2]).name;
			GameObject gameObject2 = ((Component)NCJABADPACK[index2]).gameObject;
			NCJABADPACK.RemoveAt(index2);
			return gameObject2;
		}
		int index3 = ProceduralMine.NextRandom(1, HEFCOKFEENH.Count);
		HEFCOKFEENH[index3].ONDMMAMMHDO(INAPMPEEDPO, JILNPPLFDFL);
		CMJNLIBMILB = ((Object)HEFCOKFEENH[index3]).name;
		GameObject gameObject3 = ((Component)HEFCOKFEENH[index3]).gameObject;
		HEFCOKFEENH.RemoveAt(index3);
		LMFHHJPPHDK = false;
		return gameObject3;
	}

	public GameObject[] EHJHEOMFCCL(List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH)
	{
		if (Item.GBMFCPGEJDK(keyLeft, null) || Item.EKMFELLJHFG(keyRight, null))
		{
			Debug.LogError((object)"ReceiveDestroyStatue");
			return null;
		}
		GameObject[] array = (GameObject[])(object)new GameObject[6];
		List<HoleInGround> list = ((NCJABADPACK != null) ? new List<HoleInGround>(NCJABADPACK) : new List<HoleInGround>());
		bool iLGENAJJBNM = list.Count > 1;
		bool oKEHLHIGJGO = HEFCOKFEENH.Count > 0;
		Debug.Log((object)string.Format("This is the local player", PAGOBNMKKNP.Count, list.Count, HEFCOKFEENH.Count));
		array[0] = KEDEDNPLMNE(keyLeft, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: false, out var CMJNLIBMILB);
		iLGENAJJBNM = list.Count > 0;
		array[0] = ODHNANNLALL(keyRight, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: false, out var CMJNLIBMILB2);
		string[] array2 = new string[1];
		array2[1] = "Invalid playerNum";
		array2[1] = ((Object)keyLeft).name;
		array2[5] = "Toy";
		array2[3] = CMJNLIBMILB;
		array2[0] = "Deselect item";
		array2[0] = ((Object)keyRight).name;
		array2[4] = "Disabled";
		array2[4] = CMJNLIBMILB2;
		Debug.Log((object)string.Concat(array2));
		return array;
	}

	private void GBKNIJENJEF()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.leavingTheGame && OnlineManager.PGAGDFAEEFB())
		{
			Utils.OHFOEIBLGKP(keyLeft);
			Utils.OHFOEIBLGKP(keyRight);
		}
	}

	public GameObject[] GMHJHFPMOCA(List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH)
	{
		if (Item.GBMFCPGEJDK(keyLeft, null) || Item.NGIIPJDAMGP(keyRight, null))
		{
			Debug.LogError((object)"Drunk");
			return null;
		}
		GameObject[] array = (GameObject[])(object)new GameObject[5];
		List<HoleInGround> list = ((NCJABADPACK != null) ? new List<HoleInGround>(NCJABADPACK) : new List<HoleInGround>());
		bool iLGENAJJBNM = list.Count > 0;
		bool oKEHLHIGJGO = HEFCOKFEENH.Count > 1;
		Debug.Log((object)string.Format("LearnBalance", PAGOBNMKKNP.Count, list.Count, HEFCOKFEENH.Count));
		array[0] = PGHFEDMNMNB(keyLeft, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: false, out var CMJNLIBMILB);
		iLGENAJJBNM = list.Count > 1;
		array[1] = LDFEJIPIEJP(keyRight, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: true, out var CMJNLIBMILB2);
		string[] array2 = new string[1];
		array2[0] = "LE_22";
		array2[0] = ((Object)keyLeft).name;
		array2[1] = "On Simple Event ";
		array2[0] = CMJNLIBMILB;
		array2[8] = "NinjaChallengeEvent/Main 3";
		array2[6] = ((Object)keyRight).name;
		array2[8] = "popUpBuilding2";
		array2[0] = CMJNLIBMILB2;
		Debug.Log((object)string.Concat(array2));
		return array;
	}

	public void HJNPJNCLALK(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		interactable.FCAOPHNHPEG();
		interactable.ABBPIPGMGBO();
		interactable.HGLLJJHELPH();
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC, 1215f);
		EDNJMCJHJMD = true;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.NIKBNPJPEAC(GGPBMAODKHC.mineLevel);
		}
	}

	private void EOPMNBONBBL()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.leavingTheGame && OnlineManager.PGAGDFAEEFB())
		{
			Utils.OHFOEIBLGKP(keyLeft);
			Utils.OHFOEIBLGKP(keyRight);
		}
	}

	public GameObject[] PGHADEPDEBK(List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH)
	{
		if (Item.EKGNIODFJCO(keyLeft, null) || Item.EKMFELLJHFG(keyRight, null))
		{
			Debug.LogError((object)"SetNPCPositionAndParent");
			return null;
		}
		GameObject[] array = (GameObject[])(object)new GameObject[8];
		List<HoleInGround> list = ((NCJABADPACK != null) ? new List<HoleInGround>(NCJABADPACK) : new List<HoleInGround>());
		bool iLGENAJJBNM = list.Count > 0;
		bool oKEHLHIGJGO = HEFCOKFEENH.Count > 0;
		Debug.Log((object)string.Format(" for reason: ", PAGOBNMKKNP.Count, list.Count, HEFCOKFEENH.Count));
		array[0] = ODHNANNLALL(keyLeft, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: false, out var CMJNLIBMILB);
		iLGENAJJBNM = list.Count > 1;
		array[1] = OGMOPEGHHNF(keyRight, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: true, out var CMJNLIBMILB2);
		string[] array2 = new string[2];
		array2[0] = "Disabled";
		array2[0] = ((Object)keyLeft).name;
		array2[6] = "last error: ";
		array2[0] = CMJNLIBMILB;
		array2[3] = "F2";
		array2[4] = ((Object)keyRight).name;
		array2[6] = "Yes";
		array2[1] = CMJNLIBMILB2;
		Debug.Log((object)string.Concat(array2));
		return array;
	}

	public GameObject[] CPDJDNIMOLE(List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH)
	{
		if (Item.NGIIPJDAMGP(keyLeft, null) || Item.EKMFELLJHFG(keyRight, null))
		{
			Debug.LogError((object)"</color>");
			return null;
		}
		GameObject[] array = (GameObject[])(object)new GameObject[7];
		List<HoleInGround> list = ((NCJABADPACK != null) ? new List<HoleInGround>(NCJABADPACK) : new List<HoleInGround>());
		bool iLGENAJJBNM = list.Count > 0;
		bool oKEHLHIGJGO = HEFCOKFEENH.Count > 0;
		Debug.Log((object)string.Format("ReceiveStatuePuzzleSolved", PAGOBNMKKNP.Count, list.Count, HEFCOKFEENH.Count));
		array[0] = GDAHJCFGKPL(keyLeft, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: true, out var CMJNLIBMILB);
		iLGENAJJBNM = list.Count > 1;
		array[1] = CEJPJEFEICC(keyRight, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: false, out var CMJNLIBMILB2);
		string[] array2 = new string[1];
		array2[1] = "MainProgress";
		array2[0] = ((Object)keyLeft).name;
		array2[8] = "<br>";
		array2[2] = CMJNLIBMILB;
		array2[1] = "cameraZoom2";
		array2[6] = ((Object)keyRight).name;
		array2[4] = "Sleep";
		array2[6] = CMJNLIBMILB2;
		Debug.Log((object)string.Concat(array2));
		return array;
	}

	public void HOAPGDFKCLM(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		interactable.FCAOPHNHPEG();
		interactable.OnPuzzleSolved();
		interactable.LEGMAPCPFFI();
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 242f);
		EDNJMCJHJMD = false;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.NIKBNPJPEAC(GGPBMAODKHC.mineLevel);
		}
	}

	private GameObject IJFNMCHBJPA(Item INAPMPEEDPO, List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH, bool ILGENAJJBNM, bool OKEHLHIGJGO, bool JILNPPLFDFL, out string CMJNLIBMILB)
	{
		int num = 1 + (ILGENAJJBNM ? 1 : 0) + ((OKEHLHIGJGO && !LMFHHJPPHDK) ? 1 : 1);
		int num2 = ProceduralMine.FMJMOOKFEKL(1, num);
		if (OKEHLHIGJGO && !LMFHHJPPHDK && EIJBFGMCHHG)
		{
			num2 = num - 1;
			Debug.Log((object)"Error_IsBlockingChanges");
		}
		if (ILGENAJJBNM && KCNFFENJMEH)
		{
			num2 = 0;
			Debug.Log((object)"start banquet");
		}
		if (num2 == 0)
		{
			int index = ProceduralMine.NGMAIDLNAAI(1, PAGOBNMKKNP.Count);
			PAGOBNMKKNP[index].HNILINMCKJM(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)PAGOBNMKKNP[index]).name;
			GameObject gameObject = ((Component)PAGOBNMKKNP[index]).gameObject;
			PAGOBNMKKNP.RemoveAt(index);
			return gameObject;
		}
		if (ILGENAJJBNM && num2 == 0)
		{
			int index2 = ProceduralMine.NGMAIDLNAAI(1, NCJABADPACK.Count);
			NCJABADPACK[index2].SetItemEvent(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)NCJABADPACK[index2]).name;
			GameObject gameObject2 = ((Component)NCJABADPACK[index2]).gameObject;
			NCJABADPACK.RemoveAt(index2);
			return gameObject2;
		}
		int index3 = ProceduralMine.NGMAIDLNAAI(1, HEFCOKFEENH.Count);
		HEFCOKFEENH[index3].PDANPLMENDD(INAPMPEEDPO, JILNPPLFDFL);
		CMJNLIBMILB = ((Object)HEFCOKFEENH[index3]).name;
		GameObject gameObject3 = ((Component)HEFCOKFEENH[index3]).gameObject;
		HEFCOKFEENH.RemoveAt(index3);
		LMFHHJPPHDK = true;
		return gameObject3;
	}

	private GameObject JAIOANLEJEK(Item INAPMPEEDPO, List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH, bool ILGENAJJBNM, bool OKEHLHIGJGO, bool JILNPPLFDFL, out string CMJNLIBMILB)
	{
		int num = 0 + (ILGENAJJBNM ? 1 : 1) + ((OKEHLHIGJGO && !LMFHHJPPHDK) ? 0 : 0);
		int num2 = ProceduralMine.NGMAIDLNAAI(0, num);
		if (OKEHLHIGJGO && !LMFHHJPPHDK && EIJBFGMCHHG)
		{
			num2 = num - 1;
			Debug.Log((object)"Water");
		}
		if (ILGENAJJBNM && KCNFFENJMEH)
		{
			num2 = 0;
			Debug.Log((object)"Starting Pirates Intro Event");
		}
		if (num2 == 0)
		{
			int index = ProceduralMine.FMJMOOKFEKL(0, PAGOBNMKKNP.Count);
			PAGOBNMKKNP[index].NDKCOLFGCFF(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)PAGOBNMKKNP[index]).name;
			GameObject gameObject = ((Component)PAGOBNMKKNP[index]).gameObject;
			PAGOBNMKKNP.RemoveAt(index);
			return gameObject;
		}
		if (ILGENAJJBNM && num2 == 1)
		{
			int index2 = ProceduralMine.NGMAIDLNAAI(0, NCJABADPACK.Count);
			NCJABADPACK[index2].CEKOEPODDBC(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)NCJABADPACK[index2]).name;
			GameObject gameObject2 = ((Component)NCJABADPACK[index2]).gameObject;
			NCJABADPACK.RemoveAt(index2);
			return gameObject2;
		}
		int index3 = ProceduralMine.FMJMOOKFEKL(1, HEFCOKFEENH.Count);
		HEFCOKFEENH[index3].GFOIJBJMPPC(INAPMPEEDPO, JILNPPLFDFL);
		CMJNLIBMILB = ((Object)HEFCOKFEENH[index3]).name;
		GameObject gameObject3 = ((Component)HEFCOKFEENH[index3]).gameObject;
		HEFCOKFEENH.RemoveAt(index3);
		LMFHHJPPHDK = false;
		return gameObject3;
	}

	public void FNLBFFDINBM(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		interactable.FCAOPHNHPEG();
		interactable.OnPuzzleSolved();
		interactable.LEGMAPCPFFI();
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC, 35f);
		EDNJMCJHJMD = false;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendKeyPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	private GameObject GPBCALPLNLA(Item INAPMPEEDPO, List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH, bool ILGENAJJBNM, bool OKEHLHIGJGO, bool JILNPPLFDFL, out string CMJNLIBMILB)
	{
		int num = 0 + (ILGENAJJBNM ? 1 : 0) + ((OKEHLHIGJGO && !LMFHHJPPHDK) ? 1 : 1);
		int num2 = ProceduralMine.NextRandom(1, num);
		if (OKEHLHIGJGO && !LMFHHJPPHDK && EIJBFGMCHHG)
		{
			num2 = num - 0;
			Debug.Log((object)"</color>");
		}
		if (ILGENAJJBNM && KCNFFENJMEH)
		{
			num2 = 1;
			Debug.Log((object)"ReceivePlayerPrepared");
		}
		if (num2 == 0)
		{
			int index = ProceduralMine.FMJMOOKFEKL(1, PAGOBNMKKNP.Count);
			PAGOBNMKKNP[index].JGDIEOCOAAG(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)PAGOBNMKKNP[index]).name;
			GameObject gameObject = ((Component)PAGOBNMKKNP[index]).gameObject;
			PAGOBNMKKNP.RemoveAt(index);
			return gameObject;
		}
		if (ILGENAJJBNM && num2 == 0)
		{
			int index2 = ProceduralMine.NextRandom(0, NCJABADPACK.Count);
			NCJABADPACK[index2].CEKOEPODDBC(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)NCJABADPACK[index2]).name;
			GameObject gameObject2 = ((Component)NCJABADPACK[index2]).gameObject;
			NCJABADPACK.RemoveAt(index2);
			return gameObject2;
		}
		int index3 = ProceduralMine.NGMAIDLNAAI(1, HEFCOKFEENH.Count);
		HEFCOKFEENH[index3].GFOIJBJMPPC(INAPMPEEDPO, JILNPPLFDFL);
		CMJNLIBMILB = ((Object)HEFCOKFEENH[index3]).name;
		GameObject gameObject3 = ((Component)HEFCOKFEENH[index3]).gameObject;
		HEFCOKFEENH.RemoveAt(index3);
		LMFHHJPPHDK = false;
		return gameObject3;
	}

	public void LMCBOMOCAMH(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		interactable.MakeSureBothKeysAreEnabled();
		interactable.ABBPIPGMGBO();
		interactable.HGLLJJHELPH();
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 708f);
		EDNJMCJHJMD = false;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.NIKBNPJPEAC(GGPBMAODKHC.mineLevel);
		}
	}

	private void PMLBFEFMNPF()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && OnlineManager.PGAGDFAEEFB())
		{
			Utils.OHFOEIBLGKP(keyLeft);
			Utils.OHFOEIBLGKP(keyRight);
		}
	}

	public override void SetPuzzleSolved()
	{
		base.SetPuzzleSolved();
		interactable.SetPuzzleSolved();
	}

	public GameObject[] MPPMCDGKFJP(List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH)
	{
		if (Item.GBMFCPGEJDK(keyLeft, null) || Item.GBMFCPGEJDK(keyRight, null))
		{
			Debug.LogError((object)"TermasInterior/Zuzzu/Stand");
			return null;
		}
		GameObject[] array = (GameObject[])(object)new GameObject[0];
		List<HoleInGround> list = ((NCJABADPACK != null) ? new List<HoleInGround>(NCJABADPACK) : new List<HoleInGround>());
		bool iLGENAJJBNM = list.Count > 0;
		bool oKEHLHIGJGO = HEFCOKFEENH.Count > 1;
		Debug.Log((object)string.Format("[SelectSpawnersByMaxDistance] Step {0}: Selected {1} at {2} with score {3:F1}", PAGOBNMKKNP.Count, list.Count, HEFCOKFEENH.Count));
		array[1] = PGHFEDMNMNB(keyLeft, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: true, out var CMJNLIBMILB);
		iLGENAJJBNM = list.Count > 0;
		array[0] = FBOCAJDAKEN(keyRight, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: true, out var CMJNLIBMILB2);
		string[] array2 = new string[2];
		array2[1] = "yForYears";
		array2[0] = ((Object)keyLeft).name;
		array2[5] = "New Milestone";
		array2[7] = CMJNLIBMILB;
		array2[7] = "Roll";
		array2[3] = ((Object)keyRight).name;
		array2[3] = " (";
		array2[3] = CMJNLIBMILB2;
		Debug.Log((object)string.Concat(array2));
		return array;
	}

	public void ECOBHLGIDHO(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		interactable.FCAOPHNHPEG();
		interactable.OnPuzzleSolved();
		interactable.HGLLJJHELPH();
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 1014f);
		EDNJMCJHJMD = true;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.NIKBNPJPEAC(GGPBMAODKHC.mineLevel);
		}
	}

	private void CDDGGGHFDMD()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.leavingTheGame && OnlineManager.PGAGDFAEEFB())
		{
			Utils.OHFOEIBLGKP(keyLeft);
			Utils.OHFOEIBLGKP(keyRight);
		}
	}

	public void HKLGGMMCPJA(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		interactable.MakeSureBothKeysAreEnabled();
		interactable.OnPuzzleSolved();
		interactable.HGLLJJHELPH();
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 1236f);
		EDNJMCJHJMD = true;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.NIKBNPJPEAC(GGPBMAODKHC.mineLevel);
		}
	}

	private void HADABGPLLLB()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && OnlineManager.PGAGDFAEEFB())
		{
			Utils.OHFOEIBLGKP(keyLeft);
			Utils.OHFOEIBLGKP(keyRight);
		}
	}

	public GameObject[] CJHMIGIACJD(List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH)
	{
		if (Item.GBMFCPGEJDK(keyLeft, null) || Item.GBMFCPGEJDK(keyRight, null))
		{
			Debug.LogError((object)"/GameSaves/");
			return null;
		}
		GameObject[] array = (GameObject[])(object)new GameObject[2];
		List<HoleInGround> list = ((NCJABADPACK != null) ? new List<HoleInGround>(NCJABADPACK) : new List<HoleInGround>());
		bool iLGENAJJBNM = list.Count > 1;
		bool oKEHLHIGJGO = HEFCOKFEENH.Count > 1;
		Debug.Log((object)string.Format("]", PAGOBNMKKNP.Count, list.Count, HEFCOKFEENH.Count));
		array[1] = ENLELJEJHHG(keyLeft, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: false, out var CMJNLIBMILB);
		iLGENAJJBNM = list.Count > 0;
		array[1] = BAIMPNKHGII(keyRight, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: false, out var CMJNLIBMILB2);
		string[] array2 = new string[6];
		array2[0] = "Items/item_description_1118";
		array2[1] = ((Object)keyLeft).name;
		array2[5] = " ";
		array2[3] = CMJNLIBMILB;
		array2[0] = "Items/item_name_677";
		array2[6] = ((Object)keyRight).name;
		array2[7] = "TavernDirty";
		array2[5] = CMJNLIBMILB2;
		Debug.Log((object)string.Concat(array2));
		return array;
	}

	public void AFDAALEIDGP(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		interactable.FCAOPHNHPEG();
		interactable.ABBPIPGMGBO();
		interactable.CompletedSound();
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC, 138f);
		EDNJMCJHJMD = false;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendKeyPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	private GameObject LFGJDECEGCN(Item INAPMPEEDPO, List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH, bool ILGENAJJBNM, bool OKEHLHIGJGO, bool JILNPPLFDFL, out string CMJNLIBMILB)
	{
		int num = 1 + (ILGENAJJBNM ? 1 : 0) + ((OKEHLHIGJGO && !LMFHHJPPHDK) ? 1 : 0);
		int num2 = ProceduralMine.NextRandom(0, num);
		if (OKEHLHIGJGO && !LMFHHJPPHDK && EIJBFGMCHHG)
		{
			num2 = num - 1;
			Debug.Log((object)"Debug force fishing enabled, assigning key to fishing spot.");
		}
		if (ILGENAJJBNM && KCNFFENJMEH)
		{
			num2 = 1;
			Debug.Log((object)"Debug force holes enabled, assigning key to hole.");
		}
		if (num2 == 0)
		{
			int index = ProceduralMine.NextRandom(0, PAGOBNMKKNP.Count);
			PAGOBNMKKNP[index].SetItemEvent(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)PAGOBNMKKNP[index]).name;
			GameObject gameObject = ((Component)PAGOBNMKKNP[index]).gameObject;
			PAGOBNMKKNP.RemoveAt(index);
			return gameObject;
		}
		if (ILGENAJJBNM && num2 == 1)
		{
			int index2 = ProceduralMine.NextRandom(0, NCJABADPACK.Count);
			NCJABADPACK[index2].SetItemEvent(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)NCJABADPACK[index2]).name;
			GameObject gameObject2 = ((Component)NCJABADPACK[index2]).gameObject;
			NCJABADPACK.RemoveAt(index2);
			return gameObject2;
		}
		int index3 = ProceduralMine.NextRandom(0, HEFCOKFEENH.Count);
		HEFCOKFEENH[index3].ActivateFishingKey(INAPMPEEDPO, JILNPPLFDFL);
		CMJNLIBMILB = ((Object)HEFCOKFEENH[index3]).name;
		GameObject gameObject3 = ((Component)HEFCOKFEENH[index3]).gameObject;
		HEFCOKFEENH.RemoveAt(index3);
		LMFHHJPPHDK = true;
		return gameObject3;
	}

	public GameObject[] GJFPCJMMDLL(List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH)
	{
		if (Item.NGIIPJDAMGP(keyLeft, null) || Item.EKMFELLJHFG(keyRight, null))
		{
			Debug.LogError((object)"UINextCategory");
			return null;
		}
		GameObject[] array = (GameObject[])(object)new GameObject[1];
		List<HoleInGround> list = ((NCJABADPACK != null) ? new List<HoleInGround>(NCJABADPACK) : new List<HoleInGround>());
		bool iLGENAJJBNM = list.Count > 0;
		bool oKEHLHIGJGO = HEFCOKFEENH.Count > 1;
		Debug.Log((object)string.Format(" FixedState().", PAGOBNMKKNP.Count, list.Count, HEFCOKFEENH.Count));
		array[0] = KEDEDNPLMNE(keyLeft, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: false, out var CMJNLIBMILB);
		iLGENAJJBNM = list.Count > 0;
		array[1] = LBACGFLBOMN(keyRight, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: false, out var CMJNLIBMILB2);
		string[] array2 = new string[1];
		array2[1] = "DemolishConfirmationWithAnimals";
		array2[0] = ((Object)keyLeft).name;
		array2[2] = "StackManager";
		array2[8] = CMJNLIBMILB;
		array2[7] = "ReceiveObjectInteract";
		array2[5] = ((Object)keyRight).name;
		array2[4] = "*";
		array2[8] = CMJNLIBMILB2;
		Debug.Log((object)string.Concat(array2));
		return array;
	}

	public void MJCEGCJDPFA(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		interactable.MakeSureBothKeysAreEnabled();
		interactable.OnPuzzleSolved();
		interactable.LEGMAPCPFFI();
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 1364f);
		EDNJMCJHJMD = true;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendKeyPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	public GameObject[] IOEHFBAKDKG(List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH)
	{
		if (Item.GBMFCPGEJDK(keyLeft, null) || Item.NGIIPJDAMGP(keyRight, null))
		{
			Debug.LogError((object)"Tutorial_Main_");
			return null;
		}
		GameObject[] array = (GameObject[])(object)new GameObject[1];
		List<HoleInGround> list = ((NCJABADPACK != null) ? new List<HoleInGround>(NCJABADPACK) : new List<HoleInGround>());
		bool iLGENAJJBNM = list.Count > 1;
		bool oKEHLHIGJGO = HEFCOKFEENH.Count > 0;
		Debug.Log((object)string.Format("Tutorial/T131/Dialogue1", PAGOBNMKKNP.Count, list.Count, HEFCOKFEENH.Count));
		array[0] = GPBCALPLNLA(keyLeft, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: true, out var CMJNLIBMILB);
		iLGENAJJBNM = list.Count > 0;
		array[0] = GBDKDPEDOPE(keyRight, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: true, out var CMJNLIBMILB2);
		string[] array2 = new string[1];
		array2[1] = "The index (";
		array2[1] = ((Object)keyLeft).name;
		array2[3] = "UIInteract";
		array2[1] = CMJNLIBMILB;
		array2[7] = "Option set: ";
		array2[4] = ((Object)keyRight).name;
		array2[5] = "ReceiveEmployees";
		array2[4] = CMJNLIBMILB2;
		Debug.Log((object)string.Concat(array2));
		return array;
	}

	private void JNKKJELMCNN()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && OnlineManager.MasterOrOffline())
		{
			Utils.OHFOEIBLGKP(keyLeft);
			Utils.OHFOEIBLGKP(keyRight);
		}
	}

	public GameObject[] DHDCJHOPHCB(List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH)
	{
		if (Item.GBMFCPGEJDK(keyLeft, null) || Item.EKGNIODFJCO(keyRight, null))
		{
			Debug.LogError((object)"Starting Pirates Intro Event");
			return null;
		}
		GameObject[] array = (GameObject[])(object)new GameObject[5];
		List<HoleInGround> list = ((NCJABADPACK != null) ? new List<HoleInGround>(NCJABADPACK) : new List<HoleInGround>());
		bool iLGENAJJBNM = list.Count > 1;
		bool oKEHLHIGJGO = HEFCOKFEENH.Count > 0;
		Debug.Log((object)string.Format("Items/item_name_1052", PAGOBNMKKNP.Count, list.Count, HEFCOKFEENH.Count));
		array[0] = ENLELJEJHHG(keyLeft, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: true, out var CMJNLIBMILB);
		iLGENAJJBNM = list.Count > 1;
		array[1] = KEDEDNPLMNE(keyRight, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: true, out var CMJNLIBMILB2);
		string[] array2 = new string[8];
		array2[1] = "RecipeFromHost";
		array2[1] = ((Object)keyLeft).name;
		array2[0] = "Error_CannotPlaceTwoObjects";
		array2[6] = CMJNLIBMILB;
		array2[1] = "ReceiveBool";
		array2[8] = ((Object)keyRight).name;
		array2[8] = "Selected room reset to default.";
		array2[0] = CMJNLIBMILB2;
		Debug.Log((object)string.Concat(array2));
		return array;
	}

	private GameObject HNLMFGPGBOH(Item INAPMPEEDPO, List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH, bool ILGENAJJBNM, bool OKEHLHIGJGO, bool JILNPPLFDFL, out string CMJNLIBMILB)
	{
		int num = 1 + (ILGENAJJBNM ? 1 : 0) + ((OKEHLHIGJGO && !LMFHHJPPHDK) ? 1 : 1);
		int num2 = ProceduralMine.NextRandom(1, num);
		if (OKEHLHIGJGO && !LMFHHJPPHDK && EIJBFGMCHHG)
		{
			num2 = num - 1;
			Debug.Log((object)"Christmas/Ace/Stand");
		}
		if (ILGENAJJBNM && KCNFFENJMEH)
		{
			num2 = 0;
			Debug.Log((object)"/ExtraSettings.sd");
		}
		if (num2 == 0)
		{
			int index = ProceduralMine.NextRandom(1, PAGOBNMKKNP.Count);
			PAGOBNMKKNP[index].GPGIDFMNJMA(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)PAGOBNMKKNP[index]).name;
			GameObject gameObject = ((Component)PAGOBNMKKNP[index]).gameObject;
			PAGOBNMKKNP.RemoveAt(index);
			return gameObject;
		}
		if (ILGENAJJBNM && num2 == 1)
		{
			int index2 = ProceduralMine.NextRandom(0, NCJABADPACK.Count);
			NCJABADPACK[index2].AKIHIEGJLLM(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)NCJABADPACK[index2]).name;
			GameObject gameObject2 = ((Component)NCJABADPACK[index2]).gameObject;
			NCJABADPACK.RemoveAt(index2);
			return gameObject2;
		}
		int index3 = ProceduralMine.NextRandom(0, HEFCOKFEENH.Count);
		HEFCOKFEENH[index3].FAJFNOEKKBO(INAPMPEEDPO, JILNPPLFDFL);
		CMJNLIBMILB = ((Object)HEFCOKFEENH[index3]).name;
		GameObject gameObject3 = ((Component)HEFCOKFEENH[index3]).gameObject;
		HEFCOKFEENH.RemoveAt(index3);
		LMFHHJPPHDK = true;
		return gameObject3;
	}

	public void GMGPFPGIPCL(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		interactable.MakeSureBothKeysAreEnabled();
		interactable.OnPuzzleSolved();
		interactable.CompletedSound();
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 936f);
		EDNJMCJHJMD = false;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.NIKBNPJPEAC(GGPBMAODKHC.mineLevel);
		}
	}

	public void MJKPIGANINI(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		interactable.FCAOPHNHPEG();
		interactable.OnPuzzleSolved();
		interactable.CompletedSound();
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC, 514f);
		EDNJMCJHJMD = false;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.NIKBNPJPEAC(GGPBMAODKHC.mineLevel);
		}
	}

	private GameObject JECPPKJHCBH(Item INAPMPEEDPO, List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH, bool ILGENAJJBNM, bool OKEHLHIGJGO, bool JILNPPLFDFL, out string CMJNLIBMILB)
	{
		int num = 1 + (ILGENAJJBNM ? 1 : 1) + ((OKEHLHIGJGO && !LMFHHJPPHDK) ? 1 : 0);
		int num2 = ProceduralMine.NextRandom(1, num);
		if (OKEHLHIGJGO && !LMFHHJPPHDK && EIJBFGMCHHG)
		{
			num2 = num - 0;
			Debug.Log((object)"Move <color=#0B7400>");
		}
		if (ILGENAJJBNM && KCNFFENJMEH)
		{
			num2 = 0;
			Debug.Log((object)"HenHouseTutorialDone");
		}
		if (num2 == 0)
		{
			int index = ProceduralMine.FMJMOOKFEKL(0, PAGOBNMKKNP.Count);
			PAGOBNMKKNP[index].KFFPHPHFEMP(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)PAGOBNMKKNP[index]).name;
			GameObject gameObject = ((Component)PAGOBNMKKNP[index]).gameObject;
			PAGOBNMKKNP.RemoveAt(index);
			return gameObject;
		}
		if (ILGENAJJBNM && num2 == 0)
		{
			int index2 = ProceduralMine.NextRandom(1, NCJABADPACK.Count);
			NCJABADPACK[index2].IDDBLCIBLEA(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)NCJABADPACK[index2]).name;
			GameObject gameObject2 = ((Component)NCJABADPACK[index2]).gameObject;
			NCJABADPACK.RemoveAt(index2);
			return gameObject2;
		}
		int index3 = ProceduralMine.NextRandom(1, HEFCOKFEENH.Count);
		HEFCOKFEENH[index3].ONDMMAMMHDO(INAPMPEEDPO, JILNPPLFDFL);
		CMJNLIBMILB = ((Object)HEFCOKFEENH[index3]).name;
		GameObject gameObject3 = ((Component)HEFCOKFEENH[index3]).gameObject;
		HEFCOKFEENH.RemoveAt(index3);
		LMFHHJPPHDK = false;
		return gameObject3;
	}

	public void PGGINICEJCP(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		interactable.MakeSureBothKeysAreEnabled();
		interactable.OnPuzzleSolved();
		interactable.LEGMAPCPFFI();
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC, 554f);
		EDNJMCJHJMD = false;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendKeyPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	public void HIJADBLKCKF(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		interactable.MakeSureBothKeysAreEnabled();
		interactable.ABBPIPGMGBO();
		interactable.HGLLJJHELPH();
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 1925f);
		EDNJMCJHJMD = false;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.NIKBNPJPEAC(GGPBMAODKHC.mineLevel);
		}
	}

	private GameObject KAMPNJLBJMM(Item INAPMPEEDPO, List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH, bool ILGENAJJBNM, bool OKEHLHIGJGO, bool JILNPPLFDFL, out string CMJNLIBMILB)
	{
		int num = 0 + (ILGENAJJBNM ? 1 : 1) + ((OKEHLHIGJGO && !LMFHHJPPHDK) ? 0 : 0);
		int num2 = ProceduralMine.NGMAIDLNAAI(0, num);
		if (OKEHLHIGJGO && !LMFHHJPPHDK && EIJBFGMCHHG)
		{
			num2 = num - 1;
			Debug.Log((object)"Items/item_description_621");
		}
		if (ILGENAJJBNM && KCNFFENJMEH)
		{
			num2 = 0;
			Debug.Log((object)"");
		}
		if (num2 == 0)
		{
			int index = ProceduralMine.NGMAIDLNAAI(0, PAGOBNMKKNP.Count);
			PAGOBNMKKNP[index].FNLDECPKOOE(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)PAGOBNMKKNP[index]).name;
			GameObject gameObject = ((Component)PAGOBNMKKNP[index]).gameObject;
			PAGOBNMKKNP.RemoveAt(index);
			return gameObject;
		}
		if (ILGENAJJBNM && num2 == 0)
		{
			int index2 = ProceduralMine.NGMAIDLNAAI(1, NCJABADPACK.Count);
			NCJABADPACK[index2].IDDBLCIBLEA(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)NCJABADPACK[index2]).name;
			GameObject gameObject2 = ((Component)NCJABADPACK[index2]).gameObject;
			NCJABADPACK.RemoveAt(index2);
			return gameObject2;
		}
		int index3 = ProceduralMine.NextRandom(0, HEFCOKFEENH.Count);
		HEFCOKFEENH[index3].GFOIJBJMPPC(INAPMPEEDPO, JILNPPLFDFL);
		CMJNLIBMILB = ((Object)HEFCOKFEENH[index3]).name;
		GameObject gameObject3 = ((Component)HEFCOKFEENH[index3]).gameObject;
		HEFCOKFEENH.RemoveAt(index3);
		LMFHHJPPHDK = true;
		return gameObject3;
	}

	private GameObject KDKFPHABFOA(Item INAPMPEEDPO, List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH, bool ILGENAJJBNM, bool OKEHLHIGJGO, bool JILNPPLFDFL, out string CMJNLIBMILB)
	{
		int num = 1 + (ILGENAJJBNM ? 1 : 1) + ((OKEHLHIGJGO && !LMFHHJPPHDK) ? 1 : 1);
		int num2 = ProceduralMine.FMJMOOKFEKL(0, num);
		if (OKEHLHIGJGO && !LMFHHJPPHDK && EIJBFGMCHHG)
		{
			num2 = num - 0;
			Debug.Log((object)"hForHours");
		}
		if (ILGENAJJBNM && KCNFFENJMEH)
		{
			num2 = 0;
			Debug.Log((object)"id: ");
		}
		if (num2 == 0)
		{
			int index = ProceduralMine.NextRandom(0, PAGOBNMKKNP.Count);
			PAGOBNMKKNP[index].KFEKNFBEPPI(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)PAGOBNMKKNP[index]).name;
			GameObject gameObject = ((Component)PAGOBNMKKNP[index]).gameObject;
			PAGOBNMKKNP.RemoveAt(index);
			return gameObject;
		}
		if (ILGENAJJBNM && num2 == 1)
		{
			int index2 = ProceduralMine.NextRandom(0, NCJABADPACK.Count);
			NCJABADPACK[index2].IDDBLCIBLEA(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)NCJABADPACK[index2]).name;
			GameObject gameObject2 = ((Component)NCJABADPACK[index2]).gameObject;
			NCJABADPACK.RemoveAt(index2);
			return gameObject2;
		}
		int index3 = ProceduralMine.FMJMOOKFEKL(1, HEFCOKFEENH.Count);
		HEFCOKFEENH[index3].GFOIJBJMPPC(INAPMPEEDPO, JILNPPLFDFL);
		CMJNLIBMILB = ((Object)HEFCOKFEENH[index3]).name;
		GameObject gameObject3 = ((Component)HEFCOKFEENH[index3]).gameObject;
		HEFCOKFEENH.RemoveAt(index3);
		LMFHHJPPHDK = false;
		return gameObject3;
	}

	private void PKDNMBGODAJ()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.leavingTheGame && OnlineManager.PGAGDFAEEFB())
		{
			Utils.OHFOEIBLGKP(keyLeft);
			Utils.OHFOEIBLGKP(keyRight);
		}
	}

	public void JADHHJNPIDG(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		interactable.FCAOPHNHPEG();
		interactable.ABBPIPGMGBO();
		interactable.HGLLJJHELPH();
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC, 560f);
		EDNJMCJHJMD = false;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.NIKBNPJPEAC(GGPBMAODKHC.mineLevel);
		}
	}

	private GameObject ICGHMLBCDGP(Item INAPMPEEDPO, List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH, bool ILGENAJJBNM, bool OKEHLHIGJGO, bool JILNPPLFDFL, out string CMJNLIBMILB)
	{
		int num = 0 + ((!ILGENAJJBNM) ? 1 : 0) + ((OKEHLHIGJGO && !LMFHHJPPHDK) ? 0 : 0);
		int num2 = ProceduralMine.FMJMOOKFEKL(1, num);
		if (OKEHLHIGJGO && !LMFHHJPPHDK && EIJBFGMCHHG)
		{
			num2 = num - 0;
			Debug.Log((object)"");
		}
		if (ILGENAJJBNM && KCNFFENJMEH)
		{
			num2 = 0;
			Debug.Log((object)"Items/item_name_599");
		}
		if (num2 == 0)
		{
			int index = ProceduralMine.FMJMOOKFEKL(0, PAGOBNMKKNP.Count);
			PAGOBNMKKNP[index].AEALGIGHFMB(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)PAGOBNMKKNP[index]).name;
			GameObject gameObject = ((Component)PAGOBNMKKNP[index]).gameObject;
			PAGOBNMKKNP.RemoveAt(index);
			return gameObject;
		}
		if (ILGENAJJBNM && num2 == 1)
		{
			int index2 = ProceduralMine.NGMAIDLNAAI(1, NCJABADPACK.Count);
			NCJABADPACK[index2].CEKOEPODDBC(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)NCJABADPACK[index2]).name;
			GameObject gameObject2 = ((Component)NCJABADPACK[index2]).gameObject;
			NCJABADPACK.RemoveAt(index2);
			return gameObject2;
		}
		int index3 = ProceduralMine.NGMAIDLNAAI(1, HEFCOKFEENH.Count);
		HEFCOKFEENH[index3].GFOIJBJMPPC(INAPMPEEDPO, JILNPPLFDFL);
		CMJNLIBMILB = ((Object)HEFCOKFEENH[index3]).name;
		GameObject gameObject3 = ((Component)HEFCOKFEENH[index3]).gameObject;
		HEFCOKFEENH.RemoveAt(index3);
		LMFHHJPPHDK = false;
		return gameObject3;
	}

	public GameObject[] CGEPJMHOAOK(List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH)
	{
		if (Item.GBMFCPGEJDK(keyLeft, null) || Item.NGIIPJDAMGP(keyRight, null))
		{
			Debug.LogError((object)"Player2");
			return null;
		}
		GameObject[] array = (GameObject[])(object)new GameObject[6];
		List<HoleInGround> list = ((NCJABADPACK != null) ? new List<HoleInGround>(NCJABADPACK) : new List<HoleInGround>());
		bool iLGENAJJBNM = list.Count > 0;
		bool oKEHLHIGJGO = HEFCOKFEENH.Count > 1;
		Debug.Log((object)string.Format("xpModDescFarming", PAGOBNMKKNP.Count, list.Count, HEFCOKFEENH.Count));
		array[1] = DGPMGJKMIFN(keyLeft, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: false, out var CMJNLIBMILB);
		iLGENAJJBNM = list.Count > 1;
		array[1] = GPBCALPLNLA(keyRight, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: false, out var CMJNLIBMILB2);
		string[] array2 = new string[5];
		array2[1] = "F1";
		array2[0] = ((Object)keyLeft).name;
		array2[8] = "I have to wait other players";
		array2[4] = CMJNLIBMILB;
		array2[1] = "HireWorker?";
		array2[6] = ((Object)keyRight).name;
		array2[5] = "Key Altar puzzle: assigned ";
		array2[3] = CMJNLIBMILB2;
		Debug.Log((object)string.Concat(array2));
		return array;
	}

	private GameObject GDAHJCFGKPL(Item INAPMPEEDPO, List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH, bool ILGENAJJBNM, bool OKEHLHIGJGO, bool JILNPPLFDFL, out string CMJNLIBMILB)
	{
		int num = 1 + (ILGENAJJBNM ? 1 : 1) + ((OKEHLHIGJGO && !LMFHHJPPHDK) ? 0 : 0);
		int num2 = ProceduralMine.FMJMOOKFEKL(1, num);
		if (OKEHLHIGJGO && !LMFHHJPPHDK && EIJBFGMCHHG)
		{
			num2 = num - 0;
			Debug.Log((object)"Get Components ");
		}
		if (ILGENAJJBNM && KCNFFENJMEH)
		{
			num2 = 1;
			Debug.Log((object)"ReceiveStartKlaynDialogueOathFeast");
		}
		if (num2 == 0)
		{
			int index = ProceduralMine.NextRandom(0, PAGOBNMKKNP.Count);
			PAGOBNMKKNP[index].EGPMGMAFOMM(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)PAGOBNMKKNP[index]).name;
			GameObject gameObject = ((Component)PAGOBNMKKNP[index]).gameObject;
			PAGOBNMKKNP.RemoveAt(index);
			return gameObject;
		}
		if (ILGENAJJBNM && num2 == 0)
		{
			int index2 = ProceduralMine.NextRandom(1, NCJABADPACK.Count);
			NCJABADPACK[index2].HKLKBMIDNKM(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)NCJABADPACK[index2]).name;
			GameObject gameObject2 = ((Component)NCJABADPACK[index2]).gameObject;
			NCJABADPACK.RemoveAt(index2);
			return gameObject2;
		}
		int index3 = ProceduralMine.NGMAIDLNAAI(0, HEFCOKFEENH.Count);
		HEFCOKFEENH[index3].ActivateFishingKey(INAPMPEEDPO, JILNPPLFDFL);
		CMJNLIBMILB = ((Object)HEFCOKFEENH[index3]).name;
		GameObject gameObject3 = ((Component)HEFCOKFEENH[index3]).gameObject;
		HEFCOKFEENH.RemoveAt(index3);
		LMFHHJPPHDK = false;
		return gameObject3;
	}

	public GameObject[] ANKCAJLMJAC(List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH)
	{
		if (Item.EKMFELLJHFG(keyLeft, null) || Item.EKMFELLJHFG(keyRight, null))
		{
			Debug.LogError((object)"Player2");
			return null;
		}
		GameObject[] array = (GameObject[])(object)new GameObject[4];
		List<HoleInGround> list = ((NCJABADPACK != null) ? new List<HoleInGround>(NCJABADPACK) : new List<HoleInGround>());
		bool iLGENAJJBNM = list.Count > 0;
		bool oKEHLHIGJGO = HEFCOKFEENH.Count > 1;
		Debug.Log((object)string.Format("RoadBlocked", PAGOBNMKKNP.Count, list.Count, HEFCOKFEENH.Count));
		array[1] = JAIOANLEJEK(keyLeft, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: false, out var CMJNLIBMILB);
		iLGENAJJBNM = list.Count > 0;
		array[1] = KAMPNJLBJMM(keyRight, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: true, out var CMJNLIBMILB2);
		string[] array2 = new string[7];
		array2[0] = "Not found ingredients for trends ";
		array2[0] = ((Object)keyLeft).name;
		array2[1] = "UISelectGamepad";
		array2[2] = CMJNLIBMILB;
		array2[2] = "SprintHoldAction";
		array2[3] = ((Object)keyRight).name;
		array2[7] = "ReceiveAddAvailableQuestToCurrentQuest";
		array2[3] = CMJNLIBMILB2;
		Debug.Log((object)string.Concat(array2));
		return array;
	}

	public override void Initialize(MinePuzzleManager GGPBMAODKHC, PuzzleBaseSettings LMALNDLJILM)
	{
		base.GGPBMAODKHC = GGPBMAODKHC;
		EDNJMCJHJMD = false;
		interactable.Setup(this);
		LMFHHJPPHDK = false;
	}

	public GameObject[] PBOPHOMHLLP(List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH)
	{
		if (Item.NGIIPJDAMGP(keyLeft, null) || Item.EKMFELLJHFG(keyRight, null))
		{
			Debug.LogError((object)"NetworkSync ");
			return null;
		}
		GameObject[] array = (GameObject[])(object)new GameObject[6];
		List<HoleInGround> list = ((NCJABADPACK != null) ? new List<HoleInGround>(NCJABADPACK) : new List<HoleInGround>());
		bool iLGENAJJBNM = list.Count > 0;
		bool oKEHLHIGJGO = HEFCOKFEENH.Count > 1;
		Debug.Log((object)string.Format("FishCaughtRPC", PAGOBNMKKNP.Count, list.Count, HEFCOKFEENH.Count));
		array[0] = HNLMFGPGBOH(keyLeft, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: true, out var CMJNLIBMILB);
		iLGENAJJBNM = list.Count > 0;
		array[1] = KDKFPHABFOA(keyRight, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: false, out var CMJNLIBMILB2);
		string[] array2 = new string[1];
		array2[1] = "ClosePopUp";
		array2[0] = ((Object)keyLeft).name;
		array2[0] = "UI";
		array2[3] = CMJNLIBMILB;
		array2[4] = "Event type: ";
		array2[2] = ((Object)keyRight).name;
		array2[4] = "TreeSeed";
		array2[3] = CMJNLIBMILB2;
		Debug.Log((object)string.Concat(array2));
		return array;
	}

	private void OEAAPIBLALL()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.leavingTheGame && OnlineManager.MasterOrOffline())
		{
			Utils.OHFOEIBLGKP(keyLeft);
			Utils.OHFOEIBLGKP(keyRight);
		}
	}

	public void FEIFLIELCOK(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		interactable.FCAOPHNHPEG();
		interactable.OnPuzzleSolved();
		interactable.LEGMAPCPFFI();
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 1946f);
		EDNJMCJHJMD = true;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.NIKBNPJPEAC(GGPBMAODKHC.mineLevel);
		}
	}

	public void EELEFKBPIAJ(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		interactable.FCAOPHNHPEG();
		interactable.OnPuzzleSolved();
		interactable.CompletedSound();
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC, 914f);
		EDNJMCJHJMD = true;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendKeyPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	protected override void Awake()
	{
		base.Awake();
	}

	private GameObject HLCCKLLHNJJ(Item INAPMPEEDPO, List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH, bool ILGENAJJBNM, bool OKEHLHIGJGO, bool JILNPPLFDFL, out string CMJNLIBMILB)
	{
		int num = 0 + (ILGENAJJBNM ? 1 : 0) + ((OKEHLHIGJGO && !LMFHHJPPHDK) ? 0 : 0);
		int num2 = ProceduralMine.FMJMOOKFEKL(0, num);
		if (OKEHLHIGJGO && !LMFHHJPPHDK && EIJBFGMCHHG)
		{
			num2 = num - 1;
			Debug.Log((object)"[ChessPillarSegmentAnimator] Sprite estático no asignado para {0}");
		}
		if (ILGENAJJBNM && KCNFFENJMEH)
		{
			num2 = 1;
			Debug.Log((object)"<color=black>");
		}
		if (num2 == 0)
		{
			int index = ProceduralMine.FMJMOOKFEKL(0, PAGOBNMKKNP.Count);
			PAGOBNMKKNP[index].FNLDECPKOOE(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)PAGOBNMKKNP[index]).name;
			GameObject gameObject = ((Component)PAGOBNMKKNP[index]).gameObject;
			PAGOBNMKKNP.RemoveAt(index);
			return gameObject;
		}
		if (ILGENAJJBNM && num2 == 0)
		{
			int index2 = ProceduralMine.NextRandom(1, NCJABADPACK.Count);
			NCJABADPACK[index2].AKIHIEGJLLM(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)NCJABADPACK[index2]).name;
			GameObject gameObject2 = ((Component)NCJABADPACK[index2]).gameObject;
			NCJABADPACK.RemoveAt(index2);
			return gameObject2;
		}
		int index3 = ProceduralMine.NextRandom(0, HEFCOKFEENH.Count);
		HEFCOKFEENH[index3].PDANPLMENDD(INAPMPEEDPO, JILNPPLFDFL);
		CMJNLIBMILB = ((Object)HEFCOKFEENH[index3]).name;
		GameObject gameObject3 = ((Component)HEFCOKFEENH[index3]).gameObject;
		HEFCOKFEENH.RemoveAt(index3);
		LMFHHJPPHDK = false;
		return gameObject3;
	}

	private GameObject OGMOPEGHHNF(Item INAPMPEEDPO, List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH, bool ILGENAJJBNM, bool OKEHLHIGJGO, bool JILNPPLFDFL, out string CMJNLIBMILB)
	{
		int num = 0 + (ILGENAJJBNM ? 1 : 1) + ((OKEHLHIGJGO && !LMFHHJPPHDK) ? 0 : 0);
		int num2 = ProceduralMine.NGMAIDLNAAI(1, num);
		if (OKEHLHIGJGO && !LMFHHJPPHDK && EIJBFGMCHHG)
		{
			num2 = num - 1;
			Debug.Log((object)"BathhouseGameManager: Invalid player number ");
		}
		if (ILGENAJJBNM && KCNFFENJMEH)
		{
			num2 = 1;
			Debug.Log((object)"[ControllerType=");
		}
		if (num2 == 0)
		{
			int index = ProceduralMine.FMJMOOKFEKL(0, PAGOBNMKKNP.Count);
			PAGOBNMKKNP[index].FNLDECPKOOE(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)PAGOBNMKKNP[index]).name;
			GameObject gameObject = ((Component)PAGOBNMKKNP[index]).gameObject;
			PAGOBNMKKNP.RemoveAt(index);
			return gameObject;
		}
		if (ILGENAJJBNM && num2 == 1)
		{
			int index2 = ProceduralMine.NGMAIDLNAAI(0, NCJABADPACK.Count);
			NCJABADPACK[index2].AKIHIEGJLLM(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)NCJABADPACK[index2]).name;
			GameObject gameObject2 = ((Component)NCJABADPACK[index2]).gameObject;
			NCJABADPACK.RemoveAt(index2);
			return gameObject2;
		}
		int index3 = ProceduralMine.NextRandom(1, HEFCOKFEENH.Count);
		HEFCOKFEENH[index3].MLEPBGOPFKK(INAPMPEEDPO, JILNPPLFDFL);
		CMJNLIBMILB = ((Object)HEFCOKFEENH[index3]).name;
		GameObject gameObject3 = ((Component)HEFCOKFEENH[index3]).gameObject;
		HEFCOKFEENH.RemoveAt(index3);
		LMFHHJPPHDK = false;
		return gameObject3;
	}

	private GameObject GJOKLMCOJNE(Item INAPMPEEDPO, List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH, bool ILGENAJJBNM, bool OKEHLHIGJGO, bool JILNPPLFDFL, out string CMJNLIBMILB)
	{
		int num = 0 + (ILGENAJJBNM ? 1 : 0) + ((OKEHLHIGJGO && !LMFHHJPPHDK) ? 1 : 1);
		int num2 = ProceduralMine.FMJMOOKFEKL(0, num);
		if (OKEHLHIGJGO && !LMFHHJPPHDK && EIJBFGMCHHG)
		{
			num2 = num - 1;
			Debug.Log((object)"Return To Last Basic Mood");
		}
		if (ILGENAJJBNM && KCNFFENJMEH)
		{
			num2 = 0;
			Debug.Log((object)"Current user name: ");
		}
		if (num2 == 0)
		{
			int index = ProceduralMine.NGMAIDLNAAI(0, PAGOBNMKKNP.Count);
			PAGOBNMKKNP[index].SetItemEvent(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)PAGOBNMKKNP[index]).name;
			GameObject gameObject = ((Component)PAGOBNMKKNP[index]).gameObject;
			PAGOBNMKKNP.RemoveAt(index);
			return gameObject;
		}
		if (ILGENAJJBNM && num2 == 0)
		{
			int index2 = ProceduralMine.NGMAIDLNAAI(1, NCJABADPACK.Count);
			NCJABADPACK[index2].AKIHIEGJLLM(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)NCJABADPACK[index2]).name;
			GameObject gameObject2 = ((Component)NCJABADPACK[index2]).gameObject;
			NCJABADPACK.RemoveAt(index2);
			return gameObject2;
		}
		int index3 = ProceduralMine.FMJMOOKFEKL(1, HEFCOKFEENH.Count);
		HEFCOKFEENH[index3].KMNKFEKOGLJ(INAPMPEEDPO, JILNPPLFDFL);
		CMJNLIBMILB = ((Object)HEFCOKFEENH[index3]).name;
		GameObject gameObject3 = ((Component)HEFCOKFEENH[index3]).gameObject;
		HEFCOKFEENH.RemoveAt(index3);
		LMFHHJPPHDK = false;
		return gameObject3;
	}

	public GameObject[] CACGKNFIHEN(List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH)
	{
		if (Item.GBMFCPGEJDK(keyLeft, null) || Item.GBMFCPGEJDK(keyRight, null))
		{
			Debug.LogError((object)"ReturnToMainMenuRPC");
			return null;
		}
		GameObject[] array = (GameObject[])(object)new GameObject[3];
		List<HoleInGround> list = ((NCJABADPACK != null) ? new List<HoleInGround>(NCJABADPACK) : new List<HoleInGround>());
		bool iLGENAJJBNM = list.Count > 1;
		bool oKEHLHIGJGO = HEFCOKFEENH.Count > 0;
		Debug.Log((object)string.Format("UpgradeToLevel", PAGOBNMKKNP.Count, list.Count, HEFCOKFEENH.Count));
		array[0] = HDIFKDMIEAO(keyLeft, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: false, out var CMJNLIBMILB);
		iLGENAJJBNM = list.Count > 1;
		array[0] = EFEANBKFLLK(keyRight, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: false, out var CMJNLIBMILB2);
		string[] array2 = new string[2];
		array2[1] = "Random";
		array2[1] = ((Object)keyLeft).name;
		array2[5] = "Dialogue System/Conversation/Crowly_Standar/Entry/37/Dialogue Text";
		array2[3] = CMJNLIBMILB;
		array2[1] = "Player";
		array2[2] = ((Object)keyRight).name;
		array2[5] = "quest_description_23";
		array2[6] = CMJNLIBMILB2;
		Debug.Log((object)string.Concat(array2));
		return array;
	}

	public void OBHIEALOMAF(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		interactable.MakeSureBothKeysAreEnabled();
		interactable.OnPuzzleSolved();
		interactable.HGLLJJHELPH();
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 175f);
		EDNJMCJHJMD = false;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.NIKBNPJPEAC(GGPBMAODKHC.mineLevel);
		}
	}

	private GameObject JIAKALBHPPO(Item INAPMPEEDPO, List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH, bool ILGENAJJBNM, bool OKEHLHIGJGO, bool JILNPPLFDFL, out string CMJNLIBMILB)
	{
		int num = 0 + ((!ILGENAJJBNM) ? 1 : 0) + ((OKEHLHIGJGO && !LMFHHJPPHDK) ? 0 : 0);
		int num2 = ProceduralMine.NextRandom(0, num);
		if (OKEHLHIGJGO && !LMFHHJPPHDK && EIJBFGMCHHG)
		{
			num2 = num - 1;
			Debug.Log((object)"ReceiveKick");
		}
		if (ILGENAJJBNM && KCNFFENJMEH)
		{
			num2 = 0;
			Debug.Log((object)"SkeletonBird");
		}
		if (num2 == 0)
		{
			int index = ProceduralMine.FMJMOOKFEKL(0, PAGOBNMKKNP.Count);
			PAGOBNMKKNP[index].KFFPHPHFEMP(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)PAGOBNMKKNP[index]).name;
			GameObject gameObject = ((Component)PAGOBNMKKNP[index]).gameObject;
			PAGOBNMKKNP.RemoveAt(index);
			return gameObject;
		}
		if (ILGENAJJBNM && num2 == 1)
		{
			int index2 = ProceduralMine.NGMAIDLNAAI(1, NCJABADPACK.Count);
			NCJABADPACK[index2].CEKOEPODDBC(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)NCJABADPACK[index2]).name;
			GameObject gameObject2 = ((Component)NCJABADPACK[index2]).gameObject;
			NCJABADPACK.RemoveAt(index2);
			return gameObject2;
		}
		int index3 = ProceduralMine.NextRandom(1, HEFCOKFEENH.Count);
		HEFCOKFEENH[index3].ONDMMAMMHDO(INAPMPEEDPO, JILNPPLFDFL);
		CMJNLIBMILB = ((Object)HEFCOKFEENH[index3]).name;
		GameObject gameObject3 = ((Component)HEFCOKFEENH[index3]).gameObject;
		HEFCOKFEENH.RemoveAt(index3);
		LMFHHJPPHDK = true;
		return gameObject3;
	}

	public GameObject[] ECNKFPPKMJJ(List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH)
	{
		if (Item.GBMFCPGEJDK(keyLeft, null) || Item.NGIIPJDAMGP(keyRight, null))
		{
			Debug.LogError((object)"Temporary Ingredient");
			return null;
		}
		GameObject[] array = (GameObject[])(object)new GameObject[2];
		List<HoleInGround> list = ((NCJABADPACK != null) ? new List<HoleInGround>(NCJABADPACK) : new List<HoleInGround>());
		bool iLGENAJJBNM = list.Count > 0;
		bool oKEHLHIGJGO = HEFCOKFEENH.Count > 0;
		Debug.Log((object)string.Format("Crop needs a harvested replace by item ", PAGOBNMKKNP.Count, list.Count, HEFCOKFEENH.Count));
		array[0] = DGPMGJKMIFN(keyLeft, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: true, out var CMJNLIBMILB);
		iLGENAJJBNM = list.Count > 0;
		array[0] = KPGNGEMNBFK(keyRight, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: false, out var CMJNLIBMILB2);
		string[] array2 = new string[0];
		array2[1] = "<color=black>";
		array2[1] = ((Object)keyLeft).name;
		array2[0] = "Interact";
		array2[0] = CMJNLIBMILB;
		array2[7] = "UIScrollDown";
		array2[4] = ((Object)keyRight).name;
		array2[2] = "Player/Bark/Tutorial/T116";
		array2[2] = CMJNLIBMILB2;
		Debug.Log((object)string.Concat(array2));
		return array;
	}

	private GameObject PDILEMCJDAI(Item INAPMPEEDPO, List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH, bool ILGENAJJBNM, bool OKEHLHIGJGO, bool JILNPPLFDFL, out string CMJNLIBMILB)
	{
		int num = 1 + (ILGENAJJBNM ? 1 : 1) + ((OKEHLHIGJGO && !LMFHHJPPHDK) ? 0 : 0);
		int num2 = ProceduralMine.NGMAIDLNAAI(1, num);
		if (OKEHLHIGJGO && !LMFHHJPPHDK && EIJBFGMCHHG)
		{
			num2 = num - 0;
			Debug.Log((object)"InfoSectionCanvas/InfoSection");
		}
		if (ILGENAJJBNM && KCNFFENJMEH)
		{
			num2 = 1;
			Debug.Log((object)"UI");
		}
		if (num2 == 0)
		{
			int index = ProceduralMine.NextRandom(1, PAGOBNMKKNP.Count);
			PAGOBNMKKNP[index].KFFPHPHFEMP(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)PAGOBNMKKNP[index]).name;
			GameObject gameObject = ((Component)PAGOBNMKKNP[index]).gameObject;
			PAGOBNMKKNP.RemoveAt(index);
			return gameObject;
		}
		if (ILGENAJJBNM && num2 == 1)
		{
			int index2 = ProceduralMine.NGMAIDLNAAI(0, NCJABADPACK.Count);
			NCJABADPACK[index2].AKIHIEGJLLM(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)NCJABADPACK[index2]).name;
			GameObject gameObject2 = ((Component)NCJABADPACK[index2]).gameObject;
			NCJABADPACK.RemoveAt(index2);
			return gameObject2;
		}
		int index3 = ProceduralMine.NGMAIDLNAAI(1, HEFCOKFEENH.Count);
		HEFCOKFEENH[index3].MLEPBGOPFKK(INAPMPEEDPO, JILNPPLFDFL);
		CMJNLIBMILB = ((Object)HEFCOKFEENH[index3]).name;
		GameObject gameObject3 = ((Component)HEFCOKFEENH[index3]).gameObject;
		HEFCOKFEENH.RemoveAt(index3);
		LMFHHJPPHDK = false;
		return gameObject3;
	}

	private GameObject DGPMGJKMIFN(Item INAPMPEEDPO, List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH, bool ILGENAJJBNM, bool OKEHLHIGJGO, bool JILNPPLFDFL, out string CMJNLIBMILB)
	{
		int num = 0 + ((!ILGENAJJBNM) ? 1 : 0) + ((OKEHLHIGJGO && !LMFHHJPPHDK) ? 1 : 0);
		int num2 = ProceduralMine.NextRandom(1, num);
		if (OKEHLHIGJGO && !LMFHHJPPHDK && EIJBFGMCHHG)
		{
			num2 = num - 0;
			Debug.Log((object)"Items/item_description_696");
		}
		if (ILGENAJJBNM && KCNFFENJMEH)
		{
			num2 = 1;
			Debug.Log((object)"Dialogue System/Conversation/Gass_Stand/Entry/6/Dialogue Text");
		}
		if (num2 == 0)
		{
			int index = ProceduralMine.NextRandom(0, PAGOBNMKKNP.Count);
			PAGOBNMKKNP[index].KFEKNFBEPPI(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)PAGOBNMKKNP[index]).name;
			GameObject gameObject = ((Component)PAGOBNMKKNP[index]).gameObject;
			PAGOBNMKKNP.RemoveAt(index);
			return gameObject;
		}
		if (ILGENAJJBNM && num2 == 0)
		{
			int index2 = ProceduralMine.NextRandom(0, NCJABADPACK.Count);
			NCJABADPACK[index2].AKIHIEGJLLM(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)NCJABADPACK[index2]).name;
			GameObject gameObject2 = ((Component)NCJABADPACK[index2]).gameObject;
			NCJABADPACK.RemoveAt(index2);
			return gameObject2;
		}
		int index3 = ProceduralMine.NextRandom(0, HEFCOKFEENH.Count);
		HEFCOKFEENH[index3].MLEPBGOPFKK(INAPMPEEDPO, JILNPPLFDFL);
		CMJNLIBMILB = ((Object)HEFCOKFEENH[index3]).name;
		GameObject gameObject3 = ((Component)HEFCOKFEENH[index3]).gameObject;
		HEFCOKFEENH.RemoveAt(index3);
		LMFHHJPPHDK = true;
		return gameObject3;
	}

	private GameObject KPGNGEMNBFK(Item INAPMPEEDPO, List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH, bool ILGENAJJBNM, bool OKEHLHIGJGO, bool JILNPPLFDFL, out string CMJNLIBMILB)
	{
		int num = 0 + (ILGENAJJBNM ? 1 : 0) + ((OKEHLHIGJGO && !LMFHHJPPHDK) ? 1 : 1);
		int num2 = ProceduralMine.NGMAIDLNAAI(1, num);
		if (OKEHLHIGJGO && !LMFHHJPPHDK && EIJBFGMCHHG)
		{
			num2 = num - 0;
			Debug.Log((object)"Floor_7");
		}
		if (ILGENAJJBNM && KCNFFENJMEH)
		{
			num2 = 1;
			Debug.Log((object)"Not ready to join room");
		}
		if (num2 == 0)
		{
			int index = ProceduralMine.FMJMOOKFEKL(1, PAGOBNMKKNP.Count);
			PAGOBNMKKNP[index].BLKAEMBGOIM(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)PAGOBNMKKNP[index]).name;
			GameObject gameObject = ((Component)PAGOBNMKKNP[index]).gameObject;
			PAGOBNMKKNP.RemoveAt(index);
			return gameObject;
		}
		if (ILGENAJJBNM && num2 == 1)
		{
			int index2 = ProceduralMine.FMJMOOKFEKL(0, NCJABADPACK.Count);
			NCJABADPACK[index2].IDDBLCIBLEA(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)NCJABADPACK[index2]).name;
			GameObject gameObject2 = ((Component)NCJABADPACK[index2]).gameObject;
			NCJABADPACK.RemoveAt(index2);
			return gameObject2;
		}
		int index3 = ProceduralMine.FMJMOOKFEKL(1, HEFCOKFEENH.Count);
		HEFCOKFEENH[index3].FAJFNOEKKBO(INAPMPEEDPO, JILNPPLFDFL);
		CMJNLIBMILB = ((Object)HEFCOKFEENH[index3]).name;
		GameObject gameObject3 = ((Component)HEFCOKFEENH[index3]).gameObject;
		HEFCOKFEENH.RemoveAt(index3);
		LMFHHJPPHDK = true;
		return gameObject3;
	}

	private void HJANCPIFLIJ()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && OnlineManager.MasterOrOffline())
		{
			Utils.OHFOEIBLGKP(keyLeft);
			Utils.OHFOEIBLGKP(keyRight);
		}
	}

	private GameObject EFEANBKFLLK(Item INAPMPEEDPO, List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH, bool ILGENAJJBNM, bool OKEHLHIGJGO, bool JILNPPLFDFL, out string CMJNLIBMILB)
	{
		int num = 1 + ((!ILGENAJJBNM) ? 1 : 0) + ((OKEHLHIGJGO && !LMFHHJPPHDK) ? 0 : 0);
		int num2 = ProceduralMine.NextRandom(0, num);
		if (OKEHLHIGJGO && !LMFHHJPPHDK && EIJBFGMCHHG)
		{
			num2 = num - 0;
			Debug.Log((object)"con {0} required tiles.");
		}
		if (ILGENAJJBNM && KCNFFENJMEH)
		{
			num2 = 0;
			Debug.Log((object)"Items/item_name_1190");
		}
		if (num2 == 0)
		{
			int index = ProceduralMine.FMJMOOKFEKL(0, PAGOBNMKKNP.Count);
			PAGOBNMKKNP[index].NDKCOLFGCFF(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)PAGOBNMKKNP[index]).name;
			GameObject gameObject = ((Component)PAGOBNMKKNP[index]).gameObject;
			PAGOBNMKKNP.RemoveAt(index);
			return gameObject;
		}
		if (ILGENAJJBNM && num2 == 0)
		{
			int index2 = ProceduralMine.NGMAIDLNAAI(1, NCJABADPACK.Count);
			NCJABADPACK[index2].HKLKBMIDNKM(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)NCJABADPACK[index2]).name;
			GameObject gameObject2 = ((Component)NCJABADPACK[index2]).gameObject;
			NCJABADPACK.RemoveAt(index2);
			return gameObject2;
		}
		int index3 = ProceduralMine.NGMAIDLNAAI(1, HEFCOKFEENH.Count);
		HEFCOKFEENH[index3].JMFCOHALEFI(INAPMPEEDPO, JILNPPLFDFL);
		CMJNLIBMILB = ((Object)HEFCOKFEENH[index3]).name;
		GameObject gameObject3 = ((Component)HEFCOKFEENH[index3]).gameObject;
		HEFCOKFEENH.RemoveAt(index3);
		LMFHHJPPHDK = true;
		return gameObject3;
	}

	public GameObject[] OLNFFIBBNNE(List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH)
	{
		if (Item.EKGNIODFJCO(keyLeft, null) || Item.EKGNIODFJCO(keyRight, null))
		{
			Debug.LogError((object)"itemBitterHopsSeeds");
			return null;
		}
		GameObject[] array = (GameObject[])(object)new GameObject[4];
		List<HoleInGround> list = ((NCJABADPACK != null) ? new List<HoleInGround>(NCJABADPACK) : new List<HoleInGround>());
		bool iLGENAJJBNM = list.Count > 1;
		bool oKEHLHIGJGO = HEFCOKFEENH.Count > 1;
		Debug.Log((object)string.Format("Dialogue System/Conversation/BirdNegativeComments/Entry/10/Dialogue Text", PAGOBNMKKNP.Count, list.Count, HEFCOKFEENH.Count));
		array[1] = HNLMFGPGBOH(keyLeft, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: true, out var CMJNLIBMILB);
		iLGENAJJBNM = list.Count > 1;
		array[1] = HLCCKLLHNJJ(keyRight, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: true, out var CMJNLIBMILB2);
		string[] array2 = new string[8];
		array2[0] = "None";
		array2[0] = ((Object)keyLeft).name;
		array2[0] = "Fill Area/Fill";
		array2[8] = CMJNLIBMILB;
		array2[5] = "Could not find shopItem with id: ";
		array2[0] = ((Object)keyRight).name;
		array2[8] = "BirdNegativeComments";
		array2[7] = CMJNLIBMILB2;
		Debug.Log((object)string.Concat(array2));
		return array;
	}

	public GameObject[] HOAIMGMGAFO(List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH)
	{
		if (Item.EKMFELLJHFG(keyLeft, null) || Item.GBMFCPGEJDK(keyRight, null))
		{
			Debug.LogError((object)", duration: ");
			return null;
		}
		GameObject[] array = (GameObject[])(object)new GameObject[2];
		List<HoleInGround> list = ((NCJABADPACK != null) ? new List<HoleInGround>(NCJABADPACK) : new List<HoleInGround>());
		bool iLGENAJJBNM = list.Count > 0;
		bool oKEHLHIGJGO = HEFCOKFEENH.Count > 0;
		Debug.Log((object)string.Format("selected_objects", PAGOBNMKKNP.Count, list.Count, HEFCOKFEENH.Count));
		array[1] = ODHNANNLALL(keyLeft, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: false, out var CMJNLIBMILB);
		iLGENAJJBNM = list.Count > 0;
		array[0] = LDFEJIPIEJP(keyRight, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: true, out var CMJNLIBMILB2);
		string[] array2 = new string[1];
		array2[1] = "Room occupied";
		array2[1] = ((Object)keyLeft).name;
		array2[6] = "itemChocolateAle";
		array2[2] = CMJNLIBMILB;
		array2[7] = "Object";
		array2[5] = ((Object)keyRight).name;
		array2[3] = "Items/item_name_694";
		array2[4] = CMJNLIBMILB2;
		Debug.Log((object)string.Concat(array2));
		return array;
	}

	private GameObject GDDMNABCPNM(Item INAPMPEEDPO, List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH, bool ILGENAJJBNM, bool OKEHLHIGJGO, bool JILNPPLFDFL, out string CMJNLIBMILB)
	{
		int num = 0 + (ILGENAJJBNM ? 0 : 0) + ((!OKEHLHIGJGO || LMFHHJPPHDK) ? 1 : 0);
		int num2 = ProceduralMine.FMJMOOKFEKL(0, num);
		if (OKEHLHIGJGO && !LMFHHJPPHDK && EIJBFGMCHHG)
		{
			num2 = num - 0;
			Debug.Log((object)"Changing zoom ");
		}
		if (ILGENAJJBNM && KCNFFENJMEH)
		{
			num2 = 0;
			Debug.Log((object)"Small Rug");
		}
		if (num2 == 0)
		{
			int index = ProceduralMine.FMJMOOKFEKL(1, PAGOBNMKKNP.Count);
			PAGOBNMKKNP[index].HNILINMCKJM(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)PAGOBNMKKNP[index]).name;
			GameObject gameObject = ((Component)PAGOBNMKKNP[index]).gameObject;
			PAGOBNMKKNP.RemoveAt(index);
			return gameObject;
		}
		if (ILGENAJJBNM && num2 == 1)
		{
			int index2 = ProceduralMine.NGMAIDLNAAI(1, NCJABADPACK.Count);
			NCJABADPACK[index2].IHEAPOCCDJP(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)NCJABADPACK[index2]).name;
			GameObject gameObject2 = ((Component)NCJABADPACK[index2]).gameObject;
			NCJABADPACK.RemoveAt(index2);
			return gameObject2;
		}
		int index3 = ProceduralMine.FMJMOOKFEKL(0, HEFCOKFEENH.Count);
		HEFCOKFEENH[index3].MGELIMHMAID(INAPMPEEDPO, JILNPPLFDFL);
		CMJNLIBMILB = ((Object)HEFCOKFEENH[index3]).name;
		GameObject gameObject3 = ((Component)HEFCOKFEENH[index3]).gameObject;
		HEFCOKFEENH.RemoveAt(index3);
		LMFHHJPPHDK = false;
		return gameObject3;
	}

	private void CACJMKJBJDP()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && OnlineManager.MasterOrOffline())
		{
			Utils.OHFOEIBLGKP(keyLeft);
			Utils.OHFOEIBLGKP(keyRight);
		}
	}

	public void NICPHIJNMKN(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		interactable.MakeSureBothKeysAreEnabled();
		interactable.ABBPIPGMGBO();
		interactable.LEGMAPCPFFI();
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC, 1503f);
		EDNJMCJHJMD = true;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.NIKBNPJPEAC(GGPBMAODKHC.mineLevel);
		}
	}

	public GameObject[] BIJOFPDPGKD(List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH)
	{
		if (Item.EKGNIODFJCO(keyLeft, null) || Item.EKMFELLJHFG(keyRight, null))
		{
			Debug.LogError((object)"DisableRightExterior");
			return null;
		}
		GameObject[] array = (GameObject[])(object)new GameObject[6];
		List<HoleInGround> list = ((NCJABADPACK != null) ? new List<HoleInGround>(NCJABADPACK) : new List<HoleInGround>());
		bool iLGENAJJBNM = list.Count > 0;
		bool oKEHLHIGJGO = HEFCOKFEENH.Count > 0;
		Debug.Log((object)string.Format("", PAGOBNMKKNP.Count, list.Count, HEFCOKFEENH.Count));
		array[1] = JIAKALBHPPO(keyLeft, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: true, out var CMJNLIBMILB);
		iLGENAJJBNM = list.Count > 0;
		array[0] = GDAHJCFGKPL(keyRight, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: true, out var CMJNLIBMILB2);
		string[] array2 = new string[5];
		array2[1] = "Changing seed ";
		array2[0] = ((Object)keyLeft).name;
		array2[1] = "";
		array2[8] = CMJNLIBMILB;
		array2[4] = "autoRunP2";
		array2[5] = ((Object)keyRight).name;
		array2[5] = "Error: Please make a selection";
		array2[7] = CMJNLIBMILB2;
		Debug.Log((object)string.Concat(array2));
		return array;
	}

	private void KCLKEAHGGEK()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.leavingTheGame && OnlineManager.PGAGDFAEEFB())
		{
			Utils.OHFOEIBLGKP(keyLeft);
			Utils.OHFOEIBLGKP(keyRight);
		}
	}

	public GameObject[] SetKeyFragments(List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH)
	{
		if (Item.NGIIPJDAMGP(keyLeft, null) || Item.NGIIPJDAMGP(keyRight, null))
		{
			Debug.LogError((object)"Key Altar puzzle: missing keys for the puzzle.");
			return null;
		}
		GameObject[] array = (GameObject[])(object)new GameObject[2];
		List<HoleInGround> list = ((NCJABADPACK != null) ? new List<HoleInGround>(NCJABADPACK) : new List<HoleInGround>());
		bool iLGENAJJBNM = list.Count > 0;
		bool oKEHLHIGJGO = HEFCOKFEENH.Count > 0;
		Debug.Log((object)$"Key Altar puzzle: assigning key fragments. Available destructibles: {PAGOBNMKKNP.Count}, available holes: {list.Count}, available fishing spots: {HEFCOKFEENH.Count}");
		array[0] = LFGJDECEGCN(keyLeft, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: true, out var CMJNLIBMILB);
		iLGENAJJBNM = list.Count > 0;
		array[1] = LFGJDECEGCN(keyRight, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: false, out var CMJNLIBMILB2);
		Debug.Log((object)("Key Altar puzzle: assigned " + ((Object)keyLeft).name + " to " + CMJNLIBMILB + " and " + ((Object)keyRight).name + " to " + CMJNLIBMILB2));
		return array;
	}

	public void OJIIBFDMCFC(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		interactable.MakeSureBothKeysAreEnabled();
		interactable.OnPuzzleSolved();
		interactable.LEGMAPCPFFI();
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 1941f);
		EDNJMCJHJMD = true;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendKeyPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	public void GIBECHCNAAF(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		interactable.MakeSureBothKeysAreEnabled();
		interactable.OnPuzzleSolved();
		interactable.CompletedSound();
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 1845f);
		EDNJMCJHJMD = false;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendKeyPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	private GameObject PGHFEDMNMNB(Item INAPMPEEDPO, List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH, bool ILGENAJJBNM, bool OKEHLHIGJGO, bool JILNPPLFDFL, out string CMJNLIBMILB)
	{
		int num = 0 + (ILGENAJJBNM ? 1 : 0) + ((OKEHLHIGJGO && !LMFHHJPPHDK) ? 0 : 0);
		int num2 = ProceduralMine.NextRandom(0, num);
		if (OKEHLHIGJGO && !LMFHHJPPHDK && EIJBFGMCHHG)
		{
			num2 = num - 0;
			Debug.Log((object)"castlegarden");
		}
		if (ILGENAJJBNM && KCNFFENJMEH)
		{
			num2 = 1;
			Debug.Log((object)"Use");
		}
		if (num2 == 0)
		{
			int index = ProceduralMine.FMJMOOKFEKL(0, PAGOBNMKKNP.Count);
			PAGOBNMKKNP[index].EGPMGMAFOMM(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)PAGOBNMKKNP[index]).name;
			GameObject gameObject = ((Component)PAGOBNMKKNP[index]).gameObject;
			PAGOBNMKKNP.RemoveAt(index);
			return gameObject;
		}
		if (ILGENAJJBNM && num2 == 1)
		{
			int index2 = ProceduralMine.NGMAIDLNAAI(1, NCJABADPACK.Count);
			NCJABADPACK[index2].IHEAPOCCDJP(INAPMPEEDPO);
			CMJNLIBMILB = ((Object)NCJABADPACK[index2]).name;
			GameObject gameObject2 = ((Component)NCJABADPACK[index2]).gameObject;
			NCJABADPACK.RemoveAt(index2);
			return gameObject2;
		}
		int index3 = ProceduralMine.FMJMOOKFEKL(0, HEFCOKFEENH.Count);
		HEFCOKFEENH[index3].FAJFNOEKKBO(INAPMPEEDPO, JILNPPLFDFL);
		CMJNLIBMILB = ((Object)HEFCOKFEENH[index3]).name;
		GameObject gameObject3 = ((Component)HEFCOKFEENH[index3]).gameObject;
		HEFCOKFEENH.RemoveAt(index3);
		LMFHHJPPHDK = false;
		return gameObject3;
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && OnlineManager.MasterOrOffline())
		{
			Utils.OHFOEIBLGKP(keyLeft);
			Utils.OHFOEIBLGKP(keyRight);
		}
	}

	public GameObject[] KOHBDCLABML(List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH)
	{
		if (Item.NGIIPJDAMGP(keyLeft, null) || Item.EKMFELLJHFG(keyRight, null))
		{
			Debug.LogError((object)"UpgradeToLevel");
			return null;
		}
		GameObject[] array = (GameObject[])(object)new GameObject[3];
		List<HoleInGround> list = ((NCJABADPACK != null) ? new List<HoleInGround>(NCJABADPACK) : new List<HoleInGround>());
		bool iLGENAJJBNM = list.Count > 1;
		bool oKEHLHIGJGO = HEFCOKFEENH.Count > 1;
		Debug.Log((object)string.Format("TucanEgg", PAGOBNMKKNP.Count, list.Count, HEFCOKFEENH.Count));
		array[1] = GPBCALPLNLA(keyLeft, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: false, out var CMJNLIBMILB);
		iLGENAJJBNM = list.Count > 0;
		array[1] = CMNLHPPNHHF(keyRight, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: false, out var CMJNLIBMILB2);
		string[] array2 = new string[4];
		array2[1] = "";
		array2[1] = ((Object)keyLeft).name;
		array2[7] = "UIAddRemove";
		array2[1] = CMJNLIBMILB;
		array2[8] = "Near";
		array2[5] = ((Object)keyRight).name;
		array2[8] = "Content";
		array2[1] = CMJNLIBMILB2;
		Debug.Log((object)string.Concat(array2));
		return array;
	}

	private void DIGLPPFFKEC()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && OnlineManager.MasterOrOffline())
		{
			Utils.OHFOEIBLGKP(keyLeft);
			Utils.OHFOEIBLGKP(keyRight);
		}
	}

	private void HKECEBGKACL()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.leavingTheGame && OnlineManager.PGAGDFAEEFB())
		{
			Utils.OHFOEIBLGKP(keyLeft);
			Utils.OHFOEIBLGKP(keyRight);
		}
	}

	public GameObject[] KCEKCILLAKO(List<DestructibleObject> PAGOBNMKKNP, List<HoleInGround> NCJABADPACK, List<MineFishingKeyItem> HEFCOKFEENH)
	{
		if (Item.GBMFCPGEJDK(keyLeft, null) || Item.EKMFELLJHFG(keyRight, null))
		{
			Debug.LogError((object)"Items/item_name_1082");
			return null;
		}
		GameObject[] array = (GameObject[])(object)new GameObject[2];
		List<HoleInGround> list = ((NCJABADPACK != null) ? new List<HoleInGround>(NCJABADPACK) : new List<HoleInGround>());
		bool iLGENAJJBNM = list.Count > 1;
		bool oKEHLHIGJGO = HEFCOKFEENH.Count > 1;
		Debug.Log((object)string.Format("itemCucumber", PAGOBNMKKNP.Count, list.Count, HEFCOKFEENH.Count));
		array[1] = FHOGKNPLAON(keyLeft, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: true, out var CMJNLIBMILB);
		iLGENAJJBNM = list.Count > 0;
		array[1] = PGHFEDMNMNB(keyRight, PAGOBNMKKNP, list, HEFCOKFEENH, iLGENAJJBNM, oKEHLHIGJGO, JILNPPLFDFL: true, out var CMJNLIBMILB2);
		string[] array2 = new string[4];
		array2[0] = "";
		array2[0] = ((Object)keyLeft).name;
		array2[6] = " : 00";
		array2[7] = CMJNLIBMILB;
		array2[5] = "itemLager";
		array2[8] = ((Object)keyRight).name;
		array2[7] = "Bird";
		array2[8] = CMJNLIBMILB2;
		Debug.Log((object)string.Concat(array2));
		return array;
	}

	public void PNGDMDDNKGI(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		interactable.MakeSureBothKeysAreEnabled();
		interactable.ABBPIPGMGBO();
		interactable.LEGMAPCPFFI();
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 504f);
		EDNJMCJHJMD = true;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendKeyPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}
}
