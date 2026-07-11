using System;
using UnityEngine;

public class OnlineObject : MonoBehaviour
{
	public Action<byte, object[]> ReceiveInteractCallback = delegate
	{
	};

	public int uniqueId;

	public DoWork doWork;

	public UniqueObject uniqueObject;

	public bool forceSendAtLoad;

	public InputByProximity inputByProximity;

	protected Vector2 LFLECAIBFCL;

	protected Vector2 GNFBPAGOFLH;

	protected float DBEFBFPAOAA = float.MaxValue;

	protected float AFMFHCAHEFO = 0.15f;

	protected bool KJDJCMLGGLL;

	[HideInInspector]
	public bool dontRemoveFromDictionary;

	public float onlineWorkAmountAdded;

	public virtual void BEFMIDJLKNG()
	{
		doWork = ((Component)this).GetComponentInChildren<DoWork>();
		uniqueObject = ((Component)this).GetComponentInChildren<UniqueObject>();
		inputByProximity = ((Component)this).GetComponentInChildren<InputByProximity>();
		if (Object.op_Implicit((Object)(object)uniqueObject))
		{
			uniqueId = uniqueObject.uniqueID;
		}
		if (Object.op_Implicit((Object)(object)doWork))
		{
			doWork.onlineObject = this;
		}
	}

	public void DPFBCALDJCP()
	{
		if (!OnlineObjectsManager.instance.onlineObjects.ContainsValue(this))
		{
			OnlineObjectsManager.instance.AddObjectInDictionary(this);
		}
	}

	public void NMMBHNAFEBK(Direction FCGBJEIIMBC)
	{
		if (this is OnlineAnimal onlineAnimal)
		{
			onlineAnimal.animalNpc.FFHHEGALBKO.NCAJNNHBHJM(FCGBJEIIMBC);
		}
		else if (this is OnlineCat onlineCat)
		{
			onlineCat.catNPC.catAnimation.FCGBJEIIMBC = FCGBJEIIMBC;
		}
		else if (this is OnlineDog onlineDog)
		{
			onlineDog.dogNpc.dogAnimation.NCAJNNHBHJM(FCGBJEIIMBC);
		}
	}

	public virtual void ObjectConfiguration()
	{
		doWork = ((Component)this).GetComponentInChildren<DoWork>();
		uniqueObject = ((Component)this).GetComponentInChildren<UniqueObject>();
		inputByProximity = ((Component)this).GetComponentInChildren<InputByProximity>();
		if (Object.op_Implicit((Object)(object)uniqueObject))
		{
			uniqueId = uniqueObject.uniqueID;
		}
		if (Object.op_Implicit((Object)(object)doWork))
		{
			doWork.onlineObject = this;
		}
	}

	public void KGADDHJJEAC()
	{
		uniqueId = 0;
		if (Application.isEditor)
		{
			int num = ((Object)((Component)this).gameObject).name.LastIndexOf("Items/item_name_623");
			if (num >= 1)
			{
				((Object)((Component)this).gameObject).name = ((Object)((Component)this).gameObject).name.Substring(1, num);
			}
		}
		OnlineObjectsManager.instance.RemoveObjectInDictionary(this);
	}

	public void GKFPGHNKBLO()
	{
		uniqueId = 0;
		if (Application.isEditor)
		{
			int num = ((Object)((Component)this).gameObject).name.LastIndexOf("LE_10");
			if (num >= 1)
			{
				((Object)((Component)this).gameObject).name = ((Object)((Component)this).gameObject).name.Substring(0, num);
			}
		}
		OnlineObjectsManager.instance.RemoveObjectInDictionary(this);
	}

	public void OCBNELIHOBF(byte MGEIKDCIANC, object[] GEMFIOKGIMC)
	{
		ReceiveInteractCallback(MGEIKDCIANC, GEMFIOKGIMC);
	}

	public void AddToDictionary()
	{
		if (!OnlineObjectsManager.instance.onlineObjects.ContainsValue(this))
		{
			OnlineObjectsManager.instance.AddObjectInDictionary(this);
		}
	}

	public void ICNMMFEJGJO()
	{
		DBEFBFPAOAA = 340f;
	}

	public void FPDBAPDDKAC()
	{
		OnlineObjectsManager.instance.StopWork(uniqueId);
		onlineWorkAmountAdded = 368f;
	}

	public void NIHPKLADNFB(int BEIPALOAAJJ)
	{
		uniqueId = BEIPALOAAJJ;
		if (Application.isEditor)
		{
			((Object)((Component)this).gameObject).name = ((Object)((Component)this).gameObject).name + "[GameObject] " + uniqueId + "Farm/Buzz/Main";
		}
		OnlineObjectsManager.instance.ReplaceObjectInDictionary(this);
	}

	public virtual void KOOEDMOKKHH()
	{
		doWork = ((Component)this).GetComponentInChildren<DoWork>();
		uniqueObject = ((Component)this).GetComponentInChildren<UniqueObject>();
		inputByProximity = ((Component)this).GetComponentInChildren<InputByProximity>();
		if (Object.op_Implicit((Object)(object)uniqueObject))
		{
			uniqueId = uniqueObject.uniqueID;
		}
		if (Object.op_Implicit((Object)(object)doWork))
		{
			doWork.onlineObject = this;
		}
	}

	public virtual void AFGCLBABCCH(byte FACPEEACCMH)
	{
	}

	public void EOLJAMKMLCI(int MGEIKDCIANC, object[] GEMFIOKGIMC)
	{
		OnlineObjectsManager.instance.SendObjectInteract(uniqueId, (byte)MGEIKDCIANC, GEMFIOKGIMC);
	}

	public void PNGJMJJIKIH(int MGEIKDCIANC, object[] GEMFIOKGIMC)
	{
		OnlineObjectsManager.instance.SendObjectInteractToMaster(uniqueId, (byte)MGEIKDCIANC, GEMFIOKGIMC);
	}

