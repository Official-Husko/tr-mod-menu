using System.Collections;
using UnityEngine;

public class OnlineAnimal : OnlinePlaceable
{
	private enum JDBLOKANBMI
	{
		Teleport,
		SleepEmote
	}

	public AnimalNPC animalNpc;

	public void KNIGBHOKCCF(bool HCCBOAMEEIJ)
	{
		animalNpc.hasWalked = HCCBOAMEEIJ;
	}

	public void SendSick()
	{
		OnlineObjectsManager.instance.SendSick(uniqueId);
	}

	protected override void Start()
	{
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		if (uniqueId == 0)
		{
			AssignNewUniqueId();
			if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.SendInstantiatePlaceable(this);
			}
		}
		else if (uniqueId < 100000)
		{
			OnlineObjectsManager.instance.AddObjectInDictionary(this);
		}
	}

	public void SendLevel(int EONJGMONIOM)
	{
		OnlineObjectsManager.instance.SendAnimalLevel(uniqueId, EONJGMONIOM);
	}

	public void EPEAPNLFEKG(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		SendSetBool(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void SendSetLife(int GDHFHKKMIEP)
	{
		OnlineObjectsManager.instance.SendSetLife(uniqueId, GDHFHKKMIEP);
	}

	public void SendSetProduction(float AODONKKHPBP)
	{
		OnlineObjectsManager.instance.SendAnimalSetProduction(uniqueId, AODONKKHPBP);
	}

	public void DeassignAnimal()
	{
		if ((Object)(object)animalNpc.animalSpace != (Object)null)
		{
			animalNpc.animalSpace.DeassignAnimal(CDPAMNIPPEC: false);
		}
	}

	public IEnumerator AssignHenHouseOnLoad(int KIDIPDEMIPB)
	{
		OnlineObject value;
		while (!OnlineObjectsManager.instance.onlineObjects.TryGetValue(KIDIPDEMIPB, out value))
		{
			yield return CommonReferences.wait2;
		}
		(value as OnlineHenHouse).henHouse.AssignAnimal(animalNpc as ChickenNPC, CDPAMNIPPEC: false);
	}

	public void SendName()
	{
		OnlineObjectsManager.instance.SendAnimalName(uniqueId, animalNpc.NBMNBKEJHPM.animalName);
	}

	public void SendEnableSleepEmote(bool BJFHJCFOEHG)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, BJFHJCFOEHG);
	}

	public void DKMAOIJHAMN()
	{
		OnlineObjectsManager.instance.OCCEGNAKNCO(uniqueId);
	}

	public void ReceiveSetTrigger(int GJKKNOKIKBJ)
	{
		animalNpc.FFHHEGALBKO.SetTrigger(GJKKNOKIKBJ);
	}

	public void ReceiveName(string GEGDHHIDEEF)
	{
		animalNpc.NBMNBKEJHPM.animalName = GEGDHHIDEEF;
	}

	public void UpdateAnimalPosition()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.PINPKCAOEFL(((Component)this).transform.position))
		{
			OnlineObjectsManager.instance.AddAnimalMovement(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
		else
		{
			OnlineObjectsManager.instance.AddUntrackedObject(uniqueId);
		}
	}

	public void Sick()
	{
		animalNpc.Sick(CDPAMNIPPEC: false);
	}

	public void SendSetBool(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		OnlineObjectsManager.instance.SendSetBool(uniqueId, GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void ReceiveSetBool(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		animalNpc.FFHHEGALBKO.SetBool(GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void ReceiveDisable()
	{
		((Component)this).gameObject.SetActive(false);
	}

	public void SendCure()
	{
		OnlineObjectsManager.instance.SendCure(uniqueId);
	}

	public void SendHitToOthers(Vector3 JBMDOGNFIGJ)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager.instance.SendHitToOthers(uniqueId, JBMDOGNFIGJ);
	}

	public void ReceiveSetProduction(float AODONKKHPBP)
	{
		animalNpc.SetProductionProgress(AODONKKHPBP, CDPAMNIPPEC: false);
	}

	public void SendSetBool(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		SendSetBool(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void SendSetVitamins(int MGNOBNCMDJG)
	{
		OnlineObjectsManager.instance.SendSetVitamins(uniqueId, MGNOBNCMDJG);
	}

	public void ReceiveWalk(bool HCCBOAMEEIJ)
	{
		animalNpc.hasWalked = HCCBOAMEEIJ;
	}

	public void SendTeleportAnimal()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, ((Component)this).transform.position.x, ((Component)this).transform.position.y);
	}

	public void ReceiveEnable()
	{
		((Component)this).gameObject.SetActive(true);
	}

	public override PlaceableMsg CreateMsg()
	{
		return new AnimalMessage(this);
	}

	public void SetVitamins(int MGNOBNCMDJG)
	{
		animalNpc.SetVitamins(MGNOBNCMDJG, CDPAMNIPPEC: false);
	}

	public void SendHit(Vector3 JBMDOGNFIGJ)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager.instance.SendHit(uniqueId, JBMDOGNFIGJ);
	}

	public void DPFPPAAPHHC(string GEGDHHIDEEF)
	{
		SendSetTrigger(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void Cure()
	{
		animalNpc.Cure(1, CDPAMNIPPEC: false);
	}

	public void DCKPFFOKEHG()
	{
		((Component)this).gameObject.SetActive(false);
	}

	private void OKHFBHNHGCJ()
	{
		if (Object.op_Implicit((Object)(object)OnlineObjectsManager.instance))
		{
			OnlineObjectsManager.instance.SendDisable(uniqueId);
		}
	}

	public void ReceiveSetLife(int GDHFHKKMIEP)
	{
		animalNpc.SetLife(GDHFHKKMIEP, CDPAMNIPPEC: false);
	}

	private void DAEEHNBDIFL()
	{
		OnlineObjectsManager.instance.SendEnable(uniqueId);
	}

	public void PIJHDMNPMEH(int GJKKNOKIKBJ)
	{
		OnlineObjectsManager.instance.SendSetTrigger(uniqueId, GJKKNOKIKBJ);
	}

	public void ReceiveLevel(int EONJGMONIOM)
	{
		animalNpc.level = EONJGMONIOM;
	}

	public void SendDeassignAnimal()
	{
		OnlineObjectsManager.instance.SendDeassignAnimal(uniqueId);
	}

	public void ICPDELHCPCE(float AODONKKHPBP)
	{
		OnlineObjectsManager.instance.CECGMEEAIOK(uniqueId, AODONKKHPBP);
	}

	public void BKLGNAGNOIB()
	{
		OnlineObjectsManager.instance.SendAnimalName(uniqueId, animalNpc.NBMNBKEJHPM.animalName);
	}

	public void SendSetTrigger(int GJKKNOKIKBJ)
	{
		OnlineObjectsManager.instance.SendSetTrigger(uniqueId, GJKKNOKIKBJ);
	}

	public void SendAssignChicken(int HJECLKNOHGC)
	{
		OnlineObjectsManager.instance.SendAssigChicken(uniqueId, HJECLKNOHGC);
	}

	public void SendSetTrigger(string GEGDHHIDEEF)
	{
		SendSetTrigger(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void SendIncreaseProduction(float AODONKKHPBP)
	{
		OnlineObjectsManager.instance.SendAnimalIncreaseProduction(uniqueId, AODONKKHPBP);
	}

	private void OnEnable()
	{
		if (OnlineManager.IsMasterClient())
		{
			DAEEHNBDIFL();
		}
	}

	private void OnDisable()
	{
		if (OnlineManager.IsMasterClient())
		{
			OKHFBHNHGCJ();
		}
	}

	public void SendWalk()
	{
		OnlineObjectsManager.instance.SendAnimalWalk(uniqueId, animalNpc.hasWalked);
	}

	public void ReceiveHit(float NCPGNLOJGAF, float JLMAILGJNCE, bool CDPAMNIPPEC)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		animalNpc.Hit(new Vector3(NCPGNLOJGAF, JLMAILGJNCE, 0f), CDPAMNIPPEC);
	}

	public void ReceiveIncreaseProduction(float AODONKKHPBP)
	{
		animalNpc.IncreaseProductionProgress(AODONKKHPBP, CDPAMNIPPEC: false);
	}

	public override void ObjectConfiguration()
	{
		base.ObjectConfiguration();
		Debug.Log((object)("Get Components " + ((Object)((Component)this).gameObject).name));
		animalNpc = ((Component)((Component)this).transform).GetComponent<AnimalNPC>();
		animalNpc.onlineAnimal = this;
		animalNpc.FFHHEGALBKO.onlineAnimal = this;
	}

	public void SendAssignAnimal(int KNIBEKEBAHD, int EPDKMPFDDGP)
	{
		OnlineObjectsManager.instance.SendAssignAnimalSpace(uniqueId, KNIBEKEBAHD, EPDKMPFDDGP);
	}

	public void ReceiveSetBool(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		animalNpc.FFHHEGALBKO.SetBool(GEGDHHIDEEF, AODONKKHPBP);
	}

	public void CNLIGEECMJN()
	{
		if ((Object)(object)animalNpc.animalSpace != (Object)null)
		{
			animalNpc.animalSpace.DFEIFHFPHJI(CDPAMNIPPEC: false);
		}
	}

	public void AssignChicken(OnlineHenHouse OPNDIFDIBLB)
	{
		OPNDIFDIBLB.henHouse.AssignAnimal(animalNpc as ChickenNPC, CDPAMNIPPEC: false);
	}

	public void ReceiveSetTrigger(string GEGDHHIDEEF)
	{
		ReceiveSetTrigger(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void AssignAnimal(int KNIBEKEBAHD, int EPDKMPFDDGP)
	{
		if (!((Object)(object)animalNpc == (Object)null))
		{
			CommonReferences.GGFJGHHHEJC.allBarnScenes[KNIBEKEBAHD].animalSpaces[EPDKMPFDDGP].AssignAnimal(animalNpc, CDPAMNIPPEC: false);
		}
	}

	public void OJLLFMFPGNE(int EONJGMONIOM)
	{
		animalNpc.level = EONJGMONIOM;
	}

	public override void ReceiveAction(byte FACPEEACCMH, params object[] GEMFIOKGIMC)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		switch ((JDBLOKANBMI)FACPEEACCMH)
		{
		case JDBLOKANBMI.Teleport:
			KJDJCMLGGLL = true;
			((Component)this).transform.position = Utils.EKCCGNEDPNO(new Vector3((float)GEMFIOKGIMC[0], (float)GEMFIOKGIMC[1], 0f), 1);
			break;
		case JDBLOKANBMI.SleepEmote:
			animalNpc.sleepEmote.SetBool("Sleep", (bool)GEMFIOKGIMC[0]);
			break;
		}
	}
}
