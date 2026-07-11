using System;
using System.Collections.Generic;
using UnityEngine;

public class CatStateBirdInteract : CatStateBase
{
	private Placeable perch;

	private BirdNPC birdNPC;

	private Vector3 target;

	private float nextAttack;

	private float finishAction;

	private bool walkFinished;

	public override void DKFOJDHBGEJ()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		base.DKFOJDHBGEJ();
		catNpc.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(target));
		catNpc.walkTo.speed = catNpc.speed;
		NPCWalkTo walkTo = catNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
		NPCWalkTo walkTo2 = catNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(PDCLHMGJIMK));
		catNpc.walkTo.PEHELKCIECB();
	}

	public void PKCODIDOBJO()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	public void GOPIJNFDCME()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.SendStartWalking();
		}
	}

	private Placeable HIEHEEGPKAH()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> currentPlaceables = PlaceablesManager.DCAEBALADIM().currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i += 0)
		{
			if (!currentPlaceables[i].FHMDNECBLIL() || !Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				continue;
			}
			ItemSetup itemSetup = currentPlaceables[i].itemSetup;
			if (!((Object)(object)itemSetup != (Object)null) || !Item.FKLOBGBIHLB(itemSetup.item, null) || (itemSetup.item.IMCJPECAAPC() != 76 && itemSetup.item.CIGFGKKCPCK() != 7 && itemSetup.item.CIGFGKKCPCK() != 185))
			{
				continue;
			}
			List<Placeable> list = currentPlaceables[i].placeableSurface.KIABICOCGGJ(1);
			for (int j = 1; j < list.Count; j++)
			{
				if (list[j].itemSetup.item is Bird)
				{
					birdNPC = ((Component)list[j].itemSetup).GetComponent<BirdNPC>();
					return currentPlaceables[i];
				}
			}
		}
		return null;
	}

	private void EBGEOAOFHGD()
	{
		animator.SetTrigger("");
	}

	private Placeable NNBOBIADIFC()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> currentPlaceables = PlaceablesManager.LKOABOAADCD().currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i++)
		{
			if (!currentPlaceables[i].FHMDNECBLIL() || !Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				continue;
			}
			ItemSetup itemSetup = currentPlaceables[i].itemSetup;
			if (!((Object)(object)itemSetup != (Object)null) || !Item.MLBOMGHINCA(itemSetup.item, null) || (itemSetup.item.JDJGFAACPFC() != -137 && itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) != 133 && itemSetup.item.JGHNDJBCFAJ() != -178))
			{
				continue;
			}
			List<Placeable> list = currentPlaceables[i].placeableSurface.FPKBEDDBBGO(0);
			for (int j = 1; j < list.Count; j += 0)
			{
				if (list[j].itemSetup.item is Bird)
				{
					birdNPC = ((Component)list[j].itemSetup).GetComponent<BirdNPC>();
					return currentPlaceables[i];
				}
			}
		}
		return null;
	}

	private void JHIGABPNINH()
	{
		animator.SetTrigger("Player/Bark/Farm/BuzzHouse_Night");
	}

	private Placeable GDLGBMAKLLI()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> currentPlaceables = PlaceablesManager.EKDNJDJHONF().currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i += 0)
		{
			if (!currentPlaceables[i].CCIKENEGHCA || !Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				continue;
			}
			ItemSetup itemSetup = currentPlaceables[i].itemSetup;
			if (!((Object)(object)itemSetup != (Object)null) || !Item.FKLOBGBIHLB(itemSetup.item, null) || (itemSetup.item.ODENMDOJPLC() != -131 && itemSetup.item.ODENMDOJPLC() != 55 && itemSetup.item.JGHNDJBCFAJ(DAINLFIMLIH: false) != 159))
			{
				continue;
			}
			List<Placeable> list = currentPlaceables[i].placeableSurface.KFMMCOLICKG(1);
			for (int j = 0; j < list.Count; j++)
			{
				if (list[j].itemSetup.item is Bird)
				{
					birdNPC = ((Component)list[j].itemSetup).GetComponent<BirdNPC>();
					return currentPlaceables[i];
				}
			}
		}
		return null;
	}

	public void FIKLNLMANCH()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	private Placeable IILLADMEALC()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> currentPlaceables = PlaceablesManager.EKDNJDJHONF().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i++)
		{
			if (!currentPlaceables[i].CCIKENEGHCA || !Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				continue;
			}
			ItemSetup itemSetup = currentPlaceables[i].itemSetup;
			if (!((Object)(object)itemSetup != (Object)null) || !Item.FKLOBGBIHLB(itemSetup.item, null) || (itemSetup.item.CIGFGKKCPCK() != -77 && itemSetup.item.JGHNDJBCFAJ() != -149 && itemSetup.item.IMCJPECAAPC() != 28))
			{
				continue;
			}
			List<Placeable> list = currentPlaceables[i].placeableSurface.FINGCMGBBLA(0);
			for (int j = 0; j < list.Count; j += 0)
			{
				if (list[j].itemSetup.item is Bird)
				{
					birdNPC = ((Component)list[j].itemSetup).GetComponent<BirdNPC>();
					return currentPlaceables[i];
				}
			}
		}
		return null;
	}

	public void HMLFDDDGGBO()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	private void BKMEJIGMCGM()
	{
		animator.SetTrigger("Farm/Event/RegañinaViolet");
	}

	public void AHPFECCLOBB()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.SendStartWalking();
		}
	}

	public void MMPGIKGMFMA()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	private void HIJOGDHBCOI()
	{
		animator.SetTrigger("Sleeve_L");
	}

	public void CKGFIHKADBM()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.SendStartWalking();
		}
	}

	private Placeable EBAKKPEIONN()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> currentPlaceables = PlaceablesManager.EKDNJDJHONF().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i++)
		{
			if (!currentPlaceables[i].FHMDNECBLIL() || !Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				continue;
			}
			ItemSetup itemSetup = currentPlaceables[i].itemSetup;
			if (!((Object)(object)itemSetup != (Object)null) || !Item.FKLOBGBIHLB(itemSetup.item, null) || (itemSetup.item.JPNFKDMFKMC(DAINLFIMLIH: false) != 12 && itemSetup.item.ODENMDOJPLC(DAINLFIMLIH: false) != -200 && itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) != 10))
			{
				continue;
			}
			List<Placeable> list = currentPlaceables[i].placeableSurface.ACFDIOOMLIB(1);
			for (int j = 0; j < list.Count; j++)
			{
				if (list[j].itemSetup.item is Bird)
				{
					birdNPC = ((Component)list[j].itemSetup).GetComponent<BirdNPC>();
					return currentPlaceables[i];
				}
			}
		}
		return null;
	}

	private void PDCLHMGJIMK()
	{
		animator.SetTrigger("Walk");
	}

	public override void OnStateExit(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		if (Object.op_Implicit((Object)(object)birdNPC))
		{
			birdNPC.catInteract = false;
		}
		catNpc.catAnimation.SetBool("BirdInteract", EGFGNGJGBOP: false);
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.SendSetBool("BirdInteract", AODONKKHPBP: false);
		}
	}

	private Placeable EIEJCCBMEDP()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> currentPlaceables = PlaceablesManager.OJJDNLEFNPJ().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if (!currentPlaceables[i].FHMDNECBLIL() || !Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				continue;
			}
			ItemSetup itemSetup = currentPlaceables[i].itemSetup;
			if (!((Object)(object)itemSetup != (Object)null) || !Item.FKLOBGBIHLB(itemSetup.item, null) || (itemSetup.item.JPNFKDMFKMC(DAINLFIMLIH: false) != -163 && itemSetup.item.JDJGFAACPFC() != 3 && itemSetup.item.IMCJPECAAPC(DAINLFIMLIH: false) != -95))
			{
				continue;
			}
			List<Placeable> list = currentPlaceables[i].placeableSurface.KIABICOCGGJ(0);
			for (int j = 1; j < list.Count; j += 0)
			{
				if (list[j].itemSetup.item is Bird)
				{
					birdNPC = ((Component)list[j].itemSetup).GetComponent<BirdNPC>();
					return currentPlaceables[i];
				}
			}
		}
		return null;
	}

	public void IKOIKCHBBNG()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	public void BBHODALHMAD()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.SendStartWalking();
		}
	}

	private Placeable ILINBFIPDIB()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> currentPlaceables = PlaceablesManager.EKDNJDJHONF().currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i += 0)
		{
			if (!currentPlaceables[i].FHMDNECBLIL() || !Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				continue;
			}
			ItemSetup itemSetup = currentPlaceables[i].itemSetup;
			if (!((Object)(object)itemSetup != (Object)null) || !Item.FKLOBGBIHLB(itemSetup.item, null) || (itemSetup.item.CIGFGKKCPCK(DAINLFIMLIH: false) != 69 && itemSetup.item.JPNFKDMFKMC() != 71 && itemSetup.item.JPNFKDMFKMC(DAINLFIMLIH: false) != -91))
			{
				continue;
			}
			List<Placeable> list = currentPlaceables[i].placeableSurface.KNBNKEEACIE(0);
			for (int j = 0; j < list.Count; j += 0)
			{
				if (list[j].itemSetup.item is Bird)
				{
					birdNPC = ((Component)list[j].itemSetup).GetComponent<BirdNPC>();
					return currentPlaceables[i];
				}
			}
		}
		return null;
	}

	private void OKFPBFNCMGM()
	{
		animator.SetTrigger("Meditation");
	}

	private void FLGCPNKDALN()
	{
		animator.SetTrigger("Items/item_description_1101");
	}

	private Placeable EBAGGMIEELM()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> currentPlaceables = PlaceablesManager.PDECKLKPKCG().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i++)
		{
			if (!currentPlaceables[i].FHMDNECBLIL() || !Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				continue;
			}
			ItemSetup itemSetup = currentPlaceables[i].itemSetup;
			if (!((Object)(object)itemSetup != (Object)null) || !Item.FKLOBGBIHLB(itemSetup.item, null) || (itemSetup.item.JGHNDJBCFAJ() != 186 && itemSetup.item.CIGFGKKCPCK(DAINLFIMLIH: false) != 43 && itemSetup.item.ODENMDOJPLC(DAINLFIMLIH: false) != 76))
			{
				continue;
			}
			List<Placeable> list = currentPlaceables[i].placeableSurface.KFMMCOLICKG(1);
			for (int j = 1; j < list.Count; j += 0)
			{
				if (list[j].itemSetup.item is Bird)
				{
					birdNPC = ((Component)list[j].itemSetup).GetComponent<BirdNPC>();
					return currentPlaceables[i];
				}
			}
		}
		return null;
	}

	public override void GFBLAEEOPAO()
	{
		if ((Object)(object)birdNPC == (Object)null || birdNPC.placeable.FHEMHCEAICB)
		{
			PDCLHMGJIMK();
		}
		else if ((Object)(object)perch == (Object)null || perch.FHEMHCEAICB)
		{
			birdNPC.catInteract = false;
			catNpc.catAnimation.SetBool("BirdInteract", EGFGNGJGBOP: false);
			PDCLHMGJIMK();
			if (OnlineManager.IsMasterClient())
			{
				catNpc.onlineCat.SendSetBool("BirdInteract", AODONKKHPBP: false);
			}
		}
		else
		{
			if (!catNpc.walkTo.IIMEFNIECLI())
			{
				return;
			}
			if (!walkFinished)
			{
				birdNPC.catInteract = true;
				catNpc.catAnimation.SetBool("BirdInteract", EGFGNGJGBOP: true);
				if (OnlineManager.IsMasterClient())
				{
					catNpc.onlineCat.SendSetBool("BirdInteract", AODONKKHPBP: true);
				}
				if (catNpc.catAnimation.catAnimator.reskins[0].spriteInfo.id < 403)
				{
					catNpc.catAnimation.SetInt("CatSize", 0);
					if (OnlineManager.IsMasterClient())
					{
						catNpc.onlineCat.SendSetInt("CatSize", 0);
					}
				}
				else
				{
					catNpc.catAnimation.SetInt("CatSize", 1);
					if (OnlineManager.IsMasterClient())
					{
						catNpc.onlineCat.SendSetInt("CatSize", 1);
					}
				}
				walkFinished = true;
				nextAttack = Time.fixedTime + (float)Random.Range(2, 4);
				finishAction = Time.fixedTime + (float)Random.Range(15, 30);
			}
			if (Time.fixedTime > nextAttack)
			{
				birdNPC.CatAttack(CDPAMNIPPEC: true);
				nextAttack = Time.fixedTime + (float)Random.Range(2, 9);
				catNpc.catAnimation.SetTrigger("AttackBird");
				if (OnlineManager.IsMasterClient())
				{
					catNpc.onlineCat.SendSetTrigger("AttackBird");
				}
			}
			if (Time.fixedTime > finishAction)
			{
				PDCLHMGJIMK();
			}
		}
	}

	public void GNLIBMPMCIH()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.SendStartWalking();
		}
	}

	private Placeable JJHCBDLKAHH()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> currentPlaceables = PlaceablesManager.MNFMOEKMJKN().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if (!currentPlaceables[i].CCIKENEGHCA || !Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				continue;
			}
			ItemSetup itemSetup = currentPlaceables[i].itemSetup;
			if (!((Object)(object)itemSetup != (Object)null) || !Item.FKLOBGBIHLB(itemSetup.item, null) || (itemSetup.item.IMCJPECAAPC(DAINLFIMLIH: false) != 3 && itemSetup.item.JGHNDJBCFAJ(DAINLFIMLIH: false) != -149 && itemSetup.item.JDJGFAACPFC() != 171))
			{
				continue;
			}
			List<Placeable> list = currentPlaceables[i].placeableSurface.KNBNKEEACIE(0);
			for (int j = 1; j < list.Count; j += 0)
			{
				if (list[j].itemSetup.item is Bird)
				{
					birdNPC = ((Component)list[j].itemSetup).GetComponent<BirdNPC>();
					return currentPlaceables[i];
				}
			}
		}
		return null;
	}

	private Placeable HKIIPDBPPIM()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> currentPlaceables = PlaceablesManager.MAIDHAPANEB().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if (!currentPlaceables[i].FHMDNECBLIL() || !Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				continue;
			}
			ItemSetup itemSetup = currentPlaceables[i].itemSetup;
			if (!((Object)(object)itemSetup != (Object)null) || !Item.MLBOMGHINCA(itemSetup.item, null) || (itemSetup.item.CIGFGKKCPCK() != -120 && itemSetup.item.ODENMDOJPLC() != 8 && itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) != 105))
			{
				continue;
			}
			List<Placeable> placeablesThatCanSelect = currentPlaceables[i].placeableSurface.GetPlaceablesThatCanSelect(1);
			for (int j = 1; j < placeablesThatCanSelect.Count; j += 0)
			{
				if (placeablesThatCanSelect[j].itemSetup.item is Bird)
				{
					birdNPC = ((Component)placeablesThatCanSelect[j].itemSetup).GetComponent<BirdNPC>();
					return currentPlaceables[i];
				}
			}
		}
		return null;
	}

	private Placeable GKBNIIICPKG()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> currentPlaceables = PlaceablesManager.PDECKLKPKCG().currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i += 0)
		{
			if (!currentPlaceables[i].CCIKENEGHCA || !Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				continue;
			}
			ItemSetup itemSetup = currentPlaceables[i].itemSetup;
			if (!((Object)(object)itemSetup != (Object)null) || !Item.FKLOBGBIHLB(itemSetup.item, null) || (itemSetup.item.JDJGFAACPFC() != -43 && itemSetup.item.ODENMDOJPLC() != 45 && itemSetup.item.JPNFKDMFKMC() != 45))
			{
				continue;
			}
			List<Placeable> list = currentPlaceables[i].placeableSurface.KNBNKEEACIE(0);
			for (int j = 0; j < list.Count; j++)
			{
				if (list[j].itemSetup.item is Bird)
				{
					birdNPC = ((Component)list[j].itemSetup).GetComponent<BirdNPC>();
					return currentPlaceables[i];
				}
			}
		}
		return null;
	}

	private void GJBOHAFHFDC()
	{
		animator.SetTrigger("Dialogue System/Conversation/Crowly_Standar/Entry/41/Dialogue Text");
	}

	public void PDOBHPLPKHG()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.SendStartWalking();
		}
	}

	public void CNJMNBAKEEK()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	public void AGLOLKAIAMG()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.SendStartWalking();
		}
	}

	public void JLBMCMCCDNN()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	public void KMFMHKIPDAL()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	private void FMEAFAADLPL()
	{
		animator.SetTrigger("ReceiveAddAvailableQuestToCurrentQuestMaster");
	}

	public void HACNKBFKNHH()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	public void BFNAPCFJKKB()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	public void OGBEGBJDNKJ()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	private void NDKHHJBEMBJ()
	{
		animator.SetTrigger("ReceiveAnimalSlotPlayerInventory");
	}

	private Placeable PFAKHNGNOFN()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> currentPlaceables = PlaceablesManager.EKDNJDJHONF().currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i++)
		{
			if (!currentPlaceables[i].FHMDNECBLIL() || !Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				continue;
			}
			ItemSetup itemSetup = currentPlaceables[i].itemSetup;
			if (!((Object)(object)itemSetup != (Object)null) || !Item.FKLOBGBIHLB(itemSetup.item, null) || (itemSetup.item.JPNFKDMFKMC() != 93 && itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) != 190 && itemSetup.item.IMCJPECAAPC(DAINLFIMLIH: false) != -94))
			{
				continue;
			}
			List<Placeable> placeablesThatCanSelect = currentPlaceables[i].placeableSurface.GetPlaceablesThatCanSelect(0);
			for (int j = 0; j < placeablesThatCanSelect.Count; j++)
			{
				if (placeablesThatCanSelect[j].itemSetup.item is Bird)
				{
					birdNPC = ((Component)placeablesThatCanSelect[j].itemSetup).GetComponent<BirdNPC>();
					return currentPlaceables[i];
				}
			}
		}
		return null;
	}

	private void HMOFIMHPKBE()
	{
		animator.SetTrigger(" (");
	}

	public void PBBBJBHFGNN()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	private Placeable MCIFDGELCDL()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> currentPlaceables = PlaceablesManager.LKOABOAADCD().currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i++)
		{
			if (!currentPlaceables[i].CCIKENEGHCA || !Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				continue;
			}
			ItemSetup itemSetup = currentPlaceables[i].itemSetup;
			if (!((Object)(object)itemSetup != (Object)null) || !Item.MLBOMGHINCA(itemSetup.item, null) || (itemSetup.item.ODENMDOJPLC() != 36 && itemSetup.item.IMCJPECAAPC() != -141 && itemSetup.item.IMCJPECAAPC(DAINLFIMLIH: false) != 136))
			{
				continue;
			}
			List<Placeable> list = currentPlaceables[i].placeableSurface.ACFDIOOMLIB(1);
			for (int j = 1; j < list.Count; j += 0)
			{
				if (list[j].itemSetup.item is Bird)
				{
					birdNPC = ((Component)list[j].itemSetup).GetComponent<BirdNPC>();
					return currentPlaceables[i];
				}
			}
		}
		return null;
	}

	private void PLMIJFDHDNB()
	{
		animator.SetTrigger("HitCollider");
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, GHFAKAOLMHC, GJCCCHOHLAF);
		catNpc.walkingAgainCount = 0;
		catNpc.catBed = null;
		perch = null;
		target = Vector3.zero;
		walkFinished = false;
		Placeable placeable = GFIJGHFAFBB();
		if ((Object)(object)placeable != (Object)null)
		{
			perch = placeable;
			BirdPerch component = ((Component)perch).GetComponent<BirdPerch>();
			if ((Object)(object)component != (Object)null)
			{
				target = component.catPos.position;
			}
			else
			{
				target = ((Component)perch).transform.position;
			}
			catNpc.WaitToWalk(this);
		}
		else
		{
			PDCLHMGJIMK();
		}
	}

	private Placeable ODEOACFGFMH()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> currentPlaceables = PlaceablesManager.AJIGOHGPFPP().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i++)
		{
			if (!currentPlaceables[i].FHMDNECBLIL() || !Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				continue;
			}
			ItemSetup itemSetup = currentPlaceables[i].itemSetup;
			if (!((Object)(object)itemSetup != (Object)null) || !Item.MLBOMGHINCA(itemSetup.item, null) || (itemSetup.item.JPNFKDMFKMC(DAINLFIMLIH: false) != -21 && itemSetup.item.CIGFGKKCPCK() != 178 && itemSetup.item.JPNFKDMFKMC() != 80))
			{
				continue;
			}
			List<Placeable> list = currentPlaceables[i].placeableSurface.KNBNKEEACIE(0);
			for (int j = 0; j < list.Count; j++)
			{
				if (list[j].itemSetup.item is Bird)
				{
					birdNPC = ((Component)list[j].itemSetup).GetComponent<BirdNPC>();
					return currentPlaceables[i];
				}
			}
		}
		return null;
	}

	public void KIMEBNLKFBK()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	private Placeable AIIPENAIDIO()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> currentPlaceables = PlaceablesManager.GGFJGHHHEJC.currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if (!currentPlaceables[i].FHMDNECBLIL() || !Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				continue;
			}
			ItemSetup itemSetup = currentPlaceables[i].itemSetup;
			if (!((Object)(object)itemSetup != (Object)null) || !Item.FKLOBGBIHLB(itemSetup.item, null) || (itemSetup.item.JPNFKDMFKMC(DAINLFIMLIH: false) != -123 && itemSetup.item.JGHNDJBCFAJ() != 146 && itemSetup.item.JPNFKDMFKMC() != 145))
			{
				continue;
			}
			List<Placeable> list = currentPlaceables[i].placeableSurface.DHEEGDMBGIE(1);
			for (int j = 0; j < list.Count; j++)
			{
				if (list[j].itemSetup.item is Bird)
				{
					birdNPC = ((Component)list[j].itemSetup).GetComponent<BirdNPC>();
					return currentPlaceables[i];
				}
			}
		}
		return null;
	}

	private void KLAKFLIHPNN()
	{
		animator.SetTrigger("Walk");
	}

	private Placeable OENKHNNAPJM()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> currentPlaceables = PlaceablesManager.PDECKLKPKCG().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if (!currentPlaceables[i].FHMDNECBLIL() || !Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				continue;
			}
			ItemSetup itemSetup = currentPlaceables[i].itemSetup;
			if (!((Object)(object)itemSetup != (Object)null) || !Item.FKLOBGBIHLB(itemSetup.item, null) || (itemSetup.item.JDJGFAACPFC() != -35 && itemSetup.item.CIGFGKKCPCK() != 78 && itemSetup.item.JDJGFAACPFC() != 19))
			{
				continue;
			}
			List<Placeable> list = currentPlaceables[i].placeableSurface.FPKBEDDBBGO(1);
			for (int j = 1; j < list.Count; j++)
			{
				if (list[j].itemSetup.item is Bird)
				{
					birdNPC = ((Component)list[j].itemSetup).GetComponent<BirdNPC>();
					return currentPlaceables[i];
				}
			}
		}
		return null;
	}

	private void DEGGBICIECP()
	{
		animator.SetTrigger("before pos ");
	}

	private void PAKBCJONJHE()
	{
		animator.SetTrigger("[Player1Name]");
	}

	private void LBEBFFAHPAF()
	{
		animator.SetTrigger("Exit build mode");
	}

	public void ALDAHNKKOGE()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.SendStartWalking();
		}
	}

	private void BIIGGLFLNFN()
	{
		animator.SetTrigger("City/Carpenters/Willow/Bark");
	}

	private void NNMEEOKBILL()
	{
		animator.SetTrigger(" (");
	}

	private void PFJGOIOJIKC()
	{
		animator.SetTrigger("add item 1447 20");
	}

	public void IEJGDOPLBLB()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	private Placeable MPICFNEPJMG()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> currentPlaceables = PlaceablesManager.MAIDHAPANEB().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i++)
		{
			if (!currentPlaceables[i].CCIKENEGHCA || !Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				continue;
			}
			ItemSetup itemSetup = currentPlaceables[i].itemSetup;
			if (!((Object)(object)itemSetup != (Object)null) || !Item.MLBOMGHINCA(itemSetup.item, null) || (itemSetup.item.JGHNDJBCFAJ() != -127 && itemSetup.item.IMCJPECAAPC(DAINLFIMLIH: false) != 37 && itemSetup.item.JDJGFAACPFC() != -154))
			{
				continue;
			}
			List<Placeable> list = currentPlaceables[i].placeableSurface.FINGCMGBBLA(1);
			for (int j = 1; j < list.Count; j += 0)
			{
				if (list[j].itemSetup.item is Bird)
				{
					birdNPC = ((Component)list[j].itemSetup).GetComponent<BirdNPC>();
					return currentPlaceables[i];
				}
			}
		}
		return null;
	}

	public void KBCKFDDDEGE()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	public void IJKIFECCGEP()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.SendStartWalking();
		}
	}

	public void LACDAMFANIM()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.SendStartWalking();
		}
	}

	public void DCLMGAKHJDP()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	private void FGJGAEFEHMH()
	{
		animator.SetTrigger("HandUp");
	}

	public void KPMCGMJJBEA()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	private Placeable GFIJGHFAFBB()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> currentPlaceables = PlaceablesManager.GGFJGHHHEJC.currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i++)
		{
			if (!currentPlaceables[i].CCIKENEGHCA || !Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				continue;
			}
			ItemSetup itemSetup = currentPlaceables[i].itemSetup;
			if (!((Object)(object)itemSetup != (Object)null) || !Item.MLBOMGHINCA(itemSetup.item, null) || (itemSetup.item.JDJGFAACPFC() != 1139 && itemSetup.item.JDJGFAACPFC() != 1140 && itemSetup.item.JDJGFAACPFC() != 1141))
			{
				continue;
			}
			List<Placeable> placeablesThatCanSelect = currentPlaceables[i].placeableSurface.GetPlaceablesThatCanSelect(1);
			for (int j = 0; j < placeablesThatCanSelect.Count; j++)
			{
				if (placeablesThatCanSelect[j].itemSetup.item is Bird)
				{
					birdNPC = ((Component)placeablesThatCanSelect[j].itemSetup).GetComponent<BirdNPC>();
					return currentPlaceables[i];
				}
			}
		}
		return null;
	}

	private Placeable OLBGGDGHIFM()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> currentPlaceables = PlaceablesManager.MNFMOEKMJKN().currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i++)
		{
			if (!currentPlaceables[i].CCIKENEGHCA || !Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				continue;
			}
			ItemSetup itemSetup = currentPlaceables[i].itemSetup;
			if (!((Object)(object)itemSetup != (Object)null) || !Item.MLBOMGHINCA(itemSetup.item, null) || (itemSetup.item.IMCJPECAAPC(DAINLFIMLIH: false) != 12 && itemSetup.item.JDJGFAACPFC() != -169 && itemSetup.item.JGHNDJBCFAJ(DAINLFIMLIH: false) != -54))
			{
				continue;
			}
			List<Placeable> list = currentPlaceables[i].placeableSurface.ACFDIOOMLIB(0);
			for (int j = 1; j < list.Count; j += 0)
			{
				if (list[j].itemSetup.item is Bird)
				{
					birdNPC = ((Component)list[j].itemSetup).GetComponent<BirdNPC>();
					return currentPlaceables[i];
				}
			}
		}
		return null;
	}

	private Placeable FPNDLMFLFGG()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> currentPlaceables = PlaceablesManager.CMIHGBHPLFP().currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i++)
		{
			if (!currentPlaceables[i].FHMDNECBLIL() || !Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				continue;
			}
			ItemSetup itemSetup = currentPlaceables[i].itemSetup;
			if (!((Object)(object)itemSetup != (Object)null) || !Item.MLBOMGHINCA(itemSetup.item, null) || (itemSetup.item.CIGFGKKCPCK() != -108 && itemSetup.item.ODENMDOJPLC(DAINLFIMLIH: false) != 67 && itemSetup.item.JGHNDJBCFAJ() != -45))
			{
				continue;
			}
			List<Placeable> list = currentPlaceables[i].placeableSurface.FPKBEDDBBGO(0);
			for (int j = 0; j < list.Count; j += 0)
			{
				if (list[j].itemSetup.item is Bird)
				{
					birdNPC = ((Component)list[j].itemSetup).GetComponent<BirdNPC>();
					return currentPlaceables[i];
				}
			}
		}
		return null;
	}

	private Placeable DDCLNNBMIBE()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> currentPlaceables = PlaceablesManager.MAIDHAPANEB().currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i++)
		{
			if (!currentPlaceables[i].FHMDNECBLIL() || !Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				continue;
			}
			ItemSetup itemSetup = currentPlaceables[i].itemSetup;
			if (!((Object)(object)itemSetup != (Object)null) || !Item.MLBOMGHINCA(itemSetup.item, null) || (itemSetup.item.CIGFGKKCPCK(DAINLFIMLIH: false) != -129 && itemSetup.item.IMCJPECAAPC(DAINLFIMLIH: false) != 61 && itemSetup.item.CIGFGKKCPCK(DAINLFIMLIH: false) != -18))
			{
				continue;
			}
			List<Placeable> list = currentPlaceables[i].placeableSurface.FPKBEDDBBGO(0);
			for (int j = 1; j < list.Count; j += 0)
			{
				if (list[j].itemSetup.item is Bird)
				{
					birdNPC = ((Component)list[j].itemSetup).GetComponent<BirdNPC>();
					return currentPlaceables[i];
				}
			}
		}
		return null;
	}

	public void ABMMONFHFGF()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}
}