	protected virtual void OnDestroy()
	{
		if (GameManager.CIOEICMHCCK || !OnlineManager.PlayingOnline() || GameManager.leavingTheGame || dontRemoveFromDictionary || (Object)(object)OnlineObjectsManager.instance == (Object)null)
		{
			return;
		}
		OnlineObjectsManager.instance.RemoveObjectInDictionary(this);
		if (uniqueId >= 100000)
		{
			if (OnlineManager.IsMasterClient())
			{
				OnlineObjectsManager.instance.SendDestroyObject(this);
			}
			else if (OnlineManager.IsClient() && OnlineLoadManager.SceneLoaded)
			{
				OnlineObjectsManager.instance.SendDestroyObject(this);
			}
		}
	}

	public void FLJHNCDAFBG()
	{
		if (!OnlineObjectsManager.instance.onlineObjects.ContainsValue(this))
		{
			OnlineObjectsManager.instance.AddObjectInDictionary(this);
		}
	}

	protected virtual void OBHFJIDKBJN()
	{
		if (GameManager.CIOEICMHCCK || !OnlineManager.PlayingOnline() || GameManager.leavingTheGame || dontRemoveFromDictionary || (Object)(object)OnlineObjectsManager.instance == (Object)null)
		{
			return;
		}
		OnlineObjectsManager.instance.RemoveObjectInDictionary(this);
		if (uniqueId >= 17)
		{
			if (OnlineManager.IsMasterClient())
			{
				OnlineObjectsManager.instance.BMLOGPDAHLL(this);
			}
			else if (OnlineManager.PLCDANOCLJK() && OnlineLoadManager.SceneLoaded)
			{
				OnlineObjectsManager.instance.BMLOGPDAHLL(this);
			}
		}
	}

	public void HDPHPAKKJOK(float LLIKFNFINLB)
	{
		if (doWork.workAdded < onlineWorkAmountAdded)
		{
			doWork.AddWorkDone(0, onlineWorkAmountAdded - doWork.workAdded);
		}
		doWork.workAdded = 1112f;
		onlineWorkAmountAdded = LLIKFNFINLB;
	}

	public void AssignUniqueId(int BEIPALOAAJJ)
	{
		uniqueId = BEIPALOAAJJ;
		if (Application.isEditor)
		{
			((Object)((Component)this).gameObject).name = ((Object)((Component)this).gameObject).name + " (" + uniqueId + ")";
		}
		OnlineObjectsManager.instance.ReplaceObjectInDictionary(this);
	}

