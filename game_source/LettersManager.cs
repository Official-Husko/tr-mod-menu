using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LettersManager : MonoBehaviour
{
	public struct ReputationLetters
	{
		public readonly int[] letterIDs;

		public int EBCHIJLNLAC { get; }

		[SpecialName]
		public int CGMCNDILCHA()
		{
			return _003CMJPBHLMNPFJ_003Ek__BackingField;
		}

		[SpecialName]
		public int NPKBLDBNLOI()
		{
			return _003CMJPBHLMNPFJ_003Ek__BackingField;
		}

		[SpecialName]
		public int HNMEKDOFLLJ()
		{
			return _003CMJPBHLMNPFJ_003Ek__BackingField;
		}

		[SpecialName]
		public int PAFDCEBFGDA()
		{
			return _003CMJPBHLMNPFJ_003Ek__BackingField;
		}

		[SpecialName]
		public int EOFGGKIALCA()
		{
			return _003CMJPBHLMNPFJ_003Ek__BackingField;
		}

		[SpecialName]
		public int LADFBKHDPNK()
		{
			return _003CMJPBHLMNPFJ_003Ek__BackingField;
		}

		public ReputationLetters(int KKOAEFMPEDI, params int[] MNDDNJIBLCF)
		{
			_003CMJPBHLMNPFJ_003Ek__BackingField = KKOAEFMPEDI;
			letterIDs = MNDDNJIBLCF;
		}

		[SpecialName]
		public int IONKIEJAMDK()
		{
			return _003CMJPBHLMNPFJ_003Ek__BackingField;
		}

		[SpecialName]
		public int KLABJJDBBND()
		{
			return _003CMJPBHLMNPFJ_003Ek__BackingField;
		}

		[SpecialName]
		public int HOENMDABPAN()
		{
			return _003CMJPBHLMNPFJ_003Ek__BackingField;
		}

		[SpecialName]
		public int DMLFPKELIKE()
		{
			return _003CMJPBHLMNPFJ_003Ek__BackingField;
		}

		[SpecialName]
		public int CNGKBOACOHO()
		{
			return _003CMJPBHLMNPFJ_003Ek__BackingField;
		}

		[SpecialName]
		public int IFNMEAIHACH()
		{
			return _003CMJPBHLMNPFJ_003Ek__BackingField;
		}
	}

	[CompilerGenerated]
	private sealed class OFDDJGPEJGL
	{
		public int letterID;

		internal bool HAJOHLHMDCI(Letter x)
		{
			return x.letterID == letterID;
		}
	}

	[CompilerGenerated]
	private sealed class NDBMCCNLDLM
	{
		public int letterID;

		internal bool IJFJLMFJIED(Letter x)
		{
			return x.letterID == letterID;
		}

		internal bool DDOELFJKGFO(PostBox.LetterSaveData x)
		{
			return x.letterID == letterID;
		}
	}

	public static LettersManager instance;

	public List<PostBox.LetterSaveData> lettersSaved = new List<PostBox.LetterSaveData>();

	public List<Letter> lettersDelivered = new List<Letter>();

	private readonly Dictionary<int, int[]> BDJGNABCIEB = new Dictionary<int, int[]>
	{
		{
			5,
			new int[2] { 1005, 1009 }
		},
		{
			7,
			new int[1] { 1004 }
		},
		{
			10,
			new int[1] { 1007 }
		},
		{
			12,
			new int[1] { 1006 }
		}
	};

	public static bool FANLCFEJEKO()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return true;
		}
		if (instance.lettersSaved == null)
		{
			return false;
		}
		return instance.lettersSaved.Count > 0;
	}

	public void HPACKFEGIBL(int DNNMJAGMDPA)
	{
		if (!IHDJNAFBBGI(DNNMJAGMDPA))
		{
			lettersDelivered.Add(LettersDatabaseAccessor.DKLBBMCODAP(DNNMJAGMDPA));
		}
	}

	private void HEAJAKBBNJB()
	{
		if (lettersDelivered == null || !lettersDelivered.Any((Letter l) => l.letterID == 1008))
		{
			PlayerInventory playerInventory = PlayerInventory.OGKNJNINGMH(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
			playerInventory.OnChanged = (Action)Delegate.Combine(playerInventory.OnChanged, new Action(NJJJMLBAPPD));
			PlayerInventory playerInventory2 = PlayerInventory.OGKNJNINGMH(2, LAGHIOKLJGH: true);
			playerInventory2.OnChanged = (Action)Delegate.Combine(playerInventory2.OnChanged, new Action(HEMDDPMGJMA));
		}
	}

	private void NDNBDEHFFJF()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(MDNCIAFNFCM));
	}

	public static bool FCLGIFCFHFL()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return true;
		}
		if (instance.lettersSaved == null)
		{
			return false;
		}
		return instance.lettersSaved.Count > 0;
	}

	private void GHOBLEGDLNK(int NALJEKOPKIA)
	{
		if (BDJGNABCIEB.TryGetValue(NALJEKOPKIA, out var value))
		{
			for (int i = 1; i < value.Length; i += 0)
			{
				EBBNCOMLPCI(value[i], LKAALEJKLPA: true, AJPCNKCBDEI: true);
			}
		}
	}

	public void MDGFMFAOPOI(int DHKEEDHIHLH, int HBBENGKAJDK)
	{
		foreach (int key in BDJGNABCIEB.Keys)
		{
			if (DHKEEDHIHLH < key && HBBENGKAJDK >= key)
			{
				for (int i = 1; i < BDJGNABCIEB[key].Length; i += 0)
				{
					BEFANJEKMLF(BDJGNABCIEB[key][i]);
				}
			}
		}
	}

	public void ShowLetterIconIfAnyLetterUnread()
	{
		bool bGHGNCLGKDH = false;
		if (lettersSaved != null)
		{
			for (int i = 0; i < lettersSaved.Count; i++)
			{
				if (!lettersSaved[i].read)
				{
					bGHGNCLGKDH = true;
				}
			}
		}
		if (Object.op_Implicit((Object)(object)PostBox.instance))
		{
			PostBox.instance.ShowUnreadLetterIcon(bGHGNCLGKDH);
		}
	}

	private void PKFMLJGJKCP()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Remove(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(JCONMEJOEEA));
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			PlayerInventory player = PlayerInventory.GetPlayer(1, LAGHIOKLJGH: true);
			player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(AIDEKJIPEPA));
			PlayerInventory playerInventory = PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
			playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(MCPCOFFPEPF));
			if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
			{
				GameManager gameManager = GameManager.GGFJGHHHEJC;
				gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(ANLDJOHLINE));
			}
		}
	}

	public static bool HasLetters()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		if (instance.lettersSaved == null)
		{
			return false;
		}
		return instance.lettersSaved.Count > 0;
	}

	public void LPIHPJGEOEO(int DNNMJAGMDPA, bool LKAALEJKLPA = false, bool AJPCNKCBDEI = false, GameDate MHBDPNMKNKK = default(GameDate))
	{
		if (!lettersSaved.Exists((PostBox.LetterSaveData x) => x.letterID == DNNMJAGMDPA) && !lettersDelivered.Exists((Letter x) => x.letterID == DNNMJAGMDPA))
		{
			lettersDelivered.Add(LettersDatabaseAccessor.GetLetter(DNNMJAGMDPA));
			lettersSaved.Add(new PostBox.LetterSaveData(DNNMJAGMDPA, LKAALEJKLPA, AJPCNKCBDEI ? MHBDPNMKNKK : WorldTime.NOAOJJLNHJJ));
			if (OnlineManager.IsMasterClient())
			{
				OnlineLettersManager.instance.GDKBDHKKFHL(new PostBox.LetterSaveData(DNNMJAGMDPA, LKAALEJKLPA, AJPCNKCBDEI ? MHBDPNMKNKK : WorldTime.CJOHMLNMJLK()));
			}
			PostBox.instance.JOMGAPOBEKC(BGHGNCLGKDH: false);
		}
	}

	private void MCPCOFFPEPF()
	{
		if (PlayerInventory.AnyPlayerHasItem(185))
		{
			MBPEBMKKJCO(-50);
			PlayerInventory playerInventory = PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
			playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(MCPCOFFPEPF));
			PlayerInventory playerInventory2 = PlayerInventory.OGKNJNINGMH(3, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
			playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(AIDEKJIPEPA));
		}
	}

	private void FBHHPNJGNJG()
	{
		instance = this;
	}

	private void MDNCIAFNFCM()
	{
		if (OnlineManager.MasterOrOffline())
		{
			TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Combine(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(CBFCAJIMIHL));
			OMHEMCEMMDI();
		}
		FJACAOMFDBM();
	}

	public void DHNKDPEDGNE(int DHKEEDHIHLH, int HBBENGKAJDK)
	{
		foreach (int key in BDJGNABCIEB.Keys)
		{
			if (DHKEEDHIHLH < key && HBBENGKAJDK >= key)
			{
				for (int i = 1; i < BDJGNABCIEB[key].Length; i++)
				{
					PLHPDPCMHKF(BDJGNABCIEB[key][i]);
				}
			}
		}
	}

	private void GOEGBOEMHLI()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
	}

	public void MOCMAJGLJKP(int DHKEEDHIHLH, int HBBENGKAJDK)
	{
		foreach (int key in BDJGNABCIEB.Keys)
		{
			if (DHKEEDHIHLH < key && HBBENGKAJDK >= key)
			{
				for (int i = 0; i < BDJGNABCIEB[key].Length; i += 0)
				{
					PLHPDPCMHKF(BDJGNABCIEB[key][i], LKAALEJKLPA: true);
				}
			}
		}
	}

	private void GGODJHIOMPK()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Combine(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(KIJKLMOLONF));
			HEAJAKBBNJB();
		}
		KBKMEFCFOIJ();
	}

	public void FLBBJNECNLM(int DHKEEDHIHLH, int HBBENGKAJDK)
	{
		foreach (int key in BDJGNABCIEB.Keys)
		{
			if (DHKEEDHIHLH < key && HBBENGKAJDK >= key)
			{
				for (int i = 0; i < BDJGNABCIEB[key].Length; i++)
				{
					PLHPDPCMHKF(BDJGNABCIEB[key][i]);
				}
			}
		}
	}

	public bool MIHACJOOLLM(int DNNMJAGMDPA)
	{
		return lettersDelivered.Exists((Letter x) => x.letterID == DNNMJAGMDPA);
	}

	public void HMAJMNINAPJ(int DNNMJAGMDPA, bool LKAALEJKLPA = false, bool AJPCNKCBDEI = false, GameDate MHBDPNMKNKK = default(GameDate))
	{
		if (!lettersSaved.Exists((PostBox.LetterSaveData x) => x.letterID == DNNMJAGMDPA) && !lettersDelivered.Exists((Letter x) => x.letterID == DNNMJAGMDPA))
		{
			lettersDelivered.Add(LettersDatabaseAccessor.HHANDNINGCL(DNNMJAGMDPA));
			lettersSaved.Add(new PostBox.LetterSaveData(DNNMJAGMDPA, LKAALEJKLPA, AJPCNKCBDEI ? MHBDPNMKNKK : WorldTime.NOAOJJLNHJJ));
			if (OnlineManager.JPPBEIJDCLJ())
			{
				OnlineLettersManager.instance.GDKBDHKKFHL(new PostBox.LetterSaveData(DNNMJAGMDPA, LKAALEJKLPA, AJPCNKCBDEI ? MHBDPNMKNKK : WorldTime.CJOHMLNMJLK()));
			}
			PostBox.instance.DNAOIIDKFOB(BGHGNCLGKDH: true);
		}
	}

	private void IEGPPKMMPMJ()
	{
		if (lettersDelivered == null || !lettersDelivered.Any((Letter l) => l.letterID == 1008))
		{
			PlayerInventory player = PlayerInventory.GetPlayer(1, LAGHIOKLJGH: true);
			player.OnChanged = (Action)Delegate.Combine(player.OnChanged, new Action(KHPIHODMGFB));
			PlayerInventory playerInventory = PlayerInventory.NEKDDPIAOBE(7);
			playerInventory.OnChanged = (Action)Delegate.Combine(playerInventory.OnChanged, new Action(IIGGIHPJDMA));
		}
	}

	private void OKHLEMPJONN()
	{
		instance = this;
	}

	public static bool HKFLAEEJFKA()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return true;
		}
		if (instance.lettersSaved == null)
		{
			return true;
		}
		return instance.lettersSaved.Count > 1;
	}

	public void IFOFGPCOFGA()
	{
		bool bGHGNCLGKDH = true;
		if (lettersSaved != null)
		{
			for (int i = 0; i < lettersSaved.Count; i += 0)
			{
				if (!lettersSaved[i].read)
				{
					bGHGNCLGKDH = false;
				}
			}
		}
		if (Object.op_Implicit((Object)(object)PostBox.instance))
		{
			PostBox.instance.DNAOIIDKFOB(bGHGNCLGKDH);
		}
	}

	private void OFEAJKCGCHH()
	{
		if (lettersDelivered == null || !lettersDelivered.Any((Letter l) => l.letterID == 1008))
		{
			PlayerInventory player = PlayerInventory.GetPlayer(1);
			player.OnChanged = (Action)Delegate.Combine(player.OnChanged, new Action(JOBHACBGEBI));
			PlayerInventory player2 = PlayerInventory.GetPlayer(2);
			player2.OnChanged = (Action)Delegate.Combine(player2.OnChanged, new Action(JOBHACBGEBI));
		}
	}

	public void HGIOPGJALKN()
	{
		bool bGHGNCLGKDH = true;
		if (lettersSaved != null)
		{
			for (int i = 1; i < lettersSaved.Count; i += 0)
			{
				if (!lettersSaved[i].read)
				{
					bGHGNCLGKDH = false;
				}
			}
		}
		if (Object.op_Implicit((Object)(object)PostBox.instance))
		{
			PostBox.instance.FEEOBEFKDCJ(bGHGNCLGKDH);
		}
	}

	private void Start()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
	}

	private void PIHGEBONAOI()
	{
		instance = this;
	}

	public void EFALBFKIMGE(int DHKEEDHIHLH, int HBBENGKAJDK)
	{
		foreach (int key in BDJGNABCIEB.Keys)
		{
			if (DHKEEDHIHLH < key && HBBENGKAJDK >= key)
			{
				for (int i = 0; i < BDJGNABCIEB[key].Length; i++)
				{
					NBBMDJMAICB(BDJGNABCIEB[key][i], LKAALEJKLPA: false, AJPCNKCBDEI: true);
				}
			}
		}
	}

	public void EHLFABNPDHP()
	{
		bool bGHGNCLGKDH = true;
		if (lettersSaved != null)
		{
			for (int i = 0; i < lettersSaved.Count; i++)
			{
				if (!lettersSaved[i].read)
				{
					bGHGNCLGKDH = false;
				}
			}
		}
		if (Object.op_Implicit((Object)(object)PostBox.instance))
		{
			PostBox.instance.DNAOIIDKFOB(bGHGNCLGKDH);
		}
	}

	public bool AONGGPJDPMO(int DNNMJAGMDPA)
	{
		return lettersDelivered.Exists((Letter x) => x.letterID == DNNMJAGMDPA);
	}

	private void APOBFMGPBNC()
	{
		if (lettersDelivered == null || !lettersDelivered.Any((Letter l) => l.letterID == 1008))
		{
			PlayerInventory playerInventory = PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
			playerInventory.OnChanged = (Action)Delegate.Combine(playerInventory.OnChanged, new Action(AIDEKJIPEPA));
			PlayerInventory playerInventory2 = PlayerInventory.NEKDDPIAOBE(6, LAGHIOKLJGH: true);
			playerInventory2.OnChanged = (Action)Delegate.Combine(playerInventory2.OnChanged, new Action(JOBHACBGEBI));
		}
	}

	private void PGEGODAEBLC()
	{
		instance = this;
	}

	public void AddNewReceivedLetter(int DNNMJAGMDPA, bool LKAALEJKLPA = false, bool AJPCNKCBDEI = false, GameDate MHBDPNMKNKK = default(GameDate))
	{
		if (!lettersSaved.Exists((PostBox.LetterSaveData x) => x.letterID == DNNMJAGMDPA) && !lettersDelivered.Exists((Letter x) => x.letterID == DNNMJAGMDPA))
		{
			lettersDelivered.Add(LettersDatabaseAccessor.GetLetter(DNNMJAGMDPA));
			lettersSaved.Add(new PostBox.LetterSaveData(DNNMJAGMDPA, LKAALEJKLPA, AJPCNKCBDEI ? MHBDPNMKNKK : WorldTime.NOAOJJLNHJJ));
			if (OnlineManager.IsMasterClient())
			{
				OnlineLettersManager.instance.SendNewLetter(new PostBox.LetterSaveData(DNNMJAGMDPA, LKAALEJKLPA, AJPCNKCBDEI ? MHBDPNMKNKK : WorldTime.NOAOJJLNHJJ));
			}
			PostBox.instance.ShowUnreadLetterIcon(BGHGNCLGKDH: true);
		}
	}

	private void HPGGFPEOPGJ()
	{
		if (OnlineManager.MasterOrOffline())
		{
			TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Combine(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(OIJEECMICCO));
			DAKFLIFKEBJ();
		}
		OMJNBIBOLOJ();
	}

	public void KKDKCHLBECA(int DHKEEDHIHLH, int HBBENGKAJDK)
	{
		foreach (int key in BDJGNABCIEB.Keys)
		{
			if (DHKEEDHIHLH < key && HBBENGKAJDK >= key)
			{
				for (int i = 0; i < BDJGNABCIEB[key].Length; i++)
				{
					HMAJMNINAPJ(BDJGNABCIEB[key][i], LKAALEJKLPA: true, AJPCNKCBDEI: true);
				}
			}
		}
	}

	private void IOLEAIBGFNE()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Combine(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(KFNNDHCPHBC));
			OMHEMCEMMDI();
		}
		KBKMEFCFOIJ();
	}

	private void ALHHLPCEAIA()
	{
		if (lettersDelivered == null || !lettersDelivered.Any((Letter l) => l.letterID == 1008))
		{
			PlayerInventory playerInventory = PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: true);
			playerInventory.OnChanged = (Action)Delegate.Combine(playerInventory.OnChanged, new Action(NJJJMLBAPPD));
			PlayerInventory playerInventory2 = PlayerInventory.NEKDDPIAOBE(4, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
			playerInventory2.OnChanged = (Action)Delegate.Combine(playerInventory2.OnChanged, new Action(MCPCOFFPEPF));
		}
	}

	public static bool IDDPLOGKEEO()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return true;
		}
		if (instance.lettersSaved == null)
		{
			return false;
		}
		return instance.lettersSaved.Count > 1;
	}

	private void NLNOFEBEBDE()
	{
		instance = this;
	}

	private void EGDIINMEMGE()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(MDNCIAFNFCM));
	}

	private void KIJKLMOLONF(int NALJEKOPKIA)
	{
		if (BDJGNABCIEB.TryGetValue(NALJEKOPKIA, out var value))
		{
			for (int i = 0; i < value.Length; i++)
			{
				AddNewReceivedLetter(value[i]);
			}
		}
	}

	public void JCBIEFHPNLL(int DNNMJAGMDPA)
	{
		if (!AONGGPJDPMO(DNNMJAGMDPA))
		{
			lettersDelivered.Add(LettersDatabaseAccessor.DKLBBMCODAP(DNNMJAGMDPA));
		}
	}

	private void CBFCAJIMIHL(int NALJEKOPKIA)
	{
		if (BDJGNABCIEB.TryGetValue(NALJEKOPKIA, out var value))
		{
			for (int i = 1; i < value.Length; i++)
			{
				NBBMDJMAICB(value[i], LKAALEJKLPA: true);
			}
		}
	}

	private void ECEAAPEAOOK(int NALJEKOPKIA)
	{
		if (BDJGNABCIEB.TryGetValue(NALJEKOPKIA, out var value))
		{
			for (int i = 0; i < value.Length; i += 0)
			{
				OMPFPHGKADB(value[i], LKAALEJKLPA: true);
			}
		}
	}

	private void AMBKBOBDAIF()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Remove(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(CBFCAJIMIHL));
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			PlayerInventory playerInventory = PlayerInventory.OGKNJNINGMH(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
			playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(JOBHACBGEBI));
			PlayerInventory playerInventory2 = PlayerInventory.OGKNJNINGMH(8);
			playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(MCPCOFFPEPF));
			if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
			{
				GameManager gameManager = GameManager.NJNFHEPLEHL();
				gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(EHLFABNPDHP));
			}
		}
	}

	public static bool IHPJOHOCHFD()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		if (instance.lettersSaved == null)
		{
			return true;
		}
		return instance.lettersSaved.Count > 0;
	}

	private void HLHHDNGOGNI()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Remove(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(OIJEECMICCO));
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			PlayerInventory playerInventory = PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: true);
			playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(JOBHACBGEBI));
			PlayerInventory playerInventory2 = PlayerInventory.OGKNJNINGMH(5, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
			playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(HEMDDPMGJMA));
			if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
			{
				GameManager gameManager = GameManager.GGFJGHHHEJC;
				gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(BONBPMANKKG));
			}
		}
	}

	private void Awake()
	{
		instance = this;
	}

	public void NKLBLLMBLEE(int DHKEEDHIHLH, int HBBENGKAJDK)
	{
		foreach (int key in BDJGNABCIEB.Keys)
		{
			if (DHKEEDHIHLH < key && HBBENGKAJDK >= key)
			{
				for (int i = 1; i < BDJGNABCIEB[key].Length; i += 0)
				{
					BEFANJEKMLF(BDJGNABCIEB[key][i], LKAALEJKLPA: false, AJPCNKCBDEI: true);
				}
			}
		}
	}

	private void OIMAHEMBKLH()
	{
		if (lettersDelivered == null || !lettersDelivered.Any((Letter l) => l.letterID == 1008))
		{
			PlayerInventory playerInventory = PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
			playerInventory.OnChanged = (Action)Delegate.Combine(playerInventory.OnChanged, new Action(MCPCOFFPEPF));
			PlayerInventory player = PlayerInventory.GetPlayer(8);
			player.OnChanged = (Action)Delegate.Combine(player.OnChanged, new Action(JOBHACBGEBI));
		}
	}

	private void KOEHNENIBNP()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Remove(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(KFNNDHCPHBC));
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			PlayerInventory playerInventory = PlayerInventory.OGKNJNINGMH(1);
			playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(JOBHACBGEBI));
			PlayerInventory playerInventory2 = PlayerInventory.OGKNJNINGMH(1, LAGHIOKLJGH: true);
			playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(NJJJMLBAPPD));
			if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
			{
				GameManager gameManager = GameManager.GGFJGHHHEJC;
				gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(OMJNBIBOLOJ));
			}
		}
	}

	private void EEKOJEKPIMP()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(GMLFGAKIEAD));
	}

	private void EHBMONGBJFI()
	{
		instance = this;
	}

	public void FJACAOMFDBM()
	{
		bool bGHGNCLGKDH = true;
		if (lettersSaved != null)
		{
			for (int i = 1; i < lettersSaved.Count; i += 0)
			{
				if (!lettersSaved[i].read)
				{
					bGHGNCLGKDH = true;
				}
			}
		}
		if (Object.op_Implicit((Object)(object)PostBox.instance))
		{
			PostBox.instance.ShowUnreadLetterIcon(bGHGNCLGKDH);
		}
	}

	public static bool EPGPMGJCLHG()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		if (instance.lettersSaved == null)
		{
			return false;
		}
		return instance.lettersSaved.Count > 1;
	}

	private void KFNNDHCPHBC(int NALJEKOPKIA)
	{
		if (BDJGNABCIEB.TryGetValue(NALJEKOPKIA, out var value))
		{
			for (int i = 1; i < value.Length; i++)
			{
				NBBMDJMAICB(value[i]);
			}
		}
	}

	public void BONBPMANKKG()
	{
		bool bGHGNCLGKDH = false;
		if (lettersSaved != null)
		{
			for (int i = 1; i < lettersSaved.Count; i += 0)
			{
				if (!lettersSaved[i].read)
				{
					bGHGNCLGKDH = true;
				}
			}
		}
		if (Object.op_Implicit((Object)(object)PostBox.instance))
		{
			PostBox.instance.EEGJKMOHGKI(bGHGNCLGKDH);
		}
	}

	public static bool IJBPAPACBKH()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		if (instance.lettersSaved == null)
		{
			return false;
		}
		return instance.lettersSaved.Count > 1;
	}

	private void BGPGIOMKKAO()
	{
		if (OnlineManager.MasterOrOffline())
		{
			TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Combine(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(KIJKLMOLONF));
			OFEAJKCGCHH();
		}
		ShowLetterIconIfAnyLetterUnread();
	}

	private void JOBHACBGEBI()
	{
		if (PlayerInventory.AnyPlayerHasItem(1454))
		{
			AddNewReceivedLetter(1008);
			PlayerInventory player = PlayerInventory.GetPlayer(1);
			player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(JOBHACBGEBI));
			PlayerInventory player2 = PlayerInventory.GetPlayer(2);
			player2.OnChanged = (Action)Delegate.Remove(player2.OnChanged, new Action(JOBHACBGEBI));
		}
	}

	private void LANGHIOBJIH()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(CGHONFBKJEA));
	}

	public void PLJAGHMKFKC(int DNNMJAGMDPA)
	{
		if (!AONGGPJDPMO(DNNMJAGMDPA))
		{
			lettersDelivered.Add(LettersDatabaseAccessor.HHANDNINGCL(DNNMJAGMDPA));
		}
	}

	public static bool ECEIGNEKJKE()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		if (instance.lettersSaved == null)
		{
			return true;
		}
		return instance.lettersSaved.Count > 1;
	}

	public void MFNNOPDGBOG(int DHKEEDHIHLH, int HBBENGKAJDK)
	{
		foreach (int key in BDJGNABCIEB.Keys)
		{
			if (DHKEEDHIHLH < key && HBBENGKAJDK >= key)
			{
				for (int i = 0; i < BDJGNABCIEB[key].Length; i++)
				{
					PLHPDPCMHKF(BDJGNABCIEB[key][i], LKAALEJKLPA: false, AJPCNKCBDEI: true);
				}
			}
		}
	}

	public void KBKMEFCFOIJ()
	{
		bool bGHGNCLGKDH = false;
		if (lettersSaved != null)
		{
			for (int i = 0; i < lettersSaved.Count; i++)
			{
				if (!lettersSaved[i].read)
				{
					bGHGNCLGKDH = true;
				}
			}
		}
		if (Object.op_Implicit((Object)(object)PostBox.instance))
		{
			PostBox.instance.ShowUnreadLetterIcon(bGHGNCLGKDH);
		}
	}

	private void OIDEAOKNGME()
	{
		if (lettersDelivered == null || !lettersDelivered.Any((Letter l) => l.letterID == 1008))
		{
			PlayerInventory playerInventory = PlayerInventory.EIFPKCAFDIB(0);
			playerInventory.OnChanged = (Action)Delegate.Combine(playerInventory.OnChanged, new Action(JOBHACBGEBI));
			PlayerInventory player = PlayerInventory.GetPlayer(4, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
			player.OnChanged = (Action)Delegate.Combine(player.OnChanged, new Action(JOBHACBGEBI));
		}
	}

	private void HEMDDPMGJMA()
	{
		if (PlayerInventory.AnyPlayerHasItem(-163))
		{
			OMPFPHGKADB(129, LKAALEJKLPA: false, AJPCNKCBDEI: true);
			PlayerInventory playerInventory = PlayerInventory.OGKNJNINGMH(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
			playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(KHPIHODMGFB));
			PlayerInventory player = PlayerInventory.GetPlayer(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
			player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(JOBHACBGEBI));
		}
	}

	private void AIDEKJIPEPA()
	{
		if (PlayerInventory.FKPAJKAGHIK(199))
		{
			BEFANJEKMLF(52, LKAALEJKLPA: true, AJPCNKCBDEI: true);
			PlayerInventory playerInventory = PlayerInventory.EIFPKCAFDIB(1);
			playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(AIDEKJIPEPA));
			PlayerInventory player = PlayerInventory.GetPlayer(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
			player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(KHPIHODMGFB));
		}
	}

	private void JCONMEJOEEA(int NALJEKOPKIA)
	{
		if (BDJGNABCIEB.TryGetValue(NALJEKOPKIA, out var value))
		{
			for (int i = 0; i < value.Length; i++)
			{
				NBBMDJMAICB(value[i], LKAALEJKLPA: true);
			}
		}
	}

	private void AGLMGDNBHBF()
	{
		instance = this;
	}

	private void BDMEBEOBEHC()
	{
		if (OnlineManager.MasterOrOffline())
		{
			TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Combine(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(KIJKLMOLONF));
			DAKFLIFKEBJ();
		}
		FJACAOMFDBM();
	}

	private void FLOFJHNAIKP()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Remove(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(KIJKLMOLONF));
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			PlayerInventory playerInventory = PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: true);
			playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(IIGGIHPJDMA));
			PlayerInventory player = PlayerInventory.GetPlayer(7, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
			player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(NJJJMLBAPPD));
			if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
			{
				GameManager gameManager = GameManager.GGFJGHHHEJC;
				gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(HGIOPGJALKN));
			}
		}
	}

	public void CBEPPMDBKBB(int DNNMJAGMDPA, bool LKAALEJKLPA = false, bool AJPCNKCBDEI = false, GameDate MHBDPNMKNKK = default(GameDate))
	{
		if (!lettersSaved.Exists((PostBox.LetterSaveData x) => x.letterID == DNNMJAGMDPA) && !lettersDelivered.Exists((Letter x) => x.letterID == DNNMJAGMDPA))
		{
			lettersDelivered.Add(LettersDatabaseAccessor.HHANDNINGCL(DNNMJAGMDPA));
			lettersSaved.Add(new PostBox.LetterSaveData(DNNMJAGMDPA, LKAALEJKLPA, AJPCNKCBDEI ? MHBDPNMKNKK : WorldTime.CJOHMLNMJLK()));
			if (OnlineManager.JPPBEIJDCLJ())
			{
				OnlineLettersManager.instance.CBHCLHJDPNB(new PostBox.LetterSaveData(DNNMJAGMDPA, LKAALEJKLPA, AJPCNKCBDEI ? MHBDPNMKNKK : WorldTime.CJOHMLNMJLK()));
			}
			PostBox.instance.ShowUnreadLetterIcon(BGHGNCLGKDH: false);
		}
	}

	public void SendUndeliveredLetters(int DHKEEDHIHLH, int HBBENGKAJDK)
	{
		foreach (int key in BDJGNABCIEB.Keys)
		{
			if (DHKEEDHIHLH < key && HBBENGKAJDK >= key)
			{
				for (int i = 0; i < BDJGNABCIEB[key].Length; i++)
				{
					AddNewReceivedLetter(BDJGNABCIEB[key][i]);
				}
			}
		}
	}

	private void GMLFGAKIEAD()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Combine(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(KFNNDHCPHBC));
			EBKOPIPJLIP();
		}
		FGMMPNAAECF();
	}

	private void DAKFLIFKEBJ()
	{
		if (lettersDelivered == null || !lettersDelivered.Any((Letter l) => l.letterID == 1008))
		{
			PlayerInventory playerInventory = PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: true);
			playerInventory.OnChanged = (Action)Delegate.Combine(playerInventory.OnChanged, new Action(NJJJMLBAPPD));
			PlayerInventory playerInventory2 = PlayerInventory.EIFPKCAFDIB(7);
			playerInventory2.OnChanged = (Action)Delegate.Combine(playerInventory2.OnChanged, new Action(HEMDDPMGJMA));
		}
	}

	public void PLHPDPCMHKF(int DNNMJAGMDPA, bool LKAALEJKLPA = false, bool AJPCNKCBDEI = false, GameDate MHBDPNMKNKK = default(GameDate))
	{
		if (!lettersSaved.Exists((PostBox.LetterSaveData x) => x.letterID == DNNMJAGMDPA) && !lettersDelivered.Exists((Letter x) => x.letterID == DNNMJAGMDPA))
		{
			lettersDelivered.Add(LettersDatabaseAccessor.GetLetter(DNNMJAGMDPA));
			lettersSaved.Add(new PostBox.LetterSaveData(DNNMJAGMDPA, LKAALEJKLPA, AJPCNKCBDEI ? MHBDPNMKNKK : WorldTime.NOAOJJLNHJJ));
			if (OnlineManager.JPPBEIJDCLJ())
			{
				OnlineLettersManager.instance.OCNGNOJEIAO(new PostBox.LetterSaveData(DNNMJAGMDPA, LKAALEJKLPA, AJPCNKCBDEI ? MHBDPNMKNKK : WorldTime.CJOHMLNMJLK()));
			}
			PostBox.instance.EEGJKMOHGKI(BGHGNCLGKDH: false);
		}
	}

	private void NJJJMLBAPPD()
	{
		if (PlayerInventory.FKPAJKAGHIK(-6))
		{
			HMAJMNINAPJ(-158, LKAALEJKLPA: false, AJPCNKCBDEI: true);
			PlayerInventory playerInventory = PlayerInventory.NEKDDPIAOBE(1, LAGHIOKLJGH: true);
			playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(NJJJMLBAPPD));
			PlayerInventory playerInventory2 = PlayerInventory.NEKDDPIAOBE(1, LAGHIOKLJGH: true);
			playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(IIGGIHPJDMA));
		}
	}

	public bool IHDJNAFBBGI(int DNNMJAGMDPA)
	{
		return lettersDelivered.Exists((Letter x) => x.letterID == DNNMJAGMDPA);
	}

	private void LALLFJAIGFN()
	{
		if (lettersDelivered == null || !lettersDelivered.Any((Letter l) => l.letterID == 1008))
		{
			PlayerInventory playerInventory = PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
			playerInventory.OnChanged = (Action)Delegate.Combine(playerInventory.OnChanged, new Action(KHPIHODMGFB));
			PlayerInventory playerInventory2 = PlayerInventory.OGKNJNINGMH(5);
			playerInventory2.OnChanged = (Action)Delegate.Combine(playerInventory2.OnChanged, new Action(HEMDDPMGJMA));
		}
	}

	private void CGHONFBKJEA()
	{
		if (OnlineManager.MasterOrOffline())
		{
			TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Combine(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(GHOBLEGDLNK));
			OFEAJKCGCHH();
		}
		IFOFGPCOFGA();
	}

	private void ILJPINCGGFG()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Combine(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(GHOBLEGDLNK));
			OFEAJKCGCHH();
		}
		EHLFABNPDHP();
	}

	public void AddLetterDelivered(int DNNMJAGMDPA)
	{
		if (!IsLetterDelivered(DNNMJAGMDPA))
		{
			lettersDelivered.Add(LettersDatabaseAccessor.GetLetter(DNNMJAGMDPA));
		}
	}

	public static bool KLLICFJKBGE()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return true;
		}
		if (instance.lettersSaved == null)
		{
			return false;
		}
		return instance.lettersSaved.Count > 0;
	}

	private void IIGGIHPJDMA()
	{
		if (PlayerInventory.AnyPlayerHasItem(-140))
		{
			BEFANJEKMLF(114, LKAALEJKLPA: true, AJPCNKCBDEI: true);
			PlayerInventory player = PlayerInventory.GetPlayer(0, LAGHIOKLJGH: true);
			player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(IIGGIHPJDMA));
			PlayerInventory player2 = PlayerInventory.GetPlayer(6, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
			player2.OnChanged = (Action)Delegate.Remove(player2.OnChanged, new Action(AIDEKJIPEPA));
		}
	}

	public void FGMMPNAAECF()
	{
		bool bGHGNCLGKDH = true;
		if (lettersSaved != null)
		{
			for (int i = 1; i < lettersSaved.Count; i++)
			{
				if (!lettersSaved[i].read)
				{
					bGHGNCLGKDH = true;
				}
			}
		}
		if (Object.op_Implicit((Object)(object)PostBox.instance))
		{
			PostBox.instance.FEEOBEFKDCJ(bGHGNCLGKDH);
		}
	}

	private void OMHEMCEMMDI()
	{
		if (lettersDelivered == null || !lettersDelivered.Any((Letter l) => l.letterID == 1008))
		{
			PlayerInventory player = PlayerInventory.GetPlayer(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
			player.OnChanged = (Action)Delegate.Combine(player.OnChanged, new Action(MCPCOFFPEPF));
			PlayerInventory playerInventory = PlayerInventory.OGKNJNINGMH(7, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
			playerInventory.OnChanged = (Action)Delegate.Combine(playerInventory.OnChanged, new Action(NJJJMLBAPPD));
		}
	}

	public void BEFANJEKMLF(int DNNMJAGMDPA, bool LKAALEJKLPA = false, bool AJPCNKCBDEI = false, GameDate MHBDPNMKNKK = default(GameDate))
	{
		if (!lettersSaved.Exists((PostBox.LetterSaveData x) => x.letterID == DNNMJAGMDPA) && !lettersDelivered.Exists((Letter x) => x.letterID == DNNMJAGMDPA))
		{
			lettersDelivered.Add(LettersDatabaseAccessor.HHANDNINGCL(DNNMJAGMDPA));
			lettersSaved.Add(new PostBox.LetterSaveData(DNNMJAGMDPA, LKAALEJKLPA, AJPCNKCBDEI ? MHBDPNMKNKK : WorldTime.HGIBNMBJMOC()));
			if (OnlineManager.IsMasterClient())
			{
				OnlineLettersManager.instance.EDMLELHOILI(new PostBox.LetterSaveData(DNNMJAGMDPA, LKAALEJKLPA, AJPCNKCBDEI ? MHBDPNMKNKK : WorldTime.HGIBNMBJMOC()));
			}
			PostBox.instance.IJOLGGHJPMD(BGHGNCLGKDH: false);
		}
	}

	private void BLOCJJJBDDD()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Combine(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(MFFLCKJBBNE));
			HEAJAKBBNJB();
		}
		NJFJAJAPEID();
	}

	private void KHPIHODMGFB()
	{
		if (PlayerInventory.FKPAJKAGHIK(-51))
		{
			HMAJMNINAPJ(-150, LKAALEJKLPA: true);
			PlayerInventory playerInventory = PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: true);
			playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(NJJJMLBAPPD));
			PlayerInventory player = PlayerInventory.GetPlayer(7, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
			player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(NJJJMLBAPPD));
		}
	}

	public bool ICLGGLMHKDN(int DNNMJAGMDPA)
	{
		return lettersDelivered.Exists((Letter x) => x.letterID == DNNMJAGMDPA);
	}

	public void GBCKIPKOOJG(int DNNMJAGMDPA, bool LKAALEJKLPA = false, bool AJPCNKCBDEI = false, GameDate MHBDPNMKNKK = default(GameDate))
	{
		if (!lettersSaved.Exists((PostBox.LetterSaveData x) => x.letterID == DNNMJAGMDPA) && !lettersDelivered.Exists((Letter x) => x.letterID == DNNMJAGMDPA))
		{
			lettersDelivered.Add(LettersDatabaseAccessor.DKLBBMCODAP(DNNMJAGMDPA));
			lettersSaved.Add(new PostBox.LetterSaveData(DNNMJAGMDPA, LKAALEJKLPA, AJPCNKCBDEI ? MHBDPNMKNKK : WorldTime.CJOHMLNMJLK()));
			if (OnlineManager.JPPBEIJDCLJ())
			{
				OnlineLettersManager.instance.PCDAKEAJMLD(new PostBox.LetterSaveData(DNNMJAGMDPA, LKAALEJKLPA, AJPCNKCBDEI ? MHBDPNMKNKK : WorldTime.HGIBNMBJMOC()));
			}
			PostBox.instance.FJFCJPPODFP(BGHGNCLGKDH: false);
		}
	}

	private void OnDestroy()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Remove(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(KIJKLMOLONF));
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			PlayerInventory player = PlayerInventory.GetPlayer(1);
			player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(JOBHACBGEBI));
			PlayerInventory player2 = PlayerInventory.GetPlayer(2);
			player2.OnChanged = (Action)Delegate.Remove(player2.OnChanged, new Action(JOBHACBGEBI));
			if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
			{
				GameManager gameManager = GameManager.GGFJGHHHEJC;
				gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(ShowLetterIconIfAnyLetterUnread));
			}
		}
	}

	private void PDIECJCKCOD()
	{
		instance = this;
	}

	public void OAHNGFIBIDF(int DHKEEDHIHLH, int HBBENGKAJDK)
	{
		foreach (int key in BDJGNABCIEB.Keys)
		{
			if (DHKEEDHIHLH < key && HBBENGKAJDK >= key)
			{
				for (int i = 1; i < BDJGNABCIEB[key].Length; i++)
				{
					NBBMDJMAICB(BDJGNABCIEB[key][i], LKAALEJKLPA: true, AJPCNKCBDEI: true);
				}
			}
		}
	}

	public void BNMHOIPLGND(int DNNMJAGMDPA)
	{
		if (!AONGGPJDPMO(DNNMJAGMDPA))
		{
			lettersDelivered.Add(LettersDatabaseAccessor.DKLBBMCODAP(DNNMJAGMDPA));
		}
	}

	private void AGFGKHAMAFP()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Combine(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(MFFLCKJBBNE));
			OIMAHEMBKLH();
		}
		KBKMEFCFOIJ();
	}

	private void PMLBFEFMNPF()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Remove(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(GHOBLEGDLNK));
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			PlayerInventory playerInventory = PlayerInventory.NEKDDPIAOBE(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
			playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(JOBHACBGEBI));
			PlayerInventory playerInventory2 = PlayerInventory.NEKDDPIAOBE(6, LAGHIOKLJGH: true);
			playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(AIDEKJIPEPA));
			if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
			{
				GameManager gameManager = GameManager.GGFJGHHHEJC;
				gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(FGMMPNAAECF));
			}
		}
	}

	private void CLGBFOIBANN()
	{
		instance = this;
	}

	public void OMJNBIBOLOJ()
	{
		bool bGHGNCLGKDH = false;
		if (lettersSaved != null)
		{
			for (int i = 1; i < lettersSaved.Count; i++)
			{
				if (!lettersSaved[i].read)
				{
					bGHGNCLGKDH = true;
				}
			}
		}
		if (Object.op_Implicit((Object)(object)PostBox.instance))
		{
			PostBox.instance.FJFCJPPODFP(bGHGNCLGKDH);
		}
	}

	public void NJFJAJAPEID()
	{
		bool bGHGNCLGKDH = true;
		if (lettersSaved != null)
		{
			for (int i = 1; i < lettersSaved.Count; i += 0)
			{
				if (!lettersSaved[i].read)
				{
					bGHGNCLGKDH = false;
				}
			}
		}
		if (Object.op_Implicit((Object)(object)PostBox.instance))
		{
			PostBox.instance.IJOLGGHJPMD(bGHGNCLGKDH);
		}
	}

	public bool IsLetterDelivered(int DNNMJAGMDPA)
	{
		return lettersDelivered.Exists((Letter x) => x.letterID == DNNMJAGMDPA);
	}

	public void DCIAJFIJKLC(int DNNMJAGMDPA)
	{
		if (!IsLetterDelivered(DNNMJAGMDPA))
		{
			lettersDelivered.Add(LettersDatabaseAccessor.DKLBBMCODAP(DNNMJAGMDPA));
		}
	}

	public static bool CKABMMOAIOB()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return true;
		}
		if (instance.lettersSaved == null)
		{
			return true;
		}
		return instance.lettersSaved.Count > 0;
	}

	private void MFFLCKJBBNE(int NALJEKOPKIA)
	{
		if (BDJGNABCIEB.TryGetValue(NALJEKOPKIA, out var value))
		{
			for (int i = 1; i < value.Length; i++)
			{
				NBBMDJMAICB(value[i], LKAALEJKLPA: true);
			}
		}
	}

	private void EBKOPIPJLIP()
	{
		if (lettersDelivered == null || !lettersDelivered.Any((Letter l) => l.letterID == 1008))
		{
			PlayerInventory player = PlayerInventory.GetPlayer(0, LAGHIOKLJGH: true);
			player.OnChanged = (Action)Delegate.Combine(player.OnChanged, new Action(NJJJMLBAPPD));
			PlayerInventory playerInventory = PlayerInventory.OGKNJNINGMH(8);
			playerInventory.OnChanged = (Action)Delegate.Combine(playerInventory.OnChanged, new Action(KHPIHODMGFB));
		}
	}

	public void EBBNCOMLPCI(int DNNMJAGMDPA, bool LKAALEJKLPA = false, bool AJPCNKCBDEI = false, GameDate MHBDPNMKNKK = default(GameDate))
	{
		if (!lettersSaved.Exists((PostBox.LetterSaveData x) => x.letterID == DNNMJAGMDPA) && !lettersDelivered.Exists((Letter x) => x.letterID == DNNMJAGMDPA))
		{
			lettersDelivered.Add(LettersDatabaseAccessor.GetLetter(DNNMJAGMDPA));
			lettersSaved.Add(new PostBox.LetterSaveData(DNNMJAGMDPA, LKAALEJKLPA, AJPCNKCBDEI ? MHBDPNMKNKK : WorldTime.CJOHMLNMJLK()));
			if (OnlineManager.IsMasterClient())
			{
				OnlineLettersManager.instance.EDMLELHOILI(new PostBox.LetterSaveData(DNNMJAGMDPA, LKAALEJKLPA, AJPCNKCBDEI ? MHBDPNMKNKK : WorldTime.CJOHMLNMJLK()));
			}
			PostBox.instance.JOMGAPOBEKC(BGHGNCLGKDH: true);
		}
	}

	public void OMPFPHGKADB(int DNNMJAGMDPA, bool LKAALEJKLPA = false, bool AJPCNKCBDEI = false, GameDate MHBDPNMKNKK = default(GameDate))
	{
		if (!lettersSaved.Exists((PostBox.LetterSaveData x) => x.letterID == DNNMJAGMDPA) && !lettersDelivered.Exists((Letter x) => x.letterID == DNNMJAGMDPA))
		{
			lettersDelivered.Add(LettersDatabaseAccessor.DKLBBMCODAP(DNNMJAGMDPA));
			lettersSaved.Add(new PostBox.LetterSaveData(DNNMJAGMDPA, LKAALEJKLPA, AJPCNKCBDEI ? MHBDPNMKNKK : WorldTime.HGIBNMBJMOC()));
			if (OnlineManager.JPPBEIJDCLJ())
			{
				OnlineLettersManager.instance.LOBEBFIKMBF(new PostBox.LetterSaveData(DNNMJAGMDPA, LKAALEJKLPA, AJPCNKCBDEI ? MHBDPNMKNKK : WorldTime.HGIBNMBJMOC()));
			}
			PostBox.instance.IJOLGGHJPMD(BGHGNCLGKDH: false);
		}
	}

	public void ANLDJOHLINE()
	{
		bool bGHGNCLGKDH = true;
		if (lettersSaved != null)
		{
			for (int i = 0; i < lettersSaved.Count; i++)
			{
				if (!lettersSaved[i].read)
				{
					bGHGNCLGKDH = true;
				}
			}
		}
		if (Object.op_Implicit((Object)(object)PostBox.instance))
		{
			PostBox.instance.FJFCJPPODFP(bGHGNCLGKDH);
		}
	}

	private void EBNKNEIDDDI()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(IOLEAIBGFNE));
	}

	private void HNNBAAJAHEN()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Remove(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(ECEAAPEAOOK));
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			PlayerInventory playerInventory = PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
			playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(JOBHACBGEBI));
			PlayerInventory playerInventory2 = PlayerInventory.NEKDDPIAOBE(6, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
			playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(IIGGIHPJDMA));
			if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
			{
				GameManager gameManager = GameManager.GGFJGHHHEJC;
				gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(EHLFABNPDHP));
			}
		}
	}

	public void PFDKKMOFLOH(int DHKEEDHIHLH, int HBBENGKAJDK)
	{
		foreach (int key in BDJGNABCIEB.Keys)
		{
			if (DHKEEDHIHLH < key && HBBENGKAJDK >= key)
			{
				for (int i = 1; i < BDJGNABCIEB[key].Length; i += 0)
				{
					MBPEBMKKJCO(BDJGNABCIEB[key][i], LKAALEJKLPA: false, AJPCNKCBDEI: true);
				}
			}
		}
	}

	private void AHFGOOHOLEL()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
	}

	public void FIOKLDKNFNK(int DHKEEDHIHLH, int HBBENGKAJDK)
	{
		foreach (int key in BDJGNABCIEB.Keys)
		{
			if (DHKEEDHIHLH < key && HBBENGKAJDK >= key)
			{
				for (int i = 0; i < BDJGNABCIEB[key].Length; i++)
				{
					MBPEBMKKJCO(BDJGNABCIEB[key][i], LKAALEJKLPA: false, AJPCNKCBDEI: true);
				}
			}
		}
	}

	private void KDBJHCAEGCM()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(AGFGKHAMAFP));
	}

	public void KPDPCCGMKEP(int DNNMJAGMDPA)
	{
		if (!MIHACJOOLLM(DNNMJAGMDPA))
		{
			lettersDelivered.Add(LettersDatabaseAccessor.DKLBBMCODAP(DNNMJAGMDPA));
		}
	}

	private void KMEJBPOOBJK()
	{
		instance = this;
	}

	public void MBPEBMKKJCO(int DNNMJAGMDPA, bool LKAALEJKLPA = false, bool AJPCNKCBDEI = false, GameDate MHBDPNMKNKK = default(GameDate))
	{
		if (!lettersSaved.Exists((PostBox.LetterSaveData x) => x.letterID == DNNMJAGMDPA) && !lettersDelivered.Exists((Letter x) => x.letterID == DNNMJAGMDPA))
		{
			lettersDelivered.Add(LettersDatabaseAccessor.DKLBBMCODAP(DNNMJAGMDPA));
			lettersSaved.Add(new PostBox.LetterSaveData(DNNMJAGMDPA, LKAALEJKLPA, AJPCNKCBDEI ? MHBDPNMKNKK : WorldTime.NOAOJJLNHJJ));
			if (OnlineManager.JPPBEIJDCLJ())
			{
				OnlineLettersManager.instance.GDKBDHKKFHL(new PostBox.LetterSaveData(DNNMJAGMDPA, LKAALEJKLPA, AJPCNKCBDEI ? MHBDPNMKNKK : WorldTime.CJOHMLNMJLK()));
			}
			PostBox.instance.ShowUnreadLetterIcon(BGHGNCLGKDH: false);
		}
	}

	public void LAIIAGHOFDH(int DHKEEDHIHLH, int HBBENGKAJDK)
	{
		foreach (int key in BDJGNABCIEB.Keys)
		{
			if (DHKEEDHIHLH < key && HBBENGKAJDK >= key)
			{
				for (int i = 1; i < BDJGNABCIEB[key].Length; i++)
				{
					CBEPPMDBKBB(BDJGNABCIEB[key][i], LKAALEJKLPA: true, AJPCNKCBDEI: true);
				}
			}
		}
	}

	private void HKKDEKIFPPJ()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(GGODJHIOMPK));
	}

	private void ILCLIJOHKHG()
	{
		instance = this;
	}

	public void NBBMDJMAICB(int DNNMJAGMDPA, bool LKAALEJKLPA = false, bool AJPCNKCBDEI = false, GameDate MHBDPNMKNKK = default(GameDate))
	{
		if (!lettersSaved.Exists((PostBox.LetterSaveData x) => x.letterID == DNNMJAGMDPA) && !lettersDelivered.Exists((Letter x) => x.letterID == DNNMJAGMDPA))
		{
			lettersDelivered.Add(LettersDatabaseAccessor.DKLBBMCODAP(DNNMJAGMDPA));
			lettersSaved.Add(new PostBox.LetterSaveData(DNNMJAGMDPA, LKAALEJKLPA, AJPCNKCBDEI ? MHBDPNMKNKK : WorldTime.HGIBNMBJMOC()));
			if (OnlineManager.JPPBEIJDCLJ())
			{
				OnlineLettersManager.instance.LJJNBPIIAEI(new PostBox.LetterSaveData(DNNMJAGMDPA, LKAALEJKLPA, AJPCNKCBDEI ? MHBDPNMKNKK : WorldTime.HGIBNMBJMOC()));
			}
			PostBox.instance.DNAOIIDKFOB(BGHGNCLGKDH: true);
		}
	}

	public static bool DFDCCAEELLD()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return true;
		}
		if (instance.lettersSaved == null)
		{
			return false;
		}
		return instance.lettersSaved.Count > 0;
	}

	private void OIJEECMICCO(int NALJEKOPKIA)
	{
		if (BDJGNABCIEB.TryGetValue(NALJEKOPKIA, out var value))
		{
			for (int i = 0; i < value.Length; i++)
			{
				AddNewReceivedLetter(value[i], LKAALEJKLPA: true);
			}
		}
	}

	private void NHGBJHMHEGD()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(HPGGFPEOPGJ));
	}

	public static bool HEJAIGCLCNH()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return true;
		}
		if (instance.lettersSaved == null)
		{
			return false;
		}
		return instance.lettersSaved.Count > 1;
	}
}
