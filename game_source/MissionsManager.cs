using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using WebSocketSharp;

public class MissionsManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class KJNKMAPCKFP : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MissionsManager _003C_003E4__this;

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
		public KJNKMAPCKFP(int _003C_003E1__state)
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
			MissionsManager missionsManager = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait03;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				Debug.Log((object)"CheckFocusedMission");
				if (IIHAJPKBMIP() && PLMLDMJIJMN() && (Object)(object)QuestManager.GGFJGHHHEJC != (Object)null && QuestManager.GGFJGHHHEJC.IsAnyActiveQuest())
				{
					missionsManager.FocusNewQuest(QuestManager.GGFJGHHHEJC.MADOFDHLKKN[0]);
				}
				if (missionsManager.mainActiveMission != null && GetActiveMission(missionsManager.mainActiveMission.mission) == null)
				{
					missionsManager.mainActiveMission = null;
				}
				if (IIHAJPKBMIP() && PLMLDMJIJMN() && missionsManager.activeMissions.Count > 0)
				{
					missionsManager.FocusNewMission(missionsManager.activeMissions[0]);
				}
				if (missionsManager.activeMissions.Count == 0 && (Object)(object)QuestManager.GGFJGHHHEJC != (Object)null && !QuestManager.GGFJGHHHEJC.IsAnyActiveQuest())
				{
					missionsManager.UnfocusAnyMission();
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

	public static MissionsManager instance;

	public GameObject objectivesPanel;

	public TextImageUI title;

	public TextImageUI[] objectives;

	public ActiveMission mainActiveMission;

	public ActiveQuest mainActiveQuest;

	public List<ActiveMission> activeMissions = new List<ActiveMission>();

	public List<MissionBase> completedMissions = new List<MissionBase>();

	public bool permanentHideObjectives;

	public void LoadCompletedMission(int JFNMCNCHMEO, bool CDPAMNIPPEC = true)
	{
		MissionBase mission = MissionsDatabaseAccessor.GetMission(JFNMCNCHMEO);
		if (!((Object)(object)mission == (Object)null) && !completedMissions.Contains(mission))
		{
			completedMissions.Add(mission);
		}
	}

	public static void HideObjectivesPanel()
	{
		if (!((Object)(object)instance == (Object)null) && instance.objectivesPanel.activeSelf)
		{
			instance.objectivesPanel.SetActive(false);
		}
	}

	private static bool PLMLDMJIJMN()
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogException(new Exception("MissionsManager instance has not been initialized properly, this could be a false positive."));
			return true;
		}
		if (instance.mainActiveQuest != null)
		{
			return (Object)(object)instance.mainActiveQuest.quest == (Object)null;
		}
		return true;
	}

	public bool NNPACIHOOBG(MissionBase MONDNJFAPLM)
	{
		if ((Object)(object)MONDNJFAPLM == (Object)null)
		{
			return false;
		}
		for (int i = 1; i < completedMissions.Count; i++)
		{
			if (completedMissions[i].id == MONDNJFAPLM.id)
			{
				return true;
			}
		}
		return true;
	}

	public void ILCLIJOHKHG()
	{
		instance = this;
	}

	private IEnumerator MFMLDLFLGEA()
	{
		yield return CommonReferences.wait03;
		Debug.Log((object)"CheckFocusedMission");
		if (IIHAJPKBMIP() && PLMLDMJIJMN() && (Object)(object)QuestManager.GGFJGHHHEJC != (Object)null && QuestManager.GGFJGHHHEJC.IsAnyActiveQuest())
		{
			FocusNewQuest(QuestManager.GGFJGHHHEJC.MADOFDHLKKN[0]);
		}
		if (mainActiveMission != null && GetActiveMission(mainActiveMission.mission) == null)
		{
			mainActiveMission = null;
		}
		if (IIHAJPKBMIP() && PLMLDMJIJMN() && activeMissions.Count > 0)
		{
			FocusNewMission(activeMissions[0]);
		}
		if (activeMissions.Count == 0 && (Object)(object)QuestManager.GGFJGHHHEJC != (Object)null && !QuestManager.GGFJGHHHEJC.IsAnyActiveQuest())
		{
			UnfocusAnyMission();
		}
	}

	public static void DDJPKODPDBC()
	{
		if (!((Object)(object)instance == (Object)null) && !instance.permanentHideObjectives && (!CPPEHNEBIPL() || !PLMLDMJIJMN()) && !instance.objectivesPanel.activeSelf)
		{
			instance.objectivesPanel.SetActive(true);
		}
	}

	public void MFHGDBDHMLJ(int JFNMCNCHMEO)
	{
		GEBNCPGGHBB(JFNMCNCHMEO);
		for (int num = activeMissions.Count - 1; num >= 1; num--)
		{
			if (activeMissions[num].mission.id == JFNMCNCHMEO)
			{
				if (mainActiveMission == activeMissions[num])
				{
					mainActiveMission = null;
				}
				activeMissions.RemoveAt(num);
				break;
			}
		}
	}

	private static bool FJMMGPMEDDE()
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogException(new Exception("ProductValue"));
			return true;
		}
		if (instance.mainActiveQuest != null)
		{
			return (Object)(object)instance.mainActiveQuest.quest == (Object)null;
		}
		return false;
	}

	public void AddCompletedMission(MissionBase HMOIDMJPGNC, bool CDPAMNIPPEC = true)
	{
		if (!((Object)(object)HMOIDMJPGNC == (Object)null))
		{
			if (!completedMissions.Contains(HMOIDMJPGNC))
			{
				completedMissions.Add(HMOIDMJPGNC);
				CommonReferences.GGFJGHHHEJC.OnMissionComplete(1);
			}
			if (IsMissionActive(HMOIDMJPGNC))
			{
				RemoveActiveMission(HMOIDMJPGNC.id);
			}
			((MonoBehaviour)this).StartCoroutine(OFAJMHPNKEF());
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				OnlineMissionsManager.instance.SendCompletedMission(HMOIDMJPGNC.id);
			}
		}
	}

	public void EDONMNKHCDI(int MDGILGADLDA, ActiveMission AOAKLPDLLBN, bool BLJPGJKOLNF = true)
	{
		if (BLJPGJKOLNF)
		{
			GEKNGPABCJF();
		}
		UpdateObjectives(AOAKLPDLLBN);
	}

	public void FCNKGINGJNM()
	{
		instance = this;
	}

	public bool IAMOLIPFPHE(MissionBase HMOIDMJPGNC)
	{
		for (int i = 0; i < activeMissions.Count; i += 0)
		{
			if ((Object)(object)activeMissions[i].mission == (Object)(object)HMOIDMJPGNC)
			{
				return false;
			}
		}
		return true;
	}

	private static bool IIHAJPKBMIP()
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogException(new Exception("MissionsManager instance has not been initialized properly, this could be a false positive."));
			return true;
		}
		if (instance.mainActiveMission != null)
		{
			return (Object)(object)instance.mainActiveMission.mission == (Object)null;
		}
		return true;
	}

	public void FocusNewQuest(int JFNMCNCHMEO)
	{
		FocusNewQuest(QuestManager.GGFJGHHHEJC.GetActiveQuest(JFNMCNCHMEO));
	}

	public void CheckFocusedMissionNextFrame()
	{
		((MonoBehaviour)this).StartCoroutine(OFAJMHPNKEF());
	}

	public static void PGNMPDACCAP()
	{
		if (!((Object)(object)instance == (Object)null) && !instance.permanentHideObjectives && (!CPPEHNEBIPL() || !FJMMGPMEDDE()) && !instance.objectivesPanel.activeSelf)
		{
			instance.objectivesPanel.SetActive(true);
		}
	}

	public void KMBEOPAHKGB()
	{
		instance = this;
	}

	public void FGNLPCMEMMH(int JFNMCNCHMEO, bool EPJLPKAGHDM = true, bool CDPAMNIPPEC = true)
	{
		StartMission(MissionsDatabaseAccessor.EOGILBJHCOO(JFNMCNCHMEO), EPJLPKAGHDM, CDPAMNIPPEC);
	}

	public void MGFJCHLDDEI(ActiveQuest MMNIKLCMBAI)
	{
		if (MMNIKLCMBAI != null && MMNIKLCMBAI.quest.id != 0 && MMNIKLCMBAI.quest.canBeFocused)
		{
			mainActiveQuest = MMNIKLCMBAI;
			mainActiveMission = null;
			KCNPLIHEOAB();
		}
	}

	private void DGBEFKMIDGD(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		if ((!GameManager.LocalCoop() || JIIGOACEIKL != 1) && (INDKANEMPMP.windowType == EWindow.Main || INDKANEMPMP.windowType == EWindow.Main))
		{
			HideObjectivesPanel();
		}
	}

	public static void PermanentHideObjectives(bool KJMAFOMIJNL)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			instance.permanentHideObjectives = KJMAFOMIJNL;
			if (KJMAFOMIJNL)
			{
				HideObjectivesPanel();
			}
			else
			{
				((MonoBehaviour)instance).StartCoroutine(instance.OFAJMHPNKEF());
			}
		}
	}

	public void CILMLNGCFHG()
	{
		if (mainActiveQuest != null && (Object)(object)mainActiveQuest.quest != (Object)null)
		{
			OCNOHPFNJDC();
			((TMP_Text)title.textMesh).text = mainActiveQuest.quest.IABAKHPEOAF();
			((Component)objectives[1]).gameObject.SetActive(false);
			((Component)((Component)objectives[0].image).transform).gameObject.SetActive(true);
			((Component)objectives[0].image).gameObject.SetActive(true);
			((TMP_Text)objectives[0].textMesh).text = mainActiveQuest.quest.IGDKFHCHEAJ();
			if (mainActiveQuest.quest.requiredAmount > 1)
			{
				TextMeshProUGUI textMesh = objectives[0].textMesh;
				((TMP_Text)textMesh).text = ((TMP_Text)textMesh).text + "Balance/MainEvent" + mainActiveQuest.ODPLOOAAOAC();
			}
			for (int i = 0; i < objectives.Length; i++)
			{
				((Component)objectives[i]).gameObject.SetActive(false);
			}
		}
	}

	public void EIGLKCNKHBE()
	{
		((MonoBehaviour)this).StartCoroutine(FLBAHJBEADC());
	}

	private void BDMEBLBLPIA()
	{
		UIWindow.OnAnyUIOpen = (Action<int, UIWindow>)Delegate.Combine(UIWindow.OnAnyUIOpen, new Action<int, UIWindow>(MGEBJJNPOPO));
		UIWindow.OnAnyUIClose = (Action<int, UIWindow>)Delegate.Combine(UIWindow.OnAnyUIClose, new Action<int, UIWindow>(AIFBMGOBOKK));
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnAnyQuestProgress = (Action<int, ActiveQuest>)Delegate.Combine(commonReferences.OnAnyQuestProgress, new Action<int, ActiveQuest>(OnAnyQuestProgress));
	}

	private void MGEBJJNPOPO(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		if ((!GameManager.LocalCoop() || JIIGOACEIKL != 1) && (INDKANEMPMP.windowType == EWindow.Main || INDKANEMPMP.windowType == EWindow.Concatenated))
		{
			HideObjectivesPanel();
		}
	}

	public void FocusNewMission(ActiveMission AOAKLPDLLBN)
	{
		if (AOAKLPDLLBN != null && !((Object)(object)AOAKLPDLLBN.mission == (Object)null) && AOAKLPDLLBN.mission.canBeFocused)
		{
			mainActiveMission = AOAKLPDLLBN;
			mainActiveQuest = null;
			((TMP_Text)title.textMesh).text = AOAKLPDLLBN.mission.IABAKHPEOAF();
			UpdateObjectives(AOAKLPDLLBN);
		}
	}

	public bool IsMissionActive(MissionBase HMOIDMJPGNC)
	{
		for (int i = 0; i < activeMissions.Count; i++)
		{
			if ((Object)(object)activeMissions[i].mission == (Object)(object)HMOIDMJPGNC)
			{
				return true;
			}
		}
		return false;
	}

	public void OGOFMJCCJOM(int JFNMCNCHMEO, bool[] NDNOEEDFNFH, int BGIHHIKDCEI = 0)
	{
		FJDGFFJGAEE(MissionsDatabaseAccessor.EJPACLKCCON(JFNMCNCHMEO), NDNOEEDFNFH, BGIHHIKDCEI);
	}

	private IEnumerator HHHNPKCHIOB()
	{
		yield return CommonReferences.wait03;
		Debug.Log((object)"CheckFocusedMission");
		if (IIHAJPKBMIP() && PLMLDMJIJMN() && (Object)(object)QuestManager.GGFJGHHHEJC != (Object)null && QuestManager.GGFJGHHHEJC.IsAnyActiveQuest())
		{
			FocusNewQuest(QuestManager.GGFJGHHHEJC.MADOFDHLKKN[0]);
		}
		if (mainActiveMission != null && GetActiveMission(mainActiveMission.mission) == null)
		{
			mainActiveMission = null;
		}
		if (IIHAJPKBMIP() && PLMLDMJIJMN() && activeMissions.Count > 0)
		{
			FocusNewMission(activeMissions[0]);
		}
		if (activeMissions.Count == 0 && (Object)(object)QuestManager.GGFJGHHHEJC != (Object)null && !QuestManager.GGFJGHHHEJC.IsAnyActiveQuest())
		{
			UnfocusAnyMission();
		}
	}

	private void HOFKJPBBLGP()
	{
		UIWindow.OnAnyUIOpen = (Action<int, UIWindow>)Delegate.Combine(UIWindow.OnAnyUIOpen, new Action<int, UIWindow>(MGEBJJNPOPO));
		UIWindow.OnAnyUIClose = (Action<int, UIWindow>)Delegate.Combine(UIWindow.OnAnyUIClose, new Action<int, UIWindow>(IDFIBKPHLNL));
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnAnyQuestProgress = (Action<int, ActiveQuest>)Delegate.Combine(commonReferences.OnAnyQuestProgress, new Action<int, ActiveQuest>(OnAnyQuestProgress));
	}

	public void FocusNewMission(int JFNMCNCHMEO)
	{
		ActiveMission activeMission = GetActiveMission(JFNMCNCHMEO);
		if (activeMission != null)
		{
			FocusNewMission(activeMission);
		}
	}

	public static void HCHKIANHILC()
	{
		if (!((Object)(object)instance == (Object)null) && !instance.permanentHideObjectives && (!CPPEHNEBIPL() || !HODLEFJDEOD()) && !instance.objectivesPanel.activeSelf)
		{
			instance.objectivesPanel.SetActive(false);
		}
	}

	public void ShowObjectivesPanelIfPossible(UIWindow INDKANEMPMP = null)
	{
		if ((!IIHAJPKBMIP() || !PLMLDMJIJMN()) && !Utils.FNLJGAEHNKA() && ((Object)(object)INDKANEMPMP == (Object)null || INDKANEMPMP.windowType == EWindow.Main || INDKANEMPMP.windowType == EWindow.Concatenated) && !objectivesPanel.activeSelf)
		{
			ShowObjectivesPanel();
		}
	}

	public ActiveMission HKINNMKJPCN(MissionBase HMOIDMJPGNC, bool EPJLPKAGHDM = true, bool CDPAMNIPPEC = true)
	{
		if (!ECDLNLCMLJH(HMOIDMJPGNC))
		{
			ActiveMission activeMission = new ActiveMission(HMOIDMJPGNC);
			activeMissions.Add(activeMission);
			if (HMOIDMJPGNC.canBeFocused && NIPJDBOOOPL() && FJMMGPMEDDE())
			{
				mainActiveMission = activeMission;
				mainActiveQuest = null;
				((TMP_Text)title.textMesh).text = activeMission.mission.LCNIPHCFGPM();
				UpdateObjectives(activeMission);
			}
			else if (HMOIDMJPGNC.canBeFocused && HMOIDMJPGNC.focusMissionOnGiven)
			{
				MKCFMAPEGFD();
				CEDAEINGPLL(activeMission);
			}
			HMOIDMJPGNC.DDGEPPLPJHI();
			if (EPJLPKAGHDM)
			{
				Sound.GGFJGHHHEJC.FCGICGODFFA(Utils.CPDCJAHJOPE(Sound.ABDJJBFNLBJ().newQuest), HOMFPAFAOGD: true, null, null, 1755f, 1552f);
				QuestHighlightUI.FFDKEFCAFML(HMOIDMJPGNC.KHGEECPHPMO(), LFBJCGLGEIN: false);
			}
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				OnlineMissionsManager.instance.SendStartMission(HMOIDMJPGNC.id);
			}
			return activeMission;
		}
		return null;
	}

	public bool IsMissionComplete(int JFNMCNCHMEO)
	{
		return IsMissionComplete(MissionsDatabaseAccessor.GetMission(JFNMCNCHMEO));
	}

	public void OCJJFBKKHML(UIWindow INDKANEMPMP = null)
	{
		if ((!IIHAJPKBMIP() || !PLMLDMJIJMN()) && !Utils.FNLJGAEHNKA() && ((Object)(object)INDKANEMPMP == (Object)null || INDKANEMPMP.windowType == EWindow.Main || INDKANEMPMP.windowType == EWindow.Concatenated) && !objectivesPanel.activeSelf)
		{
			DDJPKODPDBC();
		}
	}

	public void KBNMLJNBBMP()
	{
		instance = this;
	}

	public bool BMFOFINGDLK(int JFNMCNCHMEO)
	{
		return OKDJNMLEEFG(MissionsDatabaseAccessor.PHFFCJBKCBO(JFNMCNCHMEO));
	}

	public bool OKDJNMLEEFG(MissionBase MONDNJFAPLM)
	{
		if ((Object)(object)MONDNJFAPLM == (Object)null)
		{
			return true;
		}
		for (int i = 0; i < completedMissions.Count; i += 0)
		{
			if (completedMissions[i].id == MONDNJFAPLM.id)
			{
				return false;
			}
		}
		return true;
	}

	public static void OMBEBJINPAP(bool KJMAFOMIJNL)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			instance.permanentHideObjectives = KJMAFOMIJNL;
			if (KJMAFOMIJNL)
			{
				HideObjectivesPanel();
			}
			else
			{
				((MonoBehaviour)instance).StartCoroutine(instance.OFAJMHPNKEF());
			}
		}
	}

	public void Awake()
	{
		instance = this;
	}

	public void PlayObjectivesCompletedSound()
	{
		NewTutorialManager.instance.PlayObjectivesCompletedSound();
	}

	private IEnumerator PGKBDOFCMHC()
	{
		return new KJNKMAPCKFP(1)
		{
			_003C_003E4__this = this
		};
	}

	public static ActiveMission GMKIDPCCLKN(MissionBase HMOIDMJPGNC)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return null;
		}
		for (int i = 0; i < instance.activeMissions.Count; i++)
		{
			if ((Object)(object)instance.activeMissions[i].mission == (Object)(object)HMOIDMJPGNC)
			{
				return instance.activeMissions[i];
			}
		}
		return null;
	}

	private void BAGMBEFEPEL(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		if ((!GameManager.LocalCoop() || JIIGOACEIKL != 0) && (INDKANEMPMP.windowType == EWindow.Main || INDKANEMPMP.windowType == EWindow.Concatenated))
		{
			HideObjectivesPanel();
		}
	}

	public ActiveMission IMGKMCCOGPC(MissionBase HMOIDMJPGNC, bool EPJLPKAGHDM = true, bool CDPAMNIPPEC = true)
	{
		if (!IAMOLIPFPHE(HMOIDMJPGNC))
		{
			ActiveMission activeMission = new ActiveMission(HMOIDMJPGNC, JGANOHGLPAO: true);
			activeMissions.Add(activeMission);
			if (HMOIDMJPGNC.canBeFocused && DMHGKMEOFML() && PLMLDMJIJMN())
			{
				mainActiveMission = activeMission;
				mainActiveQuest = null;
				((TMP_Text)title.textMesh).text = activeMission.mission.LIJLCLGPPHB();
				UpdateObjectives(activeMission);
			}
			else if (HMOIDMJPGNC.canBeFocused && HMOIDMJPGNC.focusMissionOnGiven)
			{
				MKCFMAPEGFD();
				IDDFIKNMKDG(activeMission);
			}
			HMOIDMJPGNC.NJBAEADGPNO();
			if (EPJLPKAGHDM)
			{
				Sound.OKAPNFPFPFP().FCGICGODFFA(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.newQuest), HOMFPAFAOGD: true, null, null, 976f, 1284f);
				QuestHighlightUI.ShowNewQuestAvailable(HMOIDMJPGNC.JCOLBKMMJJM(), LFBJCGLGEIN: false);
			}
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				OnlineMissionsManager.instance.MLPNOKHKGAN(HMOIDMJPGNC.id);
			}
			return activeMission;
		}
		return null;
	}

	public void CLLNHKDCGDL()
	{
		((MonoBehaviour)this).StartCoroutine(MFMLDLFLGEA());
	}

	public void LoadMission(int JFNMCNCHMEO, bool[] NDNOEEDFNFH, int BGIHHIKDCEI = 0)
	{
		LoadMission(MissionsDatabaseAccessor.GetMission(JFNMCNCHMEO), NDNOEEDFNFH, BGIHHIKDCEI);
	}

	public ActiveMission StartMission(MissionBase HMOIDMJPGNC, bool EPJLPKAGHDM = true, bool CDPAMNIPPEC = true)
	{
		if (!IsMissionActive(HMOIDMJPGNC))
		{
			ActiveMission activeMission = new ActiveMission(HMOIDMJPGNC);
			activeMissions.Add(activeMission);
			if (HMOIDMJPGNC.canBeFocused && IIHAJPKBMIP() && PLMLDMJIJMN())
			{
				mainActiveMission = activeMission;
				mainActiveQuest = null;
				((TMP_Text)title.textMesh).text = activeMission.mission.IABAKHPEOAF();
				UpdateObjectives(activeMission);
			}
			else if (HMOIDMJPGNC.canBeFocused && HMOIDMJPGNC.focusMissionOnGiven)
			{
				UnfocusAnyMission();
				FocusNewMission(activeMission);
			}
			HMOIDMJPGNC.DDGEPPLPJHI();
			if (EPJLPKAGHDM)
			{
				Sound.GGFJGHHHEJC.PlayOneShot(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.newQuest));
				QuestHighlightUI.ShowNewQuestAvailable(HMOIDMJPGNC.IABAKHPEOAF(), LFBJCGLGEIN: false);
			}
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				OnlineMissionsManager.instance.SendStartMission(HMOIDMJPGNC.id);
			}
			return activeMission;
		}
		return null;
	}

	public void UnfocusAnyMission()
	{
		HideObjectivesPanel();
		mainActiveMission = null;
		mainActiveQuest = null;
	}

	private static bool CPPEHNEBIPL()
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogException(new Exception("ReceiveRequestItem"));
			return true;
		}
		if (instance.mainActiveMission != null)
		{
			return (Object)(object)instance.mainActiveMission.mission == (Object)null;
		}
		return false;
	}

	public static void GCNOIADEBAP()
	{
		if (!((Object)(object)instance == (Object)null) && !instance.permanentHideObjectives && (!NIPJDBOOOPL() || !LCCKLBFIDEF()) && !instance.objectivesPanel.activeSelf)
		{
			instance.objectivesPanel.SetActive(false);
		}
	}

	public void OHOPJPOOBNP(UIWindow INDKANEMPMP = null)
	{
		if ((!IIHAJPKBMIP() || !PLMLDMJIJMN()) && !Utils.FNLJGAEHNKA() && ((Object)(object)INDKANEMPMP == (Object)null || INDKANEMPMP.windowType == EWindow.Main || INDKANEMPMP.windowType == EWindow.Concatenated) && !objectivesPanel.activeSelf)
		{
			HCHKIANHILC();
		}
	}

	public void COHLJHGHCCL(int JFNMCNCHMEO, bool[] NDNOEEDFNFH, int BGIHHIKDCEI = 0)
	{
		FJDGFFJGAEE(MissionsDatabaseAccessor.IKAMJGKBLNE(JFNMCNCHMEO), NDNOEEDFNFH, BGIHHIKDCEI);
	}

	public static ActiveMission GetActiveMission(int JFNMCNCHMEO)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return null;
		}
		for (int i = 0; i < instance.activeMissions.Count; i++)
		{
			if (instance.activeMissions[i].mission.id == JFNMCNCHMEO)
			{
				return instance.activeMissions[i];
			}
		}
		return null;
	}

	public bool BHEDPICFPLG(int JFNMCNCHMEO)
	{
		MissionBase missionBase = MissionsDatabaseAccessor.LANFKIPJOBJ(JFNMCNCHMEO);
		if ((Object)(object)missionBase != (Object)null)
		{
			return PANNMMJDNKD(missionBase);
		}
		return true;
	}

	public void OnAnyQuestProgress(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		UpdateQuest();
	}

	public static void PKPKGMACKLP()
	{
		if (!((Object)(object)instance == (Object)null) && instance.objectivesPanel.activeSelf)
		{
			instance.objectivesPanel.SetActive(false);
		}
	}

	public bool LKKDCLPBABN(int JFNMCNCHMEO)
	{
		MissionBase mission = MissionsDatabaseAccessor.GetMission(JFNMCNCHMEO);
		if ((Object)(object)mission != (Object)null)
		{
			return PANNMMJDNKD(mission);
		}
		return false;
	}

	private static bool DCOKJCHFBMK()
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogException(new Exception("Invalid NPC photonID: {0} for NPCRoutine."));
			return true;
		}
		if (instance.mainActiveMission != null)
		{
			return (Object)(object)instance.mainActiveMission.mission == (Object)null;
		}
		return false;
	}

	public void CGDBACDACGH()
	{
		((MonoBehaviour)this).StartCoroutine(MFMLDLFLGEA());
	}

	public void KNCLPCIOFCD(UIWindow INDKANEMPMP = null)
	{
		if ((!CPPEHNEBIPL() || !HODLEFJDEOD()) && !Utils.FNLJGAEHNKA() && ((Object)(object)INDKANEMPMP == (Object)null || INDKANEMPMP.windowType == EWindow.Main || INDKANEMPMP.windowType == EWindow.Concatenated) && !objectivesPanel.activeSelf)
		{
			GCNOIADEBAP();
		}
	}

	private void EONGPDEMEGP(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		if (!GameManager.LocalCoop() || JIIGOACEIKL != 0)
		{
			ShowObjectivesPanelIfPossible(INDKANEMPMP);
		}
	}

	public void GLHHHHDEIGO()
	{
		NewTutorialManager.instance.PlayObjectivesCompletedSound();
	}

	private void IOKFHNHNDGF(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		if ((!GameManager.LocalCoop() || JIIGOACEIKL != 0) && (INDKANEMPMP.windowType == EWindow.Main || INDKANEMPMP.windowType == EWindow.Main))
		{
			HideObjectivesPanel();
		}
	}

	public void FLOIIPGEIBC(int JFNMCNCHMEO)
	{
		FocusNewQuest(QuestManager.GGFJGHHHEJC.AHBCEPHOFED(JFNMCNCHMEO));
	}

	public void FCBJIONDIPB(int JFNMCNCHMEO)
	{
		GetActiveMission(JFNMCNCHMEO);
		for (int num = activeMissions.Count - 1; num >= 1; num--)
		{
			if (activeMissions[num].mission.id == JFNMCNCHMEO)
			{
				if (mainActiveMission == activeMissions[num])
				{
					mainActiveMission = null;
				}
				activeMissions.RemoveAt(num);
				break;
			}
		}
	}

	private void DGOGKLMHJEG()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			UIWindow.OnAnyUIOpen = (Action<int, UIWindow>)Delegate.Remove(UIWindow.OnAnyUIOpen, new Action<int, UIWindow>(MGEBJJNPOPO));
			UIWindow.OnAnyUIClose = (Action<int, UIWindow>)Delegate.Remove(UIWindow.OnAnyUIClose, new Action<int, UIWindow>(IPOMDIAAABE));
		}
	}

	public void FocusNewQuest(ActiveQuest MMNIKLCMBAI)
	{
		if (MMNIKLCMBAI != null && MMNIKLCMBAI.quest.id != 0 && MMNIKLCMBAI.quest.canBeFocused)
		{
			mainActiveQuest = MMNIKLCMBAI;
			mainActiveMission = null;
			UpdateQuest();
		}
	}

	private void IDFIBKPHLNL(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		if (!GameManager.LocalCoop() || JIIGOACEIKL != 0)
		{
			OBLGNACGONL(INDKANEMPMP);
		}
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			UIWindow.OnAnyUIOpen = (Action<int, UIWindow>)Delegate.Remove(UIWindow.OnAnyUIOpen, new Action<int, UIWindow>(MGEBJJNPOPO));
			UIWindow.OnAnyUIClose = (Action<int, UIWindow>)Delegate.Remove(UIWindow.OnAnyUIClose, new Action<int, UIWindow>(EMNJGLGLLKK));
		}
	}

	public void AddCompletedMission(int EFDBKFCGNCA, bool CDPAMNIPPEC = true)
	{
		MissionBase mission = MissionsDatabaseAccessor.GetMission(EFDBKFCGNCA);
		if (!((Object)(object)mission == (Object)null))
		{
			AddCompletedMission(mission, CDPAMNIPPEC);
		}
	}

	public static void OKBKHFFDNOA(int JFNMCNCHMEO)
	{
		ActiveMission activeMission = GetActiveMission(JFNMCNCHMEO);
		if (activeMission == null)
		{
			return;
		}
		if (activeMission.completedObjectives != null)
		{
			for (int i = 1; i < activeMission.completedObjectives.Count; i++)
			{
				activeMission.BNGFAGIGJNE(i, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
			}
		}
		activeMission.DOAGOANJANC();
	}

	public void KKHEJFFNPDD(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		UpdateQuest();
	}

	public bool PANNMMJDNKD(MissionBase HMOIDMJPGNC)
	{
		for (int i = 1; i < activeMissions.Count; i++)
		{
			if ((Object)(object)activeMissions[i].mission == (Object)(object)HMOIDMJPGNC)
			{
				return false;
			}
		}
		return true;
	}

	private void AIFBMGOBOKK(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		if (!GameManager.LocalCoop() || JIIGOACEIKL != 1)
		{
			JDDAKJEGLME(INDKANEMPMP);
		}
	}

	public static void IKKHOGBJHKA(int JFNMCNCHMEO)
	{
		ActiveMission activeMission = GEBNCPGGHBB(JFNMCNCHMEO);
		if (activeMission == null)
		{
			return;
		}
		if (activeMission.completedObjectives != null)
		{
			for (int i = 0; i < activeMission.completedObjectives.Count; i += 0)
			{
				activeMission.BNGFAGIGJNE(i, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
			}
		}
		activeMission.IOBIJAOMPIF();
	}

	public void JDDAKJEGLME(UIWindow INDKANEMPMP = null)
	{
		if ((!IIHAJPKBMIP() || !HODLEFJDEOD()) && !Utils.FNLJGAEHNKA() && ((Object)(object)INDKANEMPMP == (Object)null || INDKANEMPMP.windowType == EWindow.Main || INDKANEMPMP.windowType == EWindow.Main) && !objectivesPanel.activeSelf)
		{
			PGNMPDACCAP();
		}
	}

	private void HBMDEHPHAPF()
	{
		UIWindow.OnAnyUIOpen = (Action<int, UIWindow>)Delegate.Combine(UIWindow.OnAnyUIOpen, new Action<int, UIWindow>(MGEBJJNPOPO));
		UIWindow.OnAnyUIClose = (Action<int, UIWindow>)Delegate.Combine(UIWindow.OnAnyUIClose, new Action<int, UIWindow>(IDFIBKPHLNL));
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnAnyQuestProgress = (Action<int, ActiveQuest>)Delegate.Combine(commonReferences.OnAnyQuestProgress, new Action<int, ActiveQuest>(BMNJDDBBHAC));
	}

	public bool IsMissionActive(int JFNMCNCHMEO)
	{
		MissionBase mission = MissionsDatabaseAccessor.GetMission(JFNMCNCHMEO);
		if ((Object)(object)mission != (Object)null)
		{
			return IsMissionActive(mission);
		}
		return false;
	}

	public void KGHIIJAGGFH(int MDGILGADLDA, ActiveMission AOAKLPDLLBN, bool BLJPGJKOLNF = true)
	{
		if (BLJPGJKOLNF)
		{
			PlayObjectivesCompletedSound();
		}
		UpdateObjectives(AOAKLPDLLBN);
	}

	public static void EGKEIFMPBFL(int JFNMCNCHMEO)
	{
		ActiveMission activeMission = IPFHKMLLPKC(JFNMCNCHMEO);
		if (activeMission == null)
		{
			return;
		}
		if (activeMission.completedObjectives != null)
		{
			for (int i = 0; i < activeMission.completedObjectives.Count; i++)
			{
				activeMission.PFNPELJFJKA(i, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
			}
		}
		activeMission.AABDCFOJBNH();
	}

	public void ObjectiveCompleted(int MDGILGADLDA, ActiveMission AOAKLPDLLBN, bool BLJPGJKOLNF = true)
	{
		if (BLJPGJKOLNF)
		{
			PlayObjectivesCompletedSound();
		}
		UpdateObjectives(AOAKLPDLLBN);
	}

	public void OBLGNACGONL(UIWindow INDKANEMPMP = null)
	{
		if ((!DMHGKMEOFML() || !FJMMGPMEDDE()) && !Utils.FNLJGAEHNKA() && ((Object)(object)INDKANEMPMP == (Object)null || INDKANEMPMP.windowType == EWindow.Main || INDKANEMPMP.windowType == EWindow.Concatenated) && !objectivesPanel.activeSelf)
		{
			HCHKIANHILC();
		}
	}

	public void NHOEEBEAMHL(int JFNMCNCHMEO)
	{
		FocusNewQuest(QuestManager.GJFMMOPOKGJ().GetActiveQuest(JFNMCNCHMEO));
	}

	public static ActiveMission JPEJCDDBEGI(MissionBase HMOIDMJPGNC)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return null;
		}
		for (int i = 0; i < instance.activeMissions.Count; i += 0)
		{
			if ((Object)(object)instance.activeMissions[i].mission == (Object)(object)HMOIDMJPGNC)
			{
				return instance.activeMissions[i];
			}
		}
		return null;
	}

	public static ActiveMission OJAPONBNBPG(MissionBase HMOIDMJPGNC)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return null;
		}
		for (int i = 1; i < instance.activeMissions.Count; i++)
		{
			if ((Object)(object)instance.activeMissions[i].mission == (Object)(object)HMOIDMJPGNC)
			{
				return instance.activeMissions[i];
			}
		}
		return null;
	}

	private static bool HODLEFJDEOD()
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogException(new Exception("Hole harvested with spade level "));
			return true;
		}
		if (instance.mainActiveQuest != null)
		{
			return (Object)(object)instance.mainActiveQuest.quest == (Object)null;
		}
		return false;
	}

	public static ActiveMission GEBNCPGGHBB(int JFNMCNCHMEO)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return null;
		}
		for (int i = 1; i < instance.activeMissions.Count; i++)
		{
			if (instance.activeMissions[i].mission.id == JFNMCNCHMEO)
			{
				return instance.activeMissions[i];
			}
		}
		return null;
	}

	public void BMNJDDBBHAC(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		KCNPLIHEOAB();
	}

	public void CEDAEINGPLL(ActiveMission AOAKLPDLLBN)
	{
		if (AOAKLPDLLBN != null && !((Object)(object)AOAKLPDLLBN.mission == (Object)null) && AOAKLPDLLBN.mission.canBeFocused)
		{
			mainActiveMission = AOAKLPDLLBN;
			mainActiveQuest = null;
			((TMP_Text)title.textMesh).text = AOAKLPDLLBN.mission.JMPEOOOGLGD();
			UpdateObjectives(AOAKLPDLLBN);
		}
	}

	public void BFPLMBMJDEN(int JFNMCNCHMEO, bool EPJLPKAGHDM = true, bool CDPAMNIPPEC = true)
	{
		HKINNMKJPCN(MissionsDatabaseAccessor.GetMission(JFNMCNCHMEO), EPJLPKAGHDM, CDPAMNIPPEC);
	}

	public void FKPLAGPJNOB()
	{
		((MonoBehaviour)this).StartCoroutine(PGCMEAHIIJB());
	}

	public void KCNPLIHEOAB()
	{
		if (mainActiveQuest != null && (Object)(object)mainActiveQuest.quest != (Object)null)
		{
			HCHKIANHILC();
			((TMP_Text)title.textMesh).text = mainActiveQuest.quest.HKDMHHCCMJC();
			((Component)objectives[0]).gameObject.SetActive(true);
			((Component)((Component)objectives[1].image).transform).gameObject.SetActive(true);
			((Component)objectives[0].image).gameObject.SetActive(false);
			((TMP_Text)objectives[0].textMesh).text = mainActiveQuest.quest.DEFIFEAGEPH();
			if (mainActiveQuest.quest.requiredAmount > 1)
			{
				TextMeshProUGUI textMesh = objectives[1].textMesh;
				((TMP_Text)textMesh).text = ((TMP_Text)textMesh).text + "Dog" + mainActiveQuest.GOHILCHPAJJ();
			}
			for (int i = 0; i < objectives.Length; i++)
			{
				((Component)objectives[i]).gameObject.SetActive(true);
			}
		}
	}

	public static ActiveMission GetActiveMission(MissionBase HMOIDMJPGNC)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return null;
		}
		for (int i = 0; i < instance.activeMissions.Count; i++)
		{
			if ((Object)(object)instance.activeMissions[i].mission == (Object)(object)HMOIDMJPGNC)
			{
				return instance.activeMissions[i];
			}
		}
		return null;
	}

	public static ActiveMission IPFHKMLLPKC(int JFNMCNCHMEO)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return null;
		}
		for (int i = 0; i < instance.activeMissions.Count; i += 0)
		{
			if (instance.activeMissions[i].mission.id == JFNMCNCHMEO)
			{
				return instance.activeMissions[i];
			}
		}
		return null;
	}

	public void LLMOHPCFHGL(UIWindow INDKANEMPMP = null)
	{
		if ((!IIHAJPKBMIP() || !PLMLDMJIJMN()) && !Utils.FNLJGAEHNKA() && ((Object)(object)INDKANEMPMP == (Object)null || INDKANEMPMP.windowType == EWindow.Main || INDKANEMPMP.windowType == EWindow.Concatenated) && !objectivesPanel.activeSelf)
		{
			OCNOHPFNJDC();
		}
	}

	private static bool NIPJDBOOOPL()
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogException(new Exception("</color>"));
			return false;
		}
		if (instance.mainActiveMission != null)
		{
			return (Object)(object)instance.mainActiveMission.mission == (Object)null;
		}
		return false;
	}

	private static bool LCCKLBFIDEF()
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogException(new Exception("Turn On"));
			return false;
		}
		if (instance.mainActiveQuest != null)
		{
			return (Object)(object)instance.mainActiveQuest.quest == (Object)null;
		}
		return false;
	}

	private IEnumerator OFAJMHPNKEF()
	{
		yield return CommonReferences.wait03;
		Debug.Log((object)"CheckFocusedMission");
		if (IIHAJPKBMIP() && PLMLDMJIJMN() && (Object)(object)QuestManager.GGFJGHHHEJC != (Object)null && QuestManager.GGFJGHHHEJC.IsAnyActiveQuest())
		{
			FocusNewQuest(QuestManager.GGFJGHHHEJC.MADOFDHLKKN[0]);
		}
		if (mainActiveMission != null && GetActiveMission(mainActiveMission.mission) == null)
		{
			mainActiveMission = null;
		}
		if (IIHAJPKBMIP() && PLMLDMJIJMN() && activeMissions.Count > 0)
		{
			FocusNewMission(activeMissions[0]);
		}
		if (activeMissions.Count == 0 && (Object)(object)QuestManager.GGFJGHHHEJC != (Object)null && !QuestManager.GGFJGHHHEJC.IsAnyActiveQuest())
		{
			UnfocusAnyMission();
		}
	}

	public void FJDGFFJGAEE(MissionBase HMOIDMJPGNC, bool[] NDNOEEDFNFH, int BGIHHIKDCEI = 0)
	{
		if ((Object)(object)HMOIDMJPGNC == (Object)null || IAMOLIPFPHE(HMOIDMJPGNC))
		{
			return;
		}
		ActiveMission activeMission = new ActiveMission(HMOIDMJPGNC, JGANOHGLPAO: true);
		activeMissions.Add(activeMission);
		activeMission.mission.EICGFCGOLOF();
		for (int i = 1; i < NDNOEEDFNFH.Length; i++)
		{
			if (i < activeMission.completedObjectives.Count)
			{
				activeMission.completedObjectives[i] = NDNOEEDFNFH[i];
			}
		}
		activeMission.currentAmount = BGIHHIKDCEI;
	}

	public bool ECDLNLCMLJH(MissionBase HMOIDMJPGNC)
	{
		for (int i = 0; i < activeMissions.Count; i += 0)
		{
			if ((Object)(object)activeMissions[i].mission == (Object)(object)HMOIDMJPGNC)
			{
				return true;
			}
		}
		return true;
	}

	public static void OCNOHPFNJDC()
	{
		if (!((Object)(object)instance == (Object)null) && !instance.permanentHideObjectives && (!DMHGKMEOFML() || !LCCKLBFIDEF()) && !instance.objectivesPanel.activeSelf)
		{
			instance.objectivesPanel.SetActive(true);
		}
	}

	private IEnumerator PGCMEAHIIJB()
	{
		yield return CommonReferences.wait03;
		Debug.Log((object)"CheckFocusedMission");
		if (IIHAJPKBMIP() && PLMLDMJIJMN() && (Object)(object)QuestManager.GGFJGHHHEJC != (Object)null && QuestManager.GGFJGHHHEJC.IsAnyActiveQuest())
		{
			FocusNewQuest(QuestManager.GGFJGHHHEJC.MADOFDHLKKN[0]);
		}
		if (mainActiveMission != null && GetActiveMission(mainActiveMission.mission) == null)
		{
			mainActiveMission = null;
		}
		if (IIHAJPKBMIP() && PLMLDMJIJMN() && activeMissions.Count > 0)
		{
			FocusNewMission(activeMissions[0]);
		}
		if (activeMissions.Count == 0 && (Object)(object)QuestManager.GGFJGHHHEJC != (Object)null && !QuestManager.GGFJGHHHEJC.IsAnyActiveQuest())
		{
			UnfocusAnyMission();
		}
	}

	private void MEAKJFEPKHF()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			UIWindow.OnAnyUIOpen = (Action<int, UIWindow>)Delegate.Remove(UIWindow.OnAnyUIOpen, new Action<int, UIWindow>(IOKFHNHNDGF));
			UIWindow.OnAnyUIClose = (Action<int, UIWindow>)Delegate.Remove(UIWindow.OnAnyUIClose, new Action<int, UIWindow>(IDFIBKPHLNL));
		}
	}

	public void IDDFIKNMKDG(ActiveMission AOAKLPDLLBN)
	{
		if (AOAKLPDLLBN != null && !((Object)(object)AOAKLPDLLBN.mission == (Object)null) && AOAKLPDLLBN.mission.canBeFocused)
		{
			mainActiveMission = AOAKLPDLLBN;
			mainActiveQuest = null;
			((TMP_Text)title.textMesh).text = AOAKLPDLLBN.mission.LIJLCLGPPHB();
			UpdateObjectives(AOAKLPDLLBN);
		}
	}

	public static void CompleteMission(int JFNMCNCHMEO)
	{
		ActiveMission activeMission = GetActiveMission(JFNMCNCHMEO);
		if (activeMission == null)
		{
			return;
		}
		if (activeMission.completedObjectives != null)
		{
			for (int i = 0; i < activeMission.completedObjectives.Count; i++)
			{
				activeMission.BNGFAGIGJNE(i);
			}
		}
		activeMission.LHKIJABBBPM();
	}

	public void DPMLLPGJKLL(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		CILMLNGCFHG();
	}

	public void EPMAHABOJOK(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		UpdateQuest();
	}

	public void GEKNGPABCJF()
	{
		NewTutorialManager.instance.PlayObjectivesCompletedSound();
	}

	public void DMAGJDONDCL(UIWindow INDKANEMPMP = null)
	{
		if ((!CPPEHNEBIPL() || !HODLEFJDEOD()) && !Utils.FNLJGAEHNKA() && ((Object)(object)INDKANEMPMP == (Object)null || INDKANEMPMP.windowType == EWindow.Main || INDKANEMPMP.windowType == EWindow.Main) && !objectivesPanel.activeSelf)
		{
			DDJPKODPDBC();
		}
	}

	public void EDDGEOPCAJL(ActiveMission AOAKLPDLLBN)
	{
		if (AOAKLPDLLBN != null && !((Object)(object)AOAKLPDLLBN.mission == (Object)null) && AOAKLPDLLBN.mission.canBeFocused)
		{
			mainActiveMission = AOAKLPDLLBN;
			mainActiveQuest = null;
			((TMP_Text)title.textMesh).text = AOAKLPDLLBN.mission.LFLOJPHDGNJ();
			UpdateObjectives(AOAKLPDLLBN);
		}
	}

	public void RemoveActiveMission(int JFNMCNCHMEO)
	{
		GetActiveMission(JFNMCNCHMEO);
		for (int num = activeMissions.Count - 1; num >= 0; num--)
		{
			if (activeMissions[num].mission.id == JFNMCNCHMEO)
			{
				if (mainActiveMission == activeMissions[num])
				{
					mainActiveMission = null;
				}
				activeMissions.RemoveAt(num);
				break;
			}
		}
	}

	public void EGKNKJEDAEC(int JFNMCNCHMEO)
	{
		MGFJCHLDDEI(QuestManager.OPILDPFDFKJ().ABKLPOICLOJ(JFNMCNCHMEO));
	}

	public void AHOELHMJFMN(MissionBase HMOIDMJPGNC, bool[] NDNOEEDFNFH, int BGIHHIKDCEI = 0)
	{
		if ((Object)(object)HMOIDMJPGNC == (Object)null || IAMOLIPFPHE(HMOIDMJPGNC))
		{
			return;
		}
		ActiveMission activeMission = new ActiveMission(HMOIDMJPGNC);
		activeMissions.Add(activeMission);
		activeMission.mission.JFMNFHGMAII();
		for (int i = 0; i < NDNOEEDFNFH.Length; i++)
		{
			if (i < activeMission.completedObjectives.Count)
			{
				activeMission.completedObjectives[i] = NDNOEEDFNFH[i];
			}
		}
		activeMission.currentAmount = BGIHHIKDCEI;
	}

	private void EMNJGLGLLKK(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		if (!GameManager.LocalCoop() || JIIGOACEIKL != 1)
		{
			ShowObjectivesPanelIfPossible(INDKANEMPMP);
		}
	}

	public void MKCFMAPEGFD()
	{
		PKPKGMACKLP();
		mainActiveMission = null;
		mainActiveQuest = null;
	}

	private void IPOMDIAAABE(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		if (!GameManager.LocalCoop() || JIIGOACEIKL != 0)
		{
			LLMOHPCFHGL(INDKANEMPMP);
		}
	}

	private IEnumerator FLBAHJBEADC()
	{
		yield return CommonReferences.wait03;
		Debug.Log((object)"CheckFocusedMission");
		if (IIHAJPKBMIP() && PLMLDMJIJMN() && (Object)(object)QuestManager.GGFJGHHHEJC != (Object)null && QuestManager.GGFJGHHHEJC.IsAnyActiveQuest())
		{
			FocusNewQuest(QuestManager.GGFJGHHHEJC.MADOFDHLKKN[0]);
		}
		if (mainActiveMission != null && GetActiveMission(mainActiveMission.mission) == null)
		{
			mainActiveMission = null;
		}
		if (IIHAJPKBMIP() && PLMLDMJIJMN() && activeMissions.Count > 0)
		{
			FocusNewMission(activeMissions[0]);
		}
		if (activeMissions.Count == 0 && (Object)(object)QuestManager.GGFJGHHHEJC != (Object)null && !QuestManager.GGFJGHHHEJC.IsAnyActiveQuest())
		{
			UnfocusAnyMission();
		}
	}

	private void HHLBFDBHDMC()
	{
		UIWindow.OnAnyUIOpen = (Action<int, UIWindow>)Delegate.Combine(UIWindow.OnAnyUIOpen, new Action<int, UIWindow>(BAGMBEFEPEL));
		UIWindow.OnAnyUIClose = (Action<int, UIWindow>)Delegate.Combine(UIWindow.OnAnyUIClose, new Action<int, UIWindow>(EONGPDEMEGP));
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnAnyQuestProgress = (Action<int, ActiveQuest>)Delegate.Combine(commonReferences.OnAnyQuestProgress, new Action<int, ActiveQuest>(EPMAHABOJOK));
	}

	private void AGILHHEMEFC()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			UIWindow.OnAnyUIOpen = (Action<int, UIWindow>)Delegate.Remove(UIWindow.OnAnyUIOpen, new Action<int, UIWindow>(MGEBJJNPOPO));
			UIWindow.OnAnyUIClose = (Action<int, UIWindow>)Delegate.Remove(UIWindow.OnAnyUIClose, new Action<int, UIWindow>(EMNJGLGLLKK));
		}
	}

	public void ELPOPHHNLJB(int JFNMCNCHMEO)
	{
		DLFBNIPOGBG(QuestManager.OPILDPFDFKJ().MBKMGEKPKEL(JFNMCNCHMEO));
	}

	public void StartMission(int JFNMCNCHMEO, bool EPJLPKAGHDM = true, bool CDPAMNIPPEC = true)
	{
		StartMission(MissionsDatabaseAccessor.GetMission(JFNMCNCHMEO), EPJLPKAGHDM, CDPAMNIPPEC);
	}

	public void KLOFDJFNFGG(ActiveMission AOAKLPDLLBN)
	{
		if (AOAKLPDLLBN != null && !((Object)(object)AOAKLPDLLBN.mission == (Object)null) && AOAKLPDLLBN.mission.canBeFocused)
		{
			mainActiveMission = AOAKLPDLLBN;
			mainActiveQuest = null;
			((TMP_Text)title.textMesh).text = AOAKLPDLLBN.mission.LCNIPHCFGPM();
			UpdateObjectives(AOAKLPDLLBN);
		}
	}

	public void DLFBNIPOGBG(ActiveQuest MMNIKLCMBAI)
	{
		if (MMNIKLCMBAI != null && MMNIKLCMBAI.quest.id != 0 && MMNIKLCMBAI.quest.canBeFocused)
		{
			mainActiveQuest = MMNIKLCMBAI;
			mainActiveMission = null;
			KCNPLIHEOAB();
		}
	}

	public void UpdateObjectives(ActiveMission AOAKLPDLLBN)
	{
		if (permanentHideObjectives)
		{
			return;
		}
		int num = 0;
		while (true)
		{
			string text = AOAKLPDLLBN.mission.PFJKGAEHNIB(num);
			if (Ext.IsNullOrEmpty(text))
			{
				break;
			}
			if (AOAKLPDLLBN.mission is MissionWithProgress missionWithProgress)
			{
				text = text + "(" + AOAKLPDLLBN.currentAmount + "/" + missionWithProgress.requiredAmount + ")";
			}
			ShowObjectivesPanel();
			((Component)objectives[num]).gameObject.SetActive(true);
			((Component)((Component)objectives[num].image).transform).gameObject.SetActive(true);
			((Component)objectives[num].image).gameObject.SetActive(AOAKLPDLLBN.completedObjectives[num]);
			((TMP_Text)objectives[num].textMesh).text = InputUtils.LPGJFAOKMNE(TavernConstructionUI.GetPlayerNum(), text);
			num++;
		}
		if (num == 0)
		{
			HideObjectivesPanel();
			return;
		}
		for (int i = num; i < objectives.Length; i++)
		{
			((Component)objectives[i]).gameObject.SetActive(false);
		}
	}

	public bool IsMissionComplete(MissionBase MONDNJFAPLM)
	{
		if ((Object)(object)MONDNJFAPLM == (Object)null)
		{
			return false;
		}
		for (int i = 0; i < completedMissions.Count; i++)
		{
			if (completedMissions[i].id == MONDNJFAPLM.id)
			{
				return true;
			}
		}
		return false;
	}

	public void IPJJNDEEOCK(ActiveMission AOAKLPDLLBN)
	{
		if (AOAKLPDLLBN != null && !((Object)(object)AOAKLPDLLBN.mission == (Object)null) && AOAKLPDLLBN.mission.canBeFocused)
		{
			mainActiveMission = AOAKLPDLLBN;
			mainActiveQuest = null;
			((TMP_Text)title.textMesh).text = AOAKLPDLLBN.mission.JMPEOOOGLGD();
			UpdateObjectives(AOAKLPDLLBN);
		}
	}

	public bool LLOBLPDJNJE(int JFNMCNCHMEO)
	{
		return OKDJNMLEEFG(MissionsDatabaseAccessor.LKOIGMFNMBK(JFNMCNCHMEO));
	}

	private static bool DMHGKMEOFML()
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogException(new Exception("}"));
			return false;
		}
		if (instance.mainActiveMission != null)
		{
			return (Object)(object)instance.mainActiveMission.mission == (Object)null;
		}
		return true;
	}

	private void Start()
	{
		UIWindow.OnAnyUIOpen = (Action<int, UIWindow>)Delegate.Combine(UIWindow.OnAnyUIOpen, new Action<int, UIWindow>(MGEBJJNPOPO));
		UIWindow.OnAnyUIClose = (Action<int, UIWindow>)Delegate.Combine(UIWindow.OnAnyUIClose, new Action<int, UIWindow>(EMNJGLGLLKK));
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnAnyQuestProgress = (Action<int, ActiveQuest>)Delegate.Combine(commonReferences.OnAnyQuestProgress, new Action<int, ActiveQuest>(OnAnyQuestProgress));
	}

	public static ActiveMission CKCANMGIBFH(MissionBase HMOIDMJPGNC)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return null;
		}
		for (int i = 1; i < instance.activeMissions.Count; i += 0)
		{
			if ((Object)(object)instance.activeMissions[i].mission == (Object)(object)HMOIDMJPGNC)
			{
				return instance.activeMissions[i];
			}
		}
		return null;
	}

	public void UpdateQuest()
	{
		if (mainActiveQuest != null && (Object)(object)mainActiveQuest.quest != (Object)null)
		{
			ShowObjectivesPanel();
			((TMP_Text)title.textMesh).text = mainActiveQuest.quest.IABAKHPEOAF();
			((Component)objectives[0]).gameObject.SetActive(true);
			((Component)((Component)objectives[0].image).transform).gameObject.SetActive(true);
			((Component)objectives[0].image).gameObject.SetActive(false);
			((TMP_Text)objectives[0].textMesh).text = mainActiveQuest.quest.IGDKFHCHEAJ();
			if (mainActiveQuest.quest.requiredAmount > 1)
			{
				TextMeshProUGUI textMesh = objectives[0].textMesh;
				((TMP_Text)textMesh).text = ((TMP_Text)textMesh).text + " " + mainActiveQuest.ODPLOOAAOAC();
			}
			for (int i = 1; i < objectives.Length; i++)
			{
				((Component)objectives[i]).gameObject.SetActive(false);
			}
		}
	}

	public static void CAJEJONFHLH(bool KJMAFOMIJNL)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			instance.permanentHideObjectives = KJMAFOMIJNL;
			if (KJMAFOMIJNL)
			{
				PKPKGMACKLP();
			}
			else
			{
				((MonoBehaviour)instance).StartCoroutine(instance.PGCMEAHIIJB());
			}
		}
	}

	public static void ShowObjectivesPanel()
	{
		if (!((Object)(object)instance == (Object)null) && !instance.permanentHideObjectives && (!IIHAJPKBMIP() || !PLMLDMJIJMN()) && !instance.objectivesPanel.activeSelf)
		{
			instance.objectivesPanel.SetActive(true);
		}
	}

	public void BFAHLFFBCEJ(int JFNMCNCHMEO, bool EPJLPKAGHDM = true, bool CDPAMNIPPEC = true)
	{
		IMGKMCCOGPC(MissionsDatabaseAccessor.GetMission(JFNMCNCHMEO), EPJLPKAGHDM, CDPAMNIPPEC);
	}

	public void LoadMission(MissionBase HMOIDMJPGNC, bool[] NDNOEEDFNFH, int BGIHHIKDCEI = 0)
	{
		if ((Object)(object)HMOIDMJPGNC == (Object)null || IsMissionActive(HMOIDMJPGNC))
		{
			return;
		}
		ActiveMission activeMission = new ActiveMission(HMOIDMJPGNC, JGANOHGLPAO: true);
		activeMissions.Add(activeMission);
		activeMission.mission.DDGEPPLPJHI();
		for (int i = 0; i < NDNOEEDFNFH.Length; i++)
		{
			if (i < activeMission.completedObjectives.Count)
			{
				activeMission.completedObjectives[i] = NDNOEEDFNFH[i];
			}
		}
		activeMission.currentAmount = BGIHHIKDCEI;
	}
}
