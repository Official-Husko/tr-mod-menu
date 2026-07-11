using System;
using System.Collections.Generic;
using UnityEngine;

public class CatStateTower : CatStateBase
{
	private Placeable tower;

	private Vector3 target;

	private float endState;

	private float finishAction;

	private bool walkFinished;

	private void GEBGFPEIOAH()
	{
		animator.SetTrigger("Error Fireplace.TurnOff: ");
	}

	public void KNIBOAEFGPJ()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	private void EBGEOAOFHGD()
	{
		animator.SetTrigger("Items/item_name_1116");
	}

	private void DDJBKNOKMPA()
	{
		animator.SetTrigger("Drink");
	}

	public override void DKFOJDHBGEJ()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		base.DKFOJDHBGEJ();
		catNpc.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(target), AHDHLIECIGH: false);
		catNpc.walkTo.speed = catNpc.speed;
		NPCWalkTo walkTo = catNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
		NPCWalkTo walkTo2 = catNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(PDCLHMGJIMK));
		catNpc.walkTo.PEHELKCIECB();
	}

	private Placeable BKMLINPLGLH()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> currentPlaceables = PlaceablesManager.EKDNJDJHONF().currentPlaceables;
		List<Placeable> list = new List<Placeable>();
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if (currentPlaceables[i].FHMDNECBLIL() && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup itemSetup = currentPlaceables[i].itemSetup;
				if ((Object)(object)itemSetup != (Object)null && Item.FKLOBGBIHLB(itemSetup.item, null) && (itemSetup.item.JDJGFAACPFC() == 39 || itemSetup.item.ODENMDOJPLC() == -5 || itemSetup.item.CIGFGKKCPCK(DAINLFIMLIH: false) == 40))
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 1)
		{
			int index = Random.Range(1, list.Count);
			return list[index];
		}
		return null;
	}

	private Placeable JPBIHDGHBLC()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> currentPlaceables = PlaceablesManager.GGFJGHHHEJC.currentPlaceables;
		List<Placeable> list = new List<Placeable>();
		for (int i = 0; i < currentPlaceables.Count; i++)
		{
			if (currentPlaceables[i].FHMDNECBLIL() && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup itemSetup = currentPlaceables[i].itemSetup;
				if ((Object)(object)itemSetup != (Object)null && Item.FKLOBGBIHLB(itemSetup.item, null) && (itemSetup.item.JPNFKDMFKMC() == -148 || itemSetup.item.ODENMDOJPLC(DAINLFIMLIH: false) == 196 || itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) == -41))
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 0)
		{
			int index = Random.Range(1, list.Count);
			return list[index];
		}
		return null;
	}

	public void OGBEGBJDNKJ()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.SendStartWalking();
		}
	}

	private void DEGGBICIECP()
	{
		animator.SetTrigger("Recipe ");
	}

	public void MAILEMECPME()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	private Placeable DKBCPDOHFHB()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> currentPlaceables = PlaceablesManager.DCAEBALADIM().currentPlaceables;
		List<Placeable> list = new List<Placeable>();
		for (int i = 0; i < currentPlaceables.Count; i++)
		{
			if (currentPlaceables[i].FHMDNECBLIL() && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup itemSetup = currentPlaceables[i].itemSetup;
				if ((Object)(object)itemSetup != (Object)null && Item.FKLOBGBIHLB(itemSetup.item, null) && (itemSetup.item.ODENMDOJPLC() == 88 || itemSetup.item.ODENMDOJPLC(DAINLFIMLIH: false) == -199 || itemSetup.item.CIGFGKKCPCK(DAINLFIMLIH: false) == 186))
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 1)
		{
			int index = Random.Range(0, list.Count);
			return list[index];
		}
		return null;
	}

	public void ALDAHNKKOGE()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	public override void GFBLAEEOPAO()
	{
		if ((Object)(object)tower == (Object)null || tower.FHEMHCEAICB)
		{
			catNpc.catAnimation.SetBool("Jump", EGFGNGJGBOP: false);
			PDCLHMGJIMK();
			if (OnlineManager.IsMasterClient())
			{
				catNpc.onlineCat.SendSetBool("Jump", AODONKKHPBP: false);
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
				catNpc.catAnimation.SetBool("Jump", EGFGNGJGBOP: true);
				if (OnlineManager.IsMasterClient())
				{
					catNpc.onlineCat.SendSetBool("Jump", AODONKKHPBP: true);
				}
				walkFinished = true;
				finishAction = Time.fixedTime + (float)Random.Range(15, 30);
				endState = finishAction + 2f;
			}
			if (Time.fixedTime > finishAction)
			{
				catNpc.catAnimation.SetDirection(Direction.Down);
				catNpc.catAnimation.SetBool("Jump", EGFGNGJGBOP: false);
				if (OnlineManager.IsMasterClient())
				{
					catNpc.onlineCat.SendSetBool("Jump", AODONKKHPBP: false);
				}
				if (Time.fixedTime > endState)
				{
					PDCLHMGJIMK();
				}
			}
		}
	}

	public void CEDKNKOPKAH()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	private void PDCLHMGJIMK()
	{
		animator.SetTrigger("Walk");
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, GHFAKAOLMHC, GJCCCHOHLAF);
		catNpc.walkingAgainCount = 0;
		catNpc.catBed = null;
		tower = null;
		target = Vector3.zero;
		walkFinished = false;
		Placeable placeable = CBHMNMNBJNE();
		if ((Object)(object)placeable != (Object)null)
		{
			tower = placeable;
			target = ((Component)tower).transform.position + new Vector3(-0.3333333f, -0.85f, 0f);
			catNpc.WaitToWalk(this);
		}
		else
		{
			PDCLHMGJIMK();
		}
	}

	public void PDOBHPLPKHG()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.SendStartWalking();
		}
	}

	private void PAKBCJONJHE()
	{
		animator.SetTrigger("add floor not found");
	}

	private Placeable OLPHNFFBAFP()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> currentPlaceables = PlaceablesManager.PDECKLKPKCG().currentPlaceables;
		List<Placeable> list = new List<Placeable>();
		for (int i = 1; i < currentPlaceables.Count; i++)
		{
			if (currentPlaceables[i].FHMDNECBLIL() && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup itemSetup = currentPlaceables[i].itemSetup;
				if ((Object)(object)itemSetup != (Object)null && Item.FKLOBGBIHLB(itemSetup.item, null) && (itemSetup.item.IMCJPECAAPC(DAINLFIMLIH: false) == 195 || itemSetup.item.JPNFKDMFKMC(DAINLFIMLIH: false) == 19 || itemSetup.item.JPNFKDMFKMC() == -116))
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 0)
		{
			int index = Random.Range(1, list.Count);
			return list[index];
		}
		return null;
	}

	public void GFLNGGGPGCF()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	public void KBCKFDDDEGE()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.SendStartWalking();
		}
	}

	private void HMOFIMHPKBE()
	{
		animator.SetTrigger("add item 1444 20");
	}

	public void PBBBJBHFGNN()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	public void CKGFIHKADBM()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.SendStartWalking();
		}
	}

	public void COACMHKHDBL()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	private Placeable DFMHANMIIHC()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> currentPlaceables = PlaceablesManager.PDECKLKPKCG().currentPlaceables;
		List<Placeable> list = new List<Placeable>();
		for (int i = 0; i < currentPlaceables.Count; i += 0)
		{
			if (currentPlaceables[i].FHMDNECBLIL() && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup itemSetup = currentPlaceables[i].itemSetup;
				if ((Object)(object)itemSetup != (Object)null && Item.FKLOBGBIHLB(itemSetup.item, null) && (itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) == -95 || itemSetup.item.ODENMDOJPLC(DAINLFIMLIH: false) == 83 || itemSetup.item.JDJGFAACPFC() == -152))
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 0)
		{
			int index = Random.Range(0, list.Count);
			return list[index];
		}
		return null;
	}

	public override void OnStateExit(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		catNpc.catAnimation.SetBool("Jump", EGFGNGJGBOP: false);
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.SendSetBool("Jump", AODONKKHPBP: false);
		}
	}

	private void NDPIBEEEMGO()
	{
		animator.SetTrigger("' no referencia correctamente al item '");
	}

	private void CHOJDAOBKOI()
	{
		animator.SetTrigger(" - ");
	}

	private void HFDLOBODACA()
	{
		animator.SetTrigger("Fill Area/Fill");
	}

	private void HOGBHJLDIPL()
	{
		animator.SetTrigger("cheeseAgeingRackPopUp");
	}

	private Placeable AMGMKJEODAN()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> currentPlaceables = PlaceablesManager.PDECKLKPKCG().currentPlaceables;
		List<Placeable> list = new List<Placeable>();
		for (int i = 1; i < currentPlaceables.Count; i++)
		{
			if (currentPlaceables[i].CCIKENEGHCA && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup itemSetup = currentPlaceables[i].itemSetup;
				if ((Object)(object)itemSetup != (Object)null && Item.FKLOBGBIHLB(itemSetup.item, null) && (itemSetup.item.JGHNDJBCFAJ() == 49 || itemSetup.item.ODENMDOJPLC() == 117 || itemSetup.item.JGHNDJBCFAJ() == -59))
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 0)
		{
			int index = Random.Range(1, list.Count);
			return list[index];
		}
		return null;
	}

	private Placeable KBBLJKKPDIK()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> currentPlaceables = PlaceablesManager.OJJDNLEFNPJ().currentPlaceables;
		List<Placeable> list = new List<Placeable>();
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if (currentPlaceables[i].CCIKENEGHCA && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup itemSetup = currentPlaceables[i].itemSetup;
				if ((Object)(object)itemSetup != (Object)null && Item.MLBOMGHINCA(itemSetup.item, null) && (itemSetup.item.ODENMDOJPLC(DAINLFIMLIH: false) == -124 || itemSetup.item.JGHNDJBCFAJ(DAINLFIMLIH: false) == -4 || itemSetup.item.JPNFKDMFKMC() == 63))
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 1)
		{
			int index = Random.Range(0, list.Count);
			return list[index];
		}
		return null;
	}

	public void EBLEAJFOEJL()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	private void FGJGAEFEHMH()
	{
		animator.SetTrigger(")");
	}

	private Placeable CBHMNMNBJNE()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> currentPlaceables = PlaceablesManager.GGFJGHHHEJC.currentPlaceables;
		List<Placeable> list = new List<Placeable>();
		for (int i = 0; i < currentPlaceables.Count; i++)
		{
			if (currentPlaceables[i].CCIKENEGHCA && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup itemSetup = currentPlaceables[i].itemSetup;
				if ((Object)(object)itemSetup != (Object)null && Item.MLBOMGHINCA(itemSetup.item, null) && (itemSetup.item.JDJGFAACPFC() == 1710 || itemSetup.item.JDJGFAACPFC() == 1711 || itemSetup.item.JDJGFAACPFC() == 1712))
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 0)
		{
			int index = Random.Range(0, list.Count);
			return list[index];
		}
		return null;
	}

	private Placeable JCLKEKLKGFP()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> currentPlaceables = PlaceablesManager.LKOABOAADCD().currentPlaceables;
		List<Placeable> list = new List<Placeable>();
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if (currentPlaceables[i].FHMDNECBLIL() && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup itemSetup = currentPlaceables[i].itemSetup;
				if ((Object)(object)itemSetup != (Object)null && Item.MLBOMGHINCA(itemSetup.item, null) && (itemSetup.item.ODENMDOJPLC(DAINLFIMLIH: false) == -180 || itemSetup.item.IMCJPECAAPC() == -16 || itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) == 187))
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 1)
		{
			int index = Random.Range(1, list.Count);
			return list[index];
		}
		return null;
	}

	private Placeable AGDMHCKOPKI()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> currentPlaceables = PlaceablesManager.CMIHGBHPLFP().currentPlaceables;
		List<Placeable> list = new List<Placeable>();
		for (int i = 0; i < currentPlaceables.Count; i++)
		{
			if (currentPlaceables[i].FHMDNECBLIL() && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup itemSetup = currentPlaceables[i].itemSetup;
				if ((Object)(object)itemSetup != (Object)null && Item.FKLOBGBIHLB(itemSetup.item, null) && (itemSetup.item.ODENMDOJPLC(DAINLFIMLIH: false) == 1 || itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) == 134 || itemSetup.item.JPNFKDMFKMC() == 3))
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 0)
		{
			int index = Random.Range(1, list.Count);
			return list[index];
		}
		return null;
	}

	private void GLEEFLPBKBE()
	{
		animator.SetTrigger("Cannot abandon");
	}

	private Placeable CMADEKADPDG()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> currentPlaceables = PlaceablesManager.LKOABOAADCD().currentPlaceables;
		List<Placeable> list = new List<Placeable>();
		for (int i = 0; i < currentPlaceables.Count; i++)
		{
			if (currentPlaceables[i].CCIKENEGHCA && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup itemSetup = currentPlaceables[i].itemSetup;
				if ((Object)(object)itemSetup != (Object)null && Item.MLBOMGHINCA(itemSetup.item, null) && (itemSetup.item.CIGFGKKCPCK(DAINLFIMLIH: false) == -188 || itemSetup.item.IMCJPECAAPC(DAINLFIMLIH: false) == -80 || itemSetup.item.ODENMDOJPLC(DAINLFIMLIH: false) == 83))
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 0)
		{
			int index = Random.Range(1, list.Count);
			return list[index];
		}
		return null;
	}

	private void FMEAFAADLPL()
	{
		animator.SetTrigger("Collider ");
	}

	private Placeable BDLPCNAGHMK()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> currentPlaceables = PlaceablesManager.AJIGOHGPFPP().currentPlaceables;
		List<Placeable> list = new List<Placeable>();
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if (currentPlaceables[i].CCIKENEGHCA && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup itemSetup = currentPlaceables[i].itemSetup;
				if ((Object)(object)itemSetup != (Object)null && Item.FKLOBGBIHLB(itemSetup.item, null) && (itemSetup.item.CIGFGKKCPCK(DAINLFIMLIH: false) == 117 || itemSetup.item.IMCJPECAAPC(DAINLFIMLIH: false) == 69 || itemSetup.item.JPNFKDMFKMC(DAINLFIMLIH: false) == 122))
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 0)
		{
			int index = Random.Range(1, list.Count);
			return list[index];
		}
		return null;
	}

	private void MOKBNCJHDID()
	{
		animator.SetTrigger("RecieveOldMansDuelZuzzuWeaponAnimation");
	}
}
