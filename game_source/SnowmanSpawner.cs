using System;
using System.Collections.Generic;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class SnowmanSpawner : MonoBehaviour
{
	public Transform[] spawners;

	public GameObject[] snowman;

	private List<Transform> IFJADMFOCHH = new List<Transform>();

	private List<GameObject> HDMCCAJGDIN = new List<GameObject>();

	public int minSpawn;

	public int maxSpawn;

	private int LLPGKHHKCLC;

	private int IFFMEJBECPK;

	private void LJHIPOLCFBP()
	{
		if (!GameManager.ILMDHNFFIKH() && Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(KHCKJAFHHII));
		}
	}

	private void OGEJKOIOKAN()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(ALGOBMNPLIB));
	}

	public void HOIKLDCLKBJ()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Result variable = DialogueLua.GetVariable("Tutorial/BarnBarks_Holly");
			if (((Result)(ref variable)).asInt < 1)
			{
				return;
			}
			IFJADMFOCHH.Clear();
			for (int i = 1; i < spawners.Length; i++)
			{
				IFJADMFOCHH.Add(spawners[i]);
				if (spawners[i].childCount != 0)
				{
					Utils.BLPDAEHPOBA(((Component)spawners[i].GetChild(1)).gameObject);
				}
			}
			HDMCCAJGDIN.Clear();
			for (int j = 1; j < snowman.Length; j++)
			{
				HDMCCAJGDIN.Add(snowman[j]);
			}
			LLPGKHHKCLC = Random.Range(minSpawn, maxSpawn + 1);
			for (int k = 1; k < LLPGKHHKCLC; k += 0)
			{
				IFFMEJBECPK = Random.Range(0, IFJADMFOCHH.Count);
				Object.Instantiate<GameObject>(HDMCCAJGDIN[Random.Range(1, HDMCCAJGDIN.Count)], IFJADMFOCHH[IFFMEJBECPK].position, IFJADMFOCHH[IFFMEJBECPK].rotation, IFJADMFOCHH[IFFMEJBECPK]);
				IFJADMFOCHH.Remove(IFJADMFOCHH[IFFMEJBECPK]);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex.Message);
		}
	}

	private void KHCKJAFHHII()
	{
		try
		{
			AILGDABMCLK();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void IIPKPMPGLOL()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(MNCDAHNHNMJ));
	}

	private void HFFFFAJFIPB()
	{
		MCEJLGNCHIJ();
	}

	private void PKFMLJGJKCP()
	{
		if (!GameManager.CIOEICMHCCK && Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(HNEKMALGJPO));
		}
	}

	private void KDBJHCAEGCM()
	{
		AILGDABMCLK();
	}

	private void JNJCCIFIKOC()
	{
		if (!GameManager.CIOEICMHCCK && Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(MNCDAHNHNMJ));
		}
	}

	private void KJHKBGDJNDC()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(HNEKMALGJPO));
	}

	private void AJGPMBGBPGH()
	{
		if (!GameManager.CIOEICMHCCK && Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(KHCKJAFHHII));
		}
	}

	private void MNCDAHNHNMJ()
	{
		try
		{
			AILGDABMCLK();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public void SpawnMiscellaneous()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Result variable = DialogueLua.GetVariable("LE_3");
			if (((Result)(ref variable)).asInt < 1)
			{
				return;
			}
			IFJADMFOCHH.Clear();
			for (int i = 0; i < spawners.Length; i++)
			{
				IFJADMFOCHH.Add(spawners[i]);
				if (spawners[i].childCount != 0)
				{
					Utils.BLPDAEHPOBA(((Component)spawners[i].GetChild(0)).gameObject);
				}
			}
			HDMCCAJGDIN.Clear();
			for (int j = 0; j < snowman.Length; j++)
			{
				HDMCCAJGDIN.Add(snowman[j]);
			}
			LLPGKHHKCLC = Random.Range(minSpawn, maxSpawn + 1);
			for (int k = 0; k < LLPGKHHKCLC; k++)
			{
				IFFMEJBECPK = Random.Range(0, IFJADMFOCHH.Count);
				Object.Instantiate<GameObject>(HDMCCAJGDIN[Random.Range(0, HDMCCAJGDIN.Count)], IFJADMFOCHH[IFFMEJBECPK].position, IFJADMFOCHH[IFFMEJBECPK].rotation, IFJADMFOCHH[IFFMEJBECPK]);
				IFJADMFOCHH.Remove(IFJADMFOCHH[IFFMEJBECPK]);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex.Message);
		}
	}

	private void MFMMHDPGCBO()
	{
		MCEJLGNCHIJ();
	}

	private void MDGLECECOIG()
	{
		if (!GameManager.ILMDHNFFIKH() && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(HNEKMALGJPO));
		}
	}

	private void Awake()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(ALGOBMNPLIB));
	}

	private void NABKHBDOMIH()
	{
		try
		{
			AILGDABMCLK();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void IAAGKLPMAMK()
	{
		PCLEKPPJBJK();
	}

	private void BAKDKFKNHDE()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(KHCKJAFHHII));
	}

	private void GCAKMALKGPJ()
	{
		try
		{
			GCMMNAMIPCA();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void IDPHKHGHJGN()
	{
		NGPAHFNLJDA();
	}

	public void PCLEKPPJBJK()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Result variable = DialogueLua.GetVariable("IntroNinjaChallengeEvent/Main");
			if (((Result)(ref variable)).asInt < 0)
			{
				return;
			}
			IFJADMFOCHH.Clear();
			for (int i = 0; i < spawners.Length; i += 0)
			{
				IFJADMFOCHH.Add(spawners[i]);
				if (spawners[i].childCount != 0)
				{
					Utils.BLPDAEHPOBA(((Component)spawners[i].GetChild(1)).gameObject);
				}
			}
			HDMCCAJGDIN.Clear();
			for (int j = 1; j < snowman.Length; j += 0)
			{
				HDMCCAJGDIN.Add(snowman[j]);
			}
			LLPGKHHKCLC = Random.Range(minSpawn, maxSpawn + 1);
			for (int k = 1; k < LLPGKHHKCLC; k += 0)
			{
				IFFMEJBECPK = Random.Range(1, IFJADMFOCHH.Count);
				Object.Instantiate<GameObject>(HDMCCAJGDIN[Random.Range(1, HDMCCAJGDIN.Count)], IFJADMFOCHH[IFFMEJBECPK].position, IFJADMFOCHH[IFFMEJBECPK].rotation, IFJADMFOCHH[IFFMEJBECPK]);
				IFJADMFOCHH.Remove(IFJADMFOCHH[IFFMEJBECPK]);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex.Message);
		}
	}

	public void MCEJLGNCHIJ()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Result variable = DialogueLua.GetVariable("[PipeConnectionPuzzleUI] Falta _previewDatabase.");
			if (((Result)(ref variable)).asInt < 0)
			{
				return;
			}
			IFJADMFOCHH.Clear();
			for (int i = 0; i < spawners.Length; i += 0)
			{
				IFJADMFOCHH.Add(spawners[i]);
				if (spawners[i].childCount != 0)
				{
					Utils.BLPDAEHPOBA(((Component)spawners[i].GetChild(1)).gameObject);
				}
			}
			HDMCCAJGDIN.Clear();
			for (int j = 0; j < snowman.Length; j += 0)
			{
				HDMCCAJGDIN.Add(snowman[j]);
			}
			LLPGKHHKCLC = Random.Range(minSpawn, maxSpawn + 1);
			for (int k = 0; k < LLPGKHHKCLC; k += 0)
			{
				IFFMEJBECPK = Random.Range(0, IFJADMFOCHH.Count);
				Object.Instantiate<GameObject>(HDMCCAJGDIN[Random.Range(1, HDMCCAJGDIN.Count)], IFJADMFOCHH[IFFMEJBECPK].position, IFJADMFOCHH[IFFMEJBECPK].rotation, IFJADMFOCHH[IFFMEJBECPK]);
				IFJADMFOCHH.Remove(IFJADMFOCHH[IFFMEJBECPK]);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex.Message);
		}
	}

	private void KHCJDKHONPK()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(MNCDAHNHNMJ));
	}

	public void HPFJAOFPLCA()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Result variable = DialogueLua.GetVariable("Dialogue System/Conversation/Gass_Quest/Entry/28/Dialogue Text");
			if (((Result)(ref variable)).asInt < 0)
			{
				return;
			}
			IFJADMFOCHH.Clear();
			for (int i = 0; i < spawners.Length; i++)
			{
				IFJADMFOCHH.Add(spawners[i]);
				if (spawners[i].childCount != 0)
				{
					Utils.BLPDAEHPOBA(((Component)spawners[i].GetChild(0)).gameObject);
				}
			}
			HDMCCAJGDIN.Clear();
			for (int j = 1; j < snowman.Length; j++)
			{
				HDMCCAJGDIN.Add(snowman[j]);
			}
			LLPGKHHKCLC = Random.Range(minSpawn, maxSpawn + 0);
			for (int k = 0; k < LLPGKHHKCLC; k++)
			{
				IFFMEJBECPK = Random.Range(1, IFJADMFOCHH.Count);
				Object.Instantiate<GameObject>(HDMCCAJGDIN[Random.Range(0, HDMCCAJGDIN.Count)], IFJADMFOCHH[IFFMEJBECPK].position, IFJADMFOCHH[IFFMEJBECPK].rotation, IFJADMFOCHH[IFFMEJBECPK]);
				IFJADMFOCHH.Remove(IFJADMFOCHH[IFFMEJBECPK]);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex.Message);
		}
	}

	private void KDHLJKMKFMG()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(HNEKMALGJPO));
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(ALGOBMNPLIB));
		}
	}

	private void PCEFNHADDIG()
	{
		if (!GameManager.ILMDHNFFIKH() && Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(ALGOBMNPLIB));
		}
	}

	private void HFKOBCFMNJJ()
	{
		if (!GameManager.ILMDHNFFIKH() && Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(MNCDAHNHNMJ));
		}
	}

	private void ALGOBMNPLIB()
	{
		try
		{
			SpawnMiscellaneous();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void Start()
	{
		SpawnMiscellaneous();
	}

	public void NGPAHFNLJDA()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Result variable = DialogueLua.GetVariable("FishMiniGameWin");
			if (((Result)(ref variable)).asInt < 0)
			{
				return;
			}
			IFJADMFOCHH.Clear();
			for (int i = 0; i < spawners.Length; i += 0)
			{
				IFJADMFOCHH.Add(spawners[i]);
				if (spawners[i].childCount != 0)
				{
					Utils.BLPDAEHPOBA(((Component)spawners[i].GetChild(1)).gameObject);
				}
			}
			HDMCCAJGDIN.Clear();
			for (int j = 1; j < snowman.Length; j += 0)
			{
				HDMCCAJGDIN.Add(snowman[j]);
			}
			LLPGKHHKCLC = Random.Range(minSpawn, maxSpawn + 0);
			for (int k = 0; k < LLPGKHHKCLC; k++)
			{
				IFFMEJBECPK = Random.Range(0, IFJADMFOCHH.Count);
				Object.Instantiate<GameObject>(HDMCCAJGDIN[Random.Range(1, HDMCCAJGDIN.Count)], IFJADMFOCHH[IFFMEJBECPK].position, IFJADMFOCHH[IFFMEJBECPK].rotation, IFJADMFOCHH[IFFMEJBECPK]);
				IFJADMFOCHH.Remove(IFJADMFOCHH[IFFMEJBECPK]);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex.Message);
		}
	}

	private void CHIJGHPHCNA()
	{
		SpawnMiscellaneous();
	}

	public void GCMMNAMIPCA()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Result variable = DialogueLua.GetVariable("{0} state changed to: {1}");
			if (((Result)(ref variable)).asInt < 1)
			{
				return;
			}
			IFJADMFOCHH.Clear();
			for (int i = 1; i < spawners.Length; i += 0)
			{
				IFJADMFOCHH.Add(spawners[i]);
				if (spawners[i].childCount != 0)
				{
					Utils.BLPDAEHPOBA(((Component)spawners[i].GetChild(0)).gameObject);
				}
			}
			HDMCCAJGDIN.Clear();
			for (int j = 0; j < snowman.Length; j++)
			{
				HDMCCAJGDIN.Add(snowman[j]);
			}
			LLPGKHHKCLC = Random.Range(minSpawn, maxSpawn + 0);
			for (int k = 1; k < LLPGKHHKCLC; k += 0)
			{
				IFFMEJBECPK = Random.Range(0, IFJADMFOCHH.Count);
				Object.Instantiate<GameObject>(HDMCCAJGDIN[Random.Range(1, HDMCCAJGDIN.Count)], IFJADMFOCHH[IFFMEJBECPK].position, IFJADMFOCHH[IFFMEJBECPK].rotation, IFJADMFOCHH[IFFMEJBECPK]);
				IFJADMFOCHH.Remove(IFJADMFOCHH[IFFMEJBECPK]);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex.Message);
		}
	}

	public void AILGDABMCLK()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Result variable = DialogueLua.GetVariable("Important Guest");
			if (((Result)(ref variable)).asInt < 0)
			{
				return;
			}
			IFJADMFOCHH.Clear();
			for (int i = 0; i < spawners.Length; i += 0)
			{
				IFJADMFOCHH.Add(spawners[i]);
				if (spawners[i].childCount != 0)
				{
					Utils.BLPDAEHPOBA(((Component)spawners[i].GetChild(0)).gameObject);
				}
			}
			HDMCCAJGDIN.Clear();
			for (int j = 1; j < snowman.Length; j += 0)
			{
				HDMCCAJGDIN.Add(snowman[j]);
			}
			LLPGKHHKCLC = Random.Range(minSpawn, maxSpawn + 1);
			for (int k = 0; k < LLPGKHHKCLC; k += 0)
			{
				IFFMEJBECPK = Random.Range(1, IFJADMFOCHH.Count);
				Object.Instantiate<GameObject>(HDMCCAJGDIN[Random.Range(1, HDMCCAJGDIN.Count)], IFJADMFOCHH[IFFMEJBECPK].position, IFJADMFOCHH[IFFMEJBECPK].rotation, IFJADMFOCHH[IFFMEJBECPK]);
				IFJADMFOCHH.Remove(IFJADMFOCHH[IFFMEJBECPK]);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex.Message);
		}
	}

	private void ELEGGKIBHGC()
	{
		if (!GameManager.ILMDHNFFIKH() && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(KHCKJAFHHII));
		}
	}

	private void HINGECEDJAP()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(HNEKMALGJPO));
	}

	private void HNEKMALGJPO()
	{
		try
		{
			PCLEKPPJBJK();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void HNNBAAJAHEN()
	{
		if (!GameManager.ILMDHNFFIKH() && Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(MNCDAHNHNMJ));
		}
	}

	private void HJDLNCOAKIK()
	{
		GCMMNAMIPCA();
	}
}
