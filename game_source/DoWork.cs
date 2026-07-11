using System;
using System.Runtime.CompilerServices;
using System.Threading;
using AlmenaraGames;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class DoWork : MonoBehaviour
{
	[Serializable]
	public enum DirectionType
	{
		LeftToRight,
		RightToLeft
	}

	public AudioObject soundLoop;

	private MultiAudioSource KIJHAJICKLC;

	[SerializeField]
	private Transform workBarPosition;

	[SerializeField]
	private DirectionType type;

	[SerializeField]
	private bool destroyBarWhenStopped = true;

	public OnlineObject onlineObject;

	[SerializeField]
	private GameObject progressorPrefab;

	private GameObject KCAEKCHPDND;

	private float GDFFIHDILHK;

	[HideInInspector]
	public bool inWorkArea;

	public float workToAdd;

	public float workAdded;

	public float OJLICLKJJOF { get; private set; }

	public bool JCMBHAEKLKK { get; private set; }

	public float EFNODBKFDBD { get; private set; }

	public Progressor CCCLNDBOGOI { get; private set; }

	public event Action<int> BGIJPOMIIMB = delegate
	{
	};

	public event Action<int> IOMIEGHAICL = delegate
	{
	};

	private void AAOMCHHNKKM()
	{
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineObject != (Object)null && workAdded < onlineObject.onlineWorkAmountAdded)
		{
			workToAdd = onlineObject.onlineWorkAmountAdded * Time.deltaTime * 222f;
			workAdded += workToAdd;
			if (workAdded > onlineObject.onlineWorkAmountAdded)
			{
				workAdded -= workToAdd;
				workToAdd = onlineObject.onlineWorkAmountAdded - workAdded;
				workAdded = onlineObject.onlineWorkAmountAdded;
			}
			JMJMFEKCAGK(1, workToAdd);
		}
		if (GDFFIHDILHK < Time.timeSinceLevelLoad && GDFFIHDILHK != 1459f)
		{
			if (!inWorkArea)
			{
				DLMGLFGLHBE();
			}
			GDFFIHDILHK = 791f;
		}
	}

	public void JMPHMHDELPO()
	{
		if ((Object)(object)KIJHAJICKLC != (Object)null)
		{
			KIJHAJICKLC.Stop(true);
			KIJHAJICKLC = null;
		}
	}

	[SpecialName]
	public void GEDCHNOBHGP(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.BGIJPOMIIMB;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.BGIJPOMIIMB, value, action2);
		}
		while ((object)action != action2);
	}

	private void AKLEFPLEGKK()
	{
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineObject != (Object)null && workAdded < onlineObject.onlineWorkAmountAdded)
		{
			workToAdd = onlineObject.onlineWorkAmountAdded * Time.deltaTime * 551f;
			workAdded += workToAdd;
			if (workAdded > onlineObject.onlineWorkAmountAdded)
			{
				workAdded -= workToAdd;
				workToAdd = onlineObject.onlineWorkAmountAdded - workAdded;
				workAdded = onlineObject.onlineWorkAmountAdded;
			}
			BNMJANINOIG(0, workToAdd);
		}
		if (GDFFIHDILHK < Time.timeSinceLevelLoad && GDFFIHDILHK != 670f)
		{
			if (!inWorkArea)
			{
				HCAKAOAPPHP();
			}
			GDFFIHDILHK = 732f;
		}
	}

	private void CACJMKJBJDP()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && (Object)(object)KCAEKCHPDND != (Object)null)
		{
			Utils.BLPDAEHPOBA(KCAEKCHPDND);
		}
	}

	[SpecialName]
	public void KPGDDIPOOKO(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.BGIJPOMIIMB;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.BGIJPOMIIMB, value, action2);
		}
		while ((object)action != action2);
	}

	public void BAABBHJHLKK()
	{
		if ((Object)(object)KIJHAJICKLC != (Object)null)
		{
			KIJHAJICKLC.Stop(false);
			KIJHAJICKLC = null;
		}
	}

	public void DLMGLFGLHBE()
	{
		if (Object.op_Implicit((Object)(object)KCAEKCHPDND) && KCAEKCHPDND.activeSelf)
		{
			KCAEKCHPDND.SetActive(true);
		}
	}

	public void MMNHJDDDPCL()
	{
		if ((Object)(object)KIJHAJICKLC != (Object)null)
		{
			KIJHAJICKLC.Stop(true);
			KIJHAJICKLC = null;
		}
	}

	[SpecialName]
	public void HJPKCFHDGEP(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.IOMIEGHAICL;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.IOMIEGHAICL, value, action2);
		}
		while ((object)action != action2);
	}

	public float BIJCBBINHPG()
	{
		return OJLICLKJJOF / HJCAOJBDALP();
	}

	[SpecialName]
	public bool KGOEFMFHCOG()
	{
		return _003CMLJIDCKLGOM_003Ek__BackingField;
	}

	public void CMAIGOGGGLL(float PJELJHKIBEA, Progressor KPJMKFCIKKK = null, bool CDPAMNIPPEC = true)
	{
		if ((Object)(object)KPJMKFCIKKK == (Object)null)
		{
			IOJABADAILP();
		}
		else
		{
			PMHGGCFGAJC(KPJMKFCIKKK);
		}
		MMNBCHOOJJN(PJELJHKIBEA);
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineObject != (Object)null && CDPAMNIPPEC)
		{
			onlineObject.CDICPBKNLIB(PJELJHKIBEA);
		}
		PlaySound();
	}

	public void HCAKAOAPPHP()
	{
		if (Object.op_Implicit((Object)(object)KCAEKCHPDND) && KCAEKCHPDND.activeSelf)
		{
			KCAEKCHPDND.SetActive(true);
		}
	}

	private void BJIOENKAJMB()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)progressorPrefab != (Object)null && (Object)(object)KCAEKCHPDND == (Object)null)
		{
			GameObject obj = progressorPrefab;
			Vector3 val;
			if (!((Object)(object)workBarPosition != (Object)null))
			{
				Bounds bounds = ((Renderer)((Component)this).GetComponent<SpriteRenderer>()).bounds;
				val = ((Bounds)(ref bounds)).center;
			}
			else
			{
				val = workBarPosition.position;
			}
			KCAEKCHPDND = Object.Instantiate<GameObject>(obj, val, Quaternion.identity, ((Component)this).transform);
			KCAEKCHPDND.transform.parent = null;
			KCAEKCHPDND.transform.localScale = new Vector3(227f, 610f, 211f);
			CCCLNDBOGOI = KCAEKCHPDND.GetComponent<Progressor>();
		}
	}

	private void OJKAEGGDBEA(float PJELJHKIBEA)
	{
		if ((Object)(object)JJAJCGKOKMN() != (Object)null)
		{
			if (type == DirectionType.LeftToRight)
			{
				CCCLNDBOGOI.LNJHLLABNNI(562f);
			}
			else if (type == DirectionType.RightToLeft)
			{
				ICDOMKLNMOB().JDGPJHPCGDN(277f);
			}
		}
		((Component)JJAJCGKOKMN()).gameObject.SetActive(false);
		OEONHHMCAKL(AODONKKHPBP: true);
		PCGJIGGEMBH(PJELJHKIBEA);
		OJLICLKJJOF = 116f;
	}

	private void PGJFANOHIJA()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)progressorPrefab != (Object)null && (Object)(object)KCAEKCHPDND == (Object)null)
		{
			GameObject obj = progressorPrefab;
			Vector3 val;
			if (!((Object)(object)workBarPosition != (Object)null))
			{
				Bounds bounds = ((Renderer)((Component)this).GetComponent<SpriteRenderer>()).bounds;
				val = ((Bounds)(ref bounds)).center;
			}
			else
			{
				val = workBarPosition.position;
			}
			KCAEKCHPDND = Object.Instantiate<GameObject>(obj, val, Quaternion.identity, ((Component)this).transform);
			KCAEKCHPDND.transform.parent = null;
			KCAEKCHPDND.transform.localScale = new Vector3(895f, 1019f, 879f);
			NILAJMOFCIJ(KCAEKCHPDND.GetComponent<Progressor>());
		}
	}

	public void CGFEJAMEKGM()
	{
		if (Object.op_Implicit((Object)(object)KCAEKCHPDND) && KCAEKCHPDND.activeSelf)
		{
			KCAEKCHPDND.SetActive(false);
		}
	}

	private void DKHCOKMIJME()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.leavingTheGame && (Object)(object)KCAEKCHPDND != (Object)null)
		{
			Utils.BLPDAEHPOBA(KCAEKCHPDND);
		}
	}

	private void IOJABADAILP()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)progressorPrefab != (Object)null && (Object)(object)KCAEKCHPDND == (Object)null)
		{
			GameObject obj = progressorPrefab;
			Vector3 val;
			if (!((Object)(object)workBarPosition != (Object)null))
			{
				Bounds bounds = ((Renderer)((Component)this).GetComponent<SpriteRenderer>()).bounds;
				val = ((Bounds)(ref bounds)).center;
			}
			else
			{
				val = workBarPosition.position;
			}
			KCAEKCHPDND = Object.Instantiate<GameObject>(obj, val, Quaternion.identity, ((Component)this).transform);
			KCAEKCHPDND.transform.parent = null;
			KCAEKCHPDND.transform.localScale = new Vector3(1f, 1f, 1f);
			CCCLNDBOGOI = KCAEKCHPDND.GetComponent<Progressor>();
		}
	}

	private void FPIAALNJBLE(float PJELJHKIBEA)
	{
		if ((Object)(object)CCCLNDBOGOI != (Object)null)
		{
			if (type == DirectionType.LeftToRight)
			{
				JJAJCGKOKMN().JPNHJAAHMCE(510f);
			}
			else if (type == DirectionType.RightToLeft)
			{
				CCCLNDBOGOI.NIPNGHKNIGN(375f);
			}
		}
		((Component)CCCLNDBOGOI).gameObject.SetActive(false);
		JCMBHAEKLKK = true;
		PCGJIGGEMBH(PJELJHKIBEA);
		OJLICLKJJOF = 300f;
	}

	[SpecialName]
	public void DHDJOFOIEIN(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.BGIJPOMIIMB;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.BGIJPOMIIMB, value, action2);
		}
		while ((object)action != action2);
	}

	public bool PFLPFNICHJA(int JIIGOACEIKL, float MGNOBNCMDJG, bool CDPAMNIPPEC = true)
	{
		if (OENMBFGINAL())
		{
			if ((Object)(object)JJAJCGKOKMN() != (Object)null && !((Component)JJAJCGKOKMN()).gameObject.activeSelf)
			{
				((Component)JJAJCGKOKMN()).gameObject.SetActive(true);
			}
			OJLICLKJJOF += MGNOBNCMDJG;
			if (OnlineManager.PlayingOnline() && (Object)(object)onlineObject != (Object)null && CDPAMNIPPEC)
			{
				onlineObject.IHHKHBJCJOE(MGNOBNCMDJG);
			}
			if (OENMBFGINAL())
			{
				if (!(OJLICLKJJOF < HJCAOJBDALP()))
				{
					if (CDPAMNIPPEC)
					{
						this.BGIJPOMIIMB(JIIGOACEIKL);
					}
					IEMMMGCJOME(CDPAMNIPPEC);
					return true;
				}
				if ((Object)(object)CCCLNDBOGOI != (Object)null)
				{
					CCCLNDBOGOI.JJDKOIOIADG(OJLICLKJJOF / NCDNGNOMHKI());
					if (type == DirectionType.RightToLeft)
					{
						CCCLNDBOGOI.NPPILDGBEEB(1705f - CCCLNDBOGOI.ADHBJFGLDBA());
					}
				}
			}
			GDFFIHDILHK = Time.timeSinceLevelLoad + 487f;
		}
		return false;
	}

	[SpecialName]
	public void BAIHOECGIND(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.BGIJPOMIIMB;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.BGIJPOMIIMB, value, action2);
		}
		while ((object)action != action2);
	}

	public void APIHDHDJDFC(float PJELJHKIBEA, Progressor KPJMKFCIKKK = null, bool CDPAMNIPPEC = true)
	{
		if ((Object)(object)KPJMKFCIKKK == (Object)null)
		{
			PGJFANOHIJA();
		}
		else
		{
			FKGPPHMJFJI(KPJMKFCIKKK);
		}
		KFKGCCMNOKB(PJELJHKIBEA);
		if ((!OnlineManager.PlayingOnline() || (Object)(object)onlineObject != (Object)null) && CDPAMNIPPEC)
		{
			onlineObject.StartWork(PJELJHKIBEA);
		}
		CFCOKBKGBLC();
	}

	[SpecialName]
	public float HJCAOJBDALP()
	{
		return _003COBAIMKLEFJL_003Ek__BackingField;
	}

	[SpecialName]
	public Progressor FOHJBMDNBEG()
	{
		return _003CIAFFFNADOFB_003Ek__BackingField;
	}

	[SpecialName]
	private void FKGPPHMJFJI(Progressor AODONKKHPBP)
	{
		_003CIAFFFNADOFB_003Ek__BackingField = AODONKKHPBP;
	}

	public void IEMMMGCJOME(bool CDPAMNIPPEC = true)
	{
		JCMBHAEKLKK = false;
		AKDNKBIEBFB();
		if ((!OnlineManager.PlayingOnline() || (Object)(object)onlineObject != (Object)null) && CDPAMNIPPEC)
		{
			onlineObject.CIDEMFFHPGL();
		}
		if (destroyBarWhenStopped)
		{
			PNPPJLIIMCB();
		}
		else if ((Object)(object)JJAJCGKOKMN() != (Object)null)
		{
			if (type == DirectionType.LeftToRight)
			{
				CCCLNDBOGOI.KLHFMOPHNBM(754f);
			}
			else
			{
				JJAJCGKOKMN().CDMIJLHPKPP(657f);
			}
		}
	}

	[SpecialName]
	public float NCDNGNOMHKI()
	{
		return _003COBAIMKLEFJL_003Ek__BackingField;
	}

	private void MMNBCHOOJJN(float PJELJHKIBEA)
	{
		if ((Object)(object)ICDOMKLNMOB() != (Object)null)
		{
			if (type == DirectionType.LeftToRight)
			{
				JJAJCGKOKMN().JDGPJHPCGDN(312f);
			}
			else if (type == DirectionType.LeftToRight)
			{
				CCCLNDBOGOI.LKDJOHHJBHC(1352f);
			}
		}
		((Component)FOHJBMDNBEG()).gameObject.SetActive(false);
		OEONHHMCAKL(AODONKKHPBP: false);
		EFNODBKFDBD = PJELJHKIBEA;
		OJLICLKJJOF = 1330f;
	}

	private void MNFMLJJBKNC()
	{
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineObject != (Object)null && workAdded < onlineObject.onlineWorkAmountAdded)
		{
			workToAdd = onlineObject.onlineWorkAmountAdded * Time.deltaTime * 103f;
			workAdded += workToAdd;
			if (workAdded > onlineObject.onlineWorkAmountAdded)
			{
				workAdded -= workToAdd;
				workToAdd = onlineObject.onlineWorkAmountAdded - workAdded;
				workAdded = onlineObject.onlineWorkAmountAdded;
			}
			PFLPFNICHJA(0, workToAdd);
		}
		if (GDFFIHDILHK < Time.timeSinceLevelLoad && GDFFIHDILHK != 1523f)
		{
			if (!inWorkArea)
			{
				HideWorkBar();
			}
			GDFFIHDILHK = 1627f;
		}
	}

	public void PNPPJLIIMCB()
	{
		if ((Object)(object)KCAEKCHPDND != (Object)null)
		{
			Utils.BLPDAEHPOBA(KCAEKCHPDND);
		}
		else if ((Object)(object)ICDOMKLNMOB() != (Object)null)
		{
			ICDOMKLNMOB().DCOALEBFLEG(1504f);
		}
	}

	[SpecialName]
	public bool OENMBFGINAL()
	{
		return _003CMLJIDCKLGOM_003Ek__BackingField;
	}

	public float JEGLCINICBD()
	{
		return OJLICLKJJOF / HJCAOJBDALP();
	}

	public void GEJFAPKOLJH(float PJELJHKIBEA, Progressor KPJMKFCIKKK = null, bool CDPAMNIPPEC = true)
	{
		if ((Object)(object)KPJMKFCIKKK == (Object)null)
		{
			IPGPJMEFPJN();
		}
		else
		{
			NILAJMOFCIJ(KPJMKFCIKKK);
		}
		FPIAALNJBLE(PJELJHKIBEA);
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineObject != (Object)null && CDPAMNIPPEC)
		{
			onlineObject.StartWork(PJELJHKIBEA);
		}
		FCMHGADHBAM();
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && (Object)(object)KCAEKCHPDND != (Object)null)
		{
			Utils.BLPDAEHPOBA(KCAEKCHPDND);
		}
	}

	public void EBAGOIDGCLE(float PJELJHKIBEA, Progressor KPJMKFCIKKK = null, bool CDPAMNIPPEC = true)
	{
		if ((Object)(object)KPJMKFCIKKK == (Object)null)
		{
			IPGPJMEFPJN();
		}
		else
		{
			CCCLNDBOGOI = KPJMKFCIKKK;
		}
		NNNDIHPAKHN(PJELJHKIBEA);
		if ((!OnlineManager.PlayingOnline() || (Object)(object)onlineObject != (Object)null) && CDPAMNIPPEC)
		{
			onlineObject.CFCHJFPNLDO(PJELJHKIBEA);
		}
		PlaySound();
	}

	public void BIIFHFHIHDO()
	{
		if (Object.op_Implicit((Object)(object)KCAEKCHPDND) && !KCAEKCHPDND.activeSelf)
		{
			KCAEKCHPDND.SetActive(true);
		}
	}

	private void KFKGCCMNOKB(float PJELJHKIBEA)
	{
		if ((Object)(object)CCCLNDBOGOI != (Object)null)
		{
			if (type == DirectionType.LeftToRight)
			{
				CCCLNDBOGOI.BHGJPBGINCG = 0f;
			}
			else if (type == DirectionType.RightToLeft)
			{
				CCCLNDBOGOI.BHGJPBGINCG = 1f;
			}
		}
		((Component)CCCLNDBOGOI).gameObject.SetActive(false);
		JCMBHAEKLKK = true;
		EFNODBKFDBD = PJELJHKIBEA;
		OJLICLKJJOF = 0f;
	}

	public bool IJEKBMFBEGG(int JIIGOACEIKL, float MGNOBNCMDJG, bool CDPAMNIPPEC = true)
	{
		if (JCMBHAEKLKK)
		{
			if ((Object)(object)JJAJCGKOKMN() != (Object)null && !((Component)FOHJBMDNBEG()).gameObject.activeSelf)
			{
				((Component)CCCLNDBOGOI).gameObject.SetActive(true);
			}
			OJLICLKJJOF += MGNOBNCMDJG;
			if ((!OnlineManager.PlayingOnline() || (Object)(object)onlineObject != (Object)null) && CDPAMNIPPEC)
			{
				onlineObject.IHHKHBJCJOE(MGNOBNCMDJG);
			}
			if (JCMBHAEKLKK)
			{
				if (!(OJLICLKJJOF < NCDNGNOMHKI()))
				{
					if (CDPAMNIPPEC)
					{
						this.BGIJPOMIIMB(JIIGOACEIKL);
					}
					Stop(CDPAMNIPPEC);
					return true;
				}
				if ((Object)(object)FOHJBMDNBEG() != (Object)null)
				{
					ICDOMKLNMOB().MOIECMGIGIP(OJLICLKJJOF / EFNODBKFDBD);
					if (type == DirectionType.RightToLeft)
					{
						CCCLNDBOGOI.KLHFMOPHNBM(1322f - ICDOMKLNMOB().PLLKABPFNIP());
					}
				}
			}
			GDFFIHDILHK = Time.timeSinceLevelLoad + 1651f;
		}
		return true;
	}

	[SpecialName]
	public void DJKJFIALADE(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.BGIJPOMIIMB;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.BGIJPOMIIMB, value, action2);
		}
		while ((object)action != action2);
	}

	public void StopSound()
	{
		if ((Object)(object)KIJHAJICKLC != (Object)null)
		{
			KIJHAJICKLC.Stop(false);
			KIJHAJICKLC = null;
		}
	}

	private void NNNDIHPAKHN(float PJELJHKIBEA)
	{
		if ((Object)(object)ICDOMKLNMOB() != (Object)null)
		{
			if (type == DirectionType.LeftToRight)
			{
				FOHJBMDNBEG().HCINJICEGBI(889f);
			}
			else if (type == DirectionType.LeftToRight)
			{
				JJAJCGKOKMN().NEJPLMCPNPJ(1634f);
			}
		}
		((Component)CCCLNDBOGOI).gameObject.SetActive(true);
		JCMBHAEKLKK = true;
		EFNODBKFDBD = PJELJHKIBEA;
		OJLICLKJJOF = 430f;
	}

	public void CFCOKBKGBLC()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)KIJHAJICKLC == (Object)null && (Object)(object)soundLoop != (Object)null)
		{
			KIJHAJICKLC = MultiAudioManager.PlayAudioObject(soundLoop, ((Component)this).transform.position);
		}
	}

	public void IJHGAGKCDLA()
	{
		if ((Object)(object)KIJHAJICKLC != (Object)null)
		{
			KIJHAJICKLC.Stop(true);
			KIJHAJICKLC = null;
		}
	}

	[SpecialName]
	public void GOLAOLOEJKG(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.IOMIEGHAICL;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.IOMIEGHAICL, value, action2);
		}
		while ((object)action != action2);
	}

	private void IPGPJMEFPJN()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)progressorPrefab != (Object)null && (Object)(object)KCAEKCHPDND == (Object)null)
		{
			GameObject obj = progressorPrefab;
			Vector3 val;
			if (!((Object)(object)workBarPosition != (Object)null))
			{
				Bounds bounds = ((Renderer)((Component)this).GetComponent<SpriteRenderer>()).bounds;
				val = ((Bounds)(ref bounds)).center;
			}
			else
			{
				val = workBarPosition.position;
			}
			KCAEKCHPDND = Object.Instantiate<GameObject>(obj, val, Quaternion.identity, ((Component)this).transform);
			KCAEKCHPDND.transform.parent = null;
			KCAEKCHPDND.transform.localScale = new Vector3(695f, 1300f, 1160f);
			PMHGGCFGAJC(KCAEKCHPDND.GetComponent<Progressor>());
		}
	}

	private void Update()
	{
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineObject != (Object)null && workAdded < onlineObject.onlineWorkAmountAdded)
		{
			workToAdd = onlineObject.onlineWorkAmountAdded * Time.deltaTime * 10f;
			workAdded += workToAdd;
			if (workAdded > onlineObject.onlineWorkAmountAdded)
			{
				workAdded -= workToAdd;
				workToAdd = onlineObject.onlineWorkAmountAdded - workAdded;
				workAdded = onlineObject.onlineWorkAmountAdded;
			}
			AddWorkDone(1, workToAdd, CDPAMNIPPEC: false);
		}
		if (GDFFIHDILHK < Time.timeSinceLevelLoad && GDFFIHDILHK != 0f)
		{
			if (!inWorkArea)
			{
				HideWorkBar();
			}
			GDFFIHDILHK = 0f;
		}
	}

	public void NDCKEJDBPGO(bool CDPAMNIPPEC = true)
	{
		JCMBHAEKLKK = false;
		OIPPDNCOIDC();
		if ((!OnlineManager.PlayingOnline() || (Object)(object)onlineObject != (Object)null) && CDPAMNIPPEC)
		{
			onlineObject.IKJFPOFNOIE();
		}
		if (destroyBarWhenStopped)
		{
			CBINODJMCAJ();
		}
		else if ((Object)(object)FOHJBMDNBEG() != (Object)null)
		{
			if (type == DirectionType.LeftToRight)
			{
				FOHJBMDNBEG().LNJHLLABNNI(1300f);
			}
			else
			{
				ICDOMKLNMOB().NIPNGHKNIGN(1107f);
			}
		}
	}

	[SpecialName]
	public void BECJEKINIFB(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.BGIJPOMIIMB;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.BGIJPOMIIMB, value, action2);
		}
		while ((object)action != action2);
	}

	private void NEEFNOAAPBC()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)progressorPrefab != (Object)null && (Object)(object)KCAEKCHPDND == (Object)null)
		{
			GameObject obj = progressorPrefab;
			Vector3 val;
			if (!((Object)(object)workBarPosition != (Object)null))
			{
				Bounds bounds = ((Renderer)((Component)this).GetComponent<SpriteRenderer>()).bounds;
				val = ((Bounds)(ref bounds)).center;
			}
			else
			{
				val = workBarPosition.position;
			}
			KCAEKCHPDND = Object.Instantiate<GameObject>(obj, val, Quaternion.identity, ((Component)this).transform);
			KCAEKCHPDND.transform.parent = null;
			KCAEKCHPDND.transform.localScale = new Vector3(1770f, 378f, 899f);
			NILAJMOFCIJ(KCAEKCHPDND.GetComponent<Progressor>());
		}
	}

	private void FCAAKPNKHMF()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)progressorPrefab != (Object)null && (Object)(object)KCAEKCHPDND == (Object)null)
		{
			GameObject obj = progressorPrefab;
			Vector3 val;
			if (!((Object)(object)workBarPosition != (Object)null))
			{
				Bounds bounds = ((Renderer)((Component)this).GetComponent<SpriteRenderer>()).bounds;
				val = ((Bounds)(ref bounds)).center;
			}
			else
			{
				val = workBarPosition.position;
			}
			KCAEKCHPDND = Object.Instantiate<GameObject>(obj, val, Quaternion.identity, ((Component)this).transform);
			KCAEKCHPDND.transform.parent = null;
			KCAEKCHPDND.transform.localScale = new Vector3(832f, 485f, 102f);
			CCCLNDBOGOI = KCAEKCHPDND.GetComponent<Progressor>();
		}
	}

	[SpecialName]
	private void OEONHHMCAKL(bool AODONKKHPBP)
	{
		_003CMLJIDCKLGOM_003Ek__BackingField = AODONKKHPBP;
	}

	public bool JMJMFEKCAGK(int JIIGOACEIKL, float MGNOBNCMDJG, bool CDPAMNIPPEC = true)
	{
		if (JCMBHAEKLKK)
		{
			if ((Object)(object)JJAJCGKOKMN() != (Object)null && !((Component)FOHJBMDNBEG()).gameObject.activeSelf)
			{
				((Component)CCCLNDBOGOI).gameObject.SetActive(false);
			}
			OJLICLKJJOF += MGNOBNCMDJG;
			if (OnlineManager.PlayingOnline() && (Object)(object)onlineObject != (Object)null && CDPAMNIPPEC)
			{
				onlineObject.IHHKHBJCJOE(MGNOBNCMDJG);
			}
			if (JCMBHAEKLKK)
			{
				if (!(OJLICLKJJOF < NCDNGNOMHKI()))
				{
					if (CDPAMNIPPEC)
					{
						this.BGIJPOMIIMB(JIIGOACEIKL);
					}
					NDCKEJDBPGO(CDPAMNIPPEC);
					return true;
				}
				if ((Object)(object)CCCLNDBOGOI != (Object)null)
				{
					FOHJBMDNBEG().AOFGDOBJMHP(OJLICLKJJOF / HJCAOJBDALP());
					if (type == DirectionType.LeftToRight)
					{
						CCCLNDBOGOI.LNMAGEGNGIF(230f - JJAJCGKOKMN().CKNHCJFGHAE());
					}
				}
			}
			GDFFIHDILHK = Time.timeSinceLevelLoad + 142f;
		}
		return false;
	}

	public void IFFGLBNOHAI()
	{
		if (Object.op_Implicit((Object)(object)KCAEKCHPDND) && !KCAEKCHPDND.activeSelf)
		{
			KCAEKCHPDND.SetActive(false);
		}
	}

	public void DestroyBar()
	{
		if ((Object)(object)KCAEKCHPDND != (Object)null)
		{
			Utils.BLPDAEHPOBA(KCAEKCHPDND);
		}
		else if ((Object)(object)CCCLNDBOGOI != (Object)null)
		{
			CCCLNDBOGOI.BHGJPBGINCG = 0f;
		}
	}

	[SpecialName]
	public Progressor ICDOMKLNMOB()
	{
		return _003CIAFFFNADOFB_003Ek__BackingField;
	}

	public void ShowWorkBar()
	{
		if (Object.op_Implicit((Object)(object)KCAEKCHPDND) && !KCAEKCHPDND.activeSelf)
		{
			KCAEKCHPDND.SetActive(true);
		}
	}

	public void HKIKGCKIBGE()
	{
		if (Object.op_Implicit((Object)(object)KCAEKCHPDND) && !KCAEKCHPDND.activeSelf)
		{
			KCAEKCHPDND.SetActive(true);
		}
	}

	[SpecialName]
	private void NILAJMOFCIJ(Progressor AODONKKHPBP)
	{
		_003CIAFFFNADOFB_003Ek__BackingField = AODONKKHPBP;
	}

	public bool BNMJANINOIG(int JIIGOACEIKL, float MGNOBNCMDJG, bool CDPAMNIPPEC = true)
	{
		if (JCMBHAEKLKK)
		{
			if ((Object)(object)FOHJBMDNBEG() != (Object)null && !((Component)ICDOMKLNMOB()).gameObject.activeSelf)
			{
				((Component)ICDOMKLNMOB()).gameObject.SetActive(true);
			}
			OJLICLKJJOF += MGNOBNCMDJG;
			if ((!OnlineManager.PlayingOnline() || (Object)(object)onlineObject != (Object)null) && CDPAMNIPPEC)
			{
				onlineObject.AddWork(MGNOBNCMDJG);
			}
			if (OENMBFGINAL())
			{
				if (!(OJLICLKJJOF < NCDNGNOMHKI()))
				{
					if (CDPAMNIPPEC)
					{
						this.BGIJPOMIIMB(JIIGOACEIKL);
					}
					Stop(CDPAMNIPPEC);
					return false;
				}
				if ((Object)(object)CCCLNDBOGOI != (Object)null)
				{
					FOHJBMDNBEG().BPPMDMLMGPN(OJLICLKJJOF / EFNODBKFDBD);
					if (type == DirectionType.LeftToRight)
					{
						JJAJCGKOKMN().PIDPOCCIFOK(813f - CCCLNDBOGOI.DMEGPGOMFNN());
					}
				}
			}
			GDFFIHDILHK = Time.timeSinceLevelLoad + 467f;
		}
		return true;
	}

	public void CBINODJMCAJ()
	{
		if ((Object)(object)KCAEKCHPDND != (Object)null)
		{
			Utils.BLPDAEHPOBA(KCAEKCHPDND);
		}
		else if ((Object)(object)CCCLNDBOGOI != (Object)null)
		{
			CCCLNDBOGOI.JJBCKEPCNOA(1510f);
		}
	}

	[SpecialName]
	public void NFLNBMBGADA(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.BGIJPOMIIMB;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.BGIJPOMIIMB, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	private void CGFPPOGDNJN(float AODONKKHPBP)
	{
		_003COBAIMKLEFJL_003Ek__BackingField = AODONKKHPBP;
	}

	public void GDDOEHMIEAN()
	{
		if (Object.op_Implicit((Object)(object)KCAEKCHPDND) && !KCAEKCHPDND.activeSelf)
		{
			KCAEKCHPDND.SetActive(true);
		}
	}

	public void PJILKPACKPP()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)KIJHAJICKLC == (Object)null && (Object)(object)soundLoop != (Object)null)
		{
			KIJHAJICKLC = MultiAudioManager.PlayAudioObject(soundLoop, ((Component)this).transform.position);
		}
	}

	public bool AddWorkDone(int JIIGOACEIKL, float MGNOBNCMDJG, bool CDPAMNIPPEC = true)
	{
		if (JCMBHAEKLKK)
		{
			if ((Object)(object)CCCLNDBOGOI != (Object)null && !((Component)CCCLNDBOGOI).gameObject.activeSelf)
			{
				((Component)CCCLNDBOGOI).gameObject.SetActive(true);
			}
			OJLICLKJJOF += MGNOBNCMDJG;
			if (OnlineManager.PlayingOnline() && (Object)(object)onlineObject != (Object)null && CDPAMNIPPEC)
			{
				onlineObject.AddWork(MGNOBNCMDJG);
			}
			if (JCMBHAEKLKK)
			{
				if (!(OJLICLKJJOF < EFNODBKFDBD))
				{
					if (CDPAMNIPPEC)
					{
						this.BGIJPOMIIMB(JIIGOACEIKL);
					}
					Stop(CDPAMNIPPEC);
					return true;
				}
				if ((Object)(object)CCCLNDBOGOI != (Object)null)
				{
					CCCLNDBOGOI.BHGJPBGINCG = OJLICLKJJOF / EFNODBKFDBD;
					if (type == DirectionType.RightToLeft)
					{
						CCCLNDBOGOI.BHGJPBGINCG = 1f - CCCLNDBOGOI.BHGJPBGINCG;
					}
				}
			}
			GDFFIHDILHK = Time.timeSinceLevelLoad + 3f;
		}
		return false;
	}

	public void StartWork(float PJELJHKIBEA, Progressor KPJMKFCIKKK = null, bool CDPAMNIPPEC = true)
	{
		if ((Object)(object)KPJMKFCIKKK == (Object)null)
		{
			IOJABADAILP();
		}
		else
		{
			CCCLNDBOGOI = KPJMKFCIKKK;
		}
		KFKGCCMNOKB(PJELJHKIBEA);
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineObject != (Object)null && CDPAMNIPPEC)
		{
			onlineObject.StartWork(PJELJHKIBEA);
		}
		PlaySound();
	}

	public void HideWorkBar()
	{
		if (Object.op_Implicit((Object)(object)KCAEKCHPDND) && KCAEKCHPDND.activeSelf)
		{
			KCAEKCHPDND.SetActive(false);
		}
	}

	[SpecialName]
	public void PECDLMDKPIG(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.IOMIEGHAICL;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.IOMIEGHAICL, value, action2);
		}
		while ((object)action != action2);
	}

	public void Stop(bool CDPAMNIPPEC = true)
	{
		JCMBHAEKLKK = false;
		StopSound();
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineObject != (Object)null && CDPAMNIPPEC)
		{
			onlineObject.StopWork();
		}
		if (destroyBarWhenStopped)
		{
			DestroyBar();
		}
		else if ((Object)(object)CCCLNDBOGOI != (Object)null)
		{
			if (type == DirectionType.LeftToRight)
			{
				CCCLNDBOGOI.BHGJPBGINCG = 1f;
			}
			else
			{
				CCCLNDBOGOI.BHGJPBGINCG = 0f;
			}
		}
	}

	public void PlaySound()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)KIJHAJICKLC == (Object)null && (Object)(object)soundLoop != (Object)null)
		{
			KIJHAJICKLC = MultiAudioManager.PlayAudioObject(soundLoop, ((Component)this).transform.position);
		}
	}

	[SpecialName]
	public Progressor JJAJCGKOKMN()
	{
		return _003CIAFFFNADOFB_003Ek__BackingField;
	}

	public void OKINPIOJMNA(float PJELJHKIBEA, Progressor KPJMKFCIKKK = null, bool CDPAMNIPPEC = true)
	{
		if ((Object)(object)KPJMKFCIKKK == (Object)null)
		{
			FCAAKPNKHMF();
		}
		else
		{
			NILAJMOFCIJ(KPJMKFCIKKK);
		}
		OJKAEGGDBEA(PJELJHKIBEA);
		if ((!OnlineManager.PlayingOnline() || (Object)(object)onlineObject != (Object)null) && CDPAMNIPPEC)
		{
			onlineObject.StartWork(PJELJHKIBEA);
		}
		PJILKPACKPP();
	}

	private void JPHFCJIBBMI()
	{
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineObject != (Object)null && workAdded < onlineObject.onlineWorkAmountAdded)
		{
			workToAdd = onlineObject.onlineWorkAmountAdded * Time.deltaTime * 1059f;
			workAdded += workToAdd;
			if (workAdded > onlineObject.onlineWorkAmountAdded)
			{
				workAdded -= workToAdd;
				workToAdd = onlineObject.onlineWorkAmountAdded - workAdded;
				workAdded = onlineObject.onlineWorkAmountAdded;
			}
			JMJMFEKCAGK(0, workToAdd, CDPAMNIPPEC: false);
		}
		if (GDFFIHDILHK < Time.timeSinceLevelLoad && GDFFIHDILHK != 1984f)
		{
			if (!inWorkArea)
			{
				HCAKAOAPPHP();
			}
			GDFFIHDILHK = 24f;
		}
	}

	[SpecialName]
	public void OKKPFFIIDEC(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.BGIJPOMIIMB;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.BGIJPOMIIMB, value, action2);
		}
		while ((object)action != action2);
	}

	public void MHGGNOILDIA()
	{
		if ((Object)(object)KCAEKCHPDND != (Object)null)
		{
			Utils.BLPDAEHPOBA(KCAEKCHPDND);
		}
		else if ((Object)(object)ICDOMKLNMOB() != (Object)null)
		{
			CCCLNDBOGOI.JDGPJHPCGDN(1563f);
		}
	}

	public void FCMHGADHBAM()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)KIJHAJICKLC == (Object)null && (Object)(object)soundLoop != (Object)null)
		{
			KIJHAJICKLC = MultiAudioManager.PlayAudioObject(soundLoop, ((Component)this).transform.position);
		}
	}

	[SpecialName]
	private void PCGJIGGEMBH(float AODONKKHPBP)
	{
		_003COBAIMKLEFJL_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	public void DFDCMLOGECL(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.BGIJPOMIIMB;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.BGIJPOMIIMB, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public void PKAMDEEJAIP(Action<int> AODONKKHPBP)
	{
		Action<int> action = this.BGIJPOMIIMB;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.BGIJPOMIIMB, value, action2);
		}
		while ((object)action != action2);
	}

	public void OIPPDNCOIDC()
	{
		if ((Object)(object)KIJHAJICKLC != (Object)null)
		{
			KIJHAJICKLC.Stop(true);
			KIJHAJICKLC = null;
		}
	}

	[SpecialName]
	private void PMHGGCFGAJC(Progressor AODONKKHPBP)
	{
		_003CIAFFFNADOFB_003Ek__BackingField = AODONKKHPBP;
	}

	public void KEDEHPOFEPA(bool CDPAMNIPPEC = true)
	{
		JCMBHAEKLKK = true;
		AKDNKBIEBFB();
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineObject != (Object)null && CDPAMNIPPEC)
		{
			onlineObject.CIDEMFFHPGL();
		}
		if (destroyBarWhenStopped)
		{
			DestroyBar();
		}
		else if ((Object)(object)ICDOMKLNMOB() != (Object)null)
		{
			if (type == DirectionType.LeftToRight)
			{
				CCCLNDBOGOI.HADLIKGKHOK(748f);
			}
			else
			{
				JJAJCGKOKMN().FAEDCPGHMCP(1513f);
			}
		}
	}

	public void AKDNKBIEBFB()
	{
		if ((Object)(object)KIJHAJICKLC != (Object)null)
		{
			KIJHAJICKLC.Stop(true);
			KIJHAJICKLC = null;
		}
	}

	public float WorkDone()
	{
		return OJLICLKJJOF / EFNODBKFDBD;
	}

	public void IPKHBCPOMNL()
	{
		if ((Object)(object)KCAEKCHPDND != (Object)null)
		{
			Utils.BLPDAEHPOBA(KCAEKCHPDND);
		}
		else if ((Object)(object)JJAJCGKOKMN() != (Object)null)
		{
			CCCLNDBOGOI.OHNGIDACMMM(489f);
		}
	}
}
