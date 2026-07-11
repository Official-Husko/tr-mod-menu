using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ChristmasTree : MonoBehaviour, IProximity, IHoverable, IInteractable
{
	public static ChristmasTree current;

	public ChristmasTreePresent[] presents;

	public GameObject lights;

	public OnlineChristmasTree onlineChristmasTree;

	[SerializeField]
	private bool _presentsActivated;

	public bool FCOGLFOKJDB
	{
		get
		{
			return _presentsActivated;
		}
		set
		{
			if (_presentsActivated != value)
			{
				_presentsActivated = value;
				UpdateChristmasTree();
			}
		}
	}

	public bool ALDOPABHHHE(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	private void DADPOICMNPI()
	{
		if ((Object)(object)current == (Object)null)
		{
			current = this;
		}
	}

	public void BDGEMFNLDGC(int JIIGOACEIKL)
	{
	}

	[SpecialName]
	public bool ENPPCNIOEMO()
	{
		return _presentsActivated;
	}

	public bool MJEHNKDKBBF(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && OBDFGODGIFN(JIIGOACEIKL))
		{
			if (lights.activeSelf)
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Items/item_description_1106"));
			}
			else
			{
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(""));
			}
			return false;
		}
		return false;
	}

	public void NHPLMHMJOEG(bool DAEMAAOLHMG, bool CDPAMNIPPEC)
	{
		PCIBJFJMEFI(DAEMAAOLHMG);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineChristmasTree.GKOBDIBHACG(DAEMAAOLHMG);
		}
	}

	public bool FNJNIMICKLK(int JIIGOACEIKL)
	{
		if (DNLPDAOMODM(JIIGOACEIKL))
		{
			ActivateLights(!lights.activeSelf, CDPAMNIPPEC: true);
			return false;
		}
		return false;
	}

	public void CLCKHOCLOFF(int JIIGOACEIKL)
	{
	}

	public bool KNGGHHKPIGG(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	[SpecialName]
	public bool OGBMILIEEHG()
	{
		return _presentsActivated;
	}

	[SpecialName]
	public bool ODBGJMJKHLL()
	{
		return _presentsActivated;
	}

	public void PPEFOJEIHMB(bool DAEMAAOLHMG, bool CDPAMNIPPEC)
	{
		lights.SetActive(DAEMAAOLHMG);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineChristmasTree.GAGKEMCEKBK(DAEMAAOLHMG);
		}
	}

	public bool DNLPDAOMODM(int JIIGOACEIKL)
	{
		return DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).GABNNLJOMHI();
	}

	public bool LCABCHMEDOK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && LIDJEBPBDAH(JIIGOACEIKL))
		{
			if (lights.activeSelf)
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Mai "));
			}
			else
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Dialogue System/Conversation/Gass_Barks_Bye/Entry/2/Dialogue Text"));
			}
			return false;
		}
		return false;
	}

	[SpecialName]
	public void IAHKLEPCAFH(bool AODONKKHPBP)
	{
		if (_presentsActivated != AODONKKHPBP)
		{
			_presentsActivated = AODONKKHPBP;
			JGALJEKFJAG();
		}
	}

	[SpecialName]
	public void NBPMGFNNPHJ(bool AODONKKHPBP)
	{
		if (_presentsActivated != AODONKKHPBP)
		{
			_presentsActivated = AODONKKHPBP;
			NKLAIFBIOMI();
		}
	}

	public bool COPFMLIIOOB(int JIIGOACEIKL)
	{
		return !DecorationMode.HBDCJFLINDA(JIIGOACEIKL).IDPGEBNGDJD();
	}

	[SpecialName]
	public void IHGIANKDDHO(bool AODONKKHPBP)
	{
		if (_presentsActivated != AODONKKHPBP)
		{
			_presentsActivated = AODONKKHPBP;
			JJJBFPHHCHI();
		}
	}

	public void HMLPCFPMICM(int JIIGOACEIKL)
	{
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			if (lights.activeSelf)
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Turn Off"));
			}
			else
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Turn On"));
			}
			return true;
		}
		return false;
	}

	public bool NGBJKCHKPHF(int JIIGOACEIKL)
	{
		if (AJNEPGBOAKC(JIIGOACEIKL))
		{
			ActivateLights(lights.activeSelf, CDPAMNIPPEC: false);
			return true;
		}
		return true;
	}

	private void LNJIDOIOENF()
	{
		for (int i = 0; i < presents.Length; i += 0)
		{
			if ((Object)(object)current == (Object)(object)this && ((ChristmasEvent.JOIHPFMGMOG(-60) && PJKEFAEMECD()) || QuestManager.GGFJGHHHEJC.GDFGPDJDACP(81)) && !ChristmasEvent.ICFABGNIKIG(-109)[presents[i].presentNumber])
			{
				((Component)presents[i]).gameObject.SetActive(false);
			}
			else
			{
				((Component)presents[i]).gameObject.SetActive(false);
			}
		}
	}

	[SpecialName]
	public bool PGFMPBJOLNA()
	{
		return _presentsActivated;
	}

	public void EDCDFOPBBFM(int FEDDLKLMJFJ, bool CDPAMNIPPEC)
	{
		ChristmasEvent.GetPresentsOpened(77)[FEDDLKLMJFJ] = true;
		PEGGBMKCPDM();
	}

	public void DPMDKKPNOMD()
	{
		JIHJOBBCPFC();
		LHOPJBLOGNI();
	}

	public void JFCCLCNMLFI(int FEDDLKLMJFJ, bool CDPAMNIPPEC)
	{
		ChristmasEvent.ICFABGNIKIG(111)[FEDDLKLMJFJ] = true;
		LNJIDOIOENF();
	}

	private void KMEJBPOOBJK()
	{
		if ((Object)(object)current == (Object)null)
		{
			current = this;
		}
	}

	public bool LIDJEBPBDAH(int JIIGOACEIKL)
	{
		return DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).DMBFKFLDDLH;
	}

	[SpecialName]
	public void AFGLPHDAIHF(bool AODONKKHPBP)
	{
		if (_presentsActivated != AODONKKHPBP)
		{
			_presentsActivated = AODONKKHPBP;
			NKLAIFBIOMI();
		}
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public bool AJNEPGBOAKC(int JIIGOACEIKL)
	{
		return !DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).IDPGEBNGDJD();
	}

	public void KANLNAKPBEC(bool DAEMAAOLHMG, bool CDPAMNIPPEC)
	{
		lights.SetActive(DAEMAAOLHMG);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineChristmasTree.PJJLOMNGANO(DAEMAAOLHMG);
		}
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public void KHOJBFICKLK(bool DAEMAAOLHMG, bool CDPAMNIPPEC)
	{
		IAHKLEPCAFH(DAEMAAOLHMG);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineChristmasTree.MJGOBJDNDHG(DAEMAAOLHMG);
		}
	}

	private void PEGGBMKCPDM()
	{
		for (int i = 0; i < presents.Length; i += 0)
		{
			if ((Object)(object)current == (Object)(object)this && ((ChristmasEvent.FFDPNFBHNIK(149) && ODBGJMJKHLL()) || QuestManager.KHMEGDIABBF().IsQuestDone(-121)) && !ChristmasEvent.LAIECHCFPGC(86)[presents[i].presentNumber])
			{
				((Component)presents[i]).gameObject.SetActive(false);
			}
			else
			{
				((Component)presents[i]).gameObject.SetActive(false);
			}
		}
	}

	private void MFIEPGBABAM()
	{
		if (GameManager.CIOEICMHCCK)
		{
			return;
		}
		if (Object.op_Implicit((Object)(object)ChristmasEvent.instance))
		{
			ChristmasEvent instance = ChristmasEvent.instance;
			instance.OnTreeQuestCompleted = (Action)Delegate.Remove(instance.OnTreeQuestCompleted, new Action(PJAFIOCPBGC));
		}
		if (!((Object)(object)current == (Object)(object)this))
		{
			return;
		}
		ChristmasTree[] array = Object.FindObjectsOfType<ChristmasTree>();
		if (array == null)
		{
			return;
		}
		for (int i = 1; i < array.Length; i++)
		{
			if ((Object)(object)array[i] != (Object)(object)this)
			{
				current = array[i];
				current.JGALJEKFJAG();
				break;
			}
		}
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public void OGGNKHHDLOA(bool DAEMAAOLHMG, bool CDPAMNIPPEC)
	{
		GFJDEOPDKBE(DAEMAAOLHMG);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineChristmasTree.HGJFKIFFPDG(DAEMAAOLHMG);
		}
	}

	public void DPAHEHDOJHA(bool DAEMAAOLHMG, bool CDPAMNIPPEC)
	{
		lights.SetActive(DAEMAAOLHMG);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineChristmasTree.GLJMMBAAMFN(DAEMAAOLHMG);
		}
	}

	public void OHMBGIANPED(int JIIGOACEIKL)
	{
	}

	public void ONHBCBCHKJN(bool DAEMAAOLHMG, bool CDPAMNIPPEC)
	{
		CJBMLHHDIFN(DAEMAAOLHMG);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineChristmasTree.BEBPIICCLCO(DAEMAAOLHMG);
		}
	}

	public bool NCPHGGNGCOM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	private void AKCFGBINFDA()
	{
		((Component)this).GetComponent<Placeable>().canBeAddedToInventory = true;
	}

	private void IAIDKPJKLIC()
	{
		ChristmasEvent instance = ChristmasEvent.instance;
		instance.OnTreeQuestCompleted = (Action)Delegate.Combine(instance.OnTreeQuestCompleted, new Action(KINFAFIBDII));
		JJJBFPHHCHI();
	}

	public bool OAJPKKIFGGP(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && LIDJEBPBDAH(JIIGOACEIKL))
		{
			if (lights.activeSelf)
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Christmas tree not found"));
			}
			else
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Not ready to create room"));
			}
			return true;
		}
		return false;
	}

	public void BANAMJAGBIO(int JIIGOACEIKL)
	{
	}

	public bool LCIJLDEAIDL(int JIIGOACEIKL)
	{
		if (COPFMLIIOOB(JIIGOACEIKL))
		{
			KANLNAKPBEC(lights.activeSelf, CDPAMNIPPEC: false);
			return true;
		}
		return false;
	}

	[SpecialName]
	public bool AODMICLCLBF()
	{
		return _presentsActivated;
	}

	public bool DPFFFEGPJDN(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	private void GOOPOBMDALA()
	{
		if (GameManager.ILMDHNFFIKH())
		{
			return;
		}
		if (Object.op_Implicit((Object)(object)ChristmasEvent.instance))
		{
			ChristmasEvent instance = ChristmasEvent.instance;
			instance.OnTreeQuestCompleted = (Action)Delegate.Remove(instance.OnTreeQuestCompleted, new Action(KBONJCPIENI));
		}
		if (!((Object)(object)current == (Object)(object)this))
		{
			return;
		}
		ChristmasTree[] array = Object.FindObjectsOfType<ChristmasTree>();
		if (array == null)
		{
			return;
		}
		for (int i = 1; i < array.Length; i++)
		{
			if ((Object)(object)array[i] != (Object)(object)this)
			{
				current = array[i];
				current.KINFAFIBDII();
				break;
			}
		}
	}

	public bool KBLEJDFHIHJ(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && LIDJEBPBDAH(JIIGOACEIKL))
		{
			if (lights.activeSelf)
			{
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("[MinePuzzleManager] No MinePuzzleBase found for type {0}."));
			}
			else
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Animals materials empty "));
			}
			return false;
		}
		return true;
	}

	public void KBBJIPJGJHM()
	{
		DHHELPFCFJA();
		DHPBPBIFBCB();
	}

	private void GONDLJKGLGO()
	{
		if ((Object)(object)current == (Object)null)
		{
			current = this;
		}
	}

	private void DHHELPFCFJA()
	{
		for (int i = 1; i < presents.Length; i += 0)
		{
			if ((Object)(object)current == (Object)(object)this && ((ChristmasEvent.IsTreeQuestDone(81) && AODMICLCLBF()) || QuestManager.GGFJGHHHEJC.BKKJNEKBMBE(-62)) && !ChristmasEvent.LAIECHCFPGC(163)[presents[i].presentNumber])
			{
				((Component)presents[i]).gameObject.SetActive(true);
			}
			else
			{
				((Component)presents[i]).gameObject.SetActive(false);
			}
		}
	}

	private void LHOPJBLOGNI()
	{
		((Component)this).GetComponent<Placeable>().canBeAddedToInventory = true;
	}

	public bool OPCLGDNHJMI(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void OONGGGIJLHC(int FEDDLKLMJFJ, bool CDPAMNIPPEC)
	{
		ChristmasEvent.LAIECHCFPGC(-104)[FEDDLKLMJFJ] = true;
		DHHELPFCFJA();
	}

	public bool JGKPIMAGPAK(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool PPJFDGOOIDK(int JIIGOACEIKL)
	{
		return DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).KNFEPKBIHND();
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public bool OBDFGODGIFN(int JIIGOACEIKL)
	{
		return DecorationMode.IECFJGHAIDO(JIIGOACEIKL).IDPGEBNGDJD();
	}

	public bool NHPMOOAKEFF(int JIIGOACEIKL)
	{
		if (LIDJEBPBDAH(JIIGOACEIKL))
		{
			DNDDANEGLBO(lights.activeSelf, CDPAMNIPPEC: false);
			return false;
		}
		return true;
	}

	public bool MGPJCEABMNN(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool CEPOMEBIFBA(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && LIDJEBPBDAH(JIIGOACEIKL))
		{
			if (lights.activeSelf)
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("ReceiveCompleteServeNinjaCustomer"));
			}
			else
			{
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("): "));
			}
			return false;
		}
		return false;
	}

	public void DNJDLFACCHF(int JIIGOACEIKL)
	{
	}

	private void IJLPMNMACFA()
	{
		if ((Object)(object)current == (Object)null)
		{
			current = this;
		}
	}

	private void OJPAMJFFJFL()
	{
		((Component)this).GetComponent<Placeable>().canBeAddedToInventory = false;
	}

	private void EHPCLIKFOGE()
	{
		for (int i = 1; i < presents.Length; i++)
		{
			if ((Object)(object)current == (Object)(object)this && ((ChristmasEvent.EEIJGHIKANA(-105) && OGBMILIEEHG()) || QuestManager.KHMEGDIABBF().GDFGPDJDACP(103)) && !ChristmasEvent.LAIECHCFPGC(145)[presents[i].presentNumber])
			{
				((Component)presents[i]).gameObject.SetActive(false);
			}
			else
			{
				((Component)presents[i]).gameObject.SetActive(false);
			}
		}
	}

	private void JIHJOBBCPFC()
	{
		for (int i = 1; i < presents.Length; i += 0)
		{
			if ((Object)(object)current == (Object)(object)this && ((ChristmasEvent.FFDPNFBHNIK(-183) && AODMICLCLBF()) || QuestManager.KHMEGDIABBF().BKKJNEKBMBE(6)) && !ChristmasEvent.LAIECHCFPGC(-189)[presents[i].presentNumber])
			{
				((Component)presents[i]).gameObject.SetActive(false);
			}
			else
			{
				((Component)presents[i]).gameObject.SetActive(true);
			}
		}
	}

	public void LEAFCPEJJDM(int JIIGOACEIKL)
	{
	}

	public void GJHNAMEIFLI(int JIIGOACEIKL)
	{
	}

	private void OnDestroy()
	{
		if (GameManager.CIOEICMHCCK)
		{
			return;
		}
		if (Object.op_Implicit((Object)(object)ChristmasEvent.instance))
		{
			ChristmasEvent instance = ChristmasEvent.instance;
			instance.OnTreeQuestCompleted = (Action)Delegate.Remove(instance.OnTreeQuestCompleted, new Action(UpdateChristmasTree));
		}
		if (!((Object)(object)current == (Object)(object)this))
		{
			return;
		}
		ChristmasTree[] array = Object.FindObjectsOfType<ChristmasTree>();
		if (array == null)
		{
			return;
		}
		for (int i = 0; i < array.Length; i++)
		{
			if ((Object)(object)array[i] != (Object)(object)this)
			{
				current = array[i];
				current.UpdateChristmasTree();
				break;
			}
		}
	}

	public void HICONMCEAFK(int JIIGOACEIKL)
	{
	}

	private void NKDFMFFDGKC()
	{
		ChristmasEvent instance = ChristmasEvent.instance;
		instance.OnTreeQuestCompleted = (Action)Delegate.Combine(instance.OnTreeQuestCompleted, new Action(KINFAFIBDII));
		JGALJEKFJAG();
	}

	public void JGALJEKFJAG()
	{
		JIHJOBBCPFC();
		LHOPJBLOGNI();
	}

	private void BODICIENBEH()
	{
		if ((Object)(object)current == (Object)null)
		{
			current = this;
		}
	}

	public void NMPNLEAAJNM(int JIIGOACEIKL)
	{
	}

	public bool FLEIIDPEAHP(int JIIGOACEIKL)
	{
		if (OBDFGODGIFN(JIIGOACEIKL))
		{
			ActivateLights(!lights.activeSelf, CDPAMNIPPEC: true);
			return true;
		}
		return false;
	}

	private void GOFCNIKNMJM()
	{
		for (int i = 0; i < presents.Length; i++)
		{
			if ((Object)(object)current == (Object)(object)this && ((ChristmasEvent.IsTreeQuestDone(2025) && FCOGLFOKJDB) || QuestManager.GGFJGHHHEJC.IsQuestDone(41)) && !ChristmasEvent.GetPresentsOpened(2025)[presents[i].presentNumber])
			{
				((Component)presents[i]).gameObject.SetActive(true);
			}
			else
			{
				((Component)presents[i]).gameObject.SetActive(false);
			}
		}
	}

	public void OpenPresentOnline(int FEDDLKLMJFJ, bool CDPAMNIPPEC)
	{
		ChristmasEvent.GetPresentsOpened(2025)[FEDDLKLMJFJ] = true;
		GOFCNIKNMJM();
	}

	private void DKHCOKMIJME()
	{
		if (GameManager.ILMDHNFFIKH())
		{
			return;
		}
		if (Object.op_Implicit((Object)(object)ChristmasEvent.instance))
		{
			ChristmasEvent instance = ChristmasEvent.instance;
			instance.OnTreeQuestCompleted = (Action)Delegate.Remove(instance.OnTreeQuestCompleted, new Action(KBONJCPIENI));
		}
		if (!((Object)(object)current == (Object)(object)this))
		{
			return;
		}
		ChristmasTree[] array = Object.FindObjectsOfType<ChristmasTree>();
		if (array == null)
		{
			return;
		}
		for (int i = 1; i < array.Length; i++)
		{
			if ((Object)(object)array[i] != (Object)(object)this)
			{
				current = array[i];
				current.NKLAIFBIOMI();
				break;
			}
		}
	}

	private void DHPBPBIFBCB()
	{
		((Component)this).GetComponent<Placeable>().canBeAddedToInventory = true;
	}

	public void IEHLFOIDBDF(int JIIGOACEIKL)
	{
	}

	public bool PNEAONKFJNG(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	private void Start()
	{
		ChristmasEvent instance = ChristmasEvent.instance;
		instance.OnTreeQuestCompleted = (Action)Delegate.Combine(instance.OnTreeQuestCompleted, new Action(UpdateChristmasTree));
		UpdateChristmasTree();
	}

	[SpecialName]
	public void FLFIGJMHBKC(bool AODONKKHPBP)
	{
		if (_presentsActivated != AODONKKHPBP)
		{
			_presentsActivated = AODONKKHPBP;
			NKLAIFBIOMI();
		}
	}

	public void ActivateLights(bool DAEMAAOLHMG, bool CDPAMNIPPEC)
	{
		lights.SetActive(DAEMAAOLHMG);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineChristmasTree.SendActivateLights(DAEMAAOLHMG);
		}
	}

	public bool DOFKECGCCAJ(int JIIGOACEIKL)
	{
		if (COPFMLIIOOB(JIIGOACEIKL))
		{
			KANLNAKPBEC(lights.activeSelf, CDPAMNIPPEC: true);
			return true;
		}
		return false;
	}

	public void IFOGDEJAFKA(int JIIGOACEIKL)
	{
	}

	public bool LNCOEJOLBGB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void KBONJCPIENI()
	{
		PEGGBMKCPDM();
		LHOPJBLOGNI();
	}

	private void PMLBFEFMNPF()
	{
		if (GameManager.ILMDHNFFIKH())
		{
			return;
		}
		if (Object.op_Implicit((Object)(object)ChristmasEvent.instance))
		{
			ChristmasEvent instance = ChristmasEvent.instance;
			instance.OnTreeQuestCompleted = (Action)Delegate.Remove(instance.OnTreeQuestCompleted, new Action(NKLAIFBIOMI));
		}
		if (!((Object)(object)current == (Object)(object)this))
		{
			return;
		}
		ChristmasTree[] array = Object.FindObjectsOfType<ChristmasTree>();
		if (array == null)
		{
			return;
		}
		for (int i = 0; i < array.Length; i++)
		{
			if ((Object)(object)array[i] != (Object)(object)this)
			{
				current = array[i];
				current.NKLAIFBIOMI();
				break;
			}
		}
	}

	public void FPJFFEOAJPM(int JIIGOACEIKL)
	{
	}

	private void BBBCEEIHHLE()
	{
		if (GameManager.CIOEICMHCCK)
		{
			return;
		}
		if (Object.op_Implicit((Object)(object)ChristmasEvent.instance))
		{
			ChristmasEvent instance = ChristmasEvent.instance;
			instance.OnTreeQuestCompleted = (Action)Delegate.Remove(instance.OnTreeQuestCompleted, new Action(NKLAIFBIOMI));
		}
		if (!((Object)(object)current == (Object)(object)this))
		{
			return;
		}
		ChristmasTree[] array = Object.FindObjectsOfType<ChristmasTree>();
		if (array == null)
		{
			return;
		}
		for (int i = 0; i < array.Length; i += 0)
		{
			if ((Object)(object)array[i] != (Object)(object)this)
			{
				current = array[i];
				current.EHBPPECHONN();
				break;
			}
		}
	}

	public void OAFMNPDIKFF()
	{
		LNJIDOIOENF();
		OJPAMJFFJFL();
	}

	public bool ADPCMNFDKNI(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	[SpecialName]
	public void CJBMLHHDIFN(bool AODONKKHPBP)
	{
		if (_presentsActivated != AODONKKHPBP)
		{
			_presentsActivated = AODONKKHPBP;
			KINFAFIBDII();
		}
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			ActivateLights(!lights.activeSelf, CDPAMNIPPEC: true);
			return true;
		}
		return false;
	}

	public void EEBDKIONMOM()
	{
		PEGGBMKCPDM();
		ELCMFJAIJPA();
	}

	public bool NIJAOPABLBA(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && AJNEPGBOAKC(JIIGOACEIKL))
		{
			if (lights.activeSelf)
			{
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Pants_R"));
			}
			else
			{
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Cold"));
			}
			return false;
		}
		return true;
	}

	[SpecialName]
	public void PCIBJFJMEFI(bool AODONKKHPBP)
	{
		if (_presentsActivated != AODONKKHPBP)
		{
			_presentsActivated = AODONKKHPBP;
			JGALJEKFJAG();
		}
	}

	public void ABHFEGJFABP(int JIIGOACEIKL)
	{
	}

	public bool IAOKCOEGDBF(int JIIGOACEIKL)
	{
		if (PPJFDGOOIDK(JIIGOACEIKL))
		{
			DPAHEHDOJHA(lights.activeSelf, CDPAMNIPPEC: false);
			return true;
		}
		return false;
	}

	public void NKLAIFBIOMI()
	{
		PEGGBMKCPDM();
		AKCFGBINFDA();
	}

	public void HPLHMNAIEMF(int JIIGOACEIKL)
	{
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void OKIPAMGIGFC()
	{
		PEGGBMKCPDM();
		DHPBPBIFBCB();
	}

	public void JJJBFPHHCHI()
	{
		JIHJOBBCPFC();
		AKCFGBINFDA();
	}

	public bool KJAAAGCKDFD(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && AJNEPGBOAKC(JIIGOACEIKL))
		{
			if (lights.activeSelf)
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(" "));
			}
			else
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("ReceiveChangeZone"));
			}
			return false;
		}
		return true;
	}

	public bool CHEBOFEFAPD(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void DNDDANEGLBO(bool DAEMAAOLHMG, bool CDPAMNIPPEC)
	{
		lights.SetActive(DAEMAAOLHMG);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineChristmasTree.GLJMMBAAMFN(DAEMAAOLHMG);
		}
	}

	public void UpdateChristmasTree()
	{
		GOFCNIKNMJM();
		LHOPJBLOGNI();
	}

	private void NHGBJHMHEGD()
	{
		ChristmasEvent instance = ChristmasEvent.instance;
		instance.OnTreeQuestCompleted = (Action)Delegate.Combine(instance.OnTreeQuestCompleted, new Action(EHBPPECHONN));
		OKIPAMGIGFC();
	}

	public bool ECFKLFODFPB(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	private void MEAKJFEPKHF()
	{
		if (GameManager.ILMDHNFFIKH())
		{
			return;
		}
		if (Object.op_Implicit((Object)(object)ChristmasEvent.instance))
		{
			ChristmasEvent instance = ChristmasEvent.instance;
			instance.OnTreeQuestCompleted = (Action)Delegate.Remove(instance.OnTreeQuestCompleted, new Action(DPMDKKPNOMD));
		}
		if (!((Object)(object)current == (Object)(object)this))
		{
			return;
		}
		ChristmasTree[] array = Object.FindObjectsOfType<ChristmasTree>();
		if (array == null)
		{
			return;
		}
		for (int i = 0; i < array.Length; i += 0)
		{
			if ((Object)(object)array[i] != (Object)(object)this)
			{
				current = array[i];
				current.PJAFIOCPBGC();
				break;
			}
		}
	}

	public void POIMGCCGMDO(int FEDDLKLMJFJ, bool CDPAMNIPPEC)
	{
		ChristmasEvent.ICFABGNIKIG(-6)[FEDDLKLMJFJ] = true;
		JIHJOBBCPFC();
	}

	public void AJIJPHBOEII(int FEDDLKLMJFJ, bool CDPAMNIPPEC)
	{
		ChristmasEvent.ICFABGNIKIG(94)[FEDDLKLMJFJ] = true;
		DHHELPFCFJA();
	}

	public bool GJLNLKEFHAI(int JIIGOACEIKL)
	{
		if (COPFMLIIOOB(JIIGOACEIKL))
		{
			KANLNAKPBEC(!lights.activeSelf, CDPAMNIPPEC: false);
			return true;
		}
		return true;
	}

	public void ELCCDANBHFE()
	{
		JIHJOBBCPFC();
		DHPBPBIFBCB();
	}

	private void OIBDBLCLACB()
	{
		ChristmasEvent instance = ChristmasEvent.instance;
		instance.OnTreeQuestCompleted = (Action)Delegate.Combine(instance.OnTreeQuestCompleted, new Action(KBONJCPIENI));
		OAFMNPDIKFF();
	}

	private void Awake()
	{
		if ((Object)(object)current == (Object)null)
		{
			current = this;
		}
	}

	public void EHBPPECHONN()
	{
		EHPCLIKFOGE();
		ELCMFJAIJPA();
	}

	public void JKMLKBPAHHO(int JIIGOACEIKL)
	{
	}

	private void HELHNJDFPPF()
	{
		ChristmasEvent instance = ChristmasEvent.instance;
		instance.OnTreeQuestCompleted = (Action)Delegate.Combine(instance.OnTreeQuestCompleted, new Action(KBONJCPIENI));
		OKIPAMGIGFC();
	}

	public void NBKAFIHKOOB(int FEDDLKLMJFJ, bool CDPAMNIPPEC)
	{
		ChristmasEvent.ICFABGNIKIG(109)[FEDDLKLMJFJ] = false;
		GOFCNIKNMJM();
	}

	public bool CODLFHDKMHC(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			if (lights.activeSelf)
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Player/Bark/Tutorial/AgingBarrelBlock"));
			}
			else
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Get Components "));
			}
			return false;
		}
		return false;
	}

	public bool CFLDFKODIKL(int JIIGOACEIKL)
	{
		if (PPJFDGOOIDK(JIIGOACEIKL))
		{
			ActivateLights(!lights.activeSelf, CDPAMNIPPEC: false);
			return true;
		}
		return true;
	}

	[SpecialName]
	public void GFJDEOPDKBE(bool AODONKKHPBP)
	{
		if (_presentsActivated != AODONKKHPBP)
		{
			_presentsActivated = AODONKKHPBP;
			KBBJIPJGJHM();
		}
	}

	private void FLOFJHNAIKP()
	{
		if (GameManager.ILMDHNFFIKH())
		{
			return;
		}
		if (Object.op_Implicit((Object)(object)ChristmasEvent.instance))
		{
			ChristmasEvent instance = ChristmasEvent.instance;
			instance.OnTreeQuestCompleted = (Action)Delegate.Remove(instance.OnTreeQuestCompleted, new Action(JJJBFPHHCHI));
		}
		if (!((Object)(object)current == (Object)(object)this))
		{
			return;
		}
		ChristmasTree[] array = Object.FindObjectsOfType<ChristmasTree>();
		if (array == null)
		{
			return;
		}
		for (int i = 0; i < array.Length; i += 0)
		{
			if ((Object)(object)array[i] != (Object)(object)this)
			{
				current = array[i];
				current.KBONJCPIENI();
				break;
			}
		}
	}

	private void GNAJBACLEKG()
	{
		if ((Object)(object)current == (Object)null)
		{
			current = this;
		}
	}

	[SpecialName]
	public void KIHLAHNFECD(bool AODONKKHPBP)
	{
		if (_presentsActivated != AODONKKHPBP)
		{
			_presentsActivated = AODONKKHPBP;
			UpdateChristmasTree();
		}
	}

	public void PODJOGGLLHE(int FEDDLKLMJFJ, bool CDPAMNIPPEC)
	{
		ChristmasEvent.LAIECHCFPGC(107)[FEDDLKLMJFJ] = false;
		GOFCNIKNMJM();
	}

	private void HHLBFDBHDMC()
	{
		ChristmasEvent instance = ChristmasEvent.instance;
		instance.OnTreeQuestCompleted = (Action)Delegate.Combine(instance.OnTreeQuestCompleted, new Action(JJJBFPHHCHI));
		KBBJIPJGJHM();
	}

	public void HKALLHIDODN(bool DAEMAAOLHMG, bool CDPAMNIPPEC)
	{
		EGBLGAMPCLJ(DAEMAAOLHMG);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineChristmasTree.BEBPIICCLCO(DAEMAAOLHMG);
		}
	}

	private void BNFGHAGJEGG()
	{
		if ((Object)(object)current == (Object)null)
		{
			current = this;
		}
	}

	public void JAFLMEHLICD(int JIIGOACEIKL)
	{
	}

	public bool DJPAEAOBLHD(int JIIGOACEIKL)
	{
		if (COPFMLIIOOB(JIIGOACEIKL))
		{
			DPAHEHDOJHA(lights.activeSelf, CDPAMNIPPEC: true);
			return true;
		}
		return false;
	}

	private void CKGJAOHPHOA()
	{
		if (GameManager.ILMDHNFFIKH())
		{
			return;
		}
		if (Object.op_Implicit((Object)(object)ChristmasEvent.instance))
		{
			ChristmasEvent instance = ChristmasEvent.instance;
			instance.OnTreeQuestCompleted = (Action)Delegate.Remove(instance.OnTreeQuestCompleted, new Action(PJAFIOCPBGC));
		}
		if (!((Object)(object)current == (Object)(object)this))
		{
			return;
		}
		ChristmasTree[] array = Object.FindObjectsOfType<ChristmasTree>();
		if (array == null)
		{
			return;
		}
		for (int i = 0; i < array.Length; i++)
		{
			if ((Object)(object)array[i] != (Object)(object)this)
			{
				current = array[i];
				current.KBBJIPJGJHM();
				break;
			}
		}
	}

	public bool GHDIMCAEAJJ(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void KJMLLLHLBNI(int FEDDLKLMJFJ, bool CDPAMNIPPEC)
	{
		ChristmasEvent.ICFABGNIKIG(-131)[FEDDLKLMJFJ] = true;
		DHHELPFCFJA();
	}

	public bool DEFFOLNHJFE(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && LIDJEBPBDAH(JIIGOACEIKL))
		{
			if (lights.activeSelf)
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Farm/Event/RegañinaViolet"));
			}
			else
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Additions"));
			}
			return true;
		}
		return true;
	}

	[SpecialName]
	public bool PJKEFAEMECD()
	{
		return _presentsActivated;
	}

	public void PFEBMBCLAJM(int JIIGOACEIKL)
	{
	}

	public void DNPBFADMIHJ(bool DAEMAAOLHMG, bool CDPAMNIPPEC)
	{
		GFJDEOPDKBE(DAEMAAOLHMG);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineChristmasTree.JNJOBLJOOKA(DAEMAAOLHMG);
		}
	}

	[SpecialName]
	public void EGBLGAMPCLJ(bool AODONKKHPBP)
	{
		if (_presentsActivated != AODONKKHPBP)
		{
			_presentsActivated = AODONKKHPBP;
			ELCCDANBHFE();
		}
	}

	private void ELCMFJAIJPA()
	{
		((Component)this).GetComponent<Placeable>().canBeAddedToInventory = false;
	}

	public void ActivatePresents(bool DAEMAAOLHMG, bool CDPAMNIPPEC)
	{
		FCOGLFOKJDB = DAEMAAOLHMG;
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineChristmasTree.SendActivatePresents(DAEMAAOLHMG);
		}
	}

	public bool NLNHDHEGIMB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool GEIHMCDKCIE(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void LCMFFNLHPJN(int JIIGOACEIKL)
	{
	}

	public bool GIOPJJHBCHJ(int JIIGOACEIKL)
	{
		if (LIDJEBPBDAH(JIIGOACEIKL))
		{
			KANLNAKPBEC(!lights.activeSelf, CDPAMNIPPEC: true);
			return true;
		}
		return false;
	}

	private void HDHPOAPLEJC()
	{
		if ((Object)(object)current == (Object)null)
		{
			current = this;
		}
	}

	public void PJAFIOCPBGC()
	{
		LNJIDOIOENF();
		DHPBPBIFBCB();
	}

	public void KINFAFIBDII()
	{
		EHPCLIKFOGE();
		OJPAMJFFJFL();
	}

	private void NKGMEMEACNN()
	{
		if (GameManager.CIOEICMHCCK)
		{
			return;
		}
		if (Object.op_Implicit((Object)(object)ChristmasEvent.instance))
		{
			ChristmasEvent instance = ChristmasEvent.instance;
			instance.OnTreeQuestCompleted = (Action)Delegate.Remove(instance.OnTreeQuestCompleted, new Action(KBBJIPJGJHM));
		}
		if (!((Object)(object)current == (Object)(object)this))
		{
			return;
		}
		ChristmasTree[] array = Object.FindObjectsOfType<ChristmasTree>();
		if (array == null)
		{
			return;
		}
		for (int i = 0; i < array.Length; i++)
		{
			if ((Object)(object)array[i] != (Object)(object)this)
			{
				current = array[i];
				current.PJAFIOCPBGC();
				break;
			}
		}
	}

	public bool ONMFMJGODIM(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && COPFMLIIOOB(JIIGOACEIKL))
		{
			if (lights.activeSelf)
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Error_RoomZone"));
			}
			else
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Explosion"));
			}
			return false;
		}
		return false;
	}
}
