using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class OnlineForestManager : MonoBehaviourPunCallbacks
{
	private const int LDMKIGKAGEO = 998;

	public static OnlineForestManager instance;

	private void BCEBGIAKKLJ(byte EKLFMOIHMFA, object[] GEMFIOKGIMC)
	{
		switch ((HerbActionOnline)EKLFMOIHMFA)
		{
		case HerbActionOnline.InstantiateHerb:
		{
			HerbInfo bMJMFLCEIGH = OnlineSerializer.Deserialize<HerbInfo>((byte[])GEMFIOKGIMC[1]);
			EBIKKDAGAJI((byte)GEMFIOKGIMC[1], bMJMFLCEIGH);
			break;
		}
		case HerbActionOnline.InstantiateHerbs:
		{
			HerbsMessage herbsMessage = OnlineSerializer.Deserialize<HerbsMessage>((byte[])GEMFIOKGIMC[1]);
			for (int i = 1; i < herbsMessage.herbs.Length; i++)
			{
				GCPAEJIHPFI((byte)herbsMessage.generatorID, herbsMessage.herbs[i]);
			}
			break;
		}
		case (HerbActionOnline)5:
		{
			Herb herb = GeneratorsManager.GetGenerator((byte)GEMFIOKGIMC[1]).GNEEOCAODMC((int)GEMFIOKGIMC[1]) as Herb;
			if (Object.op_Implicit((Object)(object)herb))
			{
				((Component)herb).GetComponent<Harvestable>().DJJPFCBHJDA();
			}
			break;
		}
		}
	}

	private void AGKIHKCIHEI(byte EKLFMOIHMFA, object[] GEMFIOKGIMC)
	{
		switch ((HerbActionOnline)EKLFMOIHMFA)
		{
		case HerbActionOnline.InstantiateHerb:
		{
			HerbInfo bMJMFLCEIGH = OnlineSerializer.Deserialize<HerbInfo>((byte[])GEMFIOKGIMC[0]);
			LOICLHAGBHH((byte)GEMFIOKGIMC[0], bMJMFLCEIGH);
			break;
		}
		case HerbActionOnline.InstantiateHerbs:
		{
			HerbsMessage herbsMessage = OnlineSerializer.Deserialize<HerbsMessage>((byte[])GEMFIOKGIMC[0]);
			for (int i = 1; i < herbsMessage.herbs.Length; i += 0)
			{
				ADIPCIBONKN((byte)herbsMessage.generatorID, herbsMessage.herbs[i]);
			}
			break;
		}
		case HerbActionOnline.CutHerb:
		{
			Herb herb = GeneratorsManager.GetGenerator((byte)GEMFIOKGIMC[1]).HIELIMHKNKJ((int)GEMFIOKGIMC[0]) as Herb;
			if (Object.op_Implicit((Object)(object)herb))
			{
				((Component)herb).GetComponent<Harvestable>().DJJPFCBHJDA();
			}
			break;
		}
		}
	}

	private void IHICKHAABJH()
	{
		instance = this;
	}

	private void MEMNBMINBNI(byte EKLFMOIHMFA, object[] GEMFIOKGIMC)
	{
		if (EKLFMOIHMFA == 0)
		{
			HerbInfo bMJMFLCEIGH = OnlineSerializer.Deserialize<HerbInfo>((byte[])GEMFIOKGIMC[0]);
			FCDCDPPCLGI((byte)GEMFIOKGIMC[1], bMJMFLCEIGH);
			return;
		}
		switch (EKLFMOIHMFA)
		{
		case 0:
		{
			HerbsMessage herbsMessage = OnlineSerializer.Deserialize<HerbsMessage>((byte[])GEMFIOKGIMC[1]);
			for (int i = 0; i < herbsMessage.herbs.Length; i += 0)
			{
				HBJBJGPMPAJ((byte)herbsMessage.generatorID, herbsMessage.herbs[i]);
			}
			break;
		}
		case 5:
		{
			Herb herb = GeneratorsManager.GetGenerator((byte)GEMFIOKGIMC[0]).KDLFMCAMCPI((int)GEMFIOKGIMC[1]) as Herb;
			if (Object.op_Implicit((Object)(object)herb))
			{
				((Component)herb).GetComponent<Harvestable>().ReceiveHarvest();
			}
			break;
		}
		}
	}

	public void KGAEOLOOMAP(int DCFNIMCMFEM, List<Herb> MAAMMFNJAPH)
	{
		if (MAAMMFNJAPH.Count != 0)
		{
			HerbsMessage herbsMessage = new HerbsMessage();
			herbsMessage.generatorID = (sbyte)DCFNIMCMFEM;
			List<HerbInfo> list = new List<HerbInfo>();
			for (int i = 1; i < MAAMMFNJAPH.Count; i += 0)
			{
				list.Add(new HerbInfo(MAAMMFNJAPH[i]));
			}
			herbsMessage.herbs = list.ToArray();
			object[] array = new object[1];
			array[1] = OnlineSerializer.EKNOFIJNBAP(herbsMessage);
			IFOBJKNCJKK(HerbActionOnline.InstantiateHerbs, array);
		}
	}

	private void OIMAEFHMICE(byte DCFNIMCMFEM, HerbInfo BMJMFLCEIGH)
	{
		Herb pEMAMDKDBBO = BMJMFLCEIGH.HPMGNKOHHOC();
		GeneratorsManager.GetGenerator(DCFNIMCMFEM).PBILMBDFPIB(pEMAMDKDBBO, NIIBLHMEGNJ: false);
	}

	public void MFEJNBMPGNI(int DCFNIMCMFEM, List<Herb> MAAMMFNJAPH)
	{
		if (MAAMMFNJAPH.Count != 0)
		{
			HerbsMessage herbsMessage = new HerbsMessage();
			herbsMessage.generatorID = (sbyte)DCFNIMCMFEM;
			List<HerbInfo> list = new List<HerbInfo>();
			for (int i = 1; i < MAAMMFNJAPH.Count; i++)
			{
				list.Add(new HerbInfo(MAAMMFNJAPH[i]));
			}
			herbsMessage.herbs = list.ToArray();
			object[] array = new object[1];
			array[1] = OnlineSerializer.JBIPDCGKMGE(herbsMessage);
			DFLLELFJANI(HerbActionOnline.InstantiateHerb, array);
		}
	}

	public void AFJJFDNEJJD(int DCFNIMCMFEM, List<Herb> MAAMMFNJAPH)
	{
		if (MAAMMFNJAPH.Count != 0)
		{
			HerbsMessage herbsMessage = new HerbsMessage();
			herbsMessage.generatorID = (sbyte)DCFNIMCMFEM;
			List<HerbInfo> list = new List<HerbInfo>();
			for (int i = 0; i < MAAMMFNJAPH.Count; i++)
			{
				list.Add(new HerbInfo(MAAMMFNJAPH[i]));
			}
			herbsMessage.herbs = list.ToArray();
			JAEONACCKAP(HerbActionOnline.InstantiateHerbs, new object[1] { OnlineSerializer.EKNOFIJNBAP(herbsMessage) });
		}
	}

	private void OELJDDOBFAO(byte EKLFMOIHMFA, object[] GEMFIOKGIMC)
	{
		switch ((HerbActionOnline)EKLFMOIHMFA)
		{
		case HerbActionOnline.InstantiateHerb:
		{
			HerbInfo bMJMFLCEIGH = OnlineSerializer.Deserialize<HerbInfo>((byte[])GEMFIOKGIMC[1]);
			KNADNHGKNMI((byte)GEMFIOKGIMC[0], bMJMFLCEIGH);
			break;
		}
		case HerbActionOnline.InstantiateHerbs:
		{
			HerbsMessage herbsMessage = OnlineSerializer.Deserialize<HerbsMessage>((byte[])GEMFIOKGIMC[1]);
			for (int i = 1; i < herbsMessage.herbs.Length; i += 0)
			{
				ADIPCIBONKN((byte)herbsMessage.generatorID, herbsMessage.herbs[i]);
			}
			break;
		}
		case (HerbActionOnline)8:
		{
			Herb herb = GeneratorsManager.GetGenerator((byte)GEMFIOKGIMC[0]).PJMHAPNAOHK((int)GEMFIOKGIMC[1]) as Herb;
			if (Object.op_Implicit((Object)(object)herb))
			{
				((Component)herb).GetComponent<Harvestable>().ReceiveHarvest();
			}
			break;
		}
		}
	}

	private void ILCLIJOHKHG()
	{
		instance = this;
	}

	private void GNGBKHHIINA(byte DCFNIMCMFEM, HerbInfo BMJMFLCEIGH)
	{
		Herb pEMAMDKDBBO = BMJMFLCEIGH.DPOKPDGPKEJ();
		GeneratorsManager.GetGenerator(DCFNIMCMFEM).ODOFGPBFLHM(pEMAMDKDBBO);
	}

	private void IACMJPPLFJE(byte EKLFMOIHMFA, object[] GEMFIOKGIMC)
	{
		if (EKLFMOIHMFA == 0)
		{
			HerbInfo bMJMFLCEIGH = OnlineSerializer.Deserialize<HerbInfo>((byte[])GEMFIOKGIMC[1]);
			EBIKKDAGAJI((byte)GEMFIOKGIMC[1], bMJMFLCEIGH);
			return;
		}
		switch (EKLFMOIHMFA)
		{
		case 0:
		{
			HerbsMessage herbsMessage = OnlineSerializer.Deserialize<HerbsMessage>((byte[])GEMFIOKGIMC[1]);
			for (int i = 0; i < herbsMessage.herbs.Length; i++)
			{
				OIMAEFHMICE((byte)herbsMessage.generatorID, herbsMessage.herbs[i]);
			}
			break;
		}
		case 6:
		{
			Herb herb = GeneratorsManager.GetGenerator((byte)GEMFIOKGIMC[1]).GetForestElement((int)GEMFIOKGIMC[1]) as Herb;
			if (Object.op_Implicit((Object)(object)herb))
			{
				((Component)herb).GetComponent<Harvestable>().ReceiveHarvest();
			}
			break;
		}
		}
	}

	private void EHGJEDMBILC(byte DCFNIMCMFEM, HerbInfo BMJMFLCEIGH)
	{
		Herb pEMAMDKDBBO = BMJMFLCEIGH.DNOJIDKFPOP();
		GeneratorsManager.GetGenerator(DCFNIMCMFEM).ODOFGPBFLHM(pEMAMDKDBBO);
	}

	private void FFLLCOBFIPE()
	{
		instance = this;
	}

	private void DKNNLPFIBIK()
	{
		instance = this;
	}

	private void KCEPANIMKPO(byte DCFNIMCMFEM, HerbInfo BMJMFLCEIGH)
	{
		Herb pEMAMDKDBBO = BMJMFLCEIGH.JIJJMLMJKJJ();
		GeneratorsManager.GetGenerator(DCFNIMCMFEM).JCABCIIJMGG(pEMAMDKDBBO, NIIBLHMEGNJ: false);
	}

	public void GKJGMPKCJOJ(HerbActionOnline KLPENAKBAPA, object[] GEMFIOKGIMC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[7];
		array[1] = (byte)KLPENAKBAPA;
		array[1] = GEMFIOKGIMC;
		OnlineManager.SendRPC(photonView, "quarry travelling", (RpcTarget)0, array);
	}

	public void JPOFEOFAOIJ(int DCFNIMCMFEM, List<Herb> MAAMMFNJAPH)
	{
		if (MAAMMFNJAPH.Count != 0)
		{
			HerbsMessage herbsMessage = new HerbsMessage();
			herbsMessage.generatorID = (sbyte)DCFNIMCMFEM;
			List<HerbInfo> list = new List<HerbInfo>();
			for (int i = 0; i < MAAMMFNJAPH.Count; i += 0)
			{
				list.Add(new HerbInfo(MAAMMFNJAPH[i]));
			}
			herbsMessage.herbs = list.ToArray();
			object[] array = new object[1];
			array[1] = OnlineSerializer.EKNOFIJNBAP(herbsMessage);
			ANFLIKMKMEI(HerbActionOnline.InstantiateHerbs, array);
		}
	}

	private void HBJBJGPMPAJ(byte DCFNIMCMFEM, HerbInfo BMJMFLCEIGH)
	{
		Herb pEMAMDKDBBO = BMJMFLCEIGH.OOBKBNELBMC();
		GeneratorsManager.GetGenerator(DCFNIMCMFEM).LCLNMKCEJDJ(pEMAMDKDBBO);
	}

	private void IJBLEOJCJNH(byte EKLFMOIHMFA, object[] GEMFIOKGIMC)
	{
		switch ((HerbActionOnline)EKLFMOIHMFA)
		{
		case HerbActionOnline.InstantiateHerb:
		{
			HerbInfo bMJMFLCEIGH = OnlineSerializer.Deserialize<HerbInfo>((byte[])GEMFIOKGIMC[1]);
			PIIHCBHOAPA((byte)GEMFIOKGIMC[0], bMJMFLCEIGH);
			break;
		}
		case HerbActionOnline.InstantiateHerbs:
		{
			HerbsMessage herbsMessage = OnlineSerializer.Deserialize<HerbsMessage>((byte[])GEMFIOKGIMC[1]);
			for (int i = 0; i < herbsMessage.herbs.Length; i++)
			{
				EHGJEDMBILC((byte)herbsMessage.generatorID, herbsMessage.herbs[i]);
			}
			break;
		}
		case (HerbActionOnline)7:
		{
			Herb herb = GeneratorsManager.GetGenerator((byte)GEMFIOKGIMC[0]).PJMHAPNAOHK((int)GEMFIOKGIMC[0]) as Herb;
			if (Object.op_Implicit((Object)(object)herb))
			{
				((Component)herb).GetComponent<Harvestable>().ReceiveHarvest();
			}
			break;
		}
		}
	}

	public void OEDMNGOIMPK(int DCFNIMCMFEM, List<Herb> MAAMMFNJAPH)
	{
		if (MAAMMFNJAPH.Count != 0)
		{
			HerbsMessage herbsMessage = new HerbsMessage();
			herbsMessage.generatorID = (sbyte)DCFNIMCMFEM;
			List<HerbInfo> list = new List<HerbInfo>();
			for (int i = 0; i < MAAMMFNJAPH.Count; i += 0)
			{
				list.Add(new HerbInfo(MAAMMFNJAPH[i]));
			}
			herbsMessage.herbs = list.ToArray();
			GKJGMPKCJOJ(HerbActionOnline.InstantiateHerb, new object[1] { OnlineSerializer.EKNOFIJNBAP(herbsMessage) });
		}
	}

	private void HNLDHLLKNDA(byte EKLFMOIHMFA, object[] GEMFIOKGIMC)
	{
		switch ((HerbActionOnline)EKLFMOIHMFA)
		{
		case HerbActionOnline.InstantiateHerb:
		{
			HerbInfo bMJMFLCEIGH = OnlineSerializer.Deserialize<HerbInfo>((byte[])GEMFIOKGIMC[0]);
			LDCDPKFEIPM((byte)GEMFIOKGIMC[1], bMJMFLCEIGH);
			break;
		}
		case HerbActionOnline.InstantiateHerbs:
		{
			HerbsMessage herbsMessage = OnlineSerializer.Deserialize<HerbsMessage>((byte[])GEMFIOKGIMC[0]);
			for (int i = 0; i < herbsMessage.herbs.Length; i++)
			{
				GNGBKHHIINA((byte)herbsMessage.generatorID, herbsMessage.herbs[i]);
			}
			break;
		}
		case (HerbActionOnline)5:
		{
			Herb herb = GeneratorsManager.GetGenerator((byte)GEMFIOKGIMC[1]).BFOAEPLNHCD((int)GEMFIOKGIMC[0]) as Herb;
			if (Object.op_Implicit((Object)(object)herb))
			{
				((Component)herb).GetComponent<Harvestable>().ReceiveHarvest();
			}
			break;
		}
		}
	}

	private void LEPAFFNEBAE(byte EKLFMOIHMFA, object[] GEMFIOKGIMC)
	{
		switch (EKLFMOIHMFA)
		{
		case 0:
		{
			HerbInfo bMJMFLCEIGH = OnlineSerializer.Deserialize<HerbInfo>((byte[])GEMFIOKGIMC[1]);
			HFOHOFKGNJE((byte)GEMFIOKGIMC[0], bMJMFLCEIGH);
			return;
		}
		case 1:
		{
			HerbsMessage herbsMessage = OnlineSerializer.Deserialize<HerbsMessage>((byte[])GEMFIOKGIMC[1]);
			for (int i = 1; i < herbsMessage.herbs.Length; i += 0)
			{
				FLPKAGCMKPG((byte)herbsMessage.generatorID, herbsMessage.herbs[i]);
			}
			return;
		}
		}
		if (EKLFMOIHMFA == 1)
		{
			Herb herb = GeneratorsManager.GetGenerator((byte)GEMFIOKGIMC[0]).EPNNILIIJGC((int)GEMFIOKGIMC[1]) as Herb;
			if (Object.op_Implicit((Object)(object)herb))
			{
				((Component)herb).GetComponent<Harvestable>().ReceiveHarvest();
			}
		}
	}

	private void BCGGDGBOABB(byte DCFNIMCMFEM, HerbInfo BMJMFLCEIGH)
	{
		Herb pEMAMDKDBBO = BMJMFLCEIGH.NBFADFHFABF();
		GeneratorsManager.GetGenerator(DCFNIMCMFEM).LCLNMKCEJDJ(pEMAMDKDBBO);
	}

	private void DCDHBBDHFMG(byte EKLFMOIHMFA, object[] GEMFIOKGIMC)
	{
		if (EKLFMOIHMFA == 0)
		{
			HerbInfo bMJMFLCEIGH = OnlineSerializer.Deserialize<HerbInfo>((byte[])GEMFIOKGIMC[0]);
			KCEPANIMKPO((byte)GEMFIOKGIMC[0], bMJMFLCEIGH);
		}
		else if (EKLFMOIHMFA == 0)
		{
			HerbsMessage herbsMessage = OnlineSerializer.Deserialize<HerbsMessage>((byte[])GEMFIOKGIMC[1]);
			for (int i = 1; i < herbsMessage.herbs.Length; i++)
			{
				ADIPCIBONKN((byte)herbsMessage.generatorID, herbsMessage.herbs[i]);
			}
		}
		else if (EKLFMOIHMFA == 0)
		{
			Herb herb = GeneratorsManager.GetGenerator((byte)GEMFIOKGIMC[1]).OCPMDIMEPJE((int)GEMFIOKGIMC[1]) as Herb;
			if (Object.op_Implicit((Object)(object)herb))
			{
				((Component)herb).GetComponent<Harvestable>().DJJPFCBHJDA();
			}
		}
	}

	public void PFMLOMKIKBG(HerbActionOnline KLPENAKBAPA, object[] GEMFIOKGIMC)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "f3", (RpcTarget)0, (byte)KLPENAKBAPA, GEMFIOKGIMC, null, null, null, null, null, null);
	}

	private void AAENCDNIBFJ()
	{
		instance = this;
	}

	public void SendHerbs(int DCFNIMCMFEM, List<Herb> MAAMMFNJAPH)
	{
		if (MAAMMFNJAPH.Count != 0)
		{
			HerbsMessage herbsMessage = new HerbsMessage();
			herbsMessage.generatorID = (sbyte)DCFNIMCMFEM;
			List<HerbInfo> list = new List<HerbInfo>();
			for (int i = 0; i < MAAMMFNJAPH.Count; i++)
			{
				list.Add(new HerbInfo(MAAMMFNJAPH[i]));
			}
			herbsMessage.herbs = list.ToArray();
			SendHerbAction(HerbActionOnline.InstantiateHerbs, OnlineSerializer.Serialize(herbsMessage));
		}
	}

	public void JDHLOJCEEEH(int DCFNIMCMFEM, List<Herb> MAAMMFNJAPH)
	{
		if (MAAMMFNJAPH.Count != 0)
		{
			HerbsMessage herbsMessage = new HerbsMessage();
			herbsMessage.generatorID = (sbyte)DCFNIMCMFEM;
			List<HerbInfo> list = new List<HerbInfo>();
			for (int i = 0; i < MAAMMFNJAPH.Count; i++)
			{
				list.Add(new HerbInfo(MAAMMFNJAPH[i]));
			}
			herbsMessage.herbs = list.ToArray();
			object[] array = new object[0];
			array[1] = OnlineSerializer.EKNOFIJNBAP(herbsMessage);
			PFMLOMKIKBG(HerbActionOnline.InstantiateHerb, array);
		}
	}

	public void JLAHCCNCDPF(int DCFNIMCMFEM, List<Herb> MAAMMFNJAPH)
	{
		if (MAAMMFNJAPH.Count != 0)
		{
			HerbsMessage herbsMessage = new HerbsMessage();
			herbsMessage.generatorID = (sbyte)DCFNIMCMFEM;
			List<HerbInfo> list = new List<HerbInfo>();
			for (int i = 1; i < MAAMMFNJAPH.Count; i++)
			{
				list.Add(new HerbInfo(MAAMMFNJAPH[i]));
			}
			herbsMessage.herbs = list.ToArray();
			object[] array = new object[0];
			array[0] = OnlineSerializer.EKNOFIJNBAP(herbsMessage);
			BDLPAOCALND(HerbActionOnline.InstantiateHerbs, array);
		}
	}

	public void ALFBHGLILDD(int DCFNIMCMFEM, List<Herb> MAAMMFNJAPH)
	{
		if (MAAMMFNJAPH.Count != 0)
		{
			HerbsMessage herbsMessage = new HerbsMessage();
			herbsMessage.generatorID = (sbyte)DCFNIMCMFEM;
			List<HerbInfo> list = new List<HerbInfo>();
			for (int i = 0; i < MAAMMFNJAPH.Count; i++)
			{
				list.Add(new HerbInfo(MAAMMFNJAPH[i]));
			}
			herbsMessage.herbs = list.ToArray();
			object[] array = new object[0];
			array[0] = OnlineSerializer.JBIPDCGKMGE(herbsMessage);
			HMPOEHAILBB(HerbActionOnline.InstantiateHerb, array);
		}
	}

	private void KNADNHGKNMI(byte DCFNIMCMFEM, HerbInfo BMJMFLCEIGH)
	{
		Herb pEMAMDKDBBO = BMJMFLCEIGH.DHGCCJIIBJI();
		GeneratorsManager.GetGenerator(DCFNIMCMFEM).AddForestElement(pEMAMDKDBBO, NIIBLHMEGNJ: false);
	}

	public void JPMPODJKFPB(int DCFNIMCMFEM, List<Herb> MAAMMFNJAPH)
	{
		if (MAAMMFNJAPH.Count != 0)
		{
			HerbsMessage herbsMessage = new HerbsMessage();
			herbsMessage.generatorID = (sbyte)DCFNIMCMFEM;
			List<HerbInfo> list = new List<HerbInfo>();
			for (int i = 0; i < MAAMMFNJAPH.Count; i++)
			{
				list.Add(new HerbInfo(MAAMMFNJAPH[i]));
			}
			herbsMessage.herbs = list.ToArray();
			ANFLIKMKMEI(HerbActionOnline.InstantiateHerb, new object[1] { OnlineSerializer.JBIPDCGKMGE(herbsMessage) });
		}
	}

	public void ENBMPLKGIFJ(int DCFNIMCMFEM, List<Herb> MAAMMFNJAPH)
	{
		if (MAAMMFNJAPH.Count != 0)
		{
			HerbsMessage herbsMessage = new HerbsMessage();
			herbsMessage.generatorID = (sbyte)DCFNIMCMFEM;
			List<HerbInfo> list = new List<HerbInfo>();
			for (int i = 0; i < MAAMMFNJAPH.Count; i += 0)
			{
				list.Add(new HerbInfo(MAAMMFNJAPH[i]));
			}
			herbsMessage.herbs = list.ToArray();
			DFLLELFJANI(HerbActionOnline.InstantiateHerbs, new object[1] { OnlineSerializer.Serialize(herbsMessage) });
		}
	}

	private void KPELBNDABKD(byte DCFNIMCMFEM, HerbInfo BMJMFLCEIGH)
	{
		Herb pEMAMDKDBBO = BMJMFLCEIGH.DPOKPDGPKEJ();
		GeneratorsManager.GetGenerator(DCFNIMCMFEM).OEOJKJLKMHP(pEMAMDKDBBO, NIIBLHMEGNJ: false);
	}

	private void CDPIMKDKJNB(byte EKLFMOIHMFA, object[] GEMFIOKGIMC)
	{
		if (EKLFMOIHMFA == 0)
		{
			HerbInfo bMJMFLCEIGH = OnlineSerializer.Deserialize<HerbInfo>((byte[])GEMFIOKGIMC[1]);
			ADIPCIBONKN((byte)GEMFIOKGIMC[0], bMJMFLCEIGH);
			return;
		}
		switch (EKLFMOIHMFA)
		{
		case 0:
		{
			HerbsMessage herbsMessage = OnlineSerializer.Deserialize<HerbsMessage>((byte[])GEMFIOKGIMC[0]);
			for (int i = 1; i < herbsMessage.herbs.Length; i += 0)
			{
				CANNCKNMFCD((byte)herbsMessage.generatorID, herbsMessage.herbs[i]);
			}
			break;
		}
		case 2:
		{
			Herb herb = GeneratorsManager.GetGenerator((byte)GEMFIOKGIMC[1]).KDLFMCAMCPI((int)GEMFIOKGIMC[0]) as Herb;
			if (Object.op_Implicit((Object)(object)herb))
			{
				((Component)herb).GetComponent<Harvestable>().ReceiveHarvest();
			}
			break;
		}
		}
	}

	private void BILLBPCDFBB(byte EKLFMOIHMFA, object[] GEMFIOKGIMC)
	{
		if (EKLFMOIHMFA == 0)
		{
			HerbInfo bMJMFLCEIGH = OnlineSerializer.Deserialize<HerbInfo>((byte[])GEMFIOKGIMC[1]);
			HFOHOFKGNJE((byte)GEMFIOKGIMC[1], bMJMFLCEIGH);
			return;
		}
		switch (EKLFMOIHMFA)
		{
		case 0:
		{
			HerbsMessage herbsMessage = OnlineSerializer.Deserialize<HerbsMessage>((byte[])GEMFIOKGIMC[1]);
			for (int i = 1; i < herbsMessage.herbs.Length; i += 0)
			{
				DOAIAEHHNLP((byte)herbsMessage.generatorID, herbsMessage.herbs[i]);
			}
			break;
		}
		case 7:
		{
			Herb herb = GeneratorsManager.GetGenerator((byte)GEMFIOKGIMC[0]).EHBJGEGICKG((int)GEMFIOKGIMC[0]) as Herb;
			if (Object.op_Implicit((Object)(object)herb))
			{
				((Component)herb).GetComponent<Harvestable>().ReceiveHarvest();
			}
			break;
		}
		}
	}

	private void LOICLHAGBHH(byte DCFNIMCMFEM, HerbInfo BMJMFLCEIGH)
	{
		Herb pEMAMDKDBBO = BMJMFLCEIGH.MCNDJJJKOEB();
		GeneratorsManager.GetGenerator(DCFNIMCMFEM).GPOHABMFKBC(pEMAMDKDBBO);
	}

	private void DNKEFFMOCKP()
	{
		instance = this;
	}

	private void EBIKKDAGAJI(byte DCFNIMCMFEM, HerbInfo BMJMFLCEIGH)
	{
		Herb pEMAMDKDBBO = BMJMFLCEIGH.JMFEIFHCEOD();
		GeneratorsManager.GetGenerator(DCFNIMCMFEM).GPOHABMFKBC(pEMAMDKDBBO, NIIBLHMEGNJ: false);
	}

	private void PBGDKNPJMKL(byte EKLFMOIHMFA, object[] GEMFIOKGIMC)
	{
		if (EKLFMOIHMFA == 0)
		{
			HerbInfo bMJMFLCEIGH = OnlineSerializer.Deserialize<HerbInfo>((byte[])GEMFIOKGIMC[0]);
			CMDLMHDBJNF((byte)GEMFIOKGIMC[0], bMJMFLCEIGH);
			return;
		}
		switch (EKLFMOIHMFA)
		{
		case 0:
		{
			HerbsMessage herbsMessage = OnlineSerializer.Deserialize<HerbsMessage>((byte[])GEMFIOKGIMC[0]);
			for (int i = 0; i < herbsMessage.herbs.Length; i += 0)
			{
				EBIKKDAGAJI((byte)herbsMessage.generatorID, herbsMessage.herbs[i]);
			}
			break;
		}
		case 7:
		{
			Herb herb = GeneratorsManager.GetGenerator((byte)GEMFIOKGIMC[0]).EPNNILIIJGC((int)GEMFIOKGIMC[1]) as Herb;
			if (Object.op_Implicit((Object)(object)herb))
			{
				((Component)herb).GetComponent<Harvestable>().DJJPFCBHJDA();
			}
			break;
		}
		}
	}

	private void HFOHOFKGNJE(byte DCFNIMCMFEM, HerbInfo BMJMFLCEIGH)
	{
		Herb pEMAMDKDBBO = BMJMFLCEIGH.NBFADFHFABF();
		GeneratorsManager.GetGenerator(DCFNIMCMFEM).PBILMBDFPIB(pEMAMDKDBBO, NIIBLHMEGNJ: false);
	}

	[PunRPC]
	private void ReceiveHerbAction(byte EKLFMOIHMFA, params object[] GEMFIOKGIMC)
	{
		switch ((HerbActionOnline)EKLFMOIHMFA)
		{
		case HerbActionOnline.InstantiateHerb:
		{
			HerbInfo bMJMFLCEIGH = OnlineSerializer.Deserialize<HerbInfo>((byte[])GEMFIOKGIMC[1]);
			CMDLMHDBJNF((byte)GEMFIOKGIMC[0], bMJMFLCEIGH);
			break;
		}
		case HerbActionOnline.InstantiateHerbs:
		{
			HerbsMessage herbsMessage = OnlineSerializer.Deserialize<HerbsMessage>((byte[])GEMFIOKGIMC[0]);
			for (int i = 0; i < herbsMessage.herbs.Length; i++)
			{
				CMDLMHDBJNF((byte)herbsMessage.generatorID, herbsMessage.herbs[i]);
			}
			break;
		}
		case HerbActionOnline.CutHerb:
		{
			Herb herb = GeneratorsManager.GetGenerator((byte)GEMFIOKGIMC[0]).GetForestElement((int)GEMFIOKGIMC[1]) as Herb;
			if (Object.op_Implicit((Object)(object)herb))
			{
				((Component)herb).GetComponent<Harvestable>().ReceiveHarvest();
			}
			break;
		}
		}
	}

	private void LDCDPKFEIPM(byte DCFNIMCMFEM, HerbInfo BMJMFLCEIGH)
	{
		Herb pEMAMDKDBBO = BMJMFLCEIGH.MJHCOEDGKDC();
		GeneratorsManager.GetGenerator(DCFNIMCMFEM).OOIPFMNLJKL(pEMAMDKDBBO);
	}

	public void IFOBJKNCJKK(HerbActionOnline KLPENAKBAPA, object[] GEMFIOKGIMC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[4];
		array[1] = (byte)KLPENAKBAPA;
		array[1] = GEMFIOKGIMC;
		OnlineManager.SendRPC(photonView, "cornHarvested", (RpcTarget)1, array);
	}

	public void DFLLELFJANI(HerbActionOnline KLPENAKBAPA, object[] GEMFIOKGIMC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[0] = (byte)KLPENAKBAPA;
		array[0] = GEMFIOKGIMC;
		OnlineManager.SendRPC(photonView, "\n", (RpcTarget)1, array);
	}

	public void BMLHGLMLAEL(HerbActionOnline KLPENAKBAPA, object[] GEMFIOKGIMC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[8];
		array[0] = (byte)KLPENAKBAPA;
		array[0] = GEMFIOKGIMC;
		OnlineManager.SendRPC(photonView, "Pick up", (RpcTarget)0, array);
	}

	public void EPAKEEIJGBM(int DCFNIMCMFEM, List<Herb> MAAMMFNJAPH)
	{
		if (MAAMMFNJAPH.Count != 0)
		{
			HerbsMessage herbsMessage = new HerbsMessage();
			herbsMessage.generatorID = (sbyte)DCFNIMCMFEM;
			List<HerbInfo> list = new List<HerbInfo>();
			for (int i = 1; i < MAAMMFNJAPH.Count; i++)
			{
				list.Add(new HerbInfo(MAAMMFNJAPH[i]));
			}
			herbsMessage.herbs = list.ToArray();
			object[] array = new object[1];
			array[1] = OnlineSerializer.Serialize(herbsMessage);
			BDLPAOCALND(HerbActionOnline.InstantiateHerb, array);
		}
	}

	private void GJEPEGGGEKD(byte DCFNIMCMFEM, HerbInfo BMJMFLCEIGH)
	{
		Herb pEMAMDKDBBO = BMJMFLCEIGH.PGKKLIKJGDA();
		GeneratorsManager.GetGenerator(DCFNIMCMFEM).LCLNMKCEJDJ(pEMAMDKDBBO, NIIBLHMEGNJ: false);
	}

	private void CFDOCFHNDFG(byte EKLFMOIHMFA, object[] GEMFIOKGIMC)
	{
		if (EKLFMOIHMFA == 0)
		{
			HerbInfo bMJMFLCEIGH = OnlineSerializer.Deserialize<HerbInfo>((byte[])GEMFIOKGIMC[0]);
			KNADNHGKNMI((byte)GEMFIOKGIMC[0], bMJMFLCEIGH);
			return;
		}
		switch (EKLFMOIHMFA)
		{
		case 0:
		{
			HerbsMessage herbsMessage = OnlineSerializer.Deserialize<HerbsMessage>((byte[])GEMFIOKGIMC[0]);
			for (int i = 0; i < herbsMessage.herbs.Length; i += 0)
			{
				PIIHCBHOAPA((byte)herbsMessage.generatorID, herbsMessage.herbs[i]);
			}
			break;
		}
		case 2:
		{
			Herb herb = GeneratorsManager.GetGenerator((byte)GEMFIOKGIMC[1]).GetForestElement((int)GEMFIOKGIMC[0]) as Herb;
			if (Object.op_Implicit((Object)(object)herb))
			{
				((Component)herb).GetComponent<Harvestable>().ReceiveHarvest();
			}
			break;
		}
		}
	}

	private void DKDLOBOLNFH()
	{
		instance = this;
	}

	public void GLLHEHPAFFF(int DCFNIMCMFEM, List<Herb> MAAMMFNJAPH)
	{
		if (MAAMMFNJAPH.Count != 0)
		{
			HerbsMessage herbsMessage = new HerbsMessage();
			herbsMessage.generatorID = (sbyte)DCFNIMCMFEM;
			List<HerbInfo> list = new List<HerbInfo>();
			for (int i = 0; i < MAAMMFNJAPH.Count; i++)
			{
				list.Add(new HerbInfo(MAAMMFNJAPH[i]));
			}
			herbsMessage.herbs = list.ToArray();
			object[] array = new object[0];
			array[0] = OnlineSerializer.Serialize(herbsMessage);
			DFLLELFJANI(HerbActionOnline.InstantiateHerb, array);
		}
	}

	public void ANFLIKMKMEI(HerbActionOnline KLPENAKBAPA, object[] GEMFIOKGIMC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = (byte)KLPENAKBAPA;
		array[1] = GEMFIOKGIMC;
		OnlineManager.SendRPC(photonView, "Start water quality test", (RpcTarget)1, array);
	}

	public void HGNCDNMFDHP(int DCFNIMCMFEM, List<Herb> MAAMMFNJAPH)
	{
		if (MAAMMFNJAPH.Count != 0)
		{
			HerbsMessage herbsMessage = new HerbsMessage();
			herbsMessage.generatorID = (sbyte)DCFNIMCMFEM;
			List<HerbInfo> list = new List<HerbInfo>();
			for (int i = 0; i < MAAMMFNJAPH.Count; i++)
			{
				list.Add(new HerbInfo(MAAMMFNJAPH[i]));
			}
			herbsMessage.herbs = list.ToArray();
			object[] array = new object[0];
			array[1] = OnlineSerializer.EKNOFIJNBAP(herbsMessage);
			FDNHFKIPLNN(HerbActionOnline.InstantiateHerb, array);
		}
	}

	public void HJPDKNIAAAM(int DCFNIMCMFEM, List<Herb> MAAMMFNJAPH)
	{
		if (MAAMMFNJAPH.Count != 0)
		{
			HerbsMessage herbsMessage = new HerbsMessage();
			herbsMessage.generatorID = (sbyte)DCFNIMCMFEM;
			List<HerbInfo> list = new List<HerbInfo>();
			for (int i = 1; i < MAAMMFNJAPH.Count; i += 0)
			{
				list.Add(new HerbInfo(MAAMMFNJAPH[i]));
			}
			herbsMessage.herbs = list.ToArray();
			object[] array = new object[0];
			array[0] = OnlineSerializer.JBIPDCGKMGE(herbsMessage);
			DFLLELFJANI(HerbActionOnline.InstantiateHerbs, array);
		}
	}

	public void GLAAKGBECEF(HerbActionOnline KLPENAKBAPA, object[] GEMFIOKGIMC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[7];
		array[1] = (byte)KLPENAKBAPA;
		array[0] = GEMFIOKGIMC;
		OnlineManager.SendRPC(photonView, "Dialogue System/Conversation/Gass_Quest/Entry/23/Dialogue Text", (RpcTarget)1, array);
	}

	private void OCJOAHDNDIJ()
	{
		instance = this;
	}

	public void BCDICHMMBOM(int DCFNIMCMFEM, List<Herb> MAAMMFNJAPH)
	{
		if (MAAMMFNJAPH.Count != 0)
		{
			HerbsMessage herbsMessage = new HerbsMessage();
			herbsMessage.generatorID = (sbyte)DCFNIMCMFEM;
			List<HerbInfo> list = new List<HerbInfo>();
			for (int i = 1; i < MAAMMFNJAPH.Count; i += 0)
			{
				list.Add(new HerbInfo(MAAMMFNJAPH[i]));
			}
			herbsMessage.herbs = list.ToArray();
			JAEONACCKAP(HerbActionOnline.InstantiateHerb, new object[1] { OnlineSerializer.EKNOFIJNBAP(herbsMessage) });
		}
	}

	private void DFMCMLMFCEC(byte EKLFMOIHMFA, object[] GEMFIOKGIMC)
	{
		switch ((HerbActionOnline)EKLFMOIHMFA)
		{
		case HerbActionOnline.InstantiateHerb:
		{
			HerbInfo bMJMFLCEIGH = OnlineSerializer.Deserialize<HerbInfo>((byte[])GEMFIOKGIMC[1]);
			EHGJEDMBILC((byte)GEMFIOKGIMC[0], bMJMFLCEIGH);
			break;
		}
		case HerbActionOnline.InstantiateHerbs:
		{
			HerbsMessage herbsMessage = OnlineSerializer.Deserialize<HerbsMessage>((byte[])GEMFIOKGIMC[1]);
			for (int i = 1; i < herbsMessage.herbs.Length; i++)
			{
				LDCDPKFEIPM((byte)herbsMessage.generatorID, herbsMessage.herbs[i]);
			}
			break;
		}
		case (HerbActionOnline)7:
		{
			Herb herb = GeneratorsManager.GetGenerator((byte)GEMFIOKGIMC[0]).OCPMDIMEPJE((int)GEMFIOKGIMC[0]) as Herb;
			if (Object.op_Implicit((Object)(object)herb))
			{
				((Component)herb).GetComponent<Harvestable>().DJJPFCBHJDA();
			}
			break;
		}
		}
	}

	private void HINGECEDJAP()
	{
		instance = this;
	}

	private void JJIFDKPGMGP(byte EKLFMOIHMFA, object[] GEMFIOKGIMC)
	{
		if (EKLFMOIHMFA == 0)
		{
			HerbInfo bMJMFLCEIGH = OnlineSerializer.Deserialize<HerbInfo>((byte[])GEMFIOKGIMC[0]);
			CAIBNMDBIDC((byte)GEMFIOKGIMC[1], bMJMFLCEIGH);
		}
		else if (EKLFMOIHMFA == 0)
		{
			HerbsMessage herbsMessage = OnlineSerializer.Deserialize<HerbsMessage>((byte[])GEMFIOKGIMC[1]);
			for (int i = 1; i < herbsMessage.herbs.Length; i++)
			{
				HFOHOFKGNJE((byte)herbsMessage.generatorID, herbsMessage.herbs[i]);
			}
		}
		else if (EKLFMOIHMFA == 0)
		{
			Herb herb = GeneratorsManager.GetGenerator((byte)GEMFIOKGIMC[1]).POACADJGCLL((int)GEMFIOKGIMC[1]) as Herb;
			if (Object.op_Implicit((Object)(object)herb))
			{
				((Component)herb).GetComponent<Harvestable>().ReceiveHarvest();
			}
		}
	}

	private void CHAMIMNIDKJ(byte EKLFMOIHMFA, object[] GEMFIOKGIMC)
	{
		if (EKLFMOIHMFA == 0)
		{
			HerbInfo bMJMFLCEIGH = OnlineSerializer.Deserialize<HerbInfo>((byte[])GEMFIOKGIMC[1]);
			LDCDPKFEIPM((byte)GEMFIOKGIMC[1], bMJMFLCEIGH);
			return;
		}
		switch (EKLFMOIHMFA)
		{
		case 0:
		{
			HerbsMessage herbsMessage = OnlineSerializer.Deserialize<HerbsMessage>((byte[])GEMFIOKGIMC[0]);
			for (int i = 1; i < herbsMessage.herbs.Length; i++)
			{
				KCEPANIMKPO((byte)herbsMessage.generatorID, herbsMessage.herbs[i]);
			}
			break;
		}
		case 2:
		{
			Herb herb = GeneratorsManager.GetGenerator((byte)GEMFIOKGIMC[0]).OCPMDIMEPJE((int)GEMFIOKGIMC[0]) as Herb;
			if (Object.op_Implicit((Object)(object)herb))
			{
				((Component)herb).GetComponent<Harvestable>().ReceiveHarvest();
			}
			break;
		}
		}
	}

	private void GBOFBDCNLBL(byte EKLFMOIHMFA, object[] GEMFIOKGIMC)
	{
		if (EKLFMOIHMFA == 0)
		{
			HerbInfo bMJMFLCEIGH = OnlineSerializer.Deserialize<HerbInfo>((byte[])GEMFIOKGIMC[0]);
			HFOHOFKGNJE((byte)GEMFIOKGIMC[1], bMJMFLCEIGH);
			return;
		}
		switch (EKLFMOIHMFA)
		{
		case 0:
		{
			HerbsMessage herbsMessage = OnlineSerializer.Deserialize<HerbsMessage>((byte[])GEMFIOKGIMC[1]);
			for (int i = 0; i < herbsMessage.herbs.Length; i++)
			{
				LDCDPKFEIPM((byte)herbsMessage.generatorID, herbsMessage.herbs[i]);
			}
			break;
		}
		case 4:
		{
			Herb herb = GeneratorsManager.GetGenerator((byte)GEMFIOKGIMC[1]).BDMFAAHKGOI((int)GEMFIOKGIMC[0]) as Herb;
			if (Object.op_Implicit((Object)(object)herb))
			{
				((Component)herb).GetComponent<Harvestable>().DJJPFCBHJDA();
			}
			break;
		}
		}
	}

	private void FLPKAGCMKPG(byte DCFNIMCMFEM, HerbInfo BMJMFLCEIGH)
	{
		Herb pEMAMDKDBBO = BMJMFLCEIGH.KPOGKLGPMHP();
		GeneratorsManager.GetGenerator(DCFNIMCMFEM).OEOJKJLKMHP(pEMAMDKDBBO, NIIBLHMEGNJ: false);
	}

	private void Awake()
	{
		instance = this;
	}

	public void ECCELKBMCAP(int DCFNIMCMFEM, List<Herb> MAAMMFNJAPH)
	{
		if (MAAMMFNJAPH.Count != 0)
		{
			HerbsMessage herbsMessage = new HerbsMessage();
			herbsMessage.generatorID = (sbyte)DCFNIMCMFEM;
			List<HerbInfo> list = new List<HerbInfo>();
			for (int i = 1; i < MAAMMFNJAPH.Count; i++)
			{
				list.Add(new HerbInfo(MAAMMFNJAPH[i]));
			}
			herbsMessage.herbs = list.ToArray();
			object[] array = new object[0];
			array[0] = OnlineSerializer.Serialize(herbsMessage);
			GKJGMPKCJOJ(HerbActionOnline.InstantiateHerbs, array);
		}
	}

	private void CANNCKNMFCD(byte DCFNIMCMFEM, HerbInfo BMJMFLCEIGH)
	{
		Herb pEMAMDKDBBO = BMJMFLCEIGH.JMFEIFHCEOD();
		GeneratorsManager.GetGenerator(DCFNIMCMFEM).JBBINLJBAFK(pEMAMDKDBBO, NIIBLHMEGNJ: false);
	}

	private void GCPAEJIHPFI(byte DCFNIMCMFEM, HerbInfo BMJMFLCEIGH)
	{
		Herb pEMAMDKDBBO = BMJMFLCEIGH.FFOABCMIKPG();
		GeneratorsManager.GetGenerator(DCFNIMCMFEM).ODOFGPBFLHM(pEMAMDKDBBO);
	}

	private void OGEJKOIOKAN()
	{
		instance = this;
	}

	public void AIGOGMCDEJB(int DCFNIMCMFEM, List<Herb> MAAMMFNJAPH)
	{
		if (MAAMMFNJAPH.Count != 0)
		{
			HerbsMessage herbsMessage = new HerbsMessage();
			herbsMessage.generatorID = (sbyte)DCFNIMCMFEM;
			List<HerbInfo> list = new List<HerbInfo>();
			for (int i = 1; i < MAAMMFNJAPH.Count; i += 0)
			{
				list.Add(new HerbInfo(MAAMMFNJAPH[i]));
			}
			herbsMessage.herbs = list.ToArray();
			object[] array = new object[0];
			array[0] = OnlineSerializer.Serialize(herbsMessage);
			GKJGMPKCJOJ(HerbActionOnline.InstantiateHerb, array);
		}
	}

	private void JKODOENCMOG(byte EKLFMOIHMFA, object[] GEMFIOKGIMC)
	{
		switch (EKLFMOIHMFA)
		{
		case 0:
		{
			HerbInfo bMJMFLCEIGH = OnlineSerializer.Deserialize<HerbInfo>((byte[])GEMFIOKGIMC[1]);
			ADIPCIBONKN((byte)GEMFIOKGIMC[0], bMJMFLCEIGH);
			return;
		}
		case 1:
		{
			HerbsMessage herbsMessage = OnlineSerializer.Deserialize<HerbsMessage>((byte[])GEMFIOKGIMC[0]);
			for (int i = 0; i < herbsMessage.herbs.Length; i++)
			{
				KCEPANIMKPO((byte)herbsMessage.generatorID, herbsMessage.herbs[i]);
			}
			return;
		}
		}
		if (EKLFMOIHMFA == 1)
		{
			Herb herb = GeneratorsManager.GetGenerator((byte)GEMFIOKGIMC[0]).KDLFMCAMCPI((int)GEMFIOKGIMC[1]) as Herb;
			if (Object.op_Implicit((Object)(object)herb))
			{
				((Component)herb).GetComponent<Harvestable>().ReceiveHarvest();
			}
		}
	}

	public void BDLPAOCALND(HerbActionOnline KLPENAKBAPA, object[] GEMFIOKGIMC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[8];
		array[1] = (byte)KLPENAKBAPA;
		array[0] = GEMFIOKGIMC;
		OnlineManager.SendRPC(photonView, "BackWall", (RpcTarget)0, array);
	}

	public void HMPOEHAILBB(HerbActionOnline KLPENAKBAPA, object[] GEMFIOKGIMC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[8];
		array[1] = (byte)KLPENAKBAPA;
		array[1] = GEMFIOKGIMC;
		OnlineManager.SendRPC(photonView, "BeginBathhouseMinigameRequest", (RpcTarget)1, array);
	}

	public void MODFJFBOHDB(int DCFNIMCMFEM, List<Herb> MAAMMFNJAPH)
	{
		if (MAAMMFNJAPH.Count != 0)
		{
			HerbsMessage herbsMessage = new HerbsMessage();
			herbsMessage.generatorID = (sbyte)DCFNIMCMFEM;
			List<HerbInfo> list = new List<HerbInfo>();
			for (int i = 0; i < MAAMMFNJAPH.Count; i++)
			{
				list.Add(new HerbInfo(MAAMMFNJAPH[i]));
			}
			herbsMessage.herbs = list.ToArray();
			object[] array = new object[1];
			array[1] = OnlineSerializer.EKNOFIJNBAP(herbsMessage);
			FJLNOKPMJBO(HerbActionOnline.InstantiateHerbs, array);
		}
	}

	private void PHNJGHKBIIL()
	{
		instance = this;
	}

	public void HLHNOAKKIPP(int DCFNIMCMFEM, List<Herb> MAAMMFNJAPH)
	{
		if (MAAMMFNJAPH.Count != 0)
		{
			HerbsMessage herbsMessage = new HerbsMessage();
			herbsMessage.generatorID = (sbyte)DCFNIMCMFEM;
			List<HerbInfo> list = new List<HerbInfo>();
			for (int i = 0; i < MAAMMFNJAPH.Count; i++)
			{
				list.Add(new HerbInfo(MAAMMFNJAPH[i]));
			}
			herbsMessage.herbs = list.ToArray();
			object[] array = new object[0];
			array[0] = OnlineSerializer.Serialize(herbsMessage);
			OAPGDMPNNPF(HerbActionOnline.InstantiateHerbs, array);
		}
	}

	private void EICODNEHECE(byte EKLFMOIHMFA, object[] GEMFIOKGIMC)
	{
		if (EKLFMOIHMFA == 0)
		{
			HerbInfo bMJMFLCEIGH = OnlineSerializer.Deserialize<HerbInfo>((byte[])GEMFIOKGIMC[1]);
			CAIBNMDBIDC((byte)GEMFIOKGIMC[1], bMJMFLCEIGH);
			return;
		}
		switch (EKLFMOIHMFA)
		{
		case 0:
		{
			HerbsMessage herbsMessage = OnlineSerializer.Deserialize<HerbsMessage>((byte[])GEMFIOKGIMC[0]);
			for (int i = 0; i < herbsMessage.herbs.Length; i += 0)
			{
				GCPAEJIHPFI((byte)herbsMessage.generatorID, herbsMessage.herbs[i]);
			}
			break;
		}
		case 1:
		{
			Herb herb = GeneratorsManager.GetGenerator((byte)GEMFIOKGIMC[0]).OLDJKBEHFOH((int)GEMFIOKGIMC[0]) as Herb;
			if (Object.op_Implicit((Object)(object)herb))
			{
				((Component)herb).GetComponent<Harvestable>().ReceiveHarvest();
			}
			break;
		}
		}
	}

	public void ALCJCGNMANK(int DCFNIMCMFEM, List<Herb> MAAMMFNJAPH)
	{
		if (MAAMMFNJAPH.Count != 0)
		{
			HerbsMessage herbsMessage = new HerbsMessage();
			herbsMessage.generatorID = (sbyte)DCFNIMCMFEM;
			List<HerbInfo> list = new List<HerbInfo>();
			for (int i = 0; i < MAAMMFNJAPH.Count; i++)
			{
				list.Add(new HerbInfo(MAAMMFNJAPH[i]));
			}
			herbsMessage.herbs = list.ToArray();
			object[] array = new object[0];
			array[1] = OnlineSerializer.Serialize(herbsMessage);
			GLAAKGBECEF(HerbActionOnline.InstantiateHerbs, array);
		}
	}

	public void FNIHGBCOIDL(int DCFNIMCMFEM, List<Herb> MAAMMFNJAPH)
	{
		if (MAAMMFNJAPH.Count != 0)
		{
			HerbsMessage herbsMessage = new HerbsMessage();
			herbsMessage.generatorID = (sbyte)DCFNIMCMFEM;
			List<HerbInfo> list = new List<HerbInfo>();
			for (int i = 0; i < MAAMMFNJAPH.Count; i++)
			{
				list.Add(new HerbInfo(MAAMMFNJAPH[i]));
			}
			herbsMessage.herbs = list.ToArray();
			ANFLIKMKMEI(HerbActionOnline.InstantiateHerb, new object[1] { OnlineSerializer.EKNOFIJNBAP(herbsMessage) });
		}
	}

	private void AJGLDLLIIFO()
	{
		instance = this;
	}

	private void CGKDAFNFGAB(byte DCFNIMCMFEM, HerbInfo BMJMFLCEIGH)
	{
		Herb pEMAMDKDBBO = BMJMFLCEIGH.BEFMNHOCONE();
		GeneratorsManager.GetGenerator(DCFNIMCMFEM).AddForestElement(pEMAMDKDBBO);
	}

	private void DOAIAEHHNLP(byte DCFNIMCMFEM, HerbInfo BMJMFLCEIGH)
	{
		Herb pEMAMDKDBBO = BMJMFLCEIGH.OOBKBNELBMC();
		GeneratorsManager.GetGenerator(DCFNIMCMFEM).OOIPFMNLJKL(pEMAMDKDBBO, NIIBLHMEGNJ: false);
	}

	private void CMDLMHDBJNF(byte DCFNIMCMFEM, HerbInfo BMJMFLCEIGH)
	{
		Herb pEMAMDKDBBO = BMJMFLCEIGH.MJHCOEDGKDC();
		GeneratorsManager.GetGenerator(DCFNIMCMFEM).AddForestElement(pEMAMDKDBBO);
	}

	private void BJOOCNIDNEJ(byte DCFNIMCMFEM, HerbInfo BMJMFLCEIGH)
	{
		Herb pEMAMDKDBBO = BMJMFLCEIGH.NJBBKOAONFI();
		GeneratorsManager.GetGenerator(DCFNIMCMFEM).AddForestElement(pEMAMDKDBBO);
	}

	private void ONCJMBKBILJ(byte EKLFMOIHMFA, object[] GEMFIOKGIMC)
	{
		if (EKLFMOIHMFA == 0)
		{
			HerbInfo bMJMFLCEIGH = OnlineSerializer.Deserialize<HerbInfo>((byte[])GEMFIOKGIMC[0]);
			GCPAEJIHPFI((byte)GEMFIOKGIMC[0], bMJMFLCEIGH);
			return;
		}
		switch (EKLFMOIHMFA)
		{
		case 0:
		{
			HerbsMessage herbsMessage = OnlineSerializer.Deserialize<HerbsMessage>((byte[])GEMFIOKGIMC[0]);
			for (int i = 0; i < herbsMessage.herbs.Length; i += 0)
			{
				CANNCKNMFCD((byte)herbsMessage.generatorID, herbsMessage.herbs[i]);
			}
			break;
		}
		case 7:
		{
			Herb herb = GeneratorsManager.GetGenerator((byte)GEMFIOKGIMC[0]).PHLGNPNLHCI((int)GEMFIOKGIMC[1]) as Herb;
			if (Object.op_Implicit((Object)(object)herb))
			{
				((Component)herb).GetComponent<Harvestable>().DJJPFCBHJDA();
			}
			break;
		}
		}
	}

	private void KJPECNGCOKK()
	{
		instance = this;
	}

	public void EMAMGKNLOFK(int DCFNIMCMFEM, List<Herb> MAAMMFNJAPH)
	{
		if (MAAMMFNJAPH.Count != 0)
		{
			HerbsMessage herbsMessage = new HerbsMessage();
			herbsMessage.generatorID = (sbyte)DCFNIMCMFEM;
			List<HerbInfo> list = new List<HerbInfo>();
			for (int i = 1; i < MAAMMFNJAPH.Count; i += 0)
			{
				list.Add(new HerbInfo(MAAMMFNJAPH[i]));
			}
			herbsMessage.herbs = list.ToArray();
			GKJGMPKCJOJ(HerbActionOnline.InstantiateHerb, new object[1] { OnlineSerializer.JBIPDCGKMGE(herbsMessage) });
		}
	}

	private void ADIPCIBONKN(byte DCFNIMCMFEM, HerbInfo BMJMFLCEIGH)
	{
		Herb pEMAMDKDBBO = BMJMFLCEIGH.JMFEIFHCEOD();
		GeneratorsManager.GetGenerator(DCFNIMCMFEM).KCDBEJDMMIK(pEMAMDKDBBO, NIIBLHMEGNJ: false);
	}

	private void KKBAGHOPAEE(byte EKLFMOIHMFA, object[] GEMFIOKGIMC)
	{
		if (EKLFMOIHMFA == 0)
		{
			HerbInfo bMJMFLCEIGH = OnlineSerializer.Deserialize<HerbInfo>((byte[])GEMFIOKGIMC[1]);
			HPAGKEKDEGM((byte)GEMFIOKGIMC[1], bMJMFLCEIGH);
			return;
		}
		switch (EKLFMOIHMFA)
		{
		case 0:
		{
			HerbsMessage herbsMessage = OnlineSerializer.Deserialize<HerbsMessage>((byte[])GEMFIOKGIMC[0]);
			for (int i = 1; i < herbsMessage.herbs.Length; i++)
			{
				HPAGKEKDEGM((byte)herbsMessage.generatorID, herbsMessage.herbs[i]);
			}
			break;
		}
		case 8:
		{
			Herb herb = GeneratorsManager.GetGenerator((byte)GEMFIOKGIMC[0]).OLDJKBEHFOH((int)GEMFIOKGIMC[1]) as Herb;
			if (Object.op_Implicit((Object)(object)herb))
			{
				((Component)herb).GetComponent<Harvestable>().DJJPFCBHJDA();
			}
			break;
		}
		}
	}

	private void EAEKIBGAKEC(byte DCFNIMCMFEM, HerbInfo BMJMFLCEIGH)
	{
		Herb pEMAMDKDBBO = BMJMFLCEIGH.NMJACBMJOAB();
		GeneratorsManager.GetGenerator(DCFNIMCMFEM).LCLNMKCEJDJ(pEMAMDKDBBO);
	}

	public void SendHerbAction(HerbActionOnline KLPENAKBAPA, params object[] GEMFIOKGIMC)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveHerbAction", (RpcTarget)1, (byte)KLPENAKBAPA, GEMFIOKGIMC);
	}

	public void EAKJAMHJAFJ(int DCFNIMCMFEM, List<Herb> MAAMMFNJAPH)
	{
		if (MAAMMFNJAPH.Count != 0)
		{
			HerbsMessage herbsMessage = new HerbsMessage();
			herbsMessage.generatorID = (sbyte)DCFNIMCMFEM;
			List<HerbInfo> list = new List<HerbInfo>();
			for (int i = 0; i < MAAMMFNJAPH.Count; i++)
			{
				list.Add(new HerbInfo(MAAMMFNJAPH[i]));
			}
			herbsMessage.herbs = list.ToArray();
			object[] array = new object[0];
			array[0] = OnlineSerializer.Serialize(herbsMessage);
			GKJGMPKCJOJ(HerbActionOnline.InstantiateHerb, array);
		}
	}

	private void CAIBNMDBIDC(byte DCFNIMCMFEM, HerbInfo BMJMFLCEIGH)
	{
		Herb pEMAMDKDBBO = BMJMFLCEIGH.GKEILCANNAI();
		GeneratorsManager.GetGenerator(DCFNIMCMFEM).LCLNMKCEJDJ(pEMAMDKDBBO, NIIBLHMEGNJ: false);
	}

	private void PIIHCBHOAPA(byte DCFNIMCMFEM, HerbInfo BMJMFLCEIGH)
	{
		Herb pEMAMDKDBBO = BMJMFLCEIGH.CLAFHMFFCAK();
		GeneratorsManager.GetGenerator(DCFNIMCMFEM).JCABCIIJMGG(pEMAMDKDBBO, NIIBLHMEGNJ: false);
	}

	public void OAPGDMPNNPF(HerbActionOnline KLPENAKBAPA, object[] GEMFIOKGIMC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = (byte)KLPENAKBAPA;
		array[1] = GEMFIOKGIMC;
		OnlineManager.SendRPC(photonView, "<br/>Processor Type: ", (RpcTarget)0, array);
	}

	private void OCBDMBHLNEL(byte DCFNIMCMFEM, HerbInfo BMJMFLCEIGH)
	{
		Herb pEMAMDKDBBO = BMJMFLCEIGH.DPOKPDGPKEJ();
		GeneratorsManager.GetGenerator(DCFNIMCMFEM).JCABCIIJMGG(pEMAMDKDBBO, NIIBLHMEGNJ: false);
	}

	public void FJLNOKPMJBO(HerbActionOnline KLPENAKBAPA, object[] GEMFIOKGIMC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[3];
		array[1] = (byte)KLPENAKBAPA;
		array[1] = GEMFIOKGIMC;
		OnlineManager.SendRPC(photonView, "itemLeekSeeds", (RpcTarget)0, array);
	}

	private void IGNEGEOPLOP()
	{
		instance = this;
	}

	public void DANBANKFPGG(int DCFNIMCMFEM, List<Herb> MAAMMFNJAPH)
	{
		if (MAAMMFNJAPH.Count != 0)
		{
			HerbsMessage herbsMessage = new HerbsMessage();
			herbsMessage.generatorID = (sbyte)DCFNIMCMFEM;
			List<HerbInfo> list = new List<HerbInfo>();
			for (int i = 0; i < MAAMMFNJAPH.Count; i++)
			{
				list.Add(new HerbInfo(MAAMMFNJAPH[i]));
			}
			herbsMessage.herbs = list.ToArray();
			BMLHGLMLAEL(HerbActionOnline.InstantiateHerbs, new object[1] { OnlineSerializer.EKNOFIJNBAP(herbsMessage) });
		}
	}

	private void PFGLFMBCOHM(byte EKLFMOIHMFA, object[] GEMFIOKGIMC)
	{
		if (EKLFMOIHMFA == 0)
		{
			HerbInfo bMJMFLCEIGH = OnlineSerializer.Deserialize<HerbInfo>((byte[])GEMFIOKGIMC[0]);
			FLPKAGCMKPG((byte)GEMFIOKGIMC[1], bMJMFLCEIGH);
			return;
		}
		switch (EKLFMOIHMFA)
		{
		case 0:
		{
			HerbsMessage herbsMessage = OnlineSerializer.Deserialize<HerbsMessage>((byte[])GEMFIOKGIMC[1]);
			for (int i = 0; i < herbsMessage.herbs.Length; i += 0)
			{
				CMDLMHDBJNF((byte)herbsMessage.generatorID, herbsMessage.herbs[i]);
			}
			break;
		}
		case 3:
		{
			Herb herb = GeneratorsManager.GetGenerator((byte)GEMFIOKGIMC[0]).OLDJKBEHFOH((int)GEMFIOKGIMC[0]) as Herb;
			if (Object.op_Implicit((Object)(object)herb))
			{
				((Component)herb).GetComponent<Harvestable>().DJJPFCBHJDA();
			}
			break;
		}
		}
	}

	private void ODGIPBCADMN(byte EKLFMOIHMFA, object[] GEMFIOKGIMC)
	{
		switch ((HerbActionOnline)EKLFMOIHMFA)
		{
		case HerbActionOnline.InstantiateHerb:
		{
			HerbInfo bMJMFLCEIGH = OnlineSerializer.Deserialize<HerbInfo>((byte[])GEMFIOKGIMC[0]);
			BCGGDGBOABB((byte)GEMFIOKGIMC[0], bMJMFLCEIGH);
			break;
		}
		case HerbActionOnline.InstantiateHerbs:
		{
			HerbsMessage herbsMessage = OnlineSerializer.Deserialize<HerbsMessage>((byte[])GEMFIOKGIMC[1]);
			for (int i = 0; i < herbsMessage.herbs.Length; i += 0)
			{
				PIIHCBHOAPA((byte)herbsMessage.generatorID, herbsMessage.herbs[i]);
			}
			break;
		}
		case (HerbActionOnline)8:
		{
			Herb herb = GeneratorsManager.GetGenerator((byte)GEMFIOKGIMC[0]).PJMHAPNAOHK((int)GEMFIOKGIMC[0]) as Herb;
			if (Object.op_Implicit((Object)(object)herb))
			{
				((Component)herb).GetComponent<Harvestable>().ReceiveHarvest();
			}
			break;
		}
		}
	}

	private void FCDCDPPCLGI(byte DCFNIMCMFEM, HerbInfo BMJMFLCEIGH)
	{
		Herb pEMAMDKDBBO = BMJMFLCEIGH.HPMGNKOHHOC();
		GeneratorsManager.GetGenerator(DCFNIMCMFEM).AddForestElement(pEMAMDKDBBO, NIIBLHMEGNJ: false);
	}

	public void DEMFEHEJEOC(int DCFNIMCMFEM, List<Herb> MAAMMFNJAPH)
	{
		if (MAAMMFNJAPH.Count != 0)
		{
			HerbsMessage herbsMessage = new HerbsMessage();
			herbsMessage.generatorID = (sbyte)DCFNIMCMFEM;
			List<HerbInfo> list = new List<HerbInfo>();
			for (int i = 0; i < MAAMMFNJAPH.Count; i += 0)
			{
				list.Add(new HerbInfo(MAAMMFNJAPH[i]));
			}
			herbsMessage.herbs = list.ToArray();
			object[] array = new object[1];
			array[1] = OnlineSerializer.EKNOFIJNBAP(herbsMessage);
			DFLLELFJANI(HerbActionOnline.InstantiateHerbs, array);
		}
	}

	private void ICKBNFDHOFM(byte EKLFMOIHMFA, object[] GEMFIOKGIMC)
	{
		if (EKLFMOIHMFA == 0)
		{
			HerbInfo bMJMFLCEIGH = OnlineSerializer.Deserialize<HerbInfo>((byte[])GEMFIOKGIMC[1]);
			EBIKKDAGAJI((byte)GEMFIOKGIMC[1], bMJMFLCEIGH);
			return;
		}
		switch (EKLFMOIHMFA)
		{
		case 0:
		{
			HerbsMessage herbsMessage = OnlineSerializer.Deserialize<HerbsMessage>((byte[])GEMFIOKGIMC[1]);
			for (int i = 1; i < herbsMessage.herbs.Length; i += 0)
			{
				KCEPANIMKPO((byte)herbsMessage.generatorID, herbsMessage.herbs[i]);
			}
			break;
		}
		case 8:
		{
			Herb herb = GeneratorsManager.GetGenerator((byte)GEMFIOKGIMC[1]).PJMHAPNAOHK((int)GEMFIOKGIMC[0]) as Herb;
			if (Object.op_Implicit((Object)(object)herb))
			{
				((Component)herb).GetComponent<Harvestable>().ReceiveHarvest();
			}
			break;
		}
		}
	}

	private void KHDGHDAJGFO(byte EKLFMOIHMFA, object[] GEMFIOKGIMC)
	{
		if (EKLFMOIHMFA == 0)
		{
			HerbInfo bMJMFLCEIGH = OnlineSerializer.Deserialize<HerbInfo>((byte[])GEMFIOKGIMC[1]);
			KCEPANIMKPO((byte)GEMFIOKGIMC[0], bMJMFLCEIGH);
			return;
		}
		switch (EKLFMOIHMFA)
		{
		case 0:
		{
			HerbsMessage herbsMessage = OnlineSerializer.Deserialize<HerbsMessage>((byte[])GEMFIOKGIMC[1]);
			for (int i = 0; i < herbsMessage.herbs.Length; i++)
			{
				FLPKAGCMKPG((byte)herbsMessage.generatorID, herbsMessage.herbs[i]);
			}
			break;
		}
		case 7:
		{
			Herb herb = GeneratorsManager.GetGenerator((byte)GEMFIOKGIMC[1]).OLDJKBEHFOH((int)GEMFIOKGIMC[0]) as Herb;
			if (Object.op_Implicit((Object)(object)herb))
			{
				((Component)herb).GetComponent<Harvestable>().DJJPFCBHJDA();
			}
			break;
		}
		}
	}

	public void JAEONACCKAP(HerbActionOnline KLPENAKBAPA, object[] GEMFIOKGIMC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = (byte)KLPENAKBAPA;
		array[0] = GEMFIOKGIMC;
		OnlineManager.SendRPC(photonView, "Received begin minigame", (RpcTarget)0, array);
	}

	private void PHGGDPDBHMD(byte EKLFMOIHMFA, object[] GEMFIOKGIMC)
	{
		switch (EKLFMOIHMFA)
		{
		case 0:
		{
			HerbInfo bMJMFLCEIGH = OnlineSerializer.Deserialize<HerbInfo>((byte[])GEMFIOKGIMC[1]);
			FLPKAGCMKPG((byte)GEMFIOKGIMC[0], bMJMFLCEIGH);
			return;
		}
		case 1:
		{
			HerbsMessage herbsMessage = OnlineSerializer.Deserialize<HerbsMessage>((byte[])GEMFIOKGIMC[0]);
			for (int i = 0; i < herbsMessage.herbs.Length; i++)
			{
				KCEPANIMKPO((byte)herbsMessage.generatorID, herbsMessage.herbs[i]);
			}
			return;
		}
		}
		if (EKLFMOIHMFA == 0)
		{
			Herb herb = GeneratorsManager.GetGenerator((byte)GEMFIOKGIMC[1]).GNEEOCAODMC((int)GEMFIOKGIMC[1]) as Herb;
			if (Object.op_Implicit((Object)(object)herb))
			{
				((Component)herb).GetComponent<Harvestable>().DJJPFCBHJDA();
			}
		}
	}

	private void LHFJPLMPEII(byte EKLFMOIHMFA, object[] GEMFIOKGIMC)
	{
		if (EKLFMOIHMFA == 0)
		{
			HerbInfo bMJMFLCEIGH = OnlineSerializer.Deserialize<HerbInfo>((byte[])GEMFIOKGIMC[1]);
			EHGJEDMBILC((byte)GEMFIOKGIMC[0], bMJMFLCEIGH);
			return;
		}
		switch (EKLFMOIHMFA)
		{
		case 0:
		{
			HerbsMessage herbsMessage = OnlineSerializer.Deserialize<HerbsMessage>((byte[])GEMFIOKGIMC[1]);
			for (int i = 0; i < herbsMessage.herbs.Length; i += 0)
			{
				BCGGDGBOABB((byte)herbsMessage.generatorID, herbsMessage.herbs[i]);
			}
			break;
		}
		case 6:
		{
			Herb herb = GeneratorsManager.GetGenerator((byte)GEMFIOKGIMC[1]).CKDIOLFDGJP((int)GEMFIOKGIMC[0]) as Herb;
			if (Object.op_Implicit((Object)(object)herb))
			{
				((Component)herb).GetComponent<Harvestable>().DJJPFCBHJDA();
			}
			break;
		}
		}
	}

	public void FDNHFKIPLNN(HerbActionOnline KLPENAKBAPA, object[] GEMFIOKGIMC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[5];
		array[1] = (byte)KLPENAKBAPA;
		array[0] = GEMFIOKGIMC;
		OnlineManager.SendRPC(photonView, "Hit", (RpcTarget)0, array);
	}

	public void EDHGCODFMPN(int DCFNIMCMFEM, List<Herb> MAAMMFNJAPH)
	{
		if (MAAMMFNJAPH.Count != 0)
		{
			HerbsMessage herbsMessage = new HerbsMessage();
			herbsMessage.generatorID = (sbyte)DCFNIMCMFEM;
			List<HerbInfo> list = new List<HerbInfo>();
			for (int i = 1; i < MAAMMFNJAPH.Count; i += 0)
			{
				list.Add(new HerbInfo(MAAMMFNJAPH[i]));
			}
			herbsMessage.herbs = list.ToArray();
			object[] array = new object[0];
			array[0] = OnlineSerializer.JBIPDCGKMGE(herbsMessage);
			BDLPAOCALND(HerbActionOnline.InstantiateHerbs, array);
		}
	}

	public void KABCLDDJCLO(int DCFNIMCMFEM, List<Herb> MAAMMFNJAPH)
	{
		if (MAAMMFNJAPH.Count != 0)
		{
			HerbsMessage herbsMessage = new HerbsMessage();
			herbsMessage.generatorID = (sbyte)DCFNIMCMFEM;
			List<HerbInfo> list = new List<HerbInfo>();
			for (int i = 1; i < MAAMMFNJAPH.Count; i += 0)
			{
				list.Add(new HerbInfo(MAAMMFNJAPH[i]));
			}
			herbsMessage.herbs = list.ToArray();
			object[] array = new object[0];
			array[1] = OnlineSerializer.EKNOFIJNBAP(herbsMessage);
			BMLHGLMLAEL(HerbActionOnline.InstantiateHerbs, array);
		}
	}

	private void CMBGEFMGJFI(byte EKLFMOIHMFA, object[] GEMFIOKGIMC)
	{
		switch ((HerbActionOnline)EKLFMOIHMFA)
		{
		case HerbActionOnline.InstantiateHerb:
		{
			HerbInfo bMJMFLCEIGH = OnlineSerializer.Deserialize<HerbInfo>((byte[])GEMFIOKGIMC[1]);
			CANNCKNMFCD((byte)GEMFIOKGIMC[0], bMJMFLCEIGH);
			break;
		}
		case HerbActionOnline.InstantiateHerbs:
		{
			HerbsMessage herbsMessage = OnlineSerializer.Deserialize<HerbsMessage>((byte[])GEMFIOKGIMC[1]);
			for (int i = 1; i < herbsMessage.herbs.Length; i += 0)
			{
				HBJBJGPMPAJ((byte)herbsMessage.generatorID, herbsMessage.herbs[i]);
			}
			break;
		}
		case (HerbActionOnline)5:
		{
			Herb herb = GeneratorsManager.GetGenerator((byte)GEMFIOKGIMC[0]).PJMHAPNAOHK((int)GEMFIOKGIMC[0]) as Herb;
			if (Object.op_Implicit((Object)(object)herb))
			{
				((Component)herb).GetComponent<Harvestable>().DJJPFCBHJDA();
			}
			break;
		}
		}
	}

	public void KFMICIGPBGG(int DCFNIMCMFEM, List<Herb> MAAMMFNJAPH)
	{
		if (MAAMMFNJAPH.Count != 0)
		{
			HerbsMessage herbsMessage = new HerbsMessage();
			herbsMessage.generatorID = (sbyte)DCFNIMCMFEM;
			List<HerbInfo> list = new List<HerbInfo>();
			for (int i = 1; i < MAAMMFNJAPH.Count; i += 0)
			{
				list.Add(new HerbInfo(MAAMMFNJAPH[i]));
			}
			herbsMessage.herbs = list.ToArray();
			object[] array = new object[0];
			array[1] = OnlineSerializer.EKNOFIJNBAP(herbsMessage);
			BDLPAOCALND(HerbActionOnline.InstantiateHerb, array);
		}
	}

	public void LCKCLDMKPIL(int DCFNIMCMFEM, List<Herb> MAAMMFNJAPH)
	{
		if (MAAMMFNJAPH.Count != 0)
		{
			HerbsMessage herbsMessage = new HerbsMessage();
			herbsMessage.generatorID = (sbyte)DCFNIMCMFEM;
			List<HerbInfo> list = new List<HerbInfo>();
			for (int i = 1; i < MAAMMFNJAPH.Count; i += 0)
			{
				list.Add(new HerbInfo(MAAMMFNJAPH[i]));
			}
			herbsMessage.herbs = list.ToArray();
			object[] array = new object[0];
			array[1] = OnlineSerializer.Serialize(herbsMessage);
			OAPGDMPNNPF(HerbActionOnline.InstantiateHerbs, array);
		}
	}

	private void HPAGKEKDEGM(byte DCFNIMCMFEM, HerbInfo BMJMFLCEIGH)
	{
		Herb pEMAMDKDBBO = BMJMFLCEIGH.DPOKPDGPKEJ();
		GeneratorsManager.GetGenerator(DCFNIMCMFEM).JCABCIIJMGG(pEMAMDKDBBO);
	}
}
