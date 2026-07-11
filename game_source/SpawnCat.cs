using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SpawnCat : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class CILNMENEHFN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SpawnCat _003C_003E4__this;

		public int relationship;

		public int catSelectedId;

		public string catName;

		public GameDate birthday;

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
		public CILNMENEHFN(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			SpawnCat spawnCat = _003C_003E4__this;
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
				if ((Object)(object)spawnCat.catNPC == (Object)null)
				{
					spawnCat.catNPC = Object.Instantiate<GameObject>(spawnCat.catPrefab, ((Component)spawnCat).transform.position, Quaternion.identity).GetComponent<CatNPC>();
					spawnCat.catNPC.relationshipSystem.SetRelationship(relationship);
					if (VersionNumberManager.IsAnOlderVersion(GameManager.GGFJGHHHEJC.HEJPPEJMPFE.HIMELJEPBDP(), VersionNumberManager.instance.NCMFFHEANML))
					{
						PetSelectorUI.GGFJGHHHEJC.Open(1);
					}
					CommonReferences.GGFJGHHHEJC.catSelected = CharacterSpritesDBAccessor.GetCat(catSelectedId);
					CommonReferences.GGFJGHHHEJC.catName = catName;
					spawnCat.catNPC.birthday = birthday;
					if ((Object)(object)CommonReferences.GGFJGHHHEJC.catSelected == (Object)null)
					{
						Debug.Log((object)("Cat with id " + catSelectedId + " not found"));
					}
					spawnCat.ChangeCatSkin();
					spawnCat.catNPC.TeleToBed();
				}
				else
				{
					Debug.LogError((object)"CatNPC already exists");
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

	private static SpawnCat IADEMLIIDPC;

	public GameObject catPrefab;

	public CatNPC catNPC;

	public static SpawnCat GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<SpawnCat>();
			}
			return IADEMLIIDPC;
		}
	}

	private void DKDLOBOLNFH()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	public void KFDMNBKLADK()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNPC == (Object)null)
		{
			Object.Instantiate<GameObject>(catPrefab, ((Component)TravelZonesManager.EKDNJDJHONF().NKEBECDKDOO(Location.Tavern, Location.None)).transform.position, Quaternion.identity).GetComponent<CatNPC>().Spawn();
		}
	}

	private IEnumerator NAMKBBDIHDO(int IHNEJFGAENM, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDate GDNLNDKBLJJ)
	{
		yield return null;
		if ((Object)(object)catNPC == (Object)null)
		{
			catNPC = Object.Instantiate<GameObject>(catPrefab, ((Component)this).transform.position, Quaternion.identity).GetComponent<CatNPC>();
			catNPC.relationshipSystem.SetRelationship(IHNEJFGAENM);
			if (VersionNumberManager.IsAnOlderVersion(GameManager.GGFJGHHHEJC.HEJPPEJMPFE.HIMELJEPBDP(), VersionNumberManager.instance.NCMFFHEANML))
			{
				PetSelectorUI.GGFJGHHHEJC.Open(1);
			}
			CommonReferences.GGFJGHHHEJC.catSelected = CharacterSpritesDBAccessor.GetCat(OAEMGBKKPHJ);
			CommonReferences.GGFJGHHHEJC.catName = HAKDHLOOCOE;
			catNPC.birthday = GDNLNDKBLJJ;
			if ((Object)(object)CommonReferences.GGFJGHHHEJC.catSelected == (Object)null)
			{
				Debug.Log((object)("Cat with id " + OAEMGBKKPHJ + " not found"));
			}
			ChangeCatSkin();
			catNPC.TeleToBed();
		}
		else
		{
			Debug.LogError((object)"CatNPC already exists");
		}
	}

	public void MFEJHNEFAJA()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNPC == (Object)null)
		{
			Object.Instantiate<GameObject>(catPrefab, ((Component)TravelZonesManager.OMFKNGDCJFN().OFIPCMMKFLP(Location.Tavern, Location.Tavern | Location.Road)).transform.position, Quaternion.identity).GetComponent<CatNPC>().Spawn();
		}
	}

	public void GMAALHIOGCO()
	{
		catNPC.catAnimator.KBNJNEJLCNG(CommonReferences.GGFJGHHHEJC.catSelected);
	}

	private IEnumerator FOKHMBENMDG(int IHNEJFGAENM, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDate GDNLNDKBLJJ)
	{
		return new CILNMENEHFN(1)
		{
			_003C_003E4__this = this,
			relationship = IHNEJFGAENM,
			catSelectedId = OAEMGBKKPHJ,
			catName = HAKDHLOOCOE,
			birthday = GDNLNDKBLJJ
		};
	}

	private void NMKGOAJLMDG()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	[SpecialName]
	public static SpawnCat CHPEMJMLDCN()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<SpawnCat>();
		}
		return IADEMLIIDPC;
	}

	public void NCACKLLINFC(int IHNEJFGAENM, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDate GDNLNDKBLJJ)
	{
		((MonoBehaviour)this).StartCoroutine(BICGJCANDOK(IHNEJFGAENM, OAEMGBKKPHJ, HAKDHLOOCOE, GDNLNDKBLJJ));
	}

	public CatNPC GNEJBNJKFDG(int PKOLNKCGANA, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDateMessage GDNLNDKBLJJ)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		catNPC = Object.Instantiate<GameObject>(catPrefab, ((Component)this).transform.position, Quaternion.identity).GetComponent<CatNPC>();
		catNPC.relationshipSystem.DJMJKDKNOCN(PKOLNKCGANA);
		CommonReferences.MNFMOEKMJKN().catSelected = CharacterSpritesDBAccessor.BECKFCECOIO(OAEMGBKKPHJ);
		CommonReferences.MNFMOEKMJKN().catName = HAKDHLOOCOE;
		catNPC.birthday = GDNLNDKBLJJ.OBDEGHJAFMP();
		CMCHMLADCPO();
		return catNPC;
	}

	public void FDLPKBHMMPN(int IHNEJFGAENM, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDate GDNLNDKBLJJ)
	{
		((MonoBehaviour)this).StartCoroutine(KLCKGJBDOGD(IHNEJFGAENM, OAEMGBKKPHJ, HAKDHLOOCOE, GDNLNDKBLJJ));
	}

	[SpecialName]
	public static SpawnCat CMIHGBHPLFP()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<SpawnCat>();
		}
		return IADEMLIIDPC;
	}

	public void CCAENOCHIBA()
	{
		catNPC.catAnimator.FGEHAEGDLDO(CommonReferences.GGFJGHHHEJC.catSelected);
	}

	private IEnumerator PKPDGCCMILM(int IHNEJFGAENM, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDate GDNLNDKBLJJ)
	{
		yield return null;
		if ((Object)(object)catNPC == (Object)null)
		{
			catNPC = Object.Instantiate<GameObject>(catPrefab, ((Component)this).transform.position, Quaternion.identity).GetComponent<CatNPC>();
			catNPC.relationshipSystem.SetRelationship(IHNEJFGAENM);
			if (VersionNumberManager.IsAnOlderVersion(GameManager.GGFJGHHHEJC.HEJPPEJMPFE.HIMELJEPBDP(), VersionNumberManager.instance.NCMFFHEANML))
			{
				PetSelectorUI.GGFJGHHHEJC.Open(1);
			}
			CommonReferences.GGFJGHHHEJC.catSelected = CharacterSpritesDBAccessor.GetCat(OAEMGBKKPHJ);
			CommonReferences.GGFJGHHHEJC.catName = HAKDHLOOCOE;
			catNPC.birthday = GDNLNDKBLJJ;
			if ((Object)(object)CommonReferences.GGFJGHHHEJC.catSelected == (Object)null)
			{
				Debug.Log((object)("Cat with id " + OAEMGBKKPHJ + " not found"));
			}
			ChangeCatSkin();
			catNPC.TeleToBed();
		}
		else
		{
			Debug.LogError((object)"CatNPC already exists");
		}
	}

	[SpecialName]
	public static SpawnCat LPFNKEOJJKE()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<SpawnCat>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static SpawnCat AJIGOHGPFPP()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<SpawnCat>();
		}
		return IADEMLIIDPC;
	}

	public void CLGGFJEOOFI()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNPC == (Object)null)
		{
			Object.Instantiate<GameObject>(catPrefab, ((Component)TravelZonesManager.OLHBLKIAFOM().NKEBECDKDOO(Location.Tavern, Location.Tavern | Location.Road)).transform.position, Quaternion.identity).GetComponent<CatNPC>().Spawn();
		}
	}

	public void ALNKBPOCPMC()
	{
		catNPC.catAnimator.EJBLHEGMJHA(CommonReferences.MNFMOEKMJKN().catSelected);
	}

	public CatNPC AIGPKHOIJOJ(int PKOLNKCGANA, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDateMessage GDNLNDKBLJJ)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		catNPC = Object.Instantiate<GameObject>(catPrefab, ((Component)this).transform.position, Quaternion.identity).GetComponent<CatNPC>();
		catNPC.relationshipSystem.BHJFKDOEPMI(PKOLNKCGANA);
		CommonReferences.GGFJGHHHEJC.catSelected = CharacterSpritesDBAccessor.AKHOCHCEHJA(OAEMGBKKPHJ);
		CommonReferences.MNFMOEKMJKN().catName = HAKDHLOOCOE;
		catNPC.birthday = GDNLNDKBLJJ.MMJLIGKGHEP();
		HANHFKAGMPN();
		return catNPC;
	}

	public void ONKHPDKMPJJ()
	{
		catNPC.catAnimator.EJBLHEGMJHA(CommonReferences.MNFMOEKMJKN().catSelected);
	}

	public void NPCFOFLEFLM()
	{
		if ((Object)(object)catNPC == (Object)null)
		{
			PetSelectorUI.JHKLPLPBKCI().OFGKFMJKBON(1);
		}
	}

	public void MCNEFHLPKMM(int IHNEJFGAENM, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDate GDNLNDKBLJJ)
	{
		((MonoBehaviour)this).StartCoroutine(PKPDGCCMILM(IHNEJFGAENM, OAEMGBKKPHJ, HAKDHLOOCOE, GDNLNDKBLJJ));
	}

	private IEnumerator OJDGEFMFPBE(int IHNEJFGAENM, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDate GDNLNDKBLJJ)
	{
		yield return null;
		if ((Object)(object)catNPC == (Object)null)
		{
			catNPC = Object.Instantiate<GameObject>(catPrefab, ((Component)this).transform.position, Quaternion.identity).GetComponent<CatNPC>();
			catNPC.relationshipSystem.SetRelationship(IHNEJFGAENM);
			if (VersionNumberManager.IsAnOlderVersion(GameManager.GGFJGHHHEJC.HEJPPEJMPFE.HIMELJEPBDP(), VersionNumberManager.instance.NCMFFHEANML))
			{
				PetSelectorUI.GGFJGHHHEJC.Open(1);
			}
			CommonReferences.GGFJGHHHEJC.catSelected = CharacterSpritesDBAccessor.GetCat(OAEMGBKKPHJ);
			CommonReferences.GGFJGHHHEJC.catName = HAKDHLOOCOE;
			catNPC.birthday = GDNLNDKBLJJ;
			if ((Object)(object)CommonReferences.GGFJGHHHEJC.catSelected == (Object)null)
			{
				Debug.Log((object)("Cat with id " + OAEMGBKKPHJ + " not found"));
			}
			ChangeCatSkin();
			catNPC.TeleToBed();
		}
		else
		{
			Debug.LogError((object)"CatNPC already exists");
		}
	}

	public void GNFIKBNDDKF()
	{
		catNPC.catAnimator.CMLFLAJLGDH(CommonReferences.MNFMOEKMJKN().catSelected);
	}

	public void NOLNHCLNAAA()
	{
		catNPC.catAnimator.CMLFLAJLGDH(CommonReferences.MNFMOEKMJKN().catSelected);
	}

	[SpecialName]
	public static SpawnCat DIHCEGINELM()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<SpawnCat>();
		}
		return IADEMLIIDPC;
	}

	public void DAMMBBBJCCF()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNPC == (Object)null)
		{
			Object.Instantiate<GameObject>(catPrefab, ((Component)TravelZonesManager.OACNNJCLEDE().ECFDFECLDFK(Location.Tavern, Location.Road)).transform.position, Quaternion.identity).GetComponent<CatNPC>().Spawn();
		}
	}

	public void CheckCatShouldSpawn()
	{
		if ((Object)(object)catNPC == (Object)null)
		{
			PetSelectorUI.GGFJGHHHEJC.Open(1);
		}
	}

	public void HBLJAKNBGFN()
	{
		catNPC.catAnimator.FGEHAEGDLDO(CommonReferences.MNFMOEKMJKN().catSelected);
	}

	private void EHBMONGBJFI()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	public void DJIMJBOMEKK()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNPC == (Object)null)
		{
			Object.Instantiate<GameObject>(catPrefab, ((Component)TravelZonesManager.OMFKNGDCJFN().KCJMDAPPJLB(Location.None, Location.Tavern | Location.Road)).transform.position, Quaternion.identity).GetComponent<CatNPC>().Spawn();
		}
	}

	public void IFLMOLKHHEF()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNPC == (Object)null)
		{
			Object.Instantiate<GameObject>(catPrefab, ((Component)TravelZonesManager.BGMJCCFNNDL().JKPNCIFMAOO(Location.None, Location.Camp)).transform.position, Quaternion.identity).GetComponent<CatNPC>().Spawn();
		}
	}

	public void DKGLNHNLHKI(int IHNEJFGAENM, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDate GDNLNDKBLJJ)
	{
		((MonoBehaviour)this).StartCoroutine(NAMKBBDIHDO(IHNEJFGAENM, OAEMGBKKPHJ, HAKDHLOOCOE, GDNLNDKBLJJ));
	}

	public void OHEIIMECJLE()
	{
		if ((Object)(object)catNPC == (Object)null)
		{
			PetSelectorUI.FOPGLLMEEDE().Open(0);
		}
	}

	private IEnumerator FBOLOBPNBKA(int IHNEJFGAENM, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDate GDNLNDKBLJJ)
	{
		yield return null;
		if ((Object)(object)catNPC == (Object)null)
		{
			catNPC = Object.Instantiate<GameObject>(catPrefab, ((Component)this).transform.position, Quaternion.identity).GetComponent<CatNPC>();
			catNPC.relationshipSystem.SetRelationship(IHNEJFGAENM);
			if (VersionNumberManager.IsAnOlderVersion(GameManager.GGFJGHHHEJC.HEJPPEJMPFE.HIMELJEPBDP(), VersionNumberManager.instance.NCMFFHEANML))
			{
				PetSelectorUI.GGFJGHHHEJC.Open(1);
			}
			CommonReferences.GGFJGHHHEJC.catSelected = CharacterSpritesDBAccessor.GetCat(OAEMGBKKPHJ);
			CommonReferences.GGFJGHHHEJC.catName = HAKDHLOOCOE;
			catNPC.birthday = GDNLNDKBLJJ;
			if ((Object)(object)CommonReferences.GGFJGHHHEJC.catSelected == (Object)null)
			{
				Debug.Log((object)("Cat with id " + OAEMGBKKPHJ + " not found"));
			}
			ChangeCatSkin();
			catNPC.TeleToBed();
		}
		else
		{
			Debug.LogError((object)"CatNPC already exists");
		}
	}

	public CatNPC CDPCCKKNIPO(int PKOLNKCGANA, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDateMessage GDNLNDKBLJJ)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		catNPC = Object.Instantiate<GameObject>(catPrefab, ((Component)this).transform.position, Quaternion.identity).GetComponent<CatNPC>();
		catNPC.relationshipSystem.HFBBJEINEFD(PKOLNKCGANA);
		CommonReferences.MNFMOEKMJKN().catSelected = CharacterSpritesDBAccessor.CGNHGMGEJJG(OAEMGBKKPHJ);
		CommonReferences.GGFJGHHHEJC.catName = HAKDHLOOCOE;
		catNPC.birthday = GDNLNDKBLJJ.HCOKPDPOCEP();
		DJEKOGPBFBI();
		return catNPC;
	}

	private IEnumerator KLCKGJBDOGD(int IHNEJFGAENM, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDate GDNLNDKBLJJ)
	{
		return new CILNMENEHFN(1)
		{
			_003C_003E4__this = this,
			relationship = IHNEJFGAENM,
			catSelectedId = OAEMGBKKPHJ,
			catName = HAKDHLOOCOE,
			birthday = GDNLNDKBLJJ
		};
	}

	public void PGCOFPBLHPL(int IHNEJFGAENM, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDate GDNLNDKBLJJ)
	{
		((MonoBehaviour)this).StartCoroutine(OJDGEFMFPBE(IHNEJFGAENM, OAEMGBKKPHJ, HAKDHLOOCOE, GDNLNDKBLJJ));
	}

	public void MMPLEFFMKDC()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNPC == (Object)null)
		{
			Object.Instantiate<GameObject>(catPrefab, ((Component)TravelZonesManager.GFMBEDCANNI().ECFDFECLDFK(Location.Tavern, Location.None)).transform.position, Quaternion.identity).GetComponent<CatNPC>().Spawn();
		}
	}

	public void CGLJCBGOHHA()
	{
		if ((Object)(object)catNPC == (Object)null)
		{
			PetSelectorUI.CMIHGBHPLFP().OFGKFMJKBON(0);
		}
	}

	public void ChangeCatSkin()
	{
		catNPC.catAnimator.ChangeCatSkin(CommonReferences.GGFJGHHHEJC.catSelected);
	}

	public CatNPC PABJAAADAKH(int PKOLNKCGANA, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDateMessage GDNLNDKBLJJ)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		catNPC = Object.Instantiate<GameObject>(catPrefab, ((Component)this).transform.position, Quaternion.identity).GetComponent<CatNPC>();
		catNPC.relationshipSystem.PANPFMABIFI(PKOLNKCGANA);
		CommonReferences.GGFJGHHHEJC.catSelected = CharacterSpritesDBAccessor.EKILDJBNOEP(OAEMGBKKPHJ);
		CommonReferences.MNFMOEKMJKN().catName = HAKDHLOOCOE;
		catNPC.birthday = GDNLNDKBLJJ.JBJLBDHAECK();
		HANHFKAGMPN();
		return catNPC;
	}

	public CatNPC CHLBIFABDBM(int PKOLNKCGANA, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDateMessage GDNLNDKBLJJ)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		catNPC = Object.Instantiate<GameObject>(catPrefab, ((Component)this).transform.position, Quaternion.identity).GetComponent<CatNPC>();
		catNPC.relationshipSystem.CAIPEIKACIH(PKOLNKCGANA);
		CommonReferences.GGFJGHHHEJC.catSelected = CharacterSpritesDBAccessor.CGNHGMGEJJG(OAEMGBKKPHJ);
		CommonReferences.MNFMOEKMJKN().catName = HAKDHLOOCOE;
		catNPC.birthday = GDNLNDKBLJJ.MDNGEDNDOEK();
		CMCHMLADCPO();
		return catNPC;
	}

	public void ELPIOMBADJG()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNPC == (Object)null)
		{
			Object.Instantiate<GameObject>(catPrefab, ((Component)TravelZonesManager.OACNNJCLEDE().OFIPCMMKFLP(Location.None, Location.Road | Location.River)).transform.position, Quaternion.identity).GetComponent<CatNPC>().Spawn();
		}
	}

	public CatNPC JPKFBABFPII(int PKOLNKCGANA, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDateMessage GDNLNDKBLJJ)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		catNPC = Object.Instantiate<GameObject>(catPrefab, ((Component)this).transform.position, Quaternion.identity).GetComponent<CatNPC>();
		catNPC.relationshipSystem.JNKKKBPMCIK(PKOLNKCGANA);
		CommonReferences.GGFJGHHHEJC.catSelected = CharacterSpritesDBAccessor.AKHOCHCEHJA(OAEMGBKKPHJ);
		CommonReferences.GGFJGHHHEJC.catName = HAKDHLOOCOE;
		catNPC.birthday = GDNLNDKBLJJ.JBJLBDHAECK();
		GMAALHIOGCO();
		return catNPC;
	}

	public CatNPC IAMNBGMPLCF(int PKOLNKCGANA, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDateMessage GDNLNDKBLJJ)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		catNPC = Object.Instantiate<GameObject>(catPrefab, ((Component)this).transform.position, Quaternion.identity).GetComponent<CatNPC>();
		catNPC.relationshipSystem.SetRelationship(PKOLNKCGANA);
		CommonReferences.MNFMOEKMJKN().catSelected = CharacterSpritesDBAccessor.BECKFCECOIO(OAEMGBKKPHJ);
		CommonReferences.MNFMOEKMJKN().catName = HAKDHLOOCOE;
		catNPC.birthday = GDNLNDKBLJJ.AMFMLHHCLHA();
		OKDOCELPLDF();
		return catNPC;
	}

	[SpecialName]
	public static SpawnCat ELGNEJNLBNO()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<SpawnCat>();
		}
		return IADEMLIIDPC;
	}

	private IEnumerator OPCBODJMPGB(int IHNEJFGAENM, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDate GDNLNDKBLJJ)
	{
		return new CILNMENEHFN(1)
		{
			_003C_003E4__this = this,
			relationship = IHNEJFGAENM,
			catSelectedId = OAEMGBKKPHJ,
			catName = HAKDHLOOCOE,
			birthday = GDNLNDKBLJJ
		};
	}

	public CatNPC NPBIJBFEBEK(int PKOLNKCGANA, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDateMessage GDNLNDKBLJJ)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		catNPC = Object.Instantiate<GameObject>(catPrefab, ((Component)this).transform.position, Quaternion.identity).GetComponent<CatNPC>();
		catNPC.relationshipSystem.MAFKPAOCIEO(PKOLNKCGANA);
		CommonReferences.MNFMOEKMJKN().catSelected = CharacterSpritesDBAccessor.AKHOCHCEHJA(OAEMGBKKPHJ);
		CommonReferences.GGFJGHHHEJC.catName = HAKDHLOOCOE;
		catNPC.birthday = GDNLNDKBLJJ.MMJLIGKGHEP();
		HANHFKAGMPN();
		return catNPC;
	}

	private void JDMMNLKLMAA()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	public void LPNDDKOAFIL()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNPC == (Object)null)
		{
			Object.Instantiate<GameObject>(catPrefab, ((Component)TravelZonesManager.CFHEJAGKIII().DAOACOMANPN(Location.None, Location.Tavern | Location.River)).transform.position, Quaternion.identity).GetComponent<CatNPC>().Spawn();
		}
	}

	public void NNAFLFFALAJ(int IHNEJFGAENM, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDate GDNLNDKBLJJ)
	{
		((MonoBehaviour)this).StartCoroutine(FOFCKLLOAFN(IHNEJFGAENM, OAEMGBKKPHJ, HAKDHLOOCOE, GDNLNDKBLJJ));
	}

	public CatNPC InstantiateOnlineCat(int PKOLNKCGANA, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDateMessage GDNLNDKBLJJ)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		catNPC = Object.Instantiate<GameObject>(catPrefab, ((Component)this).transform.position, Quaternion.identity).GetComponent<CatNPC>();
		catNPC.relationshipSystem.SetRelationship(PKOLNKCGANA);
		CommonReferences.GGFJGHHHEJC.catSelected = CharacterSpritesDBAccessor.GetCat(OAEMGBKKPHJ);
		CommonReferences.GGFJGHHHEJC.catName = HAKDHLOOCOE;
		catNPC.birthday = GDNLNDKBLJJ.JBJLBDHAECK();
		ChangeCatSkin();
		return catNPC;
	}

	public void InstantiateCatNextFrame(int IHNEJFGAENM, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDate GDNLNDKBLJJ)
	{
		((MonoBehaviour)this).StartCoroutine(FBOLOBPNBKA(IHNEJFGAENM, OAEMGBKKPHJ, HAKDHLOOCOE, GDNLNDKBLJJ));
	}

	private IEnumerator FOFCKLLOAFN(int IHNEJFGAENM, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDate GDNLNDKBLJJ)
	{
		yield return null;
		if ((Object)(object)catNPC == (Object)null)
		{
			catNPC = Object.Instantiate<GameObject>(catPrefab, ((Component)this).transform.position, Quaternion.identity).GetComponent<CatNPC>();
			catNPC.relationshipSystem.SetRelationship(IHNEJFGAENM);
			if (VersionNumberManager.IsAnOlderVersion(GameManager.GGFJGHHHEJC.HEJPPEJMPFE.HIMELJEPBDP(), VersionNumberManager.instance.NCMFFHEANML))
			{
				PetSelectorUI.GGFJGHHHEJC.Open(1);
			}
			CommonReferences.GGFJGHHHEJC.catSelected = CharacterSpritesDBAccessor.GetCat(OAEMGBKKPHJ);
			CommonReferences.GGFJGHHHEJC.catName = HAKDHLOOCOE;
			catNPC.birthday = GDNLNDKBLJJ;
			if ((Object)(object)CommonReferences.GGFJGHHHEJC.catSelected == (Object)null)
			{
				Debug.Log((object)("Cat with id " + OAEMGBKKPHJ + " not found"));
			}
			ChangeCatSkin();
			catNPC.TeleToBed();
		}
		else
		{
			Debug.LogError((object)"CatNPC already exists");
		}
	}

	public void PHLLGAFNAGF(int IHNEJFGAENM, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDate GDNLNDKBLJJ)
	{
		((MonoBehaviour)this).StartCoroutine(KFBCDJIPJIJ(IHNEJFGAENM, OAEMGBKKPHJ, HAKDHLOOCOE, GDNLNDKBLJJ));
	}

	private IEnumerator ANDKFBDIEBJ(int IHNEJFGAENM, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDate GDNLNDKBLJJ)
	{
		yield return null;
		if ((Object)(object)catNPC == (Object)null)
		{
			catNPC = Object.Instantiate<GameObject>(catPrefab, ((Component)this).transform.position, Quaternion.identity).GetComponent<CatNPC>();
			catNPC.relationshipSystem.SetRelationship(IHNEJFGAENM);
			if (VersionNumberManager.IsAnOlderVersion(GameManager.GGFJGHHHEJC.HEJPPEJMPFE.HIMELJEPBDP(), VersionNumberManager.instance.NCMFFHEANML))
			{
				PetSelectorUI.GGFJGHHHEJC.Open(1);
			}
			CommonReferences.GGFJGHHHEJC.catSelected = CharacterSpritesDBAccessor.GetCat(OAEMGBKKPHJ);
			CommonReferences.GGFJGHHHEJC.catName = HAKDHLOOCOE;
			catNPC.birthday = GDNLNDKBLJJ;
			if ((Object)(object)CommonReferences.GGFJGHHHEJC.catSelected == (Object)null)
			{
				Debug.Log((object)("Cat with id " + OAEMGBKKPHJ + " not found"));
			}
			ChangeCatSkin();
			catNPC.TeleToBed();
		}
		else
		{
			Debug.LogError((object)"CatNPC already exists");
		}
	}

	public void HANHFKAGMPN()
	{
		catNPC.catAnimator.EJBLHEGMJHA(CommonReferences.MNFMOEKMJKN().catSelected);
	}

	public void OKDOCELPLDF()
	{
		catNPC.catAnimator.EJBLHEGMJHA(CommonReferences.MNFMOEKMJKN().catSelected);
	}

	[SpecialName]
	public static SpawnCat NEFIEJALANL()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<SpawnCat>();
		}
		return IADEMLIIDPC;
	}

	private void MMNBJPDJHGK()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	private void GMCKBBECJOE()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	public void JFLFGIFJKOM()
	{
		catNPC.catAnimator.DNANKCOCPIC(CommonReferences.GGFJGHHHEJC.catSelected);
	}

	public void HBPGCAKHDAB()
	{
		if ((Object)(object)catNPC == (Object)null)
		{
			PetSelectorUI.KHMEGDIABBF().Open(1);
		}
	}

	private void PHJKJHKAABL()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	public void KJJOOAJHGFB()
	{
		if ((Object)(object)catNPC == (Object)null)
		{
			PetSelectorUI.JHKLPLPBKCI().Open(1);
		}
	}

	public CatNPC FKBNJNJDGNN(int PKOLNKCGANA, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDateMessage GDNLNDKBLJJ)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		catNPC = Object.Instantiate<GameObject>(catPrefab, ((Component)this).transform.position, Quaternion.identity).GetComponent<CatNPC>();
		catNPC.relationshipSystem.PANPFMABIFI(PKOLNKCGANA);
		CommonReferences.GGFJGHHHEJC.catSelected = CharacterSpritesDBAccessor.CGNHGMGEJJG(OAEMGBKKPHJ);
		CommonReferences.MNFMOEKMJKN().catName = HAKDHLOOCOE;
		catNPC.birthday = GDNLNDKBLJJ.DEICGCGAMJC();
		JFLFGIFJKOM();
		return catNPC;
	}

	public void JPMBOKEINOF(int IHNEJFGAENM, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDate GDNLNDKBLJJ)
	{
		((MonoBehaviour)this).StartCoroutine(OPCBODJMPGB(IHNEJFGAENM, OAEMGBKKPHJ, HAKDHLOOCOE, GDNLNDKBLJJ));
	}

	public void PGIKBBKAHDN()
	{
		if ((Object)(object)catNPC == (Object)null)
		{
			PetSelectorUI.GGFJGHHHEJC.OFGKFMJKBON(1);
		}
	}

	public void OPCLIOLOBIB()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNPC == (Object)null)
		{
			Object.Instantiate<GameObject>(catPrefab, ((Component)TravelZonesManager.GFMBEDCANNI().NKEBECDKDOO(Location.None, Location.None)).transform.position, Quaternion.identity).GetComponent<CatNPC>().Spawn();
		}
	}

	private void BODICIENBEH()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	public void CMCHMLADCPO()
	{
		catNPC.catAnimator.FGEHAEGDLDO(CommonReferences.MNFMOEKMJKN().catSelected);
	}

	public void HMDFONNDHCP(int IHNEJFGAENM, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDate GDNLNDKBLJJ)
	{
		((MonoBehaviour)this).StartCoroutine(OPCBODJMPGB(IHNEJFGAENM, OAEMGBKKPHJ, HAKDHLOOCOE, GDNLNDKBLJJ));
	}

	private IEnumerator NBEDGKJAPDD(int IHNEJFGAENM, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDate GDNLNDKBLJJ)
	{
		yield return null;
		if ((Object)(object)catNPC == (Object)null)
		{
			catNPC = Object.Instantiate<GameObject>(catPrefab, ((Component)this).transform.position, Quaternion.identity).GetComponent<CatNPC>();
			catNPC.relationshipSystem.SetRelationship(IHNEJFGAENM);
			if (VersionNumberManager.IsAnOlderVersion(GameManager.GGFJGHHHEJC.HEJPPEJMPFE.HIMELJEPBDP(), VersionNumberManager.instance.NCMFFHEANML))
			{
				PetSelectorUI.GGFJGHHHEJC.Open(1);
			}
			CommonReferences.GGFJGHHHEJC.catSelected = CharacterSpritesDBAccessor.GetCat(OAEMGBKKPHJ);
			CommonReferences.GGFJGHHHEJC.catName = HAKDHLOOCOE;
			catNPC.birthday = GDNLNDKBLJJ;
			if ((Object)(object)CommonReferences.GGFJGHHHEJC.catSelected == (Object)null)
			{
				Debug.Log((object)("Cat with id " + OAEMGBKKPHJ + " not found"));
			}
			ChangeCatSkin();
			catNPC.TeleToBed();
		}
		else
		{
			Debug.LogError((object)"CatNPC already exists");
		}
	}

	private IEnumerator IBKBBLDHOJN(int IHNEJFGAENM, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDate GDNLNDKBLJJ)
	{
		return new CILNMENEHFN(1)
		{
			_003C_003E4__this = this,
			relationship = IHNEJFGAENM,
			catSelectedId = OAEMGBKKPHJ,
			catName = HAKDHLOOCOE,
			birthday = GDNLNDKBLJJ
		};
	}

	private IEnumerator HCCDBDKKPHK(int IHNEJFGAENM, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDate GDNLNDKBLJJ)
	{
		return new CILNMENEHFN(1)
		{
			_003C_003E4__this = this,
			relationship = IHNEJFGAENM,
			catSelectedId = OAEMGBKKPHJ,
			catName = HAKDHLOOCOE,
			birthday = GDNLNDKBLJJ
		};
	}

	private IEnumerator EOHPKIOKKKH(int IHNEJFGAENM, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDate GDNLNDKBLJJ)
	{
		return new CILNMENEHFN(1)
		{
			_003C_003E4__this = this,
			relationship = IHNEJFGAENM,
			catSelectedId = OAEMGBKKPHJ,
			catName = HAKDHLOOCOE,
			birthday = GDNLNDKBLJJ
		};
	}

	public CatNPC CMPHEAOAICA(int PKOLNKCGANA, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDateMessage GDNLNDKBLJJ)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		catNPC = Object.Instantiate<GameObject>(catPrefab, ((Component)this).transform.position, Quaternion.identity).GetComponent<CatNPC>();
		catNPC.relationshipSystem.JBEAELDILAL(PKOLNKCGANA);
		CommonReferences.GGFJGHHHEJC.catSelected = CharacterSpritesDBAccessor.BHMJONKJKDK(OAEMGBKKPHJ);
		CommonReferences.MNFMOEKMJKN().catName = HAKDHLOOCOE;
		catNPC.birthday = GDNLNDKBLJJ.CGDNCJIAHHG();
		ONKHPDKMPJJ();
		return catNPC;
	}

	private void COKBJNMAMDI()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	public void MJOFNHKJGAF(int IHNEJFGAENM, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDate GDNLNDKBLJJ)
	{
		((MonoBehaviour)this).StartCoroutine(IBKBBLDHOJN(IHNEJFGAENM, OAEMGBKKPHJ, HAKDHLOOCOE, GDNLNDKBLJJ));
	}

	public void DJEKOGPBFBI()
	{
		catNPC.catAnimator.KBNJNEJLCNG(CommonReferences.GGFJGHHHEJC.catSelected);
	}

	private IEnumerator BEEMIHGAHJN(int IHNEJFGAENM, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDate GDNLNDKBLJJ)
	{
		yield return null;
		if ((Object)(object)catNPC == (Object)null)
		{
			catNPC = Object.Instantiate<GameObject>(catPrefab, ((Component)this).transform.position, Quaternion.identity).GetComponent<CatNPC>();
			catNPC.relationshipSystem.SetRelationship(IHNEJFGAENM);
			if (VersionNumberManager.IsAnOlderVersion(GameManager.GGFJGHHHEJC.HEJPPEJMPFE.HIMELJEPBDP(), VersionNumberManager.instance.NCMFFHEANML))
			{
				PetSelectorUI.GGFJGHHHEJC.Open(1);
			}
			CommonReferences.GGFJGHHHEJC.catSelected = CharacterSpritesDBAccessor.GetCat(OAEMGBKKPHJ);
			CommonReferences.GGFJGHHHEJC.catName = HAKDHLOOCOE;
			catNPC.birthday = GDNLNDKBLJJ;
			if ((Object)(object)CommonReferences.GGFJGHHHEJC.catSelected == (Object)null)
			{
				Debug.Log((object)("Cat with id " + OAEMGBKKPHJ + " not found"));
			}
			ChangeCatSkin();
			catNPC.TeleToBed();
		}
		else
		{
			Debug.LogError((object)"CatNPC already exists");
		}
	}

	public CatNPC FMABNLPJDKF(int PKOLNKCGANA, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDateMessage GDNLNDKBLJJ)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		catNPC = Object.Instantiate<GameObject>(catPrefab, ((Component)this).transform.position, Quaternion.identity).GetComponent<CatNPC>();
		catNPC.relationshipSystem.NMHKEGAOPAL(PKOLNKCGANA);
		CommonReferences.GGFJGHHHEJC.catSelected = CharacterSpritesDBAccessor.GetCat(OAEMGBKKPHJ);
		CommonReferences.MNFMOEKMJKN().catName = HAKDHLOOCOE;
		catNPC.birthday = GDNLNDKBLJJ.OBDEGHJAFMP();
		JIHKEEFCGJI();
		return catNPC;
	}

	public void EIAABGEGNFM()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNPC == (Object)null)
		{
			Object.Instantiate<GameObject>(catPrefab, ((Component)TravelZonesManager.LKOABOAADCD().IMKJEBFOBKK(Location.None, Location.Tavern)).transform.position, Quaternion.identity).GetComponent<CatNPC>().Spawn();
		}
	}

	private void IGNEGEOPLOP()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	public void CatSpawn()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNPC == (Object)null)
		{
			Object.Instantiate<GameObject>(catPrefab, ((Component)TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Tavern, Location.Road)).transform.position, Quaternion.identity).GetComponent<CatNPC>().Spawn();
		}
	}

	public void EJEOEOMABCL(int IHNEJFGAENM, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDate GDNLNDKBLJJ)
	{
		((MonoBehaviour)this).StartCoroutine(OPCBODJMPGB(IHNEJFGAENM, OAEMGBKKPHJ, HAKDHLOOCOE, GDNLNDKBLJJ));
	}

	public CatNPC JGLPGIFNOOL(int PKOLNKCGANA, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDateMessage GDNLNDKBLJJ)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		catNPC = Object.Instantiate<GameObject>(catPrefab, ((Component)this).transform.position, Quaternion.identity).GetComponent<CatNPC>();
		catNPC.relationshipSystem.MAFKPAOCIEO(PKOLNKCGANA);
		CommonReferences.MNFMOEKMJKN().catSelected = CharacterSpritesDBAccessor.GetCat(OAEMGBKKPHJ);
		CommonReferences.GGFJGHHHEJC.catName = HAKDHLOOCOE;
		catNPC.birthday = GDNLNDKBLJJ.OIIMNMKECAC();
		NOLNHCLNAAA();
		return catNPC;
	}

	public void ODIBLCHPBFN()
	{
		catNPC.catAnimator.CMLFLAJLGDH(CommonReferences.MNFMOEKMJKN().catSelected);
	}

	public CatNPC ECPBGMNHBNK(int PKOLNKCGANA, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDateMessage GDNLNDKBLJJ)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		catNPC = Object.Instantiate<GameObject>(catPrefab, ((Component)this).transform.position, Quaternion.identity).GetComponent<CatNPC>();
		catNPC.relationshipSystem.BHJFKDOEPMI(PKOLNKCGANA);
		CommonReferences.GGFJGHHHEJC.catSelected = CharacterSpritesDBAccessor.BECKFCECOIO(OAEMGBKKPHJ);
		CommonReferences.GGFJGHHHEJC.catName = HAKDHLOOCOE;
		catNPC.birthday = GDNLNDKBLJJ.OBDEGHJAFMP();
		OLGOALPFGEL();
		return catNPC;
	}

	private IEnumerator APDJGHENAFP(int IHNEJFGAENM, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDate GDNLNDKBLJJ)
	{
		return new CILNMENEHFN(1)
		{
			_003C_003E4__this = this,
			relationship = IHNEJFGAENM,
			catSelectedId = OAEMGBKKPHJ,
			catName = HAKDHLOOCOE,
			birthday = GDNLNDKBLJJ
		};
	}

	private IEnumerator BICGJCANDOK(int IHNEJFGAENM, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDate GDNLNDKBLJJ)
	{
		return new CILNMENEHFN(1)
		{
			_003C_003E4__this = this,
			relationship = IHNEJFGAENM,
			catSelectedId = OAEMGBKKPHJ,
			catName = HAKDHLOOCOE,
			birthday = GDNLNDKBLJJ
		};
	}

	[SpecialName]
	public static SpawnCat MKIEMMGGFEE()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<SpawnCat>();
		}
		return IADEMLIIDPC;
	}

	public void OLGOALPFGEL()
	{
		catNPC.catAnimator.IKFLGBPNLGE(CommonReferences.GGFJGHHHEJC.catSelected);
	}

	[SpecialName]
	public static SpawnCat KIALFDOKABP()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<SpawnCat>();
		}
		return IADEMLIIDPC;
	}

	private IEnumerator DPBFCOBEIKE(int IHNEJFGAENM, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDate GDNLNDKBLJJ)
	{
		yield return null;
		if ((Object)(object)catNPC == (Object)null)
		{
			catNPC = Object.Instantiate<GameObject>(catPrefab, ((Component)this).transform.position, Quaternion.identity).GetComponent<CatNPC>();
			catNPC.relationshipSystem.SetRelationship(IHNEJFGAENM);
			if (VersionNumberManager.IsAnOlderVersion(GameManager.GGFJGHHHEJC.HEJPPEJMPFE.HIMELJEPBDP(), VersionNumberManager.instance.NCMFFHEANML))
			{
				PetSelectorUI.GGFJGHHHEJC.Open(1);
			}
			CommonReferences.GGFJGHHHEJC.catSelected = CharacterSpritesDBAccessor.GetCat(OAEMGBKKPHJ);
			CommonReferences.GGFJGHHHEJC.catName = HAKDHLOOCOE;
			catNPC.birthday = GDNLNDKBLJJ;
			if ((Object)(object)CommonReferences.GGFJGHHHEJC.catSelected == (Object)null)
			{
				Debug.Log((object)("Cat with id " + OAEMGBKKPHJ + " not found"));
			}
			ChangeCatSkin();
			catNPC.TeleToBed();
		}
		else
		{
			Debug.LogError((object)"CatNPC already exists");
		}
	}

	public void LNIEDIMJBDJ()
	{
		if ((Object)(object)catNPC == (Object)null)
		{
			PetSelectorUI.FMIDAFEGDCD().OFGKFMJKBON(0);
		}
	}

	public CatNPC LLFBGOLJBMI(int PKOLNKCGANA, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDateMessage GDNLNDKBLJJ)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		catNPC = Object.Instantiate<GameObject>(catPrefab, ((Component)this).transform.position, Quaternion.identity).GetComponent<CatNPC>();
		catNPC.relationshipSystem.LGDONECCGLN(PKOLNKCGANA);
		CommonReferences.MNFMOEKMJKN().catSelected = CharacterSpritesDBAccessor.EKILDJBNOEP(OAEMGBKKPHJ);
		CommonReferences.GGFJGHHHEJC.catName = HAKDHLOOCOE;
		catNPC.birthday = GDNLNDKBLJJ.NFEMJJIGDKJ();
		HBLJAKNBGFN();
		return catNPC;
	}

	public void DCLIEFAADIL()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNPC == (Object)null)
		{
			Object.Instantiate<GameObject>(catPrefab, ((Component)TravelZonesManager.DGCNCEDIFOF().NKEBECDKDOO(Location.None, Location.Tavern)).transform.position, Quaternion.identity).GetComponent<CatNPC>().Spawn();
		}
	}

	[SpecialName]
	public static SpawnCat PNHHCHJCDNM()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<SpawnCat>();
		}
		return IADEMLIIDPC;
	}

	private void PDIECJCKCOD()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	public void MAPHDJOBBPN()
	{
		if ((Object)(object)catNPC == (Object)null)
		{
			PetSelectorUI.DBJCACLEFGK().Open(0);
		}
	}

	public void KBEEBNBODJK()
	{
		if ((Object)(object)catNPC == (Object)null)
		{
			PetSelectorUI.LDBJELPPBAI().Open(1);
		}
	}

	public void FOJIFMJKPMC(int IHNEJFGAENM, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDate GDNLNDKBLJJ)
	{
		((MonoBehaviour)this).StartCoroutine(IBKBBLDHOJN(IHNEJFGAENM, OAEMGBKKPHJ, HAKDHLOOCOE, GDNLNDKBLJJ));
	}

	private void CIICEKEJANM()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	public void AJLOJLJHMKK(int IHNEJFGAENM, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDate GDNLNDKBLJJ)
	{
		((MonoBehaviour)this).StartCoroutine(FOFCKLLOAFN(IHNEJFGAENM, OAEMGBKKPHJ, HAKDHLOOCOE, GDNLNDKBLJJ));
	}

	public void FKBGKBNJHJC()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNPC == (Object)null)
		{
			Object.Instantiate<GameObject>(catPrefab, ((Component)TravelZonesManager.CFHEJAGKIII().OFIPCMMKFLP(Location.Tavern, Location.Camp)).transform.position, Quaternion.identity).GetComponent<CatNPC>().Spawn();
		}
	}

	public void FGFPAHINHKC()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNPC == (Object)null)
		{
			Object.Instantiate<GameObject>(catPrefab, ((Component)TravelZonesManager.CFHEJAGKIII().KCJMDAPPJLB(Location.None, Location.Tavern)).transform.position, Quaternion.identity).GetComponent<CatNPC>().Spawn();
		}
	}

	public void OADEFKHBPAG(int IHNEJFGAENM, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDate GDNLNDKBLJJ)
	{
		((MonoBehaviour)this).StartCoroutine(FOFCKLLOAFN(IHNEJFGAENM, OAEMGBKKPHJ, HAKDHLOOCOE, GDNLNDKBLJJ));
	}

	private IEnumerator KFBCDJIPJIJ(int IHNEJFGAENM, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDate GDNLNDKBLJJ)
	{
		return new CILNMENEHFN(1)
		{
			_003C_003E4__this = this,
			relationship = IHNEJFGAENM,
			catSelectedId = OAEMGBKKPHJ,
			catName = HAKDHLOOCOE,
			birthday = GDNLNDKBLJJ
		};
	}

	private IEnumerator JEKGJBPEAEH(int IHNEJFGAENM, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDate GDNLNDKBLJJ)
	{
		yield return null;
		if ((Object)(object)catNPC == (Object)null)
		{
			catNPC = Object.Instantiate<GameObject>(catPrefab, ((Component)this).transform.position, Quaternion.identity).GetComponent<CatNPC>();
			catNPC.relationshipSystem.SetRelationship(IHNEJFGAENM);
			if (VersionNumberManager.IsAnOlderVersion(GameManager.GGFJGHHHEJC.HEJPPEJMPFE.HIMELJEPBDP(), VersionNumberManager.instance.NCMFFHEANML))
			{
				PetSelectorUI.GGFJGHHHEJC.Open(1);
			}
			CommonReferences.GGFJGHHHEJC.catSelected = CharacterSpritesDBAccessor.GetCat(OAEMGBKKPHJ);
			CommonReferences.GGFJGHHHEJC.catName = HAKDHLOOCOE;
			catNPC.birthday = GDNLNDKBLJJ;
			if ((Object)(object)CommonReferences.GGFJGHHHEJC.catSelected == (Object)null)
			{
				Debug.Log((object)("Cat with id " + OAEMGBKKPHJ + " not found"));
			}
			ChangeCatSkin();
			catNPC.TeleToBed();
		}
		else
		{
			Debug.LogError((object)"CatNPC already exists");
		}
	}

	public void IBKBIJNCIGE()
	{
		catNPC.catAnimator.KBNJNEJLCNG(CommonReferences.GGFJGHHHEJC.catSelected);
	}

	public void EACPCPILFLP()
	{
		catNPC.catAnimator.JIJDPHGJDCG(CommonReferences.GGFJGHHHEJC.catSelected);
	}

	private IEnumerator DAPLLLLKPDN(int IHNEJFGAENM, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDate GDNLNDKBLJJ)
	{
		yield return null;
		if ((Object)(object)catNPC == (Object)null)
		{
			catNPC = Object.Instantiate<GameObject>(catPrefab, ((Component)this).transform.position, Quaternion.identity).GetComponent<CatNPC>();
			catNPC.relationshipSystem.SetRelationship(IHNEJFGAENM);
			if (VersionNumberManager.IsAnOlderVersion(GameManager.GGFJGHHHEJC.HEJPPEJMPFE.HIMELJEPBDP(), VersionNumberManager.instance.NCMFFHEANML))
			{
				PetSelectorUI.GGFJGHHHEJC.Open(1);
			}
			CommonReferences.GGFJGHHHEJC.catSelected = CharacterSpritesDBAccessor.GetCat(OAEMGBKKPHJ);
			CommonReferences.GGFJGHHHEJC.catName = HAKDHLOOCOE;
			catNPC.birthday = GDNLNDKBLJJ;
			if ((Object)(object)CommonReferences.GGFJGHHHEJC.catSelected == (Object)null)
			{
				Debug.Log((object)("Cat with id " + OAEMGBKKPHJ + " not found"));
			}
			ChangeCatSkin();
			catNPC.TeleToBed();
		}
		else
		{
			Debug.LogError((object)"CatNPC already exists");
		}
	}

	public CatNPC MBNFBJOINFG(int PKOLNKCGANA, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDateMessage GDNLNDKBLJJ)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		catNPC = Object.Instantiate<GameObject>(catPrefab, ((Component)this).transform.position, Quaternion.identity).GetComponent<CatNPC>();
		catNPC.relationshipSystem.JBEAELDILAL(PKOLNKCGANA);
		CommonReferences.MNFMOEKMJKN().catSelected = CharacterSpritesDBAccessor.BECKFCECOIO(OAEMGBKKPHJ);
		CommonReferences.GGFJGHHHEJC.catName = HAKDHLOOCOE;
		catNPC.birthday = GDNLNDKBLJJ.OBDEGHJAFMP();
		NOLNHCLNAAA();
		return catNPC;
	}

	public void DCNOHCLBBFC()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNPC == (Object)null)
		{
			Object.Instantiate<GameObject>(catPrefab, ((Component)TravelZonesManager.CFHEJAGKIII().GetTravelZone(Location.Tavern, Location.Road)).transform.position, Quaternion.identity).GetComponent<CatNPC>().Spawn();
		}
	}

	private void Awake()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	public void BDLIPDPIMGI()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNPC == (Object)null)
		{
			Object.Instantiate<GameObject>(catPrefab, ((Component)TravelZonesManager.OLHBLKIAFOM().DAOACOMANPN(Location.Tavern, Location.Road)).transform.position, Quaternion.identity).GetComponent<CatNPC>().Spawn();
		}
	}

	[SpecialName]
	public static SpawnCat GJFMMOPOKGJ()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<SpawnCat>();
		}
		return IADEMLIIDPC;
	}

	private void GNAJBACLEKG()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	[SpecialName]
	public static SpawnCat GAGMPCEPONF()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<SpawnCat>();
		}
		return IADEMLIIDPC;
	}

	public CatNPC OFJCOHELCBC(int PKOLNKCGANA, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDateMessage GDNLNDKBLJJ)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		catNPC = Object.Instantiate<GameObject>(catPrefab, ((Component)this).transform.position, Quaternion.identity).GetComponent<CatNPC>();
		catNPC.relationshipSystem.ANOMKLEIAGM(PKOLNKCGANA);
		CommonReferences.MNFMOEKMJKN().catSelected = CharacterSpritesDBAccessor.EKILDJBNOEP(OAEMGBKKPHJ);
		CommonReferences.GGFJGHHHEJC.catName = HAKDHLOOCOE;
		catNPC.birthday = GDNLNDKBLJJ.LOCEJDHKNAE();
		JFLFGIFJKOM();
		return catNPC;
	}

	private void AJGLDLLIIFO()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	public void JIHKEEFCGJI()
	{
		catNPC.catAnimator.IKFLGBPNLGE(CommonReferences.MNFMOEKMJKN().catSelected);
	}

	public CatNPC GAOJADHHNHA(int PKOLNKCGANA, int OAEMGBKKPHJ, string HAKDHLOOCOE, GameDateMessage GDNLNDKBLJJ)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		catNPC = Object.Instantiate<GameObject>(catPrefab, ((Component)this).transform.position, Quaternion.identity).GetComponent<CatNPC>();
		catNPC.relationshipSystem.JBEAELDILAL(PKOLNKCGANA);
		CommonReferences.MNFMOEKMJKN().catSelected = CharacterSpritesDBAccessor.EKILDJBNOEP(OAEMGBKKPHJ);
		CommonReferences.GGFJGHHHEJC.catName = HAKDHLOOCOE;
		catNPC.birthday = GDNLNDKBLJJ.KBOIGHBHFMM();
		ONKHPDKMPJJ();
		return catNPC;
	}
}