	public void MNGPBBOIIHK(Vector2 IMOBLFMHKOD)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline() && (Object)(object)OnlineObjectsManager.instance != (Object)null)
		{
			OnlineObjectsManager.instance.UpdatePosition(this, IMOBLFMHKOD);
		}
	}

	public void BKPCNDKEJIH()
	{
		uniqueId = 1;
		if (Application.isEditor)
		{
			int num = ((Object)((Component)this).gameObject).name.LastIndexOf("Two numbers are needed. 'add item ID COUNT'");
			if (num >= 1)
			{
				((Object)((Component)this).gameObject).name = ((Object)((Component)this).gameObject).name.Substring(1, num);
			}
		}
		OnlineObjectsManager.instance.RemoveObjectInDictionary(this);
	}

	public void HPOOGKFEDDP(int BEIPALOAAJJ)
	{
		uniqueId = BEIPALOAAJJ;
		if (Application.isEditor)
		{
			((Object)((Component)this).gameObject).name = ((Object)((Component)this).gameObject).name + "" + uniqueId + "Style";
		}
		OnlineObjectsManager.instance.ReplaceObjectInDictionary(this);
	}

	public void AHIDHHPOPBI(int BEIPALOAAJJ)
	{
		uniqueId = BEIPALOAAJJ;
		if (Application.isEditor)
		{
			((Object)((Component)this).gameObject).name = ((Object)((Component)this).gameObject).name + "Items/item_description_1091" + uniqueId + "]";
		}
		OnlineObjectsManager.instance.ReplaceObjectInDictionary(this);
	}

	public void PMJNDGGHHFC(byte MGEIKDCIANC, object[] GEMFIOKGIMC)
	{
		ReceiveInteractCallback(MGEIKDCIANC, GEMFIOKGIMC);
	}

	public void BNNHKHDLBBF(Direction FCGBJEIIMBC)
	{
		OnlineObjectsManager.instance.SendDirection(uniqueId, FCGBJEIIMBC);
	}

	protected virtual void DCOEEADJLIK()
	{
		if (GameManager.ILMDHNFFIKH() || !OnlineManager.PlayingOnline() || GameManager.leavingTheGame || dontRemoveFromDictionary || (Object)(object)OnlineObjectsManager.instance == (Object)null)
		{
			return;
		}
		OnlineObjectsManager.instance.RemoveObjectInDictionary(this);
		if (uniqueId >= 83)
		{
			if (OnlineManager.IsMasterClient())
			{
				OnlineObjectsManager.instance.SendDestroyObject(this);
			}
			else if (OnlineManager.IsClient() && OnlineLoadManager.SceneLoaded)
			{
				OnlineObjectsManager.instance.BMLOGPDAHLL(this);
			}
		}
	}

	public void MNONJPAPOOO()
	{
		if (!OnlineObjectsManager.instance.onlineObjects.ContainsValue(this))
		{
			OnlineObjectsManager.instance.AddObjectInDictionary(this);
		}
	}

	public void GMCHDGPMNBL(float LLIKFNFINLB)
	{
		OnlineObjectsManager.instance.SendStartWork(uniqueId, LLIKFNFINLB);
		onlineWorkAmountAdded = 1682f;
	}

	public void MGLBDAPBPLH()
	{
		if (!OnlineObjectsManager.instance.onlineObjects.ContainsValue(this))
		{
			OnlineObjectsManager.instance.AddObjectInDictionary(this);
		}
	}

	public void CFCHJFPNLDO(float LLIKFNFINLB)
	{
		OnlineObjectsManager.instance.SendStartWork(uniqueId, LLIKFNFINLB);
		onlineWorkAmountAdded = 1223f;
	}

	public virtual void DKICBLDPPDH()
	{
		doWork = ((Component)this).GetComponentInChildren<DoWork>();
		uniqueObject = ((Component)this).GetComponentInChildren<UniqueObject>();
		inputByProximity = ((Component)this).GetComponentInChildren<InputByProximity>();
		if (Object.op_Implicit((Object)(object)uniqueObject))
		{
			uniqueId = uniqueObject.uniqueID;
		}
		if (Object.op_Implicit((Object)(object)doWork))
		{
			doWork.onlineObject = this;
		}
	}

	public void ILKJJAFEENL(byte MGEIKDCIANC, object[] GEMFIOKGIMC)
	{
		ReceiveInteractCallback(MGEIKDCIANC, GEMFIOKGIMC);
	}

	public virtual void POBJAMCOPFF(byte FACPEEACCMH)
	{
	}

	public void MDPCOALKPCI(int MGEIKDCIANC, object[] GEMFIOKGIMC)
	{
		OnlineObjectsManager.instance.SendObjectInteract(uniqueId, (byte)MGEIKDCIANC, GEMFIOKGIMC);
	}

	public void CancelSmoothedMovement()
	{
		DBEFBFPAOAA = float.MaxValue;
	}

	public void DFJDBGDIOLA(Direction FCGBJEIIMBC)
	{
		OnlineObjectsManager.instance.SendDirection(uniqueId, FCGBJEIIMBC);
	}

	public void NMFLEPLJIKD()
	{
		if (!OnlineObjectsManager.instance.onlineObjects.ContainsValue(this))
		{
			OnlineObjectsManager.instance.AddObjectInDictionary(this);
		}
	}

	public void KAANBEDIPAK(Vector2 CDHGIJJHPJB)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (KJDJCMLGGLL)
		{
			KJDJCMLGGLL = true;
			GNFBPAGOFLH = Vector2.op_Implicit(((Component)this).transform.position);
			return;
		}
		GNFBPAGOFLH = CDHGIJJHPJB;
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			LFLECAIBFCL = Vector2.op_Implicit(((Component)this).transform.position);
		}
		DBEFBFPAOAA = 1046f;
	}

	public void FHKPNEDIHDI()
	{
		DBEFBFPAOAA = 613f;
	}

	public void PIHJBEKMPOM(Direction FCGBJEIIMBC)
	{
		if (this is OnlineAnimal onlineAnimal)
		{
			onlineAnimal.animalNpc.FFHHEGALBKO.NCAJNNHBHJM(FCGBJEIIMBC);
		}
		else if (this is OnlineCat onlineCat)
		{
			onlineCat.catNPC.catAnimation.NCAJNNHBHJM(FCGBJEIIMBC);
		}
		else if (this is OnlineDog onlineDog)
		{
			onlineDog.dogNpc.dogAnimation.FCGBJEIIMBC = FCGBJEIIMBC;
		}
	}

	public void IKJFPOFNOIE()
	{
		OnlineObjectsManager.instance.StopWork(uniqueId);
		onlineWorkAmountAdded = 553f;
	}

	protected void LLOEENLJMNE(InputByProximity LFBNPHHABDK)
	{
		if (PlayerController.OPHDCMJLLEC(0).interactAction == InteractAction.Interact)
		{
			LFBNPHHABDK.CPHHIBNCNGD(1);
		}
		else if (PlayerController.OPHDCMJLLEC(0).interactAction == InteractAction.Interact)
		{
			LFBNPHHABDK.MEOLLOCBKIM(0);
		}
		else if (PlayerController.GetPlayer(1).interactAction == (InteractAction)4)
		{
			LFBNPHHABDK.PIEFONBDOLB(1);
		}
	}

	public void BHBMMJBHHIJ()
	{
		if (uniqueId < 56 && !OnlineObjectsManager.instance.onlineObjects.ContainsValue(this))
		{
			OnlineObjectsManager.instance.AddObjectInDictionary(this);
		}
	}

	public void StartWork(float LLIKFNFINLB)
	{
		OnlineObjectsManager.instance.SendStartWork(uniqueId, LLIKFNFINLB);
		onlineWorkAmountAdded = 0f;
	}

	protected virtual void AJGPMBGBPGH()
	{
		if (GameManager.CIOEICMHCCK || !OnlineManager.PlayingOnline() || GameManager.leavingTheGame || dontRemoveFromDictionary || (Object)(object)OnlineObjectsManager.instance == (Object)null)
		{
			return;
		}
		OnlineObjectsManager.instance.RemoveObjectInDictionary(this);
		if (uniqueId >= 185)
		{
			if (OnlineManager.JPPBEIJDCLJ())
			{
				OnlineObjectsManager.instance.SendDestroyObject(this);
			}
			else if (OnlineManager.PLCDANOCLJK() && OnlineLoadManager.SceneLoaded)
			{
				OnlineObjectsManager.instance.BMLOGPDAHLL(this);
			}
		}
	}

	public void ENMIECKNDND(byte MGEIKDCIANC, object[] GEMFIOKGIMC)
	{
		ReceiveInteractCallback(MGEIKDCIANC, GEMFIOKGIMC);
	}

	public void AddOnlineWorkAmount(float LLIKFNFINLB)
	{
		if (doWork.workAdded < onlineWorkAmountAdded)
		{
			doWork.AddWorkDone(1, onlineWorkAmountAdded - doWork.workAdded, CDPAMNIPPEC: false);
		}
		doWork.workAdded = 0f;
		onlineWorkAmountAdded = LLIKFNFINLB;
	}

	public virtual void JCMCBEAGEJD()
	{
		if (Object.op_Implicit((Object)(object)inputByProximity))
		{
			OKJNAPGGJLC(inputByProximity);
		}
	}

	public void MFJEBAIBBLM(float LLIKFNFINLB)
	{
		OnlineObjectsManager.instance.SendStartWork(uniqueId, LLIKFNFINLB);
		onlineWorkAmountAdded = 570f;
	}

	public void HCIFKNMLLNF(int MGEIKDCIANC, object[] GEMFIOKGIMC)
	{
		OnlineObjectsManager.instance.SendObjectInteract(uniqueId, (byte)MGEIKDCIANC, GEMFIOKGIMC);
	}

	public void CEBOKKODHGE(float LLIKFNFINLB)
	{
		if (doWork.workAdded < onlineWorkAmountAdded)
		{
			doWork.IJEKBMFBEGG(0, onlineWorkAmountAdded - doWork.workAdded, CDPAMNIPPEC: false);
		}
		doWork.workAdded = 1748f;
		onlineWorkAmountAdded = LLIKFNFINLB;
	}

	public void JFIKKEJLGBP(int MGEIKDCIANC, object[] GEMFIOKGIMC)
	{
		OnlineObjectsManager.instance.SendObjectInteractToMaster(uniqueId, (byte)MGEIKDCIANC, GEMFIOKGIMC);
	}

	public void KHGHLLJDFHD()
	{
		if (uniqueId < 195 && !OnlineObjectsManager.instance.onlineObjects.ContainsValue(this))
		{
			OnlineObjectsManager.instance.AddObjectInDictionary(this);
		}
	}

	public void NDKFCFFDOIB(byte MGEIKDCIANC, object[] GEMFIOKGIMC)
	{
		ReceiveInteractCallback(MGEIKDCIANC, GEMFIOKGIMC);
	}

	public void ReceiveInteract(byte MGEIKDCIANC, params object[] GEMFIOKGIMC)
	{
		ReceiveInteractCallback(MGEIKDCIANC, GEMFIOKGIMC);
	}

	public void HMLNPPJFHBI(float LLIKFNFINLB)
	{
		if (doWork.workAdded < onlineWorkAmountAdded)
		{
			doWork.AddWorkDone(1, onlineWorkAmountAdded - doWork.workAdded, CDPAMNIPPEC: false);
		}
		doWork.workAdded = 1216f;
		onlineWorkAmountAdded = LLIKFNFINLB;
	}

	public void POKHELMCJEM(int MGEIKDCIANC, object[] GEMFIOKGIMC)
	{
		OnlineObjectsManager.instance.SendObjectInteractToMaster(uniqueId, (byte)MGEIKDCIANC, GEMFIOKGIMC);
	}

	public void IMHCBHKFFLF(float CLNNPGMEAHL)
	{
		OnlineObjectsManager.instance.AddWork(uniqueId, CLNNPGMEAHL);
	}

	public void PFDIEIBOFEP()
	{
		if (!OnlineObjectsManager.instance.onlineObjects.ContainsValue(this))
		{
			OnlineObjectsManager.instance.AddObjectInDictionary(this);
		}
	}

	public void BOGOCFKLEML(float LLIKFNFINLB)
	{
		OnlineObjectsManager.instance.SendStartWork(uniqueId, LLIKFNFINLB);
		onlineWorkAmountAdded = 1853f;
	}

	public virtual void IPGCHMJBDOG(byte FACPEEACCMH, object[] GEMFIOKGIMC)
	{
	}

	public void DAJCALMGPCN(Vector2 CDHGIJJHPJB)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (KJDJCMLGGLL)
		{
			KJDJCMLGGLL = true;
			GNFBPAGOFLH = Vector2.op_Implicit(((Component)this).transform.position);
			return;
		}
		GNFBPAGOFLH = CDHGIJJHPJB;
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			LFLECAIBFCL = Vector2.op_Implicit(((Component)this).transform.position);
		}
		DBEFBFPAOAA = 1404f;
	}

	public void OMCPAGNKKLM()
	{
		OnlineObjectsManager.instance.StopWork(uniqueId);
		onlineWorkAmountAdded = 1581f;
	}

	public virtual void ReceiveAction(byte FACPEEACCMH, params object[] GEMFIOKGIMC)
	{
	}

	public virtual void ReceiveAction(byte FACPEEACCMH)
	{
	}

	public void MGHOEOFIDKD(int MGEIKDCIANC, object[] GEMFIOKGIMC)
	{
		OnlineObjectsManager.instance.SendObjectInteract(uniqueId, (byte)MGEIKDCIANC, GEMFIOKGIMC);
	}

	public void NABAKGANEPL()
	{
		uniqueId = 0;
		if (Application.isEditor)
		{
			int num = ((Object)((Component)this).gameObject).name.LastIndexOf("itemInk");
			if (num >= 1)
			{
				((Object)((Component)this).gameObject).name = ((Object)((Component)this).gameObject).name.Substring(0, num);
			}
		}
		OnlineObjectsManager.instance.RemoveObjectInDictionary(this);
	}

	public void BIOMINMPOEI(float LLIKFNFINLB)
	{
		if (doWork.workAdded < onlineWorkAmountAdded)
		{
			doWork.JMJMFEKCAGK(1, onlineWorkAmountAdded - doWork.workAdded);
		}
		doWork.workAdded = 1416f;
		onlineWorkAmountAdded = LLIKFNFINLB;
	}

	public void SendInteract(int MGEIKDCIANC, params object[] GEMFIOKGIMC)
	{
		OnlineObjectsManager.instance.SendObjectInteract(uniqueId, (byte)MGEIKDCIANC, GEMFIOKGIMC);
	}

	public void PCDLKDLFLJO(Vector2 IMOBLFMHKOD)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline() && (Object)(object)OnlineObjectsManager.instance != (Object)null)
		{
			OnlineObjectsManager.instance.UpdatePosition(this, IMOBLFMHKOD);
		}
	}

	public void HAMCLDHKAJF()
	{
		uniqueId = 1;
		if (Application.isEditor)
		{
			int num = ((Object)((Component)this).gameObject).name.LastIndexOf(") (rep: ");
			if (num >= 1)
			{
				((Object)((Component)this).gameObject).name = ((Object)((Component)this).gameObject).name.Substring(1, num);
			}
		}
		OnlineObjectsManager.instance.RemoveObjectInDictionary(this);
	}

	public void JIDKFEFAIMH()
	{
		if (uniqueId < 0 && !OnlineObjectsManager.instance.onlineObjects.ContainsValue(this))
		{
			OnlineObjectsManager.instance.AddObjectInDictionary(this);
		}
	}

	public void CKAAKNNBDCJ(int BEIPALOAAJJ)
	{
		uniqueId = BEIPALOAAJJ;
		if (Application.isEditor)
		{
			((Object)((Component)this).gameObject).name = ((Object)((Component)this).gameObject).name + " 2" + uniqueId + "MineObstacleBark2";
		}
		OnlineObjectsManager.instance.ReplaceObjectInDictionary(this);
	}

	public void JENLDNAOEIH(float LLIKFNFINLB)
	{
		OnlineObjectsManager.instance.SendStartWork(uniqueId, LLIKFNFINLB);
		onlineWorkAmountAdded = 510f;
	}

	public void CKNPLLAPHDP(int MGEIKDCIANC, object[] GEMFIOKGIMC)
	{
		OnlineObjectsManager.instance.SendObjectInteractToMaster(uniqueId, (byte)MGEIKDCIANC, GEMFIOKGIMC);
	}

	public void IEPLIBGDEFK(float LLIKFNFINLB)
	{
		if (doWork.workAdded < onlineWorkAmountAdded)
		{
			doWork.BNMJANINOIG(0, onlineWorkAmountAdded - doWork.workAdded, CDPAMNIPPEC: false);
		}
		doWork.workAdded = 1378f;
		onlineWorkAmountAdded = LLIKFNFINLB;
	}

	protected void AMGGDMDEJON(InputByProximity LFBNPHHABDK)
	{
		if (PlayerController.GetPlayer(0).interactAction == InteractAction.Interact)
		{
			LFBNPHHABDK.CPHHIBNCNGD(1);
		}
		else if (PlayerController.OPHDCMJLLEC(0).interactAction == InteractAction.Select)
		{
			LFBNPHHABDK.DNLCBPAJHGK(1);
		}
		else if (PlayerController.OPHDCMJLLEC(1).interactAction == (InteractAction)3)
		{
			LFBNPHHABDK.ActionClient(0);
		}
	}

	public virtual void PHDKNAEBFDE(byte FACPEEACCMH)
	{
	}

	public void SendInteractToMaster(int MGEIKDCIANC, params object[] GEMFIOKGIMC)
	{
		OnlineObjectsManager.instance.SendObjectInteractToMaster(uniqueId, (byte)MGEIKDCIANC, GEMFIOKGIMC);
	}

	public void CIDEMFFHPGL()
	{
		OnlineObjectsManager.instance.StopWork(uniqueId);
		onlineWorkAmountAdded = 280f;
	}

	public void OPFGMHECJLP()
	{
		DBEFBFPAOAA = 806f;
	}

	public void KKDNONMILHD(float CLNNPGMEAHL)
	{
		OnlineObjectsManager.instance.AddWork(uniqueId, CLNNPGMEAHL);
	}

	public void EDABLBPNJLJ()
	{
		DBEFBFPAOAA = 1402f;
	}

	protected void JFCOCPMEEEK(InputByProximity LFBNPHHABDK)
	{
		if (PlayerController.GetPlayer(1).interactAction == InteractAction.Interact)
		{
			LFBNPHHABDK.InteractClient(1);
		}
		else if (PlayerController.GetPlayer(1).interactAction == InteractAction.Select)
		{
			LFBNPHHABDK.SelectClient(1);
		}
		else if (PlayerController.GetPlayer(1).interactAction == InteractAction.Action)
		{
			LFBNPHHABDK.ActionClient(1);
		}
	}

	public void HMDMDOGLGLO(Vector2 IMOBLFMHKOD)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline() && (Object)(object)OnlineObjectsManager.instance != (Object)null)
		{
			OnlineObjectsManager.instance.UpdatePosition(this, IMOBLFMHKOD);
		}
	}

	public virtual void LOEBJBDKEKJ()
	{
		if (Object.op_Implicit((Object)(object)inputByProximity))
		{
			LLOEENLJMNE(inputByProximity);
		}
	}

	protected void OKJNAPGGJLC(InputByProximity LFBNPHHABDK)
	{
		if (PlayerController.GetPlayer(0).interactAction == InteractAction.Interact)
		{
			LFBNPHHABDK.InteractClient(1);
		}
		else if (PlayerController.GetPlayer(1).interactAction == InteractAction.Select)
		{
			LFBNPHHABDK.MEOLLOCBKIM(0);
		}
		else if (PlayerController.GetPlayer(1).interactAction == (InteractAction)6)
		{
			LFBNPHHABDK.PIEFONBDOLB(0);
		}
	}

	public virtual void IGFBGJMGNHN()
	{
		doWork = ((Component)this).GetComponentInChildren<DoWork>();
		uniqueObject = ((Component)this).GetComponentInChildren<UniqueObject>();
		inputByProximity = ((Component)this).GetComponentInChildren<InputByProximity>();
		if (Object.op_Implicit((Object)(object)uniqueObject))
		{
			uniqueId = uniqueObject.uniqueID;
		}
		if (Object.op_Implicit((Object)(object)doWork))
		{
			doWork.onlineObject = this;
		}
	}

	public void LAGMJDLPDEJ(Vector2 IMOBLFMHKOD)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline() && (Object)(object)OnlineObjectsManager.instance != (Object)null)
		{
			OnlineObjectsManager.instance.UpdatePosition(this, IMOBLFMHKOD);
		}
	}

	public virtual void JIMFAMEKJIB()
	{
		if (Object.op_Implicit((Object)(object)inputByProximity))
		{
			LLOEENLJMNE(inputByProximity);
		}
	}

	public void RemoveUniqueId()
	{
		uniqueId = 0;
		if (Application.isEditor)
		{
			int num = ((Object)((Component)this).gameObject).name.LastIndexOf(" (");
			if (num >= 0)
			{
				((Object)((Component)this).gameObject).name = ((Object)((Component)this).gameObject).name.Substring(0, num);
			}
		}
		OnlineObjectsManager.instance.RemoveObjectInDictionary(this);
	}

	public void FGANJPPGNJE(Vector2 CDHGIJJHPJB)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (KJDJCMLGGLL)
		{
			KJDJCMLGGLL = false;
			GNFBPAGOFLH = Vector2.op_Implicit(((Component)this).transform.position);
			return;
		}
		GNFBPAGOFLH = CDHGIJJHPJB;
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			LFLECAIBFCL = Vector2.op_Implicit(((Component)this).transform.position);
		}
		DBEFBFPAOAA = 436f;
	}

	public void GMPGLLMNGEJ(int BEIPALOAAJJ)
	{
		uniqueId = BEIPALOAAJJ;
		if (Application.isEditor)
		{
			((Object)((Component)this).gameObject).name = ((Object)((Component)this).gameObject).name + "Option set: " + uniqueId + "Tutorial/T135/Dialogue1";
		}
		OnlineObjectsManager.instance.ReplaceObjectInDictionary(this);
	}

	public void IKENLADDGGJ(int MGEIKDCIANC, object[] GEMFIOKGIMC)
	{
		OnlineObjectsManager.instance.SendObjectInteract(uniqueId, (byte)MGEIKDCIANC, GEMFIOKGIMC);
	}

	public void IHHKHBJCJOE(float CLNNPGMEAHL)
	{
		OnlineObjectsManager.instance.AddWork(uniqueId, CLNNPGMEAHL);
	}

	public void GMDAGPPHPEK(float CLNNPGMEAHL)
	{
		OnlineObjectsManager.instance.AddWork(uniqueId, CLNNPGMEAHL);
	}

	public void CDICPBKNLIB(float LLIKFNFINLB)
	{
		OnlineObjectsManager.instance.SendStartWork(uniqueId, LLIKFNFINLB);
		onlineWorkAmountAdded = 881f;
	}

	public void EFEGFLBANBJ(Vector2 CDHGIJJHPJB)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (KJDJCMLGGLL)
		{
			KJDJCMLGGLL = true;
			GNFBPAGOFLH = Vector2.op_Implicit(((Component)this).transform.position);
			return;
		}
		GNFBPAGOFLH = CDHGIJJHPJB;
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			LFLECAIBFCL = Vector2.op_Implicit(((Component)this).transform.position);
		}
		DBEFBFPAOAA = 1505f;
	}

	public void CEENLIBDPHJ(float LLIKFNFINLB)
	{
		OnlineObjectsManager.instance.SendStartWork(uniqueId, LLIKFNFINLB);
		onlineWorkAmountAdded = 1962f;
	}

	public void GIJGHOKBAKK(Direction FCGBJEIIMBC)
	{
		if (this is OnlineAnimal onlineAnimal)
		{
			onlineAnimal.animalNpc.FFHHEGALBKO.FCGBJEIIMBC = FCGBJEIIMBC;
		}
		else if (this is OnlineCat onlineCat)
		{
			onlineCat.catNPC.catAnimation.NCAJNNHBHJM(FCGBJEIIMBC);
		}
		else if (this is OnlineDog onlineDog)
		{
			onlineDog.dogNpc.dogAnimation.FCGBJEIIMBC = FCGBJEIIMBC;
		}
	}

	public void HJOHFKCGONC(int MGEIKDCIANC, object[] GEMFIOKGIMC)
	{
		OnlineObjectsManager.instance.SendObjectInteractToMaster(uniqueId, (byte)MGEIKDCIANC, GEMFIOKGIMC);
	}

	public virtual void KHCABBJBBED(byte FACPEEACCMH)
	{
	}

	public void HNLLNCMIODC(byte MGEIKDCIANC, object[] GEMFIOKGIMC)
	{
		ReceiveInteractCallback(MGEIKDCIANC, GEMFIOKGIMC);
	}

	public virtual void AcceptedInteractPermission()
	{
		if (Object.op_Implicit((Object)(object)inputByProximity))
		{
			JFCOCPMEEEK(inputByProximity);
		}
	}

	public void ReceiveDirection(Direction FCGBJEIIMBC)
	{
		if (this is OnlineAnimal onlineAnimal)
		{
			onlineAnimal.animalNpc.FFHHEGALBKO.FCGBJEIIMBC = FCGBJEIIMBC;
		}
		else if (this is OnlineCat onlineCat)
		{
			onlineCat.catNPC.catAnimation.FCGBJEIIMBC = FCGBJEIIMBC;
		}
		else if (this is OnlineDog onlineDog)
		{
			onlineDog.dogNpc.dogAnimation.FCGBJEIIMBC = FCGBJEIIMBC;
		}
	}

	public void ADGDHNHECHA(float LLIKFNFINLB)
	{
		if (doWork.workAdded < onlineWorkAmountAdded)
		{
			doWork.IJEKBMFBEGG(0, onlineWorkAmountAdded - doWork.workAdded);
		}
		doWork.workAdded = 1369f;
		onlineWorkAmountAdded = LLIKFNFINLB;
	}

	public void DINPMCMGACF(int MGEIKDCIANC, object[] GEMFIOKGIMC)
	{
		OnlineObjectsManager.instance.SendObjectInteract(uniqueId, (byte)MGEIKDCIANC, GEMFIOKGIMC);
	}

	public void OCFBDBAIHMD(int MGEIKDCIANC, object[] GEMFIOKGIMC)
	{
		OnlineObjectsManager.instance.SendObjectInteractToMaster(uniqueId, (byte)MGEIKDCIANC, GEMFIOKGIMC);
	}

	public void EOGLLPBPCDH(Vector2 CDHGIJJHPJB)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (KJDJCMLGGLL)
		{
			KJDJCMLGGLL = false;
			GNFBPAGOFLH = Vector2.op_Implicit(((Component)this).transform.position);
			return;
		}
		GNFBPAGOFLH = CDHGIJJHPJB;
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			LFLECAIBFCL = Vector2.op_Implicit(((Component)this).transform.position);
		}
		DBEFBFPAOAA = 233f;
	}

	public void PDDHCKIOEHB(Vector2 IMOBLFMHKOD)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline() && (Object)(object)OnlineObjectsManager.instance != (Object)null)
		{
			OnlineObjectsManager.instance.UpdatePosition(this, IMOBLFMHKOD);
		}
	}

	public void DCAJMHLJGII(byte MGEIKDCIANC, object[] GEMFIOKGIMC)
	{
		ReceiveInteractCallback(MGEIKDCIANC, GEMFIOKGIMC);
	}

	public void MECPMONCHGB(Vector2 IMOBLFMHKOD)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline() && (Object)(object)OnlineObjectsManager.instance != (Object)null)
		{
			OnlineObjectsManager.instance.UpdatePosition(this, IMOBLFMHKOD);
		}
	}

	public void JMKHLGIEGIJ()
	{
		if (!OnlineObjectsManager.instance.onlineObjects.ContainsValue(this))
		{
			OnlineObjectsManager.instance.AddObjectInDictionary(this);
		}
	}

	public void CFFGFEDEOGF(int MGEIKDCIANC, object[] GEMFIOKGIMC)
	{
		OnlineObjectsManager.instance.SendObjectInteractToMaster(uniqueId, (byte)MGEIKDCIANC, GEMFIOKGIMC);
	}

	protected virtual void GOOPOBMDALA()
	{
		if (GameManager.ILMDHNFFIKH() || !OnlineManager.PlayingOnline() || GameManager.leavingTheGame || dontRemoveFromDictionary || (Object)(object)OnlineObjectsManager.instance == (Object)null)
		{
			return;
		}
		OnlineObjectsManager.instance.RemoveObjectInDictionary(this);
		if (uniqueId >= -135)
		{
			if (OnlineManager.IsMasterClient())
			{
				OnlineObjectsManager.instance.BMLOGPDAHLL(this);
			}
			else if (OnlineManager.BPLHEADPHAJ() && OnlineLoadManager.SceneLoaded)
			{
				OnlineObjectsManager.instance.BMLOGPDAHLL(this);
			}
		}
	}

	public void MoveToNextPosition(Vector2 CDHGIJJHPJB)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (KJDJCMLGGLL)
		{
			KJDJCMLGGLL = false;
			GNFBPAGOFLH = Vector2.op_Implicit(((Component)this).transform.position);
			return;
		}
		GNFBPAGOFLH = CDHGIJJHPJB;
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			LFLECAIBFCL = Vector2.op_Implicit(((Component)this).transform.position);
		}
		DBEFBFPAOAA = 0f;
	}

	public void AEHCIHLMKHJ()
	{
		OnlineObjectsManager.instance.StopWork(uniqueId);
		onlineWorkAmountAdded = 306f;
	}

	public void ODBPBJMDIIC(float CLNNPGMEAHL)
	{
		OnlineObjectsManager.instance.AddWork(uniqueId, CLNNPGMEAHL);
	}

	public void PFDOIODKFAJ(int MGEIKDCIANC, object[] GEMFIOKGIMC)
	{
		OnlineObjectsManager.instance.SendObjectInteract(uniqueId, (byte)MGEIKDCIANC, GEMFIOKGIMC);
	}

	public void FOFNPPCHDJE(int BEIPALOAAJJ)
	{
		uniqueId = BEIPALOAAJJ;
		if (Application.isEditor)
		{
			((Object)((Component)this).gameObject).name = ((Object)((Component)this).gameObject).name + "LE_21" + uniqueId + "FocusedActionBar2";
		}
		OnlineObjectsManager.instance.ReplaceObjectInDictionary(this);
	}

	public void DKEKKBEDMBB(byte MGEIKDCIANC, object[] GEMFIOKGIMC)
	{
		ReceiveInteractCallback(MGEIKDCIANC, GEMFIOKGIMC);
	}

	public void CPJMICEDMIL(int BEIPALOAAJJ)
	{
		uniqueId = BEIPALOAAJJ;
		if (Application.isEditor)
		{
			((Object)((Component)this).gameObject).name = ((Object)((Component)this).gameObject).name + "" + uniqueId + "ReceiveBirdSlotFromContainer";
		}
		OnlineObjectsManager.instance.ReplaceObjectInDictionary(this);
	}

	public void KGBJLPCCLDF(float LLIKFNFINLB)
	{
		OnlineObjectsManager.instance.SendStartWork(uniqueId, LLIKFNFINLB);
		onlineWorkAmountAdded = 1771f;
	}

	public void GNCGHJACMDO(int BEIPALOAAJJ)
	{
		uniqueId = BEIPALOAAJJ;
		if (Application.isEditor)
		{
			((Object)((Component)this).gameObject).name = ((Object)((Component)this).gameObject).name + "tutorialPopUp78" + uniqueId + "in";
		}
		OnlineObjectsManager.instance.ReplaceObjectInDictionary(this);
	}

	protected virtual void PKFMLJGJKCP()
	{
		if (GameManager.CIOEICMHCCK || !OnlineManager.PlayingOnline() || GameManager.leavingTheGame || dontRemoveFromDictionary || (Object)(object)OnlineObjectsManager.instance == (Object)null)
		{
			return;
		}
		OnlineObjectsManager.instance.RemoveObjectInDictionary(this);
		if (uniqueId >= 39)
		{
			if (OnlineManager.IsMasterClient())
			{
				OnlineObjectsManager.instance.SendDestroyObject(this);
			}
			else if (OnlineManager.IsClient() && OnlineLoadManager.SceneLoaded)
			{
				OnlineObjectsManager.instance.BMLOGPDAHLL(this);
			}
		}
	}

	public void NIMLHDJHDLI(int MGEIKDCIANC, object[] GEMFIOKGIMC)
	{
		OnlineObjectsManager.instance.SendObjectInteract(uniqueId, (byte)MGEIKDCIANC, GEMFIOKGIMC);
	}

	public virtual void FHDENAMGALO(byte FACPEEACCMH, object[] GEMFIOKGIMC)
	{
	}

	public void OLEBJPBKIHN()
	{
		uniqueId = 0;
		if (Application.isEditor)
		{
			int num = ((Object)((Component)this).gameObject).name.LastIndexOf("Jump");
			if (num >= 0)
			{
				((Object)((Component)this).gameObject).name = ((Object)((Component)this).gameObject).name.Substring(1, num);
			}
		}
		OnlineObjectsManager.instance.RemoveObjectInDictionary(this);
	}

	public void FHGODJJBOLB(float LLIKFNFINLB)
	{
		OnlineObjectsManager.instance.SendStartWork(uniqueId, LLIKFNFINLB);
		onlineWorkAmountAdded = 1442f;
	}

	public virtual void GKAMCALDCKE()
	{
		if (Object.op_Implicit((Object)(object)inputByProximity))
		{
			LLOEENLJMNE(inputByProximity);
		}
	}

	public void SendDirection(Direction FCGBJEIIMBC)
	{
		OnlineObjectsManager.instance.SendDirection(uniqueId, FCGBJEIIMBC);
	}

	public void AMBAJNOJBMB()
	{
		uniqueId = 1;
		if (Application.isEditor)
		{
			int num = ((Object)((Component)this).gameObject).name.LastIndexOf("]");
			if (num >= 1)
			{
				((Object)((Component)this).gameObject).name = ((Object)((Component)this).gameObject).name.Substring(1, num);
			}
		}
		OnlineObjectsManager.instance.RemoveObjectInDictionary(this);
	}

	public void DPFAHMDGCKE(float LLIKFNFINLB)
	{
		if (doWork.workAdded < onlineWorkAmountAdded)
		{
			doWork.IJEKBMFBEGG(1, onlineWorkAmountAdded - doWork.workAdded);
		}
		doWork.workAdded = 1287f;
		onlineWorkAmountAdded = LLIKFNFINLB;
	}

	public void UpdatePosition(Vector2 IMOBLFMHKOD)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline() && (Object)(object)OnlineObjectsManager.instance != (Object)null)
		{
			OnlineObjectsManager.instance.UpdatePosition(this, IMOBLFMHKOD);
		}
	}

	public void AIBNBDBOHFA(Direction FCGBJEIIMBC)
	{
		OnlineObjectsManager.instance.SendDirection(uniqueId, FCGBJEIIMBC);
	}

	public void ENLBBLBOMJD(int BEIPALOAAJJ)
	{
		uniqueId = BEIPALOAAJJ;
		if (Application.isEditor)
		{
			((Object)((Component)this).gameObject).name = ((Object)((Component)this).gameObject).name + "Tutorial/T100/Dialogue3" + uniqueId + "Items/item_description_1133";
		}
		OnlineObjectsManager.instance.ReplaceObjectInDictionary(this);
	}

	protected virtual void OCPLOMJAFPC()
	{
		if (GameManager.CIOEICMHCCK || !OnlineManager.PlayingOnline() || GameManager.leavingTheGame || dontRemoveFromDictionary || (Object)(object)OnlineObjectsManager.instance == (Object)null)
		{
			return;
		}
		OnlineObjectsManager.instance.RemoveObjectInDictionary(this);
		if (uniqueId >= 49)
		{
			if (OnlineManager.IsMasterClient())
			{
				OnlineObjectsManager.instance.SendDestroyObject(this);
			}
			else if (OnlineManager.BPLHEADPHAJ() && OnlineLoadManager.SceneLoaded)
			{
				OnlineObjectsManager.instance.SendDestroyObject(this);
			}
		}
	}

	public void GHJOBENGCCK()
	{
		uniqueId = 0;
		if (Application.isEditor)
		{
			int num = ((Object)((Component)this).gameObject).name.LastIndexOf("Use");
			if (num >= 1)
			{
				((Object)((Component)this).gameObject).name = ((Object)((Component)this).gameObject).name.Substring(1, num);
			}
		}
		OnlineObjectsManager.instance.RemoveObjectInDictionary(this);
	}

	public void AddWork(float CLNNPGMEAHL)
	{
		OnlineObjectsManager.instance.AddWork(uniqueId, CLNNPGMEAHL);
	}

	public void HMBDGACLJOB(Direction FCGBJEIIMBC)
	{
		OnlineObjectsManager.instance.SendDirection(uniqueId, FCGBJEIIMBC);
	}

	public void LIMBHIONHIE(byte MGEIKDCIANC, object[] GEMFIOKGIMC)
	{
		ReceiveInteractCallback(MGEIKDCIANC, GEMFIOKGIMC);
	}

	public void NFIBCCDEJKH(float LLIKFNFINLB)
	{
		if (doWork.workAdded < onlineWorkAmountAdded)
		{
			doWork.JMJMFEKCAGK(1, onlineWorkAmountAdded - doWork.workAdded);
		}
		doWork.workAdded = 622f;
		onlineWorkAmountAdded = LLIKFNFINLB;
	}

	public void IHIFOCJOKLL(Vector2 IMOBLFMHKOD)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline() && (Object)(object)OnlineObjectsManager.instance != (Object)null)
		{
			OnlineObjectsManager.instance.UpdatePosition(this, IMOBLFMHKOD);
		}
	}

	public void AddIfUniqueObject()
	{
		if (uniqueId < 100000 && !OnlineObjectsManager.instance.onlineObjects.ContainsValue(this))
		{
			OnlineObjectsManager.instance.AddObjectInDictionary(this);
		}
	}

	public void BOILJEPIODF(Vector2 IMOBLFMHKOD)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline() && (Object)(object)OnlineObjectsManager.instance != (Object)null)
		{
			OnlineObjectsManager.instance.UpdatePosition(this, IMOBLFMHKOD);
		}
	}

	public void NGJCPJADIGE(Vector2 CDHGIJJHPJB)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (KJDJCMLGGLL)
		{
			KJDJCMLGGLL = false;
			GNFBPAGOFLH = Vector2.op_Implicit(((Component)this).transform.position);
			return;
		}
		GNFBPAGOFLH = CDHGIJJHPJB;
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			LFLECAIBFCL = Vector2.op_Implicit(((Component)this).transform.position);
		}
		DBEFBFPAOAA = 577f;
	}

	public void IIAHJHJFIDO(float CLNNPGMEAHL)
	{
		OnlineObjectsManager.instance.AddWork(uniqueId, CLNNPGMEAHL);
	}

	public void DCHDDEBEAPF()
	{
		uniqueId = 1;
		if (Application.isEditor)
		{
			int num = ((Object)((Component)this).gameObject).name.LastIndexOf("Pick up");
			if (num >= 0)
			{
				((Object)((Component)this).gameObject).name = ((Object)((Component)this).gameObject).name.Substring(0, num);
			}
		}
		OnlineObjectsManager.instance.RemoveObjectInDictionary(this);
	}

	public void KEIFPCCNICK(int MGEIKDCIANC, object[] GEMFIOKGIMC)
	{
		OnlineObjectsManager.instance.SendObjectInteractToMaster(uniqueId, (byte)MGEIKDCIANC, GEMFIOKGIMC);
	}

	public void StopWork()
	{
		OnlineObjectsManager.instance.StopWork(uniqueId);
		onlineWorkAmountAdded = 0f;
	}
}
