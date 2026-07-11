using System.Runtime.CompilerServices;
using UnityEngine;

public class ContentLock : MonoBehaviour
{
	public ContentLockID contentLockID;

	public GameObject lockParent;

	public bool PFAPICAIEFB { get; private set; }

	protected virtual void IDPHKHGHJGN()
	{
		ContentLocksManager.OKFMBJIKEAH(this);
	}

	[SpecialName]
	private void JIDLNNAGKMH(bool AODONKKHPBP)
	{
		_003CJNEENGGKDFH_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	public bool FCELFJIAFFL()
	{
		return _003CJNEENGGKDFH_003Ek__BackingField;
	}

	[SpecialName]
	public bool OIDNLOKBAEP()
	{
		return _003CJNEENGGKDFH_003Ek__BackingField;
	}

	protected virtual void OOFCNPEAKLM(int JIIGOACEIKL)
	{
		CommonReferences.GGFJGHHHEJC.OnUnlocked(JIIGOACEIKL, contentLockID);
		CommonReferences.MNFMOEKMJKN().contentUnlocked.Add(contentLockID);
		BEJMLJNHPDD(AODONKKHPBP: false);
	}

	[SpecialName]
	private void FDBBNIECMJH(bool AODONKKHPBP)
	{
		_003CJNEENGGKDFH_003Ek__BackingField = AODONKKHPBP;
	}

	protected virtual void PLGOJCHJJCH(int JIIGOACEIKL)
	{
		CommonReferences.MNFMOEKMJKN().OnUnlocked(JIIGOACEIKL, contentLockID);
		CommonReferences.GGFJGHHHEJC.contentUnlocked.Add(contentLockID);
		BEJMLJNHPDD(AODONKKHPBP: false);
	}

	[SpecialName]
	private void JCGECJCHBJJ(bool AODONKKHPBP)
	{
		_003CJNEENGGKDFH_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	public bool KKJEKJEPAJF()
	{
		return _003CJNEENGGKDFH_003Ek__BackingField;
	}

	protected virtual void DGFKKDADOAG(int JIIGOACEIKL)
	{
		CommonReferences.GGFJGHHHEJC.OnUnlocked(JIIGOACEIKL, contentLockID);
		CommonReferences.GGFJGHHHEJC.contentUnlocked.Add(contentLockID);
		JCGECJCHBJJ(AODONKKHPBP: false);
	}

	[SpecialName]
	public bool HOBPJJNDOHL()
	{
		return _003CJNEENGGKDFH_003Ek__BackingField;
	}

	[SpecialName]
	private void OIENGGKEOGB(bool AODONKKHPBP)
	{
		_003CJNEENGGKDFH_003Ek__BackingField = AODONKKHPBP;
	}

	public void OEIAPKHMPFA()
	{
		if (!((Object)(object)lockParent == (Object)null))
		{
			Debug.Log((object)"NO SLOT MANAGER!");
			lockParent.SetActive(false);
		}
	}

	protected virtual void LIILMNLDCKP(int JIIGOACEIKL)
	{
		CommonReferences.GGFJGHHHEJC.OnUnlocked(JIIGOACEIKL, contentLockID);
		CommonReferences.GGFJGHHHEJC.contentUnlocked.Add(contentLockID);
		OIENGGKEOGB(AODONKKHPBP: true);
	}

	public virtual void LKJFHMLDPPB()
	{
		CommonReferences.MNFMOEKMJKN().contentUnlocked.Add(contentLockID);
		PFAPICAIEFB = true;
	}

	public virtual void JGCKGMCGOMA()
	{
		CommonReferences.MNFMOEKMJKN().contentUnlocked.Add(contentLockID);
		PKAFMMGDLJD(AODONKKHPBP: false);
	}

	protected virtual void DNDJHHODOGG(int JIIGOACEIKL)
	{
		CommonReferences.GGFJGHHHEJC.OnUnlocked(JIIGOACEIKL, contentLockID);
		CommonReferences.GGFJGHHHEJC.contentUnlocked.Add(contentLockID);
		OOAIFPMBOFF(AODONKKHPBP: true);
	}

	[SpecialName]
	public bool BGBPKLMLCFI()
	{
		return _003CJNEENGGKDFH_003Ek__BackingField;
	}

	public virtual void CCENMBPDBFL()
	{
		CommonReferences.MNFMOEKMJKN().contentUnlocked.Add(contentLockID);
		JCGECJCHBJJ(AODONKKHPBP: true);
	}

	[SpecialName]
	public bool DFLAHGJCNGG()
	{
		return _003CJNEENGGKDFH_003Ek__BackingField;
	}

	protected virtual void AAAMMOBLNCL(int JIIGOACEIKL)
	{
		CommonReferences.GGFJGHHHEJC.OnUnlocked(JIIGOACEIKL, contentLockID);
		CommonReferences.MNFMOEKMJKN().contentUnlocked.Add(contentLockID);
		CJAPPCCDHEP(AODONKKHPBP: true);
	}

	protected virtual void Start()
	{
		ContentLocksManager.AddLock(this);
	}

	public void MJMPDFKFLJL()
	{
		if (!((Object)(object)lockParent == (Object)null))
		{
			Debug.Log((object)"Tutorial/T100/Dialogue3");
			lockParent.SetActive(true);
		}
	}

	[SpecialName]
	public bool HFKMDHLJDBG()
	{
		return _003CJNEENGGKDFH_003Ek__BackingField;
	}

	[SpecialName]
	private void PKAFMMGDLJD(bool AODONKKHPBP)
	{
		_003CJNEENGGKDFH_003Ek__BackingField = AODONKKHPBP;
	}

	public void DLGADHLPEPB()
	{
		if (!((Object)(object)lockParent == (Object)null))
		{
			Debug.Log((object)"</color>");
			lockParent.SetActive(false);
		}
	}

	[SpecialName]
	private void NBKEHLKGOHC(bool AODONKKHPBP)
	{
		_003CJNEENGGKDFH_003Ek__BackingField = AODONKKHPBP;
	}

	protected virtual void NMEEBOPJAOB(int JIIGOACEIKL)
	{
		CommonReferences.GGFJGHHHEJC.OnUnlocked(JIIGOACEIKL, contentLockID);
		CommonReferences.MNFMOEKMJKN().contentUnlocked.Add(contentLockID);
		CEJBJJLOKHP(AODONKKHPBP: true);
	}

	[SpecialName]
	private void OOAIFPMBOFF(bool AODONKKHPBP)
	{
		_003CJNEENGGKDFH_003Ek__BackingField = AODONKKHPBP;
	}

	protected virtual void JEDKOLDKBAG(int JIIGOACEIKL)
	{
		CommonReferences.MNFMOEKMJKN().OnUnlocked(JIIGOACEIKL, contentLockID);
		CommonReferences.MNFMOEKMJKN().contentUnlocked.Add(contentLockID);
		PKAFMMGDLJD(AODONKKHPBP: true);
	}

	protected virtual void GNGADDPBJDC()
	{
		ContentLocksManager.HNPBNOHALOM(this);
	}

	public virtual void BGPLLCAEMIK()
	{
		CommonReferences.MNFMOEKMJKN().contentUnlocked.Add(contentLockID);
		CNBPBDGLLFM(AODONKKHPBP: true);
	}

	protected virtual void BGFCHEIOKOG()
	{
		ContentLocksManager.HNPBNOHALOM(this);
	}

	[SpecialName]
	public bool CFCMCLLOKMM()
	{
		return _003CJNEENGGKDFH_003Ek__BackingField;
	}

	[SpecialName]
	public bool GAACDDKNJFP()
	{
		return _003CJNEENGGKDFH_003Ek__BackingField;
	}

	protected virtual void BDMEBLBLPIA()
	{
		ContentLocksManager.EAMONNGOOBN(this);
	}

	protected virtual void DKHGCLKCLLI(int JIIGOACEIKL)
	{
		CommonReferences.MNFMOEKMJKN().OnUnlocked(JIIGOACEIKL, contentLockID);
		CommonReferences.GGFJGHHHEJC.contentUnlocked.Add(contentLockID);
		JIDLNNAGKMH(AODONKKHPBP: true);
	}

	protected virtual void MLLADNLMIMP()
	{
		ContentLocksManager.NCACCFMGKIB(this);
	}

	protected virtual void NJKCAJJDDGC(int JIIGOACEIKL)
	{
		CommonReferences.GGFJGHHHEJC.OnUnlocked(JIIGOACEIKL, contentLockID);
		CommonReferences.MNFMOEKMJKN().contentUnlocked.Add(contentLockID);
		BKJACOFMECH(AODONKKHPBP: true);
	}

	protected virtual void HOKAPOOCJCC()
	{
		ContentLocksManager.JELIADFOODC(this);
	}

	[SpecialName]
	public bool KEHECKHCMPE()
	{
		return _003CJNEENGGKDFH_003Ek__BackingField;
	}

	protected virtual void CBLOABGNPEE(int JIIGOACEIKL)
	{
		CommonReferences.GGFJGHHHEJC.OnUnlocked(JIIGOACEIKL, contentLockID);
		CommonReferences.GGFJGHHHEJC.contentUnlocked.Add(contentLockID);
		MILACHLIPFH(AODONKKHPBP: false);
	}

	[SpecialName]
	private void CJAPPCCDHEP(bool AODONKKHPBP)
	{
		_003CJNEENGGKDFH_003Ek__BackingField = AODONKKHPBP;
	}

	protected virtual void BELOIFKPNMM()
	{
		ContentLocksManager.DPDHEAPJFCA(this);
	}

	public virtual void BGKPLFJDJGF()
	{
		CommonReferences.GGFJGHHHEJC.contentUnlocked.Add(contentLockID);
		JIDLNNAGKMH(AODONKKHPBP: true);
	}

	public void ActivateLock()
	{
		if (!((Object)(object)lockParent == (Object)null))
		{
			Debug.Log((object)"Activate Lock");
			lockParent.SetActive(true);
		}
	}

	public void CDJFPKKBCJG()
	{
		if (!((Object)(object)lockParent == (Object)null))
		{
			Debug.Log((object)"Plant");
			lockParent.SetActive(false);
		}
	}

	protected virtual void MFMMHDPGCBO()
	{
		ContentLocksManager.PIGHEFEFINO(this);
	}

	protected virtual void DMGALPKNKLP(int JIIGOACEIKL)
	{
		CommonReferences.MNFMOEKMJKN().OnUnlocked(JIIGOACEIKL, contentLockID);
		CommonReferences.MNFMOEKMJKN().contentUnlocked.Add(contentLockID);
		OIENGGKEOGB(AODONKKHPBP: true);
	}

	[SpecialName]
	public bool EKPFCEIMKOP()
	{
		return _003CJNEENGGKDFH_003Ek__BackingField;
	}

	public virtual void CLMPOJPOFKL()
	{
		CommonReferences.MNFMOEKMJKN().contentUnlocked.Add(contentLockID);
		JIDLNNAGKMH(AODONKKHPBP: false);
	}

	[SpecialName]
	private void CNBPBDGLLFM(bool AODONKKHPBP)
	{
		_003CJNEENGGKDFH_003Ek__BackingField = AODONKKHPBP;
	}

	public virtual void LoadUnlocked()
	{
		CommonReferences.GGFJGHHHEJC.contentUnlocked.Add(contentLockID);
		PFAPICAIEFB = true;
	}

	public virtual void CKEFHDHBFLM()
	{
		CommonReferences.GGFJGHHHEJC.contentUnlocked.Add(contentLockID);
		JIDLNNAGKMH(AODONKKHPBP: true);
	}

	[SpecialName]
	public bool GOHGFMLGHOI()
	{
		return _003CJNEENGGKDFH_003Ek__BackingField;
	}

	[SpecialName]
	private void PDEDKDLJGHC(bool AODONKKHPBP)
	{
		_003CJNEENGGKDFH_003Ek__BackingField = AODONKKHPBP;
	}

	protected virtual void HEFPEPJKINN(int JIIGOACEIKL)
	{
		CommonReferences.GGFJGHHHEJC.OnUnlocked(JIIGOACEIKL, contentLockID);
		CommonReferences.MNFMOEKMJKN().contentUnlocked.Add(contentLockID);
		BEJMLJNHPDD(AODONKKHPBP: false);
	}

	protected virtual void HKKDEKIFPPJ()
	{
		ContentLocksManager.KFAKFGHHIGA(this);
	}

	public virtual void FFHGOEBJAAE()
	{
		CommonReferences.MNFMOEKMJKN().contentUnlocked.Add(contentLockID);
		JIDLNNAGKMH(AODONKKHPBP: false);
	}

	public void OOOPMJBKHNJ()
	{
		if (!((Object)(object)lockParent == (Object)null))
		{
			Debug.Log((object)"Can't find Seat");
			lockParent.SetActive(true);
		}
	}

	protected virtual void EMIAIANJEFM(int JIIGOACEIKL)
	{
		CommonReferences.GGFJGHHHEJC.OnUnlocked(JIIGOACEIKL, contentLockID);
		CommonReferences.GGFJGHHHEJC.contentUnlocked.Add(contentLockID);
		OOAIFPMBOFF(AODONKKHPBP: true);
	}

	public virtual void PCJEIIADLCH()
	{
		CommonReferences.MNFMOEKMJKN().contentUnlocked.Add(contentLockID);
		PDEDKDLJGHC(AODONKKHPBP: true);
	}

	[SpecialName]
	public bool KCOHJCABNON()
	{
		return _003CJNEENGGKDFH_003Ek__BackingField;
	}

	[SpecialName]
	public bool LGDKBOJBFIO()
	{
		return _003CJNEENGGKDFH_003Ek__BackingField;
	}

	protected virtual void LAKAMCEKHPI(int JIIGOACEIKL)
	{
		CommonReferences.GGFJGHHHEJC.OnUnlocked(JIIGOACEIKL, contentLockID);
		CommonReferences.GGFJGHHHEJC.contentUnlocked.Add(contentLockID);
		PFAPICAIEFB = true;
	}

	protected virtual void AELGMOBKCOD(int JIIGOACEIKL)
	{
		CommonReferences.GGFJGHHHEJC.OnUnlocked(JIIGOACEIKL, contentLockID);
		CommonReferences.GGFJGHHHEJC.contentUnlocked.Add(contentLockID);
		PDEDKDLJGHC(AODONKKHPBP: true);
	}

	[SpecialName]
	private void BKJACOFMECH(bool AODONKKHPBP)
	{
		_003CJNEENGGKDFH_003Ek__BackingField = AODONKKHPBP;
	}

	protected virtual void NKDFMFFDGKC()
	{
		ContentLocksManager.EAMONNGOOBN(this);
	}

	protected virtual void LOHAMDHOLDD()
	{
		ContentLocksManager.ACKHEKJBKMM(this);
	}

	public virtual void GDJBKPCBIAH()
	{
		CommonReferences.MNFMOEKMJKN().contentUnlocked.Add(contentLockID);
		NBKEHLKGOHC(AODONKKHPBP: false);
	}

	protected virtual void FCGMLNHEKFP(int JIIGOACEIKL)
	{
		CommonReferences.MNFMOEKMJKN().OnUnlocked(JIIGOACEIKL, contentLockID);
		CommonReferences.MNFMOEKMJKN().contentUnlocked.Add(contentLockID);
		FDBBNIECMJH(AODONKKHPBP: false);
	}

	public virtual void BBHPOBMNIDB()
	{
		CommonReferences.MNFMOEKMJKN().contentUnlocked.Add(contentLockID);
		CEJBJJLOKHP(AODONKKHPBP: true);
	}

	[SpecialName]
	public bool NKIMAMAEJAG()
	{
		return _003CJNEENGGKDFH_003Ek__BackingField;
	}

	protected virtual void DCKKIDMJKJM()
	{
		ContentLocksManager.KFAKFGHHIGA(this);
	}

	public virtual void KMGOGLFKDMC()
	{
		CommonReferences.GGFJGHHHEJC.contentUnlocked.Add(contentLockID);
		FDBBNIECMJH(AODONKKHPBP: true);
	}

	protected virtual void HJDLNCOAKIK()
	{
		ContentLocksManager.BAGBAPOEOHO(this);
	}

	protected virtual void GOEGBOEMHLI()
	{
		ContentLocksManager.DLKGEHNHFEJ(this);
	}

	protected virtual void BNIKICAEIND()
	{
		ContentLocksManager.CMKLCOFCDGG(this);
	}

	protected virtual void JOPDHKAKHDH(int JIIGOACEIKL)
	{
		CommonReferences.MNFMOEKMJKN().OnUnlocked(JIIGOACEIKL, contentLockID);
		CommonReferences.GGFJGHHHEJC.contentUnlocked.Add(contentLockID);
		CJAPPCCDHEP(AODONKKHPBP: false);
	}

	public virtual void JDDKEPNIOED()
	{
		CommonReferences.GGFJGHHHEJC.contentUnlocked.Add(contentLockID);
		PKAFMMGDLJD(AODONKKHPBP: false);
	}

	protected virtual void DOHLOJOIHFO()
	{
		ContentLocksManager.GPOICIBCONJ(this);
	}

	public virtual void JOMPCCAHCML()
	{
		CommonReferences.MNFMOEKMJKN().contentUnlocked.Add(contentLockID);
		OOAIFPMBOFF(AODONKKHPBP: true);
	}

	public virtual void ADAEBAINBDN()
	{
		CommonReferences.GGFJGHHHEJC.contentUnlocked.Add(contentLockID);
		CJAPPCCDHEP(AODONKKHPBP: false);
	}

	[SpecialName]
	public bool MLDEMOCMCIC()
	{
		return _003CJNEENGGKDFH_003Ek__BackingField;
	}

	protected virtual void KBGNNHFCLBG(int JIIGOACEIKL)
	{
		CommonReferences.GGFJGHHHEJC.OnUnlocked(JIIGOACEIKL, contentLockID);
		CommonReferences.MNFMOEKMJKN().contentUnlocked.Add(contentLockID);
		BEJMLJNHPDD(AODONKKHPBP: false);
	}

	public void FONEBLBFMEK()
	{
		if (!((Object)(object)lockParent == (Object)null))
		{
			Debug.Log((object)"ReceiveTavernEventsLoad");
			lockParent.SetActive(true);
		}
	}

	[SpecialName]
	public bool ALPPFKGFMGI()
	{
		return _003CJNEENGGKDFH_003Ek__BackingField;
	}

	public void CKJFJLNIMLA()
	{
		if (!((Object)(object)lockParent == (Object)null))
		{
			Debug.Log((object)"BLOCKS NUMBER: {0} Puzzle Needit: {1}");
			lockParent.SetActive(true);
		}
	}

	protected virtual void NEIGMKNPHAN(int JIIGOACEIKL)
	{
		CommonReferences.MNFMOEKMJKN().OnUnlocked(JIIGOACEIKL, contentLockID);
		CommonReferences.MNFMOEKMJKN().contentUnlocked.Add(contentLockID);
		FDBBNIECMJH(AODONKKHPBP: false);
	}

	protected virtual void HOFKJPBBLGP()
	{
		ContentLocksManager.DPODMMJPPLM(this);
	}

	protected virtual void FJDKNGFJNBC(int JIIGOACEIKL)
	{
		CommonReferences.GGFJGHHHEJC.OnUnlocked(JIIGOACEIKL, contentLockID);
		CommonReferences.GGFJGHHHEJC.contentUnlocked.Add(contentLockID);
		MILACHLIPFH(AODONKKHPBP: false);
	}

	[SpecialName]
	private void MILACHLIPFH(bool AODONKKHPBP)
	{
		_003CJNEENGGKDFH_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	public bool CLADLHOEIHE()
	{
		return _003CJNEENGGKDFH_003Ek__BackingField;
	}

	[SpecialName]
	public bool JNMFGGGCNII()
	{
		return _003CJNEENGGKDFH_003Ek__BackingField;
	}

	protected virtual void JCGHAFCFPIC(int JIIGOACEIKL)
	{
		CommonReferences.MNFMOEKMJKN().OnUnlocked(JIIGOACEIKL, contentLockID);
		CommonReferences.GGFJGHHHEJC.contentUnlocked.Add(contentLockID);
		JCGECJCHBJJ(AODONKKHPBP: false);
	}

	public virtual void HNMEDOCGHJM()
	{
		CommonReferences.GGFJGHHHEJC.contentUnlocked.Add(contentLockID);
		BKJACOFMECH(AODONKKHPBP: false);
	}

	public virtual void OMIMOMCOHNN()
	{
		CommonReferences.GGFJGHHHEJC.contentUnlocked.Add(contentLockID);
		OIENGGKEOGB(AODONKKHPBP: true);
	}

	[SpecialName]
	private void CEJBJJLOKHP(bool AODONKKHPBP)
	{
		_003CJNEENGGKDFH_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	private void BEJMLJNHPDD(bool AODONKKHPBP)
	{
		_003CJNEENGGKDFH_003Ek__BackingField = AODONKKHPBP;
	}

	public virtual void EDCLGHHOBDI()
	{
		CommonReferences.GGFJGHHHEJC.contentUnlocked.Add(contentLockID);
		BEJMLJNHPDD(AODONKKHPBP: false);
	}

	[SpecialName]
	public bool NODLBNNFFKI()
	{
		return _003CJNEENGGKDFH_003Ek__BackingField;
	}

	public virtual void IFNAOOJIKNH()
	{
		CommonReferences.MNFMOEKMJKN().contentUnlocked.Add(contentLockID);
		BEJMLJNHPDD(AODONKKHPBP: true);
	}

	protected virtual void JFKGOFIGGHB(int JIIGOACEIKL)
	{
		CommonReferences.GGFJGHHHEJC.OnUnlocked(JIIGOACEIKL, contentLockID);
		CommonReferences.MNFMOEKMJKN().contentUnlocked.Add(contentLockID);
		PFAPICAIEFB = true;
	}
}
