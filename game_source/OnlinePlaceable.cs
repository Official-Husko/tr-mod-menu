using System.Runtime.CompilerServices;
using UnityEngine;

public class OnlinePlaceable : OnlineObject
{
	private enum JDBLOKANBMI
	{
		Style,
		SkinVariation,
		ChangePosition,
		BenchPosition,
		SetDirection
	}

	public Placeable placeable;

	public bool rotated;

	protected float DCGBADKLANM;

	public OnlineDialogueNPC onlineDialogueNPC;

	public bool _onlineSelected;

	[HideInInspector]
	public ChangeRandomTavernLocation changeRandomLocation;

	public bool CLHLNFFGOGA
	{
		get
		{
			return _onlineSelected;
		}
		set
		{
			if (_onlineSelected != value)
			{
				_onlineSelected = value;
				if (!placeable.FHEMHCEAICB)
				{
					placeable.ChangeObjectLayer(_onlineSelected);
					placeable.RigidBodyKinematic(_onlineSelected);
				}
			}
		}
	}

	public virtual PlaceableMsg MAMPLEOIEJN()
	{
		return new PlaceableMsg(this);
	}

	public virtual PlaceableMsg OGDHFKILLMN()
	{
		return new PlaceableMsg(this);
	}

	protected virtual void MNFJELNEGPG()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		if (!(DBEFBFPAOAA < AFMFHCAHEFO))
		{
			return;
		}
		if (KJDJCMLGGLL)
		{
			DBEFBFPAOAA = AFMFHCAHEFO;
			return;
		}
		DBEFBFPAOAA += Time.deltaTime;
		DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
		((Component)this).transform.position = Vector2.op_Implicit(Vector2.Lerp(LFLECAIBFCL, GNFBPAGOFLH, DCGBADKLANM));
		if (Object.op_Implicit((Object)(object)placeable.snapToGrid))
		{
			placeable.snapToGrid.FIOKLLOAAHM(MLPOHGEHIME: true);
		}
		else
		{
			((Component)this).transform.position = Utils.EKCCGNEDPNO(((Component)this).transform.position, 1);
		}
		if ((Object)(object)placeable.currentSurface != (Object)null && !placeable.snappedToPosition)
		{
			placeable.currentSurface.CheckReorder(((Component)this).transform);
		}
	}

	public void JDDHAPNMGNO(Vector3 PAICGEGHOCO)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[6];
		array[1] = PAICGEGHOCO.x;
		array[0] = PAICGEGHOCO.y;
		instance.SendObjectAction(bEIPALOAAJJ, 3, array);
	}

	protected virtual void OIBDBLCLACB()
	{
		if (!OnlineManager.PlayingOnline())
		{
			((Behaviour)this).enabled = false;
			return;
		}
		if (uniqueId != 0)
		{
			OnlineObjectsManager.instance.ReplaceObjectInDictionary(this);
		}
		if (!((Object)(object)placeable == (Object)null) && ((Behaviour)placeable).enabled)
		{
			if (uniqueId == 0)
			{
				AssignUniqueIDAndSend();
			}
			else if (!placeable.FHEMHCEAICB && GFMGFDGBPEP())
			{
				placeable.ActionObject(0, GFNHAMCPEAK: true);
			}
		}
	}

	public void KNBABMLDOFD(Vector3 PAICGEGHOCO)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[7];
		array[1] = PAICGEGHOCO.x;
		array[1] = PAICGEGHOCO.y;
		instance.SendObjectAction(bEIPALOAAJJ, 4, array);
	}

	public void ICNMDNMGEMC()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)OnlineObjectsManager.instance != (Object)null && uniqueId != 0)
		{
			OnlineObjectsManager.instance.DGCLLKKPNPJ(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	public void GEAPPCMMCHM()
	{
		if ((Object)(object)OnlineObjectsManager.instance != (Object)null && uniqueId != 0)
		{
			OnlineObjectsManager.instance.SelectPlaceableIfIsPossible(uniqueId);
		}
	}

	public void BEIGPFNCFMD(bool DDNPPKBFENA)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.InRoom() && (Object)(object)OnlineObjectsManager.instance != (Object)null && GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			CLHLNFFGOGA = DDNPPKBFENA;
			OnlineObjectsManager.instance.DLJPEICOGND(this, DDNPPKBFENA, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	protected virtual void Start()
	{
		if (!OnlineManager.PlayingOnline())
		{
			((Behaviour)this).enabled = false;
			return;
		}
		if (uniqueId != 0)
		{
			OnlineObjectsManager.instance.ReplaceObjectInDictionary(this);
		}
		if (!((Object)(object)placeable == (Object)null) && ((Behaviour)placeable).enabled)
		{
			if (uniqueId == 0)
			{
				AssignUniqueIDAndSend();
			}
			else if (!placeable.FHEMHCEAICB && CLHLNFFGOGA)
			{
				placeable.ActionObject(1, GFNHAMCPEAK: false);
			}
		}
	}

	public void CNMKJNENKFN(OnlinePlaceable IEEGOPMJAAB)
	{
		if (!((Object)(object)OnlineObjectsManager.instance != (Object)null))
		{
			return;
		}
		GMPGLLMNGEJ(IEEGOPMJAAB.uniqueId);
		IEEGOPMJAAB.uniqueId = 1;
		for (int i = 0; i < OnlineObjectsManager.instance.playersPlaceablesSelected.Length; i += 0)
		{
			if ((Object)(object)OnlineObjectsManager.instance.playersPlaceablesSelected[i] == (Object)(object)IEEGOPMJAAB)
			{
				OnlineObjectsManager.instance.playersPlaceablesSelected[i] = this;
				break;
			}
		}
	}

	public void NINKCDJFCKO(int JJPJHIHBOIB)
	{
		CLHLNFFGOGA = false;
		placeable.StartMoving(1, PHJILIBHABG: true, OnlineManager.IsLocalActor(JJPJHIHBOIB));
		if (OnlineManager.IsLocalActor(JJPJHIHBOIB))
		{
			SelectObject.GetPlayer(1).SelectGameObject((MonoBehaviour)(object)placeable);
		}
		else
		{
			CameraRenderSettings.placeablePlayer = null;
		}
	}

	public void MOPKNAKILDI(Vector3 PAICGEGHOCO)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = PAICGEGHOCO.x;
		array[0] = PAICGEGHOCO.y;
		instance.SendObjectAction(bEIPALOAAJJ, 4, array);
	}

	public void AssignUniqueIDAndSend()
	{
		if (uniqueId == 0)
		{
			AssignNewUniqueId();
			if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.SendInstantiatePlaceable(this);
			}
		}
	}

	public void FNBAKMBECOO(Vector3 PAICGEGHOCO, Vector3 GGINPPKCMOI)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[6];
		array[1] = PAICGEGHOCO.x;
		array[0] = PAICGEGHOCO.y;
		array[2] = GGINPPKCMOI.x;
		array[6] = GGINPPKCMOI.y;
		instance.SendObjectAction(bEIPALOAAJJ, 6, array);
	}

	public void LBMEKLFFHEA(Direction FCGBJEIIMBC)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, (byte)FCGBJEIIMBC);
	}

	public void AssignSameUniqueId(OnlinePlaceable IEEGOPMJAAB)
	{
		if (!((Object)(object)OnlineObjectsManager.instance != (Object)null))
		{
			return;
		}
		AssignUniqueId(IEEGOPMJAAB.uniqueId);
		IEEGOPMJAAB.uniqueId = 0;
		for (int i = 1; i < OnlineObjectsManager.instance.playersPlaceablesSelected.Length; i++)
		{
			if ((Object)(object)OnlineObjectsManager.instance.playersPlaceablesSelected[i] == (Object)(object)IEEGOPMJAAB)
			{
				OnlineObjectsManager.instance.playersPlaceablesSelected[i] = this;
				break;
			}
		}
	}

	public virtual PlaceableMsg LPKPBCPBFEI()
	{
		return new PlaceableMsg(this);
	}

	protected virtual void CFIIEJDJFPB()
	{
		if (!OnlineManager.PlayingOnline())
		{
			((Behaviour)this).enabled = false;
			return;
		}
		if (uniqueId != 0)
		{
			OnlineObjectsManager.instance.ReplaceObjectInDictionary(this);
		}
		if (!((Object)(object)placeable == (Object)null) && ((Behaviour)placeable).enabled)
		{
			if (uniqueId == 0)
			{
				PGCLJPKJLNG();
			}
			else if (!placeable.FHEMHCEAICB && EACMNFJCGFC())
			{
				placeable.JABJEIGGCFJ(1, GFNHAMCPEAK: true);
			}
		}
	}

	public void FDFAMKIDGCH(int ONLCBJNNJMB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = (byte)ONLCBJNNJMB;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void EHFBKGFIKJG(Direction FCGBJEIIMBC)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 2, (byte)FCGBJEIIMBC);
	}

	protected virtual void PGEGODAEBLC()
	{
		if (OnlineManager.PlayingOnline())
		{
			DJPJMAJLNGP();
		}
	}

	public void OHDMKFNOFHF(Vector3 PAICGEGHOCO, Vector3 GGINPPKCMOI)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[8];
		array[0] = PAICGEGHOCO.x;
		array[0] = PAICGEGHOCO.y;
		array[2] = GGINPPKCMOI.x;
		array[1] = GGINPPKCMOI.y;
		instance.SendObjectAction(bEIPALOAAJJ, 3, array);
	}

	public void SendStyle(int ONLCBJNNJMB)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, (byte)ONLCBJNNJMB);
	}

	public void INPFBFCMBMH(int[] MIABNMJIMLD)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, MIABNMJIMLD);
	}

	public void GCDJAJDGDMO()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)OnlineObjectsManager.instance != (Object)null && uniqueId != 0)
		{
			OnlineObjectsManager.instance.DeselectPlaceable(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	protected virtual void NDLCBLKOBLF()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		if (!(DBEFBFPAOAA < AFMFHCAHEFO))
		{
			return;
		}
		if (KJDJCMLGGLL)
		{
			DBEFBFPAOAA = AFMFHCAHEFO;
			return;
		}
		DBEFBFPAOAA += Time.deltaTime;
		DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
		((Component)this).transform.position = Vector2.op_Implicit(Vector2.Lerp(LFLECAIBFCL, GNFBPAGOFLH, DCGBADKLANM));
		if (Object.op_Implicit((Object)(object)placeable.snapToGrid))
		{
			placeable.snapToGrid.HEIPNKAKFBL(MLPOHGEHIME: true);
		}
		else
		{
			((Component)this).transform.position = Utils.EKCCGNEDPNO(((Component)this).transform.position, 1);
		}
		if ((Object)(object)placeable.currentSurface != (Object)null && !placeable.snappedToPosition)
		{
			placeable.currentSurface.HLGLEGMHDAC(((Component)this).transform);
		}
	}

	protected virtual void OFDEGDJGGGF()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		if (!(DBEFBFPAOAA < AFMFHCAHEFO))
		{
			return;
		}
		if (KJDJCMLGGLL)
		{
			DBEFBFPAOAA = AFMFHCAHEFO;
			return;
		}
		DBEFBFPAOAA += Time.deltaTime;
		DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
		((Component)this).transform.position = Vector2.op_Implicit(Vector2.Lerp(LFLECAIBFCL, GNFBPAGOFLH, DCGBADKLANM));
		if (Object.op_Implicit((Object)(object)placeable.snapToGrid))
		{
			placeable.snapToGrid.AOOJCIOMPEP();
		}
		else
		{
			((Component)this).transform.position = Utils.EKCCGNEDPNO(((Component)this).transform.position, 0);
		}
		if ((Object)(object)placeable.currentSurface != (Object)null && !placeable.snappedToPosition)
		{
			placeable.currentSurface.PJFHIIIMGPH(((Component)this).transform);
		}
	}

	public void DOILIKCGAEG()
	{
		if ((Object)(object)placeable != (Object)null)
		{
			placeable.onlinePlaceable = this;
			if ((Object)(object)placeable.placeableSurface != (Object)null)
			{
				placeable.placeableSurface.onlinePlaceable = this;
			}
		}
	}

	public void GHKBMBNHCCC(bool DDNPPKBFENA)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.InRoom() && (Object)(object)OnlineObjectsManager.instance != (Object)null && GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			PBCCHJIDNEC(DDNPPKBFENA);
			OnlineObjectsManager.instance.DLJPEICOGND(this, DDNPPKBFENA, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	public void BFCDJICGJGI(int ONLCBJNNJMB)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, (byte)ONLCBJNNJMB);
	}

	[SpecialName]
	public bool KFAJLICFLIC()
	{
		return _onlineSelected;
	}

	public void ADJOMHFGCIH(int[] MIABNMJIMLD)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, MIABNMJIMLD);
	}

	protected virtual void LOHAMDHOLDD()
	{
		if (!OnlineManager.PlayingOnline())
		{
			((Behaviour)this).enabled = false;
			return;
		}
		if (uniqueId != 0)
		{
			OnlineObjectsManager.instance.ReplaceObjectInDictionary(this);
		}
		if (!((Object)(object)placeable == (Object)null) && ((Behaviour)placeable).enabled)
		{
			if (uniqueId == 0)
			{
				EBNFALDBENB();
			}
			else if (!placeable.FHEMHCEAICB && ABPAADPINOL())
			{
				placeable.BNMJDOFGNCE(0, GFNHAMCPEAK: true);
			}
		}
	}

	public void MAEPADOOJCO(Vector3 PAICGEGHOCO)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = PAICGEGHOCO.x;
		array[1] = PAICGEGHOCO.y;
		instance.SendObjectAction(bEIPALOAAJJ, 8, array);
	}

	public void BOBAPJAKLBJ()
	{
		uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
		IIFKLGFBLPH(placeable.FHEMHCEAICB);
	}

	public void KIGHMHIGLGH(bool DDNPPKBFENA)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.JLEFEDNBAJH() && (Object)(object)OnlineObjectsManager.instance != (Object)null && GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			IIFKLGFBLPH(!DDNPPKBFENA);
			OnlineObjectsManager.instance.SendPlaceItem(this, DDNPPKBFENA, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	public void FKOBECFPACP()
	{
		uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
		CLHLNFFGOGA = placeable.FHEMHCEAICB;
	}

	public void IFDKLOKOEFC(Direction FCGBJEIIMBC)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 6, (byte)FCGBJEIIMBC);
	}

	public override void ObjectConfiguration()
	{
		base.ObjectConfiguration();
		Debug.Log((object)("Get Components " + ((Object)((Component)this).gameObject).name));
		placeable = ((Component)((Component)this).transform).GetComponentInChildren<Placeable>();
		if ((Object)(object)placeable != (Object)null)
		{
			placeable.onlinePlaceable = this;
		}
		if ((Object)(object)placeable != (Object)null && (Object)(object)placeable.itemSetup != (Object)null && Item.MLBOMGHINCA(placeable.itemSetup.item, null))
		{
			if ((Object)(object)placeable.itemSetup.item.ALLGGMEFAKA() == (Object)(object)((Component)this).gameObject)
			{
				rotated = true;
			}
			else
			{
				rotated = false;
			}
		}
	}

	public void PMJOKNIEKHF()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)OnlineObjectsManager.instance != (Object)null && uniqueId != 0)
		{
			OnlineObjectsManager.instance.MPNGIFHOAMO(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	public void MAFABEEPNNA()
	{
		uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
		PBCCHJIDNEC(placeable.FHEMHCEAICB);
	}

	public void KCJBEBKBCIB(Direction FCGBJEIIMBC)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 8, (byte)FCGBJEIIMBC);
	}

	[SpecialName]
	public bool EACMNFJCGFC()
	{
		return _onlineSelected;
	}

	public void ENJOEOHAGLI(int ONLCBJNNJMB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = (byte)ONLCBJNNJMB;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void EBNFALDBENB()
	{
		if (uniqueId == 0)
		{
			FKOBECFPACP();
			if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.PEDOIKFHCGI(this);
			}
		}
	}

	public void NOKBPNOBGNN()
	{
		if ((Object)(object)placeable != (Object)null)
		{
			placeable.onlinePlaceable = this;
			if ((Object)(object)placeable.placeableSurface != (Object)null)
			{
				placeable.placeableSurface.onlinePlaceable = this;
			}
		}
	}

	public void AGGEDBJGKPO()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)OnlineObjectsManager.instance != (Object)null && uniqueId != 0)
		{
			OnlineObjectsManager.instance.DGCLLKKPNPJ(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	public virtual PlaceableMsg GFDGBPOMDMC()
	{
		return new PlaceableMsg(this);
	}

	protected virtual void EGACIHOKJLH()
	{
		if (!OnlineManager.PlayingOnline())
		{
			((Behaviour)this).enabled = true;
			return;
		}
		if (uniqueId != 0)
		{
			OnlineObjectsManager.instance.ReplaceObjectInDictionary(this);
		}
		if (!((Object)(object)placeable == (Object)null) && ((Behaviour)placeable).enabled)
		{
			if (uniqueId == 0)
			{
				JJKBAKMONPC();
			}
			else if (!placeable.FHEMHCEAICB && ABPAADPINOL())
			{
				placeable.ActionObject(1, GFNHAMCPEAK: true);
			}
		}
	}

	public void ICKDAGJFHFI()
	{
		if (uniqueId == 0)
		{
			FKOBECFPACP();
			if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.SendInstantiatePlaceable(this);
			}
		}
	}

	protected virtual void Awake()
	{
		if (OnlineManager.PlayingOnline())
		{
			AssignInitialValues();
		}
	}

	public void CKDOPOINPDN(bool DDNPPKBFENA)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.JLEFEDNBAJH() && (Object)(object)OnlineObjectsManager.instance != (Object)null && GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			PBCCHJIDNEC(DDNPPKBFENA);
			OnlineObjectsManager.instance.SendPlaceItem(this, DDNPPKBFENA, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	public void DJPJMAJLNGP()
	{
		if ((Object)(object)placeable != (Object)null)
		{
			placeable.onlinePlaceable = this;
			if ((Object)(object)placeable.placeableSurface != (Object)null)
			{
				placeable.placeableSurface.onlinePlaceable = this;
			}
		}
	}

	protected virtual void NLFHFPHDNCF()
	{
		if (!OnlineManager.PlayingOnline())
		{
			((Behaviour)this).enabled = false;
			return;
		}
		if (uniqueId != 0)
		{
			OnlineObjectsManager.instance.ReplaceObjectInDictionary(this);
		}
		if (!((Object)(object)placeable == (Object)null) && ((Behaviour)placeable).enabled)
		{
			if (uniqueId == 0)
			{
				EBNFALDBENB();
			}
			else if (!placeable.FHEMHCEAICB && EACMNFJCGFC())
			{
				placeable.JABJEIGGCFJ(0, GFNHAMCPEAK: false);
			}
		}
	}

	public void RequestPermissionSelection()
	{
		if ((Object)(object)OnlineObjectsManager.instance != (Object)null && uniqueId != 0)
		{
			OnlineObjectsManager.instance.SelectPlaceableIfIsPossible(uniqueId);
		}
	}

	public void AcceptedSelectPermission(int JJPJHIHBOIB)
	{
		CLHLNFFGOGA = true;
		placeable.StartMoving(1, PHJILIBHABG: false, OnlineManager.IsLocalActor(JJPJHIHBOIB));
		if (OnlineManager.IsLocalActor(JJPJHIHBOIB))
		{
			SelectObject.GetPlayer(1).SelectGameObject((MonoBehaviour)(object)placeable);
		}
		else
		{
			CameraRenderSettings.placeablePlayer = null;
		}
	}

	public void SendSetDirection(Direction FCGBJEIIMBC)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 4, (byte)FCGBJEIIMBC);
	}

	public void BAAFGFEMGFN(Vector3 PAICGEGHOCO)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[3];
		array[1] = PAICGEGHOCO.x;
		array[0] = PAICGEGHOCO.y;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public virtual void CollectItems(byte HFDILBELIKE, short JJPJHIHBOIB)
	{
	}

	public void AssignNewUniqueId()
	{
		uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
		CLHLNFFGOGA = placeable.FHEMHCEAICB;
	}

	public void PGCLJPKJLNG()
	{
		if (uniqueId == 0)
		{
			AssignNewUniqueId();
			if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.PEDOIKFHCGI(this);
			}
		}
	}

	public virtual PlaceableMsg CreateMsg()
	{
		return new PlaceableMsg(this);
	}

	public void AssignInitialValues()
	{
		if ((Object)(object)placeable != (Object)null)
		{
			placeable.onlinePlaceable = this;
			if ((Object)(object)placeable.placeableSurface != (Object)null)
			{
				placeable.placeableSurface.onlinePlaceable = this;
			}
		}
	}

	public void SendPlace(bool DDNPPKBFENA)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.InRoom() && (Object)(object)OnlineObjectsManager.instance != (Object)null && GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			CLHLNFFGOGA = !DDNPPKBFENA;
			OnlineObjectsManager.instance.SendPlaceItem(this, DDNPPKBFENA, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	public void AMDDHPEBEIN(Vector3 PAICGEGHOCO)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[3];
		array[1] = PAICGEGHOCO.x;
		array[1] = PAICGEGHOCO.y;
		instance.SendObjectAction(bEIPALOAAJJ, 3, array);
	}

	public void KNKGLFLNHFD(int JJPJHIHBOIB)
	{
		PBCCHJIDNEC(AODONKKHPBP: true);
		placeable.StartMoving(0, PHJILIBHABG: true, OnlineManager.IsLocalActor(JJPJHIHBOIB));
		if (OnlineManager.IsLocalActor(JJPJHIHBOIB))
		{
			SelectObject.BNMEANGDMIP(0).SelectGameObject((MonoBehaviour)(object)placeable);
		}
		else
		{
			CameraRenderSettings.placeablePlayer = null;
		}
	}

	public void JDLDNHKOCEK(Direction FCGBJEIIMBC)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = (byte)FCGBJEIIMBC;
		instance.SendObjectAction(bEIPALOAAJJ, 3, array);
	}

	public override void AcceptedInteractPermission()
	{
		JFCOCPMEEEK(placeable.inputByProximity);
	}

	[SpecialName]
	public bool ABPAADPINOL()
	{
		return _onlineSelected;
	}

	[SpecialName]
	public void PBCCHJIDNEC(bool AODONKKHPBP)
	{
		if (_onlineSelected != AODONKKHPBP)
		{
			_onlineSelected = AODONKKHPBP;
			if (!placeable.FHEMHCEAICB)
			{
				placeable.ChangeObjectLayer(_onlineSelected);
				placeable.MEHDJDJFNDC(_onlineSelected);
			}
		}
	}

	public void SendPlaceableDeselected()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)OnlineObjectsManager.instance != (Object)null && uniqueId != 0)
		{
			OnlineObjectsManager.instance.DeselectPlaceable(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	public void LHHJODCENFM(bool DDNPPKBFENA)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.JLEFEDNBAJH() && (Object)(object)OnlineObjectsManager.instance != (Object)null && GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			CLHLNFFGOGA = !DDNPPKBFENA;
			OnlineObjectsManager.instance.DLJPEICOGND(this, DDNPPKBFENA, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	public void KOMLBPGDOEA()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)OnlineObjectsManager.instance != (Object)null && uniqueId != 0)
		{
			OnlineObjectsManager.instance.DeselectPlaceable(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	protected virtual void ELHCBGCEJDH()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		if (!(DBEFBFPAOAA < AFMFHCAHEFO))
		{
			return;
		}
		if (KJDJCMLGGLL)
		{
			DBEFBFPAOAA = AFMFHCAHEFO;
			return;
		}
		DBEFBFPAOAA += Time.deltaTime;
		DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
		((Component)this).transform.position = Vector2.op_Implicit(Vector2.Lerp(LFLECAIBFCL, GNFBPAGOFLH, DCGBADKLANM));
		if (Object.op_Implicit((Object)(object)placeable.snapToGrid))
		{
			placeable.snapToGrid.FEMGGNMPBJN(MLPOHGEHIME: true);
		}
		else
		{
			((Component)this).transform.position = Utils.EKCCGNEDPNO(((Component)this).transform.position, 0);
		}
		if ((Object)(object)placeable.currentSurface != (Object)null && !placeable.snappedToPosition)
		{
			placeable.currentSurface.CheckReorder(((Component)this).transform);
		}
	}

	public void DCPIJMMCBGM(Vector3 PAICGEGHOCO)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[3];
		array[0] = PAICGEGHOCO.x;
		array[0] = PAICGEGHOCO.y;
		instance.SendObjectAction(bEIPALOAAJJ, 5, array);
	}

	protected virtual void AAOMCHHNKKM()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		if (!(DBEFBFPAOAA < AFMFHCAHEFO))
		{
			return;
		}
		if (KJDJCMLGGLL)
		{
			DBEFBFPAOAA = AFMFHCAHEFO;
			return;
		}
		DBEFBFPAOAA += Time.deltaTime;
		DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
		((Component)this).transform.position = Vector2.op_Implicit(Vector2.Lerp(LFLECAIBFCL, GNFBPAGOFLH, DCGBADKLANM));
		if (Object.op_Implicit((Object)(object)placeable.snapToGrid))
		{
			placeable.snapToGrid.KLDEDEHJHJC(MLPOHGEHIME: true);
		}
		else
		{
			((Component)this).transform.position = Utils.EKCCGNEDPNO(((Component)this).transform.position, 1);
		}
		if ((Object)(object)placeable.currentSurface != (Object)null && !placeable.snappedToPosition)
		{
			placeable.currentSurface.CHJFOGGEEMN(((Component)this).transform);
		}
	}

	public void GHIHCHMAMID(int ONLCBJNNJMB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = (byte)ONLCBJNNJMB;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void BILFEBNHHJA(OnlinePlaceable IEEGOPMJAAB)
	{
		if (!((Object)(object)OnlineObjectsManager.instance != (Object)null))
		{
			return;
		}
		CPJMICEDMIL(IEEGOPMJAAB.uniqueId);
		IEEGOPMJAAB.uniqueId = 1;
		for (int i = 0; i < OnlineObjectsManager.instance.playersPlaceablesSelected.Length; i++)
		{
			if ((Object)(object)OnlineObjectsManager.instance.playersPlaceablesSelected[i] == (Object)(object)IEEGOPMJAAB)
			{
				OnlineObjectsManager.instance.playersPlaceablesSelected[i] = this;
				break;
			}
		}
	}

	protected virtual void GMCKBBECJOE()
	{
		if (OnlineManager.PlayingOnline())
		{
			DOILIKCGAEG();
		}
	}

	protected virtual void JLPLLHKJEMH()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		if (!(DBEFBFPAOAA < AFMFHCAHEFO))
		{
			return;
		}
		if (KJDJCMLGGLL)
		{
			DBEFBFPAOAA = AFMFHCAHEFO;
			return;
		}
		DBEFBFPAOAA += Time.deltaTime;
		DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
		((Component)this).transform.position = Vector2.op_Implicit(Vector2.Lerp(LFLECAIBFCL, GNFBPAGOFLH, DCGBADKLANM));
		if (Object.op_Implicit((Object)(object)placeable.snapToGrid))
		{
			placeable.snapToGrid.NFCNLOEMCKC(MLPOHGEHIME: true);
		}
		else
		{
			((Component)this).transform.position = Utils.EKCCGNEDPNO(((Component)this).transform.position, 1);
		}
		if ((Object)(object)placeable.currentSurface != (Object)null && !placeable.snappedToPosition)
		{
			placeable.currentSurface.PJFHIIIMGPH(((Component)this).transform);
		}
	}

	public void HCECDMGOKPH()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)OnlineObjectsManager.instance != (Object)null && uniqueId != 0)
		{
			OnlineObjectsManager.instance.DGCLLKKPNPJ(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	public void DJNPJDIBNLJ(int[] MIABNMJIMLD)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = MIABNMJIMLD;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void BHAMBMLGFOJ(Vector3 PAICGEGHOCO)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[8];
		array[1] = PAICGEGHOCO.x;
		array[1] = PAICGEGHOCO.y;
		instance.SendObjectAction(bEIPALOAAJJ, 8, array);
	}

	public void SendSkinVariation(int[] MIABNMJIMLD)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, MIABNMJIMLD);
	}

	public void PMFKKMGCLJA(int JJPJHIHBOIB)
	{
		PBCCHJIDNEC(AODONKKHPBP: false);
		placeable.StartMoving(1, PHJILIBHABG: false, OnlineManager.IsLocalActor(JJPJHIHBOIB), MAFODGNALFJ: false);
		if (OnlineManager.IsLocalActor(JJPJHIHBOIB))
		{
			SelectObject.BNMEANGDMIP(0).SelectGameObject((MonoBehaviour)(object)placeable);
		}
		else
		{
			CameraRenderSettings.placeablePlayer = null;
		}
	}

	public void KAHEGDBNEMP()
	{
		uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
		CLHLNFFGOGA = placeable.FHEMHCEAICB;
	}

	public void PBDECELLIDD(int JJPJHIHBOIB)
	{
		PBCCHJIDNEC(AODONKKHPBP: true);
		placeable.StartMoving(1, PHJILIBHABG: false, OnlineManager.IsLocalActor(JJPJHIHBOIB), MAFODGNALFJ: true, MCFNOAFOIHE: false);
		if (OnlineManager.IsLocalActor(JJPJHIHBOIB))
		{
			SelectObject.BNMEANGDMIP(1).LEIFHIKBIBI((MonoBehaviour)(object)placeable);
		}
		else
		{
			CameraRenderSettings.placeablePlayer = null;
		}
	}

	[SpecialName]
	public bool GFMGFDGBPEP()
	{
		return _onlineSelected;
	}

	public void KJAEJCGLJEI(Vector3 PAICGEGHOCO)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[4];
		array[1] = PAICGEGHOCO.x;
		array[0] = PAICGEGHOCO.y;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	[SpecialName]
	public void IIFKLGFBLPH(bool AODONKKHPBP)
	{
		if (_onlineSelected != AODONKKHPBP)
		{
			_onlineSelected = AODONKKHPBP;
			if (!placeable.FHEMHCEAICB)
			{
				placeable.ChangeObjectLayer(_onlineSelected);
				placeable.PFAFNPAGLNB(_onlineSelected);
			}
		}
	}

	public void CDMDGHCLHFD()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)OnlineObjectsManager.instance != (Object)null && uniqueId != 0)
		{
			OnlineObjectsManager.instance.DeselectPlaceable(uniqueId, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	public void LLMDPOENJIK(OnlinePlaceable IEEGOPMJAAB)
	{
		if (!((Object)(object)OnlineObjectsManager.instance != (Object)null))
		{
			return;
		}
		NIHPKLADNFB(IEEGOPMJAAB.uniqueId);
		IEEGOPMJAAB.uniqueId = 0;
		for (int i = 0; i < OnlineObjectsManager.instance.playersPlaceablesSelected.Length; i += 0)
		{
			if ((Object)(object)OnlineObjectsManager.instance.playersPlaceablesSelected[i] == (Object)(object)IEEGOPMJAAB)
			{
				OnlineObjectsManager.instance.playersPlaceablesSelected[i] = this;
				break;
			}
		}
	}

	public void FGFDPMLNNLN(Vector3 PAICGEGHOCO)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[2];
		array[1] = PAICGEGHOCO.x;
		array[1] = PAICGEGHOCO.y;
		instance.SendObjectAction(bEIPALOAAJJ, 5, array);
	}

	public void LGIDDDGFEID()
	{
		if ((Object)(object)placeable != (Object)null)
		{
			placeable.onlinePlaceable = this;
			if ((Object)(object)placeable.placeableSurface != (Object)null)
			{
				placeable.placeableSurface.onlinePlaceable = this;
			}
		}
	}

	public void SendChangeDollPosition(Vector3 PAICGEGHOCO)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 2, PAICGEGHOCO.x, PAICGEGHOCO.y);
	}

	public void PEGHCLBAHMH(Direction FCGBJEIIMBC)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = (byte)FCGBJEIIMBC;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	protected virtual void OONONNJFEFL()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		if (!(DBEFBFPAOAA < AFMFHCAHEFO))
		{
			return;
		}
		if (KJDJCMLGGLL)
		{
			DBEFBFPAOAA = AFMFHCAHEFO;
			return;
		}
		DBEFBFPAOAA += Time.deltaTime;
		DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
		((Component)this).transform.position = Vector2.op_Implicit(Vector2.Lerp(LFLECAIBFCL, GNFBPAGOFLH, DCGBADKLANM));
		if (Object.op_Implicit((Object)(object)placeable.snapToGrid))
		{
			placeable.snapToGrid.FIBJJICHPKE(MLPOHGEHIME: true);
		}
		else
		{
			((Component)this).transform.position = Utils.EKCCGNEDPNO(((Component)this).transform.position, 0);
		}
		if ((Object)(object)placeable.currentSurface != (Object)null && !placeable.snappedToPosition)
		{
			placeable.currentSurface.CheckReorder(((Component)this).transform);
		}
	}

	protected virtual void MFJIHCKEIIF()
	{
		if (OnlineManager.PlayingOnline())
		{
			DOILIKCGAEG();
		}
	}

	public void IFKJIJHEEPA(int ONLCBJNNJMB)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, (byte)ONLCBJNNJMB);
	}

	public void SendNewBenchPosition(Vector3 PAICGEGHOCO, Vector3 GGINPPKCMOI)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 3, PAICGEGHOCO.x, PAICGEGHOCO.y, GGINPPKCMOI.x, GGINPPKCMOI.y);
	}

	public void BLGICJJDKCI()
	{
		if ((Object)(object)OnlineObjectsManager.instance != (Object)null && uniqueId != 0)
		{
			OnlineObjectsManager.instance.SelectPlaceableIfIsPossible(uniqueId);
		}
	}

	public void ODKEDBOJCNO(bool DDNPPKBFENA)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.JLEFEDNBAJH() && (Object)(object)OnlineObjectsManager.instance != (Object)null && GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			CLHLNFFGOGA = DDNPPKBFENA;
			OnlineObjectsManager.instance.DLJPEICOGND(this, DDNPPKBFENA, Vector2.op_Implicit(((Component)this).transform.position));
		}
	}

	public void HNLJBDOKEBG()
	{
		uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
		CLHLNFFGOGA = placeable.FHEMHCEAICB;
	}

	public override void ReceiveAction(byte FACPEEACCMH, params object[] GEMFIOKGIMC)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		switch ((JDBLOKANBMI)FACPEEACCMH)
		{
		case JDBLOKANBMI.Style:
			placeable.ChangeSkin((byte)GEMFIOKGIMC[0], PDHJLCDFNCK: false);
			break;
		case JDBLOKANBMI.SkinVariation:
			placeable.ReceiveSkinVariations((int[])GEMFIOKGIMC[0]);
			break;
		case JDBLOKANBMI.ChangePosition:
			changeRandomLocation.SetNewLocation(new Vector3((float)GEMFIOKGIMC[0], (float)GEMFIOKGIMC[1], 0f));
			break;
		case JDBLOKANBMI.SetDirection:
			placeable.SetDirection((Direction)(byte)GEMFIOKGIMC[0], CDPAMNIPPEC: false);
			break;
		case JDBLOKANBMI.BenchPosition:
			((Component)placeable).transform.position = new Vector3((float)GEMFIOKGIMC[0], (float)GEMFIOKGIMC[1], 0f);
			((Component)placeable.itemSpace).transform.position = new Vector3((float)GEMFIOKGIMC[2], (float)GEMFIOKGIMC[3], 0f);
			break;
		default:
			base.ReceiveAction(FACPEEACCMH, GEMFIOKGIMC);
			break;
		}
	}

	public void ONLPFFLBGEM()
	{
		if ((Object)(object)OnlineObjectsManager.instance != (Object)null && uniqueId != 0)
		{
			OnlineObjectsManager.instance.SelectPlaceableIfIsPossible(uniqueId);
		}
	}

	public void JJKBAKMONPC()
	{
		if (uniqueId == 0)
		{
			BOBAPJAKLBJ();
			if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
			{
				OnlineObjectsManager.instance.HMEBGADCMPK(this);
			}
		}
	}

	protected virtual void MIKNFPCDLML()
	{
		if (OnlineManager.PlayingOnline())
		{
			DOILIKCGAEG();
		}
	}

	[SpecialName]
	public bool MIKOKGHOFOF()
	{
		return _onlineSelected;
	}

	public void KKEKGGJDAJF(Vector3 PAICGEGHOCO)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = PAICGEGHOCO.x;
		array[0] = PAICGEGHOCO.y;
		instance.SendObjectAction(bEIPALOAAJJ, 5, array);
	}

	public virtual void PGIPBIHMOEE(byte HFDILBELIKE, short JJPJHIHBOIB)
	{
	}

	protected virtual void Update()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		if (!(DBEFBFPAOAA < AFMFHCAHEFO))
		{
			return;
		}
		if (KJDJCMLGGLL)
		{
			DBEFBFPAOAA = AFMFHCAHEFO;
			return;
		}
		DBEFBFPAOAA += Time.deltaTime;
		DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
		((Component)this).transform.position = Vector2.op_Implicit(Vector2.Lerp(LFLECAIBFCL, GNFBPAGOFLH, DCGBADKLANM));
		if (Object.op_Implicit((Object)(object)placeable.snapToGrid))
		{
			placeable.snapToGrid.Snap();
		}
		else
		{
			((Component)this).transform.position = Utils.EKCCGNEDPNO(((Component)this).transform.position, 1);
		}
		if ((Object)(object)placeable.currentSurface != (Object)null && !placeable.snappedToPosition)
		{
			placeable.currentSurface.CheckReorder(((Component)this).transform);
		}
	}
}
