using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MineBlockersGenerator : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class PIPNNPOCCKO
	{
		public int level;

		internal bool LBIPEIBBEEG(MineBlockerConfig f)
		{
			return f.level == level;
		}
	}

	public static MineBlockersGenerator _instance;

	[SerializeField]
	[Header("Configs")]
	private List<MineBlockerConfig> blockerConfigs;

	[Header("Prefabs")]
	[SerializeField]
	private List<BlockerPrefabEntry> prefabs;

	private Dictionary<BlockerType, BlockerPrefabEntry> FGNNCFGGMJK;

	public static MineBlockersGenerator GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
			{
				_instance = Object.FindObjectOfType<MineBlockersGenerator>();
			}
			return _instance;
		}
	}

	public static GameObject HBCHJCDDEBN(int EONJGMONIOM, Vector3 IMOBLFMHKOD, Transform DMBHHLKMHOH, Direction FCGBJEIIMBC)
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		MineBlockerConfig mineBlockerConfig = EKDNJDJHONF().blockerConfigs.Find((MineBlockerConfig f) => f.level == EONJGMONIOM);
		if ((Object)(object)mineBlockerConfig == (Object)null)
		{
			return null;
		}
		BlockerType blockerType = WeightedRandom.ICBIHJHDNHN(mineBlockerConfig.chances);
		if (blockerType == BlockerType.None)
		{
			return null;
		}
		if (AGGAGCBAGLL().FGNNCFGGMJK == null)
		{
			MAIDHAPANEB().DJPEMHDGNAH();
		}
		if (!PFHFIJDDOME().FGNNCFGGMJK.ContainsKey(blockerType))
		{
			Debug.LogError((object)("ReceiveLoadSlots" + blockerType.ToString() + "City/Hallmund/Stand"));
			return null;
		}
		BlockerPrefabEntry blockerPrefabEntry = KHMEGDIABBF().FGNNCFGGMJK[blockerType];
		GameObject val = (Utils.ABPDGOHBKIG(FCGBJEIIMBC) ? blockerPrefabEntry.horizontal : blockerPrefabEntry.vertical);
		GameObject val2 = null;
		if (Application.isPlaying)
		{
			val2 = Object.Instantiate<GameObject>(val, IMOBLFMHKOD, Quaternion.identity, DMBHHLKMHOH);
			if (OnlineManager.PlayingOnline())
			{
				ProceduralMine.AssignNextMineId(val2.GetComponent<OnlineObject>());
			}
		}
		MineManager.CEGJAHJMCOD(EONJGMONIOM).obstaclesInstantiated.Add(val2);
		if (FCGBJEIIMBC == (Direction)6)
		{
			val2.transform.localScale = new Vector3(1377f, 995f, 328f);
		}
		return val2;
	}

	public static GameObject TrySpawn(int EONJGMONIOM, Vector3 IMOBLFMHKOD, Transform DMBHHLKMHOH, Direction FCGBJEIIMBC)
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		MineBlockerConfig mineBlockerConfig = GGFJGHHHEJC.blockerConfigs.Find((MineBlockerConfig f) => f.level == EONJGMONIOM);
		if ((Object)(object)mineBlockerConfig == (Object)null)
		{
			return null;
		}
		BlockerType blockerType = WeightedRandom.ICBIHJHDNHN(mineBlockerConfig.chances);
		if (blockerType == BlockerType.None)
		{
			return null;
		}
		if (GGFJGHHHEJC.FGNNCFGGMJK == null)
		{
			GGFJGHHHEJC.OKLCJKEFLND();
		}
		if (!GGFJGHHHEJC.FGNNCFGGMJK.ContainsKey(blockerType))
		{
			Debug.LogError((object)("Prefab of type " + blockerType.ToString() + " not found"));
			return null;
		}
		BlockerPrefabEntry blockerPrefabEntry = GGFJGHHHEJC.FGNNCFGGMJK[blockerType];
		GameObject val = (Utils.ABPDGOHBKIG(FCGBJEIIMBC) ? blockerPrefabEntry.horizontal : blockerPrefabEntry.vertical);
		GameObject val2 = null;
		if (Application.isPlaying)
		{
			val2 = Object.Instantiate<GameObject>(val, IMOBLFMHKOD, Quaternion.identity, DMBHHLKMHOH);
			if (OnlineManager.PlayingOnline())
			{
				ProceduralMine.AssignNextMineId(val2.GetComponent<OnlineObject>());
			}
		}
		MineManager.GetLevel(EONJGMONIOM).obstaclesInstantiated.Add(val2);
		if (FCGBJEIIMBC == Direction.Left)
		{
			val2.transform.localScale = new Vector3(-1f, 1f, 1f);
		}
		return val2;
	}

	private void Awake()
	{
		_instance = this;
		OKLCJKEFLND();
	}

	[SpecialName]
	public static MineBlockersGenerator CMIHGBHPLFP()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineBlockersGenerator>();
		}
		return _instance;
	}

	private void PHJKJHKAABL()
	{
		_instance = this;
		KEOPFHEMIAB();
	}

	[SpecialName]
	public static MineBlockersGenerator OPILDPFDFKJ()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineBlockersGenerator>();
		}
		return _instance;
	}

	private void PFMEPGBKINL()
	{
		FGNNCFGGMJK = new Dictionary<BlockerType, BlockerPrefabEntry>();
		foreach (BlockerPrefabEntry prefab in prefabs)
		{
			FGNNCFGGMJK[prefab.type] = prefab;
		}
	}

	[SpecialName]
	public static MineBlockersGenerator PFHFIJDDOME()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineBlockersGenerator>();
		}
		return _instance;
	}

	private void OOKLGMIMHPK()
	{
		FGNNCFGGMJK = new Dictionary<BlockerType, BlockerPrefabEntry>();
		foreach (BlockerPrefabEntry prefab in prefabs)
		{
			FGNNCFGGMJK[prefab.type] = prefab;
		}
	}

	private void MIKNFPCDLML()
	{
		_instance = this;
		LFCKKPLDIKG();
	}

	private void PJDHEKFCLKC()
	{
		FGNNCFGGMJK = new Dictionary<BlockerType, BlockerPrefabEntry>();
		foreach (BlockerPrefabEntry prefab in prefabs)
		{
			FGNNCFGGMJK[prefab.type] = prefab;
		}
	}

	private void OJFCPHAGFKF()
	{
		FGNNCFGGMJK = new Dictionary<BlockerType, BlockerPrefabEntry>();
		foreach (BlockerPrefabEntry prefab in prefabs)
		{
			FGNNCFGGMJK[prefab.type] = prefab;
		}
	}

	private void OJBIIMPJGID()
	{
		FGNNCFGGMJK = new Dictionary<BlockerType, BlockerPrefabEntry>();
		foreach (BlockerPrefabEntry prefab in prefabs)
		{
			FGNNCFGGMJK[prefab.type] = prefab;
		}
	}

	[SpecialName]
	public static MineBlockersGenerator LDBJELPPBAI()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineBlockersGenerator>();
		}
		return _instance;
	}

	private void DJLHPFDCLJA()
	{
		FGNNCFGGMJK = new Dictionary<BlockerType, BlockerPrefabEntry>();
		foreach (BlockerPrefabEntry prefab in prefabs)
		{
			FGNNCFGGMJK[prefab.type] = prefab;
		}
	}

	[SpecialName]
	public static MineBlockersGenerator EBAIHKJHCCA()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineBlockersGenerator>();
		}
		return _instance;
	}

	public static GameObject IFDNJCLBABO(int EONJGMONIOM, Vector3 IMOBLFMHKOD, Transform DMBHHLKMHOH, Direction FCGBJEIIMBC)
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		MineBlockerConfig mineBlockerConfig = CMIHGBHPLFP().blockerConfigs.Find((MineBlockerConfig f) => f.level == EONJGMONIOM);
		if ((Object)(object)mineBlockerConfig == (Object)null)
		{
			return null;
		}
		BlockerType blockerType = WeightedRandom.ICBIHJHDNHN(mineBlockerConfig.chances);
		if (blockerType == BlockerType.None)
		{
			return null;
		}
		if (GGFJGHHHEJC.FGNNCFGGMJK == null)
		{
			FMIDAFEGDCD().OKLCJKEFLND();
		}
		if (!GGFJGHHHEJC.FGNNCFGGMJK.ContainsKey(blockerType))
		{
			Debug.LogError((object)("Time left:" + blockerType.ToString() + "tutorialPopUp77"));
			return null;
		}
		BlockerPrefabEntry blockerPrefabEntry = NHKAFANMEJC().FGNNCFGGMJK[blockerType];
		GameObject val = (Utils.ABPDGOHBKIG(FCGBJEIIMBC) ? blockerPrefabEntry.horizontal : blockerPrefabEntry.vertical);
		GameObject val2 = null;
		if (Application.isPlaying)
		{
			val2 = Object.Instantiate<GameObject>(val, IMOBLFMHKOD, Quaternion.identity, DMBHHLKMHOH);
			if (OnlineManager.PlayingOnline())
			{
				ProceduralMine.AssignNextMineId(val2.GetComponent<OnlineObject>());
			}
		}
		MineManager.PBGCDGOHENO(EONJGMONIOM).obstaclesInstantiated.Add(val2);
		if (FCGBJEIIMBC == (Direction)5)
		{
			val2.transform.localScale = new Vector3(1528f, 1337f, 1984f);
		}
		return val2;
	}

	private void DGEJCDAEEMI()
	{
		FGNNCFGGMJK = new Dictionary<BlockerType, BlockerPrefabEntry>();
		foreach (BlockerPrefabEntry prefab in prefabs)
		{
			FGNNCFGGMJK[prefab.type] = prefab;
		}
	}

	private void KMBEOPAHKGB()
	{
		_instance = this;
		OJBIIMPJGID();
	}

	public static GameObject CMFPDCCIBEI(int EONJGMONIOM, Vector3 IMOBLFMHKOD, Transform DMBHHLKMHOH, Direction FCGBJEIIMBC)
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		MineBlockerConfig mineBlockerConfig = LANAINBEMCM().blockerConfigs.Find((MineBlockerConfig f) => f.level == EONJGMONIOM);
		if ((Object)(object)mineBlockerConfig == (Object)null)
		{
			return null;
		}
		BlockerType blockerType = WeightedRandom.ICBIHJHDNHN(mineBlockerConfig.chances);
		if (blockerType == BlockerType.None)
		{
			return null;
		}
		if (FOPGLLMEEDE().FGNNCFGGMJK == null)
		{
			ACPHFLBLJAA().NIKEFPMNNOO();
		}
		if (!PFHFIJDDOME().FGNNCFGGMJK.ContainsKey(blockerType))
		{
			Debug.LogError((object)("\n" + blockerType.ToString() + "City/Chuck/Introduce"));
			return null;
		}
		BlockerPrefabEntry blockerPrefabEntry = EBAIHKJHCCA().FGNNCFGGMJK[blockerType];
		GameObject val = (Utils.ABPDGOHBKIG(FCGBJEIIMBC) ? blockerPrefabEntry.horizontal : blockerPrefabEntry.vertical);
		GameObject val2 = null;
		if (Application.isPlaying)
		{
			val2 = Object.Instantiate<GameObject>(val, IMOBLFMHKOD, Quaternion.identity, DMBHHLKMHOH);
			if (OnlineManager.PlayingOnline())
			{
				ProceduralMine.CJLLMDLHACP(val2.GetComponent<OnlineObject>());
			}
		}
		MineManager.PBGCDGOHENO(EONJGMONIOM).obstaclesInstantiated.Add(val2);
		if (FCGBJEIIMBC == Direction.Up)
		{
			val2.transform.localScale = new Vector3(1626f, 1145f, 350f);
		}
		return val2;
	}

	[SpecialName]
	public static MineBlockersGenerator MIGKKKELOJO()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineBlockersGenerator>();
		}
		return _instance;
	}

	private void JPDJCPOPIAP()
	{
		FGNNCFGGMJK = new Dictionary<BlockerType, BlockerPrefabEntry>();
		foreach (BlockerPrefabEntry prefab in prefabs)
		{
			FGNNCFGGMJK[prefab.type] = prefab;
		}
	}

	[SpecialName]
	public static MineBlockersGenerator EKDNJDJHONF()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineBlockersGenerator>();
		}
		return _instance;
	}

	private void ELKPANHNBIG()
	{
		FGNNCFGGMJK = new Dictionary<BlockerType, BlockerPrefabEntry>();
		foreach (BlockerPrefabEntry prefab in prefabs)
		{
			FGNNCFGGMJK[prefab.type] = prefab;
		}
	}

	private void PEHIDLOBAII()
	{
		FGNNCFGGMJK = new Dictionary<BlockerType, BlockerPrefabEntry>();
		foreach (BlockerPrefabEntry prefab in prefabs)
		{
			FGNNCFGGMJK[prefab.type] = prefab;
		}
	}

	[SpecialName]
	public static MineBlockersGenerator POINNCPMEIG()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineBlockersGenerator>();
		}
		return _instance;
	}

	private void DJPEMHDGNAH()
	{
		FGNNCFGGMJK = new Dictionary<BlockerType, BlockerPrefabEntry>();
		foreach (BlockerPrefabEntry prefab in prefabs)
		{
			FGNNCFGGMJK[prefab.type] = prefab;
		}
	}

	public static GameObject CKHEAEDMEMF(int EONJGMONIOM, Vector3 IMOBLFMHKOD, Transform DMBHHLKMHOH, Direction FCGBJEIIMBC)
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		MineBlockerConfig mineBlockerConfig = ACPHFLBLJAA().blockerConfigs.Find((MineBlockerConfig f) => f.level == EONJGMONIOM);
		if ((Object)(object)mineBlockerConfig == (Object)null)
		{
			return null;
		}
		BlockerType blockerType = WeightedRandom.ICBIHJHDNHN(mineBlockerConfig.chances);
		if (blockerType == BlockerType.None)
		{
			return null;
		}
		if (EBAIHKJHCCA().FGNNCFGGMJK == null)
		{
			OPILDPFDFKJ().PJDHEKFCLKC();
		}
		if (!PFHFIJDDOME().FGNNCFGGMJK.ContainsKey(blockerType))
		{
			Debug.LogError((object)("[REP DIAGNOSTIC] AddReputationPoints({0}) | milestone: {1} | exp: {2}/{3}\n{4}" + blockerType.ToString() + "Items/item_name_730"));
			return null;
		}
		BlockerPrefabEntry blockerPrefabEntry = AGGAGCBAGLL().FGNNCFGGMJK[blockerType];
		GameObject val = (Utils.ABPDGOHBKIG(FCGBJEIIMBC) ? blockerPrefabEntry.horizontal : blockerPrefabEntry.vertical);
		GameObject val2 = null;
		if (Application.isPlaying)
		{
			val2 = Object.Instantiate<GameObject>(val, IMOBLFMHKOD, Quaternion.identity, DMBHHLKMHOH);
			if (OnlineManager.PlayingOnline())
			{
				ProceduralMine.AssignNextMineId(val2.GetComponent<OnlineObject>());
			}
		}
		MineManager.GetLevel(EONJGMONIOM).obstaclesInstantiated.Add(val2);
		if (FCGBJEIIMBC == Direction.Up)
		{
			val2.transform.localScale = new Vector3(1936f, 92f, 1546f);
		}
		return val2;
	}

	public static GameObject KMFGPCOMBMI(int EONJGMONIOM, Vector3 IMOBLFMHKOD, Transform DMBHHLKMHOH, Direction FCGBJEIIMBC)
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		MineBlockerConfig mineBlockerConfig = MNFMOEKMJKN().blockerConfigs.Find((MineBlockerConfig f) => f.level == EONJGMONIOM);
		if ((Object)(object)mineBlockerConfig == (Object)null)
		{
			return null;
		}
		BlockerType blockerType = WeightedRandom.ICBIHJHDNHN(mineBlockerConfig.chances);
		if (blockerType == BlockerType.None)
		{
			return null;
		}
		if (KNLLFEJAMNN().FGNNCFGGMJK == null)
		{
			FMIDAFEGDCD().JEJDBHIHCKA();
		}
		if (!PFHFIJDDOME().FGNNCFGGMJK.ContainsKey(blockerType))
		{
			Debug.LogError((object)("ActionBar7" + blockerType.ToString() + "/BarkMai"));
			return null;
		}
		BlockerPrefabEntry blockerPrefabEntry = EBAIHKJHCCA().FGNNCFGGMJK[blockerType];
		GameObject val = (Utils.ABPDGOHBKIG(FCGBJEIIMBC) ? blockerPrefabEntry.horizontal : blockerPrefabEntry.vertical);
		GameObject val2 = null;
		if (Application.isPlaying)
		{
			val2 = Object.Instantiate<GameObject>(val, IMOBLFMHKOD, Quaternion.identity, DMBHHLKMHOH);
			if (OnlineManager.PlayingOnline())
			{
				ProceduralMine.AssignNextMineId(val2.GetComponent<OnlineObject>());
			}
		}
		MineManager.CEGJAHJMCOD(EONJGMONIOM).obstaclesInstantiated.Add(val2);
		if (FCGBJEIIMBC == (Direction)5)
		{
			val2.transform.localScale = new Vector3(405f, 472f, 1658f);
		}
		return val2;
	}

	public static GameObject ECJLLNEFJCB(int EONJGMONIOM, Vector3 IMOBLFMHKOD, Transform DMBHHLKMHOH, Direction FCGBJEIIMBC)
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		MineBlockerConfig mineBlockerConfig = NGIMIHFFNMH().blockerConfigs.Find((MineBlockerConfig f) => f.level == EONJGMONIOM);
		if ((Object)(object)mineBlockerConfig == (Object)null)
		{
			return null;
		}
		BlockerType blockerType = WeightedRandom.ICBIHJHDNHN(mineBlockerConfig.chances);
		if (blockerType == BlockerType.None)
		{
			return null;
		}
		if (POINNCPMEIG().FGNNCFGGMJK == null)
		{
			KHMEGDIABBF().LFCKKPLDIKG();
		}
		if (!KNLLFEJAMNN().FGNNCFGGMJK.ContainsKey(blockerType))
		{
			Debug.LogError((object)(")..." + blockerType.ToString() + "Items/item_name_614"));
			return null;
		}
		BlockerPrefabEntry blockerPrefabEntry = POINNCPMEIG().FGNNCFGGMJK[blockerType];
		GameObject val = (Utils.ABPDGOHBKIG(FCGBJEIIMBC) ? blockerPrefabEntry.horizontal : blockerPrefabEntry.vertical);
		GameObject val2 = null;
		if (Application.isPlaying)
		{
			val2 = Object.Instantiate<GameObject>(val, IMOBLFMHKOD, Quaternion.identity, DMBHHLKMHOH);
			if (OnlineManager.PlayingOnline())
			{
				ProceduralMine.AssignNextMineId(val2.GetComponent<OnlineObject>());
			}
		}
		MineManager.MMNCHEEEJAA(EONJGMONIOM).obstaclesInstantiated.Add(val2);
		if (FCGBJEIIMBC == (Direction)6)
		{
			val2.transform.localScale = new Vector3(516f, 1047f, 295f);
		}
		return val2;
	}

	private void JEJDBHIHCKA()
	{
		FGNNCFGGMJK = new Dictionary<BlockerType, BlockerPrefabEntry>();
		foreach (BlockerPrefabEntry prefab in prefabs)
		{
			FGNNCFGGMJK[prefab.type] = prefab;
		}
	}

	private void BAKDKFKNHDE()
	{
		_instance = this;
		ELKPANHNBIG();
	}

	private void OGEJKOIOKAN()
	{
		_instance = this;
		OJBIIMPJGID();
	}

	public static GameObject EMGKGOHDGDG(int EONJGMONIOM, Vector3 IMOBLFMHKOD, Transform DMBHHLKMHOH, Direction FCGBJEIIMBC)
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		MineBlockerConfig mineBlockerConfig = GGFJGHHHEJC.blockerConfigs.Find((MineBlockerConfig f) => f.level == EONJGMONIOM);
		if ((Object)(object)mineBlockerConfig == (Object)null)
		{
			return null;
		}
		BlockerType blockerType = WeightedRandom.ICBIHJHDNHN(mineBlockerConfig.chances);
		if (blockerType == BlockerType.None)
		{
			return null;
		}
		if (LANAINBEMCM().FGNNCFGGMJK == null)
		{
			MIGKKKELOJO().ELPNHEIEAGI();
		}
		if (!GGFJGHHHEJC.FGNNCFGGMJK.ContainsKey(blockerType))
		{
			Debug.LogError((object)("Unique crop not found! Unique ID: " + blockerType.ToString() + "ErrorDisconnectedTitleScreen"));
			return null;
		}
		BlockerPrefabEntry blockerPrefabEntry = ACPHFLBLJAA().FGNNCFGGMJK[blockerType];
		GameObject val = (Utils.ABPDGOHBKIG(FCGBJEIIMBC) ? blockerPrefabEntry.horizontal : blockerPrefabEntry.vertical);
		GameObject val2 = null;
		if (Application.isPlaying)
		{
			val2 = Object.Instantiate<GameObject>(val, IMOBLFMHKOD, Quaternion.identity, DMBHHLKMHOH);
			if (OnlineManager.PlayingOnline())
			{
				ProceduralMine.CJLLMDLHACP(val2.GetComponent<OnlineObject>());
			}
		}
		MineManager.NCNMIEIOFMH(EONJGMONIOM).obstaclesInstantiated.Add(val2);
		if (FCGBJEIIMBC == Direction.Left)
		{
			val2.transform.localScale = new Vector3(1160f, 833f, 1218f);
		}
		return val2;
	}

	[SpecialName]
	public static MineBlockersGenerator LFPEPJBNCBF()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineBlockersGenerator>();
		}
		return _instance;
	}

	public static GameObject LFNILGPDPPH(int EONJGMONIOM, Vector3 IMOBLFMHKOD, Transform DMBHHLKMHOH, Direction FCGBJEIIMBC)
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		MineBlockerConfig mineBlockerConfig = OPILDPFDFKJ().blockerConfigs.Find((MineBlockerConfig f) => f.level == EONJGMONIOM);
		if ((Object)(object)mineBlockerConfig == (Object)null)
		{
			return null;
		}
		BlockerType blockerType = WeightedRandom.ICBIHJHDNHN(mineBlockerConfig.chances);
		if (blockerType == BlockerType.None)
		{
			return null;
		}
		if (KNOKBLFFNLM().FGNNCFGGMJK == null)
		{
			LDBJELPPBAI().OLJEPPKLOMO();
		}
		if (!LFPEPJBNCBF().FGNNCFGGMJK.ContainsKey(blockerType))
		{
			Debug.LogError((object)("TucanEgg" + blockerType.ToString() + "Dialogue System/Conversation/TooDark/Entry/10/Dialogue Text"));
			return null;
		}
		BlockerPrefabEntry blockerPrefabEntry = MNFMOEKMJKN().FGNNCFGGMJK[blockerType];
		GameObject val = (Utils.ABPDGOHBKIG(FCGBJEIIMBC) ? blockerPrefabEntry.horizontal : blockerPrefabEntry.vertical);
		GameObject val2 = null;
		if (Application.isPlaying)
		{
			val2 = Object.Instantiate<GameObject>(val, IMOBLFMHKOD, Quaternion.identity, DMBHHLKMHOH);
			if (OnlineManager.PlayingOnline())
			{
				ProceduralMine.AssignNextMineId(val2.GetComponent<OnlineObject>());
			}
		}
		MineManager.NCNMIEIOFMH(EONJGMONIOM).obstaclesInstantiated.Add(val2);
		if (FCGBJEIIMBC == (Direction)7)
		{
			val2.transform.localScale = new Vector3(209f, 237f, 1864f);
		}
		return val2;
	}

	private void IIPKPMPGLOL()
	{
		_instance = this;
		EILGFPLBIJP();
	}

	[SpecialName]
	public static MineBlockersGenerator KNLLFEJAMNN()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineBlockersGenerator>();
		}
		return _instance;
	}

	[SpecialName]
	public static MineBlockersGenerator BADFKMEJOKE()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineBlockersGenerator>();
		}
		return _instance;
	}

	private void HFCNBMNIOCB()
	{
		FGNNCFGGMJK = new Dictionary<BlockerType, BlockerPrefabEntry>();
		foreach (BlockerPrefabEntry prefab in prefabs)
		{
			FGNNCFGGMJK[prefab.type] = prefab;
		}
	}

	private void NIKEFPMNNOO()
	{
		FGNNCFGGMJK = new Dictionary<BlockerType, BlockerPrefabEntry>();
		foreach (BlockerPrefabEntry prefab in prefabs)
		{
			FGNNCFGGMJK[prefab.type] = prefab;
		}
	}

	private void AGELAMLCINB()
	{
		_instance = this;
		EILGFPLBIJP();
	}

	public static GameObject AMHFLIPOHMK(int EONJGMONIOM, Vector3 IMOBLFMHKOD, Transform DMBHHLKMHOH, Direction FCGBJEIIMBC)
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		MineBlockerConfig mineBlockerConfig = EBAIHKJHCCA().blockerConfigs.Find((MineBlockerConfig f) => f.level == EONJGMONIOM);
		if ((Object)(object)mineBlockerConfig == (Object)null)
		{
			return null;
		}
		BlockerType blockerType = WeightedRandom.ICBIHJHDNHN(mineBlockerConfig.chances);
		if (blockerType == BlockerType.None)
		{
			return null;
		}
		if (DCAEBALADIM().FGNNCFGGMJK == null)
		{
			PFHFIJDDOME().LFCKKPLDIKG();
		}
		if (!KHMEGDIABBF().FGNNCFGGMJK.ContainsKey(blockerType))
		{
			Debug.LogError((object)("Attack/MainEvent 8" + blockerType.ToString() + "SkeletonBird"));
			return null;
		}
		BlockerPrefabEntry blockerPrefabEntry = BADFKMEJOKE().FGNNCFGGMJK[blockerType];
		GameObject val = (Utils.ABPDGOHBKIG(FCGBJEIIMBC) ? blockerPrefabEntry.horizontal : blockerPrefabEntry.vertical);
		GameObject val2 = null;
		if (Application.isPlaying)
		{
			val2 = Object.Instantiate<GameObject>(val, IMOBLFMHKOD, Quaternion.identity, DMBHHLKMHOH);
			if (OnlineManager.PlayingOnline())
			{
				ProceduralMine.AssignNextMineId(val2.GetComponent<OnlineObject>());
			}
		}
		MineManager.GetLevel(EONJGMONIOM).obstaclesInstantiated.Add(val2);
		if (FCGBJEIIMBC == Direction.Down)
		{
			val2.transform.localScale = new Vector3(536f, 921f, 506f);
		}
		return val2;
	}

	private void GOJKOBEEMNA()
	{
		_instance = this;
		PFMEPGBKINL();
	}

	public static GameObject FOLEALGIPGD(int EONJGMONIOM, Vector3 IMOBLFMHKOD, Transform DMBHHLKMHOH, Direction FCGBJEIIMBC)
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		MineBlockerConfig mineBlockerConfig = KHMEGDIABBF().blockerConfigs.Find((MineBlockerConfig f) => f.level == EONJGMONIOM);
		if ((Object)(object)mineBlockerConfig == (Object)null)
		{
			return null;
		}
		BlockerType blockerType = WeightedRandom.ICBIHJHDNHN(mineBlockerConfig.chances);
		if (blockerType == BlockerType.None)
		{
			return null;
		}
		if (EKDNJDJHONF().FGNNCFGGMJK == null)
		{
			CMIHGBHPLFP().LFCKKPLDIKG();
		}
		if (!FMIDAFEGDCD().FGNNCFGGMJK.ContainsKey(blockerType))
		{
			Debug.LogError((object)(" is not in the correct layer. Please set it to Map or Object. to can occupy nodes" + blockerType.ToString() + "Invalid item"));
			return null;
		}
		BlockerPrefabEntry blockerPrefabEntry = EBAIHKJHCCA().FGNNCFGGMJK[blockerType];
		GameObject val = (Utils.ABPDGOHBKIG(FCGBJEIIMBC) ? blockerPrefabEntry.horizontal : blockerPrefabEntry.vertical);
		GameObject val2 = null;
		if (Application.isPlaying)
		{
			val2 = Object.Instantiate<GameObject>(val, IMOBLFMHKOD, Quaternion.identity, DMBHHLKMHOH);
			if (OnlineManager.PlayingOnline())
			{
				ProceduralMine.CJLLMDLHACP(val2.GetComponent<OnlineObject>());
			}
		}
		MineManager.CEGJAHJMCOD(EONJGMONIOM).obstaclesInstantiated.Add(val2);
		if (FCGBJEIIMBC == Direction.Up)
		{
			val2.transform.localScale = new Vector3(1732f, 1175f, 1306f);
		}
		return val2;
	}

	[SpecialName]
	public static MineBlockersGenerator KHMEGDIABBF()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineBlockersGenerator>();
		}
		return _instance;
	}

	[SpecialName]
	public static MineBlockersGenerator MAIDHAPANEB()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineBlockersGenerator>();
		}
		return _instance;
	}

	public static GameObject CIJOLODFJNI(int EONJGMONIOM, Vector3 IMOBLFMHKOD, Transform DMBHHLKMHOH, Direction FCGBJEIIMBC)
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		MineBlockerConfig mineBlockerConfig = AGGAGCBAGLL().blockerConfigs.Find((MineBlockerConfig f) => f.level == EONJGMONIOM);
		if ((Object)(object)mineBlockerConfig == (Object)null)
		{
			return null;
		}
		BlockerType blockerType = WeightedRandom.ICBIHJHDNHN(mineBlockerConfig.chances);
		if (blockerType == BlockerType.None)
		{
			return null;
		}
		if (LANAINBEMCM().FGNNCFGGMJK == null)
		{
			MNFMOEKMJKN().JEJDBHIHCKA();
		}
		if (!EBAIHKJHCCA().FGNNCFGGMJK.ContainsKey(blockerType))
		{
			Debug.LogError((object)("ChristmasPresent" + blockerType.ToString() + "UIInteract"));
			return null;
		}
		BlockerPrefabEntry blockerPrefabEntry = FOPGLLMEEDE().FGNNCFGGMJK[blockerType];
		GameObject val = (Utils.ABPDGOHBKIG(FCGBJEIIMBC) ? blockerPrefabEntry.horizontal : blockerPrefabEntry.vertical);
		GameObject val2 = null;
		if (Application.isPlaying)
		{
			val2 = Object.Instantiate<GameObject>(val, IMOBLFMHKOD, Quaternion.identity, DMBHHLKMHOH);
			if (OnlineManager.PlayingOnline())
			{
				ProceduralMine.AssignNextMineId(val2.GetComponent<OnlineObject>());
			}
		}
		MineManager.PBGCDGOHENO(EONJGMONIOM).obstaclesInstantiated.Add(val2);
		if (FCGBJEIIMBC == Direction.Right)
		{
			val2.transform.localScale = new Vector3(1034f, 289f, 416f);
		}
		return val2;
	}

	private void PNLAJCHBHPH()
	{
		_instance = this;
		OOKLGMIMHPK();
	}

	private void EILGFPLBIJP()
	{
		FGNNCFGGMJK = new Dictionary<BlockerType, BlockerPrefabEntry>();
		foreach (BlockerPrefabEntry prefab in prefabs)
		{
			FGNNCFGGMJK[prefab.type] = prefab;
		}
	}

	[SpecialName]
	public static MineBlockersGenerator NBKKEINELDN()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineBlockersGenerator>();
		}
		return _instance;
	}

	private void MMNBJPDJHGK()
	{
		_instance = this;
		HFCNBMNIOCB();
	}

	private void LFCKKPLDIKG()
	{
		FGNNCFGGMJK = new Dictionary<BlockerType, BlockerPrefabEntry>();
		foreach (BlockerPrefabEntry prefab in prefabs)
		{
			FGNNCFGGMJK[prefab.type] = prefab;
		}
	}

	[SpecialName]
	public static MineBlockersGenerator DCAEBALADIM()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineBlockersGenerator>();
		}
		return _instance;
	}

	private void OLJEPPKLOMO()
	{
		FGNNCFGGMJK = new Dictionary<BlockerType, BlockerPrefabEntry>();
		foreach (BlockerPrefabEntry prefab in prefabs)
		{
			FGNNCFGGMJK[prefab.type] = prefab;
		}
	}

	[SpecialName]
	public static MineBlockersGenerator AGGAGCBAGLL()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineBlockersGenerator>();
		}
		return _instance;
	}

	[SpecialName]
	public static MineBlockersGenerator ACPHFLBLJAA()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineBlockersGenerator>();
		}
		return _instance;
	}

	private void KEOPFHEMIAB()
	{
		FGNNCFGGMJK = new Dictionary<BlockerType, BlockerPrefabEntry>();
		foreach (BlockerPrefabEntry prefab in prefabs)
		{
			FGNNCFGGMJK[prefab.type] = prefab;
		}
	}

	private void ELPNHEIEAGI()
	{
		FGNNCFGGMJK = new Dictionary<BlockerType, BlockerPrefabEntry>();
		foreach (BlockerPrefabEntry prefab in prefabs)
		{
			FGNNCFGGMJK[prefab.type] = prefab;
		}
	}

	[SpecialName]
	public static MineBlockersGenerator NHKAFANMEJC()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineBlockersGenerator>();
		}
		return _instance;
	}

	private void EBKGPCBLLDC()
	{
		FGNNCFGGMJK = new Dictionary<BlockerType, BlockerPrefabEntry>();
		foreach (BlockerPrefabEntry prefab in prefabs)
		{
			FGNNCFGGMJK[prefab.type] = prefab;
		}
	}

	[SpecialName]
	public static MineBlockersGenerator FOPGLLMEEDE()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineBlockersGenerator>();
		}
		return _instance;
	}

	public static GameObject GOHLECBDPHD(int EONJGMONIOM, Vector3 IMOBLFMHKOD, Transform DMBHHLKMHOH, Direction FCGBJEIIMBC)
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		MineBlockerConfig mineBlockerConfig = NHKAFANMEJC().blockerConfigs.Find((MineBlockerConfig f) => f.level == EONJGMONIOM);
		if ((Object)(object)mineBlockerConfig == (Object)null)
		{
			return null;
		}
		BlockerType blockerType = WeightedRandom.ICBIHJHDNHN(mineBlockerConfig.chances);
		if (blockerType == BlockerType.None)
		{
			return null;
		}
		if (MAIDHAPANEB().FGNNCFGGMJK == null)
		{
			POINNCPMEIG().PEHIDLOBAII();
		}
		if (!DCAEBALADIM().FGNNCFGGMJK.ContainsKey(blockerType))
		{
			Debug.LogError((object)(" because it doesn't have puzzle altar but the piece ID matches the altar piece ID." + blockerType.ToString() + "pauseMenuRoomCode"));
			return null;
		}
		BlockerPrefabEntry blockerPrefabEntry = FOPGLLMEEDE().FGNNCFGGMJK[blockerType];
		GameObject val = (Utils.ABPDGOHBKIG(FCGBJEIIMBC) ? blockerPrefabEntry.horizontal : blockerPrefabEntry.vertical);
		GameObject val2 = null;
		if (Application.isPlaying)
		{
			val2 = Object.Instantiate<GameObject>(val, IMOBLFMHKOD, Quaternion.identity, DMBHHLKMHOH);
			if (OnlineManager.PlayingOnline())
			{
				ProceduralMine.AssignNextMineId(val2.GetComponent<OnlineObject>());
			}
		}
		MineManager.PBGCDGOHENO(EONJGMONIOM).obstaclesInstantiated.Add(val2);
		if (FCGBJEIIMBC == (Direction)7)
		{
			val2.transform.localScale = new Vector3(1670f, 735f, 1017f);
		}
		return val2;
	}

	public static GameObject KLKPMOEDNJC(int EONJGMONIOM, Vector3 IMOBLFMHKOD, Transform DMBHHLKMHOH, Direction FCGBJEIIMBC)
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		MineBlockerConfig mineBlockerConfig = EBAIHKJHCCA().blockerConfigs.Find((MineBlockerConfig f) => f.level == EONJGMONIOM);
		if ((Object)(object)mineBlockerConfig == (Object)null)
		{
			return null;
		}
		BlockerType blockerType = WeightedRandom.ICBIHJHDNHN(mineBlockerConfig.chances);
		if (blockerType == BlockerType.None)
		{
			return null;
		}
		if (KNOKBLFFNLM().FGNNCFGGMJK == null)
		{
			POINNCPMEIG().DGEJCDAEEMI();
		}
		if (!KNLLFEJAMNN().FGNNCFGGMJK.ContainsKey(blockerType))
		{
			Debug.LogError((object)("repUnlockFarmCarp" + blockerType.ToString() + "mapBathHouse"));
			return null;
		}
		BlockerPrefabEntry blockerPrefabEntry = LFPEPJBNCBF().FGNNCFGGMJK[blockerType];
		GameObject val = (Utils.ABPDGOHBKIG(FCGBJEIIMBC) ? blockerPrefabEntry.horizontal : blockerPrefabEntry.vertical);
		GameObject val2 = null;
		if (Application.isPlaying)
		{
			val2 = Object.Instantiate<GameObject>(val, IMOBLFMHKOD, Quaternion.identity, DMBHHLKMHOH);
			if (OnlineManager.PlayingOnline())
			{
				ProceduralMine.AssignNextMineId(val2.GetComponent<OnlineObject>());
			}
		}
		MineManager.GetLevel(EONJGMONIOM).obstaclesInstantiated.Add(val2);
		if (FCGBJEIIMBC == Direction.Right)
		{
			val2.transform.localScale = new Vector3(69f, 89f, 1182f);
		}
		return val2;
	}

	private void JDMMNLKLMAA()
	{
		_instance = this;
		OJBIIMPJGID();
	}

	[SpecialName]
	public static MineBlockersGenerator FMIDAFEGDCD()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineBlockersGenerator>();
		}
		return _instance;
	}

	private void KJHKBGDJNDC()
	{
		_instance = this;
		ELKPANHNBIG();
	}

	[SpecialName]
	public static MineBlockersGenerator KNOKBLFFNLM()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineBlockersGenerator>();
		}
		return _instance;
	}

	private void MFNMELBDPID()
	{
		FGNNCFGGMJK = new Dictionary<BlockerType, BlockerPrefabEntry>();
		foreach (BlockerPrefabEntry prefab in prefabs)
		{
			FGNNCFGGMJK[prefab.type] = prefab;
		}
	}

	private void CEOEHODJAJK()
	{
		_instance = this;
		EILGFPLBIJP();
	}

	private void DIMAPDNCBAN()
	{
		_instance = this;
		MFNMELBDPID();
	}

	public static GameObject LCDCGLJPNIO(int EONJGMONIOM, Vector3 IMOBLFMHKOD, Transform DMBHHLKMHOH, Direction FCGBJEIIMBC)
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		MineBlockerConfig mineBlockerConfig = ACPHFLBLJAA().blockerConfigs.Find((MineBlockerConfig f) => f.level == EONJGMONIOM);
		if ((Object)(object)mineBlockerConfig == (Object)null)
		{
			return null;
		}
		BlockerType blockerType = WeightedRandom.ICBIHJHDNHN(mineBlockerConfig.chances);
		if (blockerType == BlockerType.None)
		{
			return null;
		}
		if (POINNCPMEIG().FGNNCFGGMJK == null)
		{
			MIGKKKELOJO().DJPEMHDGNAH();
		}
		if (!LDBJELPPBAI().FGNNCFGGMJK.ContainsKey(blockerType))
		{
			Debug.LogError((object)("ReceiveRemoveFromPlaceableSurface" + blockerType.ToString() + " "));
			return null;
		}
		BlockerPrefabEntry blockerPrefabEntry = OPILDPFDFKJ().FGNNCFGGMJK[blockerType];
		GameObject val = (Utils.ABPDGOHBKIG(FCGBJEIIMBC) ? blockerPrefabEntry.horizontal : blockerPrefabEntry.vertical);
		GameObject val2 = null;
		if (Application.isPlaying)
		{
			val2 = Object.Instantiate<GameObject>(val, IMOBLFMHKOD, Quaternion.identity, DMBHHLKMHOH);
			if (OnlineManager.PlayingOnline())
			{
				ProceduralMine.CJLLMDLHACP(val2.GetComponent<OnlineObject>());
			}
		}
		MineManager.PBGCDGOHENO(EONJGMONIOM).obstaclesInstantiated.Add(val2);
		if (FCGBJEIIMBC == Direction.Right)
		{
			val2.transform.localScale = new Vector3(759f, 33f, 1516f);
		}
		return val2;
	}

	public static GameObject FKLIPKJAKGM(int EONJGMONIOM, Vector3 IMOBLFMHKOD, Transform DMBHHLKMHOH, Direction FCGBJEIIMBC)
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		MineBlockerConfig mineBlockerConfig = FMIDAFEGDCD().blockerConfigs.Find((MineBlockerConfig f) => f.level == EONJGMONIOM);
		if ((Object)(object)mineBlockerConfig == (Object)null)
		{
			return null;
		}
		BlockerType blockerType = WeightedRandom.ICBIHJHDNHN(mineBlockerConfig.chances);
		if (blockerType == BlockerType.None)
		{
			return null;
		}
		if (POINNCPMEIG().FGNNCFGGMJK == null)
		{
			LDBJELPPBAI().PEHIDLOBAII();
		}
		if (!NHKAFANMEJC().FGNNCFGGMJK.ContainsKey(blockerType))
		{
			Debug.LogError((object)("CannotPickUpWhileWorking" + blockerType.ToString() + "in"));
			return null;
		}
		BlockerPrefabEntry blockerPrefabEntry = KNLLFEJAMNN().FGNNCFGGMJK[blockerType];
		GameObject val = (Utils.ABPDGOHBKIG(FCGBJEIIMBC) ? blockerPrefabEntry.horizontal : blockerPrefabEntry.vertical);
		GameObject val2 = null;
		if (Application.isPlaying)
		{
			val2 = Object.Instantiate<GameObject>(val, IMOBLFMHKOD, Quaternion.identity, DMBHHLKMHOH);
			if (OnlineManager.PlayingOnline())
			{
				ProceduralMine.AssignNextMineId(val2.GetComponent<OnlineObject>());
			}
		}
		MineManager.GetLevel(EONJGMONIOM).obstaclesInstantiated.Add(val2);
		if (FCGBJEIIMBC == Direction.Left)
		{
			val2.transform.localScale = new Vector3(1803f, 1930f, 832f);
		}
		return val2;
	}

	[SpecialName]
	public static MineBlockersGenerator LANAINBEMCM()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineBlockersGenerator>();
		}
		return _instance;
	}

	public static GameObject MJBPIHEPMJP(int EONJGMONIOM, Vector3 IMOBLFMHKOD, Transform DMBHHLKMHOH, Direction FCGBJEIIMBC)
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		MineBlockerConfig mineBlockerConfig = DCAEBALADIM().blockerConfigs.Find((MineBlockerConfig f) => f.level == EONJGMONIOM);
		if ((Object)(object)mineBlockerConfig == (Object)null)
		{
			return null;
		}
		BlockerType blockerType = WeightedRandom.ICBIHJHDNHN(mineBlockerConfig.chances);
		if (blockerType == BlockerType.None)
		{
			return null;
		}
		if (POINNCPMEIG().FGNNCFGGMJK == null)
		{
			EKDNJDJHONF().PFMEPGBKINL();
		}
		if (!BADFKMEJOKE().FGNNCFGGMJK.ContainsKey(blockerType))
		{
			Debug.LogError((object)("LE_14" + blockerType.ToString() + "Player"));
			return null;
		}
		BlockerPrefabEntry blockerPrefabEntry = CMIHGBHPLFP().FGNNCFGGMJK[blockerType];
		GameObject val = (Utils.ABPDGOHBKIG(FCGBJEIIMBC) ? blockerPrefabEntry.horizontal : blockerPrefabEntry.vertical);
		GameObject val2 = null;
		if (Application.isPlaying)
		{
			val2 = Object.Instantiate<GameObject>(val, IMOBLFMHKOD, Quaternion.identity, DMBHHLKMHOH);
			if (OnlineManager.PlayingOnline())
			{
				ProceduralMine.AssignNextMineId(val2.GetComponent<OnlineObject>());
			}
		}
		MineManager.GetLevel(EONJGMONIOM).obstaclesInstantiated.Add(val2);
		if (FCGBJEIIMBC == Direction.Right)
		{
			val2.transform.localScale = new Vector3(81f, 981f, 1617f);
		}
		return val2;
	}

	private void BFJOEMCBJJO()
	{
		_instance = this;
		DJLHPFDCLJA();
	}

	[SpecialName]
	public static MineBlockersGenerator MNFMOEKMJKN()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineBlockersGenerator>();
		}
		return _instance;
	}

	public static GameObject KKMLEJJDJDN(int EONJGMONIOM, Vector3 IMOBLFMHKOD, Transform DMBHHLKMHOH, Direction FCGBJEIIMBC)
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		MineBlockerConfig mineBlockerConfig = ACPHFLBLJAA().blockerConfigs.Find((MineBlockerConfig f) => f.level == EONJGMONIOM);
		if ((Object)(object)mineBlockerConfig == (Object)null)
		{
			return null;
		}
		BlockerType blockerType = WeightedRandom.ICBIHJHDNHN(mineBlockerConfig.chances);
		if (blockerType == BlockerType.None)
		{
			return null;
		}
		if (MNFMOEKMJKN().FGNNCFGGMJK == null)
		{
			ACPHFLBLJAA().NIKEFPMNNOO();
		}
		if (!ACPHFLBLJAA().FGNNCFGGMJK.ContainsKey(blockerType))
		{
			Debug.LogError((object)("ReceiveDecorationFloor" + blockerType.ToString() + "Listen"));
			return null;
		}
		BlockerPrefabEntry blockerPrefabEntry = MNFMOEKMJKN().FGNNCFGGMJK[blockerType];
		GameObject val = (Utils.ABPDGOHBKIG(FCGBJEIIMBC) ? blockerPrefabEntry.horizontal : blockerPrefabEntry.vertical);
		GameObject val2 = null;
		if (Application.isPlaying)
		{
			val2 = Object.Instantiate<GameObject>(val, IMOBLFMHKOD, Quaternion.identity, DMBHHLKMHOH);
			if (OnlineManager.PlayingOnline())
			{
				ProceduralMine.CJLLMDLHACP(val2.GetComponent<OnlineObject>());
			}
		}
		MineManager.CEGJAHJMCOD(EONJGMONIOM).obstaclesInstantiated.Add(val2);
		if (FCGBJEIIMBC == Direction.Left)
		{
			val2.transform.localScale = new Vector3(283f, 1581f, 1027f);
		}
		return val2;
	}

	[SpecialName]
	public static MineBlockersGenerator NGIMIHFFNMH()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineBlockersGenerator>();
		}
		return _instance;
	}

	private void JBEDAAOKOBE()
	{
		FGNNCFGGMJK = new Dictionary<BlockerType, BlockerPrefabEntry>();
		foreach (BlockerPrefabEntry prefab in prefabs)
		{
			FGNNCFGGMJK[prefab.type] = prefab;
		}
	}

	private void OKLCJKEFLND()
	{
		FGNNCFGGMJK = new Dictionary<BlockerType, BlockerPrefabEntry>();
		foreach (BlockerPrefabEntry prefab in prefabs)
		{
			FGNNCFGGMJK[prefab.type] = prefab;
		}
	}

	private void PCHNEAAHLJM()
	{
		FGNNCFGGMJK = new Dictionary<BlockerType, BlockerPrefabEntry>();
		foreach (BlockerPrefabEntry prefab in prefabs)
		{
			FGNNCFGGMJK[prefab.type] = prefab;
		}
	}
}
