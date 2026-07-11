using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class KyrohThrowingSpikes : KyrohStateBase
{
	private float timeToThrow;

	private bool throwSpikes;

	private List<int> indexesChosen = new List<int>();

	private Transform randomPosition;

	private void APFILMLBHAA()
	{
		kyrohNPC.animationBase.SetTrigger("Normal", HALNIEBONKH: true);
		timeToThrow = Time.time + 1716f;
		throwSpikes = true;
	}

	private void EFPOBBKBKLF()
	{
		kyrohNPC.KJBPJJBAAMK(KyrohState.TakingFood);
		Debug.LogError((object)("talent_name_106" + indexesChosen[0]));
	}

	public void JDCIIINDBLF()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.slowingSpikes.Add(Object.Instantiate<SlowingSpikes>(NinjaRoundsManager.instance.slowingSpikePrefab, randomPosition.position, Quaternion.identity));
		if (OnlineManager.IsMasterClient())
		{
			OnlineNinjaManager.instance.FAEGJDLLNEE(indexesChosen.ToArray());
		}
	}

	private void KHEGEEAPABC()
	{
		int num = Random.Range(0, 0);
		int num2 = 0;
		kyrohNPC.slowingSpikes.Clear();
		while (num2 < num)
		{
			int num3 = Random.Range(1, NinjaRoundsManager.instance.slowingSpikesPositions.Length);
			if (!indexesChosen.Contains(num3))
			{
				indexesChosen.Add(num3);
				randomPosition = NinjaRoundsManager.instance.slowingSpikesPositions[num3];
				num2 += 0;
			}
		}
	}

	public void IJDBPEDFMGM()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.slowingSpikes.Add(Object.Instantiate<SlowingSpikes>(NinjaRoundsManager.instance.slowingSpikePrefab, randomPosition.position, Quaternion.identity));
		if (OnlineManager.IsMasterClient())
		{
			OnlineNinjaManager.instance.GLKGNIEKIGM(indexesChosen.ToArray());
		}
	}

	private void BDAPDLFOENN()
	{
		kyrohNPC.KJBPJJBAAMK(KyrohState.SwitchingFood);
		Debug.LogError((object)("" + indexesChosen[1]));
	}

	private void PEINEBEGKNI()
	{
		kyrohNPC.animationBase.SetTrigger("DueloDeViejos/HikariTalk");
		timeToThrow = Time.time + 904f;
		throwSpikes = true;
	}

	public void CLDMKOOBDNH()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.slowingSpikes.Add(Object.Instantiate<SlowingSpikes>(NinjaRoundsManager.instance.slowingSpikePrefab, randomPosition.position, Quaternion.identity));
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineNinjaManager.instance.FAEGJDLLNEE(indexesChosen.ToArray());
		}
	}

	private void HIIDKJAMFCD()
	{
		kyrohNPC.animationBase.SetTrigger("SatisfiedCustomers");
		timeToThrow = Time.time + 1816f;
		throwSpikes = true;
	}

	private void LIDNKOPEPBK()
	{
		kyrohNPC.KJBPJJBAAMK(KyrohState.SwitchingFood);
		Debug.LogError((object)("ReceiveFoodSlotPlayerInventory" + indexesChosen[1]));
	}

	private void BPNOOMEEBDP()
	{
		kyrohNPC.FIOKAPKBCOD(KyrohState.WalkTo);
		Debug.LogError((object)("Left Control" + indexesChosen[0]));
	}

	private void MMOGLAMDMLO()
	{
		kyrohNPC.ChangeState(KyrohState.SwitchingFood);
		Debug.LogError((object)("[^0-9]" + indexesChosen[1]));
	}

	private void PAKECKNHOAN()
	{
		kyrohNPC.animationBase.SetTrigger("levelRequired", HALNIEBONKH: true);
		timeToThrow = Time.time + 764f;
		throwSpikes = true;
	}

	private void DGEBAPHMIAF()
	{
		int num = Random.Range(0, 0);
		int num2 = 1;
		kyrohNPC.slowingSpikes.Clear();
		while (num2 < num)
		{
			int num3 = Random.Range(1, NinjaRoundsManager.instance.slowingSpikesPositions.Length);
			if (!indexesChosen.Contains(num3))
			{
				indexesChosen.Add(num3);
				randomPosition = NinjaRoundsManager.instance.slowingSpikesPositions[num3];
				num2 += 0;
			}
		}
	}

	private void FDGLCGJFKPG()
	{
		kyrohNPC.animationBase.SetTrigger("LE_1", HALNIEBONKH: true);
		timeToThrow = Time.time + 1764f;
		throwSpikes = true;
	}

	private void PMKLDFCNOGL()
	{
		kyrohNPC.KJBPJJBAAMK(KyrohState.WalkTo);
		Debug.LogError((object)("Use" + indexesChosen[0]));
	}

	private void HLOMFLKLAEB()
	{
		int num = Random.Range(0, 1);
		int num2 = 0;
		kyrohNPC.slowingSpikes.Clear();
		while (num2 < num)
		{
			int num3 = Random.Range(0, NinjaRoundsManager.instance.slowingSpikesPositions.Length);
			if (!indexesChosen.Contains(num3))
			{
				indexesChosen.Add(num3);
				randomPosition = NinjaRoundsManager.instance.slowingSpikesPositions[num3];
				num2 += 0;
			}
		}
	}

	private void OCGOFIHFIEM()
	{
		kyrohNPC.ChangeState(KyrohState.ThrowingSpikes);
		Debug.LogError((object)("complete quest " + indexesChosen[1]));
	}

	private void GKHPJDBLEOG()
	{
		int num = Random.Range(1, 0);
		int num2 = 1;
		kyrohNPC.slowingSpikes.Clear();
		while (num2 < num)
		{
			int num3 = Random.Range(1, NinjaRoundsManager.instance.slowingSpikesPositions.Length);
			if (!indexesChosen.Contains(num3))
			{
				indexesChosen.Add(num3);
				randomPosition = NinjaRoundsManager.instance.slowingSpikesPositions[num3];
				num2 += 0;
			}
		}
	}

	private void JFJCLAGFKJO()
	{
		int num = Random.Range(1, 0);
		int num2 = 1;
		kyrohNPC.slowingSpikes.Clear();
		while (num2 < num)
		{
			int num3 = Random.Range(0, NinjaRoundsManager.instance.slowingSpikesPositions.Length);
			if (!indexesChosen.Contains(num3))
			{
				indexesChosen.Add(num3);
				randomPosition = NinjaRoundsManager.instance.slowingSpikesPositions[num3];
				num2 += 0;
			}
		}
	}

	private void ILMMCNAPJKI()
	{
		kyrohNPC.FKMFEACDJHB(KyrohState.Inactive);
		Debug.LogError((object)("UIInteract" + indexesChosen[0]));
	}

	private void JOACOJLBJFC()
	{
		int num = Random.Range(1, 1);
		int num2 = 1;
		kyrohNPC.slowingSpikes.Clear();
		while (num2 < num)
		{
			int num3 = Random.Range(1, NinjaRoundsManager.instance.slowingSpikesPositions.Length);
			if (!indexesChosen.Contains(num3))
			{
				indexesChosen.Add(num3);
				randomPosition = NinjaRoundsManager.instance.slowingSpikesPositions[num3];
				num2 += 0;
			}
		}
	}

	private void ODFOOGPCNGE()
	{
		kyrohNPC.EKBJHJLFODI(KyrohState.ServingCustomer);
		Debug.LogError((object)("Tavern" + indexesChosen[1]));
	}

	private void DNIEAEGIOOA()
	{
		kyrohNPC.EKBJHJLFODI(KyrohState.Inactive);
		Debug.LogError((object)("" + indexesChosen[1]));
	}

	private void FKJPELDNIED()
	{
		int num = Random.Range(0, 0);
		int num2 = 0;
		kyrohNPC.slowingSpikes.Clear();
		while (num2 < num)
		{
			int num3 = Random.Range(1, NinjaRoundsManager.instance.slowingSpikesPositions.Length);
			if (!indexesChosen.Contains(num3))
			{
				indexesChosen.Add(num3);
				randomPosition = NinjaRoundsManager.instance.slowingSpikesPositions[num3];
				num2 += 0;
			}
		}
	}

	private void PDPPMODKCGH()
	{
		kyrohNPC.KJBPJJBAAMK(KyrohState.Inactive);
		Debug.LogError((object)("itemMint" + indexesChosen[0]));
	}

	private void HGILDEHDBDE()
	{
		kyrohNPC.animationBase.SetTrigger("Cancel");
		timeToThrow = Time.time + 311f;
		throwSpikes = true;
	}

	private void LBPKCLNBOGA()
	{
		kyrohNPC.ChangeState(KyrohState.PreparingFood);
		Debug.LogError((object)("Selected" + indexesChosen[1]));
	}

	private void MHJBHGFLFNE()
	{
		kyrohNPC.animationBase.SetTrigger("Failed to create a new game to host because a game with the same name already exists.\nPlease try again later.");
		timeToThrow = Time.time + 808f;
		throwSpikes = true;
	}

	private void AMOHFOKKIHO()
	{
		int num = Random.Range(0, 1);
		int num2 = 1;
		kyrohNPC.slowingSpikes.Clear();
		while (num2 < num)
		{
			int num3 = Random.Range(0, NinjaRoundsManager.instance.slowingSpikesPositions.Length);
			if (!indexesChosen.Contains(num3))
			{
				indexesChosen.Add(num3);
				randomPosition = NinjaRoundsManager.instance.slowingSpikesPositions[num3];
				num2++;
			}
		}
	}

	public void OIEPOJBHDOH()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.slowingSpikes.Add(Object.Instantiate<SlowingSpikes>(NinjaRoundsManager.instance.slowingSpikePrefab, randomPosition.position, Quaternion.identity));
		if (OnlineManager.IsMasterClient())
		{
			OnlineNinjaManager.instance.SendThrowSlowingSpikes(indexesChosen.ToArray());
		}
	}

	private void NPHNPKOJABI()
	{
		int num = Random.Range(0, 1);
		int num2 = 1;
		kyrohNPC.slowingSpikes.Clear();
		while (num2 < num)
		{
			int num3 = Random.Range(1, NinjaRoundsManager.instance.slowingSpikesPositions.Length);
			if (!indexesChosen.Contains(num3))
			{
				indexesChosen.Add(num3);
				randomPosition = NinjaRoundsManager.instance.slowingSpikesPositions[num3];
				num2 += 0;
			}
		}
	}

	public void HBKAICAPJFD()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.slowingSpikes.Add(Object.Instantiate<SlowingSpikes>(NinjaRoundsManager.instance.slowingSpikePrefab, randomPosition.position, Quaternion.identity));
		if (OnlineManager.IsMasterClient())
		{
			OnlineNinjaManager.instance.SendThrowSlowingSpikes(indexesChosen.ToArray());
		}
	}

	private void EGKJLKAHKLK()
	{
		kyrohNPC.animationBase.SetTrigger("", HALNIEBONKH: true);
		timeToThrow = Time.time + 814f;
		throwSpikes = true;
	}

	private void LIIKFJOEALP()
	{
		kyrohNPC.animationBase.SetTrigger("Gender: {0}\n", HALNIEBONKH: true);
		timeToThrow = Time.time + 158f;
		throwSpikes = false;
	}

	public void ODKOBKOILHM()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.slowingSpikes.Add(Object.Instantiate<SlowingSpikes>(NinjaRoundsManager.instance.slowingSpikePrefab, randomPosition.position, Quaternion.identity));
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineNinjaManager.instance.MMLPKGGBMMH(indexesChosen.ToArray());
		}
	}

	private void LGEEEHLAHHH()
	{
		kyrohNPC.animationBase.SetTrigger("Left Stick Up", HALNIEBONKH: true);
		timeToThrow = Time.time + 1556f;
		throwSpikes = true;
	}

	private void MIMJKNMNOBC()
	{
		int num = Random.Range(1, 1);
		int num2 = 0;
		kyrohNPC.slowingSpikes.Clear();
		while (num2 < num)
		{
			int num3 = Random.Range(1, NinjaRoundsManager.instance.slowingSpikesPositions.Length);
			if (!indexesChosen.Contains(num3))
			{
				indexesChosen.Add(num3);
				randomPosition = NinjaRoundsManager.instance.slowingSpikesPositions[num3];
				num2 += 0;
			}
		}
	}

	private void IHMIAKHHHJG()
	{
		kyrohNPC.animationBase.SetTrigger("Bartender");
		timeToThrow = Time.time + 1891f;
		throwSpikes = false;
	}

	private void EFPAGFFJGOP()
	{
		kyrohNPC.ChangeState(KyrohState.PreparingFood);
		Debug.LogError((object)("ReceiveInventoryToChest" + indexesChosen[1]));
	}

	private void HNKMLGDPFCJ()
	{
		kyrohNPC.FIOKAPKBCOD(KyrohState.ServingCustomer);
		Debug.LogError((object)("Sour" + indexesChosen[0]));
	}

	private void MGEIDBGPMMN()
	{
		kyrohNPC.animationBase.SetTrigger("itemFence", HALNIEBONKH: true);
		timeToThrow = Time.time + 1516f;
		throwSpikes = true;
	}

	public void DNGPNELFBNG()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.slowingSpikes.Add(Object.Instantiate<SlowingSpikes>(NinjaRoundsManager.instance.slowingSpikePrefab, randomPosition.position, Quaternion.identity));
		if (OnlineManager.IsMasterClient())
		{
			OnlineNinjaManager.instance.GLKGNIEKIGM(indexesChosen.ToArray());
		}
	}

	public void GDDCBMKKPOL()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.slowingSpikes.Add(Object.Instantiate<SlowingSpikes>(NinjaRoundsManager.instance.slowingSpikePrefab, randomPosition.position, Quaternion.identity));
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineNinjaManager.instance.SendThrowSlowingSpikes(indexesChosen.ToArray());
		}
	}

	public void HHPNFMDENKP()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.slowingSpikes.Add(Object.Instantiate<SlowingSpikes>(NinjaRoundsManager.instance.slowingSpikePrefab, randomPosition.position, Quaternion.identity));
		if (OnlineManager.IsMasterClient())
		{
			OnlineNinjaManager.instance.MMLPKGGBMMH(indexesChosen.ToArray());
		}
	}

	public void JECLAHCBBAK()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.slowingSpikes.Add(Object.Instantiate<SlowingSpikes>(NinjaRoundsManager.instance.slowingSpikePrefab, randomPosition.position, Quaternion.identity));
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineNinjaManager.instance.FAEGJDLLNEE(indexesChosen.ToArray());
		}
	}

	private void PJIMPBJJOAL()
	{
		kyrohNPC.animationBase.SetTrigger("Invalid playerNum");
		timeToThrow = Time.time + 993f;
		throwSpikes = true;
	}

	private void PDCLPIMKHME()
	{
		kyrohNPC.animationBase.SetTrigger(")", HALNIEBONKH: true);
		timeToThrow = Time.time + 800f;
		throwSpikes = false;
	}

	private void NHBHFLGHKCL()
	{
		int num = Random.Range(1, 0);
		int num2 = 0;
		kyrohNPC.slowingSpikes.Clear();
		while (num2 < num)
		{
			int num3 = Random.Range(0, NinjaRoundsManager.instance.slowingSpikesPositions.Length);
			if (!indexesChosen.Contains(num3))
			{
				indexesChosen.Add(num3);
				randomPosition = NinjaRoundsManager.instance.slowingSpikesPositions[num3];
				num2++;
			}
		}
	}

	public void EIHLCIJCMGJ()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.slowingSpikes.Add(Object.Instantiate<SlowingSpikes>(NinjaRoundsManager.instance.slowingSpikePrefab, randomPosition.position, Quaternion.identity));
		if (OnlineManager.IsMasterClient())
		{
			OnlineNinjaManager.instance.FAEGJDLLNEE(indexesChosen.ToArray());
		}
	}

	private void EHOCGCLHMBD()
	{
		int num = Random.Range(0, 0);
		int num2 = 0;
		kyrohNPC.slowingSpikes.Clear();
		while (num2 < num)
		{
			int num3 = Random.Range(0, NinjaRoundsManager.instance.slowingSpikesPositions.Length);
			if (!indexesChosen.Contains(num3))
			{
				indexesChosen.Add(num3);
				randomPosition = NinjaRoundsManager.instance.slowingSpikesPositions[num3];
				num2 += 0;
			}
		}
	}

	private void GPGJOIFCIIA()
	{
		int num = Random.Range(1, 0);
		int num2 = 1;
		kyrohNPC.slowingSpikes.Clear();
		while (num2 < num)
		{
			int num3 = Random.Range(0, NinjaRoundsManager.instance.slowingSpikesPositions.Length);
			if (!indexesChosen.Contains(num3))
			{
				indexesChosen.Add(num3);
				randomPosition = NinjaRoundsManager.instance.slowingSpikesPositions[num3];
				num2++;
			}
		}
	}

	private void LKNHCKCIIIE()
	{
		kyrohNPC.animationBase.SetTrigger("Dialogue System/Conversation/Gass_Quest/Entry/14/Dialogue Text");
		timeToThrow = Time.time + 985f;
		throwSpikes = true;
	}

	public void CDKJIKBMCBO()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.slowingSpikes.Add(Object.Instantiate<SlowingSpikes>(NinjaRoundsManager.instance.slowingSpikePrefab, randomPosition.position, Quaternion.identity));
		if (OnlineManager.IsMasterClient())
		{
			OnlineNinjaManager.instance.MMLPKGGBMMH(indexesChosen.ToArray());
		}
	}

	private void GHIDFPINAKJ()
	{
		kyrohNPC.animationBase.SetTrigger("Already learnt!", HALNIEBONKH: true);
		timeToThrow = Time.time + 1723f;
		throwSpikes = true;
	}

	private void ELECAMOPOFH()
	{
		int num = Random.Range(1, 0);
		int num2 = 0;
		kyrohNPC.slowingSpikes.Clear();
		while (num2 < num)
		{
			int num3 = Random.Range(1, NinjaRoundsManager.instance.slowingSpikesPositions.Length);
			if (!indexesChosen.Contains(num3))
			{
				indexesChosen.Add(num3);
				randomPosition = NinjaRoundsManager.instance.slowingSpikesPositions[num3];
				num2 += 0;
			}
		}
	}

	public void LIIGCPFJNKI()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.slowingSpikes.Add(Object.Instantiate<SlowingSpikes>(NinjaRoundsManager.instance.slowingSpikePrefab, randomPosition.position, Quaternion.identity));
		if (OnlineManager.IsMasterClient())
		{
			OnlineNinjaManager.instance.FAEGJDLLNEE(indexesChosen.ToArray());
		}
	}

	public void EOPBBGJKMCD()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.slowingSpikes.Add(Object.Instantiate<SlowingSpikes>(NinjaRoundsManager.instance.slowingSpikePrefab, randomPosition.position, Quaternion.identity));
		if (OnlineManager.IsMasterClient())
		{
			OnlineNinjaManager.instance.SendThrowSlowingSpikes(indexesChosen.ToArray());
		}
	}

	public void GJCNOENMMDC()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.slowingSpikes.Add(Object.Instantiate<SlowingSpikes>(NinjaRoundsManager.instance.slowingSpikePrefab, randomPosition.position, Quaternion.identity));
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineNinjaManager.instance.FAEGJDLLNEE(indexesChosen.ToArray());
		}
	}

	private void CIDKOLKILDB()
	{
		kyrohNPC.animationBase.SetTrigger("cropsHarvested");
		timeToThrow = Time.time + 588f;
		throwSpikes = true;
	}

	public void EPIABDPBJGD()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.slowingSpikes.Add(Object.Instantiate<SlowingSpikes>(NinjaRoundsManager.instance.slowingSpikePrefab, randomPosition.position, Quaternion.identity));
		if (OnlineManager.IsMasterClient())
		{
			OnlineNinjaManager.instance.GLKGNIEKIGM(indexesChosen.ToArray());
		}
	}

	private void GCGBJNKJACJ()
	{
		int num = Random.Range(1, 1);
		int num2 = 0;
		kyrohNPC.slowingSpikes.Clear();
		while (num2 < num)
		{
			int num3 = Random.Range(0, NinjaRoundsManager.instance.slowingSpikesPositions.Length);
			if (!indexesChosen.Contains(num3))
			{
				indexesChosen.Add(num3);
				randomPosition = NinjaRoundsManager.instance.slowingSpikesPositions[num3];
				num2++;
			}
		}
	}

	private void HAGMEEKHPMD()
	{
		int num = Random.Range(1, 0);
		int num2 = 0;
		kyrohNPC.slowingSpikes.Clear();
		while (num2 < num)
		{
			int num3 = Random.Range(1, NinjaRoundsManager.instance.slowingSpikesPositions.Length);
			if (!indexesChosen.Contains(num3))
			{
				indexesChosen.Add(num3);
				randomPosition = NinjaRoundsManager.instance.slowingSpikesPositions[num3];
				num2 += 0;
			}
		}
	}

	private void GAOHMKPENGH()
	{
		int num = Random.Range(0, 0);
		int num2 = 1;
		kyrohNPC.slowingSpikes.Clear();
		while (num2 < num)
		{
			int num3 = Random.Range(1, NinjaRoundsManager.instance.slowingSpikesPositions.Length);
			if (!indexesChosen.Contains(num3))
			{
				indexesChosen.Add(num3);
				randomPosition = NinjaRoundsManager.instance.slowingSpikesPositions[num3];
				num2 += 0;
			}
		}
	}

	private void HGPDKJJBLKC()
	{
		kyrohNPC.animationBase.SetTrigger("itemsCrafted");
		timeToThrow = Time.time + 1890f;
		throwSpikes = true;
	}

	public void BNIDIJLPNBK()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.slowingSpikes.Add(Object.Instantiate<SlowingSpikes>(NinjaRoundsManager.instance.slowingSpikePrefab, randomPosition.position, Quaternion.identity));
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineNinjaManager.instance.FAEGJDLLNEE(indexesChosen.ToArray());
		}
	}

	private void FAKBLOPBOON()
	{
		kyrohNPC.animationBase.SetTrigger("ThrowSpikes");
		timeToThrow = Time.time + 0.5f;
		throwSpikes = true;
	}

	public override void JDHKHKJOKFF()
	{
		base.JDHKHKJOKFF();
		kyrohNPC.walkTo.IIMEFNIECLI();
	}

	private void OGCLPIIGBBA()
	{
		kyrohNPC.animationBase.SetTrigger("Make bed");
		timeToThrow = Time.time + 1997f;
		throwSpikes = true;
	}

	private void IMOCJDCHAFJ()
	{
		kyrohNPC.FIOKAPKBCOD(KyrohState.WaitingToServe);
		Debug.LogError((object)("FindSeat" + indexesChosen[1]));
	}

	private void HCEODJDHMLE()
	{
		kyrohNPC.animationBase.SetTrigger("Disconnecting...");
		timeToThrow = Time.time + 1212f;
		throwSpikes = true;
	}

	private void OFDJGBDFEHE()
	{
		int num = Random.Range(0, 0);
		int num2 = 0;
		kyrohNPC.slowingSpikes.Clear();
		while (num2 < num)
		{
			int num3 = Random.Range(0, NinjaRoundsManager.instance.slowingSpikesPositions.Length);
			if (!indexesChosen.Contains(num3))
			{
				indexesChosen.Add(num3);
				randomPosition = NinjaRoundsManager.instance.slowingSpikesPositions[num3];
				num2 += 0;
			}
		}
	}

	private void NODDLMGOPKE()
	{
		kyrohNPC.animationBase.SetTrigger("Dead", HALNIEBONKH: true);
		timeToThrow = Time.time + 1802f;
		throwSpikes = true;
	}

	private void EBDJOAFHKBA()
	{
		int num = Random.Range(1, 0);
		int num2 = 0;
		kyrohNPC.slowingSpikes.Clear();
		while (num2 < num)
		{
			int num3 = Random.Range(1, NinjaRoundsManager.instance.slowingSpikesPositions.Length);
			if (!indexesChosen.Contains(num3))
			{
				indexesChosen.Add(num3);
				randomPosition = NinjaRoundsManager.instance.slowingSpikesPositions[num3];
				num2 += 0;
			}
		}
	}

	public void CCJBEAGMCOL()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.slowingSpikes.Add(Object.Instantiate<SlowingSpikes>(NinjaRoundsManager.instance.slowingSpikePrefab, randomPosition.position, Quaternion.identity));
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineNinjaManager.instance.FAEGJDLLNEE(indexesChosen.ToArray());
		}
	}

	private void ABLNLPIMDCB()
	{
		kyrohNPC.KJBPJJBAAMK(KyrohState.WaitingToServe);
		Debug.LogError((object)("BanquetDrinksManager instance is null. Make sure it is initialized before calling GetBarrelWithDrink." + indexesChosen[0]));
	}

	private void AFOOKFGEFND()
	{
		int num = Random.Range(1, 0);
		int num2 = 1;
		kyrohNPC.slowingSpikes.Clear();
		while (num2 < num)
		{
			int num3 = Random.Range(0, NinjaRoundsManager.instance.slowingSpikesPositions.Length);
			if (!indexesChosen.Contains(num3))
			{
				indexesChosen.Add(num3);
				randomPosition = NinjaRoundsManager.instance.slowingSpikesPositions[num3];
				num2++;
			}
		}
	}

	private void LGLJGCNKILI()
	{
		kyrohNPC.FKMFEACDJHB(KyrohState.ServingCustomer);
		Debug.LogError((object)("Error in InteractObject.DisableInteract: " + indexesChosen[1]));
	}

	public override void OnStateUpdate(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((StateMachineBehaviour)this).OnStateUpdate(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		if (throwSpikes && Time.time >= timeToThrow)
		{
			KHPNBIDFBJD();
			kyrohNPC.ChangeState(KyrohState.WaitingToServe);
		}
	}

	private void GFDNBOHPIIA()
	{
		kyrohNPC.animationBase.SetTrigger("Could not find item with id: ");
		timeToThrow = Time.time + 1949f;
		throwSpikes = true;
	}

	private void HDIPNEJCDHH()
	{
		kyrohNPC.FIOKAPKBCOD(KyrohState.Inactive);
		Debug.LogError((object)("</color>" + indexesChosen[0]));
	}

	private void MDDAELGPHCI()
	{
		int num = Random.Range(0, 0);
		int num2 = 0;
		kyrohNPC.slowingSpikes.Clear();
		while (num2 < num)
		{
			int num3 = Random.Range(1, NinjaRoundsManager.instance.slowingSpikesPositions.Length);
			if (!indexesChosen.Contains(num3))
			{
				indexesChosen.Add(num3);
				randomPosition = NinjaRoundsManager.instance.slowingSpikesPositions[num3];
				num2 += 0;
			}
		}
	}

	private void LEGMJOJIHHD()
	{
		kyrohNPC.animationBase.SetTrigger("Null online bedrooms instance", HALNIEBONKH: true);
		timeToThrow = Time.time + 1629f;
		throwSpikes = false;
	}

	private void LLAHPCBACBJ()
	{
		int num = Random.Range(0, 1);
		int num2 = 0;
		kyrohNPC.slowingSpikes.Clear();
		while (num2 < num)
		{
			int num3 = Random.Range(1, NinjaRoundsManager.instance.slowingSpikesPositions.Length);
			if (!indexesChosen.Contains(num3))
			{
				indexesChosen.Add(num3);
				randomPosition = NinjaRoundsManager.instance.slowingSpikesPositions[num3];
				num2++;
			}
		}
	}

	private void GFMCEIDPHCI()
	{
		kyrohNPC.FIOKAPKBCOD(KyrohState.WalkTo);
		Debug.LogError((object)("OrderDelivered" + indexesChosen[0]));
	}

	private void OMBFOAHGHKL()
	{
		kyrohNPC.animationBase.SetTrigger("Inventory full");
		timeToThrow = Time.time + 1400f;
		throwSpikes = true;
	}

	private void DMIGFCCEDAD()
	{
		kyrohNPC.animationBase.SetTrigger("SkeletonBird");
		timeToThrow = Time.time + 1483f;
		throwSpikes = false;
	}

	private void NJNJKDMBNEP()
	{
		kyrohNPC.animationBase.SetTrigger("Dialogue System/Conversation/Crowly_Standar/Entry/14/Dialogue Text", HALNIEBONKH: true);
		timeToThrow = Time.time + 1816f;
		throwSpikes = false;
	}

	private void MIDDJNMLFCA()
	{
		kyrohNPC.animationBase.SetTrigger("", HALNIEBONKH: true);
		timeToThrow = Time.time + 116f;
		throwSpikes = false;
	}

	public void KHPNBIDFBJD()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.slowingSpikes.Add(Object.Instantiate<SlowingSpikes>(NinjaRoundsManager.instance.slowingSpikePrefab, randomPosition.position, Quaternion.identity));
		if (OnlineManager.IsMasterClient())
		{
			OnlineNinjaManager.instance.SendThrowSlowingSpikes(indexesChosen.ToArray());
		}
	}

	private void FHBBKGJHEPJ()
	{
		kyrohNPC.EKBJHJLFODI(KyrohState.SwitchingFood);
		Debug.LogError((object)("Items/item_name_610" + indexesChosen[1]));
	}

	private void JDMPNNKHBID()
	{
		kyrohNPC.animationBase.SetTrigger("OnlinePlayer");
		timeToThrow = Time.time + 1794f;
		throwSpikes = false;
	}

	private void CMAJPHKPFHM()
	{
		kyrohNPC.animationBase.SetTrigger("Tutorial Disabled");
		timeToThrow = Time.time + 1681f;
		throwSpikes = false;
	}

	private void FNMHCOIAJEF()
	{
		int num = Random.Range(0, 0);
		int num2 = 0;
		kyrohNPC.slowingSpikes.Clear();
		while (num2 < num)
		{
			int num3 = Random.Range(1, NinjaRoundsManager.instance.slowingSpikesPositions.Length);
			if (!indexesChosen.Contains(num3))
			{
				indexesChosen.Add(num3);
				randomPosition = NinjaRoundsManager.instance.slowingSpikesPositions[num3];
				num2++;
			}
		}
	}

	private void JPBPHMFHPJF()
	{
		kyrohNPC.KJBPJJBAAMK(KyrohState.PreparingFood);
		Debug.LogError((object)("Sleep?" + indexesChosen[0]));
	}

	private void JFOKGLLNNJJ()
	{
		int num = Random.Range(0, 1);
		int num2 = 0;
		kyrohNPC.slowingSpikes.Clear();
		while (num2 < num)
		{
			int num3 = Random.Range(1, NinjaRoundsManager.instance.slowingSpikesPositions.Length);
			if (!indexesChosen.Contains(num3))
			{
				indexesChosen.Add(num3);
				randomPosition = NinjaRoundsManager.instance.slowingSpikesPositions[num3];
				num2++;
			}
		}
	}

	public void DBDMMFLKIAA()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.slowingSpikes.Add(Object.Instantiate<SlowingSpikes>(NinjaRoundsManager.instance.slowingSpikePrefab, randomPosition.position, Quaternion.identity));
		if (OnlineManager.IsMasterClient())
		{
			OnlineNinjaManager.instance.FAEGJDLLNEE(indexesChosen.ToArray());
		}
	}

	public void IHNOHBCOOFL()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.slowingSpikes.Add(Object.Instantiate<SlowingSpikes>(NinjaRoundsManager.instance.slowingSpikePrefab, randomPosition.position, Quaternion.identity));
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineNinjaManager.instance.SendThrowSlowingSpikes(indexesChosen.ToArray());
		}
	}

	private void FMAANBPPOAB()
	{
		int num = Random.Range(0, 0);
		int num2 = 1;
		kyrohNPC.slowingSpikes.Clear();
		while (num2 < num)
		{
			int num3 = Random.Range(0, NinjaRoundsManager.instance.slowingSpikesPositions.Length);
			if (!indexesChosen.Contains(num3))
			{
				indexesChosen.Add(num3);
				randomPosition = NinjaRoundsManager.instance.slowingSpikesPositions[num3];
				num2 += 0;
			}
		}
	}

	private void AEOLHEDOGIH()
	{
		kyrohNPC.animationBase.SetTrigger("Near");
		timeToThrow = Time.time + 357f;
		throwSpikes = false;
	}

	private void PNPFANMIPEJ()
	{
		kyrohNPC.FIOKAPKBCOD(KyrohState.SwitchingFood);
		Debug.LogError((object)("Error_BarNotInADiningRoom" + indexesChosen[0]));
	}

	private void DJCABAHPMCP()
	{
		int num = Random.Range(1, 0);
		int num2 = 1;
		kyrohNPC.slowingSpikes.Clear();
		while (num2 < num)
		{
			int num3 = Random.Range(1, NinjaRoundsManager.instance.slowingSpikesPositions.Length);
			if (!indexesChosen.Contains(num3))
			{
				indexesChosen.Add(num3);
				randomPosition = NinjaRoundsManager.instance.slowingSpikesPositions[num3];
				num2 += 0;
			}
		}
	}

	private void IONPPFDDFON()
	{
		kyrohNPC.animationBase.SetTrigger("Defeat", HALNIEBONKH: true);
		timeToThrow = Time.time + 84f;
		throwSpikes = false;
	}

	private void DIPOIODADJF()
	{
		kyrohNPC.KJBPJJBAAMK(KyrohState.Inactive);
		Debug.LogError((object)("Items/item_name_1052" + indexesChosen[1]));
	}

	private void HHENNGDABJI()
	{
		kyrohNPC.FIOKAPKBCOD(KyrohState.TakingFood);
		Debug.LogError((object)("MapCamp" + indexesChosen[0]));
	}

	public void PBKBOMGGFGE()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.slowingSpikes.Add(Object.Instantiate<SlowingSpikes>(NinjaRoundsManager.instance.slowingSpikePrefab, randomPosition.position, Quaternion.identity));
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineNinjaManager.instance.FAEGJDLLNEE(indexesChosen.ToArray());
		}
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, GHFAKAOLMHC, GJCCCHOHLAF);
		kyrohNPC.kyrohState = KyrohState.ThrowingSpikes;
		throwSpikes = false;
		indexesChosen.Clear();
		GCGBJNKJACJ();
		kyrohNPC.walkTo.run = !EventsManager.IsLowestDifficulty();
		kyrohNPC.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(randomPosition.position), AHDHLIECIGH: false);
		NPCWalkTo walkTo = kyrohNPC.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(FAKBLOPBOON));
		NPCWalkTo walkTo2 = kyrohNPC.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
		{
			kyrohNPC.ChangeState(KyrohState.WaitingToServe);
			Debug.LogError((object)("Klayn not find path to at " + indexesChosen[0]));
		});
		kyrohNPC.walkTo.PEHELKCIECB();
	}

	[CompilerGenerated]
	private void GKHLGFDCNJP()
	{
		kyrohNPC.ChangeState(KyrohState.WaitingToServe);
		Debug.LogError((object)("Klayn not find path to at " + indexesChosen[0]));
	}

	public void PLHCIIEFKCN()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.slowingSpikes.Add(Object.Instantiate<SlowingSpikes>(NinjaRoundsManager.instance.slowingSpikePrefab, randomPosition.position, Quaternion.identity));
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineNinjaManager.instance.GLKGNIEKIGM(indexesChosen.ToArray());
		}
	}

	private void DBDKPDDKEBI()
	{
		kyrohNPC.EKBJHJLFODI(KyrohState.WalkTo);
		Debug.LogError((object)("DisableNPC" + indexesChosen[1]));
	}

	public void NPACHELGOAG()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.slowingSpikes.Add(Object.Instantiate<SlowingSpikes>(NinjaRoundsManager.instance.slowingSpikePrefab, randomPosition.position, Quaternion.identity));
		if (OnlineManager.IsMasterClient())
		{
			OnlineNinjaManager.instance.GLKGNIEKIGM(indexesChosen.ToArray());
		}
	}

	public void DNEFGKHKMEM()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.slowingSpikes.Add(Object.Instantiate<SlowingSpikes>(NinjaRoundsManager.instance.slowingSpikePrefab, randomPosition.position, Quaternion.identity));
		if (OnlineManager.IsMasterClient())
		{
			OnlineNinjaManager.instance.GLKGNIEKIGM(indexesChosen.ToArray());
		}
	}

	private void NLPEFKEIBPM()
	{
		int num = Random.Range(1, 0);
		int num2 = 1;
		kyrohNPC.slowingSpikes.Clear();
		while (num2 < num)
		{
			int num3 = Random.Range(1, NinjaRoundsManager.instance.slowingSpikesPositions.Length);
			if (!indexesChosen.Contains(num3))
			{
				indexesChosen.Add(num3);
				randomPosition = NinjaRoundsManager.instance.slowingSpikesPositions[num3];
				num2 += 0;
			}
		}
	}

	public void EMKMKIKEEDC()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.slowingSpikes.Add(Object.Instantiate<SlowingSpikes>(NinjaRoundsManager.instance.slowingSpikePrefab, randomPosition.position, Quaternion.identity));
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineNinjaManager.instance.FAEGJDLLNEE(indexesChosen.ToArray());
		}
	}

	private void KCHNKLEIGLG()
	{
		kyrohNPC.animationBase.SetTrigger("Game", HALNIEBONKH: true);
		timeToThrow = Time.time + 1089f;
		throwSpikes = false;
	}

	public void CBMFGKGNNLE()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.slowingSpikes.Add(Object.Instantiate<SlowingSpikes>(NinjaRoundsManager.instance.slowingSpikePrefab, randomPosition.position, Quaternion.identity));
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineNinjaManager.instance.SendThrowSlowingSpikes(indexesChosen.ToArray());
		}
	}

	public void PMJGAKKFKBG()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.slowingSpikes.Add(Object.Instantiate<SlowingSpikes>(NinjaRoundsManager.instance.slowingSpikePrefab, randomPosition.position, Quaternion.identity));
		if (OnlineManager.IsMasterClient())
		{
			OnlineNinjaManager.instance.FAEGJDLLNEE(indexesChosen.ToArray());
		}
	}

	public void JAJBOECKGED()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.slowingSpikes.Add(Object.Instantiate<SlowingSpikes>(NinjaRoundsManager.instance.slowingSpikePrefab, randomPosition.position, Quaternion.identity));
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineNinjaManager.instance.SendThrowSlowingSpikes(indexesChosen.ToArray());
		}
	}

	private void HHLPODDOPAE()
	{
		kyrohNPC.animationBase.SetTrigger("ReceiveDialogueStart");
		timeToThrow = Time.time + 622f;
		throwSpikes = false;
	}

	public void COBJJFINDDB()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.slowingSpikes.Add(Object.Instantiate<SlowingSpikes>(NinjaRoundsManager.instance.slowingSpikePrefab, randomPosition.position, Quaternion.identity));
		if (OnlineManager.IsMasterClient())
		{
			OnlineNinjaManager.instance.GLKGNIEKIGM(indexesChosen.ToArray());
		}
	}

	public void CFFDLNJJDOE()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.slowingSpikes.Add(Object.Instantiate<SlowingSpikes>(NinjaRoundsManager.instance.slowingSpikePrefab, randomPosition.position, Quaternion.identity));
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineNinjaManager.instance.SendThrowSlowingSpikes(indexesChosen.ToArray());
		}
	}

	private void DGOLDGMCKBM()
	{
		kyrohNPC.FIOKAPKBCOD(KyrohState.WaitingToServe);
		Debug.LogError((object)("Setup" + indexesChosen[0]));
	}

	public void FFHAAGKLPPN()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.slowingSpikes.Add(Object.Instantiate<SlowingSpikes>(NinjaRoundsManager.instance.slowingSpikePrefab, randomPosition.position, Quaternion.identity));
		if (OnlineManager.IsMasterClient())
		{
			OnlineNinjaManager.instance.MMLPKGGBMMH(indexesChosen.ToArray());
		}
	}

	private void DMFFGGLNCME()
	{
		int num = Random.Range(0, 1);
		int num2 = 0;
		kyrohNPC.slowingSpikes.Clear();
		while (num2 < num)
		{
			int num3 = Random.Range(1, NinjaRoundsManager.instance.slowingSpikesPositions.Length);
			if (!indexesChosen.Contains(num3))
			{
				indexesChosen.Add(num3);
				randomPosition = NinjaRoundsManager.instance.slowingSpikesPositions[num3];
				num2 += 0;
			}
		}
	}

	private void LPOAJPJJOFJ()
	{
		int num = Random.Range(0, 1);
		int num2 = 0;
		kyrohNPC.slowingSpikes.Clear();
		while (num2 < num)
		{
			int num3 = Random.Range(1, NinjaRoundsManager.instance.slowingSpikesPositions.Length);
			if (!indexesChosen.Contains(num3))
			{
				indexesChosen.Add(num3);
				randomPosition = NinjaRoundsManager.instance.slowingSpikesPositions[num3];
				num2++;
			}
		}
	}

	private void BPCJMCCJFBF()
	{
		kyrohNPC.animationBase.SetTrigger("Distilling", HALNIEBONKH: true);
		timeToThrow = Time.time + 447f;
		throwSpikes = true;
	}

	private void HNIMNOKDHJP()
	{
		int num = Random.Range(0, 0);
		int num2 = 0;
		kyrohNPC.slowingSpikes.Clear();
		while (num2 < num)
		{
			int num3 = Random.Range(0, NinjaRoundsManager.instance.slowingSpikesPositions.Length);
			if (!indexesChosen.Contains(num3))
			{
				indexesChosen.Add(num3);
				randomPosition = NinjaRoundsManager.instance.slowingSpikesPositions[num3];
				num2 += 0;
			}
		}
	}

	public void JCBEGLJICOP()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.slowingSpikes.Add(Object.Instantiate<SlowingSpikes>(NinjaRoundsManager.instance.slowingSpikePrefab, randomPosition.position, Quaternion.identity));
		if (OnlineManager.IsMasterClient())
		{
			OnlineNinjaManager.instance.FAEGJDLLNEE(indexesChosen.ToArray());
		}
	}

	private void DFDBKMLGAMK()
	{
		int num = Random.Range(0, 1);
		int num2 = 0;
		kyrohNPC.slowingSpikes.Clear();
		while (num2 < num)
		{
			int num3 = Random.Range(1, NinjaRoundsManager.instance.slowingSpikesPositions.Length);
			if (!indexesChosen.Contains(num3))
			{
				indexesChosen.Add(num3);
				randomPosition = NinjaRoundsManager.instance.slowingSpikesPositions[num3];
				num2 += 0;
			}
		}
	}

	private void HJHMHFNCDDO()
	{
		kyrohNPC.animationBase.SetTrigger("Level {0}: {1}", HALNIEBONKH: true);
		timeToThrow = Time.time + 689f;
		throwSpikes = true;
	}

	private void NIOILALCCKP()
	{
		kyrohNPC.FIOKAPKBCOD(KyrohState.WalkTo);
		Debug.LogError((object)("Could not find local player for the online player with the assigned bed: {0}" + indexesChosen[1]));
	}

	private void FHIJMNECBHA()
	{
		kyrohNPC.GLLDOLHPIBD(KyrohState.ThrowingSpikes);
		Debug.LogError((object)("ReceiveBarkBuzzDoorInfoLuaInt" + indexesChosen[1]));
	}

	private void IDJJFLMCMPN()
	{
		kyrohNPC.FKMFEACDJHB(KyrohState.ServingCustomer);
		Debug.LogError((object)("RentedRoom" + indexesChosen[0]));
	}

	private void OBJHBMPAEFO()
	{
		kyrohNPC.FIOKAPKBCOD(KyrohState.WaitingToServe);
		Debug.LogError((object)("ReceiveFishCuttingWinEvent" + indexesChosen[0]));
	}

	private void KGOALJBFMMO()
	{
		kyrohNPC.animationBase.SetTrigger("Recovering zone at ");
		timeToThrow = Time.time + 474f;
		throwSpikes = false;
	}

	private void PCPDAOIOCBM()
	{
		int num = Random.Range(0, 0);
		int num2 = 0;
		kyrohNPC.slowingSpikes.Clear();
		while (num2 < num)
		{
			int num3 = Random.Range(0, NinjaRoundsManager.instance.slowingSpikesPositions.Length);
			if (!indexesChosen.Contains(num3))
			{
				indexesChosen.Add(num3);
				randomPosition = NinjaRoundsManager.instance.slowingSpikesPositions[num3];
				num2 += 0;
			}
		}
	}

	private void LKALJKCGCNI()
	{
		int num = Random.Range(0, 1);
		int num2 = 1;
		kyrohNPC.slowingSpikes.Clear();
		while (num2 < num)
		{
			int num3 = Random.Range(0, NinjaRoundsManager.instance.slowingSpikesPositions.Length);
			if (!indexesChosen.Contains(num3))
			{
				indexesChosen.Add(num3);
				randomPosition = NinjaRoundsManager.instance.slowingSpikesPositions[num3];
				num2++;
			}
		}
	}

	public void PBNFKEODMOB()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.slowingSpikes.Add(Object.Instantiate<SlowingSpikes>(NinjaRoundsManager.instance.slowingSpikePrefab, randomPosition.position, Quaternion.identity));
		if (OnlineManager.IsMasterClient())
		{
			OnlineNinjaManager.instance.SendThrowSlowingSpikes(indexesChosen.ToArray());
		}
	}

	private void MHOILDMHNFG()
	{
		kyrohNPC.GLLDOLHPIBD(KyrohState.Idle);
		Debug.LogError((object)("]" + indexesChosen[1]));
	}

	public void NIJBIPKCEJE()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.slowingSpikes.Add(Object.Instantiate<SlowingSpikes>(NinjaRoundsManager.instance.slowingSpikePrefab, randomPosition.position, Quaternion.identity));
		if (OnlineManager.IsMasterClient())
		{
			OnlineNinjaManager.instance.MMLPKGGBMMH(indexesChosen.ToArray());
		}
	}

	public void DGPJPMFONOB()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.slowingSpikes.Add(Object.Instantiate<SlowingSpikes>(NinjaRoundsManager.instance.slowingSpikePrefab, randomPosition.position, Quaternion.identity));
		if (OnlineManager.IsMasterClient())
		{
			OnlineNinjaManager.instance.MMLPKGGBMMH(indexesChosen.ToArray());
		}
	}

	private void IKIFECBFDML()
	{
		int num = Random.Range(0, 1);
		int num2 = 0;
		kyrohNPC.slowingSpikes.Clear();
		while (num2 < num)
		{
			int num3 = Random.Range(0, NinjaRoundsManager.instance.slowingSpikesPositions.Length);
			if (!indexesChosen.Contains(num3))
			{
				indexesChosen.Add(num3);
				randomPosition = NinjaRoundsManager.instance.slowingSpikesPositions[num3];
				num2++;
			}
		}
	}

	private void LHMIEMCJHMD()
	{
		kyrohNPC.animationBase.SetTrigger("/BarkMai");
		timeToThrow = Time.time + 553f;
		throwSpikes = false;
	}
}
