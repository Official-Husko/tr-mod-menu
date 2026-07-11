using System.Collections;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public abstract class TutorialPhaseBase : MonoBehaviour
{
	[HideInInspector]
	public int triggerPlayerNum = 1;

	[HideInInspector]
	public bool objectivesSetUp;

	protected GameObject JELIKOFDONK;

	protected GameObject LJEJMMAEKJF;

	protected GameObject NDAJGAJNIMB;

	protected GameObject BHLGEJIECAL;

	protected bool KMGCKIBBCMO()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)PlayerController.GetPlayer(1)).transform.position.y > 911f && ((Component)PlayerController.GetPlayer(1)).transform.position.y < 914f && ((Component)PlayerController.GetPlayer(1)).transform.position.x < 13f)
		{
			triggerPlayerNum = 1;
			return true;
		}
		if (GameManager.LocalCoop() && ((Component)PlayerController.GetPlayer(2)).transform.position.y > 911f && ((Component)PlayerController.GetPlayer(2)).transform.position.y < 914f && ((Component)PlayerController.GetPlayer(2)).transform.position.x < 13f)
		{
			triggerPlayerNum = 2;
			return true;
		}
		return false;
	}

	protected bool AAOPIEDAKKD(int AKKFJBFMDPB)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("TutorialPhase");
		return ((Result)(ref variable)).asInt < AKKFJBFMDPB;
	}

	protected void CPMMKKOCDML()
	{
		Growable[] array = (Growable[])(object)Object.FindObjectsOfType(typeof(Growable));
		for (int i = 0; i < array.Length; i++)
		{
			if ((Object)(object)array[i].fertileSoil != (Object)null)
			{
				array[i].fertileSoil.daysUntilDry = 3;
			}
		}
		for (int j = 0; j < array.Length; j++)
		{
			while (!array[j].grown)
			{
				array[j].GrowPlant();
			}
			if (!array[j].cropSetter.harvestable.isHarvestable)
			{
				array[j].cropSetter.harvestable.isHarvestable = true;
				array[j].cropSetter.UpdateCropVisual(array[j].FKDFFKABPIH);
			}
		}
		for (int k = 0; k < array.Length; k++)
		{
			if ((Object)(object)array[k].fertileSoil != (Object)null)
			{
				array[k].fertileSoil.daysUntilDry = 0;
				array[k].fertileSoil.ShowDampGround();
			}
		}
	}

	protected bool AOOKIKFINFB()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)PlayerController.GetPlayer(1)).transform.position.y < 909.4f && ((Component)PlayerController.GetPlayer(1)).transform.position.y > 900f)
		{
			triggerPlayerNum = 1;
			return true;
		}
		if (GameManager.LocalCoop() && ((Component)PlayerController.GetPlayer(2)).transform.position.y < 909.4f && ((Component)PlayerController.GetPlayer(2)).transform.position.y > 900f)
		{
			triggerPlayerNum = 2;
			return true;
		}
		return false;
	}

	public void AddQuest(int OOBMJEBFGIJ)
	{
		Debug.Log((object)"AddQuest");
		Quest quest = QuestDatabaseAccessor.GetQuest(OOBMJEBFGIJ);
		if (Object.op_Implicit((Object)(object)quest))
		{
			Debug.Log((object)"AddQuest2");
			QuestManager.GGFJGHHHEJC.AddQuest(quest);
			QuestHighlightUI.ShowNewQuestAvailable(quest, LFBJCGLGEIN: false);
		}
		else
		{
			Debug.LogError((object)("Quest not found with ID " + OOBMJEBFGIJ));
		}
	}

	protected bool LHNFLANDFFH()
	{
		if (PlayerController.GetPlayer(1).LEOIMFNKFGA == Location.Quarry)
		{
			triggerPlayerNum = 1;
			return true;
		}
		if (GameManager.LocalCoop() && PlayerController.GetPlayer(2).LEOIMFNKFGA == Location.Quarry)
		{
			triggerPlayerNum = 2;
			return true;
		}
		return false;
	}

	protected IEnumerator CCIOMPBMJMD()
	{
		while (!GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			yield return null;
		}
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
	}

	public virtual void SetUp()
	{
		Debug.Log((object)("Starting Tutorial Phase: " + GetID()));
		triggerPlayerNum = 1;
		if (GetID() >= 130)
		{
			GetID();
			_ = 139;
		}
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(1);
		DialogueLua.SetVariable("TutorialPhase", (object)0);
	}

	public void ResetMai()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(8.979167f, 908.7292f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		((MonoBehaviour)this).StartCoroutine(LKKFBBDFMCL());
	}

	protected bool MLIHKNOAIFO()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)PlayerController.GetPlayer(1)).transform.position.y > 801.2f && ((Component)PlayerController.GetPlayer(1)).transform.position.y < 810f)
		{
			triggerPlayerNum = 1;
			return true;
		}
		if (GameManager.LocalCoop() && ((Component)PlayerController.GetPlayer(2)).transform.position.y > 801.2f && ((Component)PlayerController.GetPlayer(2)).transform.position.y < 810f)
		{
			triggerPlayerNum = 2;
			return true;
		}
		return false;
	}

	private IEnumerator LKKFBBDFMCL()
	{
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
	}

	protected virtual void LHKIJABBBPM()
	{
		NewTutorialManager.instance.NextPhase();
	}

	protected bool DMMFNMNKJLL()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)PlayerController.GetPlayer(1)).transform.position.y >= 905f)
		{
			triggerPlayerNum = 1;
			return true;
		}
		if (GameManager.LocalCoop() && ((Component)PlayerController.GetPlayer(2)).transform.position.y >= 905f)
		{
			triggerPlayerNum = 2;
			return true;
		}
		return false;
	}

	protected bool IIBCAKMOPIM()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)PlayerController.GetPlayer(1)).transform.position.y <= 905f)
		{
			triggerPlayerNum = 1;
			return true;
		}
		if (GameManager.LocalCoop() && ((Component)PlayerController.GetPlayer(2)).transform.position.y <= 905f)
		{
			triggerPlayerNum = 2;
			return true;
		}
		return false;
	}

	protected bool MCKLEPHBECB()
	{
		if (PlayerController.GetPlayer(1).LEOIMFNKFGA == Location.Road)
		{
			triggerPlayerNum = 1;
			return true;
		}
		if (GameManager.LocalCoop() && PlayerController.GetPlayer(2).LEOIMFNKFGA == Location.Road)
		{
			triggerPlayerNum = 2;
			return true;
		}
		return false;
	}

	protected bool LJNJGMLHCIC()
	{
		if (PlayerController.GetPlayer(1).LEOIMFNKFGA == Location.QuarryCave)
		{
			triggerPlayerNum = 1;
			return true;
		}
		if (GameManager.LocalCoop() && PlayerController.GetPlayer(2).LEOIMFNKFGA == Location.QuarryCave)
		{
			triggerPlayerNum = 2;
			return true;
		}
		return false;
	}

	protected IEnumerator CDICFNAMCEE()
	{
		while (MainUI.IsAnyUIOpen())
		{
			yield return null;
		}
	}

	protected bool DEDAGAANMIB()
	{
		if (GameManager.LocalCoop())
		{
			if (!MainUI.IsAnyUIOpen(1) && !MainUI.IsAnyUIOpen(2))
			{
				return false;
			}
		}
		else if (!MainUI.IsAnyUIOpen(1))
		{
			return false;
		}
		return true;
	}

	public abstract int GetID();

	protected bool FMMJDDBDPCP()
	{
		if (PlayerController.GetPlayer(1).LEOIMFNKFGA == Location.InnkeepersCave)
		{
			triggerPlayerNum = 1;
			return true;
		}
		if (GameManager.LocalCoop() && PlayerController.GetPlayer(2).LEOIMFNKFGA == Location.InnkeepersCave)
		{
			triggerPlayerNum = 2;
			return true;
		}
		return false;
	}

	protected bool CLJJAIEMOLN()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)PlayerController.GetPlayer(1)).transform.position.y >= 916.5f && ((Component)PlayerController.GetPlayer(1)).transform.position.x < 13f)
		{
			triggerPlayerNum = 1;
			return true;
		}
		if (GameManager.LocalCoop() && ((Component)PlayerController.GetPlayer(2)).transform.position.y >= 916.5f && ((Component)PlayerController.GetPlayer(2)).transform.position.x < 13f)
		{
			triggerPlayerNum = 2;
			return true;
		}
		return false;
	}
}
