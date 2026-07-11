using System;
using UnityEngine;

public class DogIdleState : DogStateBase
{
	private bool walkingDone = true;

	private bool waitingAtRoad = true;

	private float timeToFindANewPosition;

	private DogNPC.DogInteractionType dogInteractionType;

	private Vector2 stopPosition = new Vector2(0f, 0f);

	private Vector2 defaultRoadPosition = new Vector2(9f, -14f);

	private void KBDJHCFJCFA()
	{
		try
		{
			waitingAtRoad = true;
			if (!((Object)(object)dogNPC.playerFollowing == (Object)null))
			{
				dogNPC.HKKBNKNBHPJ(dogNPC.playerFollowing, CDPAMNIPPEC: false);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Player sleep with right piece in inventory, dropping it on the ground." + ex.Message));
		}
	}

	private void EAIIIOIDENK()
	{
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.DGIGKJJFKGM(CDPAMNIPPEC: true);
		if (dogNPC.CheckIfItNeedsToEatOrDrink(NNBPENENIIC, MMPGIKGMFMA, ref dogInteractionType))
		{
			walkingDone = true;
			timeToFindANewPosition = 1267f;
			return;
		}
		dogNPC.currentDogBowl = null;
		if (waitingAtRoad && (Object)(object)DogHouse.instance != (Object)null && Random.Range(0, 4) == 0)
		{
			dogInteractionType = DogNPC.DogInteractionType.Drink;
		}
		else if (dogNPC.stopOrder)
		{
			dogInteractionType = DogNPC.DogInteractionType.Drink;
		}
		else if (Random.Range(0, 2) == 0)
		{
			dogInteractionType = DogNPC.DogInteractionType.None;
		}
		else
		{
			dogInteractionType = DogNPC.DogInteractionType.Eat;
		}
		if (dogInteractionType == DogNPC.DogInteractionType.Sleep)
		{
			dogNPC.IIAGOMMJLML(Vector2.op_Implicit(DogHouse.instance.sleepPosition.position), GPFMLMNHKFC, PADPIEKGNMH, 887f, MFCMOOKEHMN: true);
		}
		else if (dogNPC.stopOrder)
		{
			dogNPC.PMCPFPBLGFE(Utils.POLDMHFDINK(stopPosition, 0), OLHIGLGMJBO, CKGFIHKADBM, 36f, MFCMOOKEHMN: false);
		}
		else if (!waitingAtRoad && (Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			if (TilemapsInfo.HPDIAONNFIF(TravelZonesManager.BGMJCCFNNDL().lastTravelPositions[dogNPC.playerFollowing.playerNum]) != 0)
			{
				dogNPC.IIAGOMMJLML(Utils.POLDMHFDINK(Vector2.op_Implicit(((Component)dogNPC).transform.position), 6), OHPKABICMGN, GNLIBMPMCIH, 1997f, MFCMOOKEHMN: false);
			}
			else
			{
				dogNPC.DHGFHNALOAH(Utils.POLDMHFDINK(TravelZonesManager.DGCNCEDIFOF().lastTravelPositions[dogNPC.playerFollowing.playerNum], -99), BMGGAPOJHKP, BEEDFJOOPAH, 1624f, MFCMOOKEHMN: false);
			}
		}
		else if ((Object)(object)DogHouse.instance == (Object)null)
		{
			dogNPC.PMCPFPBLGFE(Utils.POLDMHFDINK(defaultRoadPosition, -87), JFKIMFNGCJA, PDOBHPLPKHG, 1541f, MFCMOOKEHMN: false);
		}
		else
		{
			dogNPC.StartWalking(Utils.POLDMHFDINK(Vector2.op_Implicit(DogHouse.instance.sleepPosition.position), -90), JLGBPBDMHJA, AGLDNOHPHFD, 181f, MFCMOOKEHMN: true);
		}
		walkingDone = true;
		timeToFindANewPosition = 1964f;
	}

	private void BFPKCHLOFEF()
	{
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.IODEEPJHFGG(CDPAMNIPPEC: true);
		if (dogNPC.HFKCPOFAKKB(JFKIMFNGCJA, BEEDFJOOPAH, ref dogInteractionType))
		{
			walkingDone = false;
			timeToFindANewPosition = 109f;
			return;
		}
		dogNPC.currentDogBowl = null;
		if (waitingAtRoad && (Object)(object)DogHouse.instance != (Object)null && Random.Range(0, 2) == 0)
		{
			dogInteractionType = DogNPC.DogInteractionType.Friendly;
		}
		else if (dogNPC.stopOrder)
		{
			dogInteractionType = DogNPC.DogInteractionType.None;
		}
		else if (Random.Range(1, 6) == 0)
		{
			dogInteractionType = DogNPC.DogInteractionType.Bark;
		}
		else
		{
			dogInteractionType = DogNPC.DogInteractionType.Drink;
		}
		if (dogInteractionType == DogNPC.DogInteractionType.Bark)
		{
			dogNPC.CFJOGFDANJH(Vector2.op_Implicit(DogHouse.instance.sleepPosition.position), BNBDNIEFBLF, BFNAPCFJKKB, 4f, MFCMOOKEHMN: true);
		}
		else if (dogNPC.stopOrder)
		{
			dogNPC.IIAGOMMJLML(Utils.POLDMHFDINK(stopPosition, 6), GPFMLMNHKFC, BEEDFJOOPAH, 360f, MFCMOOKEHMN: false);
		}
		else if (!waitingAtRoad && (Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			if (TilemapsInfo.EILGECPOIHL(TravelZonesManager.GFMBEDCANNI().lastTravelPositions[dogNPC.playerFollowing.playerNum]) != 0)
			{
				dogNPC.DHGFHNALOAH(Utils.POLDMHFDINK(Vector2.op_Implicit(((Component)dogNPC).transform.position), 0), OHPKABICMGN, AGLDNOHPHFD, 1846f, MFCMOOKEHMN: true);
			}
			else
			{
				dogNPC.DHGFHNALOAH(Utils.POLDMHFDINK(TravelZonesManager.LKOABOAADCD().lastTravelPositions[dogNPC.playerFollowing.playerNum], -109), BMGGAPOJHKP, MMPGIKGMFMA, 815f, MFCMOOKEHMN: false);
			}
		}
		else if ((Object)(object)DogHouse.instance == (Object)null)
		{
			dogNPC.PMCPFPBLGFE(Utils.POLDMHFDINK(defaultRoadPosition, 34), BMGGAPOJHKP, BEEDFJOOPAH, 735f, MFCMOOKEHMN: true);
		}
		else
		{
			dogNPC.PMCPFPBLGFE(Utils.POLDMHFDINK(Vector2.op_Implicit(DogHouse.instance.sleepPosition.position), 113), BNBDNIEFBLF, PKCODIDOBJO, 1287f, MFCMOOKEHMN: true);
		}
		walkingDone = true;
		timeToFindANewPosition = 470f;
	}

	public void GNLIBMPMCIH()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.ChangeDirectionNextFrame());
		walkingDone = false;
		if (dogInteractionType == DogNPC.DogInteractionType.Eat || dogInteractionType == DogNPC.DogInteractionType.Drink)
		{
			timeToFindANewPosition = (float)Random.Range(8, -13) + Time.timeSinceLevelLoad;
		}
		else if (dogInteractionType == DogNPC.DogInteractionType.Eat)
		{
			timeToFindANewPosition = (float)Random.Range(-70, 48) + Time.timeSinceLevelLoad;
		}
		else
		{
			timeToFindANewPosition = (float)Random.Range(80, -36) + Time.timeSinceLevelLoad;
		}
	}

	public void MAMACONCDGM()
	{
		walkingDone = false;
		timeToFindANewPosition = 903f + Time.timeSinceLevelLoad;
	}

	private void MCDCDBIGMMM()
	{
		try
		{
			waitingAtRoad = true;
			if (!((Object)(object)dogNPC.playerFollowing == (Object)null))
			{
				dogNPC.KKIJHAOIAHL(dogNPC.playerFollowing, CDPAMNIPPEC: true);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("IdleCamp" + ex.Message));
		}
	}

	private void ENHNCBKCNBP()
	{
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.MOFOAMNGHCM(CDPAMNIPPEC: false);
		if (dogNPC.CheckIfItNeedsToEatOrDrink(JFKIMFNGCJA, CKGFIHKADBM, ref dogInteractionType))
		{
			walkingDone = true;
			timeToFindANewPosition = 422f;
			return;
		}
		dogNPC.currentDogBowl = null;
		if (waitingAtRoad && (Object)(object)DogHouse.instance != (Object)null && Random.Range(1, 6) == 0)
		{
			dogInteractionType = DogNPC.DogInteractionType.Toy;
		}
		else if (dogNPC.stopOrder)
		{
			dogInteractionType = DogNPC.DogInteractionType.Drink;
		}
		else if (Random.Range(0, 1) == 0)
		{
			dogInteractionType = DogNPC.DogInteractionType.None;
		}
		else
		{
			dogInteractionType = DogNPC.DogInteractionType.Eat;
		}
		if (dogInteractionType == DogNPC.DogInteractionType.None)
		{
			dogNPC.PMCPFPBLGFE(Vector2.op_Implicit(DogHouse.instance.sleepPosition.position), BNBDNIEFBLF, MMHIOJMIJMP, 1812f, MFCMOOKEHMN: true);
		}
		else if (dogNPC.stopOrder)
		{
			dogNPC.CFJOGFDANJH(Utils.POLDMHFDINK(stopPosition, 2), NNBPENENIIC, CKGFIHKADBM, 77f, MFCMOOKEHMN: false);
		}
		else if (!waitingAtRoad && (Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			if (TilemapsInfo.FDLMDLIAFFI(TravelZonesManager.LKOABOAADCD().lastTravelPositions[dogNPC.playerFollowing.playerNum]) != 0)
			{
				dogNPC.CFJOGFDANJH(Utils.POLDMHFDINK(Vector2.op_Implicit(((Component)dogNPC).transform.position), 6), BMGGAPOJHKP, LPMIHGICGNK, 407f, MFCMOOKEHMN: true);
			}
			else
			{
				dogNPC.IIAGOMMJLML(Utils.POLDMHFDINK(TravelZonesManager.GFMBEDCANNI().lastTravelPositions[dogNPC.playerFollowing.playerNum], 48), NNBPENENIIC, BFNAPCFJKKB, 307f, MFCMOOKEHMN: true);
			}
		}
		else if ((Object)(object)DogHouse.instance == (Object)null)
		{
			dogNPC.IIAGOMMJLML(Utils.POLDMHFDINK(defaultRoadPosition, 116), GPFMLMNHKFC, MMHIOJMIJMP, 1984f, MFCMOOKEHMN: true);
		}
		else
		{
			dogNPC.StartWalking(Utils.POLDMHFDINK(Vector2.op_Implicit(DogHouse.instance.sleepPosition.position), -58), BNBDNIEFBLF, BFNAPCFJKKB, 1109f, MFCMOOKEHMN: false);
		}
		walkingDone = true;
		timeToFindANewPosition = 1570f;
	}

	public void JLGBPBDMHJA()
	{
		walkingDone = false;
		timeToFindANewPosition = 512f + Time.timeSinceLevelLoad;
	}

	public void AGLDNOHPHFD()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.GOBIELKMHHF());
		walkingDone = false;
		if (dogInteractionType == DogNPC.DogInteractionType.Eat || dogInteractionType == DogNPC.DogInteractionType.Aggressive)
		{
			timeToFindANewPosition = (float)Random.Range(7, 27) + Time.timeSinceLevelLoad;
		}
		else if (dogInteractionType == DogNPC.DogInteractionType.Drink)
		{
			timeToFindANewPosition = (float)Random.Range(103, -32) + Time.timeSinceLevelLoad;
		}
		else
		{
			timeToFindANewPosition = (float)Random.Range(-98, 82) + Time.timeSinceLevelLoad;
		}
	}

