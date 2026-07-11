using UnityEngine;

public class OnlineCat : OnlineObject
{
	private enum JDBLOKANBMI
	{
		WakeUp,
		StartWalking,
		HeadToBed,
		Eat,
		Pet,
		SetRelationship,
		MinusRelationship,
		Teleport
	}

	public CatNPC catNPC;

	private float DCGBADKLANM;

	public void KMKPBKKNIAE(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		catNPC.catAnimation.SetBool(GJKKNOKIKBJ, AODONKKHPBP, HALNIEBONKH: true);
	}

	public void BEALKMOGAJP(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		catNPC.catAnimation.SetBool(GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void SendHeadToBed(Placeable HJLNPMKIJCI)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 2, HJLNPMKIJCI.onlinePlaceable.uniqueId);
	}

	public void DBNKLPGDPKA(string GEGDHHIDEEF, int AODONKKHPBP)
	{
		OFGPFKBHEEM(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	protected virtual void CMJJFJFDNED()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		if (DBEFBFPAOAA < AFMFHCAHEFO && (Object)(object)((Component)this).transform.parent == (Object)null)
		{
			DBEFBFPAOAA += Time.fixedDeltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			((Component)this).transform.position = Vector2.op_Implicit(Vector2.Lerp(LFLECAIBFCL, GNFBPAGOFLH, DCGBADKLANM));
			((Component)this).transform.position = Utils.EKCCGNEDPNO(((Component)this).transform.position, 0);
		}
	}

	public void ECNCCIPNNNE(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		PLPCLLDBKHF(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void OLGIMNFAIMI(int GJKKNOKIKBJ, int AODONKKHPBP)
	{
		catNPC.catAnimation.SetInt(GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void DDPAJNNCNBP()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[7];
		array[1] = ((Component)this).transform.position.x;
		array[1] = ((Component)this).transform.position.y;
		instance.SendObjectAction(bEIPALOAAJJ, 4, array);
	}

	public void FFIGLDLBFAG(string GEGDHHIDEEF, int AODONKKHPBP)
	{
		ReceiveSetInt(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void NAKFBDOPMEK(int GJKKNOKIKBJ, int AODONKKHPBP)
	{
		OnlineObjectsManager.instance.SendSetInt(uniqueId, GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void SendSetInt(string GEGDHHIDEEF, int AODONKKHPBP)
	{
		SendSetInt(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void CJOENOAEPOB(int IHNEJFGAENM)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, IHNEJFGAENM);
	}

	public void HOEPNHEFKPL(int FFDIEOBBFKL)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = FFDIEOBBFKL;
		instance.SendObjectAction(bEIPALOAAJJ, 6, array);
	}

	public void NMAILIGPACC(int GJKKNOKIKBJ)
	{
		OnlineObjectsManager.instance.SendSetTrigger(uniqueId, GJKKNOKIKBJ);
	}

	public void UpdateCatPosition()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.PINPKCAOEFL(((Component)this).transform.position))
		{
			OnlineObjectsManager.instance.AddCatMovement(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
		else
		{
			OnlineObjectsManager.instance.AddUntrackedObject(uniqueId);
		}
	}

	public void ELGONAJIPOG(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		BEALKMOGAJP(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void IPKFPOBAALP(string GEGDHHIDEEF)
	{
		BLOEANHKHEG(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void SendSetTrigger(string GEGDHHIDEEF)
	{
		SendSetTrigger(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void ALPGCGEFOBP()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	private void DMFMNEMDFNP()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		if (uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.SendInstantiateCat(this);
			}
		}
		LFLECAIBFCL = Vector2.op_Implicit(((Component)this).transform.position);
	}

	protected virtual void FixedUpdate()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		if (DBEFBFPAOAA < AFMFHCAHEFO && (Object)(object)((Component)this).transform.parent == (Object)null)
		{
			DBEFBFPAOAA += Time.fixedDeltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			((Component)this).transform.position = Vector2.op_Implicit(Vector2.Lerp(LFLECAIBFCL, GNFBPAGOFLH, DCGBADKLANM));
			((Component)this).transform.position = Utils.EKCCGNEDPNO(((Component)this).transform.position, 1);
		}
	}

	public void FIFJCHPBDAJ(string GEGDHHIDEEF)
	{
		ReceiveSetTrigger(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void SendSetBool(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		OnlineObjectsManager.instance.SendSetBool(uniqueId, GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void ReceiveSetInt(string GEGDHHIDEEF, int AODONKKHPBP)
	{
		ReceiveSetInt(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void COPHJGMIHFM(string GEGDHHIDEEF, int AODONKKHPBP)
	{
		OLGIMNFAIMI(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	protected virtual void ACFMEGDHELN()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		if (DBEFBFPAOAA < AFMFHCAHEFO && (Object)(object)((Component)this).transform.parent == (Object)null)
		{
			DBEFBFPAOAA += Time.fixedDeltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			((Component)this).transform.position = Vector2.op_Implicit(Vector2.Lerp(LFLECAIBFCL, GNFBPAGOFLH, DCGBADKLANM));
			((Component)this).transform.position = Utils.EKCCGNEDPNO(((Component)this).transform.position, 1);
		}
	}

	public void LOKMOKHAHFL(int GJKKNOKIKBJ)
	{
		catNPC.catAnimation.SetTrigger(GJKKNOKIKBJ, HALNIEBONKH: true);
	}

	public void MPCIIHMHBKP(int GJKKNOKIKBJ)
	{
		catNPC.catAnimation.SetTrigger(GJKKNOKIKBJ, HALNIEBONKH: true);
	}

	public void BCAMJGCDCMI(int GJKKNOKIKBJ, int AODONKKHPBP)
	{
		catNPC.catAnimation.SetInt(GJKKNOKIKBJ, AODONKKHPBP, HALNIEBONKH: true);
	}

	public void GDMPCJGNKGF(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		SendSetBool(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void MDBCCKCKHAH(string GEGDHHIDEEF)
	{
		NMAILIGPACC(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void MNJGNCLHDGK(int GJKKNOKIKBJ)
	{
		OnlineObjectsManager.instance.SendSetTrigger(uniqueId, GJKKNOKIKBJ);
	}

	public void JMIIPHHBNJI(string GEGDHHIDEEF)
	{
		MNJGNCLHDGK(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void ILALMDPKEKP(string GEGDHHIDEEF, int AODONKKHPBP)
	{
		ReceiveSetInt(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void LIEFBALIINM()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 8);
	}

	public void ILEEGGJDIJE(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		BEALKMOGAJP(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void FNNMFJODCEF(string GEGDHHIDEEF)
	{
		LOKMOKHAHFL(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void JGCHPDOKJKF(int GJKKNOKIKBJ, int AODONKKHPBP)
	{
		OnlineObjectsManager.instance.GIIGFBIBKKK(uniqueId, GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void JOBDOGGILNF(string GEGDHHIDEEF)
	{
		BLOEANHKHEG(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void SendTeleportCat()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 7, ((Component)this).transform.position.x, ((Component)this).transform.position.y);
	}

	public override void ObjectConfiguration()
	{
		base.ObjectConfiguration();
		Debug.Log((object)("Get Components " + ((Object)((Component)this).gameObject).name));
		catNPC = ((Component)this).gameObject.GetComponent<CatNPC>();
		catNPC.onlineCat = this;
		catNPC.catAnimation.onlineCat = this;
	}

	public void INKCLNLGLHO(int FFDIEOBBFKL)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 2, FFDIEOBBFKL);
	}

	private void EBNENBFLEKB()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		if (uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.SendInstantiateCat(this);
			}
		}
		LFLECAIBFCL = Vector2.op_Implicit(((Component)this).transform.position);
	}

	public void SendMinusRelationship(int FFDIEOBBFKL)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 6, FFDIEOBBFKL);
	}

	public void LOOAJDJELBE(string GEGDHHIDEEF, int AODONKKHPBP)
	{
		JGCHPDOKJKF(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void AHCJAGNLJMI(int GJKKNOKIKBJ, int AODONKKHPBP)
	{
		catNPC.catAnimation.SetInt(GJKKNOKIKBJ, AODONKKHPBP, HALNIEBONKH: true);
	}

	public override void ReceiveAction(byte FACPEEACCMH, params object[] GEMFIOKGIMC)
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		switch ((JDBLOKANBMI)FACPEEACCMH)
		{
		case JDBLOKANBMI.HeadToBed:
		{
			if (OnlineObjectsManager.instance.onlineObjects.TryGetValue((int)GEMFIOKGIMC[0], out var value))
			{
				catNPC.HeadToBed((value as OnlinePlaceable).placeable);
			}
			else
			{
				Debug.LogError((object)("Bed not found! Unique id: " + (int)GEMFIOKGIMC[0]));
			}
			break;
		}
		case JDBLOKANBMI.SetRelationship:
			catNPC.relationshipSystem.SetRelationship((int)GEMFIOKGIMC[0]);
			break;
		case JDBLOKANBMI.MinusRelationship:
			catNPC.MinusRelationship((int)GEMFIOKGIMC[0], CDPAMNIPPEC: false);
			break;
		case JDBLOKANBMI.Teleport:
			KJDJCMLGGLL = true;
			((Component)this).transform.position = Utils.EKCCGNEDPNO(new Vector3((float)GEMFIOKGIMC[0], (float)GEMFIOKGIMC[1], 0f), 1);
			break;
		case JDBLOKANBMI.Eat:
		case JDBLOKANBMI.Pet:
			break;
		}
	}

	public void DDAJJPEBNJG(string GEGDHHIDEEF, int AODONKKHPBP)
	{
		POJFLMOPJPK(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void EPEAPNLFEKG(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		OnlineObjectsManager.instance.SendSetBool(uniqueId, GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void GGCAOODDFDG(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		SendSetBool(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void BLOEANHKHEG(int GJKKNOKIKBJ)
	{
		OnlineObjectsManager.instance.SendSetTrigger(uniqueId, GJKKNOKIKBJ);
	}

	public void MCACMHPPHJA()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 7);
	}

	public void PPEIFPHEDPB(string GEGDHHIDEEF)
	{
		PBPDJMAHHIN(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void ReceiveSetBool(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		ReceiveSetBool(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void ReceiveSetInt(int GJKKNOKIKBJ, int AODONKKHPBP)
	{
		catNPC.catAnimation.SetInt(GJKKNOKIKBJ, AODONKKHPBP, HALNIEBONKH: true);
	}

	public void OFGPFKBHEEM(int GJKKNOKIKBJ, int AODONKKHPBP)
	{
		OnlineObjectsManager.instance.GIIGFBIBKKK(uniqueId, GJKKNOKIKBJ, AODONKKHPBP);
	}

	private void GNMMELIJKML()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		if (uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.SendInstantiateCat(this);
			}
		}
		LFLECAIBFCL = Vector2.op_Implicit(((Component)this).transform.position);
	}

	public void LEEJOEGIEIO()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.PINPKCAOEFL(((Component)this).transform.position))
		{
			OnlineObjectsManager.instance.AddCatMovement(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
		else
		{
			OnlineObjectsManager.instance.AddUntrackedObject(uniqueId);
		}
	}

	public void PBPDJMAHHIN(int GJKKNOKIKBJ)
	{
		catNPC.catAnimation.IDNHDBIKNKP(GJKKNOKIKBJ, HALNIEBONKH: true);
	}

	public void CDDOEEDAGLB(string GEGDHHIDEEF)
	{
		PMNPEEHLDED(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void MEHBENEGLDL(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		ReceiveSetBool(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void NAIEPCANFKD(string GEGDHHIDEEF)
	{
		MNJGNCLHDGK(Animator.StringToHash(GEGDHHIDEEF));
	}

	private void IDHCFOCEPMD()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		if (uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.SendInstantiateCat(this);
			}
		}
		LFLECAIBFCL = Vector2.op_Implicit(((Component)this).transform.position);
	}

	public void PLPCLLDBKHF(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		catNPC.catAnimation.SetBool(GJKKNOKIKBJ, AODONKKHPBP, HALNIEBONKH: true);
	}

	public void SendWakeUpCat()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void GEKOMGIJAFG()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.PINPKCAOEFL(((Component)this).transform.position))
		{
			OnlineObjectsManager.instance.AddCatMovement(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
		else
		{
			OnlineObjectsManager.instance.AddUntrackedObject(uniqueId);
		}
	}

	public void APKKOILFKDG(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		LJEPJCDMDDG(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void NACBLANFEDI(int IHNEJFGAENM)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = IHNEJFGAENM;
		instance.SendObjectAction(bEIPALOAAJJ, 2, array);
	}

	public void EFBAEEFGGJL()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.PINPKCAOEFL(((Component)this).transform.position))
		{
			OnlineObjectsManager.instance.AddCatMovement(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
		else
		{
			OnlineObjectsManager.instance.AddUntrackedObject(uniqueId);
		}
	}

	public void PDGIHGOBFFI(Placeable HJLNPMKIJCI)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = HJLNPMKIJCI.onlinePlaceable.uniqueId;
		instance.SendObjectAction(bEIPALOAAJJ, 4, array);
	}

	public void LAPGBOLIFFK(int GJKKNOKIKBJ, int AODONKKHPBP)
	{
		OnlineObjectsManager.instance.GIIGFBIBKKK(uniqueId, GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void HEPIIDCPJON(string GEGDHHIDEEF, int AODONKKHPBP)
	{
		SendSetInt(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void ReceiveSetTrigger(int GJKKNOKIKBJ)
	{
		catNPC.catAnimation.SetTrigger(GJKKNOKIKBJ, HALNIEBONKH: true);
	}

	public void CAGGICDCDIO(string GEGDHHIDEEF)
	{
		MNJGNCLHDGK(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void PMNPEEHLDED(int GJKKNOKIKBJ)
	{
		catNPC.catAnimation.IDNHDBIKNKP(GJKKNOKIKBJ, HALNIEBONKH: true);
	}

	public void PPILINDJAKB()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.PINPKCAOEFL(((Component)this).transform.position))
		{
			OnlineObjectsManager.instance.AddCatMovement(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
		else
		{
			OnlineObjectsManager.instance.AddUntrackedObject(uniqueId);
		}
	}

	public void SendSetRelationship(int IHNEJFGAENM)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 5, IHNEJFGAENM);
	}

	public void ReceiveSetTrigger(string GEGDHHIDEEF)
	{
		ReceiveSetTrigger(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void POJFLMOPJPK(int GJKKNOKIKBJ, int AODONKKHPBP)
	{
		catNPC.catAnimation.SetInt(GJKKNOKIKBJ, AODONKKHPBP, HALNIEBONKH: true);
	}

	public void FFDGNGPBCLJ(string GEGDHHIDEEF)
	{
		ReceiveSetTrigger(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void PJHLBCDCNDF(string GEGDHHIDEEF)
	{
		ReceiveSetTrigger(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void LJEPJCDMDDG(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		catNPC.catAnimation.SetBool(GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void KAEFKOPAMJD(int FFDIEOBBFKL)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = FFDIEOBBFKL;
		instance.SendObjectAction(bEIPALOAAJJ, 8, array);
	}

	public void SendSetBool(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		SendSetBool(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	protected virtual void KPPIKBFOIFB()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		if (DBEFBFPAOAA < AFMFHCAHEFO && (Object)(object)((Component)this).transform.parent == (Object)null)
		{
			DBEFBFPAOAA += Time.fixedDeltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			((Component)this).transform.position = Vector2.op_Implicit(Vector2.Lerp(LFLECAIBFCL, GNFBPAGOFLH, DCGBADKLANM));
			((Component)this).transform.position = Utils.EKCCGNEDPNO(((Component)this).transform.position, 1);
		}
	}

	public void DAPGDHELGLJ(int GJKKNOKIKBJ)
	{
		catNPC.catAnimation.IDNHDBIKNKP(GJKKNOKIKBJ, HALNIEBONKH: true);
	}

	public void ReceiveSetBool(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		catNPC.catAnimation.SetBool(GJKKNOKIKBJ, AODONKKHPBP, HALNIEBONKH: true);
	}

	public void SendPet()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 4);
	}

	public void NMKIODKCDBF(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		catNPC.catAnimation.SetBool(GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void PIJHDMNPMEH(string GEGDHHIDEEF)
	{
		SendSetTrigger(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void POMDGPDCOBC(Placeable HJLNPMKIJCI)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = HJLNPMKIJCI.onlinePlaceable.uniqueId;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void LLAIGKICEFN()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void LLCNNGPEILA(string GEGDHHIDEEF, int AODONKKHPBP)
	{
		LAPGBOLIFFK(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void BKBPKPJALKE()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void ELIDHMJNJCH()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void KIMJHFINHGK(Placeable HJLNPMKIJCI)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = HJLNPMKIJCI.onlinePlaceable.uniqueId;
		instance.SendObjectAction(bEIPALOAAJJ, 8, array);
	}

	public void NAOCIMPEDFG()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.PINPKCAOEFL(((Component)this).transform.position))
		{
			OnlineObjectsManager.instance.AddCatMovement(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
		else
		{
			OnlineObjectsManager.instance.AddUntrackedObject(uniqueId);
		}
	}

	public void SendStartWalking()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void KLAIIDJCGMB(string GEGDHHIDEEF, int AODONKKHPBP)
	{
		JGCHPDOKJKF(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void BLNFGDFAPHE(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		MAEHKKPKGNM(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void BCNFHPJGHLP()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void LINMNDAOFNJ(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		LJEPJCDMDDG(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void SendSetTrigger(int GJKKNOKIKBJ)
	{
		OnlineObjectsManager.instance.SendSetTrigger(uniqueId, GJKKNOKIKBJ);
	}

	private void Start()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		if (uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.SendInstantiateCat(this);
			}
		}
		LFLECAIBFCL = Vector2.op_Implicit(((Component)this).transform.position);
	}

	public void PLOEJPHGJOP(int IHNEJFGAENM)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 2, IHNEJFGAENM);
	}

	public void JKBIHLINBJA()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.PINPKCAOEFL(((Component)this).transform.position))
		{
			OnlineObjectsManager.instance.AddCatMovement(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
		else
		{
			OnlineObjectsManager.instance.AddUntrackedObject(uniqueId);
		}
	}

	public void EEPOGEEIHCJ(Placeable HJLNPMKIJCI)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 3, HJLNPMKIJCI.onlinePlaceable.uniqueId);
	}

	public void BNCIEEGBHJO(string GEGDHHIDEEF)
	{
		PMNPEEHLDED(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void LIEJPCHMABD()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void CHHAGGGGMLJ(int FFDIEOBBFKL)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = FFDIEOBBFKL;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	private void OIBDBLCLACB()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		if (uniqueId == 0)
		{
			uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.SendInstantiateCat(this);
			}
		}
		LFLECAIBFCL = Vector2.op_Implicit(((Component)this).transform.position);
	}

	public override void ReceiveAction(byte FACPEEACCMH)
	{
		switch ((JDBLOKANBMI)FACPEEACCMH)
		{
		case JDBLOKANBMI.WakeUp:
			catNPC.WakeUp();
			break;
		case JDBLOKANBMI.StartWalking:
			catNPC.StartWalking();
			break;
		case JDBLOKANBMI.Pet:
			catNPC.Pet(1, CDPAMNIPPEC: false);
			break;
		case JDBLOKANBMI.HeadToBed:
		case JDBLOKANBMI.Eat:
			break;
		}
	}

	public void LGCPCMMELEE(int GJKKNOKIKBJ, int AODONKKHPBP)
	{
		OnlineObjectsManager.instance.SendSetInt(uniqueId, GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void JELLKFPMNIF()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void SendSetInt(int GJKKNOKIKBJ, int AODONKKHPBP)
	{
		OnlineObjectsManager.instance.SendSetInt(uniqueId, GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void MAEHKKPKGNM(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		OnlineObjectsManager.instance.SendSetBool(uniqueId, GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void KFKOIHFLIID(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		catNPC.catAnimation.SetBool(GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void DIOBAMEOLAG(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		OnlineObjectsManager.instance.SendSetBool(uniqueId, GJKKNOKIKBJ, AODONKKHPBP);
	}
}
