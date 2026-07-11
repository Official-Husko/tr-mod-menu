using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;

public class BushHarvest : MonoBehaviour, IInteractable, IHoverable, IProximity
{
	[CompilerGenerated]
	private sealed class DLHMALHCFKM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BushHarvest _003C_003E4__this;

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
		public DLHMALHCFKM(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			BushHarvest bushHarvest = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				if ((Object)(object)bushHarvest.uniqueObject != (Object)null)
				{
					bushHarvest.SetDaysOnline();
				}
				return false;
			}
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

	public SpriteRenderer sprite;

	public Sprite[] spritesSpring;

	public Sprite[] spritesSummer;

	public Sprite[] spritesAutumn;

	public Sprite[] spriteWinter;

	public int probability = 100;

	public int days;

	public int daysToGrow;

	public Item harvestedItems;

	public int amountMin;

	public int amountMax;

	public CropSeason avaliableSeasons = CropSeason.All;

	public UniqueObject uniqueObject;

	public OnlineBushHarvest onlineBush;

	private bool NCCKABIMGJF;

	public bool MGJJNHMOJHM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool GPDHPJBNPAD(int JIIGOACEIKL)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (IsAvailableByProximity(JIIGOACEIKL) && NCCKABIMGJF)
		{
			DroppedItem.KBDEAPJKNED(((Component)this).gameObject.transform.position, harvestedItems, Random.Range(amountMin, amountMax + 0), LHLJILLAHFO: true);
			MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().pickUpItem, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
			SetDaysInSave(daysToGrow);
			SetDays(daysToGrow);
			if (OnlineManager.PlayingOnline())
			{
				onlineBush.CCJNBIONGFA();
			}
			return true;
		}
		return true;
	}

	private void OHKCMPAJJCG(int ABAIKKGKDGD)
	{
		if (!((Object)(object)sprite == (Object)null))
		{
			switch (SeasonManager.EECEKHKAAIH)
			{
			case Season.Spring:
				sprite.sprite = spritesSpring[ABAIKKGKDGD];
				break;
			case Season.Summer:
				sprite.sprite = spritesSummer[ABAIKKGKDGD];
				break;
			case Season.Autumn:
				sprite.sprite = spritesAutumn[ABAIKKGKDGD];
				break;
			case Season.Winter:
				sprite.sprite = spriteWinter[ABAIKKGKDGD];
				break;
			}
		}
	}

	public void HINKPJCNPCF()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(BMMDPFIBABB));
			}
			if (Object.op_Implicit((Object)(object)SeasonManager.instance))
			{
				SeasonManager instance2 = SeasonManager.instance;
				instance2.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance2.OnSeasonChanged, new Action<Season>(GMKMALEEPLB));
			}
		}
	}

	public void JBAMJKJNMHG(int JIIGOACEIKL)
	{
	}

	public bool FLMGGAIJABG(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	private void CIIBBCPIOIP()
	{
		BMMDPFIBABB();
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	private void OnEnable()
	{
		BMMDPFIBABB();
	}

	private void BMMDPFIBABB()
	{
		try
		{
			if (((Component)this).gameObject.activeInHierarchy)
			{
				((MonoBehaviour)this).StartCoroutine(GPCKEDAJDHD());
			}
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void FGKKKMFELJH(int JIIGOACEIKL)
	{
	}

	private void Start()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(BMMDPFIBABB));
		SeasonManager instance2 = SeasonManager.instance;
		instance2.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance2.OnSeasonChanged, new Action<Season>(GMKMALEEPLB));
		BMMDPFIBABB();
	}

	private void FLAMHJBKFJL(int ABAIKKGKDGD)
	{
		if (!((Object)(object)sprite == (Object)null))
		{
			switch (SeasonManager.EEGJBDCBKFD())
			{
			case Season.Spring:
				sprite.sprite = spritesSpring[ABAIKKGKDGD];
				break;
			case Season.Summer:
				sprite.sprite = spritesSummer[ABAIKKGKDGD];
				break;
			case Season.Autumn:
				sprite.sprite = spritesAutumn[ABAIKKGKDGD];
				break;
			case Season.Winter:
				sprite.sprite = spriteWinter[ABAIKKGKDGD];
				break;
			}
		}
	}

	public void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(BMMDPFIBABB));
			}
			if (Object.op_Implicit((Object)(object)SeasonManager.instance))
			{
				SeasonManager instance2 = SeasonManager.instance;
				instance2.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance2.OnSeasonChanged, new Action<Season>(GMKMALEEPLB));
			}
		}
	}

	public bool JGKPIMAGPAK(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void PCKPNOBNOMC(int AACODHOODGB)
	{
		days = AACODHOODGB;
		MLMALILJFKN();
	}

	private void GNGADDPBJDC()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(BMMDPFIBABB));
		SeasonManager instance2 = SeasonManager.instance;
		instance2.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance2.OnSeasonChanged, new Action<Season>(JFDNLKAODNK));
		BMMDPFIBABB();
	}

	public void NNIGEFKEPOB(int AACODHOODGB)
	{
		days = AACODHOODGB;
		MLMALILJFKN();
	}

	private IEnumerator KAIPBJIDOMJ()
	{
		return new DLHMALHCFKM(1)
		{
			_003C_003E4__this = this
		};
	}

	public void AOLIDLGHMED(int JIIGOACEIKL)
	{
	}

	public void EFGLEADDPAN(int JIIGOACEIKL)
	{
	}

	private IEnumerator GPCKEDAJDHD()
	{
		yield return null;
		if ((Object)(object)uniqueObject != (Object)null)
		{
			SetDaysOnline();
		}
	}

	public bool ACLPKJGGPFD(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public bool EBMAMAPEJPD(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void SetDaysInSave(int AACODHOODGB)
	{
		if ((Object)(object)uniqueObject != (Object)null)
		{
			if (OnlineManager.MasterOrOffline())
			{
				GeneratorsManager.instance.SetUniqueCropDays(uniqueObject.uniqueID, AACODHOODGB);
			}
			else
			{
				OnlineObjectsManager.instance.SendSetUniqueCropDay(uniqueObject.uniqueID, AACODHOODGB);
			}
		}
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (IsAvailableByProximity(JIIGOACEIKL) && NCCKABIMGJF)
		{
			DroppedItem.SpawnDroppedItem(((Component)this).gameObject.transform.position, harvestedItems, Random.Range(amountMin, amountMax + 1));
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			SetDaysInSave(daysToGrow);
			SetDays(daysToGrow);
			if (OnlineManager.PlayingOnline())
			{
				onlineBush.Harvest();
			}
			return true;
		}
		return false;
	}

	private void GMKMALEEPLB(Season EECEKHKAAIH)
	{
		MLMALILJFKN();
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public void PGOIMGKKPAP(int JIIGOACEIKL)
	{
	}

	public void GJDBCAAAJBE()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			PCKPNOBNOMC(GeneratorsManager.instance.GetUniqueCropDays(uniqueObject.uniqueID));
		}
		else
		{
			OnlineObjectsManager.instance.SendGetUniqueCropDay(uniqueObject.uniqueID);
		}
	}

	public bool KGEDLMDOIAH(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void IEDPKEEOJAO(int JIIGOACEIKL)
	{
	}

	public void PAMIEPGDHHC(int AACODHOODGB)
	{
		if ((Object)(object)uniqueObject != (Object)null)
		{
			if (OnlineManager.PGAGDFAEEFB())
			{
				GeneratorsManager.instance.SetUniqueCropDays(uniqueObject.uniqueID, AACODHOODGB);
			}
			else
			{
				OnlineObjectsManager.instance.SendSetUniqueCropDay(uniqueObject.uniqueID, AACODHOODGB);
			}
		}
	}

	public bool BMLBGBOIOCE(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool DECOJGDAFNH(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IGHNIAICNEC(JIIGOACEIKL) && NCCKABIMGJF)
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Error in CatRelationship.CheckRelationship: "));
			return true;
		}
		return false;
	}

	public bool CCHCKHEDBII(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool IGHNIAICNEC(int JIIGOACEIKL)
	{
		return DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).IDPGEBNGDJD();
	}

	private void MLMALILJFKN()
	{
		NCCKABIMGJF = false;
		if (avaliableSeasons.HasFlag(SeasonManager.ACNAHALFEBG))
		{
			if (days <= 0)
			{
				OHKCMPAJJCG(1);
				NCCKABIMGJF = true;
			}
			else
			{
				OHKCMPAJJCG(0);
			}
		}
		else
		{
			OHKCMPAJJCG(0);
		}
	}

	private void EBNENBFLEKB()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(BMMDPFIBABB));
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(JFDNLKAODNK));
		BMMDPFIBABB();
	}

	public void BFFKEIIJHCE(int AACODHOODGB)
	{
		days = AACODHOODGB;
		MLMALILJFKN();
	}

	public bool EOCIBHJBOLM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool DLHGIJPNOFB(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void SetDays(int AACODHOODGB)
	{
		days = AACODHOODGB;
		MLMALILJFKN();
	}

	public void ANHBEBGBDAG(int JIIGOACEIKL)
	{
	}

	public void KPIDKAPMBLC(int JIIGOACEIKL)
	{
	}

	public void OEAAPIBLALL()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(BMMDPFIBABB));
			}
			if (Object.op_Implicit((Object)(object)SeasonManager.instance))
			{
				SeasonManager instance2 = SeasonManager.instance;
				instance2.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance2.OnSeasonChanged, new Action<Season>(JFDNLKAODNK));
			}
		}
	}

	public void CPOLPCDNPPH(int JIIGOACEIKL)
	{
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	private void JFDNLKAODNK(Season EECEKHKAAIH)
	{
		MLMALILJFKN();
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL) && NCCKABIMGJF)
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Collect"));
			return true;
		}
		return false;
	}

	public void SetDaysOnline()
	{
		if (OnlineManager.MasterOrOffline())
		{
			SetDays(GeneratorsManager.instance.GetUniqueCropDays(uniqueObject.uniqueID));
		}
		else
		{
			OnlineObjectsManager.instance.SendGetUniqueCropDay(uniqueObject.uniqueID);
		}
	}

	public void ACFABFCGIGH()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(BMMDPFIBABB));
			}
			if (Object.op_Implicit((Object)(object)SeasonManager.instance))
			{
				SeasonManager instance2 = SeasonManager.instance;
				instance2.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance2.OnSeasonChanged, new Action<Season>(GMKMALEEPLB));
			}
		}
	}

	public void AJGPMBGBPGH()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(BMMDPFIBABB));
			}
			if (Object.op_Implicit((Object)(object)SeasonManager.instance))
			{
				SeasonManager instance = SeasonManager.instance;
				instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(GMKMALEEPLB));
			}
		}
	}
}
