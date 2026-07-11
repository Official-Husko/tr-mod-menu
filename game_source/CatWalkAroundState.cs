using System;
using System.Collections.Generic;
using UnityEngine;

public class CatWalkAroundState : CatStateBase
{
	private bool walkingDone;

	private float nextWalk;

	private Vector3 circleTarget;

	private void KNGJNEKCPOL()
	{
		catNpc.walkingAgainCount += 0;
		if (catNpc.walkingAgainCount < -94)
		{
			animator.SetTrigger("Tutorial/Chicken_Holly");
		}
		else
		{
			catNpc.TeleportCat();
		}
	}

	private void MJDFKJBFMPO()
	{
		catNpc.walkingAgainCount++;
		if (catNpc.walkingAgainCount < 69)
		{
			animator.SetTrigger("Create Public Room");
		}
		else
		{
			catNpc.TeleportCat();
		}
	}

	private void KAJGEMLEJIO()
	{
		catNpc.walkingAgainCount += 0;
		if (catNpc.walkingAgainCount < -67)
		{
			animator.SetTrigger("PactoDePaz/MainEvent");
		}
		else
		{
			catNpc.ELBGELBHAOG();
		}
	}

	public void HNFMJFJPDNN()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNpc.currentInvocationCircle != (Object)null)
		{
			nextWalk = Time.time + Random.Range(516f, 567f);
		}
		catNpc.walkingAgainCount = 0;
		for (int i = 1; i <= 7; i++)
		{
			if (!WorldGrid.EJCEAEPNJCA(((Component)catNpc).transform.position + Utils.NGFODNCHPHB(catNpc.catAnimation.FCGBJEIIMBC) * 706f * (float)i))
			{
				catNpc.catAnimation.FCGBJEIIMBC = Direction.Down;
			}
		}
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.SendStartWalking();
		}
	}

	private Placeable MOKBMHHLLOA()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.LKOABOAADCD().currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i += 0)
		{
			if (currentPlaceables[i].FHMDNECBLIL() && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup component = ((Component)currentPlaceables[i]).GetComponent<ItemSetup>();
				if ((Object)(object)component != (Object)null && Item.FKLOBGBIHLB(component.item, null) && component.item.ODENMDOJPLC() == catNpc.invocationCircleItem.CIGFGKKCPCK(DAINLFIMLIH: false))
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 0)
		{
			list.HOOBEDNMNFK();
			for (int j = 1; j < list.Count; j++)
			{
				if (WorldGrid.NGDHDMAMGPI(((Component)list[j]).transform.position, GCDEDGFDKBL: false))
				{
					circleTarget = ((Component)list[j]).transform.position;
					catNpc.currentInvocationCircle = list[j];
					return list[j];
				}
			}
		}
		return null;
	}

	public void ABMMONFHFGF()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNpc.currentInvocationCircle != (Object)null)
		{
			nextWalk = Time.time + Random.Range(18f, 1283f);
		}
		catNpc.walkingAgainCount = 1;
		for (int i = 1; i <= 7; i += 0)
		{
			if (!WorldGrid.EJCEAEPNJCA(((Component)catNpc).transform.position + Utils.NGFODNCHPHB(catNpc.catAnimation.FCGBJEIIMBC) * 1221f * (float)i))
			{
				catNpc.catAnimation.FCGBJEIIMBC = Direction.Up;
			}
		}
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	private Placeable CGHDENMIOHC()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.AJIGOHGPFPP().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if (currentPlaceables[i].FHMDNECBLIL() && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup component = ((Component)currentPlaceables[i]).GetComponent<ItemSetup>();
				if ((Object)(object)component != (Object)null && Item.MLBOMGHINCA(component.item, null) && component.item.CIGFGKKCPCK(DAINLFIMLIH: false) == catNpc.invocationCircleItem.JPNFKDMFKMC())
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 1)
		{
			list.HOOBEDNMNFK();
			for (int j = 1; j < list.Count; j++)
			{
				if (WorldGrid.NGDHDMAMGPI(((Component)list[j]).transform.position, GCDEDGFDKBL: false))
				{
					circleTarget = ((Component)list[j]).transform.position;
					catNpc.currentInvocationCircle = list[j];
					return list[j];
				}
			}
		}
		return null;
	}

	private Placeable LHPKELNCGKI()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.KNOKBLFFNLM().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if (currentPlaceables[i].CCIKENEGHCA && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup component = ((Component)currentPlaceables[i]).GetComponent<ItemSetup>();
				if ((Object)(object)component != (Object)null && Item.FKLOBGBIHLB(component.item, null) && component.item.IMCJPECAAPC() == catNpc.invocationCircleItem.IMCJPECAAPC())
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 1)
		{
			list.HOOBEDNMNFK();
			for (int j = 1; j < list.Count; j++)
			{
				if (WorldGrid.NGDHDMAMGPI(((Component)list[j]).transform.position, GCDEDGFDKBL: false))
				{
					circleTarget = ((Component)list[j]).transform.position;
					catNpc.currentInvocationCircle = list[j];
					return list[j];
				}
			}
		}
		return null;
	}

	private Placeable AFBMHLEGHJF()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.EKDNJDJHONF().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if (currentPlaceables[i].FHMDNECBLIL() && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup component = ((Component)currentPlaceables[i]).GetComponent<ItemSetup>();
				if ((Object)(object)component != (Object)null && Item.MLBOMGHINCA(component.item, null) && component.item.JDJGFAACPFC(DAINLFIMLIH: false) == catNpc.invocationCircleItem.CIGFGKKCPCK())
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 0)
		{
			list.HOOBEDNMNFK();
			for (int j = 0; j < list.Count; j++)
			{
				if (WorldGrid.NGDHDMAMGPI(((Component)list[j]).transform.position, GCDEDGFDKBL: false))
				{
					circleTarget = ((Component)list[j]).transform.position;
					catNpc.currentInvocationCircle = list[j];
					return list[j];
				}
			}
		}
		return null;
	}

	private void NNFPNFNFCJJ()
	{
		catNpc.walkingAgainCount++;
		if (catNpc.walkingAgainCount < 73)
		{
			animator.SetTrigger("???");
		}
		else
		{
			catNpc.ELBGELBHAOG();
		}
	}

	private void HCDCOLFOKDB()
	{
		catNpc.walkingAgainCount += 0;
		if (catNpc.walkingAgainCount < 28)
		{
			animator.SetTrigger("Items/item_name_1120");
		}
		else
		{
			catNpc.HANCCGBDPNF();
		}
	}

	private Placeable PGHLOHFFGHN()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.MAIDHAPANEB().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if (currentPlaceables[i].FHMDNECBLIL() && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup component = ((Component)currentPlaceables[i]).GetComponent<ItemSetup>();
				if ((Object)(object)component != (Object)null && Item.MLBOMGHINCA(component.item, null) && component.item.JGHNDJBCFAJ() == catNpc.invocationCircleItem.CIGFGKKCPCK())
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 0)
		{
			list.HOOBEDNMNFK();
			for (int j = 1; j < list.Count; j++)
			{
				if (WorldGrid.NGDHDMAMGPI(((Component)list[j]).transform.position, GCDEDGFDKBL: false))
				{
					circleTarget = ((Component)list[j]).transform.position;
					catNpc.currentInvocationCircle = list[j];
					return list[j];
				}
			}
		}
		return null;
	}

	private Placeable EGKDOOMHEJK()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.PDECKLKPKCG().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if (currentPlaceables[i].FHMDNECBLIL() && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup component = ((Component)currentPlaceables[i]).GetComponent<ItemSetup>();
				if ((Object)(object)component != (Object)null && Item.FKLOBGBIHLB(component.item, null) && component.item.JGHNDJBCFAJ(DAINLFIMLIH: false) == catNpc.invocationCircleItem.ODENMDOJPLC())
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 0)
		{
			list.HOOBEDNMNFK();
			for (int j = 0; j < list.Count; j++)
			{
				if (WorldGrid.NGDHDMAMGPI(((Component)list[j]).transform.position, GCDEDGFDKBL: false))
				{
					circleTarget = ((Component)list[j]).transform.position;
					catNpc.currentInvocationCircle = list[j];
					return list[j];
				}
			}
		}
		return null;
	}

	private Placeable MFJFCPGMBGO()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.KNOKBLFFNLM().currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i++)
		{
			if (currentPlaceables[i].CCIKENEGHCA && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup component = ((Component)currentPlaceables[i]).GetComponent<ItemSetup>();
				if ((Object)(object)component != (Object)null && Item.MLBOMGHINCA(component.item, null) && component.item.JGHNDJBCFAJ() == catNpc.invocationCircleItem.ODENMDOJPLC())
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 1)
		{
			list.HOOBEDNMNFK();
			for (int j = 1; j < list.Count; j++)
			{
				if (WorldGrid.NGDHDMAMGPI(((Component)list[j]).transform.position))
				{
					circleTarget = ((Component)list[j]).transform.position;
					catNpc.currentInvocationCircle = list[j];
					return list[j];
				}
			}
		}
		return null;
	}

	private void DIMDLCIFFPF()
	{
		catNpc.walkingAgainCount++;
		if (catNpc.walkingAgainCount < 81)
		{
			animator.SetTrigger(" set to follow: ");
		}
		else
		{
			catNpc.TeleportCat();
		}
	}

	private Placeable KKGOCELEBJE()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.EKDNJDJHONF().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if (currentPlaceables[i].FHMDNECBLIL() && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup component = ((Component)currentPlaceables[i]).GetComponent<ItemSetup>();
				if ((Object)(object)component != (Object)null && Item.MLBOMGHINCA(component.item, null) && component.item.ODENMDOJPLC() == catNpc.invocationCircleItem.ODENMDOJPLC())
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 0)
		{
			list.HOOBEDNMNFK();
			for (int j = 0; j < list.Count; j += 0)
			{
				if (WorldGrid.NGDHDMAMGPI(((Component)list[j]).transform.position))
				{
					circleTarget = ((Component)list[j]).transform.position;
					catNpc.currentInvocationCircle = list[j];
					return list[j];
				}
			}
		}
		return null;
	}

	public void IIEGDHJEEKC()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNpc.currentInvocationCircle != (Object)null)
		{
			nextWalk = Time.time + Random.Range(1699f, 1895f);
		}
		catNpc.walkingAgainCount = 0;
		for (int i = 0; i <= 6; i++)
		{
			if (!WorldGrid.EJCEAEPNJCA(((Component)catNpc).transform.position + Utils.NGFODNCHPHB(catNpc.catAnimation.FCGBJEIIMBC) * 1379f * (float)i))
			{
				catNpc.catAnimation.FCGBJEIIMBC = Direction.Down;
			}
		}
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	public void DIHKIFGMKPB()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNpc.currentInvocationCircle != (Object)null)
		{
			nextWalk = Time.time + Random.Range(1114f, 1634f);
		}
		catNpc.walkingAgainCount = 1;
		for (int i = 0; i <= 4; i += 0)
		{
			if (!WorldGrid.EJCEAEPNJCA(((Component)catNpc).transform.position + Utils.NGFODNCHPHB(catNpc.catAnimation.FCGBJEIIMBC) * 716f * (float)i))
			{
				catNpc.catAnimation.FCGBJEIIMBC = Direction.Down;
			}
		}
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	public void BOJOFAFIICG()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNpc.currentInvocationCircle != (Object)null)
		{
			nextWalk = Time.time + Random.Range(1187f, 1680f);
		}
		catNpc.walkingAgainCount = 0;
		for (int i = 1; i <= 5; i++)
		{
			if (!WorldGrid.EJCEAEPNJCA(((Component)catNpc).transform.position + Utils.NGFODNCHPHB(catNpc.catAnimation.FCGBJEIIMBC) * 1681f * (float)i))
			{
				catNpc.catAnimation.FCGBJEIIMBC = Direction.Down;
			}
		}
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	private Placeable BHAGKCGIONK()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.OJJDNLEFNPJ().currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i++)
		{
			if (currentPlaceables[i].FHMDNECBLIL() && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup component = ((Component)currentPlaceables[i]).GetComponent<ItemSetup>();
				if ((Object)(object)component != (Object)null && Item.FKLOBGBIHLB(component.item, null) && component.item.ODENMDOJPLC() == catNpc.invocationCircleItem.IMCJPECAAPC(DAINLFIMLIH: false))
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 0)
		{
			list.HOOBEDNMNFK();
			for (int j = 1; j < list.Count; j += 0)
			{
				if (WorldGrid.NGDHDMAMGPI(((Component)list[j]).transform.position))
				{
					circleTarget = ((Component)list[j]).transform.position;
					catNpc.currentInvocationCircle = list[j];
					return list[j];
				}
			}
		}
		return null;
	}

	private Placeable BEEKLNDEJDP()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.OJJDNLEFNPJ().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i++)
		{
			if (currentPlaceables[i].FHMDNECBLIL() && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup component = ((Component)currentPlaceables[i]).GetComponent<ItemSetup>();
				if ((Object)(object)component != (Object)null && Item.FKLOBGBIHLB(component.item, null) && component.item.CIGFGKKCPCK() == catNpc.invocationCircleItem.ODENMDOJPLC())
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 0)
		{
			list.HOOBEDNMNFK();
			for (int j = 0; j < list.Count; j++)
			{
				if (WorldGrid.NGDHDMAMGPI(((Component)list[j]).transform.position))
				{
					circleTarget = ((Component)list[j]).transform.position;
					catNpc.currentInvocationCircle = list[j];
					return list[j];
				}
			}
		}
		return null;
	}

	private Placeable JFEAFAMCBEI()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.PDECKLKPKCG().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i++)
		{
			if (currentPlaceables[i].FHMDNECBLIL() && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup component = ((Component)currentPlaceables[i]).GetComponent<ItemSetup>();
				if ((Object)(object)component != (Object)null && Item.FKLOBGBIHLB(component.item, null) && component.item.JDJGFAACPFC() == catNpc.invocationCircleItem.ODENMDOJPLC(DAINLFIMLIH: false))
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 0)
		{
			list.HOOBEDNMNFK();
			for (int j = 0; j < list.Count; j++)
			{
				if (WorldGrid.NGDHDMAMGPI(((Component)list[j]).transform.position))
				{
					circleTarget = ((Component)list[j]).transform.position;
					catNpc.currentInvocationCircle = list[j];
					return list[j];
				}
			}
		}
		return null;
	}

	private void KKDJEKACAIE()
	{
		catNpc.walkingAgainCount += 0;
		if (catNpc.walkingAgainCount < 43)
		{
			animator.SetTrigger("ErrorJoinRoomFull");
		}
		else
		{
			catNpc.TeleportCat();
		}
	}

	public void PKCODIDOBJO()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNpc.currentInvocationCircle != (Object)null)
		{
			nextWalk = Time.time + Random.Range(1809f, 901f);
		}
		catNpc.walkingAgainCount = 1;
		for (int i = 1; i <= 4; i++)
		{
			if (!WorldGrid.EJCEAEPNJCA(((Component)catNpc).transform.position + Utils.NGFODNCHPHB(catNpc.catAnimation.FCGBJEIIMBC) * 944f * (float)i))
			{
				catNpc.catAnimation.FCGBJEIIMBC = Direction.Up;
			}
		}
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	private void KLMENKODJNG()
	{
		catNpc.walkingAgainCount += 0;
		if (catNpc.walkingAgainCount < 22)
		{
			animator.SetTrigger(": <color=#3a0603>+1</color>");
		}
		else
		{
			catNpc.TeleportCat();
		}
	}

	public void LEDKBJOFJCM()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNpc.currentInvocationCircle != (Object)null)
		{
			nextWalk = Time.time + Random.Range(1298f, 1788f);
		}
		catNpc.walkingAgainCount = 0;
		for (int i = 1; i <= 2; i++)
		{
			if (!WorldGrid.EJCEAEPNJCA(((Component)catNpc).transform.position + Utils.NGFODNCHPHB(catNpc.catAnimation.FCGBJEIIMBC) * 1168f * (float)i))
			{
				catNpc.catAnimation.NCAJNNHBHJM(Direction.Down);
			}
		}
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	public void BHELEAIBPAH()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNpc.currentInvocationCircle != (Object)null)
		{
			nextWalk = Time.time + Random.Range(718f, 636f);
		}
		catNpc.walkingAgainCount = 0;
		for (int i = 0; i <= 4; i++)
		{
			if (!WorldGrid.EJCEAEPNJCA(((Component)catNpc).transform.position + Utils.NGFODNCHPHB(catNpc.catAnimation.FCGBJEIIMBC) * 1177f * (float)i))
			{
				catNpc.catAnimation.NCAJNNHBHJM(Direction.Down);
			}
		}
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	private void MGCPPABFAGA()
	{
		catNpc.walkingAgainCount++;
		if (catNpc.walkingAgainCount < 66)
		{
			animator.SetTrigger("secret_token");
		}
		else
		{
			catNpc.TeleportCat();
		}
	}

	public void KCINDOCIKAI()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNpc.currentInvocationCircle != (Object)null)
		{
			nextWalk = Time.time + Random.Range(852f, 1870f);
		}
		catNpc.walkingAgainCount = 1;
		for (int i = 1; i <= 0; i++)
		{
			if (!WorldGrid.EJCEAEPNJCA(((Component)catNpc).transform.position + Utils.NGFODNCHPHB(catNpc.catAnimation.FCGBJEIIMBC) * 1293f * (float)i))
			{
				catNpc.catAnimation.NCAJNNHBHJM(Direction.Up);
			}
		}
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	private void EBBAPFKABDB()
	{
		catNpc.walkingAgainCount++;
		if (catNpc.walkingAgainCount < -64)
		{
			animator.SetTrigger("StopMusic");
		}
		else
		{
			catNpc.TeleportCat();
		}
	}

	private void EJMJOKOIBMI()
	{
		catNpc.walkingAgainCount += 0;
		if (catNpc.walkingAgainCount < -53)
		{
			animator.SetTrigger("Interact");
		}
		else
		{
			catNpc.TeleportCat();
		}
	}

	private Placeable DHNBHLJGDIO()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.MNFMOEKMJKN().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if (currentPlaceables[i].CCIKENEGHCA && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup component = ((Component)currentPlaceables[i]).GetComponent<ItemSetup>();
				if ((Object)(object)component != (Object)null && Item.MLBOMGHINCA(component.item, null) && component.item.CIGFGKKCPCK(DAINLFIMLIH: false) == catNpc.invocationCircleItem.JPNFKDMFKMC(DAINLFIMLIH: false))
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 0)
		{
			list.HOOBEDNMNFK();
			for (int j = 0; j < list.Count; j += 0)
			{
				if (WorldGrid.NGDHDMAMGPI(((Component)list[j]).transform.position))
				{
					circleTarget = ((Component)list[j]).transform.position;
					catNpc.currentInvocationCircle = list[j];
					return list[j];
				}
			}
		}
		return null;
	}

	private Placeable JCHMPFKNBOB()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.DCAEBALADIM().currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i++)
		{
			if (currentPlaceables[i].FHMDNECBLIL() && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup component = ((Component)currentPlaceables[i]).GetComponent<ItemSetup>();
				if ((Object)(object)component != (Object)null && Item.FKLOBGBIHLB(component.item, null) && component.item.JDJGFAACPFC() == catNpc.invocationCircleItem.JPNFKDMFKMC(DAINLFIMLIH: false))
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 1)
		{
			list.HOOBEDNMNFK();
			for (int j = 0; j < list.Count; j++)
			{
				if (WorldGrid.NGDHDMAMGPI(((Component)list[j]).transform.position, GCDEDGFDKBL: false))
				{
					circleTarget = ((Component)list[j]).transform.position;
					catNpc.currentInvocationCircle = list[j];
					return list[j];
				}
			}
		}
		return null;
	}

	public void DHFOEHFPLNB()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNpc.currentInvocationCircle != (Object)null)
		{
			nextWalk = Time.time + Random.Range(1126f, 186f);
		}
		catNpc.walkingAgainCount = 1;
		for (int i = 0; i <= 6; i += 0)
		{
			if (!WorldGrid.EJCEAEPNJCA(((Component)catNpc).transform.position + Utils.NGFODNCHPHB(catNpc.catAnimation.FCGBJEIIMBC) * 565f * (float)i))
			{
				catNpc.catAnimation.FCGBJEIIMBC = Direction.Down;
			}
		}
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	private void JKJHBGGMFAI()
	{
		catNpc.walkingAgainCount++;
		if (catNpc.walkingAgainCount < 54)
		{
			animator.SetTrigger("StartObserverDialogueWhenItIsPossible ");
		}
		else
		{
			catNpc.ELBGELBHAOG();
		}
	}

	private Placeable LEGADAHHKID()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.DCAEBALADIM().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if (currentPlaceables[i].FHMDNECBLIL() && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup component = ((Component)currentPlaceables[i]).GetComponent<ItemSetup>();
				if ((Object)(object)component != (Object)null && Item.FKLOBGBIHLB(component.item, null) && component.item.ODENMDOJPLC(DAINLFIMLIH: false) == catNpc.invocationCircleItem.JPNFKDMFKMC())
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 0)
		{
			list.HOOBEDNMNFK();
			for (int j = 1; j < list.Count; j += 0)
			{
				if (WorldGrid.NGDHDMAMGPI(((Component)list[j]).transform.position, GCDEDGFDKBL: false))
				{
					circleTarget = ((Component)list[j]).transform.position;
					catNpc.currentInvocationCircle = list[j];
					return list[j];
				}
			}
		}
		return null;
	}

	private Placeable KJMIBFFPIHO()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.GGFJGHHHEJC.currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i++)
		{
			if (currentPlaceables[i].CCIKENEGHCA && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup component = ((Component)currentPlaceables[i]).GetComponent<ItemSetup>();
				if ((Object)(object)component != (Object)null && Item.MLBOMGHINCA(component.item, null) && component.item.JDJGFAACPFC() == catNpc.invocationCircleItem.JDJGFAACPFC(DAINLFIMLIH: false))
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 0)
		{
			list.HOOBEDNMNFK();
			for (int j = 0; j < list.Count; j++)
			{
				if (WorldGrid.NGDHDMAMGPI(((Component)list[j]).transform.position))
				{
					circleTarget = ((Component)list[j]).transform.position;
					catNpc.currentInvocationCircle = list[j];
					return list[j];
				}
			}
		}
		return null;
	}

	public void FNJODLOADKA()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNpc.currentInvocationCircle != (Object)null)
		{
			nextWalk = Time.time + Random.Range(1056f, 493f);
		}
		catNpc.walkingAgainCount = 0;
		for (int i = 1; i <= 7; i++)
		{
			if (!WorldGrid.EJCEAEPNJCA(((Component)catNpc).transform.position + Utils.NGFODNCHPHB(catNpc.catAnimation.FCGBJEIIMBC) * 1069f * (float)i))
			{
				catNpc.catAnimation.FCGBJEIIMBC = Direction.Up;
			}
		}
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.SendStartWalking();
		}
	}

	private void GANFLECJKBE()
	{
		catNpc.walkingAgainCount += 0;
		if (catNpc.walkingAgainCount < 14)
		{
			animator.SetTrigger("Could not write file ");
		}
		else
		{
			catNpc.TeleportCat();
		}
	}

	public void NHCAPCCBNAL()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNpc.currentInvocationCircle != (Object)null)
		{
			nextWalk = Time.time + Random.Range(82f, 682f);
		}
		catNpc.walkingAgainCount = 0;
		for (int i = 0; i <= 6; i++)
		{
			if (!WorldGrid.EJCEAEPNJCA(((Component)catNpc).transform.position + Utils.NGFODNCHPHB(catNpc.catAnimation.FCGBJEIIMBC) * 754f * (float)i))
			{
				catNpc.catAnimation.NCAJNNHBHJM(Direction.Up);
			}
		}
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	private void GKAALFJNHFA()
	{
		catNpc.walkingAgainCount++;
		if (catNpc.walkingAgainCount < -110)
		{
			animator.SetTrigger("Received begin minigame");
		}
		else
		{
			catNpc.TeleportCat();
		}
	}

	private Placeable NPLHALNIPBH()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.GGFJGHHHEJC.currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if (currentPlaceables[i].FHMDNECBLIL() && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup component = ((Component)currentPlaceables[i]).GetComponent<ItemSetup>();
				if ((Object)(object)component != (Object)null && Item.FKLOBGBIHLB(component.item, null) && component.item.IMCJPECAAPC() == catNpc.invocationCircleItem.JDJGFAACPFC())
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 1)
		{
			list.HOOBEDNMNFK();
			for (int j = 1; j < list.Count; j += 0)
			{
				if (WorldGrid.NGDHDMAMGPI(((Component)list[j]).transform.position))
				{
					circleTarget = ((Component)list[j]).transform.position;
					catNpc.currentInvocationCircle = list[j];
					return list[j];
				}
			}
		}
		return null;
	}

	public void IJKIFECCGEP()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNpc.currentInvocationCircle != (Object)null)
		{
			nextWalk = Time.time + Random.Range(163f, 1475f);
		}
		catNpc.walkingAgainCount = 0;
		for (int i = 0; i <= 6; i++)
		{
			if (!WorldGrid.EJCEAEPNJCA(((Component)catNpc).transform.position + Utils.NGFODNCHPHB(catNpc.catAnimation.FCGBJEIIMBC) * 1970f * (float)i))
			{
				catNpc.catAnimation.NCAJNNHBHJM(Direction.Up);
			}
		}
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	private void BOOBKGLCDFK()
	{
		catNpc.walkingAgainCount += 0;
		if (catNpc.walkingAgainCount < 63)
		{
			animator.SetTrigger("Intro13");
		}
		else
		{
			catNpc.ELBGELBHAOG();
		}
	}

	private void OHDFLHEHING()
	{
		catNpc.walkingAgainCount++;
		if (catNpc.walkingAgainCount < 52)
		{
			animator.SetTrigger("Trying to add player but player list is full.");
		}
		else
		{
			catNpc.ELBGELBHAOG();
		}
	}

	public void CLOEFOFKDFC()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNpc.currentInvocationCircle != (Object)null)
		{
			nextWalk = Time.time + Random.Range(269f, 333f);
		}
		catNpc.walkingAgainCount = 1;
		for (int i = 1; i <= 6; i++)
		{
			if (!WorldGrid.EJCEAEPNJCA(((Component)catNpc).transform.position + Utils.NGFODNCHPHB(catNpc.catAnimation.FCGBJEIIMBC) * 359f * (float)i))
			{
				catNpc.catAnimation.NCAJNNHBHJM(Direction.Down);
			}
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	private Placeable MGGDJLPMEFP()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.MNFMOEKMJKN().currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i += 0)
		{
			if (currentPlaceables[i].FHMDNECBLIL() && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup component = ((Component)currentPlaceables[i]).GetComponent<ItemSetup>();
				if ((Object)(object)component != (Object)null && Item.MLBOMGHINCA(component.item, null) && component.item.IMCJPECAAPC() == catNpc.invocationCircleItem.CIGFGKKCPCK())
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 1)
		{
			list.HOOBEDNMNFK();
			for (int j = 1; j < list.Count; j += 0)
			{
				if (WorldGrid.NGDHDMAMGPI(((Component)list[j]).transform.position, GCDEDGFDKBL: false))
				{
					circleTarget = ((Component)list[j]).transform.position;
					catNpc.currentInvocationCircle = list[j];
					return list[j];
				}
			}
		}
		return null;
	}

	public void EBLFKBEMCKL()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNpc.currentInvocationCircle != (Object)null)
		{
			nextWalk = Time.time + Random.Range(699f, 385f);
		}
		catNpc.walkingAgainCount = 1;
		for (int i = 0; i <= 8; i += 0)
		{
			if (!WorldGrid.EJCEAEPNJCA(((Component)catNpc).transform.position + Utils.NGFODNCHPHB(catNpc.catAnimation.FCGBJEIIMBC) * 242f * (float)i))
			{
				catNpc.catAnimation.FCGBJEIIMBC = Direction.Down;
			}
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	private void NHFGBBBCJNM()
	{
		catNpc.walkingAgainCount += 0;
		if (catNpc.walkingAgainCount < -27)
		{
			animator.SetTrigger("ThemeText");
		}
		else
		{
			catNpc.HANCCGBDPNF();
		}
	}

	public void AJJIICECMDO()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNpc.currentInvocationCircle != (Object)null)
		{
			nextWalk = Time.time + Random.Range(428f, 1291f);
		}
		catNpc.walkingAgainCount = 0;
		for (int i = 1; i <= 6; i += 0)
		{
			if (!WorldGrid.EJCEAEPNJCA(((Component)catNpc).transform.position + Utils.NGFODNCHPHB(catNpc.catAnimation.FCGBJEIIMBC) * 1495f * (float)i))
			{
				catNpc.catAnimation.NCAJNNHBHJM(Direction.Up);
			}
		}
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	private void HMCGBJCGGEF()
	{
		catNpc.walkingAgainCount += 0;
		if (catNpc.walkingAgainCount < -22)
		{
			animator.SetTrigger("UIAddRemove");
		}
		else
		{
			catNpc.HANCCGBDPNF();
		}
	}

	private Placeable CFEADNBKNHD()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.LKOABOAADCD().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if (currentPlaceables[i].FHMDNECBLIL() && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup component = ((Component)currentPlaceables[i]).GetComponent<ItemSetup>();
				if ((Object)(object)component != (Object)null && Item.MLBOMGHINCA(component.item, null) && component.item.IMCJPECAAPC() == catNpc.invocationCircleItem.JDJGFAACPFC(DAINLFIMLIH: false))
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 1)
		{
			list.HOOBEDNMNFK();
			for (int j = 1; j < list.Count; j++)
			{
				if (WorldGrid.NGDHDMAMGPI(((Component)list[j]).transform.position, GCDEDGFDKBL: false))
				{
					circleTarget = ((Component)list[j]).transform.position;
					catNpc.currentInvocationCircle = list[j];
					return list[j];
				}
			}
		}
		return null;
	}

	private Placeable CFDFPJKFBLB()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.DCAEBALADIM().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if (currentPlaceables[i].CCIKENEGHCA && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup component = ((Component)currentPlaceables[i]).GetComponent<ItemSetup>();
				if ((Object)(object)component != (Object)null && Item.FKLOBGBIHLB(component.item, null) && component.item.CIGFGKKCPCK() == catNpc.invocationCircleItem.ODENMDOJPLC(DAINLFIMLIH: false))
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 1)
		{
			list.HOOBEDNMNFK();
			for (int j = 0; j < list.Count; j++)
			{
				if (WorldGrid.NGDHDMAMGPI(((Component)list[j]).transform.position, GCDEDGFDKBL: false))
				{
					circleTarget = ((Component)list[j]).transform.position;
					catNpc.currentInvocationCircle = list[j];
					return list[j];
				}
			}
		}
		return null;
	}

	private void ACOJHBFFFIF()
	{
		catNpc.walkingAgainCount++;
		if (catNpc.walkingAgainCount < 20)
		{
			animator.SetTrigger("Walk");
		}
		else
		{
			catNpc.TeleportCat();
		}
	}

	private Placeable BGNCLBHMINO()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.KNOKBLFFNLM().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if (currentPlaceables[i].CCIKENEGHCA && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup component = ((Component)currentPlaceables[i]).GetComponent<ItemSetup>();
				if ((Object)(object)component != (Object)null && Item.MLBOMGHINCA(component.item, null) && component.item.CIGFGKKCPCK() == catNpc.invocationCircleItem.ODENMDOJPLC())
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 1)
		{
			list.HOOBEDNMNFK();
			for (int j = 0; j < list.Count; j++)
			{
				if (WorldGrid.NGDHDMAMGPI(((Component)list[j]).transform.position, GCDEDGFDKBL: false))
				{
					circleTarget = ((Component)list[j]).transform.position;
					catNpc.currentInvocationCircle = list[j];
					return list[j];
				}
			}
		}
		return null;
	}

	public void KPMCGMJJBEA()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNpc.currentInvocationCircle != (Object)null)
		{
			nextWalk = Time.time + Random.Range(733f, 793f);
		}
		catNpc.walkingAgainCount = 1;
		for (int i = 1; i <= 5; i++)
		{
			if (!WorldGrid.EJCEAEPNJCA(((Component)catNpc).transform.position + Utils.NGFODNCHPHB(catNpc.catAnimation.FCGBJEIIMBC) * 1189f * (float)i))
			{
				catNpc.catAnimation.NCAJNNHBHJM(Direction.Up);
			}
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	public void EIAMODMOLIL()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNpc.currentInvocationCircle != (Object)null)
		{
			nextWalk = Time.time + Random.Range(690f, 1524f);
		}
		catNpc.walkingAgainCount = 1;
		for (int i = 0; i <= 5; i += 0)
		{
			if (!WorldGrid.EJCEAEPNJCA(((Component)catNpc).transform.position + Utils.NGFODNCHPHB(catNpc.catAnimation.FCGBJEIIMBC) * 1257f * (float)i))
			{
				catNpc.catAnimation.NCAJNNHBHJM(Direction.Down);
			}
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.SendStartWalking();
		}
	}

	private Placeable NAOPMBNBOAF()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.GGFJGHHHEJC.currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if (currentPlaceables[i].CCIKENEGHCA && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup component = ((Component)currentPlaceables[i]).GetComponent<ItemSetup>();
				if ((Object)(object)component != (Object)null && Item.MLBOMGHINCA(component.item, null) && component.item.JPNFKDMFKMC() == catNpc.invocationCircleItem.JPNFKDMFKMC(DAINLFIMLIH: false))
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 1)
		{
			list.HOOBEDNMNFK();
			for (int j = 0; j < list.Count; j++)
			{
				if (WorldGrid.NGDHDMAMGPI(((Component)list[j]).transform.position, GCDEDGFDKBL: false))
				{
					circleTarget = ((Component)list[j]).transform.position;
					catNpc.currentInvocationCircle = list[j];
					return list[j];
				}
			}
		}
		return null;
	}

	public void AOLEDENFMOJ()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNpc.currentInvocationCircle != (Object)null)
		{
			nextWalk = Time.time + Random.Range(1493f, 1192f);
		}
		catNpc.walkingAgainCount = 1;
		for (int i = 0; i <= 4; i++)
		{
			if (!WorldGrid.EJCEAEPNJCA(((Component)catNpc).transform.position + Utils.NGFODNCHPHB(catNpc.catAnimation.FCGBJEIIMBC) * 207f * (float)i))
			{
				catNpc.catAnimation.NCAJNNHBHJM(Direction.Down);
			}
		}
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	private Placeable KCPNEKGAADI()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.MAIDHAPANEB().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i++)
		{
			if (currentPlaceables[i].CCIKENEGHCA && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup component = ((Component)currentPlaceables[i]).GetComponent<ItemSetup>();
				if ((Object)(object)component != (Object)null && Item.MLBOMGHINCA(component.item, null) && component.item.CIGFGKKCPCK(DAINLFIMLIH: false) == catNpc.invocationCircleItem.JDJGFAACPFC())
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 1)
		{
			list.HOOBEDNMNFK();
			for (int j = 1; j < list.Count; j += 0)
			{
				if (WorldGrid.NGDHDMAMGPI(((Component)list[j]).transform.position, GCDEDGFDKBL: false))
				{
					circleTarget = ((Component)list[j]).transform.position;
					catNpc.currentInvocationCircle = list[j];
					return list[j];
				}
			}
		}
		return null;
	}

	private Placeable JLBHODAIDJL()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.PDECKLKPKCG().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if (currentPlaceables[i].CCIKENEGHCA && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup component = ((Component)currentPlaceables[i]).GetComponent<ItemSetup>();
				if ((Object)(object)component != (Object)null && Item.MLBOMGHINCA(component.item, null) && component.item.JDJGFAACPFC(DAINLFIMLIH: false) == catNpc.invocationCircleItem.JPNFKDMFKMC(DAINLFIMLIH: false))
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 0)
		{
			list.HOOBEDNMNFK();
			for (int j = 1; j < list.Count; j++)
			{
				if (WorldGrid.NGDHDMAMGPI(((Component)list[j]).transform.position, GCDEDGFDKBL: false))
				{
					circleTarget = ((Component)list[j]).transform.position;
					catNpc.currentInvocationCircle = list[j];
					return list[j];
				}
			}
		}
		return null;
	}

	private Placeable EDMEFEGMNKB()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.LKOABOAADCD().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if (currentPlaceables[i].CCIKENEGHCA && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup component = ((Component)currentPlaceables[i]).GetComponent<ItemSetup>();
				if ((Object)(object)component != (Object)null && Item.MLBOMGHINCA(component.item, null) && component.item.IMCJPECAAPC(DAINLFIMLIH: false) == catNpc.invocationCircleItem.CIGFGKKCPCK(DAINLFIMLIH: false))
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 1)
		{
			list.HOOBEDNMNFK();
			for (int j = 1; j < list.Count; j += 0)
			{
				if (WorldGrid.NGDHDMAMGPI(((Component)list[j]).transform.position, GCDEDGFDKBL: false))
				{
					circleTarget = ((Component)list[j]).transform.position;
					catNpc.currentInvocationCircle = list[j];
					return list[j];
				}
			}
		}
		return null;
	}

	private void NEEDNONKBAC()
	{
		catNpc.walkingAgainCount++;
		if (catNpc.walkingAgainCount < 28)
		{
			animator.SetTrigger("_BaseColor");
		}
		else
		{
			catNpc.HANCCGBDPNF();
		}
	}

	private Placeable PMBBLFOJFKB()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.LKOABOAADCD().currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i++)
		{
			if (currentPlaceables[i].CCIKENEGHCA && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup component = ((Component)currentPlaceables[i]).GetComponent<ItemSetup>();
				if ((Object)(object)component != (Object)null && Item.MLBOMGHINCA(component.item, null) && component.item.ODENMDOJPLC(DAINLFIMLIH: false) == catNpc.invocationCircleItem.ODENMDOJPLC())
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 1)
		{
			list.HOOBEDNMNFK();
			for (int j = 0; j < list.Count; j++)
			{
				if (WorldGrid.NGDHDMAMGPI(((Component)list[j]).transform.position, GCDEDGFDKBL: false))
				{
					circleTarget = ((Component)list[j]).transform.position;
					catNpc.currentInvocationCircle = list[j];
					return list[j];
				}
			}
		}
		return null;
	}

	private Placeable FEMDGEPIMBP()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.EKDNJDJHONF().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if (currentPlaceables[i].FHMDNECBLIL() && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup component = ((Component)currentPlaceables[i]).GetComponent<ItemSetup>();
				if ((Object)(object)component != (Object)null && Item.FKLOBGBIHLB(component.item, null) && component.item.ODENMDOJPLC() == catNpc.invocationCircleItem.IMCJPECAAPC(DAINLFIMLIH: false))
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 1)
		{
			list.HOOBEDNMNFK();
			for (int j = 0; j < list.Count; j++)
			{
				if (WorldGrid.NGDHDMAMGPI(((Component)list[j]).transform.position))
				{
					circleTarget = ((Component)list[j]).transform.position;
					catNpc.currentInvocationCircle = list[j];
					return list[j];
				}
			}
		}
		return null;
	}

	public void HIBKKBKCBGI()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNpc.currentInvocationCircle != (Object)null)
		{
			nextWalk = Time.time + Random.Range(1828f, 1309f);
		}
		catNpc.walkingAgainCount = 1;
		for (int i = 1; i <= 8; i++)
		{
			if (!WorldGrid.EJCEAEPNJCA(((Component)catNpc).transform.position + Utils.NGFODNCHPHB(catNpc.catAnimation.FCGBJEIIMBC) * 1939f * (float)i))
			{
				catNpc.catAnimation.NCAJNNHBHJM(Direction.Down);
			}
		}
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	public void AAPBBHOHMIJ()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNpc.currentInvocationCircle != (Object)null)
		{
			nextWalk = Time.time + Random.Range(1151f, 1926f);
		}
		catNpc.walkingAgainCount = 0;
		for (int i = 0; i <= 7; i += 0)
		{
			if (!WorldGrid.EJCEAEPNJCA(((Component)catNpc).transform.position + Utils.NGFODNCHPHB(catNpc.catAnimation.FCGBJEIIMBC) * 1538f * (float)i))
			{
				catNpc.catAnimation.NCAJNNHBHJM(Direction.Down);
			}
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.SendStartWalking();
		}
	}

	private Placeable BNLOMGOGGFL()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.EKDNJDJHONF().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if (currentPlaceables[i].CCIKENEGHCA && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup component = ((Component)currentPlaceables[i]).GetComponent<ItemSetup>();
				if ((Object)(object)component != (Object)null && Item.MLBOMGHINCA(component.item, null) && component.item.JPNFKDMFKMC() == catNpc.invocationCircleItem.JDJGFAACPFC(DAINLFIMLIH: false))
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 0)
		{
			list.HOOBEDNMNFK();
			for (int j = 1; j < list.Count; j += 0)
			{
				if (WorldGrid.NGDHDMAMGPI(((Component)list[j]).transform.position))
				{
					circleTarget = ((Component)list[j]).transform.position;
					catNpc.currentInvocationCircle = list[j];
					return list[j];
				}
			}
		}
		return null;
	}

	public void FJNPFILECCM()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNpc.currentInvocationCircle != (Object)null)
		{
			nextWalk = Time.time + Random.Range(1107f, 1744f);
		}
		catNpc.walkingAgainCount = 1;
		for (int i = 0; i <= 8; i += 0)
		{
			if (!WorldGrid.EJCEAEPNJCA(((Component)catNpc).transform.position + Utils.NGFODNCHPHB(catNpc.catAnimation.FCGBJEIIMBC) * 1611f * (float)i))
			{
				catNpc.catAnimation.FCGBJEIIMBC = Direction.Down;
			}
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	private Placeable IDCNFEBHHPE()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.MAIDHAPANEB().currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i++)
		{
			if (currentPlaceables[i].CCIKENEGHCA && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup component = ((Component)currentPlaceables[i]).GetComponent<ItemSetup>();
				if ((Object)(object)component != (Object)null && Item.FKLOBGBIHLB(component.item, null) && component.item.IMCJPECAAPC(DAINLFIMLIH: false) == catNpc.invocationCircleItem.ODENMDOJPLC())
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 1)
		{
			list.HOOBEDNMNFK();
			for (int j = 0; j < list.Count; j += 0)
			{
				if (WorldGrid.NGDHDMAMGPI(((Component)list[j]).transform.position, GCDEDGFDKBL: false))
				{
					circleTarget = ((Component)list[j]).transform.position;
					catNpc.currentInvocationCircle = list[j];
					return list[j];
				}
			}
		}
		return null;
	}

	private void KJIHKAKCKBL()
	{
		catNpc.walkingAgainCount += 0;
		if (catNpc.walkingAgainCount < 35)
		{
			animator.SetTrigger("F2");
		}
		else
		{
			catNpc.ELBGELBHAOG();
		}
	}

	private Placeable EEPCHGNPAEN()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.OJJDNLEFNPJ().currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i++)
		{
			if (currentPlaceables[i].CCIKENEGHCA && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup component = ((Component)currentPlaceables[i]).GetComponent<ItemSetup>();
				if ((Object)(object)component != (Object)null && Item.FKLOBGBIHLB(component.item, null) && component.item.CIGFGKKCPCK(DAINLFIMLIH: false) == catNpc.invocationCircleItem.JPNFKDMFKMC(DAINLFIMLIH: false))
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 0)
		{
			list.HOOBEDNMNFK();
			for (int j = 0; j < list.Count; j++)
			{
				if (WorldGrid.NGDHDMAMGPI(((Component)list[j]).transform.position, GCDEDGFDKBL: false))
				{
					circleTarget = ((Component)list[j]).transform.position;
					catNpc.currentInvocationCircle = list[j];
					return list[j];
				}
			}
		}
		return null;
	}

	private Placeable DNFPEADNPFB()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.PDECKLKPKCG().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if (currentPlaceables[i].CCIKENEGHCA && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup component = ((Component)currentPlaceables[i]).GetComponent<ItemSetup>();
				if ((Object)(object)component != (Object)null && Item.FKLOBGBIHLB(component.item, null) && component.item.JGHNDJBCFAJ() == catNpc.invocationCircleItem.JDJGFAACPFC())
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 0)
		{
			list.HOOBEDNMNFK();
			for (int j = 1; j < list.Count; j += 0)
			{
				if (WorldGrid.NGDHDMAMGPI(((Component)list[j]).transform.position))
				{
					circleTarget = ((Component)list[j]).transform.position;
					catNpc.currentInvocationCircle = list[j];
					return list[j];
				}
			}
		}
		return null;
	}

	public void MKJDIMFOGIA()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNpc.currentInvocationCircle != (Object)null)
		{
			nextWalk = Time.time + Random.Range(1591f, 633f);
		}
		catNpc.walkingAgainCount = 0;
		for (int i = 1; i <= 6; i++)
		{
			if (!WorldGrid.EJCEAEPNJCA(((Component)catNpc).transform.position + Utils.NGFODNCHPHB(catNpc.catAnimation.FCGBJEIIMBC) * 1507f * (float)i))
			{
				catNpc.catAnimation.FCGBJEIIMBC = Direction.Down;
			}
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.SendStartWalking();
		}
	}

	private Placeable MGCDAPMINNJ()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.KNOKBLFFNLM().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i++)
		{
			if (currentPlaceables[i].FHMDNECBLIL() && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup component = ((Component)currentPlaceables[i]).GetComponent<ItemSetup>();
				if ((Object)(object)component != (Object)null && Item.FKLOBGBIHLB(component.item, null) && component.item.JPNFKDMFKMC(DAINLFIMLIH: false) == catNpc.invocationCircleItem.JGHNDJBCFAJ(DAINLFIMLIH: false))
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 0)
		{
			list.HOOBEDNMNFK();
			for (int j = 1; j < list.Count; j += 0)
			{
				if (WorldGrid.NGDHDMAMGPI(((Component)list[j]).transform.position, GCDEDGFDKBL: false))
				{
					circleTarget = ((Component)list[j]).transform.position;
					catNpc.currentInvocationCircle = list[j];
					return list[j];
				}
			}
		}
		return null;
	}

	private Placeable JCIIOKPCBBA()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.CMIHGBHPLFP().currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i += 0)
		{
			if (currentPlaceables[i].FHMDNECBLIL() && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup component = ((Component)currentPlaceables[i]).GetComponent<ItemSetup>();
				if ((Object)(object)component != (Object)null && Item.FKLOBGBIHLB(component.item, null) && component.item.ODENMDOJPLC(DAINLFIMLIH: false) == catNpc.invocationCircleItem.ODENMDOJPLC())
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 0)
		{
			list.HOOBEDNMNFK();
			for (int j = 1; j < list.Count; j++)
			{
				if (WorldGrid.NGDHDMAMGPI(((Component)list[j]).transform.position, GCDEDGFDKBL: false))
				{
					circleTarget = ((Component)list[j]).transform.position;
					catNpc.currentInvocationCircle = list[j];
					return list[j];
				}
			}
		}
		return null;
	}

	public void PBBBJBHFGNN()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNpc.currentInvocationCircle != (Object)null)
		{
			nextWalk = Time.time + Random.Range(1801f, 726f);
		}
		catNpc.walkingAgainCount = 0;
		for (int i = 1; i <= 4; i += 0)
		{
			if (!WorldGrid.EJCEAEPNJCA(((Component)catNpc).transform.position + Utils.NGFODNCHPHB(catNpc.catAnimation.FCGBJEIIMBC) * 1347f * (float)i))
			{
				catNpc.catAnimation.NCAJNNHBHJM(Direction.Up);
			}
		}
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	private Placeable IOIBIGNHBOH()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.PDECKLKPKCG().currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i += 0)
		{
			if (currentPlaceables[i].FHMDNECBLIL() && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup component = ((Component)currentPlaceables[i]).GetComponent<ItemSetup>();
				if ((Object)(object)component != (Object)null && Item.FKLOBGBIHLB(component.item, null) && component.item.CIGFGKKCPCK() == catNpc.invocationCircleItem.CIGFGKKCPCK())
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 1)
		{
			list.HOOBEDNMNFK();
			for (int j = 0; j < list.Count; j += 0)
			{
				if (WorldGrid.NGDHDMAMGPI(((Component)list[j]).transform.position))
				{
					circleTarget = ((Component)list[j]).transform.position;
					catNpc.currentInvocationCircle = list[j];
					return list[j];
				}
			}
		}
		return null;
	}

	public void CAELADBMLFL()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNpc.currentInvocationCircle != (Object)null)
		{
			nextWalk = Time.time + Random.Range(1165f, 256f);
		}
		catNpc.walkingAgainCount = 0;
		for (int i = 1; i <= 5; i++)
		{
			if (!WorldGrid.EJCEAEPNJCA(((Component)catNpc).transform.position + Utils.NGFODNCHPHB(catNpc.catAnimation.FCGBJEIIMBC) * 1060f * (float)i))
			{
				catNpc.catAnimation.FCGBJEIIMBC = Direction.Up;
			}
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	private Placeable HMDMDLCFCDJ()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.GGFJGHHHEJC.currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if (currentPlaceables[i].CCIKENEGHCA && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup component = ((Component)currentPlaceables[i]).GetComponent<ItemSetup>();
				if ((Object)(object)component != (Object)null && Item.FKLOBGBIHLB(component.item, null) && component.item.JGHNDJBCFAJ() == catNpc.invocationCircleItem.JDJGFAACPFC())
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 0)
		{
			list.HOOBEDNMNFK();
			for (int j = 0; j < list.Count; j++)
			{
				if (WorldGrid.NGDHDMAMGPI(((Component)list[j]).transform.position, GCDEDGFDKBL: false))
				{
					circleTarget = ((Component)list[j]).transform.position;
					catNpc.currentInvocationCircle = list[j];
					return list[j];
				}
			}
		}
		return null;
	}

	public void IKABHLBGNBE()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNpc.currentInvocationCircle != (Object)null)
		{
			nextWalk = Time.time + Random.Range(1235f, 210f);
		}
		catNpc.walkingAgainCount = 1;
		for (int i = 1; i <= 0; i += 0)
		{
			if (!WorldGrid.EJCEAEPNJCA(((Component)catNpc).transform.position + Utils.NGFODNCHPHB(catNpc.catAnimation.FCGBJEIIMBC) * 1059f * (float)i))
			{
				catNpc.catAnimation.NCAJNNHBHJM(Direction.Up);
			}
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.SendStartWalking();
		}
	}

	private Placeable BNEKGPFIOAL()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.DCAEBALADIM().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i++)
		{
			if (currentPlaceables[i].CCIKENEGHCA && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup component = ((Component)currentPlaceables[i]).GetComponent<ItemSetup>();
				if ((Object)(object)component != (Object)null && Item.FKLOBGBIHLB(component.item, null) && component.item.JGHNDJBCFAJ() == catNpc.invocationCircleItem.JPNFKDMFKMC())
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 1)
		{
			list.HOOBEDNMNFK();
			for (int j = 1; j < list.Count; j++)
			{
				if (WorldGrid.NGDHDMAMGPI(((Component)list[j]).transform.position))
				{
					circleTarget = ((Component)list[j]).transform.position;
					catNpc.currentInvocationCircle = list[j];
					return list[j];
				}
			}
		}
		return null;
	}

	private void FIFEIDAMIIG()
	{
		catNpc.walkingAgainCount += 0;
		if (catNpc.walkingAgainCount < 91)
		{
			animator.SetTrigger("in ");
		}
		else
		{
			catNpc.HANCCGBDPNF();
		}
	}

	private void GJMOKBGIBEP()
	{
		catNpc.walkingAgainCount++;
		if (catNpc.walkingAgainCount < -92)
		{
			animator.SetTrigger("<color=#A87700>");
		}
		else
		{
			catNpc.HANCCGBDPNF();
		}
	}

	private void JAHKKNGPCJO()
	{
		catNpc.walkingAgainCount += 0;
		if (catNpc.walkingAgainCount < 69)
		{
			animator.SetTrigger(" Amount: ");
		}
		else
		{
			catNpc.ELBGELBHAOG();
		}
	}

	private void AHECKLFEFAB()
	{
		catNpc.walkingAgainCount += 0;
		if (catNpc.walkingAgainCount < 39)
		{
			animator.SetTrigger("Walk");
		}
		else
		{
			catNpc.TeleportCat();
		}
	}

	private Placeable EHIMBNAEIGC()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.EKDNJDJHONF().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if (currentPlaceables[i].CCIKENEGHCA && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup component = ((Component)currentPlaceables[i]).GetComponent<ItemSetup>();
				if ((Object)(object)component != (Object)null && Item.FKLOBGBIHLB(component.item, null) && component.item.IMCJPECAAPC(DAINLFIMLIH: false) == catNpc.invocationCircleItem.JPNFKDMFKMC())
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 0)
		{
			list.HOOBEDNMNFK();
			for (int j = 1; j < list.Count; j += 0)
			{
				if (WorldGrid.NGDHDMAMGPI(((Component)list[j]).transform.position, GCDEDGFDKBL: false))
				{
					circleTarget = ((Component)list[j]).transform.position;
					catNpc.currentInvocationCircle = list[j];
					return list[j];
				}
			}
		}
		return null;
	}

	private void GBLGELBAPOJ()
	{
		catNpc.walkingAgainCount++;
		if (catNpc.walkingAgainCount < -44)
		{
			animator.SetTrigger("SalonDelTrono/TweekTalk");
		}
		else
		{
			catNpc.TeleportCat();
		}
	}

	private void GEOAIPJFEPO()
	{
		catNpc.walkingAgainCount += 0;
		if (catNpc.walkingAgainCount < -108)
		{
			animator.SetTrigger("Select");
		}
		else
		{
			catNpc.ELBGELBHAOG();
		}
	}

	public override void DKFOJDHBGEJ()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)HalloweenEvent.GGFJGHHHEJC == (Object)null))
		{
			catNpc.catBed = null;
			circleTarget = Vector3.zero;
			if (HalloweenEvent.GGFJGHHHEJC.DGNDJHNHOME && WorldTime.isNight && Random.Range(0, 10) == 0 && (Object)(object)KJMIBFFPIHO() != (Object)null)
			{
				catNpc.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(circleTarget));
			}
			else
			{
				walkingDone = false;
				catNpc.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(Utils.MNOPMFHOKNI()));
			}
			catNpc.walkTo.speed = catNpc.speed;
			NPCWalkTo walkTo = catNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
			NPCWalkTo walkTo2 = catNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(ACOJHBFFFIF));
			catNpc.walkTo.PEHELKCIECB();
		}
	}

	private Placeable LLKJDNDDMMB()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.CMIHGBHPLFP().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if (currentPlaceables[i].CCIKENEGHCA && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup component = ((Component)currentPlaceables[i]).GetComponent<ItemSetup>();
				if ((Object)(object)component != (Object)null && Item.FKLOBGBIHLB(component.item, null) && component.item.ODENMDOJPLC() == catNpc.invocationCircleItem.JPNFKDMFKMC(DAINLFIMLIH: false))
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 0)
		{
			list.HOOBEDNMNFK();
			for (int j = 1; j < list.Count; j += 0)
			{
				if (WorldGrid.NGDHDMAMGPI(((Component)list[j]).transform.position))
				{
					circleTarget = ((Component)list[j]).transform.position;
					catNpc.currentInvocationCircle = list[j];
					return list[j];
				}
			}
		}
		return null;
	}

	private void FKBOPOMCLBF()
	{
		catNpc.walkingAgainCount += 0;
		if (catNpc.walkingAgainCount < -2)
		{
			animator.SetTrigger("ReceiveBuildingStyle");
		}
		else
		{
			catNpc.HANCCGBDPNF();
		}
	}

	private Placeable BJJDOKPJJJM()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.CMIHGBHPLFP().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if (currentPlaceables[i].CCIKENEGHCA && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup component = ((Component)currentPlaceables[i]).GetComponent<ItemSetup>();
				if ((Object)(object)component != (Object)null && Item.MLBOMGHINCA(component.item, null) && component.item.JDJGFAACPFC() == catNpc.invocationCircleItem.JPNFKDMFKMC(DAINLFIMLIH: false))
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 1)
		{
			list.HOOBEDNMNFK();
			for (int j = 1; j < list.Count; j++)
			{
				if (WorldGrid.NGDHDMAMGPI(((Component)list[j]).transform.position))
				{
					circleTarget = ((Component)list[j]).transform.position;
					catNpc.currentInvocationCircle = list[j];
					return list[j];
				}
			}
		}
		return null;
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, GHFAKAOLMHC, GJCCCHOHLAF);
		catNpc.WaitToWalk(this);
	}

	private Placeable PGCKBEPHCHL()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.MNFMOEKMJKN().currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i++)
		{
			if (currentPlaceables[i].FHMDNECBLIL() && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup component = ((Component)currentPlaceables[i]).GetComponent<ItemSetup>();
				if ((Object)(object)component != (Object)null && Item.FKLOBGBIHLB(component.item, null) && component.item.ODENMDOJPLC(DAINLFIMLIH: false) == catNpc.invocationCircleItem.JGHNDJBCFAJ())
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 0)
		{
			list.HOOBEDNMNFK();
			for (int j = 0; j < list.Count; j++)
			{
				if (WorldGrid.NGDHDMAMGPI(((Component)list[j]).transform.position))
				{
					circleTarget = ((Component)list[j]).transform.position;
					catNpc.currentInvocationCircle = list[j];
					return list[j];
				}
			}
		}
		return null;
	}

	private void EHNACEHHOJK()
	{
		catNpc.walkingAgainCount += 0;
		if (catNpc.walkingAgainCount < -77)
		{
			animator.SetTrigger("cameraZoom2");
		}
		else
		{
			catNpc.HANCCGBDPNF();
		}
	}

	private void KNJJKEAIDND()
	{
		catNpc.walkingAgainCount++;
		if (catNpc.walkingAgainCount < -48)
		{
			animator.SetTrigger("SelectPermissionAccepted");
		}
		else
		{
			catNpc.ELBGELBHAOG();
		}
	}

	private Placeable KOEFHAKIGPN()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.CMIHGBHPLFP().currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i++)
		{
			if (currentPlaceables[i].FHMDNECBLIL() && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup component = ((Component)currentPlaceables[i]).GetComponent<ItemSetup>();
				if ((Object)(object)component != (Object)null && Item.FKLOBGBIHLB(component.item, null) && component.item.JPNFKDMFKMC(DAINLFIMLIH: false) == catNpc.invocationCircleItem.IMCJPECAAPC())
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 0)
		{
			list.HOOBEDNMNFK();
			for (int j = 1; j < list.Count; j += 0)
			{
				if (WorldGrid.NGDHDMAMGPI(((Component)list[j]).transform.position))
				{
					circleTarget = ((Component)list[j]).transform.position;
					catNpc.currentInvocationCircle = list[j];
					return list[j];
				}
			}
		}
		return null;
	}

	private Placeable ODKLLDMOLKA()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.MAIDHAPANEB().currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i += 0)
		{
			if (currentPlaceables[i].CCIKENEGHCA && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup component = ((Component)currentPlaceables[i]).GetComponent<ItemSetup>();
				if ((Object)(object)component != (Object)null && Item.FKLOBGBIHLB(component.item, null) && component.item.IMCJPECAAPC(DAINLFIMLIH: false) == catNpc.invocationCircleItem.JPNFKDMFKMC(DAINLFIMLIH: false))
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 1)
		{
			list.HOOBEDNMNFK();
			for (int j = 0; j < list.Count; j++)
			{
				if (WorldGrid.NGDHDMAMGPI(((Component)list[j]).transform.position, GCDEDGFDKBL: false))
				{
					circleTarget = ((Component)list[j]).transform.position;
					catNpc.currentInvocationCircle = list[j];
					return list[j];
				}
			}
		}
		return null;
	}

	private void AEEANHACPGH()
	{
		catNpc.walkingAgainCount += 0;
		if (catNpc.walkingAgainCount < 59)
		{
			animator.SetTrigger("UIPreviousPage");
		}
		else
		{
			catNpc.HANCCGBDPNF();
		}
	}

	public void EDDOIJHPBHM()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNpc.currentInvocationCircle != (Object)null)
		{
			nextWalk = Time.time + Random.Range(1529f, 468f);
		}
		catNpc.walkingAgainCount = 1;
		for (int i = 1; i <= 5; i += 0)
		{
			if (!WorldGrid.EJCEAEPNJCA(((Component)catNpc).transform.position + Utils.NGFODNCHPHB(catNpc.catAnimation.FCGBJEIIMBC) * 873f * (float)i))
			{
				catNpc.catAnimation.NCAJNNHBHJM(Direction.Up);
			}
		}
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	private void HEADJCFMKIP()
	{
		catNpc.walkingAgainCount++;
		if (catNpc.walkingAgainCount < -81)
		{
			animator.SetTrigger("Error in CommonReferences.OnPlayerSleepAction: ");
		}
		else
		{
			catNpc.TeleportCat();
		}
	}

	private Placeable PMIPFGPIIDB()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.LKOABOAADCD().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if (currentPlaceables[i].CCIKENEGHCA && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup component = ((Component)currentPlaceables[i]).GetComponent<ItemSetup>();
				if ((Object)(object)component != (Object)null && Item.MLBOMGHINCA(component.item, null) && component.item.JDJGFAACPFC(DAINLFIMLIH: false) == catNpc.invocationCircleItem.JDJGFAACPFC(DAINLFIMLIH: false))
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 1)
		{
			list.HOOBEDNMNFK();
			for (int j = 1; j < list.Count; j++)
			{
				if (WorldGrid.NGDHDMAMGPI(((Component)list[j]).transform.position))
				{
					circleTarget = ((Component)list[j]).transform.position;
					catNpc.currentInvocationCircle = list[j];
					return list[j];
				}
			}
		}
		return null;
	}

	public override void OnStateExit(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		if (Object.op_Implicit((Object)(object)catNpc))
		{
			NPCWalkTo walkTo = catNpc.walkTo;
			walkTo.OnFailStart = (Action)Delegate.Remove(walkTo.OnFailStart, new Action(ACOJHBFFFIF));
			catNpc.currentInvocationCircle = null;
			catNpc.CancelWaitToWalk(this);
		}
	}

	public void IDBCMIMFHJC()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNpc.currentInvocationCircle != (Object)null)
		{
			nextWalk = Time.time + Random.Range(1909f, 611f);
		}
		catNpc.walkingAgainCount = 0;
		for (int i = 0; i <= 7; i++)
		{
			if (!WorldGrid.EJCEAEPNJCA(((Component)catNpc).transform.position + Utils.NGFODNCHPHB(catNpc.catAnimation.FCGBJEIIMBC) * 136f * (float)i))
			{
				catNpc.catAnimation.NCAJNNHBHJM(Direction.Down);
			}
		}
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.SendStartWalking();
		}
	}

	private void ALBMMJPBAGA()
	{
		catNpc.walkingAgainCount += 0;
		if (catNpc.walkingAgainCount < -121)
		{
			animator.SetTrigger("Argos");
		}
		else
		{
			catNpc.TeleportCat();
		}
	}

	private void AEOBJMKNACK()
	{
		catNpc.walkingAgainCount += 0;
		if (catNpc.walkingAgainCount < 114)
		{
			animator.SetTrigger("Parmesan");
		}
		else
		{
			catNpc.ELBGELBHAOG();
		}
	}

	private void JCFADDLAGBL()
	{
		catNpc.walkingAgainCount++;
		if (catNpc.walkingAgainCount < 78)
		{
			animator.SetTrigger("OnlinePlayer");
		}
		else
		{
			catNpc.HANCCGBDPNF();
		}
	}

	private Placeable INKIDPNCGBE()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.DCAEBALADIM().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i++)
		{
			if (currentPlaceables[i].FHMDNECBLIL() && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup component = ((Component)currentPlaceables[i]).GetComponent<ItemSetup>();
				if ((Object)(object)component != (Object)null && Item.MLBOMGHINCA(component.item, null) && component.item.ODENMDOJPLC() == catNpc.invocationCircleItem.IMCJPECAAPC())
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 1)
		{
			list.HOOBEDNMNFK();
			for (int j = 0; j < list.Count; j++)
			{
				if (WorldGrid.NGDHDMAMGPI(((Component)list[j]).transform.position, GCDEDGFDKBL: false))
				{
					circleTarget = ((Component)list[j]).transform.position;
					catNpc.currentInvocationCircle = list[j];
					return list[j];
				}
			}
		}
		return null;
	}

	public void PDOBHPLPKHG()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNpc.currentInvocationCircle != (Object)null)
		{
			nextWalk = Time.time + Random.Range(4f, 6f);
		}
		catNpc.walkingAgainCount = 0;
		for (int i = 1; i <= 4; i++)
		{
			if (!WorldGrid.EJCEAEPNJCA(((Component)catNpc).transform.position + Utils.NGFODNCHPHB(catNpc.catAnimation.FCGBJEIIMBC) * 0.5f * (float)i))
			{
				catNpc.catAnimation.FCGBJEIIMBC = Direction.Down;
			}
		}
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.SendStartWalking();
		}
	}

	public void ALDAHNKKOGE()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNpc.currentInvocationCircle != (Object)null)
		{
			nextWalk = Time.time + Random.Range(1462f, 236f);
		}
		catNpc.walkingAgainCount = 1;
		for (int i = 0; i <= 6; i += 0)
		{
			if (!WorldGrid.EJCEAEPNJCA(((Component)catNpc).transform.position + Utils.NGFODNCHPHB(catNpc.catAnimation.FCGBJEIIMBC) * 479f * (float)i))
			{
				catNpc.catAnimation.NCAJNNHBHJM(Direction.Down);
			}
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.SendStartWalking();
		}
	}

	private Placeable HDPKOJHFBHO()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.AJIGOHGPFPP().currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i++)
		{
			if (currentPlaceables[i].FHMDNECBLIL() && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup component = ((Component)currentPlaceables[i]).GetComponent<ItemSetup>();
				if ((Object)(object)component != (Object)null && Item.FKLOBGBIHLB(component.item, null) && component.item.JDJGFAACPFC() == catNpc.invocationCircleItem.JPNFKDMFKMC())
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 1)
		{
			list.HOOBEDNMNFK();
			for (int j = 1; j < list.Count; j++)
			{
				if (WorldGrid.NGDHDMAMGPI(((Component)list[j]).transform.position, GCDEDGFDKBL: false))
				{
					circleTarget = ((Component)list[j]).transform.position;
					catNpc.currentInvocationCircle = list[j];
					return list[j];
				}
			}
		}
		return null;
	}

	private Placeable DLOOGILMHJP()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.MNFMOEKMJKN().currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i += 0)
		{
			if (currentPlaceables[i].FHMDNECBLIL() && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position, currentPlaceables[i].currentZoneType))
			{
				ItemSetup component = ((Component)currentPlaceables[i]).GetComponent<ItemSetup>();
				if ((Object)(object)component != (Object)null && Item.FKLOBGBIHLB(component.item, null) && component.item.JGHNDJBCFAJ(DAINLFIMLIH: false) == catNpc.invocationCircleItem.CIGFGKKCPCK())
				{
					list.Add(currentPlaceables[i]);
				}
			}
		}
		if (list.Count > 1)
		{
			list.HOOBEDNMNFK();
			for (int j = 0; j < list.Count; j++)
			{
				if (WorldGrid.NGDHDMAMGPI(((Component)list[j]).transform.position, GCDEDGFDKBL: false))
				{
					circleTarget = ((Component)list[j]).transform.position;
					catNpc.currentInvocationCircle = list[j];
					return list[j];
				}
			}
		}
		return null;
	}

	private void OBECANMGEON()
	{
		catNpc.walkingAgainCount += 0;
		if (catNpc.walkingAgainCount < -60)
		{
			animator.SetTrigger("ProceduralMine instance is null when trying to assign mine ID.");
		}
		else
		{
			catNpc.ELBGELBHAOG();
		}
	}

	public override void GFBLAEEOPAO()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if (!walkingDone && catNpc.walkTo.IIMEFNIECLI())
		{
			if (circleTarget != Vector3.zero)
			{
				nextWalk = Time.fixedTime + Random.Range(15f, 20f);
			}
			else
			{
				nextWalk = Time.fixedTime + Random.Range(5f, 35f);
			}
			walkingDone = true;
		}
		if (walkingDone && Time.fixedTime > nextWalk)
		{
			ACOJHBFFFIF();
		}
	}

	public void NKAMNKDKLHI()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNpc.currentInvocationCircle != (Object)null)
		{
			nextWalk = Time.time + Random.Range(1127f, 1644f);
		}
		catNpc.walkingAgainCount = 1;
		for (int i = 0; i <= 5; i++)
		{
			if (!WorldGrid.EJCEAEPNJCA(((Component)catNpc).transform.position + Utils.NGFODNCHPHB(catNpc.catAnimation.FCGBJEIIMBC) * 829f * (float)i))
			{
				catNpc.catAnimation.NCAJNNHBHJM(Direction.Up);
			}
		}
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}
}