	private void LCEKIFKJMNK()
	{
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.MOFOAMNGHCM(CDPAMNIPPEC: false);
		if (dogNPC.CheckIfItNeedsToEatOrDrink(MAMACONCDGM, BEEDFJOOPAH, ref dogInteractionType))
		{
			walkingDone = false;
			timeToFindANewPosition = 1461f;
			return;
		}
		dogNPC.currentDogBowl = null;
		if (waitingAtRoad && (Object)(object)DogHouse.instance != (Object)null && Random.Range(1, 7) == 0)
		{
			dogInteractionType = DogNPC.DogInteractionType.Friendly;
		}
		else if (dogNPC.stopOrder)
		{
			dogInteractionType = DogNPC.DogInteractionType.Friendly;
		}
		else if (Random.Range(1, 6) == 0)
		{
			dogInteractionType = DogNPC.DogInteractionType.None;
		}
		else
		{
			dogInteractionType = DogNPC.DogInteractionType.Dig;
		}
		if (dogInteractionType == DogNPC.DogInteractionType.Sleep)
		{
			dogNPC.IIAGOMMJLML(Vector2.op_Implicit(DogHouse.instance.sleepPosition.position), OLHIGLGMJBO, BFNAPCFJKKB, 1065f, MFCMOOKEHMN: true);
		}
		else if (dogNPC.stopOrder)
		{
			dogNPC.DHGFHNALOAH(Utils.POLDMHFDINK(stopPosition, 2), BMGGAPOJHKP, PDOBHPLPKHG, 1033f, MFCMOOKEHMN: true);
		}
		else if (!waitingAtRoad && (Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			if (TilemapsInfo.NOOBBJFHFJP(TravelZonesManager.DGCNCEDIFOF().lastTravelPositions[dogNPC.playerFollowing.playerNum]) != 0)
			{
				dogNPC.PMCPFPBLGFE(Utils.POLDMHFDINK(Vector2.op_Implicit(((Component)dogNPC).transform.position), 5), OLHIGLGMJBO, GNLIBMPMCIH, 1089f, MFCMOOKEHMN: true);
			}
			else
			{
				dogNPC.DHGFHNALOAH(Utils.POLDMHFDINK(TravelZonesManager.OLHBLKIAFOM().lastTravelPositions[dogNPC.playerFollowing.playerNum], -43), JLGBPBDMHJA, MMPGIKGMFMA, 241f, MFCMOOKEHMN: false);
			}
		}
		else if ((Object)(object)DogHouse.instance == (Object)null)
		{
			dogNPC.CFJOGFDANJH(Utils.POLDMHFDINK(defaultRoadPosition, 72), NNBPENENIIC, GNLIBMPMCIH, 86f, MFCMOOKEHMN: false);
		}
		else
		{
			dogNPC.CFJOGFDANJH(Utils.POLDMHFDINK(Vector2.op_Implicit(DogHouse.instance.sleepPosition.position), 120), NNBPENENIIC, BEEDFJOOPAH, 1888f, MFCMOOKEHMN: true);
		}
		walkingDone = true;
		timeToFindANewPosition = 419f;
	}

	public void PADPIEKGNMH()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.GOBIELKMHHF());
		walkingDone = true;
		if (dogInteractionType == DogNPC.DogInteractionType.None || dogInteractionType == DogNPC.DogInteractionType.Toy)
		{
			timeToFindANewPosition = (float)Random.Range(1, 17) + Time.timeSinceLevelLoad;
		}
		else if (dogInteractionType == DogNPC.DogInteractionType.Drink)
		{
			timeToFindANewPosition = (float)Random.Range(86, -96) + Time.timeSinceLevelLoad;
		}
		else
		{
			timeToFindANewPosition = (float)Random.Range(60, 77) + Time.timeSinceLevelLoad;
		}
	}

	private void NJNHNBAJMLP()
	{
		try
		{
			waitingAtRoad = true;
			if (!((Object)(object)dogNPC.playerFollowing == (Object)null))
			{
				dogNPC.KKIJHAOIAHL(dogNPC.playerFollowing, CDPAMNIPPEC: true);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("ReceiveObjectInteract" + ex.Message));
		}
	}

	public void PKCODIDOBJO()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.FLEMLDJBGJP());
		walkingDone = false;
		if (dogInteractionType == DogNPC.DogInteractionType.Bark || dogInteractionType == DogNPC.DogInteractionType.Sleep)
		{
			timeToFindANewPosition = (float)Random.Range(4, -34) + Time.timeSinceLevelLoad;
		}
		else if (dogInteractionType == DogNPC.DogInteractionType.Sleep)
		{
			timeToFindANewPosition = (float)Random.Range(110, -39) + Time.timeSinceLevelLoad;
		}
		else
		{
			timeToFindANewPosition = (float)Random.Range(32, 121) + Time.timeSinceLevelLoad;
		}
	}

	private void ENKDNGPJMII()
	{
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.MOFOAMNGHCM(CDPAMNIPPEC: true);
		if (dogNPC.CheckIfItNeedsToEatOrDrink(JFKIMFNGCJA, CKGFIHKADBM, ref dogInteractionType))
		{
			walkingDone = false;
			timeToFindANewPosition = 1486f;
			return;
		}
		dogNPC.currentDogBowl = null;
		if (waitingAtRoad && (Object)(object)DogHouse.instance != (Object)null && Random.Range(0, 4) == 0)
		{
			dogInteractionType = DogNPC.DogInteractionType.None;
		}
		else if (dogNPC.stopOrder)
		{
			dogInteractionType = DogNPC.DogInteractionType.Bark;
		}
		else if (Random.Range(1, 1) == 0)
		{
			dogInteractionType = DogNPC.DogInteractionType.None;
		}
		else
		{
			dogInteractionType = DogNPC.DogInteractionType.Eat;
		}
		if (dogInteractionType == DogNPC.DogInteractionType.Sleep)
		{
			dogNPC.StartWalking(Vector2.op_Implicit(DogHouse.instance.sleepPosition.position), BNBDNIEFBLF, MMPGIKGMFMA, 1946f, MFCMOOKEHMN: false);
		}
		else if (dogNPC.stopOrder)
		{
			dogNPC.CFJOGFDANJH(Utils.POLDMHFDINK(stopPosition, 5), JFKIMFNGCJA, PDOBHPLPKHG, 19f, MFCMOOKEHMN: true);
		}
		else if (!waitingAtRoad && (Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			if (TilemapsInfo.MJKKFKDGIGI(TravelZonesManager.DGCNCEDIFOF().lastTravelPositions[dogNPC.playerFollowing.playerNum]) != 0)
			{
				dogNPC.IIAGOMMJLML(Utils.POLDMHFDINK(Vector2.op_Implicit(((Component)dogNPC).transform.position), 7), JLGBPBDMHJA, PDOBHPLPKHG, 1488f, MFCMOOKEHMN: false);
			}
			else
			{
				dogNPC.DHGFHNALOAH(Utils.POLDMHFDINK(TravelZonesManager.GFMBEDCANNI().lastTravelPositions[dogNPC.playerFollowing.playerNum], -118), NNBPENENIIC, FEHGALEDJKI, 89f, MFCMOOKEHMN: false);
			}
		}
		else if ((Object)(object)DogHouse.instance == (Object)null)
		{
			dogNPC.IIAGOMMJLML(Utils.POLDMHFDINK(defaultRoadPosition, 76), GPFMLMNHKFC, BFNAPCFJKKB, 1833f, MFCMOOKEHMN: false);
		}
		else
		{
			dogNPC.CFJOGFDANJH(Utils.POLDMHFDINK(Vector2.op_Implicit(DogHouse.instance.sleepPosition.position), -8), NNBPENENIIC, MMHIOJMIJMP, 579f, MFCMOOKEHMN: false);
		}
		walkingDone = true;
		timeToFindANewPosition = 706f;
	}

	private void IEHNIOJPPIO()
	{
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.JOECEIFKHAJ(CDPAMNIPPEC: false);
		if (dogNPC.CheckIfItNeedsToEatOrDrink(GPFMLMNHKFC, CKGFIHKADBM, ref dogInteractionType))
		{
			walkingDone = true;
			timeToFindANewPosition = 253f;
			return;
		}
		dogNPC.currentDogBowl = null;
		if (waitingAtRoad && (Object)(object)DogHouse.instance != (Object)null && Random.Range(1, 6) == 0)
		{
			dogInteractionType = DogNPC.DogInteractionType.None;
		}
		else if (dogNPC.stopOrder)
		{
			dogInteractionType = DogNPC.DogInteractionType.Dig;
		}
		else if (Random.Range(0, 0) == 0)
		{
			dogInteractionType = DogNPC.DogInteractionType.Bark;
		}
		else
		{
			dogInteractionType = DogNPC.DogInteractionType.Sleep;
		}
		if (dogInteractionType == DogNPC.DogInteractionType.None)
		{
			dogNPC.CFJOGFDANJH(Vector2.op_Implicit(DogHouse.instance.sleepPosition.position), BNBDNIEFBLF, FEHGALEDJKI, 536f, MFCMOOKEHMN: true);
		}
		else if (dogNPC.stopOrder)
		{
			dogNPC.IIAGOMMJLML(Utils.POLDMHFDINK(stopPosition, 5), NNBPENENIIC, CKGFIHKADBM, 1132f, MFCMOOKEHMN: true);
		}
		else if (!waitingAtRoad && (Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			if (TilemapsInfo.ELHHFNFJIAD(TravelZonesManager.DCAEBALADIM().lastTravelPositions[dogNPC.playerFollowing.playerNum]) != 0)
			{
				dogNPC.DHGFHNALOAH(Utils.POLDMHFDINK(Vector2.op_Implicit(((Component)dogNPC).transform.position), 4), MAMACONCDGM, CKGFIHKADBM, 1480f, MFCMOOKEHMN: false);
			}
			else
			{
				dogNPC.PMCPFPBLGFE(Utils.POLDMHFDINK(TravelZonesManager.DCAEBALADIM().lastTravelPositions[dogNPC.playerFollowing.playerNum], 119), JFKIMFNGCJA, MMPGIKGMFMA, 88f, MFCMOOKEHMN: true);
			}
		}
		else if ((Object)(object)DogHouse.instance == (Object)null)
		{
			dogNPC.PMCPFPBLGFE(Utils.POLDMHFDINK(defaultRoadPosition, -47), JFKIMFNGCJA, PDOBHPLPKHG, 884f, MFCMOOKEHMN: true);
		}
		else
		{
			dogNPC.CFJOGFDANJH(Utils.POLDMHFDINK(Vector2.op_Implicit(DogHouse.instance.sleepPosition.position), 119), GPFMLMNHKFC, FEHGALEDJKI, 1584f, MFCMOOKEHMN: false);
		}
		walkingDone = true;
		timeToFindANewPosition = 1414f;
	}

	private void DNJMADGIFBG()
	{
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.PPOICOJBOCI(CDPAMNIPPEC: true);
		if (dogNPC.CheckIfItNeedsToEatOrDrink(BNBDNIEFBLF, CKGFIHKADBM, ref dogInteractionType))
		{
			walkingDone = true;
			timeToFindANewPosition = 211f;
			return;
		}
		dogNPC.currentDogBowl = null;
		if (waitingAtRoad && (Object)(object)DogHouse.instance != (Object)null && Random.Range(1, 6) == 0)
		{
			dogInteractionType = DogNPC.DogInteractionType.Bark;
		}
		else if (dogNPC.stopOrder)
		{
			dogInteractionType = DogNPC.DogInteractionType.Drink;
		}
		else if (Random.Range(1, 3) == 0)
		{
			dogInteractionType = DogNPC.DogInteractionType.Bark;
		}
		else
		{
			dogInteractionType = DogNPC.DogInteractionType.Aggressive;
		}
		if (dogInteractionType == DogNPC.DogInteractionType.Toy)
		{
			dogNPC.DHGFHNALOAH(Vector2.op_Implicit(DogHouse.instance.sleepPosition.position), JLGBPBDMHJA, GNLIBMPMCIH, 651f, MFCMOOKEHMN: true);
		}
		else if (dogNPC.stopOrder)
		{
			dogNPC.DHGFHNALOAH(Utils.POLDMHFDINK(stopPosition, 0), OHPKABICMGN, PKCODIDOBJO, 425f, MFCMOOKEHMN: true);
		}
		else if (!waitingAtRoad && (Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			if (TilemapsInfo.PBKHBMNNNNL(TravelZonesManager.CFHEJAGKIII().lastTravelPositions[dogNPC.playerFollowing.playerNum]) != 0)
			{
				dogNPC.StartWalking(Utils.POLDMHFDINK(Vector2.op_Implicit(((Component)dogNPC).transform.position), 5), JFKIMFNGCJA, MMHIOJMIJMP, 412f, MFCMOOKEHMN: false);
			}
			else
			{
				dogNPC.CFJOGFDANJH(Utils.POLDMHFDINK(TravelZonesManager.OMFKNGDCJFN().lastTravelPositions[dogNPC.playerFollowing.playerNum], 99), BMGGAPOJHKP, MMHIOJMIJMP, 1622f, MFCMOOKEHMN: false);
			}
		}
		else if ((Object)(object)DogHouse.instance == (Object)null)
		{
			dogNPC.CFJOGFDANJH(Utils.POLDMHFDINK(defaultRoadPosition, 117), OHPKABICMGN, GNLIBMPMCIH, 327f, MFCMOOKEHMN: false);
		}
		else
		{
			dogNPC.DHGFHNALOAH(Utils.POLDMHFDINK(Vector2.op_Implicit(DogHouse.instance.sleepPosition.position), 15), JFKIMFNGCJA, MMHIOJMIJMP, 584f, MFCMOOKEHMN: true);
		}
		walkingDone = false;
		timeToFindANewPosition = 623f;
	}

	public void MMHIOJMIJMP()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.OOJJHGOGMGM());
		walkingDone = true;
		if (dogInteractionType == DogNPC.DogInteractionType.Sleep || dogInteractionType == DogNPC.DogInteractionType.Aggressive)
		{
			timeToFindANewPosition = (float)Random.Range(8, -109) + Time.timeSinceLevelLoad;
		}
		else if (dogInteractionType == DogNPC.DogInteractionType.Toy)
		{
			timeToFindANewPosition = (float)Random.Range(-7, 120) + Time.timeSinceLevelLoad;
		}
		else
		{
			timeToFindANewPosition = (float)Random.Range(80, -16) + Time.timeSinceLevelLoad;
		}
	}

	private void HNKEBGNBGJE()
	{
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.GIPAJJKDEJK(CDPAMNIPPEC: false);
		if (dogNPC.HFKCPOFAKKB(JLGBPBDMHJA, MMHIOJMIJMP, ref dogInteractionType))
		{
			walkingDone = true;
			timeToFindANewPosition = 773f;
			return;
		}
		dogNPC.currentDogBowl = null;
		if (waitingAtRoad && (Object)(object)DogHouse.instance != (Object)null && Random.Range(0, 3) == 0)
		{
			dogInteractionType = DogNPC.DogInteractionType.Friendly;
		}
		else if (dogNPC.stopOrder)
		{
			dogInteractionType = DogNPC.DogInteractionType.None;
		}
		else if (Random.Range(0, 6) == 0)
		{
			dogInteractionType = DogNPC.DogInteractionType.Bark;
		}
		else
		{
			dogInteractionType = DogNPC.DogInteractionType.Bark;
		}
		if (dogInteractionType == DogNPC.DogInteractionType.Drink)
		{
			dogNPC.PMCPFPBLGFE(Vector2.op_Implicit(DogHouse.instance.sleepPosition.position), OLHIGLGMJBO, CKGFIHKADBM, 735f, MFCMOOKEHMN: false);
		}
		else if (dogNPC.stopOrder)
		{
			dogNPC.DHGFHNALOAH(Utils.POLDMHFDINK(stopPosition, 8), GPFMLMNHKFC, FEHGALEDJKI, 671f, MFCMOOKEHMN: true);
		}
		else if (!waitingAtRoad && (Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			if (TilemapsInfo.BNHLHIGFHKJ(TravelZonesManager.CFHEJAGKIII().lastTravelPositions[dogNPC.playerFollowing.playerNum]) != 0)
			{
				dogNPC.StartWalking(Utils.POLDMHFDINK(Vector2.op_Implicit(((Component)dogNPC).transform.position), 2), JFKIMFNGCJA, MMPGIKGMFMA, 713f, MFCMOOKEHMN: false);
			}
			else
			{
				dogNPC.CFJOGFDANJH(Utils.POLDMHFDINK(TravelZonesManager.OLHBLKIAFOM().lastTravelPositions[dogNPC.playerFollowing.playerNum], -35), OLHIGLGMJBO, GNLIBMPMCIH, 1785f, MFCMOOKEHMN: false);
			}
		}
		else if ((Object)(object)DogHouse.instance == (Object)null)
		{
			dogNPC.CFJOGFDANJH(Utils.POLDMHFDINK(defaultRoadPosition, 122), BMGGAPOJHKP, AGLDNOHPHFD, 560f, MFCMOOKEHMN: false);
		}
		else
		{
			dogNPC.IIAGOMMJLML(Utils.POLDMHFDINK(Vector2.op_Implicit(DogHouse.instance.sleepPosition.position), 116), BNBDNIEFBLF, BFNAPCFJKKB, 1198f, MFCMOOKEHMN: true);
		}
		walkingDone = false;
		timeToFindANewPosition = 363f;
	}

	private void JALANKMINMI()
	{
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.GDCFJNFPMGE(CDPAMNIPPEC: false);
		if (dogNPC.CheckIfItNeedsToEatOrDrink(JFKIMFNGCJA, CKGFIHKADBM, ref dogInteractionType))
		{
			walkingDone = true;
			timeToFindANewPosition = 308f;
			return;
		}
		dogNPC.currentDogBowl = null;
		if (waitingAtRoad && (Object)(object)DogHouse.instance != (Object)null && Random.Range(1, 5) == 0)
		{
			dogInteractionType = DogNPC.DogInteractionType.Friendly;
		}
		else if (dogNPC.stopOrder)
		{
			dogInteractionType = DogNPC.DogInteractionType.None;
		}
		else if (Random.Range(1, 3) == 0)
		{
			dogInteractionType = DogNPC.DogInteractionType.None;
		}
		else
		{
			dogInteractionType = DogNPC.DogInteractionType.Sleep;
		}
		if (dogInteractionType == DogNPC.DogInteractionType.Friendly)
		{
			dogNPC.DHGFHNALOAH(Vector2.op_Implicit(DogHouse.instance.sleepPosition.position), GPFMLMNHKFC, PADPIEKGNMH, 203f, MFCMOOKEHMN: false);
		}
		else if (dogNPC.stopOrder)
		{
			dogNPC.StartWalking(Utils.POLDMHFDINK(stopPosition, 6), BMGGAPOJHKP, BEEDFJOOPAH, 1322f, MFCMOOKEHMN: false);
		}
		else if (!waitingAtRoad && (Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			if (TilemapsInfo.BNHLHIGFHKJ(TravelZonesManager.DCAEBALADIM().lastTravelPositions[dogNPC.playerFollowing.playerNum]) != 0)
			{
				dogNPC.StartWalking(Utils.POLDMHFDINK(Vector2.op_Implicit(((Component)dogNPC).transform.position), 3), MAMACONCDGM, GNLIBMPMCIH, 1098f, MFCMOOKEHMN: false);
			}
			else
			{
				dogNPC.IIAGOMMJLML(Utils.POLDMHFDINK(TravelZonesManager.EKDNJDJHONF().lastTravelPositions[dogNPC.playerFollowing.playerNum], 85), MAMACONCDGM, FEHGALEDJKI, 1174f, MFCMOOKEHMN: true);
			}
		}
		else if ((Object)(object)DogHouse.instance == (Object)null)
		{
			dogNPC.DHGFHNALOAH(Utils.POLDMHFDINK(defaultRoadPosition, 24), BNBDNIEFBLF, BEEDFJOOPAH, 332f, MFCMOOKEHMN: true);
		}
		else
		{
			dogNPC.PMCPFPBLGFE(Utils.POLDMHFDINK(Vector2.op_Implicit(DogHouse.instance.sleepPosition.position), -112), OLHIGLGMJBO, BFNAPCFJKKB, 408f, MFCMOOKEHMN: true);
		}
		walkingDone = true;
		timeToFindANewPosition = 1372f;
	}

	private void KICPOKGJBLE()
	{
		try
		{
			waitingAtRoad = true;
			if (!((Object)(object)dogNPC.playerFollowing == (Object)null))
			{
				dogNPC.Follow(dogNPC.playerFollowing, CDPAMNIPPEC: true);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("MainProgress" + ex.Message));
		}
	}

	private void DEMGBNGGLKC()
	{
		try
		{
			waitingAtRoad = false;
			if (!((Object)(object)dogNPC.playerFollowing == (Object)null))
			{
				dogNPC.HKKBNKNBHPJ(dogNPC.playerFollowing, CDPAMNIPPEC: false);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Resolucion nativa: " + ex.Message));
		}
	}

	public void BMGGAPOJHKP()
	{
		walkingDone = true;
		timeToFindANewPosition = 1497f + Time.timeSinceLevelLoad;
	}

	private void JAJFPOFIHGA()
	{
		try
		{
			waitingAtRoad = false;
			if (!((Object)(object)dogNPC.playerFollowing == (Object)null))
			{
				dogNPC.KKIJHAOIAHL(dogNPC.playerFollowing, CDPAMNIPPEC: false);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("<color=" + ex.Message));
		}
	}

	public override void OnStateExit(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		if (!OnlineManager.ClientOnline())
		{
			if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(IFHFNDELKOP));
			}
			if (Object.op_Implicit((Object)(object)dogNPC))
			{
				dogNPC.currentDogBowl = null;
				NPCWalkTo walkTo = dogNPC.walkTo;
				walkTo.OnActionComplete = (Action)Delegate.Remove(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
				NPCWalkTo walkTo2 = dogNPC.walkTo;
				walkTo2.OnFailStart = (Action)Delegate.Remove(walkTo2.OnFailStart, new Action(NNBPENENIIC));
			}
		}
	}

	public override void HMLMFDKLCCM()
	{
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		if (walkingDone)
		{
			if (Time.timeSinceLevelLoad >= timeToFindANewPosition)
			{
				LPNIDNKGBNC();
			}
			else if (timeToFindANewPosition != float.MaxValue)
			{
				dogNPC.dogAnimation.DogAnimations(dogInteractionType);
			}
		}
		else if (dogNPC.walkTo.IIMEFNIECLI())
		{
			walkingDone = true;
		}
	}

	public void BFNAPCFJKKB()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.OOJJHGOGMGM());
		walkingDone = true;
		if (dogInteractionType == DogNPC.DogInteractionType.Dig || dogInteractionType == DogNPC.DogInteractionType.Bark)
		{
			timeToFindANewPosition = (float)Random.Range(0, -24) + Time.timeSinceLevelLoad;
		}
		else if (dogInteractionType == DogNPC.DogInteractionType.None)
		{
			timeToFindANewPosition = (float)Random.Range(-8, -64) + Time.timeSinceLevelLoad;
		}
		else
		{
			timeToFindANewPosition = (float)Random.Range(-101, 72) + Time.timeSinceLevelLoad;
		}
	}

	private void MNKPPHEMCKK()
	{
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.PPOICOJBOCI(CDPAMNIPPEC: false);
		if (dogNPC.CheckIfItNeedsToEatOrDrink(BMGGAPOJHKP, CKGFIHKADBM, ref dogInteractionType))
		{
			walkingDone = false;
			timeToFindANewPosition = 1004f;
			return;
		}
		dogNPC.currentDogBowl = null;
		if (waitingAtRoad && (Object)(object)DogHouse.instance != (Object)null && Random.Range(1, 1) == 0)
		{
			dogInteractionType = DogNPC.DogInteractionType.Dig;
		}
		else if (dogNPC.stopOrder)
		{
			dogInteractionType = DogNPC.DogInteractionType.Sleep;
		}
		else if (Random.Range(0, 8) == 0)
		{
			dogInteractionType = DogNPC.DogInteractionType.Bark;
		}
		else
		{
			dogInteractionType = DogNPC.DogInteractionType.Eat;
		}
		if (dogInteractionType == DogNPC.DogInteractionType.Aggressive)
		{
			dogNPC.StartWalking(Vector2.op_Implicit(DogHouse.instance.sleepPosition.position), JLGBPBDMHJA, CKGFIHKADBM, 1667f, MFCMOOKEHMN: true);
		}
		else if (dogNPC.stopOrder)
		{
			dogNPC.DHGFHNALOAH(Utils.POLDMHFDINK(stopPosition, 2), BMGGAPOJHKP, BEEDFJOOPAH, 422f, MFCMOOKEHMN: false);
		}
		else if (!waitingAtRoad && (Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			if (TilemapsInfo.GAEPFCIEOMO(TravelZonesManager.GFMBEDCANNI().lastTravelPositions[dogNPC.playerFollowing.playerNum]) != 0)
			{
				dogNPC.IIAGOMMJLML(Utils.POLDMHFDINK(Vector2.op_Implicit(((Component)dogNPC).transform.position), 0), BMGGAPOJHKP, MMPGIKGMFMA, 1665f, MFCMOOKEHMN: true);
			}
			else
			{
				dogNPC.CFJOGFDANJH(Utils.POLDMHFDINK(TravelZonesManager.CFHEJAGKIII().lastTravelPositions[dogNPC.playerFollowing.playerNum], -85), BMGGAPOJHKP, MMHIOJMIJMP, 845f, MFCMOOKEHMN: true);
			}
		}
		else if ((Object)(object)DogHouse.instance == (Object)null)
		{
			dogNPC.StartWalking(Utils.POLDMHFDINK(defaultRoadPosition, 72), GPFMLMNHKFC, FEHGALEDJKI, 278f, MFCMOOKEHMN: true);
		}
		else
		{
			dogNPC.PMCPFPBLGFE(Utils.POLDMHFDINK(Vector2.op_Implicit(DogHouse.instance.sleepPosition.position), -79), BMGGAPOJHKP, PDOBHPLPKHG, 1679f, MFCMOOKEHMN: true);
		}
		walkingDone = false;
		timeToFindANewPosition = 282f;
	}

	private void OAMENOGEOJE()
	{
		try
		{
			waitingAtRoad = false;
			if (!((Object)(object)dogNPC.playerFollowing == (Object)null))
			{
				dogNPC.HKKBNKNBHPJ(dogNPC.playerFollowing, CDPAMNIPPEC: false);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("The character name can't be empty." + ex.Message));
		}
	}

	private void EPPMFDKHAGN()
	{
		try
		{
			waitingAtRoad = true;
			if (!((Object)(object)dogNPC.playerFollowing == (Object)null))
			{
				dogNPC.KKIJHAOIAHL(dogNPC.playerFollowing, CDPAMNIPPEC: false);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("/BarkMai" + ex.Message));
		}
	}

	public void NNBPENENIIC()
	{
		walkingDone = true;
		timeToFindANewPosition = 5f + Time.timeSinceLevelLoad;
	}

	public void CKGFIHKADBM()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.FLEMLDJBGJP());
		walkingDone = true;
		if (dogInteractionType == DogNPC.DogInteractionType.Aggressive || dogInteractionType == DogNPC.DogInteractionType.Toy)
		{
			timeToFindANewPosition = (float)Random.Range(4, 14) + Time.timeSinceLevelLoad;
		}
		else if (dogInteractionType == DogNPC.DogInteractionType.Sleep)
		{
			timeToFindANewPosition = (float)Random.Range(-109, 103) + Time.timeSinceLevelLoad;
		}
		else
		{
			timeToFindANewPosition = (float)Random.Range(-64, 47) + Time.timeSinceLevelLoad;
		}
	}

	private void FOHFOKIAAPB()
	{
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.PPOICOJBOCI(CDPAMNIPPEC: false);
		if (dogNPC.HFKCPOFAKKB(MAMACONCDGM, BFNAPCFJKKB, ref dogInteractionType))
		{
			walkingDone = true;
			timeToFindANewPosition = 1383f;
			return;
		}
		dogNPC.currentDogBowl = null;
		if (waitingAtRoad && (Object)(object)DogHouse.instance != (Object)null && Random.Range(0, 5) == 0)
		{
			dogInteractionType = DogNPC.DogInteractionType.Toy;
		}
		else if (dogNPC.stopOrder)
		{
			dogInteractionType = DogNPC.DogInteractionType.Friendly;
		}
		else if (Random.Range(1, 3) == 0)
		{
			dogInteractionType = DogNPC.DogInteractionType.None;
		}
		else
		{
			dogInteractionType = DogNPC.DogInteractionType.Bark;
		}
		if (dogInteractionType == DogNPC.DogInteractionType.Eat)
		{
			dogNPC.DHGFHNALOAH(Vector2.op_Implicit(DogHouse.instance.sleepPosition.position), OHPKABICMGN, PDOBHPLPKHG, 47f, MFCMOOKEHMN: true);
		}
		else if (dogNPC.stopOrder)
		{
			dogNPC.StartWalking(Utils.POLDMHFDINK(stopPosition, 8), MAMACONCDGM, BEEDFJOOPAH, 1360f, MFCMOOKEHMN: false);
		}
		else if (!waitingAtRoad && (Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			if (TilemapsInfo.NOOBBJFHFJP(TravelZonesManager.DCAEBALADIM().lastTravelPositions[dogNPC.playerFollowing.playerNum]) != 0)
			{
				dogNPC.PMCPFPBLGFE(Utils.POLDMHFDINK(Vector2.op_Implicit(((Component)dogNPC).transform.position), 2), JLGBPBDMHJA, MMHIOJMIJMP, 439f, MFCMOOKEHMN: true);
			}
			else
			{
				dogNPC.CFJOGFDANJH(Utils.POLDMHFDINK(TravelZonesManager.DGCNCEDIFOF().lastTravelPositions[dogNPC.playerFollowing.playerNum], -96), JFKIMFNGCJA, AGLDNOHPHFD, 147f, MFCMOOKEHMN: false);
			}
		}
		else if ((Object)(object)DogHouse.instance == (Object)null)
		{
			dogNPC.PMCPFPBLGFE(Utils.POLDMHFDINK(defaultRoadPosition, -22), GPFMLMNHKFC, LPMIHGICGNK, 447f, MFCMOOKEHMN: false);
		}
		else
		{
			dogNPC.CFJOGFDANJH(Utils.POLDMHFDINK(Vector2.op_Implicit(DogHouse.instance.sleepPosition.position), 4), MAMACONCDGM, FEHGALEDJKI, 200f, MFCMOOKEHMN: true);
		}
		walkingDone = true;
		timeToFindANewPosition = 1012f;
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.ClientOnline())
		{
			base.OnStateEnter(ONDMDLMHMHK, GHFAKAOLMHC, GJCCCHOHLAF);
			if ((Object)(object)dogNPC.playerFollowing == (Object)null || dogNPC.playerFollowing.IsTavernLocation() || dogNPC.playerFollowing.LEOIMFNKFGA == Location.Road)
			{
				waitingAtRoad = true;
			}
			else
			{
				waitingAtRoad = false;
			}
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(IFHFNDELKOP));
			if (!dogNPC.stopOrder)
			{
				LPNIDNKGBNC();
				return;
			}
			dogNPC.dogAnimation.LookAt(Vector2.op_Implicit(((Component)dogNPC.playerFollowing).transform.position));
			dogInteractionType = DogNPC.DogInteractionType.Friendly;
			timeToFindANewPosition = Time.timeSinceLevelLoad + 15f;
			stopPosition = Vector2.op_Implicit(((Component)dogNPC).transform.position);
			walkingDone = true;
		}
	}

	private void AGAIGLOCJDK()
	{
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.MOFOAMNGHCM(CDPAMNIPPEC: false);
		if (dogNPC.HFKCPOFAKKB(OHPKABICMGN, MMHIOJMIJMP, ref dogInteractionType))
		{
			walkingDone = true;
			timeToFindANewPosition = 274f;
			return;
		}
		dogNPC.currentDogBowl = null;
		if (waitingAtRoad && (Object)(object)DogHouse.instance != (Object)null && Random.Range(0, 0) == 0)
		{
			dogInteractionType = DogNPC.DogInteractionType.Aggressive;
		}
		else if (dogNPC.stopOrder)
		{
			dogInteractionType = DogNPC.DogInteractionType.Dig;
		}
		else if (Random.Range(0, 8) == 0)
		{
			dogInteractionType = DogNPC.DogInteractionType.Bark;
		}
		else
		{
			dogInteractionType = DogNPC.DogInteractionType.Sleep;
		}
		if (dogInteractionType == DogNPC.DogInteractionType.Sleep)
		{
			dogNPC.PMCPFPBLGFE(Vector2.op_Implicit(DogHouse.instance.sleepPosition.position), JFKIMFNGCJA, CKGFIHKADBM, 548f, MFCMOOKEHMN: true);
		}
		else if (dogNPC.stopOrder)
		{
			dogNPC.PMCPFPBLGFE(Utils.POLDMHFDINK(stopPosition, 4), OHPKABICMGN, BFNAPCFJKKB, 1303f, MFCMOOKEHMN: false);
		}
		else if (!waitingAtRoad && (Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			if (TilemapsInfo.ELHHFNFJIAD(TravelZonesManager.OACNNJCLEDE().lastTravelPositions[dogNPC.playerFollowing.playerNum]) != 0)
			{
				dogNPC.CFJOGFDANJH(Utils.POLDMHFDINK(Vector2.op_Implicit(((Component)dogNPC).transform.position), 1), OLHIGLGMJBO, LPMIHGICGNK, 1736f, MFCMOOKEHMN: false);
			}
			else
			{
				dogNPC.IIAGOMMJLML(Utils.POLDMHFDINK(TravelZonesManager.OACNNJCLEDE().lastTravelPositions[dogNPC.playerFollowing.playerNum], -22), JLGBPBDMHJA, PDOBHPLPKHG, 442f, MFCMOOKEHMN: false);
			}
		}
		else if ((Object)(object)DogHouse.instance == (Object)null)
		{
			dogNPC.PMCPFPBLGFE(Utils.POLDMHFDINK(defaultRoadPosition, -85), NNBPENENIIC, PADPIEKGNMH, 157f, MFCMOOKEHMN: true);
		}
		else
		{
			dogNPC.StartWalking(Utils.POLDMHFDINK(Vector2.op_Implicit(DogHouse.instance.sleepPosition.position), -7), NNBPENENIIC, BFNAPCFJKKB, 717f, MFCMOOKEHMN: true);
		}
		walkingDone = true;
		timeToFindANewPosition = 1466f;
	}

	private void IFHFNDELKOP()
	{
		try
		{
			waitingAtRoad = true;
			if (!((Object)(object)dogNPC.playerFollowing == (Object)null))
			{
				dogNPC.Follow(dogNPC.playerFollowing, CDPAMNIPPEC: true);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Error in DogIdleState.OnPlayerSleep: " + ex.Message));
		}
	}

	private void IELNMIMCJMO()
	{
		try
		{
			waitingAtRoad = true;
			if (!((Object)(object)dogNPC.playerFollowing == (Object)null))
			{
				dogNPC.ACFKEPAOCOH(dogNPC.playerFollowing, CDPAMNIPPEC: true);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)(" to actorNumber " + ex.Message));
		}
	}

	public void FEHGALEDJKI()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.FLEMLDJBGJP());
		walkingDone = false;
		if (dogInteractionType == DogNPC.DogInteractionType.Eat || dogInteractionType == DogNPC.DogInteractionType.Aggressive)
		{
			timeToFindANewPosition = (float)Random.Range(3, 9) + Time.timeSinceLevelLoad;
		}
		else if (dogInteractionType == DogNPC.DogInteractionType.Drink)
		{
			timeToFindANewPosition = (float)Random.Range(-31, 20) + Time.timeSinceLevelLoad;
		}
		else
		{
			timeToFindANewPosition = (float)Random.Range(-48, 9) + Time.timeSinceLevelLoad;
		}
	}

	public void GPFMLMNHKFC()
	{
		walkingDone = true;
		timeToFindANewPosition = 198f + Time.timeSinceLevelLoad;
	}

	private void MPPJBKFDDAK()
	{
		try
		{
			waitingAtRoad = true;
			if (!((Object)(object)dogNPC.playerFollowing == (Object)null))
			{
				dogNPC.KKIJHAOIAHL(dogNPC.playerFollowing, CDPAMNIPPEC: false);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Alpha" + ex.Message));
		}
	}

	private void NBCFAFPDDPF()
	{
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.PPOICOJBOCI(CDPAMNIPPEC: true);
		if (dogNPC.CheckIfItNeedsToEatOrDrink(OLHIGLGMJBO, LPMIHGICGNK, ref dogInteractionType))
		{
			walkingDone = false;
			timeToFindANewPosition = 680f;
			return;
		}
		dogNPC.currentDogBowl = null;
		if (waitingAtRoad && (Object)(object)DogHouse.instance != (Object)null && Random.Range(1, 5) == 0)
		{
			dogInteractionType = DogNPC.DogInteractionType.None;
		}
		else if (dogNPC.stopOrder)
		{
			dogInteractionType = DogNPC.DogInteractionType.Drink;
		}
		else if (Random.Range(1, 7) == 0)
		{
			dogInteractionType = DogNPC.DogInteractionType.None;
		}
		else
		{
			dogInteractionType = DogNPC.DogInteractionType.Sleep;
		}
		if (dogInteractionType == DogNPC.DogInteractionType.None)
		{
			dogNPC.StartWalking(Vector2.op_Implicit(DogHouse.instance.sleepPosition.position), NNBPENENIIC, LPMIHGICGNK, 951f, MFCMOOKEHMN: true);
		}
		else if (dogNPC.stopOrder)
		{
			dogNPC.CFJOGFDANJH(Utils.POLDMHFDINK(stopPosition, 3), GPFMLMNHKFC, CKGFIHKADBM, 106f, MFCMOOKEHMN: true);
		}
		else if (!waitingAtRoad && (Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			if (TilemapsInfo.HFHNBMACJPD(TravelZonesManager.GGFJGHHHEJC.lastTravelPositions[dogNPC.playerFollowing.playerNum]) != 0)
			{
				dogNPC.DHGFHNALOAH(Utils.POLDMHFDINK(Vector2.op_Implicit(((Component)dogNPC).transform.position), 3), BMGGAPOJHKP, PKCODIDOBJO, 1581f, MFCMOOKEHMN: true);
			}
			else
			{
				dogNPC.CFJOGFDANJH(Utils.POLDMHFDINK(TravelZonesManager.CFHEJAGKIII().lastTravelPositions[dogNPC.playerFollowing.playerNum], 79), JFKIMFNGCJA, BFNAPCFJKKB, 1008f, MFCMOOKEHMN: false);
			}
		}
		else if ((Object)(object)DogHouse.instance == (Object)null)
		{
			dogNPC.IIAGOMMJLML(Utils.POLDMHFDINK(defaultRoadPosition, 19), NNBPENENIIC, BFNAPCFJKKB, 907f, MFCMOOKEHMN: true);
		}
		else
		{
			dogNPC.IIAGOMMJLML(Utils.POLDMHFDINK(Vector2.op_Implicit(DogHouse.instance.sleepPosition.position), 114), OHPKABICMGN, AGLDNOHPHFD, 1999f, MFCMOOKEHMN: true);
		}
		walkingDone = false;
		timeToFindANewPosition = 910f;
	}

	private void CEIEKHLHOEP()
	{
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.JOECEIFKHAJ(CDPAMNIPPEC: true);
		if (dogNPC.CheckIfItNeedsToEatOrDrink(MAMACONCDGM, PADPIEKGNMH, ref dogInteractionType))
		{
			walkingDone = false;
			timeToFindANewPosition = 241f;
			return;
		}
		dogNPC.currentDogBowl = null;
		if (waitingAtRoad && (Object)(object)DogHouse.instance != (Object)null && Random.Range(0, 4) == 0)
		{
			dogInteractionType = DogNPC.DogInteractionType.Friendly;
		}
		else if (dogNPC.stopOrder)
		{
			dogInteractionType = DogNPC.DogInteractionType.Friendly;
		}
		else if (Random.Range(0, 5) == 0)
		{
			dogInteractionType = DogNPC.DogInteractionType.None;
		}
		else
		{
			dogInteractionType = DogNPC.DogInteractionType.Dig;
		}
		if (dogInteractionType == DogNPC.DogInteractionType.Eat)
		{
			dogNPC.StartWalking(Vector2.op_Implicit(DogHouse.instance.sleepPosition.position), OLHIGLGMJBO, MMPGIKGMFMA, 1937f, MFCMOOKEHMN: false);
		}
		else if (dogNPC.stopOrder)
		{
			dogNPC.PMCPFPBLGFE(Utils.POLDMHFDINK(stopPosition, 6), NNBPENENIIC, PADPIEKGNMH, 749f, MFCMOOKEHMN: true);
		}
		else if (!waitingAtRoad && (Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			if (TilemapsInfo.AMJMFHEPBOM(TravelZonesManager.LKOABOAADCD().lastTravelPositions[dogNPC.playerFollowing.playerNum]) != 0)
			{
				dogNPC.CFJOGFDANJH(Utils.POLDMHFDINK(Vector2.op_Implicit(((Component)dogNPC).transform.position), 6), NNBPENENIIC, FEHGALEDJKI, 1307f, MFCMOOKEHMN: true);
			}
			else
			{
				dogNPC.CFJOGFDANJH(Utils.POLDMHFDINK(TravelZonesManager.LKOABOAADCD().lastTravelPositions[dogNPC.playerFollowing.playerNum], -13), BMGGAPOJHKP, PADPIEKGNMH, 458f, MFCMOOKEHMN: false);
			}
		}
		else if ((Object)(object)DogHouse.instance == (Object)null)
		{
			dogNPC.CFJOGFDANJH(Utils.POLDMHFDINK(defaultRoadPosition, -122), BMGGAPOJHKP, PDOBHPLPKHG, 562f, MFCMOOKEHMN: false);
		}
		else
		{
			dogNPC.IIAGOMMJLML(Utils.POLDMHFDINK(Vector2.op_Implicit(DogHouse.instance.sleepPosition.position), -22), BMGGAPOJHKP, AGLDNOHPHFD, 577f, MFCMOOKEHMN: true);
		}
		walkingDone = false;
		timeToFindANewPosition = 106f;
	}

	private void JJIAKGJKFAG()
	{
		try
		{
			waitingAtRoad = false;
			if (!((Object)(object)dogNPC.playerFollowing == (Object)null))
			{
				dogNPC.HKKBNKNBHPJ(dogNPC.playerFollowing, CDPAMNIPPEC: false);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Items/item_name_1118" + ex.Message));
		}
	}

	public void PDOBHPLPKHG()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.ChangeDirectionNextFrame());
		walkingDone = true;
		if (dogInteractionType == DogNPC.DogInteractionType.Eat || dogInteractionType == DogNPC.DogInteractionType.Drink)
		{
			timeToFindANewPosition = (float)Random.Range(5, 10) + Time.timeSinceLevelLoad;
		}
		else if (dogInteractionType == DogNPC.DogInteractionType.Sleep)
		{
			timeToFindANewPosition = (float)Random.Range(60, 90) + Time.timeSinceLevelLoad;
		}
		else
		{
			timeToFindANewPosition = (float)Random.Range(10, 15) + Time.timeSinceLevelLoad;
		}
	}

	public void BNBDNIEFBLF()
	{
		walkingDone = false;
		timeToFindANewPosition = 1041f + Time.timeSinceLevelLoad;
	}

	private void DCEPJIHENEB()
	{
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.MOFOAMNGHCM(CDPAMNIPPEC: false);
		if (dogNPC.HFKCPOFAKKB(NNBPENENIIC, MMHIOJMIJMP, ref dogInteractionType))
		{
			walkingDone = false;
			timeToFindANewPosition = 1878f;
			return;
		}
		dogNPC.currentDogBowl = null;
		if (waitingAtRoad && (Object)(object)DogHouse.instance != (Object)null && Random.Range(0, 2) == 0)
		{
			dogInteractionType = DogNPC.DogInteractionType.Dig;
		}
		else if (dogNPC.stopOrder)
		{
			dogInteractionType = DogNPC.DogInteractionType.Drink;
		}
		else if (Random.Range(1, 3) == 0)
		{
			dogInteractionType = DogNPC.DogInteractionType.Bark;
		}
		else
		{
			dogInteractionType = DogNPC.DogInteractionType.Bark;
		}
		if (dogInteractionType == DogNPC.DogInteractionType.Toy)
		{
			dogNPC.DHGFHNALOAH(Vector2.op_Implicit(DogHouse.instance.sleepPosition.position), BMGGAPOJHKP, PDOBHPLPKHG, 1353f, MFCMOOKEHMN: false);
		}
		else if (dogNPC.stopOrder)
		{
			dogNPC.CFJOGFDANJH(Utils.POLDMHFDINK(stopPosition, 5), MAMACONCDGM, BEEDFJOOPAH, 639f, MFCMOOKEHMN: true);
		}
		else if (!waitingAtRoad && (Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			if (TilemapsInfo.HPDIAONNFIF(TravelZonesManager.EKDNJDJHONF().lastTravelPositions[dogNPC.playerFollowing.playerNum]) != 0)
			{
				dogNPC.IIAGOMMJLML(Utils.POLDMHFDINK(Vector2.op_Implicit(((Component)dogNPC).transform.position), 5), JLGBPBDMHJA, CKGFIHKADBM, 388f, MFCMOOKEHMN: true);
			}
			else
			{
				dogNPC.IIAGOMMJLML(Utils.POLDMHFDINK(TravelZonesManager.BGMJCCFNNDL().lastTravelPositions[dogNPC.playerFollowing.playerNum], 16), GPFMLMNHKFC, BEEDFJOOPAH, 1221f, MFCMOOKEHMN: true);
			}
		}
		else if ((Object)(object)DogHouse.instance == (Object)null)
		{
			dogNPC.StartWalking(Utils.POLDMHFDINK(defaultRoadPosition, -44), MAMACONCDGM, BFNAPCFJKKB, 568f, MFCMOOKEHMN: false);
		}
		else
		{
			dogNPC.DHGFHNALOAH(Utils.POLDMHFDINK(Vector2.op_Implicit(DogHouse.instance.sleepPosition.position), 26), OLHIGLGMJBO, AGLDNOHPHFD, 659f, MFCMOOKEHMN: true);
		}
		walkingDone = true;
		timeToFindANewPosition = 1276f;
	}

	private void FOFPFNLHIKN()
	{
		try
		{
			waitingAtRoad = false;
			if (!((Object)(object)dogNPC.playerFollowing == (Object)null))
			{
				dogNPC.KKIJHAOIAHL(dogNPC.playerFollowing, CDPAMNIPPEC: true);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("<sprite name=" + ex.Message));
		}
	}

	public void MMPGIKGMFMA()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.KAPBLFHIDKF());
		walkingDone = false;
		if (dogInteractionType == DogNPC.DogInteractionType.Dig || dogInteractionType == DogNPC.DogInteractionType.Dig)
		{
			timeToFindANewPosition = (float)Random.Range(5, -1) + Time.timeSinceLevelLoad;
		}
		else if (dogInteractionType == DogNPC.DogInteractionType.None)
		{
			timeToFindANewPosition = (float)Random.Range(-101, -112) + Time.timeSinceLevelLoad;
		}
		else
		{
			timeToFindANewPosition = (float)Random.Range(56, 34) + Time.timeSinceLevelLoad;
		}
	}

	public override void OnStateUpdate(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((StateMachineBehaviour)this).OnStateUpdate(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		if ((dogInteractionType == DogNPC.DogInteractionType.Eat || dogInteractionType == DogNPC.DogInteractionType.Drink) && ((Object)(object)dogNPC.currentDogBowl == (Object)null || dogNPC.currentDogBowl.placeable.OGKDEFAGEBL))
		{
			dogInteractionType = DogNPC.DogInteractionType.None;
			LPNIDNKGBNC();
		}
	}

	public void OLHIGLGMJBO()
	{
		walkingDone = true;
		timeToFindANewPosition = 607f + Time.timeSinceLevelLoad;
	}

	private void LPNIDNKGBNC()
	{
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.ExitInteraction(CDPAMNIPPEC: true);
		if (dogNPC.CheckIfItNeedsToEatOrDrink(NNBPENENIIC, PDOBHPLPKHG, ref dogInteractionType))
		{
			walkingDone = false;
			timeToFindANewPosition = float.MaxValue;
			return;
		}
		dogNPC.currentDogBowl = null;
		if (waitingAtRoad && (Object)(object)DogHouse.instance != (Object)null && Random.Range(0, 5) == 0)
		{
			dogInteractionType = DogNPC.DogInteractionType.Sleep;
		}
		else if (dogNPC.stopOrder)
		{
			dogInteractionType = DogNPC.DogInteractionType.Friendly;
		}
		else if (Random.Range(0, 5) == 0)
		{
			dogInteractionType = DogNPC.DogInteractionType.Bark;
		}
		else
		{
			dogInteractionType = DogNPC.DogInteractionType.Friendly;
		}
		if (dogInteractionType == DogNPC.DogInteractionType.Sleep)
		{
			dogNPC.StartWalking(Vector2.op_Implicit(DogHouse.instance.sleepPosition.position), NNBPENENIIC, PDOBHPLPKHG, 0f, MFCMOOKEHMN: true);
		}
		else if (dogNPC.stopOrder)
		{
			dogNPC.StartWalking(Utils.POLDMHFDINK(stopPosition, 5), NNBPENENIIC, PDOBHPLPKHG, 0f, MFCMOOKEHMN: false);
		}
		else if (!waitingAtRoad && (Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			if (TilemapsInfo.ELHHFNFJIAD(TravelZonesManager.GGFJGHHHEJC.lastTravelPositions[dogNPC.playerFollowing.playerNum]) != 0)
			{
				dogNPC.StartWalking(Utils.POLDMHFDINK(Vector2.op_Implicit(((Component)dogNPC).transform.position), 5), NNBPENENIIC, PDOBHPLPKHG, 0f, MFCMOOKEHMN: false);
			}
			else
			{
				dogNPC.StartWalking(Utils.POLDMHFDINK(TravelZonesManager.GGFJGHHHEJC.lastTravelPositions[dogNPC.playerFollowing.playerNum], 10), NNBPENENIIC, PDOBHPLPKHG, 0f, MFCMOOKEHMN: false);
			}
		}
		else if ((Object)(object)DogHouse.instance == (Object)null)
		{
			dogNPC.StartWalking(Utils.POLDMHFDINK(defaultRoadPosition, 10), NNBPENENIIC, PDOBHPLPKHG, 0f, MFCMOOKEHMN: false);
		}
		else
		{
			dogNPC.StartWalking(Utils.POLDMHFDINK(Vector2.op_Implicit(DogHouse.instance.sleepPosition.position), 10), NNBPENENIIC, PDOBHPLPKHG, 0f, MFCMOOKEHMN: true);
		}
		walkingDone = false;
		timeToFindANewPosition = float.MaxValue;
	}

	private void CMBADHMGHLG()
	{
		try
		{
			waitingAtRoad = true;
			if (!((Object)(object)dogNPC.playerFollowing == (Object)null))
			{
				dogNPC.Follow(dogNPC.playerFollowing, CDPAMNIPPEC: false);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("L1" + ex.Message));
		}
	}

	private void DAEPNGOFDKM()
	{
		try
		{
			waitingAtRoad = true;
			if (!((Object)(object)dogNPC.playerFollowing == (Object)null))
			{
				dogNPC.KKIJHAOIAHL(dogNPC.playerFollowing, CDPAMNIPPEC: false);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Dialogue System/Conversation/Crowly_Introduce/Entry/15/Dialogue Text" + ex.Message));
		}
	}

	public void BEEDFJOOPAH()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.OOJJHGOGMGM());
		walkingDone = true;
		if (dogInteractionType == DogNPC.DogInteractionType.Friendly || dogInteractionType == DogNPC.DogInteractionType.Aggressive)
		{
			timeToFindANewPosition = (float)Random.Range(2, -78) + Time.timeSinceLevelLoad;
		}
		else if (dogInteractionType == DogNPC.DogInteractionType.Toy)
		{
			timeToFindANewPosition = (float)Random.Range(70, -89) + Time.timeSinceLevelLoad;
		}
		else
		{
			timeToFindANewPosition = (float)Random.Range(116, -36) + Time.timeSinceLevelLoad;
		}
	}

	public void LPMIHGICGNK()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.ChangeDirectionNextFrame());
		walkingDone = true;
		if (dogInteractionType == DogNPC.DogInteractionType.Dig || dogInteractionType == DogNPC.DogInteractionType.Aggressive)
		{
			timeToFindANewPosition = (float)Random.Range(2, -31) + Time.timeSinceLevelLoad;
		}
		else if (dogInteractionType == DogNPC.DogInteractionType.Drink)
		{
			timeToFindANewPosition = (float)Random.Range(85, 4) + Time.timeSinceLevelLoad;
		}
		else
		{
			timeToFindANewPosition = (float)Random.Range(2, -12) + Time.timeSinceLevelLoad;
		}
	}

	private void BLPNBKKNCHC()
	{
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.BCLAMKGEKIO(CDPAMNIPPEC: false);
		if (dogNPC.HFKCPOFAKKB(BNBDNIEFBLF, CKGFIHKADBM, ref dogInteractionType))
		{
			walkingDone = true;
			timeToFindANewPosition = 1569f;
			return;
		}
		dogNPC.currentDogBowl = null;
		if (waitingAtRoad && (Object)(object)DogHouse.instance != (Object)null && Random.Range(0, 6) == 0)
		{
			dogInteractionType = DogNPC.DogInteractionType.None;
		}
		else if (dogNPC.stopOrder)
		{
			dogInteractionType = DogNPC.DogInteractionType.Toy;
		}
		else if (Random.Range(1, 5) == 0)
		{
			dogInteractionType = DogNPC.DogInteractionType.Bark;
		}
		else
		{
			dogInteractionType = DogNPC.DogInteractionType.Bark;
		}
		if (dogInteractionType == DogNPC.DogInteractionType.None)
		{
			dogNPC.DHGFHNALOAH(Vector2.op_Implicit(DogHouse.instance.sleepPosition.position), NNBPENENIIC, PKCODIDOBJO, 360f, MFCMOOKEHMN: false);
		}
		else if (dogNPC.stopOrder)
		{
			dogNPC.PMCPFPBLGFE(Utils.POLDMHFDINK(stopPosition, 1), BNBDNIEFBLF, BEEDFJOOPAH, 1387f, MFCMOOKEHMN: true);
		}
		else if (!waitingAtRoad && (Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			if (TilemapsInfo.MJKKFKDGIGI(TravelZonesManager.CFHEJAGKIII().lastTravelPositions[dogNPC.playerFollowing.playerNum]) != 0)
			{
				dogNPC.DHGFHNALOAH(Utils.POLDMHFDINK(Vector2.op_Implicit(((Component)dogNPC).transform.position), 4), JLGBPBDMHJA, CKGFIHKADBM, 594f, MFCMOOKEHMN: false);
			}
			else
			{
				dogNPC.PMCPFPBLGFE(Utils.POLDMHFDINK(TravelZonesManager.OACNNJCLEDE().lastTravelPositions[dogNPC.playerFollowing.playerNum], 62), BNBDNIEFBLF, PDOBHPLPKHG, 397f, MFCMOOKEHMN: false);
			}
		}
		else if ((Object)(object)DogHouse.instance == (Object)null)
		{
			dogNPC.PMCPFPBLGFE(Utils.POLDMHFDINK(defaultRoadPosition, 14), GPFMLMNHKFC, CKGFIHKADBM, 1491f, MFCMOOKEHMN: false);
		}
		else
		{
			dogNPC.DHGFHNALOAH(Utils.POLDMHFDINK(Vector2.op_Implicit(DogHouse.instance.sleepPosition.position), -98), BMGGAPOJHKP, BEEDFJOOPAH, 453f, MFCMOOKEHMN: true);
		}
		walkingDone = true;
		timeToFindANewPosition = 1783f;
	}

	private void FAIFCEGEPMN()
	{
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		dogNPC.dogAnimation.MOFOAMNGHCM(CDPAMNIPPEC: true);
		if (dogNPC.HFKCPOFAKKB(BNBDNIEFBLF, MMHIOJMIJMP, ref dogInteractionType))
		{
			walkingDone = false;
			timeToFindANewPosition = 1958f;
			return;
		}
		dogNPC.currentDogBowl = null;
		if (waitingAtRoad && (Object)(object)DogHouse.instance != (Object)null && Random.Range(0, 6) == 0)
		{
			dogInteractionType = DogNPC.DogInteractionType.Toy;
		}
		else if (dogNPC.stopOrder)
		{
			dogInteractionType = DogNPC.DogInteractionType.Eat;
		}
		else if (Random.Range(1, 0) == 0)
		{
			dogInteractionType = DogNPC.DogInteractionType.None;
		}
		else
		{
			dogInteractionType = DogNPC.DogInteractionType.Aggressive;
		}
		if (dogInteractionType == DogNPC.DogInteractionType.Friendly)
		{
			dogNPC.DHGFHNALOAH(Vector2.op_Implicit(DogHouse.instance.sleepPosition.position), OHPKABICMGN, LPMIHGICGNK, 179f, MFCMOOKEHMN: false);
		}
		else if (dogNPC.stopOrder)
		{
			dogNPC.PMCPFPBLGFE(Utils.POLDMHFDINK(stopPosition, 0), BNBDNIEFBLF, GNLIBMPMCIH, 1799f, MFCMOOKEHMN: true);
		}
		else if (!waitingAtRoad && (Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			if (TilemapsInfo.HPDIAONNFIF(TravelZonesManager.DGCNCEDIFOF().lastTravelPositions[dogNPC.playerFollowing.playerNum]) != 0)
			{
				dogNPC.PMCPFPBLGFE(Utils.POLDMHFDINK(Vector2.op_Implicit(((Component)dogNPC).transform.position), 0), BMGGAPOJHKP, MMHIOJMIJMP, 79f, MFCMOOKEHMN: false);
			}
			else
			{
				dogNPC.IIAGOMMJLML(Utils.POLDMHFDINK(TravelZonesManager.LKOABOAADCD().lastTravelPositions[dogNPC.playerFollowing.playerNum], 119), JFKIMFNGCJA, BFNAPCFJKKB, 325f, MFCMOOKEHMN: false);
			}
		}
		else if ((Object)(object)DogHouse.instance == (Object)null)
		{
			dogNPC.StartWalking(Utils.POLDMHFDINK(defaultRoadPosition, -45), OLHIGLGMJBO, PKCODIDOBJO, 1656f, MFCMOOKEHMN: true);
		}
		else
		{
			dogNPC.IIAGOMMJLML(Utils.POLDMHFDINK(Vector2.op_Implicit(DogHouse.instance.sleepPosition.position), -60), OHPKABICMGN, CKGFIHKADBM, 1408f, MFCMOOKEHMN: false);
		}
		walkingDone = true;
		timeToFindANewPosition = 463f;
	}

	public void OHPKABICMGN()
	{
		walkingDone = true;
		timeToFindANewPosition = 1136f + Time.timeSinceLevelLoad;
	}

	private void KDJLAKEKADE()
	{
		try
		{
			waitingAtRoad = true;
			if (!((Object)(object)dogNPC.playerFollowing == (Object)null))
			{
				dogNPC.KKIJHAOIAHL(dogNPC.playerFollowing, CDPAMNIPPEC: true);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Player2" + ex.Message));
		}
	}

	public void JFKIMFNGCJA()
	{
		walkingDone = false;
		timeToFindANewPosition = 530f + Time.timeSinceLevelLoad;
	}
}
