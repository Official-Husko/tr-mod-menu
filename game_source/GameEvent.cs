using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public abstract class GameEvent : MonoBehaviour
{
	public EventsManager.EventType eventType;

	public bool saveActiveState;

	public bool isActive;

	public bool isStarted;

	public bool isDone;

	protected int CJODOOFLLLB = 1;

	public int actorNumber = 1;

	public bool isActor;

	protected DialogueNPCBase EDGDFPPKGDL;

	protected string MDFALJKHKED = "";

	protected int CIKGDDCIDAL;

	public Transform cameraPosition;

	private Location BAIMHDBJPDK;

	private GameEvent GGFJGHHHEJC => GetInstance();

	public void EndEvent()
	{
		isActor = true;
		EndEvent(BGKCHMNJBLJ: true);
	}

	protected void PCPDOOPJCKE(int JIIGOACEIKL)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (MainUI.IsAnyUIOpen())
		{
			MainUI.CloseAllUIWindows();
		}
		if ((Object)(object)cameraPosition != (Object)null)
		{
			DialogueCameraTarget.GetPlayer(JIIGOACEIKL).cameraInEvent = true;
			DialogueCameraTarget.GetPlayer(JIIGOACEIKL).MoveCameraToPositionFromCameraTarget(Vector2.op_Implicit(cameraPosition.position));
		}
	}

	private void PFGNIKFHHGD()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		MainUI.GetYesNoDialogue().Open(1);
		((TMP_Text)MainUI.GetYesNoDialogue().boxText).text = LocalisationSystem.Get("askAboutLowestDifficulty");
		MainUI.GetYesNoDialogue().AddYesAction(new UnityAction(SetLowestDifficulty));
		MainUI.GetYesNoDialogue().AddNoAction(new UnityAction(NBMAHJIBHAP));
	}

	protected virtual IEnumerator GGJCNNAHOAB(int JIIGOACEIKL)
	{
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= GGJCNNAHOAB;
		yield return null;
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)GGFJGHHHEJC);
	}

	public virtual void LoadGameEvent(bool FAFHGCBNNJO, bool GKECEPMLCNA)
	{
		isActive = FAFHGCBNNJO;
		isDone = GKECEPMLCNA;
	}

	public void OnLocalPlayerEntersLocation(int JIIGOACEIKL)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		PlayerInputs.DisableKeyboardInputsAndMovement(JIIGOACEIKL, (MonoBehaviour)(object)GGFJGHHHEJC);
		if ((Object)(object)cameraPosition != (Object)null)
		{
			PlayerController.SetDirection(JIIGOACEIKL, Utils.EIDFHLPBICI(Vector2.op_Implicit(cameraPosition.position - ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position)));
			PCPDOOPJCKE(JIIGOACEIKL);
		}
	}

	public void StopPlayingChallenge()
	{
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)GGFJGHHHEJC);
		ChallengeEventPointsUI.instance.CloseUI();
		((MonoBehaviour)this).StartCoroutine(LNNGFCFBKEN(1));
		OnlineManager.OpenRoom();
		CIKGDDCIDAL = 0;
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.instance.SendStopPlayingChallenge(eventType);
		}
	}

	public void RemoveAllTravelZonesCallbacks(Location BAIMHDBJPDK)
	{
		List<TravelZone> travelZonesFromLocation = TravelZonesManager.GGFJGHHHEJC.GetTravelZonesFromLocation(BAIMHDBJPDK);
		for (int i = 0; i < travelZonesFromLocation.Count; i++)
		{
			TravelZone travelZone = travelZonesFromLocation[i];
			travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(OnLocalPlayerEntersLocation));
		}
	}

	public virtual void StartEvent(bool BFLCJPHHDJM, bool CDPAMNIPPEC)
	{
		EventsManager.SetActive(eventType, DMBFKFLDDLH: true);
		EventsManager.SetStarted(eventType, PBLIMLKPDKC: true);
		isActor = BFLCJPHHDJM;
		Debug.Log((object)("Start Event " + eventType.ToString() + " isActor: " + BFLCJPHHDJM));
		if (BFLCJPHHDJM)
		{
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				OnlineEventsManager.SendStartEvent(eventType);
			}
			if (OnlineManager.MasterOrOffline())
			{
				actorNumber = 1;
			}
			else
			{
				OnlineEventsManager.SendEventActorToMasterClient(eventType);
			}
		}
	}

	public abstract GameEvent GetInstance();

	public void SetLowestDifficulty()
	{
		if (OnlineManager.MasterOrOffline())
		{
			OthersMenuUI.GGFJGHHHEJC.EasyChallengeDifficulty(OEDBPACCOGH: true);
			NBMAHJIBHAP();
		}
	}

	public void RestartChallenge()
	{
		if (FadeCamera.GetPlayer(1).IsBlack())
		{
			((MonoBehaviour)this).StartCoroutine(GGJCNNAHOAB(1));
		}
		else
		{
			FadeCamera.FadeOutAllPlayers();
			FadeCamera.GetPlayer(1).JDKHJJIOLOE += GGJCNNAHOAB;
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.instance.SendRestartChallenge(eventType);
		}
	}

	protected virtual void CBPDNHLJKGA()
	{
	}

	public void PrepareLocalCoop(Location BAIMHDBJPDK)
	{
		int jIIGOACEIKL = ((CJODOOFLLLB != 1) ? 1 : 2);
		this.BAIMHDBJPDK = BAIMHDBJPDK;
		if (Utils.AHMPFOEGJHF(BAIMHDBJPDK, jIIGOACEIKL))
		{
			OnLocalPlayerEntersLocation(jIIGOACEIKL);
			return;
		}
		List<TravelZone> travelZonesFromLocation = TravelZonesManager.GGFJGHHHEJC.GetTravelZonesFromLocation(BAIMHDBJPDK);
		for (int i = 0; i < travelZonesFromLocation.Count; i++)
		{
			TravelZone travelZone = travelZonesFromLocation[i];
			travelZone.OnTravelZoneTo = (Action<int>)Delegate.Combine(travelZone.OnTravelZoneTo, new Action<int>(OnLocalPlayerEntersLocation));
		}
	}

	public void RequestChallengeRestart()
	{
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)GGFJGHHHEJC);
		CIKGDDCIDAL++;
		if (OnlineManager.MasterOrOffline())
		{
			if (!EventsManager.IsLowestDifficulty() && CIKGDDCIDAL > 2)
			{
				PFGNIKFHHGD();
			}
			else
			{
				NBMAHJIBHAP();
			}
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.instance.SendRequestChallengeRestart(eventType);
		}
	}

	public void OnOtherPlayerDisconnected(int MPMECNEJOMB)
	{
		if (OnlineManager.IsMasterClient() && actorNumber == MPMECNEJOMB)
		{
			Debug.Log((object)("Other player disconnected was the actor of event " + eventType.ToString() + ". Now the actor is the host."));
			isActor = true;
			actorNumber = 1;
			if (Object.op_Implicit((Object)(object)EDGDFPPKGDL))
			{
				EDGDFPPKGDL.StopConversation(BGKCHMNJBLJ: false);
				EDGDFPPKGDL.StartConversation(1, MDFALJKHKED);
			}
		}
	}

	protected void JCIDFJMJMAA(GameObject MEGPBGODLIL)
	{
		JCIDFJMJMAA(MEGPBGODLIL.transform);
	}

	public virtual void EndEvent(bool BGKCHMNJBLJ)
	{
		Debug.Log((object)("End Event " + eventType));
		EventsManager.SetActive(eventType, DMBFKFLDDLH: false);
		EventsManager.SetStarted(eventType, PBLIMLKPDKC: false);
		EventsManager.SetDone(eventType, POADAPOJIAI: true);
		if (GameManager.LocalCoop() && Object.op_Implicit((Object)(object)GetInstance()) && GetInstance().BAIMHDBJPDK != 0)
		{
			GetInstance().RemoveAllTravelZonesCallbacks(GetInstance().BAIMHDBJPDK);
		}
		if (BGKCHMNJBLJ && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendEndEvent(eventType);
		}
	}

	public virtual void OnSimpleEvent(short JFNMCNCHMEO)
	{
	}

	protected void JCIDFJMJMAA(Transform CHGOBPEDDBJ)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
		DialogueCameraTarget.GetPlayer(1).MoveCameraToPositionFromCameraTarget(Vector2.op_Implicit(CHGOBPEDDBJ.position));
	}

	private void NBMAHJIBHAP()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		MainUI.GetYesNoDialogue().Open(1);
		((TMP_Text)MainUI.GetYesNoDialogue().boxText).text = LocalisationSystem.Get("askAboutRestartingChallenge");
		MainUI.GetYesNoDialogue().AddYesAction(new UnityAction(RestartChallenge));
		MainUI.GetYesNoDialogue().AddNoAction(new UnityAction(StopPlayingChallenge));
	}

	protected virtual IEnumerator LNNGFCFBKEN(int JIIGOACEIKL)
	{
		yield return null;
	}

	public virtual void ActivateEvent()
	{
		EventsManager.SetActive(eventType, DMBFKFLDDLH: true);
		Debug.Log((object)("Activate Event " + eventType));
	}

	protected virtual void Awake()
	{
		EventsManager.instance.allGameEvents.Add(this);
	}
}
