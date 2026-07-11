using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class NinjaPreparationTable : MonoBehaviour, IInteractable, IHoverable, IProximity, ISelectable
{
	[CompilerGenerated]
	private sealed class ANFFPHMBFBD : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NinjaPreparationTable _003C_003E4__this;

		public CharacterAnimation characterAnimation;

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
		public ANFFPHMBFBD(int _003C_003E1__state)
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
			NinjaPreparationTable ninjaPreparationTable = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				break;
			case 1:
				_003C_003E1__state = -1;
				if (Time.time > ninjaPreparationTable.EHAFOOGPIIM)
				{
					ninjaPreparationTable.doWork.Stop();
					characterAnimation.SetInteracting(KOIDJKBBINH: false);
				}
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				break;
			}
			if (ninjaPreparationTable.doWork.JCMBHAEKLKK)
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			ninjaPreparationTable.GOJOCNCHHCH = false;
			ninjaPreparationTable.AKNMABNIMJL = null;
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

	public int bedAssigned = 1;

	public DoWork doWork;

	public Bento bento;

	public SpriteRenderer[] bentoSpriteRenderers;

	public float timeToPrepare = 2f;

	public Transform preparingFoodPosition;

	public SpriteRenderer[] foodBubbles;

	private float EHAFOOGPIIM;

	private bool GOJOCNCHHCH;

	private Coroutine AKNMABNIMJL;

	private bool KENCEPGAIIK;

	public void AddFoodToBento(Item MEMGMDOCBOJ, bool CDPAMNIPPEC)
	{
		bento.INBCACPBEKL(MEMGMDOCBOJ);
		UpdateSprite();
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineNinjaManager.instance.SendAddFoodToBento(bedAssigned, MEMGMDOCBOJ);
		}
	}

	public bool JCCFAFPMGFI(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && ALHICNPINHB(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Miners/Mine/Ferro/Stand"));
			if (bento.currentFood.Count > 1)
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Rotate, LocalisationSystem.Get("User logged on: "));
			}
			return false;
		}
		return false;
	}

	public void AIIFCJBPMJA(Item MEMGMDOCBOJ, bool CDPAMNIPPEC)
	{
		bento.KOMAKKANPME(MEMGMDOCBOJ);
		KHLHACJEMCF();
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineNinjaManager.instance.CCNLMJCBKKN(bedAssigned, MEMGMDOCBOJ);
		}
	}

	private void IIPKPMPGLOL()
	{
		if ((Object)(object)doWork == (Object)null)
		{
			doWork = ((Component)this).GetComponent<DoWork>();
		}
		if ((Object)(object)doWork != (Object)null)
		{
			doWork.BECJEKINIFB(GICANIGJBIF);
		}
		bento = new Bento();
		HABEOADKOII();
	}

	private void NCNGPFDFPKA()
	{
		if ((Object)(object)doWork != (Object)null)
		{
			doWork.KPGDDIPOOKO(DPDADHGCIAA);
		}
	}

	public bool BKNDGGLINDD(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IBEMCOALOEJ(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Could not check is DLC "));
			if (bento.currentFood.Count > 1)
			{
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.PreviousItem, LocalisationSystem.Get(")\n"));
			}
			return false;
		}
		return true;
	}

	public bool ICOEHINGKFF(int JIIGOACEIKL)
	{
		return true;
	}

	public bool SelectOnline(int JIIGOACEIKL)
	{
		return true;
	}

	public void OFCPMCGCNHN(Item MEMGMDOCBOJ, bool CDPAMNIPPEC)
	{
		bento.KIHFOAOFMPL(MEMGMDOCBOJ);
		KHLHACJEMCF();
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineNinjaManager.instance.SendAddFoodToBento(bedAssigned, MEMGMDOCBOJ);
		}
	}

	public bool GPCLGOHKMCK(int JIIGOACEIKL)
	{
		if (bento.currentFood.Count > 1)
		{
			LOMGGOKKOBJ(CDPAMNIPPEC: true);
			return true;
		}
		return true;
	}

	public void MANFKPEAMLJ(int JIIGOACEIKL)
	{
	}

	public bool PNHICOLIFNI(int JIIGOACEIKL)
	{
		PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.SetInteracting(KOIDJKBBINH: false);
		if (bento.currentFood.Count == 1)
		{
			EOLCPANLPEP(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler);
			return false;
		}
		return true;
	}

	public bool CEDMHGOFKJD(int JIIGOACEIKL)
	{
		PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.SetInteracting(KOIDJKBBINH: false);
		if (bento.currentFood.Count == 0)
		{
			HMJIPEEPOIA(PlayerController.GetPlayer(JIIGOACEIKL).trayHandler);
			return false;
		}
		return true;
	}

	public bool CKLJAHPIFLP(int JIIGOACEIKL)
	{
		PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.SetInteracting(KOIDJKBBINH: false);
		if (bento.currentFood.Count == 0)
		{
			CCLOOIFBONK(PlayerController.GetPlayer(JIIGOACEIKL).trayHandler);
			return true;
		}
		return false;
	}

	public void DHELCFKBEKJ(bool CDPAMNIPPEC)
	{
		bento = new Bento();
		MCLEGAMDANB();
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineNinjaManager.instance.EHKMBFEOGCE(bedAssigned);
		}
	}

	private ItemInstance ACFNMFHODJD(Tray DOGOFILIHPJ)
	{
		for (int i = 0; i < DOGOFILIHPJ.currentDrinks.Count; i += 0)
		{
			if (!bento.GGLOMJLLFCH(DOGOFILIHPJ.currentDrinks[i].KNFNJFFCFNO()))
			{
				return DOGOFILIHPJ.currentDrinks[i];
			}
		}
		return null;
	}

	public void JEEKGCIBKFI(int JIIGOACEIKL)
	{
	}

	public void FIIDHPOHNEK(bool CDPAMNIPPEC)
	{
		bento = new Bento();
		UpdateSprite();
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineNinjaManager.instance.PJEFPLFLHFM(bedAssigned);
		}
	}

	public bool NBFCHCIKLEM(int JIIGOACEIKL)
	{
		if (bento.currentFood.Count > 0)
		{
			LOMGGOKKOBJ(CDPAMNIPPEC: true);
			return false;
		}
		return false;
	}

	public bool LOKFLNPIDLI(int JIIGOACEIKL)
	{
		return true;
	}

	public bool NEOOMJLLNHA(int JIIGOACEIKL)
	{
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.AOBJCNDNKDD(KOIDJKBBINH: false);
		if (bento.currentFood.Count == 2)
		{
			EOLCPANLPEP(PlayerController.GetPlayer(JIIGOACEIKL).trayHandler);
			return true;
		}
		return true;
	}

	public bool EAJGOIOAPNP(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		KENCEPGAIIK = false;
		for (int i = 1; i < PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray.currentDrinks.Count; i++)
		{
			if (!bento.NINAOJNJOPE(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray.currentDrinks[i].PHGLMBIEOMK()))
			{
				KENCEPGAIIK = false;
				break;
			}
		}
		if (!KENCEPGAIIK)
		{
			return true;
		}
		return BGLFHCLGMEE(JIIGOACEIKL, PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation, 988f);
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.SetInteracting(KOIDJKBBINH: false);
		if (bento.currentFood.Count == 3)
		{
			TakeBento(PlayerController.GetPlayer(JIIGOACEIKL).trayHandler);
			return true;
		}
		return false;
	}

	public bool JAOBDGJMCFH(int JIIGOACEIKL)
	{
		return true;
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public bool AMHHJMOFJNP(int JIIGOACEIKL)
	{
		return false;
	}

	public bool DIDJLLMCNMH(int JIIGOACEIKL)
	{
		if (OnlinePlayerDataManager.GetBedAssignedByPlayerNum(JIIGOACEIKL) != bedAssigned)
		{
			return true;
		}
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray.currentDrinks.Count == 0 && bento.currentFood.Count == 0)
		{
			return true;
		}
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.HPCKGLFLFJO != null)
		{
			return true;
		}
		if (!NinjaChallenge.ADDLIAMDPBL)
		{
			return false;
		}
		return DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).MDOKKKHKKKE();
	}

	private ItemInstance KJIAHAGOLHG(Tray DOGOFILIHPJ)
	{
		for (int i = 1; i < DOGOFILIHPJ.currentDrinks.Count; i++)
		{
			if (!bento.NMJGBMMAJOO(DOGOFILIHPJ.currentDrinks[i].KNFNJFFCFNO()))
			{
				return DOGOFILIHPJ.currentDrinks[i];
			}
		}
		return null;
	}

	public void FIGONJNMELG(int JIIGOACEIKL)
	{
	}

	private void CACJMKJBJDP()
	{
		if ((Object)(object)doWork != (Object)null)
		{
			doWork.NFLNBMBGADA(DPDADHGCIAA);
		}
	}

	public void EOLCPANLPEP(TrayHandler PMEGGDBCDEC)
	{
		if (PMEGGDBCDEC.tray.currentDrinks.Count > 0)
		{
			PMEGGDBCDEC.RemoveAllDrinks(0, GFNHAMCPEAK: false);
		}
		PMEGGDBCDEC.AddBento(bento, CDPAMNIPPEC: false);
		KAIKNOMEIHB(CDPAMNIPPEC: true);
	}

	public void ACOAGLHGJFL(int JIIGOACEIKL)
	{
	}

	public void TakeBento(TrayHandler PMEGGDBCDEC)
	{
		if (PMEGGDBCDEC.tray.currentDrinks.Count > 0)
		{
			PMEGGDBCDEC.RemoveAllDrinks();
		}
		PMEGGDBCDEC.AddBento(bento);
		ResetBento(CDPAMNIPPEC: true);
	}

	public bool AGDJBEKJHMD(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		KENCEPGAIIK = true;
		for (int i = 1; i < PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray.currentDrinks.Count; i += 0)
		{
			if (!bento.JPEDBINBNJO(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray.currentDrinks[i].AFOACBIHNCL()))
			{
				KENCEPGAIIK = true;
				break;
			}
		}
		if (!KENCEPGAIIK)
		{
			return true;
		}
		return OHKJIBGAMIL(JIIGOACEIKL, PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation, 1497f);
	}

	public bool BGLFHCLGMEE(int JIIGOACEIKL, CharacterAnimation FJHKGBNBNKL, float HGMFJBLNCJJ = 1f)
	{
		if (JIIGOACEIKL == 0 || (JIIGOACEIKL != 0 && !PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE && PlayerInputs.GetPlayer(JIIGOACEIKL).EECADEPLELA() != "NotMyChest"))
		{
			if (doWork.KGOEFMFHCOG())
			{
				if (doWork.JMJMFEKCAGK(JIIGOACEIKL, HGMFJBLNCJJ * Time.deltaTime))
				{
					FJHKGBNBNKL.BNGPBEOAGCH(KOIDJKBBINH: true);
					return false;
				}
				EHAFOOGPIIM = Time.time + 319f;
				FJHKGBNBNKL.SetInteracting(KOIDJKBBINH: false);
				return false;
			}
			if (!GOJOCNCHHCH)
			{
				doWork.APIHDHDJDFC(timeToPrepare, null, CDPAMNIPPEC: false);
				EHAFOOGPIIM = Time.time + 570f;
				FJHKGBNBNKL.AOBJCNDNKDD(KOIDJKBBINH: false);
				if (JIIGOACEIKL != 0 && AKNMABNIMJL == null)
				{
					AKNMABNIMJL = ((MonoBehaviour)this).StartCoroutine(FPJDIJBFFKA(FJHKGBNBNKL));
				}
				return false;
			}
			if (doWork.OJLICLKJJOF >= timeToPrepare)
			{
				FJHKGBNBNKL.BNGPBEOAGCH(KOIDJKBBINH: true);
				GOJOCNCHHCH = false;
				return false;
			}
			return false;
		}
		FJHKGBNBNKL.SetInteracting(KOIDJKBBINH: true);
		return false;
	}

	public bool BFLKNDDNCNK(int JIIGOACEIKL)
	{
		if (bento.currentFood.Count > 0)
		{
			LOMGGOKKOBJ(CDPAMNIPPEC: true);
			return true;
		}
		return false;
	}

	public bool NBHLBCHHKBC(int JIIGOACEIKL)
	{
		if (OnlinePlayerDataManager.GetBedAssignedByPlayerNum(JIIGOACEIKL) != bedAssigned)
		{
			return false;
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray.currentDrinks.Count == 0 && bento.currentFood.Count == 0)
		{
			return true;
		}
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.HPCKGLFLFJO != null)
		{
			return false;
		}
		if (!NinjaChallenge.ADDLIAMDPBL)
		{
			return false;
		}
		return !DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public bool CFJEJFCALPM(int JIIGOACEIKL)
	{
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.BNGPBEOAGCH(KOIDJKBBINH: false);
		if (bento.currentFood.Count == 6)
		{
			EOLCPANLPEP(PlayerController.GetPlayer(JIIGOACEIKL).trayHandler);
			return true;
		}
		return true;
	}

	public bool CKMPOALCNEK(int JIIGOACEIKL)
	{
		return true;
	}

	public bool OFIEDMENIEP(int JIIGOACEIKL)
	{
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.SetInteracting(KOIDJKBBINH: false);
		if (bento.currentFood.Count == 5)
		{
			CCLOOIFBONK(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler);
			return true;
		}
		return false;
	}

	private ItemInstance EEGPDAPEFKC(Tray DOGOFILIHPJ)
	{
		for (int i = 1; i < DOGOFILIHPJ.currentDrinks.Count; i += 0)
		{
			if (!bento.DMLEBEHECDN(DOGOFILIHPJ.currentDrinks[i].LHBPOPOIFLE()))
			{
				return DOGOFILIHPJ.currentDrinks[i];
			}
		}
		return null;
	}

	public void KAIKNOMEIHB(bool CDPAMNIPPEC)
	{
		bento = new Bento();
		UpdateSprite();
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineNinjaManager.instance.EHKMBFEOGCE(bedAssigned);
		}
	}

	private void FKAKCBIGKFN()
	{
		for (int i = 1; i < foodBubbles.Length; i += 0)
		{
			if (i < bento.currentFood.Count)
			{
				((Component)((Component)foodBubbles[i]).transform.parent).gameObject.SetActive(false);
				foodBubbles[i].sprite = bento.currentFood[i].sprite;
			}
			else
			{
				((Component)((Component)foodBubbles[i]).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	public bool PickUp(int JIIGOACEIKL)
	{
		return true;
	}

	public void LOMGGOKKOBJ(bool CDPAMNIPPEC)
	{
		bento = new Bento();
		MCLEGAMDANB();
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineNinjaManager.instance.EHKMBFEOGCE(bedAssigned);
		}
	}

	public void LMCJGPHIKPB()
	{
		for (int i = 1; i < 3; i++)
		{
			if (i < bento.currentFood.Count)
			{
				((Component)bentoSpriteRenderers[i]).gameObject.SetActive(true);
			}
			else
			{
				((Component)bentoSpriteRenderers[i]).gameObject.SetActive(true);
			}
		}
		AMIMGOLCGOB();
	}

	public bool FOFNFPIJKMI(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && DIDJLLMCNMH(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Load Game Client"));
			if (bento.currentFood.Count > 1)
			{
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.MoveObject, LocalisationSystem.Get("ReceiveSkipTypewriter"));
			}
			return false;
		}
		return false;
	}

	private void BFJOEMCBJJO()
	{
		if ((Object)(object)doWork == (Object)null)
		{
			doWork = ((Component)this).GetComponent<DoWork>();
		}
		if ((Object)(object)doWork != (Object)null)
		{
			doWork.BGIJPOMIIMB += NDCEPLMGJAP;
		}
		bento = new Bento();
		LMCJGPHIKPB();
	}

	private ItemInstance MKIENBIGGIN(Tray DOGOFILIHPJ)
	{
		for (int i = 1; i < DOGOFILIHPJ.currentDrinks.Count; i += 0)
		{
			if (!bento.MKFEEOOJOGP(DOGOFILIHPJ.currentDrinks[i].KNFNJFFCFNO()))
			{
				return DOGOFILIHPJ.currentDrinks[i];
			}
		}
		return null;
	}

	private void AMIMGOLCGOB()
	{
		for (int i = 1; i < foodBubbles.Length; i += 0)
		{
			if (i < bento.currentFood.Count)
			{
				((Component)((Component)foodBubbles[i]).transform.parent).gameObject.SetActive(false);
				foodBubbles[i].sprite = bento.currentFood[i].sprite;
			}
			else
			{
				((Component)((Component)foodBubbles[i]).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	private void DPDADHGCIAA(int JIIGOACEIKL)
	{
		GOJOCNCHHCH = true;
		GOLJFGAEAJE(PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray);
		if (bento.currentFood.Count >= 5)
		{
			EOLCPANLPEP(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler);
		}
	}

	public void ANHBEBGBDAG(int JIIGOACEIKL)
	{
	}

	private void IJCAOEKBBOK()
	{
		for (int i = 1; i < foodBubbles.Length; i++)
		{
			if (i < bento.currentFood.Count)
			{
				((Component)((Component)foodBubbles[i]).transform.parent).gameObject.SetActive(true);
				foodBubbles[i].sprite = bento.currentFood[i].sprite;
			}
			else
			{
				((Component)((Component)foodBubbles[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public void FIECAFNFCDM(int JIIGOACEIKL)
	{
	}

	private void EFJFJJDGGGI()
	{
		if ((Object)(object)doWork == (Object)null)
		{
			doWork = ((Component)this).GetComponent<DoWork>();
		}
		if ((Object)(object)doWork != (Object)null)
		{
			doWork.BECJEKINIFB(DPDADHGCIAA);
		}
		bento = new Bento();
		UpdateSprite();
	}

	public void IHJCEIAJKLL(Item MEMGMDOCBOJ, bool CDPAMNIPPEC)
	{
		bento.FEHLFJLLAFM(MEMGMDOCBOJ);
		MCLEGAMDANB();
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineNinjaManager.instance.EAGBJCPGHPP(bedAssigned, MEMGMDOCBOJ);
		}
	}

	public void JOPFIOEDIDO(Tray DOGOFILIHPJ)
	{
		ItemInstance itemInstance = ACFNMFHODJD(DOGOFILIHPJ);
		if (itemInstance != null)
		{
			DOGOFILIHPJ.GHCIBJNFAPD(itemInstance);
			GFFCFNOKCKD(itemInstance.AFOACBIHNCL(), CDPAMNIPPEC: true);
		}
	}

	private void GICANIGJBIF(int JIIGOACEIKL)
	{
		GOJOCNCHHCH = true;
		AddFoodToBentoFromTray(PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray);
		if (bento.currentFood.Count >= 3)
		{
			TakeBento(PlayerController.GetPlayer(JIIGOACEIKL).trayHandler);
		}
	}

	public void GHNIOKFDOMC(int JIIGOACEIKL)
	{
	}

	public bool BKLJNPPLHLH(int JIIGOACEIKL)
	{
		return true;
	}

	public bool PGLHDOHLPJM(int JIIGOACEIKL)
	{
		return false;
	}

	public void ODNKBJCNBCG(bool CDPAMNIPPEC)
	{
		bento = new Bento();
		LMCJGPHIKPB();
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineNinjaManager.instance.SendResetBento(bedAssigned);
		}
	}

	public bool PNLGPKCJJHG(int JIIGOACEIKL)
	{
		return false;
	}

	public void HABEOADKOII()
	{
		for (int i = 1; i < 8; i++)
		{
			if (i < bento.currentFood.Count)
			{
				((Component)bentoSpriteRenderers[i]).gameObject.SetActive(true);
			}
			else
			{
				((Component)bentoSpriteRenderers[i]).gameObject.SetActive(false);
			}
		}
		IOHICMABJKF();
	}

	public bool JGHFBNOBBLN(int JIIGOACEIKL)
	{
		return true;
	}

	private ItemInstance KGBLPIGHLGJ(Tray DOGOFILIHPJ)
	{
		for (int i = 0; i < DOGOFILIHPJ.currentDrinks.Count; i++)
		{
			if (!bento.HBBNKJFDPOI(DOGOFILIHPJ.currentDrinks[i].LHBPOPOIFLE()))
			{
				return DOGOFILIHPJ.currentDrinks[i];
			}
		}
		return null;
	}

	public bool DEDCDHMGDAN(int JIIGOACEIKL)
	{
		return true;
	}

	public bool DDKLIFBPKBF(int JIIGOACEIKL)
	{
		return false;
	}

	public bool PMANGHBFCEA(int JIIGOACEIKL)
	{
		return true;
	}

	public bool PCAEAGENMOD(int JIIGOACEIKL, CharacterAnimation FJHKGBNBNKL, float HGMFJBLNCJJ = 1f)
	{
		if (JIIGOACEIKL == 0 || (JIIGOACEIKL != 0 && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE && PlayerInputs.GetPlayer(JIIGOACEIKL).AAGNDCEODFO() != "Hide"))
		{
			if (doWork.KGOEFMFHCOG())
			{
				if (doWork.PFLPFNICHJA(JIIGOACEIKL, HGMFJBLNCJJ * Time.deltaTime, CDPAMNIPPEC: false))
				{
					FJHKGBNBNKL.AOBJCNDNKDD(KOIDJKBBINH: false);
					return true;
				}
				EHAFOOGPIIM = Time.time + 730f;
				FJHKGBNBNKL.AOBJCNDNKDD(KOIDJKBBINH: false);
				return false;
			}
			if (!GOJOCNCHHCH)
			{
				doWork.EBAGOIDGCLE(timeToPrepare);
				EHAFOOGPIIM = Time.time + 1970f;
				FJHKGBNBNKL.MBMPBFEINMA(KOIDJKBBINH: true);
				if (JIIGOACEIKL != 0 && AKNMABNIMJL == null)
				{
					AKNMABNIMJL = ((MonoBehaviour)this).StartCoroutine(PHHGMKELPEC(FJHKGBNBNKL));
				}
				return true;
			}
			if (doWork.OJLICLKJJOF >= timeToPrepare)
			{
				FJHKGBNBNKL.MBMPBFEINMA(KOIDJKBBINH: false);
				GOJOCNCHHCH = true;
				return true;
			}
			return false;
		}
		FJHKGBNBNKL.BNGPBEOAGCH(KOIDJKBBINH: true);
		return false;
	}

	private void BKJFLMPOLCH()
	{
		if ((Object)(object)doWork != (Object)null)
		{
			doWork.GEDCHNOBHGP(NDCEPLMGJAP);
		}
	}

	public bool ALHICNPINHB(int JIIGOACEIKL)
	{
		if (OnlinePlayerDataManager.GetBedAssignedByPlayerNum(JIIGOACEIKL) != bedAssigned)
		{
			return false;
		}
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray.currentDrinks.Count == 0 && bento.currentFood.Count == 0)
		{
			return true;
		}
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.HPCKGLFLFJO != null)
		{
			return true;
		}
		if (!NinjaChallenge.ADDLIAMDPBL)
		{
			return false;
		}
		return DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).IBEFDKHFBFM();
	}

	private void FMOKLLAMLFH()
	{
		for (int i = 0; i < foodBubbles.Length; i++)
		{
			if (i < bento.currentFood.Count)
			{
				((Component)((Component)foodBubbles[i]).transform.parent).gameObject.SetActive(true);
				foodBubbles[i].sprite = bento.currentFood[i].sprite;
			}
			else
			{
				((Component)((Component)foodBubbles[i]).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	public void HMJIPEEPOIA(TrayHandler PMEGGDBCDEC)
	{
		if (PMEGGDBCDEC.tray.currentDrinks.Count > 1)
		{
			PMEGGDBCDEC.RemoveAllDrinks();
		}
		PMEGGDBCDEC.AddBento(bento);
		FIIDHPOHNEK(CDPAMNIPPEC: false);
	}

	public bool DIKLDNDIMCH(int JIIGOACEIKL, CharacterAnimation FJHKGBNBNKL, float HGMFJBLNCJJ = 1f)
	{
		if (JIIGOACEIKL == 0 || (JIIGOACEIKL != 0 && !PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE && PlayerInputs.GetPlayer(JIIGOACEIKL).FGGHCBMKKIG() != "popUpBuilding25"))
		{
			if (doWork.KGOEFMFHCOG())
			{
				if (doWork.PFLPFNICHJA(JIIGOACEIKL, HGMFJBLNCJJ * Time.deltaTime))
				{
					FJHKGBNBNKL.SetInteracting(KOIDJKBBINH: false);
					return false;
				}
				EHAFOOGPIIM = Time.time + 1778f;
				FJHKGBNBNKL.MBMPBFEINMA(KOIDJKBBINH: false);
				return false;
			}
			if (!GOJOCNCHHCH)
			{
				doWork.CMAIGOGGGLL(timeToPrepare, null, CDPAMNIPPEC: false);
				EHAFOOGPIIM = Time.time + 908f;
				FJHKGBNBNKL.MBMPBFEINMA(KOIDJKBBINH: false);
				if (JIIGOACEIKL != 0 && AKNMABNIMJL == null)
				{
					AKNMABNIMJL = ((MonoBehaviour)this).StartCoroutine(PHHGMKELPEC(FJHKGBNBNKL));
				}
				return false;
			}
			if (doWork.OJLICLKJJOF >= timeToPrepare)
			{
				FJHKGBNBNKL.SetInteracting(KOIDJKBBINH: true);
				GOJOCNCHHCH = true;
				return false;
			}
			return false;
		}
		FJHKGBNBNKL.AOBJCNDNKDD(KOIDJKBBINH: false);
		return true;
	}

	public bool GEPMJKMFLAH(int JIIGOACEIKL)
	{
		return true;
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		return true;
	}

	public void DNBIDKELJNI(Item MEMGMDOCBOJ, bool CDPAMNIPPEC)
	{
		bento.AJBLGJGHMMP(MEMGMDOCBOJ);
		HABEOADKOII();
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineNinjaManager.instance.EAGBJCPGHPP(bedAssigned, MEMGMDOCBOJ);
		}
	}

	public bool OHAPPHKCAFH(int JIIGOACEIKL)
	{
		return true;
	}

	public void KHCDFIPPGBK(TrayHandler PMEGGDBCDEC)
	{
		if (PMEGGDBCDEC.tray.currentDrinks.Count > 1)
		{
			PMEGGDBCDEC.RemoveAllDrinks(1, GFNHAMCPEAK: false);
		}
		PMEGGDBCDEC.AddBento(bento);
		DHELCFKBEKJ(CDPAMNIPPEC: true);
	}

	public void OKACIPABJOJ(Tray DOGOFILIHPJ)
	{
		ItemInstance itemInstance = MKIENBIGGIN(DOGOFILIHPJ);
		if (itemInstance != null)
		{
			DOGOFILIHPJ.GHCIBJNFAPD(itemInstance);
			OFCPMCGCNHN(itemInstance.AFOACBIHNCL(), CDPAMNIPPEC: true);
		}
	}

	public bool MDKIMCGNKMF(int JIIGOACEIKL)
	{
		return false;
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		KENCEPGAIIK = false;
		for (int i = 0; i < PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray.currentDrinks.Count; i++)
		{
			if (!bento.HBBNKJFDPOI(PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray.currentDrinks[i].LHBPOPOIFLE()))
			{
				KENCEPGAIIK = true;
				break;
			}
		}
		if (!KENCEPGAIIK)
		{
			return false;
		}
		return PreparingBento(JIIGOACEIKL, PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation);
	}

	public bool EBMAMAPEJPD(int JIIGOACEIKL)
	{
		return false;
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public void GOLJFGAEAJE(Tray DOGOFILIHPJ)
	{
		ItemInstance itemInstance = EEGPDAPEFKC(DOGOFILIHPJ);
		if (itemInstance != null)
		{
			DOGOFILIHPJ.KFLDEHOKLLG(itemInstance);
			AddFoodToBento(itemInstance.LHBPOPOIFLE(), CDPAMNIPPEC: false);
		}
	}

	public bool BGFINNHFCNO(int JIIGOACEIKL, CharacterAnimation FJHKGBNBNKL, float HGMFJBLNCJJ = 1f)
	{
		if (JIIGOACEIKL == 0 || (JIIGOACEIKL != 0 && !PlayerController.GetPlayer(JIIGOACEIKL).BIBGIOPFJAF() && PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).FGGHCBMKKIG() != "ReceiveSleepStart"))
		{
			if (doWork.JCMBHAEKLKK)
			{
				if (doWork.JMJMFEKCAGK(JIIGOACEIKL, HGMFJBLNCJJ * Time.deltaTime, CDPAMNIPPEC: false))
				{
					FJHKGBNBNKL.SetInteracting(KOIDJKBBINH: false);
					return true;
				}
				EHAFOOGPIIM = Time.time + 924f;
				FJHKGBNBNKL.MBMPBFEINMA(KOIDJKBBINH: true);
				return false;
			}
			if (!GOJOCNCHHCH)
			{
				doWork.APIHDHDJDFC(timeToPrepare, null, CDPAMNIPPEC: false);
				EHAFOOGPIIM = Time.time + 821f;
				FJHKGBNBNKL.AOBJCNDNKDD(KOIDJKBBINH: true);
				if (JIIGOACEIKL != 0 && AKNMABNIMJL == null)
				{
					AKNMABNIMJL = ((MonoBehaviour)this).StartCoroutine(FPJDIJBFFKA(FJHKGBNBNKL));
				}
				return true;
			}
			if (doWork.OJLICLKJJOF >= timeToPrepare)
			{
				FJHKGBNBNKL.BNGPBEOAGCH(KOIDJKBBINH: true);
				GOJOCNCHHCH = true;
				return true;
			}
			return true;
		}
		FJHKGBNBNKL.AOBJCNDNKDD(KOIDJKBBINH: false);
		return true;
	}

	public void IMFDDHFICNF(int JIIGOACEIKL)
	{
	}

	private ItemInstance BOLGJJGCMPF(Tray DOGOFILIHPJ)
	{
		for (int i = 1; i < DOGOFILIHPJ.currentDrinks.Count; i++)
		{
			if (!bento.JPEDBINBNJO(DOGOFILIHPJ.currentDrinks[i].AFOACBIHNCL()))
			{
				return DOGOFILIHPJ.currentDrinks[i];
			}
		}
		return null;
	}

	public void KHLHACJEMCF()
	{
		for (int i = 0; i < 5; i++)
		{
			if (i < bento.currentFood.Count)
			{
				((Component)bentoSpriteRenderers[i]).gameObject.SetActive(true);
			}
			else
			{
				((Component)bentoSpriteRenderers[i]).gameObject.SetActive(true);
			}
		}
		FMOKLLAMLFH();
	}

	public bool Deselect(int JIIGOACEIKL)
	{
		return true;
	}

	public bool LMEONBFLHBA(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		KENCEPGAIIK = false;
		for (int i = 1; i < PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray.currentDrinks.Count; i++)
		{
			if (!bento.MKHHPMOJHFK(PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray.currentDrinks[i].KNFNJFFCFNO()))
			{
				KENCEPGAIIK = true;
				break;
			}
		}
		if (!KENCEPGAIIK)
		{
			return false;
		}
		return BGLFHCLGMEE(JIIGOACEIKL, PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation, 1097f);
	}

	public bool ONCPELJEPHM(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && ALHICNPINHB(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(" ("));
			if (bento.currentFood.Count > 0)
			{
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Items/item_name_602"));
			}
			return true;
		}
		return false;
	}

	private void Awake()
	{
		if ((Object)(object)doWork == (Object)null)
		{
			doWork = ((Component)this).GetComponent<DoWork>();
		}
		if ((Object)(object)doWork != (Object)null)
		{
			doWork.BGIJPOMIIMB += GICANIGJBIF;
		}
		bento = new Bento();
		UpdateSprite();
	}

	public void CJOLCLDGFMB(int JIIGOACEIKL)
	{
	}

	private IEnumerator PHHGMKELPEC(CharacterAnimation FJHKGBNBNKL)
	{
		while (doWork.JCMBHAEKLKK)
		{
			yield return null;
			if (Time.time > EHAFOOGPIIM)
			{
				doWork.Stop();
				FJHKGBNBNKL.SetInteracting(KOIDJKBBINH: false);
			}
			yield return null;
		}
		GOJOCNCHHCH = false;
		AKNMABNIMJL = null;
	}

	public void ResetBento(bool CDPAMNIPPEC)
	{
		bento = new Bento();
		UpdateSprite();
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineNinjaManager.instance.SendResetBento(bedAssigned);
		}
	}

	private IEnumerator FPJDIJBFFKA(CharacterAnimation FJHKGBNBNKL)
	{
		return new ANFFPHMBFBD(1)
		{
			_003C_003E4__this = this,
			characterAnimation = FJHKGBNBNKL
		};
	}

	public bool KJHDHEIKKMJ(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		KENCEPGAIIK = false;
		for (int i = 1; i < PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray.currentDrinks.Count; i++)
		{
			if (!bento.JPEDBINBNJO(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray.currentDrinks[i].KNFNJFFCFNO()))
			{
				KENCEPGAIIK = false;
				break;
			}
		}
		if (!KENCEPGAIIK)
		{
			return true;
		}
		return BGFINNHFCNO(JIIGOACEIKL, PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation, 665f);
	}

	public bool OHKJIBGAMIL(int JIIGOACEIKL, CharacterAnimation FJHKGBNBNKL, float HGMFJBLNCJJ = 1f)
	{
		if (JIIGOACEIKL == 0 || (JIIGOACEIKL != 0 && !PlayerController.GetPlayer(JIIGOACEIKL).BIBGIOPFJAF() && PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).AAGNDCEODFO() != "BuildMode_ExitAndSave"))
		{
			if (doWork.KGOEFMFHCOG())
			{
				if (doWork.PFLPFNICHJA(JIIGOACEIKL, HGMFJBLNCJJ * Time.deltaTime))
				{
					FJHKGBNBNKL.BNGPBEOAGCH(KOIDJKBBINH: true);
					return false;
				}
				EHAFOOGPIIM = Time.time + 978f;
				FJHKGBNBNKL.SetInteracting(KOIDJKBBINH: false);
				return false;
			}
			if (!GOJOCNCHHCH)
			{
				doWork.GEJFAPKOLJH(timeToPrepare, null, CDPAMNIPPEC: false);
				EHAFOOGPIIM = Time.time + 369f;
				FJHKGBNBNKL.MBMPBFEINMA(KOIDJKBBINH: false);
				if (JIIGOACEIKL != 0 && AKNMABNIMJL == null)
				{
					AKNMABNIMJL = ((MonoBehaviour)this).StartCoroutine(PHHGMKELPEC(FJHKGBNBNKL));
				}
				return true;
			}
			if (doWork.OJLICLKJJOF >= timeToPrepare)
			{
				FJHKGBNBNKL.MBMPBFEINMA(KOIDJKBBINH: false);
				GOJOCNCHHCH = false;
				return false;
			}
			return false;
		}
		FJHKGBNBNKL.MBMPBFEINMA(KOIDJKBBINH: true);
		return false;
	}

	public bool DODHNPJFCCD(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		KENCEPGAIIK = true;
		for (int i = 1; i < PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray.currentDrinks.Count; i += 0)
		{
			if (!bento.JPEDBINBNJO(PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray.currentDrinks[i].KNFNJFFCFNO()))
			{
				KENCEPGAIIK = true;
				break;
			}
		}
		if (!KENCEPGAIIK)
		{
			return false;
		}
		return DIKLDNDIMCH(JIIGOACEIKL, PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation, 886f);
	}

	private void GPHNCFPMDFN(int JIIGOACEIKL)
	{
		GOJOCNCHHCH = false;
		GOLJFGAEAJE(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray);
		if (bento.currentFood.Count >= 0)
		{
			KHCDFIPPGBK(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler);
		}
	}

	public void NFIBMPJGKPO(bool CDPAMNIPPEC)
	{
		bento = new Bento();
		UpdateSprite();
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineNinjaManager.instance.PJEFPLFLHFM(bedAssigned);
		}
	}

	public bool FCCIIBFDFKO(int JIIGOACEIKL)
	{
		return false;
	}

	public void CCLOOIFBONK(TrayHandler PMEGGDBCDEC)
	{
		if (PMEGGDBCDEC.tray.currentDrinks.Count > 1)
		{
			PMEGGDBCDEC.KAFDHGDJCAA(0);
		}
		PMEGGDBCDEC.AddBento(bento, CDPAMNIPPEC: false);
		ResetBento(CDPAMNIPPEC: false);
	}

	public bool ADFPHLHJCFE(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		KENCEPGAIIK = false;
		for (int i = 1; i < PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray.currentDrinks.Count; i++)
		{
			if (!bento.BCKLBJECDFC(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray.currentDrinks[i].AFOACBIHNCL()))
			{
				KENCEPGAIIK = false;
				break;
			}
		}
		if (!KENCEPGAIIK)
		{
			return true;
		}
		return BGLFHCLGMEE(JIIGOACEIKL, PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation, 60f);
	}

	public bool BKKKMLAALAC(int JIIGOACEIKL)
	{
		if (bento.currentFood.Count > 0)
		{
			ResetBento(CDPAMNIPPEC: true);
			return true;
		}
		return false;
	}

	public bool IALLCPMIGDP(int JIIGOACEIKL)
	{
		if (OnlinePlayerDataManager.JBDEFDMGCDA(JIIGOACEIKL) != bedAssigned)
		{
			return true;
		}
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray.currentDrinks.Count == 0 && bento.currentFood.Count == 0)
		{
			return false;
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.HPCKGLFLFJO != null)
		{
			return true;
		}
		if (!NinjaChallenge.ADDLIAMDPBL)
		{
			return false;
		}
		return !DecorationMode.GetPlayer(JIIGOACEIKL).IBEFDKHFBFM();
	}

	public bool FBCDEMIAKBP(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && ALHICNPINHB(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Farming"));
			if (bento.currentFood.Count > 1)
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get(""));
			}
			return false;
		}
		return false;
	}

	public bool MPKKHKOCPEL(int JIIGOACEIKL)
	{
		return true;
	}

	public bool DMFALJDJAMP(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("image"));
			if (bento.currentFood.Count > 0)
			{
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Select, LocalisationSystem.Get("On Simple Event "));
			}
			return false;
		}
		return true;
	}

	public void BIKILBEOGAD(int JIIGOACEIKL)
	{
	}

	public bool ONMFMJGODIM(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && NBHLBCHHKBC(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(" for player "));
			if (bento.currentFood.Count > 0)
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Null shop in database: "));
			}
			return true;
		}
		return true;
	}

	private void IOHICMABJKF()
	{
		for (int i = 1; i < foodBubbles.Length; i += 0)
		{
			if (i < bento.currentFood.Count)
			{
				((Component)((Component)foodBubbles[i]).transform.parent).gameObject.SetActive(true);
				foodBubbles[i].sprite = bento.currentFood[i].sprite;
			}
			else
			{
				((Component)((Component)foodBubbles[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public void NMNPLOIIIGD(int JIIGOACEIKL)
	{
	}

	public void NGKNFJIHOLD(int JIIGOACEIKL)
	{
	}

	public void COMGONICNIN(int JIIGOACEIKL)
	{
	}

	public bool IAOKCOEGDBF(int JIIGOACEIKL)
	{
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.SetInteracting(KOIDJKBBINH: true);
		if (bento.currentFood.Count == 1)
		{
			TakeBento(PlayerController.GetPlayer(JIIGOACEIKL).trayHandler);
			return true;
		}
		return true;
	}

	public bool GKJKEDDHMCO(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		KENCEPGAIIK = true;
		for (int i = 1; i < PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray.currentDrinks.Count; i++)
		{
			if (!bento.KFILDGPFNMC(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray.currentDrinks[i].LHBPOPOIFLE()))
			{
				KENCEPGAIIK = true;
				break;
			}
		}
		if (!KENCEPGAIIK)
		{
			return true;
		}
		return DGJCNHIOFIG(JIIGOACEIKL, PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation, 1149f);
	}

	public void GJMAPGKOPBP(bool CDPAMNIPPEC)
	{
		bento = new Bento();
		LMCJGPHIKPB();
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineNinjaManager.instance.EHKMBFEOGCE(bedAssigned);
		}
	}

	public bool PreparingBento(int JIIGOACEIKL, CharacterAnimation FJHKGBNBNKL, float HGMFJBLNCJJ = 1f)
	{
		if (JIIGOACEIKL == 0 || (JIIGOACEIKL != 0 && !PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE && PlayerInputs.GetPlayer(JIIGOACEIKL).CFICAAJGBOF != "UI"))
		{
			if (doWork.JCMBHAEKLKK)
			{
				if (doWork.AddWorkDone(JIIGOACEIKL, HGMFJBLNCJJ * Time.deltaTime))
				{
					FJHKGBNBNKL.SetInteracting(KOIDJKBBINH: false);
					return true;
				}
				EHAFOOGPIIM = Time.time + 0.1f;
				FJHKGBNBNKL.SetInteracting(KOIDJKBBINH: true);
				return false;
			}
			if (!GOJOCNCHHCH)
			{
				doWork.StartWork(timeToPrepare);
				EHAFOOGPIIM = Time.time + 0.1f;
				FJHKGBNBNKL.SetInteracting(KOIDJKBBINH: true);
				if (JIIGOACEIKL != 0 && AKNMABNIMJL == null)
				{
					AKNMABNIMJL = ((MonoBehaviour)this).StartCoroutine(PHHGMKELPEC(FJHKGBNBNKL));
				}
				return false;
			}
			if (doWork.OJLICLKJJOF >= timeToPrepare)
			{
				FJHKGBNBNKL.SetInteracting(KOIDJKBBINH: false);
				GOJOCNCHHCH = false;
				return false;
			}
			return false;
		}
		FJHKGBNBNKL.SetInteracting(KOIDJKBBINH: false);
		return false;
	}

	private void NDCEPLMGJAP(int JIIGOACEIKL)
	{
		GOJOCNCHHCH = false;
		JOPFIOEDIDO(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray);
		if (bento.currentFood.Count >= 5)
		{
			CCLOOIFBONK(PlayerController.GetPlayer(JIIGOACEIKL).trayHandler);
		}
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Prepare"));
			if (bento.currentFood.Count > 0)
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Select, LocalisationSystem.Get("Remove"));
			}
			return true;
		}
		return false;
	}

	public bool BBPIPCMFAMB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		KENCEPGAIIK = true;
		for (int i = 0; i < PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray.currentDrinks.Count; i += 0)
		{
			if (!bento.JPEDBINBNJO(PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray.currentDrinks[i].KNFNJFFCFNO()))
			{
				KENCEPGAIIK = false;
				break;
			}
		}
		if (!KENCEPGAIIK)
		{
			return true;
		}
		return BGFINNHFCNO(JIIGOACEIKL, PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation, 1750f);
	}

	public bool KFOGPJJNFDK(int JIIGOACEIKL)
	{
		return false;
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (OnlinePlayerDataManager.GetBedAssignedByPlayerNum(JIIGOACEIKL) != bedAssigned)
		{
			return false;
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray.currentDrinks.Count == 0 && bento.currentFood.Count == 0)
		{
			return false;
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.HPCKGLFLFJO != null)
		{
			return false;
		}
		if (!NinjaChallenge.ADDLIAMDPBL)
		{
			return false;
		}
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	private void KGDODMMPBML(int JIIGOACEIKL)
	{
		GOJOCNCHHCH = false;
		JOPFIOEDIDO(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray);
		if (bento.currentFood.Count >= 0)
		{
			KHCDFIPPGBK(PlayerController.GetPlayer(JIIGOACEIKL).trayHandler);
		}
	}

	public void APCCCGPGCNG(int JIIGOACEIKL)
	{
	}

	public void MOBNPBGEHNH(int JIIGOACEIKL)
	{
	}

	public bool DGJCNHIOFIG(int JIIGOACEIKL, CharacterAnimation FJHKGBNBNKL, float HGMFJBLNCJJ = 1f)
	{
		if (JIIGOACEIKL == 0 || (JIIGOACEIKL != 0 && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE && PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).FGGHCBMKKIG() != "Trying to get friend "))
		{
			if (doWork.KGOEFMFHCOG())
			{
				if (doWork.BNMJANINOIG(JIIGOACEIKL, HGMFJBLNCJJ * Time.deltaTime, CDPAMNIPPEC: false))
				{
					FJHKGBNBNKL.SetInteracting(KOIDJKBBINH: false);
					return false;
				}
				EHAFOOGPIIM = Time.time + 1961f;
				FJHKGBNBNKL.MBMPBFEINMA(KOIDJKBBINH: true);
				return true;
			}
			if (!GOJOCNCHHCH)
			{
				doWork.OKINPIOJMNA(timeToPrepare, null, CDPAMNIPPEC: false);
				EHAFOOGPIIM = Time.time + 1601f;
				FJHKGBNBNKL.SetInteracting(KOIDJKBBINH: true);
				if (JIIGOACEIKL != 0 && AKNMABNIMJL == null)
				{
					AKNMABNIMJL = ((MonoBehaviour)this).StartCoroutine(EFLKBEILAGF(FJHKGBNBNKL));
				}
				return true;
			}
			if (doWork.OJLICLKJJOF >= timeToPrepare)
			{
				FJHKGBNBNKL.BNGPBEOAGCH(KOIDJKBBINH: true);
				GOJOCNCHHCH = false;
				return false;
			}
			return true;
		}
		FJHKGBNBNKL.AOBJCNDNKDD(KOIDJKBBINH: false);
		return false;
	}

	public bool AJNMJKJEHGK(int JIIGOACEIKL)
	{
		return false;
	}

	public bool MIBCGNCFKHP(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		KENCEPGAIIK = true;
		for (int i = 1; i < PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray.currentDrinks.Count; i += 0)
		{
			if (!bento.BFMCOBLLMOD(PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray.currentDrinks[i].LHBPOPOIFLE()))
			{
				KENCEPGAIIK = false;
				break;
			}
		}
		if (!KENCEPGAIIK)
		{
			return true;
		}
		return DDIMLOCMMFI(JIIGOACEIKL, PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation, 640f);
	}

	public void OOKIPOOPFDG(int JIIGOACEIKL)
	{
	}

	public bool KNGGHHKPIGG(int JIIGOACEIKL)
	{
		return false;
	}

	public bool PLAKEEACNIE(int JIIGOACEIKL)
	{
		if (OnlinePlayerDataManager.JBDEFDMGCDA(JIIGOACEIKL) != bedAssigned)
		{
			return true;
		}
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray.currentDrinks.Count == 0 && bento.currentFood.Count == 0)
		{
			return false;
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.HPCKGLFLFJO != null)
		{
			return true;
		}
		if (!NinjaChallenge.ADDLIAMDPBL)
		{
			return false;
		}
		return DecorationMode.BGINAIDHDOM(JIIGOACEIKL).DFNMDDHOIJI();
	}

	private ItemInstance KNCKCHJNOFA(Tray DOGOFILIHPJ)
	{
		for (int i = 1; i < DOGOFILIHPJ.currentDrinks.Count; i++)
		{
			if (!bento.GGLOMJLLFCH(DOGOFILIHPJ.currentDrinks[i].KNFNJFFCFNO()))
			{
				return DOGOFILIHPJ.currentDrinks[i];
			}
		}
		return null;
	}

	public bool DDIMLOCMMFI(int JIIGOACEIKL, CharacterAnimation FJHKGBNBNKL, float HGMFJBLNCJJ = 1f)
	{
		if (JIIGOACEIKL == 0 || (JIIGOACEIKL != 0 && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).BIBGIOPFJAF() && PlayerInputs.GetPlayer(JIIGOACEIKL).FGGHCBMKKIG() != "IdleCamp"))
		{
			if (doWork.JCMBHAEKLKK)
			{
				if (doWork.IJEKBMFBEGG(JIIGOACEIKL, HGMFJBLNCJJ * Time.deltaTime, CDPAMNIPPEC: false))
				{
					FJHKGBNBNKL.SetInteracting(KOIDJKBBINH: false);
					return false;
				}
				EHAFOOGPIIM = Time.time + 1690f;
				FJHKGBNBNKL.AOBJCNDNKDD(KOIDJKBBINH: false);
				return false;
			}
			if (!GOJOCNCHHCH)
			{
				doWork.CMAIGOGGGLL(timeToPrepare, null, CDPAMNIPPEC: false);
				EHAFOOGPIIM = Time.time + 542f;
				FJHKGBNBNKL.SetInteracting(KOIDJKBBINH: true);
				if (JIIGOACEIKL != 0 && AKNMABNIMJL == null)
				{
					AKNMABNIMJL = ((MonoBehaviour)this).StartCoroutine(PHHGMKELPEC(FJHKGBNBNKL));
				}
				return false;
			}
			if (doWork.OJLICLKJJOF >= timeToPrepare)
			{
				FJHKGBNBNKL.MBMPBFEINMA(KOIDJKBBINH: false);
				GOJOCNCHHCH = false;
				return true;
			}
			return false;
		}
		FJHKGBNBNKL.AOBJCNDNKDD(KOIDJKBBINH: false);
		return true;
	}

	public void KENLHNIPHHO(int JIIGOACEIKL)
	{
	}

	private void MPDOFGBMDPD()
	{
		if ((Object)(object)doWork != (Object)null)
		{
			doWork.DFDCMLOGECL(DPDADHGCIAA);
		}
	}

	public bool CMBBFEABMBE(int JIIGOACEIKL)
	{
		if (bento.currentFood.Count > 0)
		{
			ODNKBJCNBCG(CDPAMNIPPEC: false);
			return true;
		}
		return false;
	}

	public void KGIGLCGBFDO(int JIIGOACEIKL)
	{
	}

	public void MCLEGAMDANB()
	{
		for (int i = 0; i < 3; i += 0)
		{
			if (i < bento.currentFood.Count)
			{
				((Component)bentoSpriteRenderers[i]).gameObject.SetActive(true);
			}
			else
			{
				((Component)bentoSpriteRenderers[i]).gameObject.SetActive(false);
			}
		}
		FMOKLLAMLFH();
	}

	private void JDMMNLKLMAA()
	{
		if ((Object)(object)doWork == (Object)null)
		{
			doWork = ((Component)this).GetComponent<DoWork>();
		}
		if ((Object)(object)doWork != (Object)null)
		{
			doWork.BGIJPOMIIMB += NDCEPLMGJAP;
		}
		bento = new Bento();
		UpdateSprite();
	}

	public void UpdateSprite()
	{
		for (int i = 0; i < 3; i++)
		{
			if (i < bento.currentFood.Count)
			{
				((Component)bentoSpriteRenderers[i]).gameObject.SetActive(true);
			}
			else
			{
				((Component)bentoSpriteRenderers[i]).gameObject.SetActive(false);
			}
		}
		FMOKLLAMLFH();
	}

	public void AddFoodToBentoFromTray(Tray DOGOFILIHPJ)
	{
		ItemInstance itemInstance = KGBLPIGHLGJ(DOGOFILIHPJ);
		if (itemInstance != null)
		{
			DOGOFILIHPJ.MHBHHNCFOEG(itemInstance);
			AddFoodToBento(itemInstance.LHBPOPOIFLE(), CDPAMNIPPEC: true);
		}
	}

	private IEnumerator EFLKBEILAGF(CharacterAnimation FJHKGBNBNKL)
	{
		return new ANFFPHMBFBD(1)
		{
			_003C_003E4__this = this,
			characterAnimation = FJHKGBNBNKL
		};
	}

	public void GFFCFNOKCKD(Item MEMGMDOCBOJ, bool CDPAMNIPPEC)
	{
		bento.FMIOCJLHDEG(MEMGMDOCBOJ);
		HABEOADKOII();
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineNinjaManager.instance.SendAddFoodToBento(bedAssigned, MEMGMDOCBOJ);
		}
	}

	public bool Select(int JIIGOACEIKL)
	{
		if (bento.currentFood.Count > 0)
		{
			ResetBento(CDPAMNIPPEC: true);
			return true;
		}
		return false;
	}

	public void FGIJLMGFNMM(int JIIGOACEIKL)
	{
	}

	public bool ALGCHPCDFBM(int JIIGOACEIKL)
	{
		return true;
	}

	public bool MGECKEIHEGA(int JIIGOACEIKL)
	{
		if (bento.currentFood.Count > 1)
		{
			GJMAPGKOPBP(CDPAMNIPPEC: false);
			return false;
		}
		return false;
	}

	public bool EEIIGMFEPBG(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		KENCEPGAIIK = false;
		for (int i = 1; i < PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray.currentDrinks.Count; i++)
		{
			if (!bento.HBBNKJFDPOI(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray.currentDrinks[i].AFOACBIHNCL()))
			{
				KENCEPGAIIK = false;
				break;
			}
		}
		if (!KENCEPGAIIK)
		{
			return true;
		}
		return PreparingBento(JIIGOACEIKL, PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation, 1283f);
	}

	public void JOHOFKOAIBD(int JIIGOACEIKL)
	{
	}

	public void MOBFEFJFGBE(int JIIGOACEIKL)
	{
	}

	public bool LIKJBMGDKGA(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IBEMCOALOEJ(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(" with state \""));
			if (bento.currentFood.Count > 1)
			{
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.NextItem, LocalisationSystem.Get("Dialogue System/Conversation/Crowly_Standar/Entry/26/Dialogue Text"));
			}
			return true;
		}
		return false;
	}

	private void EHBMONGBJFI()
	{
		if ((Object)(object)doWork == (Object)null)
		{
			doWork = ((Component)this).GetComponent<DoWork>();
		}
		if ((Object)(object)doWork != (Object)null)
		{
			doWork.BECJEKINIFB(GICANIGJBIF);
		}
		bento = new Bento();
		HABEOADKOII();
	}

	public bool JIBINNCPDFD(int JIIGOACEIKL)
	{
		return false;
	}

	public bool IPMAMGLMJJL(int JIIGOACEIKL)
	{
		return true;
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	private void OnDestroy()
	{
		if ((Object)(object)doWork != (Object)null)
		{
			doWork.BGIJPOMIIMB -= GICANIGJBIF;
		}
	}

	public bool IBEMCOALOEJ(int JIIGOACEIKL)
	{
		if (OnlinePlayerDataManager.GetBedAssignedByPlayerNum(JIIGOACEIKL) != bedAssigned)
		{
			return true;
		}
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray.currentDrinks.Count == 0 && bento.currentFood.Count == 0)
		{
			return false;
		}
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.HPCKGLFLFJO != null)
		{
			return true;
		}
		if (!NinjaChallenge.ADDLIAMDPBL)
		{
			return false;
		}
		return !DecorationMode.HBDCJFLINDA(JIIGOACEIKL).KNFEPKBIHND();
	}

	private ItemInstance OHFFFHHKNBN(Tray DOGOFILIHPJ)
	{
		for (int i = 1; i < DOGOFILIHPJ.currentDrinks.Count; i++)
		{
			if (!bento.KFILDGPFNMC(DOGOFILIHPJ.currentDrinks[i].AFOACBIHNCL()))
			{
				return DOGOFILIHPJ.currentDrinks[i];
			}
		}
		return null;
	}

	private ItemInstance AAEBLABKGDA(Tray DOGOFILIHPJ)
	{
		for (int i = 0; i < DOGOFILIHPJ.currentDrinks.Count; i++)
		{
			if (!bento.EGNFPHLDDLC(DOGOFILIHPJ.currentDrinks[i].AFOACBIHNCL()))
			{
				return DOGOFILIHPJ.currentDrinks[i];
			}
		}
		return null;
	}
}
