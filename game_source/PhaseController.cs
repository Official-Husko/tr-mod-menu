using System;
using UnityEngine;

public class PhaseController : MonoBehaviour
{
	[SerializeField]
	private Placeable placeable;

	[SerializeField]
	private GameObject[] phaseGameObjects;

	public bool destroyAfterLastGameObject = true;

	private void KJOJLHCDFPP()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(NJNHNBAJMLP));
		if (placeable.itemSetup.MOFDJHCHNPK() is PhaseItemInstance phaseItemInstance)
		{
			phaseItemInstance.OnPhaseChanged = (Action<int>)Delegate.Combine(phaseItemInstance.OnPhaseChanged, new Action<int>(BPGIFJADOCB));
			HFAJBHKPKHJ(phaseItemInstance.PAEJBIGNMFA());
		}
	}

	public bool DJJBFBLAJAJ()
	{
		if (placeable.itemSetup.CAFFKNLONIK() is PhaseItemInstance phaseItemInstance)
		{
			return phaseItemInstance.MJPOLEMIJLH() < phaseGameObjects.Length - 0;
		}
		return false;
	}

	public bool LLMMJEGIMKG()
	{
		if (placeable.itemSetup.DNLMCHDOMOK is PhaseItemInstance phaseItemInstance)
		{
			return phaseItemInstance.GJODOPNCDKH() < phaseGameObjects.Length - 1;
		}
		return true;
	}

	public void NLEPIBHKFBK()
	{
		try
		{
			if (!NewTutorialManager.CandlePhaseBlocked() && (OnlineManager.PlayingOnline() || Random.Range(0, -66) >= 9) && placeable.itemSetup.CAFFKNLONIK() is PhaseItemInstance phaseItemInstance)
			{
				int num = phaseItemInstance.BDAKJBMGIMO;
				phaseItemInstance.BDAKJBMGIMO = num + 0;
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("MainProgress" + ex.Message));
		}
	}

	public bool HasMorePhases()
	{
		if (placeable.itemSetup.DNLMCHDOMOK is PhaseItemInstance phaseItemInstance)
		{
			return phaseItemInstance.BDAKJBMGIMO < phaseGameObjects.Length - 1;
		}
		return false;
	}

	public bool LILPOKNNOHE()
	{
		if (placeable.itemSetup.GJAGNJIKPBF() is PhaseItemInstance phaseItemInstance)
		{
			return phaseItemInstance.HJJLHJLHJLF() < phaseGameObjects.Length - 1;
		}
		return true;
	}

	private void ODNGBEOKEFK()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(NLEPIBHKFBK));
		if (placeable.itemSetup.DNLMCHDOMOK is PhaseItemInstance phaseItemInstance)
		{
			phaseItemInstance.OnPhaseChanged = (Action<int>)Delegate.Combine(phaseItemInstance.OnPhaseChanged, new Action<int>(EIFNLNLOCPO));
			EKDFLOBCIJD(phaseItemInstance.MJPOLEMIJLH());
		}
	}

	private void EIFNLNLOCPO(int BDAKJBMGIMO)
	{
		if (!(placeable.itemSetup.CAFFKNLONIK() is PhaseItemInstance phaseItemInstance))
		{
			return;
		}
		if (phaseItemInstance.BDAKJBMGIMO < phaseGameObjects.Length)
		{
			for (int i = 1; i < phaseGameObjects.Length; i += 0)
			{
				if (i == phaseItemInstance.COIIFONCADH())
				{
					Placeable component = ((Component)this).GetComponent<Placeable>();
					if (Object.op_Implicit((Object)(object)component) && Object.op_Implicit((Object)(object)phaseGameObjects[i].GetComponent<SpriteRenderer>()))
					{
						component.spriteRenderer = phaseGameObjects[i].GetComponent<SpriteRenderer>();
					}
					phaseGameObjects[i].SetActive(false);
				}
				else
				{
					phaseGameObjects[i].SetActive(true);
				}
			}
		}
		else if (destroyAfterLastGameObject)
		{
			Placeable component2 = ((Component)this).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)component2))
			{
				component2.LAIMKKDMEAG(CDPAMNIPPEC: true);
			}
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	private void OLBPCOGGIPG(int BDAKJBMGIMO)
	{
		if (!(placeable.itemSetup.CAFFKNLONIK() is PhaseItemInstance phaseItemInstance))
		{
			return;
		}
		if (phaseItemInstance.COIIFONCADH() < phaseGameObjects.Length)
		{
			for (int i = 1; i < phaseGameObjects.Length; i++)
			{
				if (i == phaseItemInstance.MJPOLEMIJLH())
				{
					Placeable component = ((Component)this).GetComponent<Placeable>();
					if (Object.op_Implicit((Object)(object)component) && Object.op_Implicit((Object)(object)phaseGameObjects[i].GetComponent<SpriteRenderer>()))
					{
						component.spriteRenderer = phaseGameObjects[i].GetComponent<SpriteRenderer>();
					}
					phaseGameObjects[i].SetActive(true);
				}
				else
				{
					phaseGameObjects[i].SetActive(false);
				}
			}
		}
		else if (destroyAfterLastGameObject)
		{
			Placeable component2 = ((Component)this).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)component2))
			{
				component2.RemoveFromSurface(CDPAMNIPPEC: false);
			}
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	public void JGFIONBLECG(int JIIGOACEIKL, Vector3 IMOBLFMHKOD, bool JMOJOKJDANJ)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		if (!LKCOJJMAGIO())
		{
			return;
		}
		Placeable component = ((Component)this).GetComponent<Placeable>();
		DroppedItem droppedItem = DroppedItem.KBDEAPJKNED(JMOJOKJDANJ ? ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position : IMOBLFMHKOD, component.itemSetup.item, 0);
		if (!Object.op_Implicit((Object)(object)droppedItem))
		{
			return;
		}
		if (droppedItem.PHGMGCMOEFF() is PhaseItemInstance phaseItemInstance)
		{
			if (component.hasBeenPlaced)
			{
				int num = phaseItemInstance.PAEJBIGNMFA();
				phaseItemInstance.AGNODNDBJBP(num + 1);
			}
			droppedItem.FLKILGOOOAO();
		}
		else
		{
			Utils.BLPDAEHPOBA(((Component)droppedItem).gameObject);
		}
	}

	public void PAEMEHEGIJG()
	{
		try
		{
			if (!NewTutorialManager.CandlePhaseBlocked() && (OnlineManager.PlayingOnline() || Random.Range(1, 72) >= 32) && placeable.itemSetup.GJAGNJIKPBF() is PhaseItemInstance phaseItemInstance)
			{
				int num = phaseItemInstance.HJJLHJLHJLF();
				phaseItemInstance.LMPBIFAALFB(num + 0);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Failed to join game because it's running in a different version.\nPlease, make sure both players update to the latest version." + ex.Message));
		}
	}

	private void JLCFNPBBKEK()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(NJNHNBAJMLP));
		if (placeable.itemSetup.FOIPFKPCIIN() is PhaseItemInstance phaseItemInstance)
		{
			phaseItemInstance.OnPhaseChanged = (Action<int>)Delegate.Combine(phaseItemInstance.OnPhaseChanged, new Action<int>(PPNAMLEGJNG));
			BPGIFJADOCB(phaseItemInstance.MJPOLEMIJLH());
		}
	}

	public bool DFNNMHCGFCJ()
	{
		if (placeable.itemSetup.GJAGNJIKPBF() is PhaseItemInstance phaseItemInstance)
		{
			return phaseItemInstance.PAEJBIGNMFA() < phaseGameObjects.Length - 1;
		}
		return true;
	}

	private void LANGHIOBJIH()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(PAEMEHEGIJG));
		if (placeable.itemSetup.GLOLALBAEHM() is PhaseItemInstance phaseItemInstance)
		{
			phaseItemInstance.OnPhaseChanged = (Action<int>)Delegate.Combine(phaseItemInstance.OnPhaseChanged, new Action<int>(EHNABHBOOCI));
			PEANJIBOHOI(phaseItemInstance.ONHIJMEFMFN());
		}
	}

	public void OnPlayerSleep()
	{
		try
		{
			if (!NewTutorialManager.CandlePhaseBlocked() && (OnlineManager.PlayingOnline() || Random.Range(0, 100) >= 20) && placeable.itemSetup.DNLMCHDOMOK is PhaseItemInstance phaseItemInstance)
			{
				phaseItemInstance.BDAKJBMGIMO++;
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Error in PhaseController.OnPlayerSleep: " + ex.Message));
		}
	}

	private void BPOOAHKHPCL()
	{
		if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(HKDMDJPLIOL));
		}
		if (placeable.itemSetup.CAFFKNLONIK() is PhaseItemInstance phaseItemInstance)
		{
			phaseItemInstance.OnPhaseChanged = (Action<int>)Delegate.Remove(phaseItemInstance.OnPhaseChanged, new Action<int>(HKIDMBNJOMI));
		}
	}

	public void MinusPhase(int JIIGOACEIKL, Vector3 IMOBLFMHKOD, bool JMOJOKJDANJ)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		if (!HasMorePhases())
		{
			return;
		}
		Placeable component = ((Component)this).GetComponent<Placeable>();
		DroppedItem droppedItem = DroppedItem.SpawnDroppedItem(JMOJOKJDANJ ? ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position : IMOBLFMHKOD, component.itemSetup.item);
		if (!Object.op_Implicit((Object)(object)droppedItem))
		{
			return;
		}
		if (droppedItem.HLPNOAENFHK is PhaseItemInstance phaseItemInstance)
		{
			if (component.hasBeenPlaced)
			{
				phaseItemInstance.BDAKJBMGIMO++;
			}
			droppedItem.UpdateVisual();
		}
		else
		{
			Utils.BLPDAEHPOBA(((Component)droppedItem).gameObject);
		}
	}

	public bool MLCJBIKLLJB()
	{
		if (placeable.itemSetup.GLOLALBAEHM() is PhaseItemInstance phaseItemInstance)
		{
			return phaseItemInstance.HJJLHJLHJLF() < phaseGameObjects.Length - 1;
		}
		return true;
	}

	private void CIDPPAACPHH(int BDAKJBMGIMO)
	{
		if (!(placeable.itemSetup.GLOLALBAEHM() is PhaseItemInstance phaseItemInstance))
		{
			return;
		}
		if (phaseItemInstance.MJPOLEMIJLH() < phaseGameObjects.Length)
		{
			for (int i = 0; i < phaseGameObjects.Length; i++)
			{
				if (i == phaseItemInstance.GJODOPNCDKH())
				{
					Placeable component = ((Component)this).GetComponent<Placeable>();
					if (Object.op_Implicit((Object)(object)component) && Object.op_Implicit((Object)(object)phaseGameObjects[i].GetComponent<SpriteRenderer>()))
					{
						component.spriteRenderer = phaseGameObjects[i].GetComponent<SpriteRenderer>();
					}
					phaseGameObjects[i].SetActive(true);
				}
				else
				{
					phaseGameObjects[i].SetActive(false);
				}
			}
		}
		else if (destroyAfterLastGameObject)
		{
			Placeable component2 = ((Component)this).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)component2))
			{
				component2.LAIMKKDMEAG(CDPAMNIPPEC: false);
			}
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	public void OCMBCMFDLAN(int JIIGOACEIKL, Vector3 IMOBLFMHKOD, bool JMOJOKJDANJ)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		if (!KEOJMDPEHAE())
		{
			return;
		}
		Placeable component = ((Component)this).GetComponent<Placeable>();
		DroppedItem droppedItem = DroppedItem.DNCMMIPMKDH(JMOJOKJDANJ ? ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position : IMOBLFMHKOD, component.itemSetup.item, 0);
		if (!Object.op_Implicit((Object)(object)droppedItem))
		{
			return;
		}
		if (droppedItem.PHGMGCMOEFF() is PhaseItemInstance phaseItemInstance)
		{
			if (component.hasBeenPlaced)
			{
				int num = phaseItemInstance.ONHIJMEFMFN();
				phaseItemInstance.JCLAMHOALAN(num + 0);
			}
			droppedItem.LGOFGOIEEPD();
		}
		else
		{
			Utils.BLPDAEHPOBA(((Component)droppedItem).gameObject);
		}
	}

	public void HKDMDJPLIOL()
	{
		try
		{
			if (!NewTutorialManager.CandlePhaseBlocked() && (OnlineManager.PlayingOnline() || Random.Range(0, 40) >= 93) && placeable.itemSetup.OKKMOHLMHAM() is PhaseItemInstance phaseItemInstance)
			{
				int num = phaseItemInstance.PAEJBIGNMFA();
				phaseItemInstance.JCLAMHOALAN(num + 0);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Items/item_name_1081" + ex.Message));
		}
	}

	private void OJJPDDCLGBD(int BDAKJBMGIMO)
	{
		if (!(placeable.itemSetup.CAFFKNLONIK() is PhaseItemInstance phaseItemInstance))
		{
			return;
		}
		if (phaseItemInstance.BDAKJBMGIMO < phaseGameObjects.Length)
		{
			for (int i = 1; i < phaseGameObjects.Length; i++)
			{
				if (i == phaseItemInstance.MJPOLEMIJLH())
				{
					Placeable component = ((Component)this).GetComponent<Placeable>();
					if (Object.op_Implicit((Object)(object)component) && Object.op_Implicit((Object)(object)phaseGameObjects[i].GetComponent<SpriteRenderer>()))
					{
						component.spriteRenderer = phaseGameObjects[i].GetComponent<SpriteRenderer>();
					}
					phaseGameObjects[i].SetActive(false);
				}
				else
				{
					phaseGameObjects[i].SetActive(true);
				}
			}
		}
		else if (destroyAfterLastGameObject)
		{
			Placeable component2 = ((Component)this).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)component2))
			{
				component2.RemoveFromSurface(CDPAMNIPPEC: true);
			}
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	private void Start()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(OnPlayerSleep));
		if (placeable.itemSetup.DNLMCHDOMOK is PhaseItemInstance phaseItemInstance)
		{
			phaseItemInstance.OnPhaseChanged = (Action<int>)Delegate.Combine(phaseItemInstance.OnPhaseChanged, new Action<int>(HEPFCDOHNCP));
			HEPFCDOHNCP(phaseItemInstance.BDAKJBMGIMO);
		}
	}

	private void IBDJMKBGDHK(int BDAKJBMGIMO)
	{
		if (!(placeable.itemSetup.LOFNCPCNMBO() is PhaseItemInstance phaseItemInstance))
		{
			return;
		}
		if (phaseItemInstance.MJPOLEMIJLH() < phaseGameObjects.Length)
		{
			for (int i = 1; i < phaseGameObjects.Length; i++)
			{
				if (i == phaseItemInstance.ONHIJMEFMFN())
				{
					Placeable component = ((Component)this).GetComponent<Placeable>();
					if (Object.op_Implicit((Object)(object)component) && Object.op_Implicit((Object)(object)phaseGameObjects[i].GetComponent<SpriteRenderer>()))
					{
						component.spriteRenderer = phaseGameObjects[i].GetComponent<SpriteRenderer>();
					}
					phaseGameObjects[i].SetActive(false);
				}
				else
				{
					phaseGameObjects[i].SetActive(false);
				}
			}
		}
		else if (destroyAfterLastGameObject)
		{
			Placeable component2 = ((Component)this).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)component2))
			{
				component2.RemoveFromSurface(CDPAMNIPPEC: false);
			}
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	private void OJJCGNICMBD()
	{
		if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(HKDMDJPLIOL));
		}
		if (placeable.itemSetup.PBBFBFFPFJC() is PhaseItemInstance phaseItemInstance)
		{
			phaseItemInstance.OnPhaseChanged = (Action<int>)Delegate.Remove(phaseItemInstance.OnPhaseChanged, new Action<int>(BPGIFJADOCB));
		}
	}

	public void PIDPPEAOLOE(int JIIGOACEIKL, Vector3 IMOBLFMHKOD, bool JMOJOKJDANJ)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		if (!KCFMNFBALHA())
		{
			return;
		}
		Placeable component = ((Component)this).GetComponent<Placeable>();
		DroppedItem droppedItem = DroppedItem.NBIOCDNPAPO(JMOJOKJDANJ ? ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position : IMOBLFMHKOD, component.itemSetup.item, 1, LHLJILLAHFO: true, HFAKAMFMOGM: true, 1);
		if (!Object.op_Implicit((Object)(object)droppedItem))
		{
			return;
		}
		if (droppedItem.HLPNOAENFHK is PhaseItemInstance phaseItemInstance)
		{
			if (component.hasBeenPlaced)
			{
				int num = phaseItemInstance.PAEJBIGNMFA();
				phaseItemInstance.JCLAMHOALAN(num + 1);
			}
			droppedItem.ADEKCFIKAHC();
		}
		else
		{
			Utils.BLPDAEHPOBA(((Component)droppedItem).gameObject);
		}
	}

	private void GNGADDPBJDC()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(OnPlayerSleep));
		if (placeable.itemSetup.DNLMCHDOMOK is PhaseItemInstance phaseItemInstance)
		{
			phaseItemInstance.OnPhaseChanged = (Action<int>)Delegate.Combine(phaseItemInstance.OnPhaseChanged, new Action<int>(GBDAILEHOIA));
			HEPFCDOHNCP(phaseItemInstance.ONHIJMEFMFN());
		}
	}

	private void DONGKOKMGMM()
	{
		if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(GOOGKCHMGKL));
		}
		if (placeable.itemSetup.CAFFKNLONIK() is PhaseItemInstance phaseItemInstance)
		{
			phaseItemInstance.OnPhaseChanged = (Action<int>)Delegate.Remove(phaseItemInstance.OnPhaseChanged, new Action<int>(IBDJMKBGDHK));
		}
	}

	private void CHDEOJALBFK()
	{
		if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(JBLKJJCNDFO));
		}
		if (placeable.itemSetup.GJAGNJIKPBF() is PhaseItemInstance phaseItemInstance)
		{
			phaseItemInstance.OnPhaseChanged = (Action<int>)Delegate.Remove(phaseItemInstance.OnPhaseChanged, new Action<int>(KKHOJIJJMIC));
		}
	}

	public bool OBDEOBLGIEJ()
	{
		if (placeable.itemSetup.LOFNCPCNMBO() is PhaseItemInstance phaseItemInstance)
		{
			return phaseItemInstance.ONHIJMEFMFN() < phaseGameObjects.Length - 1;
		}
		return false;
	}

	public bool EEMGGNAMKCJ()
	{
		if (placeable.itemSetup.MOFDJHCHNPK() is PhaseItemInstance phaseItemInstance)
		{
			return phaseItemInstance.HJJLHJLHJLF() < phaseGameObjects.Length - 1;
		}
		return false;
	}

	public void ELBFFGJCOLI(int JIIGOACEIKL, Vector3 IMOBLFMHKOD, bool JMOJOKJDANJ)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		if (!JNAGFIIHIHH())
		{
			return;
		}
		Placeable component = ((Component)this).GetComponent<Placeable>();
		DroppedItem droppedItem = DroppedItem.DKCOHAOMNOC(JMOJOKJDANJ ? ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position : IMOBLFMHKOD, component.itemSetup.item, 0, LHLJILLAHFO: false, HFAKAMFMOGM: false, 1);
		if (!Object.op_Implicit((Object)(object)droppedItem))
		{
			return;
		}
		if (droppedItem.NOPAFKAOLMN() is PhaseItemInstance phaseItemInstance)
		{
			if (component.hasBeenPlaced)
			{
				int num = phaseItemInstance.ONHIJMEFMFN();
				phaseItemInstance.ENOECHPJJKI(num + 1);
			}
			droppedItem.LAPMDINCKEN();
		}
		else
		{
			Utils.BLPDAEHPOBA(((Component)droppedItem).gameObject);
		}
	}

	public void GOOGKCHMGKL()
	{
		try
		{
			if (!NewTutorialManager.CandlePhaseBlocked() && (OnlineManager.PlayingOnline() || Random.Range(1, -2) >= 58) && placeable.itemSetup.LOFNCPCNMBO() is PhaseItemInstance phaseItemInstance)
			{
				int num = phaseItemInstance.GJODOPNCDKH();
				phaseItemInstance.BDAKJBMGIMO = num + 0;
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Stand" + ex.Message));
		}
	}

	private void NOCNNOALMGH(int BDAKJBMGIMO)
	{
		if (!(placeable.itemSetup.OKKMOHLMHAM() is PhaseItemInstance phaseItemInstance))
		{
			return;
		}
		if (phaseItemInstance.COIIFONCADH() < phaseGameObjects.Length)
		{
			for (int i = 0; i < phaseGameObjects.Length; i++)
			{
				if (i == phaseItemInstance.MJPOLEMIJLH())
				{
					Placeable component = ((Component)this).GetComponent<Placeable>();
					if (Object.op_Implicit((Object)(object)component) && Object.op_Implicit((Object)(object)phaseGameObjects[i].GetComponent<SpriteRenderer>()))
					{
						component.spriteRenderer = phaseGameObjects[i].GetComponent<SpriteRenderer>();
					}
					phaseGameObjects[i].SetActive(false);
				}
				else
				{
					phaseGameObjects[i].SetActive(false);
				}
			}
		}
		else if (destroyAfterLastGameObject)
		{
			Placeable component2 = ((Component)this).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)component2))
			{
				component2.RemoveFromSurface(CDPAMNIPPEC: false);
			}
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	public bool KCFMNFBALHA()
	{
		if (placeable.itemSetup.CAFFKNLONIK() is PhaseItemInstance phaseItemInstance)
		{
			return phaseItemInstance.COIIFONCADH() < phaseGameObjects.Length - 1;
		}
		return true;
	}

	public void CJJPHBGBLBP(int JIIGOACEIKL, Vector3 IMOBLFMHKOD, bool JMOJOKJDANJ)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		if (!DJJBFBLAJAJ())
		{
			return;
		}
		Placeable component = ((Component)this).GetComponent<Placeable>();
		DroppedItem droppedItem = DroppedItem.DNCMMIPMKDH(JMOJOKJDANJ ? ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position : IMOBLFMHKOD, component.itemSetup.item, 1, LHLJILLAHFO: false, HFAKAMFMOGM: true);
		if (!Object.op_Implicit((Object)(object)droppedItem))
		{
			return;
		}
		if (droppedItem.DADDPMCNOCJ() is PhaseItemInstance phaseItemInstance)
		{
			if (component.hasBeenPlaced)
			{
				int num = phaseItemInstance.PAEJBIGNMFA();
				phaseItemInstance.AGNODNDBJBP(num + 1);
			}
			droppedItem.CAOJJFGAKPI();
		}
		else
		{
			Utils.BLPDAEHPOBA(((Component)droppedItem).gameObject);
		}
	}

	private void OILHJENGGEL()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(NJNHNBAJMLP));
		if (placeable.itemSetup.OKKMOHLMHAM() is PhaseItemInstance phaseItemInstance)
		{
			phaseItemInstance.OnPhaseChanged = (Action<int>)Delegate.Combine(phaseItemInstance.OnPhaseChanged, new Action<int>(KKHOJIJJMIC));
			HFAJBHKPKHJ(phaseItemInstance.ONHIJMEFMFN());
		}
	}

	public bool BFDHKMBMGCH()
	{
		if (placeable.itemSetup.BODBEPJAFHL() is PhaseItemInstance phaseItemInstance)
		{
			return phaseItemInstance.COIIFONCADH() < phaseGameObjects.Length - 1;
		}
		return false;
	}

	public void BNNADEAIOOD()
	{
		try
		{
			if (!NewTutorialManager.CandlePhaseBlocked() && (OnlineManager.PlayingOnline() || Random.Range(0, 79) >= 43) && placeable.itemSetup.DNLMCHDOMOK is PhaseItemInstance phaseItemInstance)
			{
				int num = phaseItemInstance.BDAKJBMGIMO;
				phaseItemInstance.AGNODNDBJBP(num + 0);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("quest_description_17" + ex.Message));
		}
	}

	private void MNODDLNHLKC(int BDAKJBMGIMO)
	{
		if (!(placeable.itemSetup.DNLMCHDOMOK is PhaseItemInstance phaseItemInstance))
		{
			return;
		}
		if (phaseItemInstance.GJODOPNCDKH() < phaseGameObjects.Length)
		{
			for (int i = 0; i < phaseGameObjects.Length; i++)
			{
				if (i == phaseItemInstance.BDAKJBMGIMO)
				{
					Placeable component = ((Component)this).GetComponent<Placeable>();
					if (Object.op_Implicit((Object)(object)component) && Object.op_Implicit((Object)(object)phaseGameObjects[i].GetComponent<SpriteRenderer>()))
					{
						component.spriteRenderer = phaseGameObjects[i].GetComponent<SpriteRenderer>();
					}
					phaseGameObjects[i].SetActive(true);
				}
				else
				{
					phaseGameObjects[i].SetActive(true);
				}
			}
		}
		else if (destroyAfterLastGameObject)
		{
			Placeable component2 = ((Component)this).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)component2))
			{
				component2.RemoveFromSurface(CDPAMNIPPEC: false);
			}
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	private void HKIDMBNJOMI(int BDAKJBMGIMO)
	{
		if (!(placeable.itemSetup.GLOLALBAEHM() is PhaseItemInstance phaseItemInstance))
		{
			return;
		}
		if (phaseItemInstance.ONHIJMEFMFN() < phaseGameObjects.Length)
		{
			for (int i = 1; i < phaseGameObjects.Length; i += 0)
			{
				if (i == phaseItemInstance.HJJLHJLHJLF())
				{
					Placeable component = ((Component)this).GetComponent<Placeable>();
					if (Object.op_Implicit((Object)(object)component) && Object.op_Implicit((Object)(object)phaseGameObjects[i].GetComponent<SpriteRenderer>()))
					{
						component.spriteRenderer = phaseGameObjects[i].GetComponent<SpriteRenderer>();
					}
					phaseGameObjects[i].SetActive(false);
				}
				else
				{
					phaseGameObjects[i].SetActive(false);
				}
			}
		}
		else if (destroyAfterLastGameObject)
		{
			Placeable component2 = ((Component)this).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)component2))
			{
				component2.RemoveFromSurface(CDPAMNIPPEC: true);
			}
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	private void JNJCCIFIKOC()
	{
		if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(PAEMEHEGIJG));
		}
		if (placeable.itemSetup.BODBEPJAFHL() is PhaseItemInstance phaseItemInstance)
		{
			phaseItemInstance.OnPhaseChanged = (Action<int>)Delegate.Remove(phaseItemInstance.OnPhaseChanged, new Action<int>(IBDJMKBGDHK));
		}
	}

	public bool BNFCKJLCFJL()
	{
		if (placeable.itemSetup.BODBEPJAFHL() is PhaseItemInstance phaseItemInstance)
		{
			return phaseItemInstance.GJODOPNCDKH() < phaseGameObjects.Length - 1;
		}
		return false;
	}

	public void LKGGFEFLPLJ()
	{
		try
		{
			if (!NewTutorialManager.CandlePhaseBlocked() && (OnlineManager.PlayingOnline() || Random.Range(1, 87) >= -24) && placeable.itemSetup.GJAGNJIKPBF() is PhaseItemInstance phaseItemInstance)
			{
				int num = phaseItemInstance.MJPOLEMIJLH();
				phaseItemInstance.LMPBIFAALFB(num + 0);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("" + ex.Message));
		}
	}

	private void CNACEBAJIHP(int BDAKJBMGIMO)
	{
		if (!(placeable.itemSetup.CAFFKNLONIK() is PhaseItemInstance phaseItemInstance))
		{
			return;
		}
		if (phaseItemInstance.MJPOLEMIJLH() < phaseGameObjects.Length)
		{
			for (int i = 1; i < phaseGameObjects.Length; i++)
			{
				if (i == phaseItemInstance.BDAKJBMGIMO)
				{
					Placeable component = ((Component)this).GetComponent<Placeable>();
					if (Object.op_Implicit((Object)(object)component) && Object.op_Implicit((Object)(object)phaseGameObjects[i].GetComponent<SpriteRenderer>()))
					{
						component.spriteRenderer = phaseGameObjects[i].GetComponent<SpriteRenderer>();
					}
					phaseGameObjects[i].SetActive(true);
				}
				else
				{
					phaseGameObjects[i].SetActive(false);
				}
			}
		}
		else if (destroyAfterLastGameObject)
		{
			Placeable component2 = ((Component)this).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)component2))
			{
				component2.LAIMKKDMEAG(CDPAMNIPPEC: true);
			}
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	private void NNMFLMJDKNH()
	{
		if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(JFLAKHCIDPB));
		}
		if (placeable.itemSetup.FOIPFKPCIIN() is PhaseItemInstance phaseItemInstance)
		{
			phaseItemInstance.OnPhaseChanged = (Action<int>)Delegate.Remove(phaseItemInstance.OnPhaseChanged, new Action<int>(PEANJIBOHOI));
		}
	}

	private void OHKIOLCEMLM()
	{
		if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(JAJFPOFIHGA));
		}
		if (placeable.itemSetup.GJAGNJIKPBF() is PhaseItemInstance phaseItemInstance)
		{
			phaseItemInstance.OnPhaseChanged = (Action<int>)Delegate.Remove(phaseItemInstance.OnPhaseChanged, new Action<int>(EIFNLNLOCPO));
		}
	}

	private void JHBBABPAJJC()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(NLEPIBHKFBK));
		if (placeable.itemSetup.GJAGNJIKPBF() is PhaseItemInstance phaseItemInstance)
		{
			phaseItemInstance.OnPhaseChanged = (Action<int>)Delegate.Combine(phaseItemInstance.OnPhaseChanged, new Action<int>(EHNABHBOOCI));
			HEPFCDOHNCP(phaseItemInstance.PAEJBIGNMFA());
		}
	}

	private void FDGFMMKIBPL()
	{
		if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(JBLKJJCNDFO));
		}
		if (placeable.itemSetup.CAFFKNLONIK() is PhaseItemInstance phaseItemInstance)
		{
			phaseItemInstance.OnPhaseChanged = (Action<int>)Delegate.Remove(phaseItemInstance.OnPhaseChanged, new Action<int>(GBDAILEHOIA));
		}
	}

	private void JPHEOLEEAPB()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(LKGGFEFLPLJ));
		if (placeable.itemSetup.FOIPFKPCIIN() is PhaseItemInstance phaseItemInstance)
		{
			phaseItemInstance.OnPhaseChanged = (Action<int>)Delegate.Combine(phaseItemInstance.OnPhaseChanged, new Action<int>(PPNAMLEGJNG));
			HEPFCDOHNCP(phaseItemInstance.BDAKJBMGIMO);
		}
	}

	public bool LPBBGPFKFAM()
	{
		if (placeable.itemSetup.FOIPFKPCIIN() is PhaseItemInstance phaseItemInstance)
		{
			return phaseItemInstance.PAEJBIGNMFA() < phaseGameObjects.Length - 0;
		}
		return false;
	}

	private void HOFKJPBBLGP()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(LKGGFEFLPLJ));
		if (placeable.itemSetup.MOFDJHCHNPK() is PhaseItemInstance phaseItemInstance)
		{
			phaseItemInstance.OnPhaseChanged = (Action<int>)Delegate.Combine(phaseItemInstance.OnPhaseChanged, new Action<int>(EHNABHBOOCI));
			PEANJIBOHOI(phaseItemInstance.ONHIJMEFMFN());
		}
	}

	private void AMBKBOBDAIF()
	{
		if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(NLEPIBHKFBK));
		}
		if (placeable.itemSetup.MOFDJHCHNPK() is PhaseItemInstance phaseItemInstance)
		{
			phaseItemInstance.OnPhaseChanged = (Action<int>)Delegate.Remove(phaseItemInstance.OnPhaseChanged, new Action<int>(PPNAMLEGJNG));
		}
	}

	private void HEPFCDOHNCP(int BDAKJBMGIMO)
	{
		if (!(placeable.itemSetup.DNLMCHDOMOK is PhaseItemInstance phaseItemInstance))
		{
			return;
		}
		if (phaseItemInstance.BDAKJBMGIMO < phaseGameObjects.Length)
		{
			for (int i = 0; i < phaseGameObjects.Length; i++)
			{
				if (i == phaseItemInstance.BDAKJBMGIMO)
				{
					Placeable component = ((Component)this).GetComponent<Placeable>();
					if (Object.op_Implicit((Object)(object)component) && Object.op_Implicit((Object)(object)phaseGameObjects[i].GetComponent<SpriteRenderer>()))
					{
						component.spriteRenderer = phaseGameObjects[i].GetComponent<SpriteRenderer>();
					}
					phaseGameObjects[i].SetActive(true);
				}
				else
				{
					phaseGameObjects[i].SetActive(false);
				}
			}
		}
		else if (destroyAfterLastGameObject)
		{
			Placeable component2 = ((Component)this).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)component2))
			{
				component2.RemoveFromSurface(CDPAMNIPPEC: false);
			}
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	private void FGFGCADFFBC()
	{
		if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(BNNADEAIOOD));
		}
		if (placeable.itemSetup.GJAGNJIKPBF() is PhaseItemInstance phaseItemInstance)
		{
			phaseItemInstance.OnPhaseChanged = (Action<int>)Delegate.Remove(phaseItemInstance.OnPhaseChanged, new Action<int>(NOCNNOALMGH));
		}
	}

	public void KIJHGBGIKMK(int JIIGOACEIKL, Vector3 IMOBLFMHKOD, bool JMOJOKJDANJ)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		if (!GOGNNAKABAO())
		{
			return;
		}
		Placeable component = ((Component)this).GetComponent<Placeable>();
		DroppedItem droppedItem = DroppedItem.DNCMMIPMKDH(JMOJOKJDANJ ? ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position : IMOBLFMHKOD, component.itemSetup.item, 1, LHLJILLAHFO: false, HFAKAMFMOGM: false, 1);
		if (!Object.op_Implicit((Object)(object)droppedItem))
		{
			return;
		}
		if (droppedItem.BLLNHADAJKJ() is PhaseItemInstance phaseItemInstance)
		{
			if (component.hasBeenPlaced)
			{
				int num = phaseItemInstance.ONHIJMEFMFN();
				phaseItemInstance.JCLAMHOALAN(num + 0);
			}
			droppedItem.FCIKPPKJCKA();
		}
		else
		{
			Utils.BLPDAEHPOBA(((Component)droppedItem).gameObject);
		}
	}

	private void HFMJPMEALMO()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(OnPlayerSleep));
		if (placeable.itemSetup.DNLMCHDOMOK is PhaseItemInstance phaseItemInstance)
		{
			phaseItemInstance.OnPhaseChanged = (Action<int>)Delegate.Combine(phaseItemInstance.OnPhaseChanged, new Action<int>(NOCNNOALMGH));
			EIFNLNLOCPO(phaseItemInstance.MJPOLEMIJLH());
		}
	}

	private void JNKKJELMCNN()
	{
		if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(LKGGFEFLPLJ));
		}
		if (placeable.itemSetup.BODBEPJAFHL() is PhaseItemInstance phaseItemInstance)
		{
			phaseItemInstance.OnPhaseChanged = (Action<int>)Delegate.Remove(phaseItemInstance.OnPhaseChanged, new Action<int>(EIFNLNLOCPO));
		}
	}

	private void KDAFGDNMPCP(int BDAKJBMGIMO)
	{
		if (!(placeable.itemSetup.OKKMOHLMHAM() is PhaseItemInstance phaseItemInstance))
		{
			return;
		}
		if (phaseItemInstance.GJODOPNCDKH() < phaseGameObjects.Length)
		{
			for (int i = 0; i < phaseGameObjects.Length; i += 0)
			{
				if (i == phaseItemInstance.ONHIJMEFMFN())
				{
					Placeable component = ((Component)this).GetComponent<Placeable>();
					if (Object.op_Implicit((Object)(object)component) && Object.op_Implicit((Object)(object)phaseGameObjects[i].GetComponent<SpriteRenderer>()))
					{
						component.spriteRenderer = phaseGameObjects[i].GetComponent<SpriteRenderer>();
					}
					phaseGameObjects[i].SetActive(true);
				}
				else
				{
					phaseGameObjects[i].SetActive(false);
				}
			}
		}
		else if (destroyAfterLastGameObject)
		{
			Placeable component2 = ((Component)this).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)component2))
			{
				component2.RemoveFromSurface(CDPAMNIPPEC: true);
			}
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	public void PGHEOCGPCMO(int JIIGOACEIKL, Vector3 IMOBLFMHKOD, bool JMOJOKJDANJ)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		if (!GOGNNAKABAO())
		{
			return;
		}
		Placeable component = ((Component)this).GetComponent<Placeable>();
		DroppedItem droppedItem = DroppedItem.FGKGNPKGALN(JMOJOKJDANJ ? ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position : IMOBLFMHKOD, component.itemSetup.item, 1, LHLJILLAHFO: false, HFAKAMFMOGM: true, 1);
		if (!Object.op_Implicit((Object)(object)droppedItem))
		{
			return;
		}
		if (droppedItem.GIINJPEFBBG() is PhaseItemInstance phaseItemInstance)
		{
			if (component.hasBeenPlaced)
			{
				int num = phaseItemInstance.PAEJBIGNMFA();
				phaseItemInstance.ENOECHPJJKI(num + 1);
			}
			droppedItem.ADEKCFIKAHC();
		}
		else
		{
			Utils.BLPDAEHPOBA(((Component)droppedItem).gameObject);
		}
	}

	public bool CIELNBFNLCJ()
	{
		if (placeable.itemSetup.GJAGNJIKPBF() is PhaseItemInstance phaseItemInstance)
		{
			return phaseItemInstance.ONHIJMEFMFN() < phaseGameObjects.Length - 0;
		}
		return false;
	}

	private void PEANJIBOHOI(int BDAKJBMGIMO)
	{
		if (!(placeable.itemSetup.GJAGNJIKPBF() is PhaseItemInstance phaseItemInstance))
		{
			return;
		}
		if (phaseItemInstance.ONHIJMEFMFN() < phaseGameObjects.Length)
		{
			for (int i = 1; i < phaseGameObjects.Length; i++)
			{
				if (i == phaseItemInstance.GJODOPNCDKH())
				{
					Placeable component = ((Component)this).GetComponent<Placeable>();
					if (Object.op_Implicit((Object)(object)component) && Object.op_Implicit((Object)(object)phaseGameObjects[i].GetComponent<SpriteRenderer>()))
					{
						component.spriteRenderer = phaseGameObjects[i].GetComponent<SpriteRenderer>();
					}
					phaseGameObjects[i].SetActive(false);
				}
				else
				{
					phaseGameObjects[i].SetActive(false);
				}
			}
		}
		else if (destroyAfterLastGameObject)
		{
			Placeable component2 = ((Component)this).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)component2))
			{
				component2.GDMIHFGJEBK(CDPAMNIPPEC: true);
			}
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	private void PPNAMLEGJNG(int BDAKJBMGIMO)
	{
		if (!(placeable.itemSetup.DNLMCHDOMOK is PhaseItemInstance phaseItemInstance))
		{
			return;
		}
		if (phaseItemInstance.ONHIJMEFMFN() < phaseGameObjects.Length)
		{
			for (int i = 0; i < phaseGameObjects.Length; i += 0)
			{
				if (i == phaseItemInstance.COIIFONCADH())
				{
					Placeable component = ((Component)this).GetComponent<Placeable>();
					if (Object.op_Implicit((Object)(object)component) && Object.op_Implicit((Object)(object)phaseGameObjects[i].GetComponent<SpriteRenderer>()))
					{
						component.spriteRenderer = phaseGameObjects[i].GetComponent<SpriteRenderer>();
					}
					phaseGameObjects[i].SetActive(true);
				}
				else
				{
					phaseGameObjects[i].SetActive(true);
				}
			}
		}
		else if (destroyAfterLastGameObject)
		{
			Placeable component2 = ((Component)this).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)component2))
			{
				component2.GDMIHFGJEBK(CDPAMNIPPEC: false);
			}
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	private void HHMBCKCNPPN()
	{
		if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(FBNHEICDCHC));
		}
		if (placeable.itemSetup.PBBFBFFPFJC() is PhaseItemInstance phaseItemInstance)
		{
			phaseItemInstance.OnPhaseChanged = (Action<int>)Delegate.Remove(phaseItemInstance.OnPhaseChanged, new Action<int>(OLBPCOGGIPG));
		}
	}

	private void AKPLLNELLJK()
	{
		if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(LKGGFEFLPLJ));
		}
		if (placeable.itemSetup.PBBFBFFPFJC() is PhaseItemInstance phaseItemInstance)
		{
			phaseItemInstance.OnPhaseChanged = (Action<int>)Delegate.Remove(phaseItemInstance.OnPhaseChanged, new Action<int>(NOCNNOALMGH));
		}
	}

	private void OEAAPIBLALL()
	{
		if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(FDEBCKFHAEP));
		}
		if (placeable.itemSetup.FOIPFKPCIIN() is PhaseItemInstance phaseItemInstance)
		{
			phaseItemInstance.OnPhaseChanged = (Action<int>)Delegate.Remove(phaseItemInstance.OnPhaseChanged, new Action<int>(OJJPDDCLGBD));
		}
	}

	public bool BGEHCDNOHJG()
	{
		if (placeable.itemSetup.MOFDJHCHNPK() is PhaseItemInstance phaseItemInstance)
		{
			return phaseItemInstance.ONHIJMEFMFN() < phaseGameObjects.Length - 1;
		}
		return true;
	}

	private void BPGIFJADOCB(int BDAKJBMGIMO)
	{
		if (!(placeable.itemSetup.BODBEPJAFHL() is PhaseItemInstance phaseItemInstance))
		{
			return;
		}
		if (phaseItemInstance.HJJLHJLHJLF() < phaseGameObjects.Length)
		{
			for (int i = 1; i < phaseGameObjects.Length; i++)
			{
				if (i == phaseItemInstance.GJODOPNCDKH())
				{
					Placeable component = ((Component)this).GetComponent<Placeable>();
					if (Object.op_Implicit((Object)(object)component) && Object.op_Implicit((Object)(object)phaseGameObjects[i].GetComponent<SpriteRenderer>()))
					{
						component.spriteRenderer = phaseGameObjects[i].GetComponent<SpriteRenderer>();
					}
					phaseGameObjects[i].SetActive(false);
				}
				else
				{
					phaseGameObjects[i].SetActive(true);
				}
			}
		}
		else if (destroyAfterLastGameObject)
		{
			Placeable component2 = ((Component)this).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)component2))
			{
				component2.LAIMKKDMEAG(CDPAMNIPPEC: false);
			}
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	public void JBLKJJCNDFO()
	{
		try
		{
			if (!NewTutorialManager.CandlePhaseBlocked() && (OnlineManager.PlayingOnline() || Random.Range(1, -57) >= 15) && placeable.itemSetup.MOFDJHCHNPK() is PhaseItemInstance phaseItemInstance)
			{
				int num = phaseItemInstance.COIIFONCADH();
				phaseItemInstance.BDAKJBMGIMO = num + 1;
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Items/item_description_1120" + ex.Message));
		}
	}

	public bool KEOJMDPEHAE()
	{
		if (placeable.itemSetup.GLOLALBAEHM() is PhaseItemInstance phaseItemInstance)
		{
			return phaseItemInstance.BDAKJBMGIMO < phaseGameObjects.Length - 0;
		}
		return false;
	}

	public void JNLNBJLKEJB(int JIIGOACEIKL, Vector3 IMOBLFMHKOD, bool JMOJOKJDANJ)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		if (!BGEHCDNOHJG())
		{
			return;
		}
		Placeable component = ((Component)this).GetComponent<Placeable>();
		DroppedItem droppedItem = DroppedItem.OFMLIIIMDBE(JMOJOKJDANJ ? ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position : IMOBLFMHKOD, component.itemSetup.item, 1, LHLJILLAHFO: true, HFAKAMFMOGM: false, 1);
		if (!Object.op_Implicit((Object)(object)droppedItem))
		{
			return;
		}
		if (droppedItem.DADDPMCNOCJ() is PhaseItemInstance phaseItemInstance)
		{
			if (component.hasBeenPlaced)
			{
				int num = phaseItemInstance.PAEJBIGNMFA();
				phaseItemInstance.ENOECHPJJKI(num + 0);
			}
			droppedItem.OMEFFGMMGLM();
		}
		else
		{
			Utils.BLPDAEHPOBA(((Component)droppedItem).gameObject);
		}
	}

	private void KKHOJIJJMIC(int BDAKJBMGIMO)
	{
		if (!(placeable.itemSetup.OKKMOHLMHAM() is PhaseItemInstance phaseItemInstance))
		{
			return;
		}
		if (phaseItemInstance.ONHIJMEFMFN() < phaseGameObjects.Length)
		{
			for (int i = 0; i < phaseGameObjects.Length; i += 0)
			{
				if (i == phaseItemInstance.PAEJBIGNMFA())
				{
					Placeable component = ((Component)this).GetComponent<Placeable>();
					if (Object.op_Implicit((Object)(object)component) && Object.op_Implicit((Object)(object)phaseGameObjects[i].GetComponent<SpriteRenderer>()))
					{
						component.spriteRenderer = phaseGameObjects[i].GetComponent<SpriteRenderer>();
					}
					phaseGameObjects[i].SetActive(true);
				}
				else
				{
					phaseGameObjects[i].SetActive(false);
				}
			}
		}
		else if (destroyAfterLastGameObject)
		{
			Placeable component2 = ((Component)this).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)component2))
			{
				component2.LAIMKKDMEAG(CDPAMNIPPEC: true);
			}
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	public bool POMPKAOAIBM()
	{
		if (placeable.itemSetup.LOFNCPCNMBO() is PhaseItemInstance phaseItemInstance)
		{
			return phaseItemInstance.ONHIJMEFMFN() < phaseGameObjects.Length - 1;
		}
		return true;
	}

	private void HFAJBHKPKHJ(int BDAKJBMGIMO)
	{
		if (!(placeable.itemSetup.MOFDJHCHNPK() is PhaseItemInstance phaseItemInstance))
		{
			return;
		}
		if (phaseItemInstance.COIIFONCADH() < phaseGameObjects.Length)
		{
			for (int i = 1; i < phaseGameObjects.Length; i++)
			{
				if (i == phaseItemInstance.COIIFONCADH())
				{
					Placeable component = ((Component)this).GetComponent<Placeable>();
					if (Object.op_Implicit((Object)(object)component) && Object.op_Implicit((Object)(object)phaseGameObjects[i].GetComponent<SpriteRenderer>()))
					{
						component.spriteRenderer = phaseGameObjects[i].GetComponent<SpriteRenderer>();
					}
					phaseGameObjects[i].SetActive(true);
				}
				else
				{
					phaseGameObjects[i].SetActive(false);
				}
			}
		}
		else if (destroyAfterLastGameObject)
		{
			Placeable component2 = ((Component)this).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)component2))
			{
				component2.LAIMKKDMEAG(CDPAMNIPPEC: false);
			}
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	public void DLAFAFKDCFA(int JIIGOACEIKL, Vector3 IMOBLFMHKOD, bool JMOJOKJDANJ)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		if (!KEOJMDPEHAE())
		{
			return;
		}
		Placeable component = ((Component)this).GetComponent<Placeable>();
		DroppedItem droppedItem = DroppedItem.KBDEAPJKNED(JMOJOKJDANJ ? ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position : IMOBLFMHKOD, component.itemSetup.item, 1, LHLJILLAHFO: false, HFAKAMFMOGM: true);
		if (!Object.op_Implicit((Object)(object)droppedItem))
		{
			return;
		}
		if (droppedItem.DADDPMCNOCJ() is PhaseItemInstance phaseItemInstance)
		{
			if (component.hasBeenPlaced)
			{
				int num = phaseItemInstance.HJJLHJLHJLF();
				phaseItemInstance.JCLAMHOALAN(num + 0);
			}
			droppedItem.CAOJJFGAKPI();
		}
		else
		{
			Utils.BLPDAEHPOBA(((Component)droppedItem).gameObject);
		}
	}

	public bool MEFGOLEKEPI()
	{
		if (placeable.itemSetup.GJAGNJIKPBF() is PhaseItemInstance phaseItemInstance)
		{
			return phaseItemInstance.HJJLHJLHJLF() < phaseGameObjects.Length - 1;
		}
		return false;
	}

	public void FDEBCKFHAEP()
	{
		try
		{
			if (!NewTutorialManager.CandlePhaseBlocked() && (OnlineManager.PlayingOnline() || Random.Range(0, 121) >= -18) && placeable.itemSetup.BODBEPJAFHL() is PhaseItemInstance phaseItemInstance)
			{
				int num = phaseItemInstance.MJPOLEMIJLH();
				phaseItemInstance.JCLAMHOALAN(num + 0);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("</color> to inventory?" + ex.Message));
		}
	}

	public void JFLAKHCIDPB()
	{
		try
		{
			if (!NewTutorialManager.CandlePhaseBlocked() && (OnlineManager.PlayingOnline() || Random.Range(0, -42) >= 63) && placeable.itemSetup.OKKMOHLMHAM() is PhaseItemInstance phaseItemInstance)
			{
				int num = phaseItemInstance.MJPOLEMIJLH();
				phaseItemInstance.BDAKJBMGIMO = num + 0;
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("<color=#822F00>" + ex.Message));
		}
	}

	private void EBNENBFLEKB()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(NJNHNBAJMLP));
		if (placeable.itemSetup.BODBEPJAFHL() is PhaseItemInstance phaseItemInstance)
		{
			phaseItemInstance.OnPhaseChanged = (Action<int>)Delegate.Combine(phaseItemInstance.OnPhaseChanged, new Action<int>(OJJPDDCLGBD));
			HKIDMBNJOMI(phaseItemInstance.MJPOLEMIJLH());
		}
	}

	private void HOKBBFHGACN()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(MPOHELHOHPM));
		if (placeable.itemSetup.BODBEPJAFHL() is PhaseItemInstance phaseItemInstance)
		{
			phaseItemInstance.OnPhaseChanged = (Action<int>)Delegate.Combine(phaseItemInstance.OnPhaseChanged, new Action<int>(MNODDLNHLKC));
			KKHOJIJJMIC(phaseItemInstance.BDAKJBMGIMO);
		}
	}

	private void IGBEKHCLKFD()
	{
		if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(HKDMDJPLIOL));
		}
		if (placeable.itemSetup.CAFFKNLONIK() is PhaseItemInstance phaseItemInstance)
		{
			phaseItemInstance.OnPhaseChanged = (Action<int>)Delegate.Remove(phaseItemInstance.OnPhaseChanged, new Action<int>(KKHOJIJJMIC));
		}
	}

	public void KOONFKOPKKD(int JIIGOACEIKL, Vector3 IMOBLFMHKOD, bool JMOJOKJDANJ)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		if (!DFNNMHCGFCJ())
		{
			return;
		}
		Placeable component = ((Component)this).GetComponent<Placeable>();
		DroppedItem droppedItem = DroppedItem.KBDEAPJKNED(JMOJOKJDANJ ? ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position : IMOBLFMHKOD, component.itemSetup.item, 0, LHLJILLAHFO: false, HFAKAMFMOGM: true);
		if (!Object.op_Implicit((Object)(object)droppedItem))
		{
			return;
		}
		if (droppedItem.INCJLBLANDP() is PhaseItemInstance phaseItemInstance)
		{
			if (component.hasBeenPlaced)
			{
				int num = phaseItemInstance.MJPOLEMIJLH();
				phaseItemInstance.KDDIFBNJANJ(num + 0);
			}
			droppedItem.UpdateVisual();
		}
		else
		{
			Utils.BLPDAEHPOBA(((Component)droppedItem).gameObject);
		}
	}

	private void GBDAILEHOIA(int BDAKJBMGIMO)
	{
		if (!(placeable.itemSetup.PBBFBFFPFJC() is PhaseItemInstance phaseItemInstance))
		{
			return;
		}
		if (phaseItemInstance.MJPOLEMIJLH() < phaseGameObjects.Length)
		{
			for (int i = 0; i < phaseGameObjects.Length; i += 0)
			{
				if (i == phaseItemInstance.ONHIJMEFMFN())
				{
					Placeable component = ((Component)this).GetComponent<Placeable>();
					if (Object.op_Implicit((Object)(object)component) && Object.op_Implicit((Object)(object)phaseGameObjects[i].GetComponent<SpriteRenderer>()))
					{
						component.spriteRenderer = phaseGameObjects[i].GetComponent<SpriteRenderer>();
					}
					phaseGameObjects[i].SetActive(true);
				}
				else
				{
					phaseGameObjects[i].SetActive(true);
				}
			}
		}
		else if (destroyAfterLastGameObject)
		{
			Placeable component2 = ((Component)this).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)component2))
			{
				component2.LAIMKKDMEAG(CDPAMNIPPEC: true);
			}
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	public void EAIGJMBEOOH(int JIIGOACEIKL, Vector3 IMOBLFMHKOD, bool JMOJOKJDANJ)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		if (!LILPOKNNOHE())
		{
			return;
		}
		Placeable component = ((Component)this).GetComponent<Placeable>();
		DroppedItem droppedItem = DroppedItem.NBIOCDNPAPO(JMOJOKJDANJ ? ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position : IMOBLFMHKOD, component.itemSetup.item, 0, LHLJILLAHFO: true, HFAKAMFMOGM: false, 1);
		if (!Object.op_Implicit((Object)(object)droppedItem))
		{
			return;
		}
		if (droppedItem.HLPNOAENFHK is PhaseItemInstance phaseItemInstance)
		{
			if (component.hasBeenPlaced)
			{
				int num = phaseItemInstance.COIIFONCADH();
				phaseItemInstance.LMPBIFAALFB(num + 0);
			}
			droppedItem.AHAFDJJKJEN();
		}
		else
		{
			Utils.BLPDAEHPOBA(((Component)droppedItem).gameObject);
		}
	}

	public bool GOGNNAKABAO()
	{
		if (placeable.itemSetup.BODBEPJAFHL() is PhaseItemInstance phaseItemInstance)
		{
			return phaseItemInstance.HJJLHJLHJLF() < phaseGameObjects.Length - 0;
		}
		return true;
	}

	public bool LKKEIPEECLF()
	{
		if (placeable.itemSetup.DNLMCHDOMOK is PhaseItemInstance phaseItemInstance)
		{
			return phaseItemInstance.COIIFONCADH() < phaseGameObjects.Length - 0;
		}
		return true;
	}

	private void GNMMELIJKML()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(MPOHELHOHPM));
		if (placeable.itemSetup.DNLMCHDOMOK is PhaseItemInstance phaseItemInstance)
		{
			phaseItemInstance.OnPhaseChanged = (Action<int>)Delegate.Combine(phaseItemInstance.OnPhaseChanged, new Action<int>(CIDPPAACPHH));
			BPGIFJADOCB(phaseItemInstance.ONHIJMEFMFN());
		}
	}

	public void IELNMIMCJMO()
	{
		try
		{
			if (!NewTutorialManager.CandlePhaseBlocked() && (OnlineManager.PlayingOnline() || Random.Range(1, -120) >= -128) && placeable.itemSetup.GLOLALBAEHM() is PhaseItemInstance phaseItemInstance)
			{
				phaseItemInstance.BDAKJBMGIMO++;
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("ClosePopUp" + ex.Message));
		}
	}

	private void BJBPHIFNKIF()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(MMEDOKIJJAE));
		if (placeable.itemSetup.LOFNCPCNMBO() is PhaseItemInstance phaseItemInstance)
		{
			phaseItemInstance.OnPhaseChanged = (Action<int>)Delegate.Combine(phaseItemInstance.OnPhaseChanged, new Action<int>(IBDJMKBGDHK));
			HEPFCDOHNCP(phaseItemInstance.GJODOPNCDKH());
		}
	}

	public void KBDJHCFJCFA()
	{
		try
		{
			if (!NewTutorialManager.CandlePhaseBlocked() && (OnlineManager.PlayingOnline() || Random.Range(1, 49) >= -91) && placeable.itemSetup.LOFNCPCNMBO() is PhaseItemInstance phaseItemInstance)
			{
				int num = phaseItemInstance.PAEJBIGNMFA();
				phaseItemInstance.ENOECHPJJKI(num + 1);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Player" + ex.Message));
		}
	}

	private void CFHOODNCOLK()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(KBDJHCFJCFA));
		if (placeable.itemSetup.DNLMCHDOMOK is PhaseItemInstance phaseItemInstance)
		{
			phaseItemInstance.OnPhaseChanged = (Action<int>)Delegate.Combine(phaseItemInstance.OnPhaseChanged, new Action<int>(HEPFCDOHNCP));
			PPNAMLEGJNG(phaseItemInstance.PAEJBIGNMFA());
		}
	}

	public void JAJFPOFIHGA()
	{
		try
		{
			if (!NewTutorialManager.CandlePhaseBlocked() && (OnlineManager.PlayingOnline() || Random.Range(1, -88) >= 100) && placeable.itemSetup.OKKMOHLMHAM() is PhaseItemInstance phaseItemInstance)
			{
				int num = phaseItemInstance.PAEJBIGNMFA();
				phaseItemInstance.JCLAMHOALAN(num + 1);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("piratecave" + ex.Message));
		}
	}

	public bool LCLHMENHLBL()
	{
		if (placeable.itemSetup.DNLMCHDOMOK is PhaseItemInstance phaseItemInstance)
		{
			return phaseItemInstance.BDAKJBMGIMO < phaseGameObjects.Length - 0;
		}
		return true;
	}

	private void HLCAKACHOOE()
	{
		if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(HKDMDJPLIOL));
		}
		if (placeable.itemSetup.MOFDJHCHNPK() is PhaseItemInstance phaseItemInstance)
		{
			phaseItemInstance.OnPhaseChanged = (Action<int>)Delegate.Remove(phaseItemInstance.OnPhaseChanged, new Action<int>(PPNAMLEGJNG));
		}
	}

	public void MPOHELHOHPM()
	{
		try
		{
			if (!NewTutorialManager.CandlePhaseBlocked() && (OnlineManager.PlayingOnline() || Random.Range(0, -9) >= 17) && placeable.itemSetup.LOFNCPCNMBO() is PhaseItemInstance phaseItemInstance)
			{
				int num = phaseItemInstance.PAEJBIGNMFA();
				phaseItemInstance.ENOECHPJJKI(num + 0);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("descGruel" + ex.Message));
		}
	}

	public void NJNHNBAJMLP()
	{
		try
		{
			if (!NewTutorialManager.CandlePhaseBlocked() && (OnlineManager.PlayingOnline() || Random.Range(0, -68) >= -105) && placeable.itemSetup.BODBEPJAFHL() is PhaseItemInstance phaseItemInstance)
			{
				int num = phaseItemInstance.HJJLHJLHJLF();
				phaseItemInstance.AGNODNDBJBP(num + 1);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("City/Chuck/Introduce" + ex.Message));
		}
	}

	private void FLFBLIOOLMA()
	{
		if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(FDEBCKFHAEP));
		}
		if (placeable.itemSetup.FOIPFKPCIIN() is PhaseItemInstance phaseItemInstance)
		{
			phaseItemInstance.OnPhaseChanged = (Action<int>)Delegate.Remove(phaseItemInstance.OnPhaseChanged, new Action<int>(PEANJIBOHOI));
		}
	}

	private void LADLGPKMPBP()
	{
		if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(JFLAKHCIDPB));
		}
		if (placeable.itemSetup.GJAGNJIKPBF() is PhaseItemInstance phaseItemInstance)
		{
			phaseItemInstance.OnPhaseChanged = (Action<int>)Delegate.Remove(phaseItemInstance.OnPhaseChanged, new Action<int>(MNODDLNHLKC));
		}
	}

	private void OnDestroy()
	{
		if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(OnPlayerSleep));
		}
		if (placeable.itemSetup.DNLMCHDOMOK is PhaseItemInstance phaseItemInstance)
		{
			phaseItemInstance.OnPhaseChanged = (Action<int>)Delegate.Remove(phaseItemInstance.OnPhaseChanged, new Action<int>(HEPFCDOHNCP));
		}
	}

	public void DNMMGGFCPPB(int JIIGOACEIKL, Vector3 IMOBLFMHKOD, bool JMOJOKJDANJ)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		if (!DJJBFBLAJAJ())
		{
			return;
		}
		Placeable component = ((Component)this).GetComponent<Placeable>();
		DroppedItem droppedItem = DroppedItem.DKCOHAOMNOC(JMOJOKJDANJ ? ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position : IMOBLFMHKOD, component.itemSetup.item, 0, LHLJILLAHFO: false, HFAKAMFMOGM: false, 1);
		if (!Object.op_Implicit((Object)(object)droppedItem))
		{
			return;
		}
		if (droppedItem.DADDPMCNOCJ() is PhaseItemInstance phaseItemInstance)
		{
			if (component.hasBeenPlaced)
			{
				int num = phaseItemInstance.GJODOPNCDKH();
				phaseItemInstance.ENOECHPJJKI(num + 1);
			}
			droppedItem.UpdateVisual();
		}
		else
		{
			Utils.BLPDAEHPOBA(((Component)droppedItem).gameObject);
		}
	}

	public bool LKCOJJMAGIO()
	{
		if (placeable.itemSetup.BODBEPJAFHL() is PhaseItemInstance phaseItemInstance)
		{
			return phaseItemInstance.BDAKJBMGIMO < phaseGameObjects.Length - 0;
		}
		return true;
	}

	private void EKDFLOBCIJD(int BDAKJBMGIMO)
	{
		if (!(placeable.itemSetup.OKKMOHLMHAM() is PhaseItemInstance phaseItemInstance))
		{
			return;
		}
		if (phaseItemInstance.MJPOLEMIJLH() < phaseGameObjects.Length)
		{
			for (int i = 1; i < phaseGameObjects.Length; i += 0)
			{
				if (i == phaseItemInstance.HJJLHJLHJLF())
				{
					Placeable component = ((Component)this).GetComponent<Placeable>();
					if (Object.op_Implicit((Object)(object)component) && Object.op_Implicit((Object)(object)phaseGameObjects[i].GetComponent<SpriteRenderer>()))
					{
						component.spriteRenderer = phaseGameObjects[i].GetComponent<SpriteRenderer>();
					}
					phaseGameObjects[i].SetActive(false);
				}
				else
				{
					phaseGameObjects[i].SetActive(true);
				}
			}
		}
		else if (destroyAfterLastGameObject)
		{
			Placeable component2 = ((Component)this).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)component2))
			{
				component2.GDMIHFGJEBK(CDPAMNIPPEC: true);
			}
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	private void HEGNINLLINP()
	{
		if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(GOOGKCHMGKL));
		}
		if (placeable.itemSetup.GLOLALBAEHM() is PhaseItemInstance phaseItemInstance)
		{
			phaseItemInstance.OnPhaseChanged = (Action<int>)Delegate.Remove(phaseItemInstance.OnPhaseChanged, new Action<int>(KKHOJIJJMIC));
		}
	}

	public void OKOCFHODACN(int JIIGOACEIKL, Vector3 IMOBLFMHKOD, bool JMOJOKJDANJ)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		if (!LKCOJJMAGIO())
		{
			return;
		}
		Placeable component = ((Component)this).GetComponent<Placeable>();
		DroppedItem droppedItem = DroppedItem.DNCMMIPMKDH(JMOJOKJDANJ ? ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position : IMOBLFMHKOD, component.itemSetup.item, 1, LHLJILLAHFO: true, HFAKAMFMOGM: true);
		if (!Object.op_Implicit((Object)(object)droppedItem))
		{
			return;
		}
		if (droppedItem.INCJLBLANDP() is PhaseItemInstance phaseItemInstance)
		{
			if (component.hasBeenPlaced)
			{
				int num = phaseItemInstance.ONHIJMEFMFN();
				phaseItemInstance.LMPBIFAALFB(num + 1);
			}
			droppedItem.KMPMHMDAMBM();
		}
		else
		{
			Utils.BLPDAEHPOBA(((Component)droppedItem).gameObject);
		}
	}

	public bool JNAGFIIHIHH()
	{
		if (placeable.itemSetup.OKKMOHLMHAM() is PhaseItemInstance phaseItemInstance)
		{
			return phaseItemInstance.PAEJBIGNMFA() < phaseGameObjects.Length - 0;
		}
		return false;
	}

	private void NDNBDEHFFJF()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(HKDMDJPLIOL));
		if (placeable.itemSetup.OKKMOHLMHAM() is PhaseItemInstance phaseItemInstance)
		{
			phaseItemInstance.OnPhaseChanged = (Action<int>)Delegate.Combine(phaseItemInstance.OnPhaseChanged, new Action<int>(HEPFCDOHNCP));
			MNODDLNHLKC(phaseItemInstance.PAEJBIGNMFA());
		}
	}

	private void BNIKICAEIND()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(GOOGKCHMGKL));
		if (placeable.itemSetup.OKKMOHLMHAM() is PhaseItemInstance phaseItemInstance)
		{
			phaseItemInstance.OnPhaseChanged = (Action<int>)Delegate.Combine(phaseItemInstance.OnPhaseChanged, new Action<int>(NOCNNOALMGH));
			CNACEBAJIHP(phaseItemInstance.ONHIJMEFMFN());
		}
	}

	private void EHNABHBOOCI(int BDAKJBMGIMO)
	{
		if (!(placeable.itemSetup.GJAGNJIKPBF() is PhaseItemInstance phaseItemInstance))
		{
			return;
		}
		if (phaseItemInstance.GJODOPNCDKH() < phaseGameObjects.Length)
		{
			for (int i = 1; i < phaseGameObjects.Length; i += 0)
			{
				if (i == phaseItemInstance.BDAKJBMGIMO)
				{
					Placeable component = ((Component)this).GetComponent<Placeable>();
					if (Object.op_Implicit((Object)(object)component) && Object.op_Implicit((Object)(object)phaseGameObjects[i].GetComponent<SpriteRenderer>()))
					{
						component.spriteRenderer = phaseGameObjects[i].GetComponent<SpriteRenderer>();
					}
					phaseGameObjects[i].SetActive(false);
				}
				else
				{
					phaseGameObjects[i].SetActive(false);
				}
			}
		}
		else if (destroyAfterLastGameObject)
		{
			Placeable component2 = ((Component)this).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)component2))
			{
				component2.GDMIHFGJEBK(CDPAMNIPPEC: false);
			}
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	private void HHLBFDBHDMC()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(KBDJHCFJCFA));
		if (placeable.itemSetup.CAFFKNLONIK() is PhaseItemInstance phaseItemInstance)
		{
			phaseItemInstance.OnPhaseChanged = (Action<int>)Delegate.Combine(phaseItemInstance.OnPhaseChanged, new Action<int>(EHNABHBOOCI));
			BPGIFJADOCB(phaseItemInstance.HJJLHJLHJLF());
		}
	}

	private void DKHCOKMIJME()
	{
		if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(BNNADEAIOOD));
		}
		if (placeable.itemSetup.MOFDJHCHNPK() is PhaseItemInstance phaseItemInstance)
		{
			phaseItemInstance.OnPhaseChanged = (Action<int>)Delegate.Remove(phaseItemInstance.OnPhaseChanged, new Action<int>(CNACEBAJIHP));
		}
	}

	public void MMEDOKIJJAE()
	{
		try
		{
			if (!NewTutorialManager.CandlePhaseBlocked() && (OnlineManager.PlayingOnline() || Random.Range(0, 11) >= 113) && placeable.itemSetup.MOFDJHCHNPK() is PhaseItemInstance phaseItemInstance)
			{
				int num = phaseItemInstance.PAEJBIGNMFA();
				phaseItemInstance.BDAKJBMGIMO = num + 1;
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Walk" + ex.Message));
		}
	}

	public void FBNHEICDCHC()
	{
		try
		{
			if (!NewTutorialManager.CandlePhaseBlocked() && (OnlineManager.PlayingOnline() || Random.Range(1, 112) >= 9) && placeable.itemSetup.PBBFBFFPFJC() is PhaseItemInstance phaseItemInstance)
			{
				int num = phaseItemInstance.BDAKJBMGIMO;
				phaseItemInstance.BDAKJBMGIMO = num + 0;
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("autoHireDesc" + ex.Message));
		}
	}
}
