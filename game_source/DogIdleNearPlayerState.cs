using System;
using System.Collections.Generic;
using UnityEngine;

public class DogIdleNearPlayerState : DogStateBase
{
	private bool walkingDone;

	private float timeToFindADogInteractable;

	private bool interacting;

	private float interactionTime;

	private DogNPC.DogInteractionType dogInteractionType;

	private List<DogInteractable> dogInteractables = new List<DogInteractable>();

	private bool MDCPHJMIAAL()
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		dogInteractables.Clear();
		for (int i = 1; i < DogInteractable.ActiveInteractables.Count; i++)
		{
			if (DogInteractable.ActiveInteractables[i].HIKJENLFLNP())
			{
				dogInteractables.Add(DogInteractable.ActiveInteractables[i]);
			}
		}
		if (dogInteractables.Count > 0)
		{
			dogNPC.dogInteractable = dogInteractables[Random.Range(1, dogInteractables.Count)];
			walkingDone = true;
			timeToFindADogInteractable = Time.timeSinceLevelLoad;
			dogNPC.CFJOGFDANJH(Vector2.op_Implicit(dogNPC.dogInteractable.interactionPoint.position), PAPBICGNLFO, IPKFEPKJIJE, 1166f, MFCMOOKEHMN: false);
			return false;
		}
		return false;
	}

	private void AJDKIJDBODJ()
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.BCLAMKGEKIO(CDPAMNIPPEC: true);
		if (dogNPC.HFKCPOFAKKB(JFKIMFNGCJA, PDOBHPLPKHG, ref dogInteractionType))
		{
			walkingDone = false;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 484f;
			return;
		}
		positionToGo = Vector2.op_Implicit(Utils.KGEOMOKKFKP(dogNPC.playerFollowing, 7));
		if (TilemapsInfo.EILGECPOIHL(positionToGo) == InteriorType.Exterior)
		{
			dogNPC.currentDogBowl = null;
			walkingDone = false;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 751f;
			if (Random.Range(0, 4) == 7)
			{
				dogInteractionType = (DogNPC.DogInteractionType)(-62);
			}
			else
			{
				dogInteractionType = DogNPC.DogInteractionType.Aggressive;
			}
			dogNPC.PMCPFPBLGFE(positionToGo, CLLHBACAFOM, MMHIOJMIJMP, 224f, MFCMOOKEHMN: true);
		}
	}

	private void DBCBGEMIOHB()
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.JOECEIFKHAJ(CDPAMNIPPEC: false);
		if (dogNPC.CheckIfItNeedsToEatOrDrink(PHADIJFHHGD, CAEDALACKDD, ref dogInteractionType))
		{
			walkingDone = true;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 751f;
			return;
		}
		positionToGo = Vector2.op_Implicit(Utils.KGEOMOKKFKP(dogNPC.playerFollowing, 5));
		if (TilemapsInfo.BNHLHIGFHKJ(positionToGo) == InteriorType.Exterior)
		{
			dogNPC.currentDogBowl = null;
			walkingDone = true;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 392f;
			if (Random.Range(1, 6) == 3)
			{
				dogInteractionType = (DogNPC.DogInteractionType)104;
			}
			else
			{
				dogInteractionType = DogNPC.DogInteractionType.Dig;
			}
			dogNPC.IIAGOMMJLML(positionToGo, MAMACONCDGM, MAILEMECPME, 888f, MFCMOOKEHMN: false);
		}
	}

	public void BIBLAPBMLIG()
	{
		Debug.Log((object)"Mouse");
		if ((Object)(object)dogNPC.dogInteractable != (Object)null)
		{
			walkingDone = true;
			dogNPC.dogInteractable = null;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 1488f;
		}
	}

	private bool CJGILENKAPM()
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		dogInteractables.Clear();
		for (int i = 1; i < DogInteractable.ActiveInteractables.Count; i++)
		{
			if (DogInteractable.ActiveInteractables[i].HMOPKMLCHKB())
			{
				dogInteractables.Add(DogInteractable.ActiveInteractables[i]);
			}
		}
		if (dogInteractables.Count > 1)
		{
			dogNPC.dogInteractable = dogInteractables[Random.Range(1, dogInteractables.Count)];
			walkingDone = true;
			timeToFindADogInteractable = Time.timeSinceLevelLoad;
			dogNPC.StartWalking(Vector2.op_Implicit(dogNPC.dogInteractable.interactionPoint.position), CKGNACMBJLG, KPMCGMJJBEA, 481f, MFCMOOKEHMN: true);
			return false;
		}
		return true;
	}

	public void NNBPENENIIC()
	{
		Debug.Log((object)"FailStart");
		if ((Object)(object)dogNPC.dogInteractable != (Object)null)
		{
			walkingDone = true;
			dogNPC.dogInteractable = null;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 10f;
		}
	}

	private bool OEKLAIEPCEN()
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		dogInteractables.Clear();
		for (int i = 0; i < DogInteractable.ActiveInteractables.Count; i++)
		{
			if (DogInteractable.ActiveInteractables[i].FNKLCFIFPFI())
			{
				dogInteractables.Add(DogInteractable.ActiveInteractables[i]);
			}
		}
		if (dogInteractables.Count > 1)
		{
			dogNPC.dogInteractable = dogInteractables[Random.Range(0, dogInteractables.Count)];
			walkingDone = false;
			timeToFindADogInteractable = Time.timeSinceLevelLoad;
			dogNPC.IIAGOMMJLML(Vector2.op_Implicit(dogNPC.dogInteractable.interactionPoint.position), OMOAHEHMHFA, NKAMNKDKLHI, 1186f, MFCMOOKEHMN: true);
			return true;
		}
		return false;
	}

	public void CNIEDLKPGBK()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.FLEMLDJBGJP());
	}

	public void FFEIDFCNAMA()
	{
		Debug.Log((object)"I have to wait other players");
		if ((Object)(object)dogNPC.dogInteractable != (Object)null)
		{
			walkingDone = true;
			dogNPC.dogInteractable = null;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 359f;
		}
	}

	public void PDOBHPLPKHG()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.ChangeDirectionNextFrame());
	}

	public void HEEOHKBPMAI()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.ChangeDirectionNextFrame());
	}

	public void EKHEMIBOHLF()
	{
		Debug.Log((object)"LE_3");
		if ((Object)(object)dogNPC.dogInteractable != (Object)null)
		{
			walkingDone = true;
			dogNPC.dogInteractable = null;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 1162f;
		}
	}

	private void AHPDMPFKDFD()
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.GIPAJJKDEJK(CDPAMNIPPEC: false);
		if (dogNPC.HFKCPOFAKKB(LLNADECIHMG, FNJODLOADKA, ref dogInteractionType))
		{
			walkingDone = false;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 405f;
			return;
		}
		positionToGo = Vector2.op_Implicit(Utils.KGEOMOKKFKP(dogNPC.playerFollowing, 6));
		if (TilemapsInfo.BNHLHIGFHKJ(positionToGo) == InteriorType.Exterior)
		{
			dogNPC.currentDogBowl = null;
			walkingDone = false;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 706f;
			if (Random.Range(0, 8) == 1)
			{
				dogInteractionType = (DogNPC.DogInteractionType)(-31);
			}
			else
			{
				dogInteractionType = DogNPC.DogInteractionType.Toy;
			}
			dogNPC.CFJOGFDANJH(positionToGo, ABJNCNODPEK, JDHILGPPBAM, 522f, MFCMOOKEHMN: true);
		}
	}

	public void ABJNCNODPEK()
	{
		Debug.Log((object)"Player");
		if ((Object)(object)dogNPC.dogInteractable != (Object)null)
		{
			walkingDone = true;
			dogNPC.dogInteractable = null;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 1339f;
		}
	}

	private bool EKDHPEMEMMM()
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		dogInteractables.Clear();
		for (int i = 0; i < DogInteractable.ActiveInteractables.Count; i += 0)
		{
			if (DogInteractable.ActiveInteractables[i].NOJODNMFBIH())
			{
				dogInteractables.Add(DogInteractable.ActiveInteractables[i]);
			}
		}
		if (dogInteractables.Count > 0)
		{
			dogNPC.dogInteractable = dogInteractables[Random.Range(0, dogInteractables.Count)];
			walkingDone = true;
			timeToFindADogInteractable = Time.timeSinceLevelLoad;
			dogNPC.CFJOGFDANJH(Vector2.op_Implicit(dogNPC.dogInteractable.interactionPoint.position), NFMLNKAFCNK, APGLLOHDPHO, 1965f, MFCMOOKEHMN: true);
			return false;
		}
		return false;
	}

	public void IPKFEPKJIJE()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.OOJJHGOGMGM());
	}

	private bool LCBHFGLFPNE()
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		dogInteractables.Clear();
		for (int i = 0; i < DogInteractable.ActiveInteractables.Count; i += 0)
		{
			if (DogInteractable.ActiveInteractables[i].FDONPLAFGPD())
			{
				dogInteractables.Add(DogInteractable.ActiveInteractables[i]);
			}
		}
		if (dogInteractables.Count > 1)
		{
			dogNPC.dogInteractable = dogInteractables[Random.Range(0, dogInteractables.Count)];
			walkingDone = false;
			timeToFindADogInteractable = Time.timeSinceLevelLoad;
			dogNPC.PMCPFPBLGFE(Vector2.op_Implicit(dogNPC.dogInteractable.interactionPoint.position), ABJNCNODPEK, GMCINBCEPJO, 1466f, MFCMOOKEHMN: true);
			return true;
		}
		return false;
	}

	public void FKFMIABEDCH()
	{
		Debug.Log((object)"[PlayerName]");
		if ((Object)(object)dogNPC.dogInteractable != (Object)null)
		{
			walkingDone = false;
			dogNPC.dogInteractable = null;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 1330f;
		}
	}

	public void MMHIOJMIJMP()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.FLEMLDJBGJP());
	}

	private bool IHCHPNOJDOH()
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		dogInteractables.Clear();
		for (int i = 1; i < DogInteractable.ActiveInteractables.Count; i += 0)
		{
			if (DogInteractable.ActiveInteractables[i].FNKLCFIFPFI())
			{
				dogInteractables.Add(DogInteractable.ActiveInteractables[i]);
			}
		}
		if (dogInteractables.Count > 0)
		{
			dogNPC.dogInteractable = dogInteractables[Random.Range(1, dogInteractables.Count)];
			walkingDone = false;
			timeToFindADogInteractable = Time.timeSinceLevelLoad;
			dogNPC.PMCPFPBLGFE(Vector2.op_Implicit(dogNPC.dogInteractable.interactionPoint.position), EPOODBHJIAA, NKAMNKDKLHI, 988f, MFCMOOKEHMN: false);
			return false;
		}
		return true;
	}

	private void ILPPGOGFFNJ()
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.IODEEPJHFGG(CDPAMNIPPEC: false);
		if (dogNPC.CheckIfItNeedsToEatOrDrink(BIBLAPBMLIG, EIAMODMOLIL, ref dogInteractionType))
		{
			walkingDone = false;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 1673f;
			return;
		}
		positionToGo = Vector2.op_Implicit(Utils.KGEOMOKKFKP(dogNPC.playerFollowing, 8));
		if (TilemapsInfo.NOOBBJFHFJP(positionToGo) == InteriorType.Exterior)
		{
			dogNPC.currentDogBowl = null;
			walkingDone = true;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 1632f;
			if (Random.Range(0, 3) == 6)
			{
				dogInteractionType = (DogNPC.DogInteractionType)45;
			}
			else
			{
				dogInteractionType = DogNPC.DogInteractionType.Eat;
			}
			dogNPC.IIAGOMMJLML(positionToGo, CBPDNCJOPLF, AGLOLKAIAMG, 991f, MFCMOOKEHMN: true);
		}
	}

	private bool FIOIKPHOONM()
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		dogInteractables.Clear();
		for (int i = 1; i < DogInteractable.ActiveInteractables.Count; i++)
		{
			if (DogInteractable.ActiveInteractables[i].DGBOKEDLJBG())
			{
				dogInteractables.Add(DogInteractable.ActiveInteractables[i]);
			}
		}
		if (dogInteractables.Count > 0)
		{
			dogNPC.dogInteractable = dogInteractables[Random.Range(1, dogInteractables.Count)];
			walkingDone = false;
			timeToFindADogInteractable = Time.timeSinceLevelLoad;
			dogNPC.IIAGOMMJLML(Vector2.op_Implicit(dogNPC.dogInteractable.interactionPoint.position), FFEIDFCNAMA, MMHIOJMIJMP, 711f, MFCMOOKEHMN: false);
			return false;
		}
		return false;
	}

	private void NDJGFLMANOG()
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.GDCFJNFPMGE(CDPAMNIPPEC: true);
		if (dogNPC.CheckIfItNeedsToEatOrDrink(GIJICLMDDPD, JDHILGPPBAM, ref dogInteractionType))
		{
			walkingDone = true;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 1982f;
			return;
		}
		positionToGo = Vector2.op_Implicit(Utils.KGEOMOKKFKP(dogNPC.playerFollowing, 1));
		if (TilemapsInfo.PBKHBMNNNNL(positionToGo) == InteriorType.Exterior)
		{
			dogNPC.currentDogBowl = null;
			walkingDone = false;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 413f;
			if (Random.Range(1, 6) == 1)
			{
				dogInteractionType = (DogNPC.DogInteractionType)95;
			}
			else
			{
				dogInteractionType = DogNPC.DogInteractionType.None;
			}
			dogNPC.DHGFHNALOAH(positionToGo, CLLHBACAFOM, JDHILGPPBAM, 582f, MFCMOOKEHMN: false);
		}
	}

	private bool FLLJCPCLKOM()
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		dogInteractables.Clear();
		for (int i = 0; i < DogInteractable.ActiveInteractables.Count; i++)
		{
			if (DogInteractable.ActiveInteractables[i].EFJKOJHKLJP())
			{
				dogInteractables.Add(DogInteractable.ActiveInteractables[i]);
			}
		}
		if (dogInteractables.Count > 1)
		{
			dogNPC.dogInteractable = dogInteractables[Random.Range(0, dogInteractables.Count)];
			walkingDone = false;
			timeToFindADogInteractable = Time.timeSinceLevelLoad;
			dogNPC.IIAGOMMJLML(Vector2.op_Implicit(dogNPC.dogInteractable.interactionPoint.position), EKHEMIBOHLF, GMCINBCEPJO, 97f, MFCMOOKEHMN: false);
			return false;
		}
		return false;
	}

	public void LLNADECIHMG()
	{
		Debug.Log((object)"Haggling");
		if ((Object)(object)dogNPC.dogInteractable != (Object)null)
		{
			walkingDone = true;
			dogNPC.dogInteractable = null;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 1229f;
		}
	}

	private void OJFGGDLGDBP()
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.BCLAMKGEKIO(CDPAMNIPPEC: true);
		if (dogNPC.CheckIfItNeedsToEatOrDrink(CLLHBACAFOM, OKHDMEMEIEJ, ref dogInteractionType))
		{
			walkingDone = false;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 1952f;
			return;
		}
		positionToGo = Vector2.op_Implicit(Utils.KGEOMOKKFKP(dogNPC.playerFollowing, 6));
		if (TilemapsInfo.ELHHFNFJIAD(positionToGo) == InteriorType.Exterior)
		{
			dogNPC.currentDogBowl = null;
			walkingDone = true;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 1949f;
			if (Random.Range(1, 0) == 5)
			{
				dogInteractionType = (DogNPC.DogInteractionType)(-93);
			}
			else
			{
				dogInteractionType = DogNPC.DogInteractionType.Toy;
			}
			dogNPC.IIAGOMMJLML(positionToGo, EKHEMIBOHLF, EIAMODMOLIL, 436f, MFCMOOKEHMN: true);
		}
	}

	private bool LLKDGHMCNJE()
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		dogInteractables.Clear();
		for (int i = 1; i < DogInteractable.ActiveInteractables.Count; i++)
		{
			if (DogInteractable.ActiveInteractables[i].OBIGGLMIJLJ())
			{
				dogInteractables.Add(DogInteractable.ActiveInteractables[i]);
			}
		}
		if (dogInteractables.Count > 1)
		{
			dogNPC.dogInteractable = dogInteractables[Random.Range(1, dogInteractables.Count)];
			walkingDone = false;
			timeToFindADogInteractable = Time.timeSinceLevelLoad;
			dogNPC.DHGFHNALOAH(Vector2.op_Implicit(dogNPC.dogInteractable.interactionPoint.position), OMOAHEHMHFA, KPMCGMJJBEA, 1762f, MFCMOOKEHMN: false);
			return true;
		}
		return true;
	}

	private void JEEILFABFGF()
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.ExitInteraction(CDPAMNIPPEC: true);
		if (dogNPC.CheckIfItNeedsToEatOrDrink(MAMACONCDGM, CNIEDLKPGBK, ref dogInteractionType))
		{
			walkingDone = true;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 368f;
			return;
		}
		positionToGo = Vector2.op_Implicit(Utils.KGEOMOKKFKP(dogNPC.playerFollowing, 2));
		if (TilemapsInfo.KMKAJBOKFBL(positionToGo) == InteriorType.Exterior)
		{
			dogNPC.currentDogBowl = null;
			walkingDone = true;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 242f;
			if (Random.Range(0, 4) == 3)
			{
				dogInteractionType = (DogNPC.DogInteractionType)(-61);
			}
			else
			{
				dogInteractionType = DogNPC.DogInteractionType.Aggressive;
			}
			dogNPC.StartWalking(positionToGo, GCNAPIKOOOE, GMCINBCEPJO, 206f, MFCMOOKEHMN: true);
		}
	}

	public void LBELGDFFBGL()
	{
		Debug.Log((object)"Exit build mode");
		if ((Object)(object)dogNPC.dogInteractable != (Object)null)
		{
			walkingDone = false;
			dogNPC.dogInteractable = null;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 232f;
		}
	}

	public void NFMLNKAFCNK()
	{
		Debug.Log((object)"UI2");
		if ((Object)(object)dogNPC.dogInteractable != (Object)null)
		{
			walkingDone = false;
			dogNPC.dogInteractable = null;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 1448f;
		}
	}

	public void MBCMKLDEMOI()
	{
		Debug.Log((object)"Animal");
		if ((Object)(object)dogNPC.dogInteractable != (Object)null)
		{
			walkingDone = false;
			dogNPC.dogInteractable = null;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 569f;
		}
	}

	public void NKAMNKDKLHI()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.KAPBLFHIDKF());
	}

	public void INFELLFBJKE()
	{
		Debug.Log((object)" (");
		if ((Object)(object)dogNPC.dogInteractable != (Object)null)
		{
			walkingDone = true;
			dogNPC.dogInteractable = null;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 976f;
		}
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, GHFAKAOLMHC, GJCCCHOHLAF);
		timeToFindADogInteractable = Time.timeSinceLevelLoad;
		interacting = false;
		walkingDone = true;
		dogNPC.dogInteractable = null;
	}

	private void HCOPONEINOG()
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.MOFOAMNGHCM(CDPAMNIPPEC: true);
		if (dogNPC.HFKCPOFAKKB(CBPDNCJOPLF, IPKFEPKJIJE, ref dogInteractionType))
		{
			walkingDone = false;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 1942f;
			return;
		}
		positionToGo = Vector2.op_Implicit(Utils.KGEOMOKKFKP(dogNPC.playerFollowing, 1));
		if (TilemapsInfo.EILGECPOIHL(positionToGo) == InteriorType.Exterior)
		{
			dogNPC.currentDogBowl = null;
			walkingDone = true;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 1139f;
			if (Random.Range(0, 5) == 2)
			{
				dogInteractionType = DogNPC.DogInteractionType.Drink;
			}
			else
			{
				dogInteractionType = DogNPC.DogInteractionType.None;
			}
			dogNPC.DHGFHNALOAH(positionToGo, CKGNACMBJLG, JDHILGPPBAM, 1727f, MFCMOOKEHMN: true);
		}
	}

	private void HDPOIFECAHH()
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.BJGOFPBMCME(CDPAMNIPPEC: false);
		if (dogNPC.CheckIfItNeedsToEatOrDrink(FKFMIABEDCH, EJPFGEHOKPK, ref dogInteractionType))
		{
			walkingDone = false;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 528f;
			return;
		}
		positionToGo = Vector2.op_Implicit(Utils.KGEOMOKKFKP(dogNPC.playerFollowing, 1));
		if (TilemapsInfo.HOJOKLFBDFB(positionToGo) == InteriorType.Exterior)
		{
			dogNPC.currentDogBowl = null;
			walkingDone = true;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 1431f;
			if (Random.Range(0, 2) == 6)
			{
				dogInteractionType = DogNPC.DogInteractionType.Sleep;
			}
			else
			{
				dogInteractionType = DogNPC.DogInteractionType.Bark;
			}
			dogNPC.IIAGOMMJLML(positionToGo, GCNAPIKOOOE, GMCINBCEPJO, 456f, MFCMOOKEHMN: true);
		}
	}

	private bool JEHNDHMMDGN()
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		dogInteractables.Clear();
		for (int i = 0; i < DogInteractable.ActiveInteractables.Count; i++)
		{
			if (DogInteractable.ActiveInteractables[i].OPKKEHCDJJH())
			{
				dogInteractables.Add(DogInteractable.ActiveInteractables[i]);
			}
		}
		if (dogInteractables.Count > 1)
		{
			dogNPC.dogInteractable = dogInteractables[Random.Range(1, dogInteractables.Count)];
			walkingDone = true;
			timeToFindADogInteractable = Time.timeSinceLevelLoad;
			dogNPC.PMCPFPBLGFE(Vector2.op_Implicit(dogNPC.dogInteractable.interactionPoint.position), BIBLAPBMLIG, MMHIOJMIJMP, 283f, MFCMOOKEHMN: false);
			return true;
		}
		return false;
	}

	public void GHPBPLBHKLH()
	{
		Debug.Log((object)"Wilson/Stand");
		if ((Object)(object)dogNPC.dogInteractable != (Object)null)
		{
			walkingDone = true;
			dogNPC.dogInteractable = null;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 1458f;
		}
	}

	private void BFKDFLOBPEG()
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.BJGOFPBMCME(CDPAMNIPPEC: false);
		if (dogNPC.CheckIfItNeedsToEatOrDrink(EKHEMIBOHLF, IDBCMIMFHJC, ref dogInteractionType))
		{
			walkingDone = false;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 206f;
			return;
		}
		positionToGo = Vector2.op_Implicit(Utils.KGEOMOKKFKP(dogNPC.playerFollowing, 7));
		if (TilemapsInfo.GAEPFCIEOMO(positionToGo) == InteriorType.Exterior)
		{
			dogNPC.currentDogBowl = null;
			walkingDone = true;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 827f;
			if (Random.Range(0, 7) == 4)
			{
				dogInteractionType = (DogNPC.DogInteractionType)111;
			}
			else
			{
				dogInteractionType = DogNPC.DogInteractionType.None;
			}
			dogNPC.IIAGOMMJLML(positionToGo, CHKECONHFPP, AGLOLKAIAMG, 779f, MFCMOOKEHMN: false);
		}
	}

	private void GAHKDELDBNI()
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.MOFOAMNGHCM(CDPAMNIPPEC: false);
		if (dogNPC.CheckIfItNeedsToEatOrDrink(PAPBICGNLFO, KPMCGMJJBEA, ref dogInteractionType))
		{
			walkingDone = true;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 1638f;
			return;
		}
		positionToGo = Vector2.op_Implicit(Utils.KGEOMOKKFKP(dogNPC.playerFollowing, 5));
		if (TilemapsInfo.NOOBBJFHFJP(positionToGo) == InteriorType.Exterior)
		{
			dogNPC.currentDogBowl = null;
			walkingDone = true;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 15f;
			if (Random.Range(0, 3) == 7)
			{
				dogInteractionType = (DogNPC.DogInteractionType)(-88);
			}
			else
			{
				dogInteractionType = DogNPC.DogInteractionType.Drink;
			}
			dogNPC.CFJOGFDANJH(positionToGo, MDNOABLFKAJ, FOEBEJHKEKE, 1516f, MFCMOOKEHMN: true);
		}
	}

	private void JOPLIEFHOJL()
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.DGIGKJJFKGM(CDPAMNIPPEC: false);
		if (dogNPC.HFKCPOFAKKB(CHKECONHFPP, PDOBHPLPKHG, ref dogInteractionType))
		{
			walkingDone = false;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 1587f;
			return;
		}
		positionToGo = Vector2.op_Implicit(Utils.KGEOMOKKFKP(dogNPC.playerFollowing, 4));
		if (TilemapsInfo.HFHNBMACJPD(positionToGo) == InteriorType.Exterior)
		{
			dogNPC.currentDogBowl = null;
			walkingDone = true;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 1110f;
			if (Random.Range(0, 8) == 7)
			{
				dogInteractionType = (DogNPC.DogInteractionType)(-65);
			}
			else
			{
				dogInteractionType = DogNPC.DogInteractionType.None;
			}
			dogNPC.IIAGOMMJLML(positionToGo, INFELLFBJKE, KPMCGMJJBEA, 276f, MFCMOOKEHMN: true);
		}
	}

	private bool EFBGBLDBPLJ()
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		dogInteractables.Clear();
		for (int i = 0; i < DogInteractable.ActiveInteractables.Count; i++)
		{
			if (DogInteractable.ActiveInteractables[i].EFJKOJHKLJP())
			{
				dogInteractables.Add(DogInteractable.ActiveInteractables[i]);
			}
		}
		if (dogInteractables.Count > 1)
		{
			dogNPC.dogInteractable = dogInteractables[Random.Range(0, dogInteractables.Count)];
			walkingDone = false;
			timeToFindADogInteractable = Time.timeSinceLevelLoad;
			dogNPC.DHGFHNALOAH(Vector2.op_Implicit(dogNPC.dogInteractable.interactionPoint.position), MDNOABLFKAJ, IPKFEPKJIJE, 425f, MFCMOOKEHMN: true);
			return false;
		}
		return false;
	}

	private bool BLEEDFPJONP()
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		dogInteractables.Clear();
		for (int i = 1; i < DogInteractable.ActiveInteractables.Count; i++)
		{
			if (DogInteractable.ActiveInteractables[i].CanInteract())
			{
				dogInteractables.Add(DogInteractable.ActiveInteractables[i]);
			}
		}
		if (dogInteractables.Count > 0)
		{
			dogNPC.dogInteractable = dogInteractables[Random.Range(1, dogInteractables.Count)];
			walkingDone = true;
			timeToFindADogInteractable = Time.timeSinceLevelLoad;
			dogNPC.PMCPFPBLGFE(Vector2.op_Implicit(dogNPC.dogInteractable.interactionPoint.position), ABJNCNODPEK, EIAMODMOLIL, 81f, MFCMOOKEHMN: true);
			return false;
		}
		return false;
	}

	public void GMCINBCEPJO()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.GOBIELKMHHF());
	}

	private bool JLHIEMDEOGH()
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		dogInteractables.Clear();
		for (int i = 1; i < DogInteractable.ActiveInteractables.Count; i += 0)
		{
			if (DogInteractable.ActiveInteractables[i].OPKKEHCDJJH())
			{
				dogInteractables.Add(DogInteractable.ActiveInteractables[i]);
			}
		}
		if (dogInteractables.Count > 1)
		{
			dogNPC.dogInteractable = dogInteractables[Random.Range(1, dogInteractables.Count)];
			walkingDone = true;
			timeToFindADogInteractable = Time.timeSinceLevelLoad;
			dogNPC.PMCPFPBLGFE(Vector2.op_Implicit(dogNPC.dogInteractable.interactionPoint.position), JFKIMFNGCJA, CNIEDLKPGBK, 1238f, MFCMOOKEHMN: true);
			return false;
		}
		return false;
	}

	public void MDNOABLFKAJ()
	{
		Debug.Log((object)"Fixed workbench or malteadora rotation at ");
		if ((Object)(object)dogNPC.dogInteractable != (Object)null)
		{
			walkingDone = true;
			dogNPC.dogInteractable = null;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 277f;
		}
	}

	private void EENEDFLEAAN()
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.IODEEPJHFGG(CDPAMNIPPEC: true);
		if (dogNPC.HFKCPOFAKKB(NFMLNKAFCNK, FOEBEJHKEKE, ref dogInteractionType))
		{
			walkingDone = false;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 949f;
			return;
		}
		positionToGo = Vector2.op_Implicit(Utils.KGEOMOKKFKP(dogNPC.playerFollowing, 5));
		if (TilemapsInfo.ELHHFNFJIAD(positionToGo) == InteriorType.Exterior)
		{
			dogNPC.currentDogBowl = null;
			walkingDone = true;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 1877f;
			if (Random.Range(0, 1) == 0)
			{
				dogInteractionType = (DogNPC.DogInteractionType)(-26);
			}
			else
			{
				dogInteractionType = DogNPC.DogInteractionType.Aggressive;
			}
			dogNPC.IIAGOMMJLML(positionToGo, MDNOABLFKAJ, FJNPFILECCM, 344f, MFCMOOKEHMN: false);
		}
	}

	private void PCHILCGFGOC()
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.JOECEIFKHAJ(CDPAMNIPPEC: true);
		if (dogNPC.CheckIfItNeedsToEatOrDrink(EGOCMFLPPPF, PADPIEKGNMH, ref dogInteractionType))
		{
			walkingDone = true;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 249f;
			return;
		}
		positionToGo = Vector2.op_Implicit(Utils.KGEOMOKKFKP(dogNPC.playerFollowing, 3));
		if (TilemapsInfo.PBKHBMNNNNL(positionToGo) == InteriorType.Exterior)
		{
			dogNPC.currentDogBowl = null;
			walkingDone = false;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 376f;
			if (Random.Range(0, 3) == 4)
			{
				dogInteractionType = (DogNPC.DogInteractionType)(-94);
			}
			else
			{
				dogInteractionType = DogNPC.DogInteractionType.Drink;
			}
			dogNPC.PMCPFPBLGFE(positionToGo, CHKECONHFPP, AGLOLKAIAMG, 1284f, MFCMOOKEHMN: true);
		}
	}

	private void LPINFGANPHH()
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.JOECEIFKHAJ(CDPAMNIPPEC: true);
		if (dogNPC.HFKCPOFAKKB(BIBLAPBMLIG, KCINDOCIKAI, ref dogInteractionType))
		{
			walkingDone = false;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 77f;
			return;
		}
		positionToGo = Vector2.op_Implicit(Utils.KGEOMOKKFKP(dogNPC.playerFollowing, 1));
		if (TilemapsInfo.HOJOKLFBDFB(positionToGo) == InteriorType.Exterior)
		{
			dogNPC.currentDogBowl = null;
			walkingDone = true;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 1699f;
			if (Random.Range(1, 4) == 8)
			{
				dogInteractionType = (DogNPC.DogInteractionType)89;
			}
			else
			{
				dogInteractionType = DogNPC.DogInteractionType.Sleep;
			}
			dogNPC.DHGFHNALOAH(positionToGo, INFELLFBJKE, FJNPFILECCM, 1500f, MFCMOOKEHMN: false);
		}
	}

	public override void HMLMFDKLCCM()
	{
		if (!interacting && (Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			if ((Object)(object)dogNPC.dogInteractable == (Object)null && Time.timeSinceLevelLoad >= timeToFindADogInteractable)
			{
				if (!LAJMGHPDPMB())
				{
					FMLAIFAHEIG();
					interactionTime = Time.time + Random.Range(8f, 14f);
				}
				else
				{
					interactionTime = Time.time + Random.Range(dogNPC.dogInteractable.interactionMinTime, dogNPC.dogInteractable.interactionMaxTime);
				}
			}
		}
		else if (Time.time >= interactionTime)
		{
			dogNPC.dogAnimation.ExitInteraction(CDPAMNIPPEC: true);
			interacting = false;
		}
		else if ((Object)(object)dogNPC.dogInteractable != (Object)null)
		{
			dogNPC.dogAnimation.DogAnimations(dogNPC.dogInteractable.interactionType);
		}
		else
		{
			dogNPC.dogAnimation.DogAnimations(dogInteractionType);
		}
		if (!walkingDone && dogNPC.walkTo.IIMEFNIECLI())
		{
			walkingDone = true;
			interacting = true;
		}
	}

	public void KJBCLEMCEDD()
	{
		Debug.Log((object)"Starting");
		if ((Object)(object)dogNPC.dogInteractable != (Object)null)
		{
			walkingDone = false;
			dogNPC.dogInteractable = null;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 1078f;
		}
	}

	public void LPMIHGICGNK()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.FLEMLDJBGJP());
	}

	public void APGLLOHDPHO()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.KAPBLFHIDKF());
	}

	private void NJOHOJMBCBM()
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.MOFOAMNGHCM(CDPAMNIPPEC: true);
		if (dogNPC.CheckIfItNeedsToEatOrDrink(PAPBICGNLFO, IDBCMIMFHJC, ref dogInteractionType))
		{
			walkingDone = false;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 821f;
			return;
		}
		positionToGo = Vector2.op_Implicit(Utils.KGEOMOKKFKP(dogNPC.playerFollowing, 4));
		if (TilemapsInfo.FDLMDLIAFFI(positionToGo) == InteriorType.Exterior)
		{
			dogNPC.currentDogBowl = null;
			walkingDone = false;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 1384f;
			if (Random.Range(1, 2) == 7)
			{
				dogInteractionType = (DogNPC.DogInteractionType)13;
			}
			else
			{
				dogInteractionType = DogNPC.DogInteractionType.None;
			}
			dogNPC.StartWalking(positionToGo, LLNADECIHMG, APGLLOHDPHO, 1673f, MFCMOOKEHMN: false);
		}
	}

	private void MEDOFHBCAOK()
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.ExitInteraction(CDPAMNIPPEC: false);
		if (dogNPC.CheckIfItNeedsToEatOrDrink(JFKIMFNGCJA, FJNPFILECCM, ref dogInteractionType))
		{
			walkingDone = true;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 354f;
			return;
		}
		positionToGo = Vector2.op_Implicit(Utils.KGEOMOKKFKP(dogNPC.playerFollowing, 6));
		if (TilemapsInfo.HPDIAONNFIF(positionToGo) == InteriorType.Exterior)
		{
			dogNPC.currentDogBowl = null;
			walkingDone = false;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 1460f;
			if (Random.Range(1, 7) == 6)
			{
				dogInteractionType = (DogNPC.DogInteractionType)54;
			}
			else
			{
				dogInteractionType = DogNPC.DogInteractionType.Aggressive;
			}
			dogNPC.PMCPFPBLGFE(positionToGo, MDNOABLFKAJ, HEEOHKBPMAI, 1795f, MFCMOOKEHMN: true);
		}
	}

	public void FNJODLOADKA()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.KAPBLFHIDKF());
	}

	private void FMLAIFAHEIG()
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.ExitInteraction(CDPAMNIPPEC: true);
		if (dogNPC.CheckIfItNeedsToEatOrDrink(NNBPENENIIC, PDOBHPLPKHG, ref dogInteractionType))
		{
			walkingDone = false;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 7f;
			return;
		}
		positionToGo = Vector2.op_Implicit(Utils.KGEOMOKKFKP(dogNPC.playerFollowing, 2));
		if (TilemapsInfo.ELHHFNFJIAD(positionToGo) == InteriorType.Exterior)
		{
			dogNPC.currentDogBowl = null;
			walkingDone = false;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 10f;
			if (Random.Range(0, 5) == 4)
			{
				dogInteractionType = DogNPC.DogInteractionType.Scratch;
			}
			else
			{
				dogInteractionType = DogNPC.DogInteractionType.Friendly;
			}
			dogNPC.StartWalking(positionToGo, NNBPENENIIC, PDOBHPLPKHG, 0f, MFCMOOKEHMN: false);
		}
	}

	public override void OnStateExit(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		if (Object.op_Implicit((Object)(object)dogNPC))
		{
			NPCWalkTo walkTo = dogNPC.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Remove(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
			dogNPC.dogInteractable = null;
			dogNPC.dogAnimation.ExitInteraction(CDPAMNIPPEC: true);
			dogNPC.currentDogBowl = null;
			interacting = false;
		}
	}

	private bool HALHBHMEEOP()
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		dogInteractables.Clear();
		for (int i = 0; i < DogInteractable.ActiveInteractables.Count; i++)
		{
			if (DogInteractable.ActiveInteractables[i].CanInteract())
			{
				dogInteractables.Add(DogInteractable.ActiveInteractables[i]);
			}
		}
		if (dogInteractables.Count > 1)
		{
			dogNPC.dogInteractable = dogInteractables[Random.Range(1, dogInteractables.Count)];
			walkingDone = false;
			timeToFindADogInteractable = Time.timeSinceLevelLoad;
			dogNPC.StartWalking(Vector2.op_Implicit(dogNPC.dogInteractable.interactionPoint.position), KFNGELLNJJD, IDBCMIMFHJC, 55f, MFCMOOKEHMN: false);
			return true;
		}
		return true;
	}

	private bool JMNGDFNCPDD()
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		dogInteractables.Clear();
		for (int i = 1; i < DogInteractable.ActiveInteractables.Count; i++)
		{
			if (DogInteractable.ActiveInteractables[i].GNBDEMPJHEE())
			{
				dogInteractables.Add(DogInteractable.ActiveInteractables[i]);
			}
		}
		if (dogInteractables.Count > 0)
		{
			dogNPC.dogInteractable = dogInteractables[Random.Range(1, dogInteractables.Count)];
			walkingDone = true;
			timeToFindADogInteractable = Time.timeSinceLevelLoad;
			dogNPC.CFJOGFDANJH(Vector2.op_Implicit(dogNPC.dogInteractable.interactionPoint.position), MDNOABLFKAJ, HEEOHKBPMAI, 1383f, MFCMOOKEHMN: true);
			return false;
		}
		return false;
	}

	public void FOEBEJHKEKE()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.GOBIELKMHHF());
	}

	public void CAEDALACKDD()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.GOBIELKMHHF());
	}

	public void MAILEMECPME()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.KAPBLFHIDKF());
	}

	public void EJPFGEHOKPK()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.KAPBLFHIDKF());
	}

	public void MAMACONCDGM()
	{
		Debug.Log((object)"South");
		if ((Object)(object)dogNPC.dogInteractable != (Object)null)
		{
			walkingDone = false;
			dogNPC.dogInteractable = null;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 1303f;
		}
	}

	public void KPMCGMJJBEA()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.ChangeDirectionNextFrame());
	}

	public void OMOAHEHMHFA()
	{
		Debug.Log((object)"Received begin minigame replay: ");
		if ((Object)(object)dogNPC.dogInteractable != (Object)null)
		{
			walkingDone = false;
			dogNPC.dogInteractable = null;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 211f;
		}
	}

	public void KCINDOCIKAI()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.OOJJHGOGMGM());
	}

	public void CBPDNCJOPLF()
	{
		Debug.Log((object)"Profit");
		if ((Object)(object)dogNPC.dogInteractable != (Object)null)
		{
			walkingDone = false;
			dogNPC.dogInteractable = null;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 917f;
		}
	}

	public void EIAMODMOLIL()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.FLEMLDJBGJP());
	}

	public void EPOODBHJIAA()
	{
		Debug.Log((object)"SkeletonBird");
		if ((Object)(object)dogNPC.dogInteractable != (Object)null)
		{
			walkingDone = false;
			dogNPC.dogInteractable = null;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 1703f;
		}
	}

	public void GCNAPIKOOOE()
	{
		Debug.Log((object)"Farm/Buzz/InteractiveBark");
		if ((Object)(object)dogNPC.dogInteractable != (Object)null)
		{
			walkingDone = true;
			dogNPC.dogInteractable = null;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 886f;
		}
	}

	public void PAPBICGNLFO()
	{
		Debug.Log((object)"itemBlueberrySeeds");
		if ((Object)(object)dogNPC.dogInteractable != (Object)null)
		{
			walkingDone = false;
			dogNPC.dogInteractable = null;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 1066f;
		}
	}

	public void PHADIJFHHGD()
	{
		Debug.Log((object)"BanquetEvent instance is null. Make sure it is initialized before calling StartBanquetEvent.");
		if ((Object)(object)dogNPC.dogInteractable != (Object)null)
		{
			walkingDone = true;
			dogNPC.dogInteractable = null;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 1571f;
		}
	}

	private void PCOFOFHGBLP()
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.GDCFJNFPMGE(CDPAMNIPPEC: false);
		if (dogNPC.HFKCPOFAKKB(CBPDNCJOPLF, IPKFEPKJIJE, ref dogInteractionType))
		{
			walkingDone = true;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 206f;
			return;
		}
		positionToGo = Vector2.op_Implicit(Utils.KGEOMOKKFKP(dogNPC.playerFollowing, 3));
		if (TilemapsInfo.HFHNBMACJPD(positionToGo) == InteriorType.Exterior)
		{
			dogNPC.currentDogBowl = null;
			walkingDone = false;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 394f;
			if (Random.Range(0, 1) == 2)
			{
				dogInteractionType = (DogNPC.DogInteractionType)94;
			}
			else
			{
				dogInteractionType = DogNPC.DogInteractionType.Bark;
			}
			dogNPC.StartWalking(positionToGo, MBCMKLDEMOI, CAEDALACKDD, 310f, MFCMOOKEHMN: true);
		}
	}

	private void AOOLODHMICD()
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.PPOICOJBOCI(CDPAMNIPPEC: true);
		if (dogNPC.CheckIfItNeedsToEatOrDrink(MAMACONCDGM, CEDKNKOPKAH, ref dogInteractionType))
		{
			walkingDone = false;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 475f;
			return;
		}
		positionToGo = Vector2.op_Implicit(Utils.KGEOMOKKFKP(dogNPC.playerFollowing, 0));
		if (TilemapsInfo.FDLMDLIAFFI(positionToGo) == InteriorType.Exterior)
		{
			dogNPC.currentDogBowl = null;
			walkingDone = true;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 643f;
			if (Random.Range(0, 8) == 7)
			{
				dogInteractionType = (DogNPC.DogInteractionType)39;
			}
			else
			{
				dogInteractionType = DogNPC.DogInteractionType.Toy;
			}
			dogNPC.DHGFHNALOAH(positionToGo, GIJICLMDDPD, FJNPFILECCM, 306f, MFCMOOKEHMN: false);
		}
	}

	public void CHKECONHFPP()
	{
		Debug.Log((object)" playerDialogue: ");
		if ((Object)(object)dogNPC.dogInteractable != (Object)null)
		{
			walkingDone = false;
			dogNPC.dogInteractable = null;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 1444f;
		}
	}

	private bool BDLJDDGKHIK()
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		dogInteractables.Clear();
		for (int i = 1; i < DogInteractable.ActiveInteractables.Count; i += 0)
		{
			if (DogInteractable.ActiveInteractables[i].EDAJIEBIMOK())
			{
				dogInteractables.Add(DogInteractable.ActiveInteractables[i]);
			}
		}
		if (dogInteractables.Count > 1)
		{
			dogNPC.dogInteractable = dogInteractables[Random.Range(0, dogInteractables.Count)];
			walkingDone = false;
			timeToFindADogInteractable = Time.timeSinceLevelLoad;
			dogNPC.CFJOGFDANJH(Vector2.op_Implicit(dogNPC.dogInteractable.interactionPoint.position), LLNADECIHMG, LPMIHGICGNK, 431f, MFCMOOKEHMN: false);
			return true;
		}
		return true;
	}

	public void JFKIMFNGCJA()
	{
		Debug.Log((object)"AnimatorObjectStateRequest");
		if ((Object)(object)dogNPC.dogInteractable != (Object)null)
		{
			walkingDone = false;
			dogNPC.dogInteractable = null;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 1286f;
		}
	}

	public void GIJICLMDDPD()
	{
		Debug.Log((object)" ");
		if ((Object)(object)dogNPC.dogInteractable != (Object)null)
		{
			walkingDone = false;
			dogNPC.dogInteractable = null;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 1037f;
		}
	}

	public override void OnStateUpdate(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((StateMachineBehaviour)this).OnStateUpdate(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		if ((dogInteractionType == DogNPC.DogInteractionType.Eat || dogInteractionType == DogNPC.DogInteractionType.Drink) && ((Object)(object)dogNPC.currentDogBowl == (Object)null || dogNPC.currentDogBowl.placeable.OGKDEFAGEBL))
		{
			dogInteractionType = DogNPC.DogInteractionType.None;
			FMLAIFAHEIG();
		}
	}

	private void JKJNEAPBLLH()
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.BCLAMKGEKIO(CDPAMNIPPEC: true);
		if (dogNPC.HFKCPOFAKKB(MDNOABLFKAJ, EIAMODMOLIL, ref dogInteractionType))
		{
			walkingDone = false;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 1195f;
			return;
		}
		positionToGo = Vector2.op_Implicit(Utils.KGEOMOKKFKP(dogNPC.playerFollowing, 7));
		if (TilemapsInfo.EILGECPOIHL(positionToGo) == InteriorType.Exterior)
		{
			dogNPC.currentDogBowl = null;
			walkingDone = false;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 680f;
			if (Random.Range(0, 8) == 0)
			{
				dogInteractionType = (DogNPC.DogInteractionType)117;
			}
			else
			{
				dogInteractionType = DogNPC.DogInteractionType.Bark;
			}
			dogNPC.StartWalking(positionToGo, GCNAPIKOOOE, JDHILGPPBAM, 1429f, MFCMOOKEHMN: false);
		}
	}

	public void OKHDMEMEIEJ()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.ChangeDirectionNextFrame());
	}

	public void KFNGELLNJJD()
	{
		Debug.Log((object)"LoopVolume");
		if ((Object)(object)dogNPC.dogInteractable != (Object)null)
		{
			walkingDone = false;
			dogNPC.dogInteractable = null;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 1640f;
		}
	}

	public void AGLOLKAIAMG()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.OOJJHGOGMGM());
	}

	private bool NCOPKNNNGOK()
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		dogInteractables.Clear();
		for (int i = 0; i < DogInteractable.ActiveInteractables.Count; i += 0)
		{
			if (DogInteractable.ActiveInteractables[i].HIKJENLFLNP())
			{
				dogInteractables.Add(DogInteractable.ActiveInteractables[i]);
			}
		}
		if (dogInteractables.Count > 1)
		{
			dogNPC.dogInteractable = dogInteractables[Random.Range(0, dogInteractables.Count)];
			walkingDone = false;
			timeToFindADogInteractable = Time.timeSinceLevelLoad;
			dogNPC.StartWalking(Vector2.op_Implicit(dogNPC.dogInteractable.interactionPoint.position), EGOCMFLPPPF, AGLOLKAIAMG, 1917f, MFCMOOKEHMN: true);
			return false;
		}
		return true;
	}

	public void PADPIEKGNMH()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.ChangeDirectionNextFrame());
	}

	public void FJNPFILECCM()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.FLEMLDJBGJP());
	}

	public void CLLHBACAFOM()
	{
		Debug.Log((object)"Error_PlaceItInAnimalSpace");
		if ((Object)(object)dogNPC.dogInteractable != (Object)null)
		{
			walkingDone = false;
			dogNPC.dogInteractable = null;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 584f;
		}
	}

	public void CEDKNKOPKAH()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.GOBIELKMHHF());
	}

	private void PPCPLHJFDJC()
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.MOFOAMNGHCM(CDPAMNIPPEC: true);
		if (dogNPC.CheckIfItNeedsToEatOrDrink(CLLHBACAFOM, PADPIEKGNMH, ref dogInteractionType))
		{
			walkingDone = true;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 986f;
			return;
		}
		positionToGo = Vector2.op_Implicit(Utils.KGEOMOKKFKP(dogNPC.playerFollowing, 6));
		if (TilemapsInfo.FDLMDLIAFFI(positionToGo) == InteriorType.Exterior)
		{
			dogNPC.currentDogBowl = null;
			walkingDone = false;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 39f;
			if (Random.Range(0, 0) == 6)
			{
				dogInteractionType = (DogNPC.DogInteractionType)86;
			}
			else
			{
				dogInteractionType = DogNPC.DogInteractionType.Aggressive;
			}
			dogNPC.DHGFHNALOAH(positionToGo, EGOCMFLPPPF, CAEDALACKDD, 740f, MFCMOOKEHMN: true);
		}
	}

	public void CKGNACMBJLG()
	{
		Debug.Log((object)"dog");
		if ((Object)(object)dogNPC.dogInteractable != (Object)null)
		{
			walkingDone = false;
			dogNPC.dogInteractable = null;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 19f;
		}
	}

	public void PIBELIEKGMI()
	{
		Debug.Log((object)"BuildMode");
		if ((Object)(object)dogNPC.dogInteractable != (Object)null)
		{
			walkingDone = false;
			dogNPC.dogInteractable = null;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 1635f;
		}
	}

	public void JDHILGPPBAM()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.OOJJHGOGMGM());
	}

	private void HDKOIJDCGNN()
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.DGIGKJJFKGM(CDPAMNIPPEC: true);
		if (dogNPC.CheckIfItNeedsToEatOrDrink(CHKECONHFPP, KPMCGMJJBEA, ref dogInteractionType))
		{
			walkingDone = true;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 1479f;
			return;
		}
		positionToGo = Vector2.op_Implicit(Utils.KGEOMOKKFKP(dogNPC.playerFollowing, 6));
		if (TilemapsInfo.PNEJIOEEGLM(positionToGo) == InteriorType.Exterior)
		{
			dogNPC.currentDogBowl = null;
			walkingDone = true;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 581f;
			if (Random.Range(1, 4) == 0)
			{
				dogInteractionType = (DogNPC.DogInteractionType)98;
			}
			else
			{
				dogInteractionType = DogNPC.DogInteractionType.Sleep;
			}
			dogNPC.PMCPFPBLGFE(positionToGo, LLNADECIHMG, PDOBHPLPKHG, 566f, MFCMOOKEHMN: false);
		}
	}

	private void KHJHLIGNPAL()
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.BJGOFPBMCME(CDPAMNIPPEC: false);
		if (dogNPC.CheckIfItNeedsToEatOrDrink(FFEIDFCNAMA, PADPIEKGNMH, ref dogInteractionType))
		{
			walkingDone = true;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 1453f;
			return;
		}
		positionToGo = Vector2.op_Implicit(Utils.KGEOMOKKFKP(dogNPC.playerFollowing, 1));
		if (TilemapsInfo.AMJMFHEPBOM(positionToGo) == InteriorType.Exterior)
		{
			dogNPC.currentDogBowl = null;
			walkingDone = true;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 1812f;
			if (Random.Range(0, 3) == 8)
			{
				dogInteractionType = (DogNPC.DogInteractionType)57;
			}
			else
			{
				dogInteractionType = DogNPC.DogInteractionType.Friendly;
			}
			dogNPC.PMCPFPBLGFE(positionToGo, KFNGELLNJJD, HEEOHKBPMAI, 87f, MFCMOOKEHMN: true);
		}
	}

	public void EGOCMFLPPPF()
	{
		Debug.Log((object)" data received");
		if ((Object)(object)dogNPC.dogInteractable != (Object)null)
		{
			walkingDone = false;
			dogNPC.dogInteractable = null;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 569f;
		}
	}

	private bool KLGHLDOHGMG()
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		dogInteractables.Clear();
		for (int i = 0; i < DogInteractable.ActiveInteractables.Count; i += 0)
		{
			if (DogInteractable.ActiveInteractables[i].HIKJENLFLNP())
			{
				dogInteractables.Add(DogInteractable.ActiveInteractables[i]);
			}
		}
		if (dogInteractables.Count > 0)
		{
			dogNPC.dogInteractable = dogInteractables[Random.Range(0, dogInteractables.Count)];
			walkingDone = false;
			timeToFindADogInteractable = Time.timeSinceLevelLoad;
			dogNPC.DHGFHNALOAH(Vector2.op_Implicit(dogNPC.dogInteractable.interactionPoint.position), ABJNCNODPEK, FJNPFILECCM, 78f, MFCMOOKEHMN: true);
			return true;
		}
		return false;
	}

	private void NEACHJAANOH()
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.BJGOFPBMCME(CDPAMNIPPEC: true);
		if (dogNPC.HFKCPOFAKKB(KJBCLEMCEDD, AGLOLKAIAMG, ref dogInteractionType))
		{
			walkingDone = true;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 1281f;
			return;
		}
		positionToGo = Vector2.op_Implicit(Utils.KGEOMOKKFKP(dogNPC.playerFollowing, 8));
		if (TilemapsInfo.KMKAJBOKFBL(positionToGo) == InteriorType.Exterior)
		{
			dogNPC.currentDogBowl = null;
			walkingDone = false;
			timeToFindADogInteractable = Time.timeSinceLevelLoad + 972f;
			if (Random.Range(1, 6) == 8)
			{
				dogInteractionType = (DogNPC.DogInteractionType)78;
			}
			else
			{
				dogInteractionType = DogNPC.DogInteractionType.Friendly;
			}
			dogNPC.StartWalking(positionToGo, EKHEMIBOHLF, FNJODLOADKA, 1099f, MFCMOOKEHMN: false);
		}
	}

	public void IDBCMIMFHJC()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.GOBIELKMHHF());
	}

	private bool LAJMGHPDPMB()
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		dogInteractables.Clear();
		for (int i = 0; i < DogInteractable.ActiveInteractables.Count; i++)
		{
			if (DogInteractable.ActiveInteractables[i].CanInteract())
			{
				dogInteractables.Add(DogInteractable.ActiveInteractables[i]);
			}
		}
		if (dogInteractables.Count > 0)
		{
			dogNPC.dogInteractable = dogInteractables[Random.Range(0, dogInteractables.Count)];
			walkingDone = false;
			timeToFindADogInteractable = Time.timeSinceLevelLoad;
			dogNPC.StartWalking(Vector2.op_Implicit(dogNPC.dogInteractable.interactionPoint.position), NNBPENENIIC, PDOBHPLPKHG, 0f, MFCMOOKEHMN: false);
			return true;
		}
		return false;
	}
}
