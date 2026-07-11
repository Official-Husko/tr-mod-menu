using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HenHouse : FarmBuilding, IHoverable, IProximity, IInteractable
{
	[CompilerGenerated]
	private sealed class MJPFNMHBDHG : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HenHouse _003C_003E4__this;

		private List<ChickenNPC> _003CnewChickensList_003E5__2;

		private int _003Ci_003E5__3;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public MJPFNMHBDHG(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Expected O, but got Unknown
			//IL_011e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0123: Unknown result type (might be due to invalid IL or missing references)
			//IL_0128: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			HenHouse henHouse = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003CnewChickensList_003E5__2 = new List<ChickenNPC>(henHouse.chickensAssigned);
				_003Ci_003E5__3 = 0;
				break;
			case 1:
				_003C_003E1__state = -1;
				goto IL_0087;
			case 2:
				{
					_003C_003E1__state = -1;
					goto IL_0087;
				}
				IL_0087:
				if (FarmConstructionManager.IsActived())
				{
					_003C_003E2__current = CommonReferences.wait2;
					_003C_003E1__state = 2;
					return true;
				}
				if (Object.op_Implicit((Object)(object)_003CnewChickensList_003E5__2[_003Ci_003E5__3]))
				{
					((Component)_003CnewChickensList_003E5__2[_003Ci_003E5__3]).gameObject.SetActive(true);
					_003CnewChickensList_003E5__2[_003Ci_003E5__3].LeaveHome();
					_003CnewChickensList_003E5__2[_003Ci_003E5__3].animationBase.ForceDirection(Direction.Down);
					_003CnewChickensList_003E5__2[_003Ci_003E5__3].lastFreePathNode = Vector2.op_Implicit(((Component)_003CnewChickensList_003E5__2[_003Ci_003E5__3]).transform.position);
					_003CnewChickensList_003E5__2[_003Ci_003E5__3].WalkAround();
				}
				_003Ci_003E5__3++;
				break;
			}
			if (_003Ci_003E5__3 < _003CnewChickensList_003E5__2.Count)
			{
				_003C_003E2__current = (object)new WaitForSeconds((float)Random.Range(2, 20));
				_003C_003E1__state = 1;
				return true;
			}
			henHouse.HKHPMDDOMNP = null;
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}
	}

	public SpritesList style;

	public int eggsAmount;

	[SerializeField]
	private List<ChickenNPC> chickensAssigned = new List<ChickenNPC>();

	[SerializeField]
	private int[] maxEggsAmount;

	[SerializeField]
	private SpriteRenderer improvementSpriteRenderer;

	[SerializeField]
	private SurfaceSortOrder surfaceSortOrder;

	public OnlineHenHouse onlineHenHouse;

	public AnimalFeederChicken foodFeeder;

	public Transform entrancePosition;

	public Item eggItem;

	public Transform[] tpPositions;

	private Coroutine HKHPMDDOMNP;

	public void LINBNJEDGBO(bool MJHBHDAEDLF)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		((Component)placeable.itemSpace).gameObject.SetActive(MJHBHDAEDLF);
		placeable.itemSpace.updateBuildSquares = MJHBHDAEDLF;
		if (MJHBHDAEDLF)
		{
			if (chickensAssigned.Count == maxAnimalsAssigned[base.EONJGMONIOM])
			{
				placeable.itemSpace.OBGGJJAKDPG(Color.red);
			}
			else
			{
				placeable.itemSpace.SetColor(Color.cyan);
			}
		}
		else
		{
			placeable.itemSpace.MDPEMPJOBNG();
		}
	}

	public bool DNLPDAOMODM(int JIIGOACEIKL)
	{
		return DecorationMode.JDADPDBHJFO(JIIGOACEIKL).MDOKKKHKKKE();
	}

	public void OnChickenAddedToSurface(Placeable EAPCLAODGAE, bool CDPAMNIPPEC)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		AnimalNPC component = ((Component)EAPCLAODGAE).GetComponent<AnimalNPC>();
		((Behaviour)component.animationBase).enabled = false;
		component.animationBase.ForceDirection(Direction.Down);
		component.lastFreePathNode = Vector2.op_Implicit(((Component)EAPCLAODGAE).transform.position);
		if (CDPAMNIPPEC)
		{
			EAPCLAODGAE.updateButtonsContext = false;
			ButtonsContext.SetPosition(EAPCLAODGAE.GetPlayerNum(), ((Component)placeable.inputByProximity.actionButtonsPoint).transform.position);
			ButtonsContext.GetPlayer(EAPCLAODGAE.GetPlayerNum()).ResetButtons();
			ButtonsContext.AddButton(EAPCLAODGAE.GetPlayerNum(), ActionType.Interact, LocalisationSystem.Get("Place"));
			ButtonsContext.GetPlayer(EAPCLAODGAE.GetPlayerNum()).SetChickensInsideHenHouse(GetAllAnimals(), maxAnimalsAssigned[base.EONJGMONIOM], ((Component)EAPCLAODGAE).GetComponent<ChickenNPC>());
		}
	}

	private void KMKJDEKHONE()
	{
		for (int num = chickensAssigned.Count - 1; num >= 1; num -= 0)
		{
			if ((Object)(object)chickensAssigned[num] != (Object)null)
			{
				Utils.BLPDAEHPOBA(((Component)chickensAssigned[num]).gameObject);
			}
		}
	}

	private IEnumerator LJNJMFKEIPE()
	{
		return new MJPFNMHBDHG(1)
		{
			_003C_003E4__this = this
		};
	}

	public void DMLMBBEDDGF(int MGNOBNCMDJG, bool CDPAMNIPPEC = true)
	{
		eggsAmount = Mathf.Max(1, Mathf.Min(eggsAmount + MGNOBNCMDJG, maxEggsAmount[base.EONJGMONIOM]));
		if (CDPAMNIPPEC)
		{
			OnlineObjectsManager.instance.SendEggIncrement(placeable.BEIPALOAAJJ, MGNOBNCMDJG);
		}
	}

	private void ALGOBMNPLIB()
	{
		try
		{
			if (HKHPMDDOMNP != null)
			{
				((MonoBehaviour)this).StopCoroutine(HKHPMDDOMNP);
			}
			HKHPMDDOMNP = ((MonoBehaviour)this).StartCoroutine(EFLIOBDINDJ());
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public void BGFIIKBLFHH(Placeable EAPCLAODGAE, int JIIGOACEIKL)
	{
		ChickenNPC component = ((Component)EAPCLAODGAE).GetComponent<ChickenNPC>();
		ONPCJPHOMCA(component, CDPAMNIPPEC: true);
		ButtonsContext.GetPlayer(EAPCLAODGAE.GetPlayerNum()).ResetChickensInsideHenHouse();
		ButtonsContext.GetPlayer(EAPCLAODGAE.PGMPPMPBCLO()).ResetButtons();
		EAPCLAODGAE.updateButtonsContext = true;
	}

	public void FFHHLMICNAI(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if (IsBuilt() && EAPCLAODGAE.itemSetup.item is Animal { animalType: AnimalType.Chicken })
		{
			FMFDDKNLBNP(MJHBHDAEDLF: false);
		}
	}

	protected override void JKMBDADNOCD()
	{
		if (!IsBuilt())
		{
			base.DPDMICLMEOD = Mathf.Min(_constructionPhase + 1, constructionPhases.Length);
			UpdateSprite();
		}
	}

	public void FMFDDKNLBNP(bool MJHBHDAEDLF)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		((Component)placeable.itemSpace).gameObject.SetActive(MJHBHDAEDLF);
		placeable.itemSpace.updateBuildSquares = !MJHBHDAEDLF;
		if (MJHBHDAEDLF)
		{
			if (chickensAssigned.Count == maxAnimalsAssigned[base.EONJGMONIOM])
			{
				placeable.itemSpace.DAAOOHHBDAP(Color.red);
			}
			else
			{
				placeable.itemSpace.OBGGJJAKDPG(Color.cyan);
			}
		}
		else
		{
			placeable.itemSpace.AFKDIIADNOA();
		}
	}

	private void BGHLHBHNHPO(int JIIGOACEIKL)
	{
		List<AnimalNPC> allAnimals = GetAllAnimals();
		for (int i = 0; i < allAnimals.Count; i++)
		{
			((Component)allAnimals[i]).gameObject.SetActive(false);
		}
	}

	private void LAMHFJJKNJN(int JIIGOACEIKL)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		List<AnimalNPC> allAnimals = GetAllAnimals();
		for (int i = 1; i < allAnimals.Count; i += 0)
		{
			((Component)allAnimals[i]).gameObject.SetActive(false);
			allAnimals[i].lastFreePathNode = Vector2.op_Implicit(((Component)allAnimals[i]).transform.position);
			if (WorldGrid.GJHHDIJOILG(((Component)allAnimals[i]).transform.position))
			{
				((Component)allAnimals[i]).transform.position = entrancePosition.position;
				allAnimals[i].lastFreePathNode = Vector2.op_Implicit(entrancePosition.position);
			}
			allAnimals[i].WalkAround();
		}
	}

	public void JFADIINLLBD(bool MJHBHDAEDLF)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		((Component)placeable.itemSpace).gameObject.SetActive(MJHBHDAEDLF);
		placeable.itemSpace.updateBuildSquares = MJHBHDAEDLF;
		if (MJHBHDAEDLF)
		{
			if (chickensAssigned.Count == maxAnimalsAssigned[base.EONJGMONIOM])
			{
				placeable.itemSpace.OBGGJJAKDPG(Color.red);
			}
			else
			{
				placeable.itemSpace.SetColor(Color.cyan);
			}
		}
		else
		{
			placeable.itemSpace.BFGEJLLBODF();
		}
	}

	private void LPLDDCGAHOM(int JIIGOACEIKL)
	{
		PlayerInventory.GetPlayer(JIIGOACEIKL).AddItems(eggItem.JMDALJBNFML(), eggsAmount, HMPDLIPFBGD: true);
		eggsAmount = 0;
		if (GameManager.PlayingOnline())
		{
			onlineHenHouse.EggsCollected();
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		ButtonsContext.ResetCrafterAction(JIIGOACEIKL);
	}

	public void EBFLEKNPKLI(ChickenNPC CPEMHDPGEBP)
	{
		chickensAssigned.Remove(CPEMHDPGEBP);
		BMBAMGFDIPD();
	}

	private void GEKCBBEMOGB(int JIIGOACEIKL)
	{
		List<AnimalNPC> allAnimals = GetAllAnimals();
		for (int i = 0; i < allAnimals.Count; i += 0)
		{
			((Component)allAnimals[i]).gameObject.SetActive(false);
		}
	}

	public override void Demolish(int JIIGOACEIKL)
	{
		PLNGLJOECAO();
		base.Demolish(JIIGOACEIKL);
	}

	public void PCAEKCAJCCN(Placeable EAPCLAODGAE)
	{
		((Behaviour)((Component)EAPCLAODGAE).GetComponent<AnimalNPC>().animationBase).enabled = false;
		ButtonsContext.GetPlayer(EAPCLAODGAE.PGMPPMPBCLO()).ResetChickensInsideHenHouse();
		ButtonsContext.GetPlayer(EAPCLAODGAE.PGMPPMPBCLO()).ResetButtons();
		EAPCLAODGAE.updateButtonsContext = false;
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	private void PLNGLJOECAO()
	{
		for (int num = chickensAssigned.Count - 1; num >= 0; num--)
		{
			if ((Object)(object)chickensAssigned[num] != (Object)null)
			{
				Utils.BLPDAEHPOBA(((Component)chickensAssigned[num]).gameObject);
			}
		}
	}

	public bool LMHMCNOBAGE(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (eggsAmount > 1)
			{
				COMODFJEIOF(JIIGOACEIKL);
			}
			else
			{
				FarmBuildingInfoUI.NAGEHKBLJDL(JIIGOACEIKL).farmBuilding = this;
				FarmBuildingInfoUI.AGNKKAPMHLN(JIIGOACEIKL).IDLAGJNLPJL();
			}
		}
		return false;
	}

	public void PLEKBLENGKF(SpritesList MDHGOHLMMOI)
	{
		style = MDHGOHLMMOI;
		UpdateSprite();
	}

	public void FFBEEGLKHGD(int MGNOBNCMDJG, bool CDPAMNIPPEC = true)
	{
		eggsAmount = Mathf.Max(0, Mathf.Min(eggsAmount + MGNOBNCMDJG, maxEggsAmount[base.EONJGMONIOM]));
		if (CDPAMNIPPEC)
		{
			OnlineObjectsManager.instance.SendEggIncrement(placeable.BEIPALOAAJJ, MGNOBNCMDJG);
		}
	}

	public void KBEEIJDNOMC(Placeable EAPCLAODGAE, bool CDPAMNIPPEC)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		AnimalNPC component = ((Component)EAPCLAODGAE).GetComponent<AnimalNPC>();
		((Behaviour)component.animationBase).enabled = true;
		component.animationBase.GAGOGFEBDCP(Direction.Down);
		component.lastFreePathNode = Vector2.op_Implicit(((Component)EAPCLAODGAE).transform.position);
		if (CDPAMNIPPEC)
		{
			EAPCLAODGAE.updateButtonsContext = false;
			ButtonsContext.SetPosition(EAPCLAODGAE.PHPMAEFGBBD(), ((Component)placeable.inputByProximity.actionButtonsPoint).transform.position);
			ButtonsContext.GetPlayer(EAPCLAODGAE.PHPMAEFGBBD()).DKCMJENPPFA();
			ButtonsContext.AddButton(EAPCLAODGAE.PHPMAEFGBBD(), ActionType.Hold, LocalisationSystem.Get("Body_Extra"));
			ButtonsContext.GetPlayer(EAPCLAODGAE.PGMPPMPBCLO()).OOFBLCGEFPM(GetAllAnimals(), maxAnimalsAssigned[base.EONJGMONIOM], ((Component)EAPCLAODGAE).GetComponent<ChickenNPC>());
		}
	}

	public bool AKFCDDOMNBF(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (eggsAmount > 0)
			{
				LPLDDCGAHOM(JIIGOACEIKL);
			}
			else
			{
				FarmBuildingInfoUI.BFCEHJIIAHN(JIIGOACEIKL).farmBuilding = this;
				FarmBuildingInfoUI.IEHEFJBFHJL(JIIGOACEIKL).OpenUI();
			}
		}
		return true;
	}

	private void NBBPNOHHLIN(int JIIGOACEIKL)
	{
		PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AddItems(eggItem.JMDALJBNFML(), eggsAmount, HMPDLIPFBGD: true);
		eggsAmount = 1;
		if (GameManager.PlayingOnline())
		{
			onlineHenHouse.EENIGFNABBK();
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		ButtonsContext.CPIIFPCIJEP(JIIGOACEIKL);
	}

	public void DeassignAnimal(ChickenNPC CPEMHDPGEBP)
	{
		chickensAssigned.Remove(CPEMHDPGEBP);
		FLPGJNEGIDJ();
	}

	public void BFHBJKAFDAO(Placeable EAPCLAODGAE, bool CDPAMNIPPEC)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		AnimalNPC component = ((Component)EAPCLAODGAE).GetComponent<AnimalNPC>();
		((Behaviour)component.animationBase).enabled = false;
		component.animationBase.GAGOGFEBDCP(Direction.Up);
		component.lastFreePathNode = Vector2.op_Implicit(((Component)EAPCLAODGAE).transform.position);
		if (CDPAMNIPPEC)
		{
			EAPCLAODGAE.updateButtonsContext = false;
			ButtonsContext.KBPDNGECKJN(EAPCLAODGAE.PHPMAEFGBBD(), ((Component)placeable.inputByProximity.actionButtonsPoint).transform.position);
			ButtonsContext.GetPlayer(EAPCLAODGAE.PHPMAEFGBBD()).ResetButtons();
			ButtonsContext.NHECENBLBAH(EAPCLAODGAE.PHPMAEFGBBD(), ActionType.Interact, LocalisationSystem.Get("R2"));
			ButtonsContext.GetPlayer(EAPCLAODGAE.PHPMAEFGBBD()).GFAAGFCIHKI(GetAllAnimals(), maxAnimalsAssigned[base.EONJGMONIOM], ((Component)EAPCLAODGAE).GetComponent<ChickenNPC>());
		}
	}

	public bool ABGHEMLLDKG(int JIIGOACEIKL)
	{
		if (IGLEJFFHKLE(JIIGOACEIKL))
		{
			if (eggsAmount > 1)
			{
				NBBPNOHHLIN(JIIGOACEIKL);
			}
			else
			{
				FarmBuildingInfoUI.AGNKKAPMHLN(JIIGOACEIKL).farmBuilding = this;
				FarmBuildingInfoUI.BMFHCBOFHCN(JIIGOACEIKL).OpenUI();
			}
		}
		return true;
	}

	public void AssignAnimal(ChickenNPC CPEMHDPGEBP, bool CDPAMNIPPEC)
	{
		if (!chickensAssigned.Contains(CPEMHDPGEBP))
		{
			chickensAssigned.Add(CPEMHDPGEBP);
		}
		CPEMHDPGEBP.currentBuilding = this;
		FLPGJNEGIDJ();
		UpdateAnimalsState();
		surfaceSortOrder.RemoveFromSurface(((Component)CPEMHDPGEBP.placeable).transform);
		((Behaviour)CPEMHDPGEBP.animationBase).enabled = true;
		CPEMHDPGEBP.WalkAround();
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			CPEMHDPGEBP.onlineAnimal.SendAssignChicken(onlineHenHouse.uniqueId);
		}
	}

	public override List<AnimalNPC> GetAllAnimals()
	{
		return new List<AnimalNPC>(chickensAssigned);
	}

	protected override void IEFIPPPLCEL()
	{
		base.IEFIPPPLCEL();
		foodFeeder.Improve();
		waterFeeders[0].Improve();
		FLPGJNEGIDJ();
		UpdateSprite();
	}

	public bool IEJBNMOKBAI(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool JJANBHCGKOJ(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void LHAANDAKPPP(Placeable EAPCLAODGAE, int JIIGOACEIKL)
	{
		ChickenNPC component = ((Component)EAPCLAODGAE).GetComponent<ChickenNPC>();
		MGNKKJMBIPG(component, CDPAMNIPPEC: true);
		ButtonsContext.GetPlayer(EAPCLAODGAE.PHPMAEFGBBD()).EHMLIFAMGFI();
		ButtonsContext.GetPlayer(EAPCLAODGAE.GetPlayerNum()).DKCMJENPPFA();
		EAPCLAODGAE.updateButtonsContext = true;
	}

	public void OnPlaceableSelected(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if (IsBuilt() && EAPCLAODGAE.itemSetup.item is Animal { animalType: AnimalType.Chicken })
		{
			HighlightBuildSquares(MJHBHDAEDLF: true);
		}
	}

	public void GGFCLDBJPKK(Placeable EAPCLAODGAE, int JIIGOACEIKL)
	{
		ChickenNPC component = ((Component)EAPCLAODGAE).GetComponent<ChickenNPC>();
		AssignAnimal(component, CDPAMNIPPEC: true);
		ButtonsContext.GetPlayer(EAPCLAODGAE.PGMPPMPBCLO()).EHMLIFAMGFI();
		ButtonsContext.GetPlayer(EAPCLAODGAE.GetPlayerNum()).ResetButtons();
		EAPCLAODGAE.updateButtonsContext = true;
	}

	private void DAONPPAIOMA()
	{
		try
		{
			if (HKHPMDDOMNP != null)
			{
				((MonoBehaviour)this).StopCoroutine(HKHPMDDOMNP);
			}
			HKHPMDDOMNP = ((MonoBehaviour)this).StartCoroutine(NLBGNCCOIAA());
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void NFMFDBBELJI(int JIIGOACEIKL)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		List<AnimalNPC> allAnimals = GetAllAnimals();
		for (int i = 0; i < allAnimals.Count; i++)
		{
			((Component)allAnimals[i]).gameObject.SetActive(true);
			allAnimals[i].lastFreePathNode = Vector2.op_Implicit(((Component)allAnimals[i]).transform.position);
			if (WorldGrid.GJHHDIJOILG(((Component)allAnimals[i]).transform.position, JGDOHPCLJPM: true))
			{
				((Component)allAnimals[i]).transform.position = entrancePosition.position;
				allAnimals[i].lastFreePathNode = Vector2.op_Implicit(entrancePosition.position);
			}
			allAnimals[i].WalkAround();
		}
	}

	private void NPHPOIFADAJ()
	{
		if (HKHPMDDOMNP != null)
		{
			((MonoBehaviour)this).StopCoroutine(HKHPMDDOMNP);
		}
		for (int i = 0; i < chickensAssigned.Count; i++)
		{
			chickensAssigned[i].GoHome();
		}
	}

	public bool MLDKIKOHBBG(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IGLEJFFHKLE(JIIGOACEIKL) && !IIEDALMMNLI)
		{
			if (eggsAmount > 0)
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Player"));
				ButtonsContext.GetPlayer(JIIGOACEIKL).SetCrafterAction(new ItemInstanceAmount(eggItem.JMDALJBNFML(), eggsAmount));
			}
			else
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("ReceiveActiveOrDisableCustomer"));
			}
			return true;
		}
		return true;
	}

	public void PCFJHCLIMDJ(ChickenNPC CPEMHDPGEBP)
	{
		chickensAssigned.Remove(CPEMHDPGEBP);
		BMBAMGFDIPD();
	}

	private void ELCCANHJFPH(int JIIGOACEIKL)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		List<AnimalNPC> allAnimals = GetAllAnimals();
		for (int i = 1; i < allAnimals.Count; i++)
		{
			((Component)allAnimals[i]).gameObject.SetActive(false);
			allAnimals[i].lastFreePathNode = Vector2.op_Implicit(((Component)allAnimals[i]).transform.position);
			if (WorldGrid.GJHHDIJOILG(((Component)allAnimals[i]).transform.position))
			{
				((Component)allAnimals[i]).transform.position = entrancePosition.position;
				allAnimals[i].lastFreePathNode = Vector2.op_Implicit(entrancePosition.position);
			}
			allAnimals[i].WalkAround();
		}
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	private void BMBAMGFDIPD()
	{
		if (Object.op_Implicit((Object)(object)surfaceSortOrder))
		{
			((Behaviour)surfaceSortOrder.surfaceCollider).enabled = chickensAssigned.Count < maxAnimalsAssigned[base.EONJGMONIOM];
		}
	}

	public void HighlightBuildSquares(bool MJHBHDAEDLF)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		((Component)placeable.itemSpace).gameObject.SetActive(MJHBHDAEDLF);
		placeable.itemSpace.updateBuildSquares = !MJHBHDAEDLF;
		if (MJHBHDAEDLF)
		{
			if (chickensAssigned.Count == maxAnimalsAssigned[base.EONJGMONIOM])
			{
				placeable.itemSpace.SetColor(Color.red);
			}
			else
			{
				placeable.itemSpace.SetColor(Color.cyan);
			}
		}
		else
		{
			placeable.itemSpace.SetInitialColor();
		}
	}

	protected override void NALJNIOAIAG()
	{
		base.NALJNIOAIAG();
		LKGAOEHMKKO();
	}

	private void MFFFKBHAKGD(int JIIGOACEIKL)
	{
		List<AnimalNPC> allAnimals = GetAllAnimals();
		for (int i = 0; i < allAnimals.Count; i += 0)
		{
			((Component)allAnimals[i]).gameObject.SetActive(true);
		}
	}

	private void OBBDDLKPAII(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		HighlightBuildSquares(MJHBHDAEDLF: false);
	}

	public void JIHPJCIKKML(int MGNOBNCMDJG, bool CDPAMNIPPEC = true)
	{
		eggsAmount = Mathf.Max(1, Mathf.Min(eggsAmount + MGNOBNCMDJG, maxEggsAmount[base.EONJGMONIOM]));
		if (CDPAMNIPPEC)
		{
			OnlineObjectsManager.instance.SendEggIncrement(placeable.BEIPALOAAJJ, MGNOBNCMDJG);
		}
	}

	private void PGILCAOONLE()
	{
		for (int num = chickensAssigned.Count - 1; num >= 0; num--)
		{
			if ((Object)(object)chickensAssigned[num] != (Object)null)
			{
				Utils.BLPDAEHPOBA(((Component)chickensAssigned[num]).gameObject);
			}
		}
	}

	private void FLPGJNEGIDJ()
	{
		if (Object.op_Implicit((Object)(object)surfaceSortOrder))
		{
			((Behaviour)surfaceSortOrder.surfaceCollider).enabled = chickensAssigned.Count < maxAnimalsAssigned[base.EONJGMONIOM];
		}
	}

	private void MENOEONEHNH()
	{
		if (HKHPMDDOMNP != null)
		{
			((MonoBehaviour)this).StopCoroutine(HKHPMDDOMNP);
		}
		for (int i = 1; i < chickensAssigned.Count; i++)
		{
			chickensAssigned[i].PBNOPNCNAKF();
		}
	}

	public bool DJPAEAOBLHD(int JIIGOACEIKL)
	{
		if (IGLEJFFHKLE(JIIGOACEIKL))
		{
			if (eggsAmount > 1)
			{
				COMODFJEIOF(JIIGOACEIKL);
			}
			else
			{
				FarmBuildingInfoUI.IEPGACAGIPO(JIIGOACEIKL).farmBuilding = this;
				FarmBuildingInfoUI.BGIMGOJDLFG(JIIGOACEIKL).OpenUI();
			}
		}
		return false;
	}

	private void GFEEIIADCFK(int JIIGOACEIKL)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		List<AnimalNPC> allAnimals = GetAllAnimals();
		for (int i = 1; i < allAnimals.Count; i++)
		{
			((Component)allAnimals[i]).gameObject.SetActive(true);
			allAnimals[i].lastFreePathNode = Vector2.op_Implicit(((Component)allAnimals[i]).transform.position);
			if (WorldGrid.GJHHDIJOILG(((Component)allAnimals[i]).transform.position, JGDOHPCLJPM: true))
			{
				((Component)allAnimals[i]).transform.position = entrancePosition.position;
				allAnimals[i].lastFreePathNode = Vector2.op_Implicit(entrancePosition.position);
			}
			allAnimals[i].WalkAround();
		}
	}

	public void DDAKDMKLDHL(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if (IsBuilt() && EAPCLAODGAE.itemSetup.item is Animal { animalType: AnimalType.Chicken })
		{
			HighlightBuildSquares(MJHBHDAEDLF: false);
		}
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool FCLHFAJMLBO(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (eggsAmount > 0)
			{
				LPLDDCGAHOM(JIIGOACEIKL);
			}
			else
			{
				FarmBuildingInfoUI.KLJCCHJHDGG(JIIGOACEIKL).farmBuilding = this;
				FarmBuildingInfoUI.AANKLOIDPOA(JIIGOACEIKL).IDLAGJNLPJL();
			}
		}
		return true;
	}

	public void OffHover(int JIIGOACEIKL)
	{
		ButtonsContext.ResetCrafterAction(JIIGOACEIKL);
	}

	public void OnChickenPlaced(Placeable EAPCLAODGAE, int JIIGOACEIKL)
	{
		ChickenNPC component = ((Component)EAPCLAODGAE).GetComponent<ChickenNPC>();
		AssignAnimal(component, CDPAMNIPPEC: true);
		ButtonsContext.GetPlayer(EAPCLAODGAE.GetPlayerNum()).ResetChickensInsideHenHouse();
		ButtonsContext.GetPlayer(EAPCLAODGAE.GetPlayerNum()).ResetButtons();
		EAPCLAODGAE.updateButtonsContext = true;
	}

	public void DCHCOFGMAKM(SpritesList MDHGOHLMMOI)
	{
		style = MDHGOHLMMOI;
		UpdateSprite();
	}

	public void CLCKHOCLOFF(int JIIGOACEIKL)
	{
	}

	public override void UpdateAnimalsState()
	{
		int currentAmount = foodFeeder.GetCurrentAmount();
		for (int i = 0; i < chickensAssigned.Count; i++)
		{
			chickensAssigned[i].hasFood = i < currentAmount;
		}
		currentAmount = waterFeeders[0].GetCurrentAmount();
		for (int j = 0; j < chickensAssigned.Count; j++)
		{
			chickensAssigned[j].hasWater = j < currentAmount;
		}
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL) && !IIEDALMMNLI)
		{
			if (eggsAmount > 0)
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Collect"));
				ButtonsContext.GetPlayer(JIIGOACEIKL).SetCrafterAction(new ItemInstanceAmount(eggItem.JMDALJBNFML(), eggsAmount));
			}
			else
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Information"));
			}
			return true;
		}
		return false;
	}

	public void MCBHIOOAIAM(int JIIGOACEIKL)
	{
		ButtonsContext.CPIIFPCIJEP(JIIGOACEIKL);
	}

	private void OJCIMGJPLLB(int JIIGOACEIKL)
	{
		List<AnimalNPC> allAnimals = GetAllAnimals();
		for (int i = 1; i < allAnimals.Count; i += 0)
		{
			((Component)allAnimals[i]).gameObject.SetActive(false);
		}
	}

	public void IECOBNAEBPJ(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if (IsBuilt() && EAPCLAODGAE.itemSetup.item is Animal { animalType: AnimalType.Chicken })
		{
			HighlightBuildSquares(MJHBHDAEDLF: true);
		}
	}

	protected override void HFMANGJKOMA()
	{
		foodFeeder.WasteUnit(chickensAssigned.Count);
	}

	private void KODPIFBNFOG()
	{
		if (HKHPMDDOMNP != null)
		{
			((MonoBehaviour)this).StopCoroutine(HKHPMDDOMNP);
		}
		for (int i = 0; i < chickensAssigned.Count; i += 0)
		{
			chickensAssigned[i].EBFCNMEDDJJ();
		}
	}

	public void OnChickenRemovedFromSurface(Placeable EAPCLAODGAE)
	{
		((Behaviour)((Component)EAPCLAODGAE).GetComponent<AnimalNPC>().animationBase).enabled = true;
		ButtonsContext.GetPlayer(EAPCLAODGAE.GetPlayerNum()).ResetChickensInsideHenHouse();
		ButtonsContext.GetPlayer(EAPCLAODGAE.GetPlayerNum()).ResetButtons();
		EAPCLAODGAE.updateButtonsContext = true;
	}

	public void BEBLOHAFHNO(int JIIGOACEIKL)
	{
		ButtonsContext.ResetCrafterAction(JIIGOACEIKL);
	}

	public void HKCMKOMMBNB(ChickenNPC CPEMHDPGEBP)
	{
		chickensAssigned.Remove(CPEMHDPGEBP);
		FLPGJNEGIDJ();
	}

	public void MGNKKJMBIPG(ChickenNPC CPEMHDPGEBP, bool CDPAMNIPPEC)
	{
		if (!chickensAssigned.Contains(CPEMHDPGEBP))
		{
			chickensAssigned.Add(CPEMHDPGEBP);
		}
		CPEMHDPGEBP.currentBuilding = this;
		FLPGJNEGIDJ();
		UpdateAnimalsState();
		surfaceSortOrder.RemoveFromSurface(((Component)CPEMHDPGEBP.placeable).transform);
		((Behaviour)CPEMHDPGEBP.animationBase).enabled = false;
		CPEMHDPGEBP.WalkAround();
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			CPEMHDPGEBP.onlineAnimal.SendAssignChicken(onlineHenHouse.uniqueId);
		}
	}

	public void FKKPKAFDOIJ(int JIIGOACEIKL)
	{
	}

	public void OBBHKOLLLJH(int JIIGOACEIKL)
	{
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	private void BEKHKKNPKNC()
	{
		try
		{
			if (HKHPMDDOMNP != null)
			{
				((MonoBehaviour)this).StopCoroutine(HKHPMDDOMNP);
			}
			HKHPMDDOMNP = ((MonoBehaviour)this).StartCoroutine(NLBGNCCOIAA());
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public void ECECBMAAHJN(SpritesList MDHGOHLMMOI)
	{
		style = MDHGOHLMMOI;
		UpdateSprite();
	}

	public void EKMBJHDPHPM(int JIIGOACEIKL)
	{
	}

	public void LFALLFNNINI(int JIIGOACEIKL)
	{
	}

	public void MCMDKDLCDGN(ChickenNPC CPEMHDPGEBP)
	{
		chickensAssigned.Remove(CPEMHDPGEBP);
		BMBAMGFDIPD();
	}

	public bool HJNKEKBANED(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	private void NAHDHKJPNDF(int JIIGOACEIKL)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		List<AnimalNPC> allAnimals = GetAllAnimals();
		for (int i = 0; i < allAnimals.Count; i++)
		{
			((Component)allAnimals[i]).gameObject.SetActive(false);
			allAnimals[i].lastFreePathNode = Vector2.op_Implicit(((Component)allAnimals[i]).transform.position);
			if (WorldGrid.GJHHDIJOILG(((Component)allAnimals[i]).transform.position, JGDOHPCLJPM: true))
			{
				((Component)allAnimals[i]).transform.position = entrancePosition.position;
				allAnimals[i].lastFreePathNode = Vector2.op_Implicit(entrancePosition.position);
			}
			allAnimals[i].WalkAround();
		}
	}

	private IEnumerator NLBGNCCOIAA()
	{
		return new MJPFNMHBDHG(1)
		{
			_003C_003E4__this = this
		};
	}

	public override void UpdateSprite()
	{
		base.UpdateSprite();
		if (IsBuilt())
		{
			improvementSpriteRenderer.sprite = style.improvementsSprites[base.EONJGMONIOM];
			((Component)foodFeeder).gameObject.SetActive(true);
			foodFeeder.SetLevel(base.EONJGMONIOM);
			((Component)waterFeeders[0]).gameObject.SetActive(true);
			waterFeeders[0].SetLevel(base.EONJGMONIOM);
		}
		else
		{
			((Component)foodFeeder).gameObject.SetActive(false);
			((Component)waterFeeders[0]).gameObject.SetActive(false);
		}
		placeable.itemSpace.UpdatePathNodes();
	}

	public bool NPJLDBMBILF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	private void NDOBENODMCD(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		LINBNJEDGBO(MJHBHDAEDLF: false);
	}

	public bool MNDDOAAODLI(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	protected override void LKGAOEHMKKO()
	{
		if (((Component)buzzVariants[0]).gameObject.activeSelf)
		{
			buzzVariants[0].buzzAnimation.SetBool("Map", EGFGNGJGBOP: true);
		}
		if (((Component)buzzVariants[1]).gameObject.activeSelf)
		{
			buzzVariants[1].buzzAnimation.SetBool("Hammer", EGFGNGJGBOP: true);
		}
		if (((Component)buzzVariants[2]).gameObject.activeSelf)
		{
			buzzVariants[2].buzzAnimation.SetBool("Map", EGFGNGJGBOP: true);
		}
		if (((Component)buzzVariants[3]).gameObject.activeSelf)
		{
			buzzVariants[3].buzzAnimation.SetBool("Hammer", EGFGNGJGBOP: true);
		}
		if (((Component)buzzVariants[4]).gameObject.activeSelf)
		{
			buzzVariants[4].buzzAnimation.SetBool("Map", EGFGNGJGBOP: true);
		}
		if (((Component)buzzVariants[5]).gameObject.activeSelf)
		{
			buzzVariants[5].buzzAnimation.SetBool("HammerFloor", EGFGNGJGBOP: true);
		}
	}

	private void OOOCOEKFCON(int JIIGOACEIKL)
	{
		List<AnimalNPC> allAnimals = GetAllAnimals();
		for (int i = 1; i < allAnimals.Count; i += 0)
		{
			((Component)allAnimals[i]).gameObject.SetActive(true);
		}
	}

	private IEnumerator EFLIOBDINDJ()
	{
		List<ChickenNPC> newChickensList = new List<ChickenNPC>(chickensAssigned);
		for (int i = 0; i < newChickensList.Count; i++)
		{
			yield return (object)new WaitForSeconds((float)Random.Range(2, 20));
			while (FarmConstructionManager.IsActived())
			{
				yield return CommonReferences.wait2;
			}
			if (Object.op_Implicit((Object)(object)newChickensList[i]))
			{
				((Component)newChickensList[i]).gameObject.SetActive(true);
				newChickensList[i].LeaveHome();
				newChickensList[i].animationBase.ForceDirection(Direction.Down);
				newChickensList[i].lastFreePathNode = Vector2.op_Implicit(((Component)newChickensList[i]).transform.position);
				newChickensList[i].WalkAround();
			}
		}
		HKHPMDDOMNP = null;
	}

	private void NABKHBDOMIH()
	{
		try
		{
			if (HKHPMDDOMNP != null)
			{
				((MonoBehaviour)this).StopCoroutine(HKHPMDDOMNP);
			}
			HKHPMDDOMNP = ((MonoBehaviour)this).StartCoroutine(NLBGNCCOIAA());
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public void FJOOIFLCOPF(int JIIGOACEIKL)
	{
	}

	private void HLGCFHDLHON()
	{
		try
		{
			if (HKHPMDDOMNP != null)
			{
				((MonoBehaviour)this).StopCoroutine(HKHPMDDOMNP);
			}
			HKHPMDDOMNP = ((MonoBehaviour)this).StartCoroutine(LJNJMFKEIPE());
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void OAOMALLBGAM()
	{
		try
		{
			if (HKHPMDDOMNP != null)
			{
				((MonoBehaviour)this).StopCoroutine(HKHPMDDOMNP);
			}
			HKHPMDDOMNP = ((MonoBehaviour)this).StartCoroutine(EFLIOBDINDJ());
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public void JKENBIBCAOO(Placeable EAPCLAODGAE)
	{
		((Behaviour)((Component)EAPCLAODGAE).GetComponent<AnimalNPC>().animationBase).enabled = true;
		ButtonsContext.GetPlayer(EAPCLAODGAE.PGMPPMPBCLO()).EHMLIFAMGFI();
		ButtonsContext.GetPlayer(EAPCLAODGAE.GetPlayerNum()).DKCMJENPPFA();
		EAPCLAODGAE.updateButtonsContext = true;
	}

	protected override void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			base.OnDestroy();
			if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Remove(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(OnPlaceableSelected));
				CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
				instance2.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(instance2.OnPlaceableDeselected, new Action<int, Placeable, bool>(OBBDDLKPAII));
				CommonReferences instance3 = CommonReferences.GGFJGHHHEJC;
				instance3.OnPlaceablePickedUp = (Action<int, Placeable, bool>)Delegate.Remove(instance3.OnPlaceablePickedUp, new Action<int, Placeable, bool>(OBBDDLKPAII));
				CommonReferences instance4 = CommonReferences.GGFJGHHHEJC;
				instance4.OnPlayerAwake = (Action)Delegate.Remove(instance4.OnPlayerAwake, new Action(ALGOBMNPLIB));
			}
			if (Object.op_Implicit((Object)(object)FarmConstructionManager.GetInstance()))
			{
				FarmConstructionManager instance5 = FarmConstructionManager.GetInstance();
				instance5.OnActivated = (Action<int>)Delegate.Remove(instance5.OnActivated, new Action<int>(BGHLHBHNHPO));
				FarmConstructionManager instance6 = FarmConstructionManager.GetInstance();
				instance6.OnDeactivated = (Action<int>)Delegate.Remove(instance6.OnDeactivated, new Action<int>(NFMFDBBELJI));
			}
			SurfaceSortOrder obj = surfaceSortOrder;
			obj.OnItemAdded = (Action<Placeable, bool>)Delegate.Remove(obj.OnItemAdded, new Action<Placeable, bool>(OnChickenAddedToSurface));
			SurfaceSortOrder obj2 = surfaceSortOrder;
			obj2.OnItemRemoved = (Action<Placeable>)Delegate.Remove(obj2.OnItemRemoved, new Action<Placeable>(OnChickenRemovedFromSurface));
			SurfaceSortOrder obj3 = surfaceSortOrder;
			obj3.OnItemPlaced = (Action<Placeable, int>)Delegate.Remove(obj3.OnItemPlaced, new Action<Placeable, int>(OnChickenPlaced));
			WorldTime.OnNightStart = (Action)Delegate.Remove(WorldTime.OnNightStart, new Action(NPHPOIFADAJ));
		}
	}

	private void IEONBJKOPFO(int JIIGOACEIKL)
	{
		List<AnimalNPC> allAnimals = GetAllAnimals();
		for (int i = 1; i < allAnimals.Count; i++)
		{
			((Component)allAnimals[i]).gameObject.SetActive(false);
		}
	}

	public void IncrementEggsAmount(int MGNOBNCMDJG, bool CDPAMNIPPEC = true)
	{
		eggsAmount = Mathf.Max(0, Mathf.Min(eggsAmount + MGNOBNCMDJG, maxEggsAmount[base.EONJGMONIOM]));
		if (CDPAMNIPPEC)
		{
			OnlineObjectsManager.instance.SendEggIncrement(placeable.BEIPALOAAJJ, MGNOBNCMDJG);
		}
	}

	public bool IGLEJFFHKLE(int JIIGOACEIKL)
	{
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DFNMDDHOIJI();
	}

	public void CDNPCGKAGLI(int JIIGOACEIKL)
	{
		ButtonsContext.ResetCrafterAction(JIIGOACEIKL);
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (eggsAmount > 0)
			{
				LPLDDCGAHOM(JIIGOACEIKL);
			}
			else
			{
				FarmBuildingInfoUI.Get(JIIGOACEIKL).farmBuilding = this;
				FarmBuildingInfoUI.Get(JIIGOACEIKL).OpenUI();
			}
		}
		return true;
	}

	public void ALJLGIANMOK(Placeable EAPCLAODGAE, bool CDPAMNIPPEC)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		AnimalNPC component = ((Component)EAPCLAODGAE).GetComponent<AnimalNPC>();
		((Behaviour)component.animationBase).enabled = false;
		component.animationBase.GAGOGFEBDCP(Direction.Down);
		component.lastFreePathNode = Vector2.op_Implicit(((Component)EAPCLAODGAE).transform.position);
		if (CDPAMNIPPEC)
		{
			EAPCLAODGAE.updateButtonsContext = true;
			ButtonsContext.KBPDNGECKJN(EAPCLAODGAE.PHPMAEFGBBD(), ((Component)placeable.inputByProximity.actionButtonsPoint).transform.position);
			ButtonsContext.GetPlayer(EAPCLAODGAE.PGMPPMPBCLO()).ResetButtons();
			ButtonsContext.IJKLIHJIOEN(EAPCLAODGAE.PHPMAEFGBBD(), ActionType.Hold, LocalisationSystem.Get("Items/item_name_732"));
			ButtonsContext.GetPlayer(EAPCLAODGAE.PHPMAEFGBBD()).OOFBLCGEFPM(GetAllAnimals(), maxAnimalsAssigned[base.EONJGMONIOM], ((Component)EAPCLAODGAE).GetComponent<ChickenNPC>());
		}
	}

	public void GMLDGKBJBOJ(ChickenNPC CPEMHDPGEBP)
	{
		chickensAssigned.Remove(CPEMHDPGEBP);
		BMBAMGFDIPD();
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	protected override void Start()
	{
		base.Start();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(OnPlaceableSelected));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance2.OnPlaceableDeselected, new Action<int, Placeable, bool>(OBBDDLKPAII));
		CommonReferences instance3 = CommonReferences.GGFJGHHHEJC;
		instance3.OnPlaceablePickedUp = (Action<int, Placeable, bool>)Delegate.Combine(instance3.OnPlaceablePickedUp, new Action<int, Placeable, bool>(OBBDDLKPAII));
		SurfaceSortOrder obj = surfaceSortOrder;
		obj.OnItemAdded = (Action<Placeable, bool>)Delegate.Combine(obj.OnItemAdded, new Action<Placeable, bool>(OnChickenAddedToSurface));
		SurfaceSortOrder obj2 = surfaceSortOrder;
		obj2.OnItemRemoved = (Action<Placeable>)Delegate.Combine(obj2.OnItemRemoved, new Action<Placeable>(OnChickenRemovedFromSurface));
		SurfaceSortOrder obj3 = surfaceSortOrder;
		obj3.OnItemPlaced = (Action<Placeable, int>)Delegate.Combine(obj3.OnItemPlaced, new Action<Placeable, int>(OnChickenPlaced));
		WorldTime.OnNightStart = (Action)Delegate.Combine(WorldTime.OnNightStart, new Action(NPHPOIFADAJ));
		CommonReferences instance4 = CommonReferences.GGFJGHHHEJC;
		instance4.OnPlayerAwake = (Action)Delegate.Combine(instance4.OnPlayerAwake, new Action(ALGOBMNPLIB));
		FarmConstructionManager instance5 = FarmConstructionManager.GetInstance();
		instance5.OnActivated = (Action<int>)Delegate.Combine(instance5.OnActivated, new Action<int>(BGHLHBHNHPO));
		FarmConstructionManager instance6 = FarmConstructionManager.GetInstance();
		instance6.OnDeactivated = (Action<int>)Delegate.Combine(instance6.OnDeactivated, new Action<int>(NFMFDBBELJI));
		if (HKHPMDDOMNP != null)
		{
			((MonoBehaviour)this).StopCoroutine(HKHPMDDOMNP);
		}
		HKHPMDDOMNP = ((MonoBehaviour)this).StartCoroutine(EFLIOBDINDJ());
		foodFeeder.container.allowedItemsList = (ItemDatabaseAccessor.GetItem(1239) as Chicken).OKPDBKOAGFO();
	}

	public void BBEHPHJNAHI(Placeable EAPCLAODGAE, int JIIGOACEIKL)
	{
		ChickenNPC component = ((Component)EAPCLAODGAE).GetComponent<ChickenNPC>();
		ONPCJPHOMCA(component, CDPAMNIPPEC: false);
		ButtonsContext.GetPlayer(EAPCLAODGAE.GetPlayerNum()).ResetChickensInsideHenHouse();
		ButtonsContext.GetPlayer(EAPCLAODGAE.PHPMAEFGBBD()).DKCMJENPPFA();
		EAPCLAODGAE.updateButtonsContext = false;
	}

	private void COMODFJEIOF(int JIIGOACEIKL)
	{
		PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: true).AINJENENGFG(eggItem.JMDALJBNFML(), eggsAmount, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: true, AOPGMJEMEFK: true);
		eggsAmount = 0;
		if (GameManager.FGFJEGOEDKJ())
		{
			onlineHenHouse.CFALHFMGGEN();
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		ButtonsContext.CPIIFPCIJEP(JIIGOACEIKL);
	}

	public void FGIBCBOHCEB(int JIIGOACEIKL)
	{
		ButtonsContext.ResetCrafterAction(JIIGOACEIKL);
	}

	public bool JENDIAHPKNK(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void ECELICGHJCI(Placeable EAPCLAODGAE, int JIIGOACEIKL)
	{
		ChickenNPC component = ((Component)EAPCLAODGAE).GetComponent<ChickenNPC>();
		AssignAnimal(component, CDPAMNIPPEC: true);
		ButtonsContext.GetPlayer(EAPCLAODGAE.GetPlayerNum()).EHMLIFAMGFI();
		ButtonsContext.GetPlayer(EAPCLAODGAE.GetPlayerNum()).DKCMJENPPFA();
		EAPCLAODGAE.updateButtonsContext = true;
	}

	public void JGANOKDNKCB(Placeable EAPCLAODGAE, bool CDPAMNIPPEC)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		AnimalNPC component = ((Component)EAPCLAODGAE).GetComponent<AnimalNPC>();
		((Behaviour)component.animationBase).enabled = true;
		component.animationBase.ForceDirection(Direction.Up);
		component.lastFreePathNode = Vector2.op_Implicit(((Component)EAPCLAODGAE).transform.position);
		if (CDPAMNIPPEC)
		{
			EAPCLAODGAE.updateButtonsContext = true;
			ButtonsContext.SetPosition(EAPCLAODGAE.PGMPPMPBCLO(), ((Component)placeable.inputByProximity.actionButtonsPoint).transform.position);
			ButtonsContext.GetPlayer(EAPCLAODGAE.GetPlayerNum()).DKCMJENPPFA();
			ButtonsContext.AddButton(EAPCLAODGAE.PHPMAEFGBBD(), ActionType.Hold, LocalisationSystem.Get("  "));
			ButtonsContext.GetPlayer(EAPCLAODGAE.GetPlayerNum()).OOFBLCGEFPM(GetAllAnimals(), maxAnimalsAssigned[base.EONJGMONIOM], ((Component)EAPCLAODGAE).GetComponent<ChickenNPC>());
		}
	}

	public void LDDAFMFLOHH(Placeable EAPCLAODGAE)
	{
		((Behaviour)((Component)EAPCLAODGAE).GetComponent<AnimalNPC>().animationBase).enabled = false;
		ButtonsContext.GetPlayer(EAPCLAODGAE.GetPlayerNum()).ResetChickensInsideHenHouse();
		ButtonsContext.GetPlayer(EAPCLAODGAE.PHPMAEFGBBD()).DKCMJENPPFA();
		EAPCLAODGAE.updateButtonsContext = true;
	}

	public void SetStyle(SpritesList MDHGOHLMMOI)
	{
		style = MDHGOHLMMOI;
		UpdateSprite();
	}

	public void ONPCJPHOMCA(ChickenNPC CPEMHDPGEBP, bool CDPAMNIPPEC)
	{
		if (!chickensAssigned.Contains(CPEMHDPGEBP))
		{
			chickensAssigned.Add(CPEMHDPGEBP);
		}
		CPEMHDPGEBP.currentBuilding = this;
		BMBAMGFDIPD();
		UpdateAnimalsState();
		surfaceSortOrder.RemoveFromSurface(((Component)CPEMHDPGEBP.placeable).transform);
		((Behaviour)CPEMHDPGEBP.animationBase).enabled = true;
		CPEMHDPGEBP.WalkAround();
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			CPEMHDPGEBP.onlineAnimal.SendAssignChicken(onlineHenHouse.uniqueId);
		}
	}
}
