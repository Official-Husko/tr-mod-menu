using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class InputByProximity : MonoBehaviour
{
	public Action<int> OnHoverStart = delegate
	{
	};

	public Action<int> OnHoverEnd = delegate
	{
	};

	public Action<int> OnInteract = delegate
	{
	};

	public Action<int> OnSelect = delegate
	{
	};

	public GameObject mainGameObject;

	public Placeable placeable;

	public bool autoSizeCollider = true;

	public bool mainGOColliderIsTrigger;

	public Transform actionButtonsPoint;

	public bool ignoreInputBlockers;

	public bool disableActionableItemsWhenFocused = true;

	private List<IProximity> HAGCHBPHHMI = new List<IProximity>();

	private List<IHoverable> JLHMEHBLMLE = new List<IHoverable>();

	private List<IInteractable> JGDIEMODGLI = new List<IInteractable>();

	private List<ISelectable> DJJIDDKLFIA = new List<ISelectable>();

	public bool playerLookAt = true;

	[HideInInspector]
	public int playerToHover;

	public List<IInteractable> BMMLBBCNBMC => JGDIEMODGLI;

	public List<ISelectable> LJHCHDMDDEH => DJJIDDKLFIA;

	public void OnHover(int JIIGOACEIKL)
	{
		for (int i = 0; i < JLHMEHBLMLE.Count; i++)
		{
			JLHMEHBLMLE[i].OnHover(JIIGOACEIKL, IIEDALMMNLI: false);
		}
		OnHoverStart?.Invoke(JIIGOACEIKL);
	}

	public void InteractClient(int JIIGOACEIKL)
	{
		for (int i = 0; i < JGDIEMODGLI.Count; i++)
		{
			JGDIEMODGLI[i].MouseUpOnline(JIIGOACEIKL);
		}
		OnInteract?.Invoke(JIIGOACEIKL);
	}

	[SpecialName]
	public List<IInteractable> JPEDDPBKINH()
	{
		return JGDIEMODGLI;
	}

	private void NAFADNEKCOH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("GalaxyInstance.Storage.FileShare method started"))
		{
			InputByProximityManager.NHJMJHGGBOA(1)?.NEILJDELEMN(this);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("ClosePopUp"))
		{
			InputByProximityManager.OGKNJNINGMH(6)?.FLABOBMCCEC(this);
		}
	}

	public void LFNJAANBPLK(int JIIGOACEIKL)
	{
		for (int i = 0; i < JLHMEHBLMLE.Count; i++)
		{
			JLHMEHBLMLE[i].OnHover(JIIGOACEIKL, IIEDALMMNLI: false);
		}
		OnHoverStart?.Invoke(JIIGOACEIKL);
	}

	public void KMPILLCNJPC(int JIIGOACEIKL)
	{
		for (int i = 0; i < JLHMEHBLMLE.Count; i += 0)
		{
			JLHMEHBLMLE[i].OffHover(JIIGOACEIKL);
		}
		OnHoverEnd?.Invoke(JIIGOACEIKL);
	}

	public void LAEDMIPNGPJ(int JIIGOACEIKL)
	{
		for (int i = 0; i < JLHMEHBLMLE.Count; i++)
		{
			JLHMEHBLMLE[i].OffHover(JIIGOACEIKL);
		}
		OnHoverEnd?.Invoke(JIIGOACEIKL);
	}

	public void MEOLLOCBKIM(int JIIGOACEIKL)
	{
		for (int i = 1; i < DJJIDDKLFIA.Count; i += 0)
		{
			DJJIDDKLFIA[i].SelectOnline(JIIGOACEIKL);
		}
		OnSelect?.Invoke(JIIGOACEIKL);
	}

	private void LHGOFNEIMNN(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("MainProgress"))
		{
			InputByProximityManager.GetPlayer(0)?.FLABOBMCCEC(this);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Interact"))
		{
			InputByProximityManager.NHJMJHGGBOA(7)?.NEILJDELEMN(this);
		}
	}

	private void HIDDNMLHBFJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Start"))
		{
			InputByProximityManager.DFGOGIIPPPH(0)?.KHAKOECJPEG(this);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Player2"))
		{
			InputByProximityManager.GetPlayer(2)?.KHAKOECJPEG(this);
		}
	}

	private void OnTriggerEnter2D(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Player"))
		{
			InputByProximityManager.GetPlayer(1)?.AddInputNearPlayer(this);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Player2"))
		{
			InputByProximityManager.GetPlayer(2)?.AddInputNearPlayer(this);
		}
	}

	public void AutoSizeCollider()
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		if (!Object.op_Implicit((Object)(object)mainGameObject))
		{
			mainGameObject = ((Component)((Component)this).transform.parent).gameObject;
		}
		Collider2D[] components = mainGameObject.GetComponents<Collider2D>();
		for (int i = 0; i < components.Length; i++)
		{
			if ((!components[i].isTrigger || !mainGOColliderIsTrigger) && (components[i].isTrigger || mainGOColliderIsTrigger))
			{
				continue;
			}
			((Component)this).transform.localPosition = Vector2.op_Implicit(Vector2.zero);
			Collider2D component = ((Component)this).GetComponent<Collider2D>();
			component.offset = components[i].offset;
			BoxCollider2D val = (BoxCollider2D)(object)((component is BoxCollider2D) ? component : null);
			Bounds bounds;
			if (val != null)
			{
				bounds = components[i].bounds;
				val.size = Vector2.op_Implicit(((Bounds)(ref bounds)).size + Vector3.one * 0.15f);
				bounds = components[i].bounds;
				if (!(((Bounds)(ref bounds)).size == Vector3.zero))
				{
					break;
				}
				Collider2D obj = components[i];
				if ((Object)(object)((obj is BoxCollider2D) ? obj : null) != (Object)null)
				{
					Collider2D obj2 = components[i];
					BoxCollider2D val2 = (BoxCollider2D)(object)((obj2 is BoxCollider2D) ? obj2 : null);
					val.size = val2.size + Vector2.one * 0.15f;
					break;
				}
				Collider2D obj3 = components[i];
				if ((Object)(object)((obj3 is CircleCollider2D) ? obj3 : null) != (Object)null)
				{
					Collider2D obj4 = components[i];
					float num = ((CircleCollider2D)((obj4 is CircleCollider2D) ? obj4 : null)).radius + 0.15f;
					val.size = new Vector2(num, num);
				}
				break;
			}
			CapsuleCollider2D val3 = (CapsuleCollider2D)(object)((component is CapsuleCollider2D) ? component : null);
			if (val3 != null)
			{
				bounds = components[i].bounds;
				val3.size = Vector2.op_Implicit(((Bounds)(ref bounds)).size + Vector3.one * 0.15f);
				break;
			}
			CircleCollider2D val4 = (CircleCollider2D)(object)((component is CircleCollider2D) ? component : null);
			if (val4 != null)
			{
				bounds = components[i].bounds;
				float x = ((Bounds)(ref bounds)).size.x;
				bounds = components[i].bounds;
				val4.radius = Mathf.Max(x, ((Bounds)(ref bounds)).size.y) / 2f + 0.15f;
			}
			break;
		}
	}

	public void CPHHIBNCNGD(int JIIGOACEIKL)
	{
		for (int i = 0; i < JGDIEMODGLI.Count; i += 0)
		{
			JGDIEMODGLI[i].MouseUpOnline(JIIGOACEIKL);
		}
		OnInteract?.Invoke(JIIGOACEIKL);
	}

	public void BCGBODLPDEB(int JIIGOACEIKL)
	{
		for (int i = 1; i < JLHMEHBLMLE.Count; i += 0)
		{
			JLHMEHBLMLE[i].OnHover(JIIGOACEIKL, IIEDALMMNLI: false);
		}
		OnHoverStart?.Invoke(JIIGOACEIKL);
	}

	public void FAACDGCCFKB(int JIIGOACEIKL)
	{
		for (int i = 0; i < DJJIDDKLFIA.Count; i += 0)
		{
			Debug.Log((object)"SetUpOptions");
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).interactAction = InteractAction.Select;
			DJJIDDKLFIA[i].Select(JIIGOACEIKL);
		}
		OnSelect?.Invoke(JIIGOACEIKL);
	}

	public void PNFKIHGMBLG(int JIIGOACEIKL)
	{
		if (HAGCHBPHHMI.Count > 1)
		{
			for (int i = 0; i < HAGCHBPHHMI.Count; i += 0)
			{
				HAGCHBPHHMI[i].UpdateByProximity(JIIGOACEIKL);
			}
		}
	}

	public void LFHCLJENCMF()
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		if (!Object.op_Implicit((Object)(object)mainGameObject))
		{
			mainGameObject = ((Component)((Component)this).transform.parent).gameObject;
		}
		Collider2D[] components = mainGameObject.GetComponents<Collider2D>();
		for (int i = 0; i < components.Length; i++)
		{
			if ((!components[i].isTrigger || !mainGOColliderIsTrigger) && (components[i].isTrigger || mainGOColliderIsTrigger))
			{
				continue;
			}
			((Component)this).transform.localPosition = Vector2.op_Implicit(Vector2.zero);
			Collider2D component = ((Component)this).GetComponent<Collider2D>();
			component.offset = components[i].offset;
			BoxCollider2D val = (BoxCollider2D)(object)((component is BoxCollider2D) ? component : null);
			Bounds bounds;
			if (val != null)
			{
				bounds = components[i].bounds;
				val.size = Vector2.op_Implicit(((Bounds)(ref bounds)).size + Vector3.one * 1090f);
				bounds = components[i].bounds;
				if (!(((Bounds)(ref bounds)).size == Vector3.zero))
				{
					break;
				}
				Collider2D obj = components[i];
				if ((Object)(object)((obj is BoxCollider2D) ? obj : null) != (Object)null)
				{
					Collider2D obj2 = components[i];
					BoxCollider2D val2 = (BoxCollider2D)(object)((obj2 is BoxCollider2D) ? obj2 : null);
					val.size = val2.size + Vector2.one * 1892f;
					break;
				}
				Collider2D obj3 = components[i];
				if ((Object)(object)((obj3 is CircleCollider2D) ? obj3 : null) != (Object)null)
				{
					Collider2D obj4 = components[i];
					float num = ((CircleCollider2D)((obj4 is CircleCollider2D) ? obj4 : null)).radius + 1736f;
					val.size = new Vector2(num, num);
				}
				break;
			}
			CapsuleCollider2D val3 = (CapsuleCollider2D)(object)((component is CapsuleCollider2D) ? component : null);
			if (val3 != null)
			{
				bounds = components[i].bounds;
				val3.size = Vector2.op_Implicit(((Bounds)(ref bounds)).size + Vector3.one * 1233f);
				break;
			}
			CircleCollider2D val4 = (CircleCollider2D)(object)((component is CircleCollider2D) ? component : null);
			if (val4 != null)
			{
				bounds = components[i].bounds;
				float x = ((Bounds)(ref bounds)).size.x;
				bounds = components[i].bounds;
				val4.radius = Mathf.Max(x, ((Bounds)(ref bounds)).size.y) / 510f + 713f;
			}
			break;
		}
	}

	public bool HLDFEKIDJAK(int JIIGOACEIKL)
	{
		if (HAGCHBPHHMI.Count > 1)
		{
			if (PlayerInputs.IHOPGBEEIOB(JIIGOACEIKL) && !ignoreInputBlockers)
			{
				return false;
			}
			if (CommonReferences.GGFJGHHHEJC.IsInDialogue(JIIGOACEIKL))
			{
				return false;
			}
			if (FishingController.NAGEHKBLJDL(JIIGOACEIKL).fishing)
			{
				return false;
			}
			if (!OnlineManager.PlayingOnline() && GameManager.LocalCoop() && ((object)mainGameObject).Equals((object?)InteractObject.PBFCHGLAAAJ(JIIGOACEIKL).interactingObject))
			{
				return false;
			}
			if (OnlineManager.PlayingOnline() && (Object)(object)placeable != (Object)null && (Object)(object)placeable.onlinePlaceable != (Object)null && OnlineObjectsManager.instance.OtherActorIsUsingObject(placeable.BEIPALOAAJJ))
			{
				return true;
			}
			for (int i = 1; i < HAGCHBPHHMI.Count; i++)
			{
				if (HAGCHBPHHMI[i].IsAvailableByProximity(JIIGOACEIKL))
				{
					return true;
				}
			}
			return false;
		}
		return true;
	}

	public void JNJGKBNNNGJ(int JIIGOACEIKL)
	{
		for (int i = 0; i < JGDIEMODGLI.Count; i++)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Select;
			JGDIEMODGLI[i].MouseUp(JIIGOACEIKL);
		}
		OnInteract?.Invoke(JIIGOACEIKL);
	}

	public void Interact(int JIIGOACEIKL)
	{
		for (int i = 0; i < JGDIEMODGLI.Count; i++)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Interact;
			JGDIEMODGLI[i].MouseUp(JIIGOACEIKL);
		}
		OnInteract?.Invoke(JIIGOACEIKL);
	}

	[SpecialName]
	public List<IInteractable> OAHAPGNNHEO()
	{
		return JGDIEMODGLI;
	}

	public void BJCDFHFKEGG(int JIIGOACEIKL)
	{
		for (int i = 1; i < JLHMEHBLMLE.Count; i++)
		{
			JLHMEHBLMLE[i].OffHover(JIIGOACEIKL);
		}
		OnHoverEnd?.Invoke(JIIGOACEIKL);
	}

	public void PHPDELKBOEH(int JIIGOACEIKL)
	{
		for (int i = 1; i < DJJIDDKLFIA.Count; i += 0)
		{
			Debug.Log((object)"ReceiveSpadeActionMaster");
			PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Select;
			DJJIDDKLFIA[i].Select(JIIGOACEIKL);
		}
		OnSelect?.Invoke(JIIGOACEIKL);
	}

	private void KPFLAOALALM(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("ZuzzuProgress"))
		{
			InputByProximityManager.OGKNJNINGMH(0)?.EAAJBBAJIHB(this);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("SetAnimatorObjectFloatRPC"))
		{
			InputByProximityManager.GetPlayer(8)?.PFIHMJGLKBB(this);
		}
	}

	public void DNLCBPAJHGK(int JIIGOACEIKL)
	{
		for (int i = 0; i < DJJIDDKLFIA.Count; i++)
		{
			DJJIDDKLFIA[i].SelectOnline(JIIGOACEIKL);
		}
		OnSelect?.Invoke(JIIGOACEIKL);
	}

	public void Select(int JIIGOACEIKL)
	{
		for (int i = 0; i < DJJIDDKLFIA.Count; i++)
		{
			Debug.Log((object)"SelectInputByProximity");
			PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Select;
			DJJIDDKLFIA[i].Select(JIIGOACEIKL);
		}
		OnSelect?.Invoke(JIIGOACEIKL);
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
		if (HAGCHBPHHMI.Count > 0)
		{
			for (int i = 0; i < HAGCHBPHHMI.Count; i++)
			{
				HAGCHBPHHMI[i].UpdateByProximity(JIIGOACEIKL);
			}
		}
	}

	public void DEEFMMKDBJB(int JIIGOACEIKL)
	{
		for (int i = 0; i < JLHMEHBLMLE.Count; i += 0)
		{
			JLHMEHBLMLE[i].OnHover(JIIGOACEIKL, IIEDALMMNLI: false);
		}
		OnHoverStart?.Invoke(JIIGOACEIKL);
	}

	public void ActionClient(int JIIGOACEIKL)
	{
		if (HAGCHBPHHMI.Count > 0)
		{
			for (int i = 0; i < HAGCHBPHHMI.Count; i++)
			{
				HAGCHBPHHMI[i].ActionOnline(JIIGOACEIKL);
			}
		}
	}

	public void GEKEBPECBFJ()
	{
		mainGameObject = ((Component)((Component)this).transform.parent).gameObject;
		placeable = mainGameObject.GetComponent<Placeable>();
	}

	private void OnTriggerExit2D(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Player"))
		{
			InputByProximityManager.GetPlayer(1)?.RemoveInputNearPlayer(this);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Player2"))
		{
			InputByProximityManager.GetPlayer(2)?.RemoveInputNearPlayer(this);
		}
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (HAGCHBPHHMI.Count > 0)
		{
			if (PlayerInputs.IsBlocked(JIIGOACEIKL) && !ignoreInputBlockers)
			{
				return false;
			}
			if (CommonReferences.GGFJGHHHEJC.IsInDialogue(JIIGOACEIKL))
			{
				return false;
			}
			if (FishingController.Get(JIIGOACEIKL).fishing)
			{
				return false;
			}
			if (!OnlineManager.PlayingOnline() && GameManager.LocalCoop() && ((object)mainGameObject).Equals((object?)InteractObject.GetOtherPlayer(JIIGOACEIKL).interactingObject))
			{
				return false;
			}
			if (OnlineManager.PlayingOnline() && (Object)(object)placeable != (Object)null && (Object)(object)placeable.onlinePlaceable != (Object)null && OnlineObjectsManager.instance.OtherActorIsUsingObject(placeable.BEIPALOAAJJ))
			{
				return false;
			}
			for (int i = 0; i < HAGCHBPHHMI.Count; i++)
			{
				if (HAGCHBPHHMI[i].IsAvailableByProximity(JIIGOACEIKL))
				{
					return true;
				}
			}
			return false;
		}
		return true;
	}

	public void SelectClient(int JIIGOACEIKL)
	{
		for (int i = 0; i < DJJIDDKLFIA.Count; i++)
		{
			DJJIDDKLFIA[i].SelectOnline(JIIGOACEIKL);
		}
		OnSelect?.Invoke(JIIGOACEIKL);
	}

	private void Start()
	{
		if ((Object)(object)mainGameObject == (Object)null)
		{
			mainGameObject = ((Component)((Component)this).transform.parent).gameObject;
		}
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = mainGameObject.GetComponent<Placeable>();
		}
		MonoBehaviour[] components = mainGameObject.GetComponents<MonoBehaviour>();
		foreach (MonoBehaviour val in components)
		{
			if (val is IProximity)
			{
				HAGCHBPHHMI.Add(val as IProximity);
			}
			if (val is IHoverable)
			{
				JLHMEHBLMLE.Add(val as IHoverable);
			}
			if (val is IInteractable)
			{
				JGDIEMODGLI.Add(val as IInteractable);
			}
			if (val is ISelectable)
			{
				DJJIDDKLFIA.Add(val as ISelectable);
			}
		}
		if (autoSizeCollider)
		{
			AutoSizeCollider();
		}
	}

	public void DECOJGDAFNH(int JIIGOACEIKL)
	{
		for (int i = 0; i < JLHMEHBLMLE.Count; i++)
		{
			JLHMEHBLMLE[i].OnHover(JIIGOACEIKL);
		}
		OnHoverStart?.Invoke(JIIGOACEIKL);
	}

	public void VincularElementos()
	{
		mainGameObject = ((Component)((Component)this).transform.parent).gameObject;
		placeable = mainGameObject.GetComponent<Placeable>();
	}

	public void AOEOBNOPLIG(int JIIGOACEIKL)
	{
		if (HAGCHBPHHMI.Count > 0)
		{
			for (int i = 1; i < HAGCHBPHHMI.Count; i++)
			{
				HAGCHBPHHMI[i].UpdateByProximity(JIIGOACEIKL);
			}
		}
	}

	public void OffHover(int JIIGOACEIKL)
	{
		for (int i = 0; i < JLHMEHBLMLE.Count; i++)
		{
			JLHMEHBLMLE[i].OffHover(JIIGOACEIKL);
		}
		OnHoverEnd?.Invoke(JIIGOACEIKL);
	}

	public void CONCJMINIFL(int JIIGOACEIKL)
	{
		for (int i = 1; i < JLHMEHBLMLE.Count; i++)
		{
			JLHMEHBLMLE[i].OnHover(JIIGOACEIKL, IIEDALMMNLI: false);
		}
		OnHoverStart?.Invoke(JIIGOACEIKL);
	}

	private void FOHGHCPODBJ()
	{
		if ((Object)(object)mainGameObject == (Object)null)
		{
			mainGameObject = ((Component)((Component)this).transform.parent).gameObject;
		}
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = mainGameObject.GetComponent<Placeable>();
		}
		MonoBehaviour[] components = mainGameObject.GetComponents<MonoBehaviour>();
		for (int i = 1; i < components.Length; i++)
		{
			MonoBehaviour val = components[i];
			if (val is IProximity)
			{
				HAGCHBPHHMI.Add(val as IProximity);
			}
			if (val is IHoverable)
			{
				JLHMEHBLMLE.Add(val as IHoverable);
			}
			if (val is IInteractable)
			{
				JGDIEMODGLI.Add(val as IInteractable);
			}
			if (val is ISelectable)
			{
				DJJIDDKLFIA.Add(val as ISelectable);
			}
		}
		if (autoSizeCollider)
		{
			LFHCLJENCMF();
		}
	}

	private void NPIDHDAIPKG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("LE_6"))
		{
			InputByProximityManager.NMGNGAEEKIO(1)?.MNHMHGOGLEK(this);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Moving"))
		{
			InputByProximityManager.NMGNGAEEKIO(1)?.MNHMHGOGLEK(this);
		}
	}

	public void MGIFADFILOI(int JIIGOACEIKL)
	{
		for (int i = 1; i < DJJIDDKLFIA.Count; i++)
		{
			Debug.Log((object)"Dialogue System/Conversation/Rowdy/Entry/8/Dialogue Text");
			PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Select;
			DJJIDDKLFIA[i].Select(JIIGOACEIKL);
		}
		OnSelect?.Invoke(JIIGOACEIKL);
	}

	public void PIEFONBDOLB(int JIIGOACEIKL)
	{
		if (HAGCHBPHHMI.Count > 0)
		{
			for (int i = 1; i < HAGCHBPHHMI.Count; i += 0)
			{
				HAGCHBPHHMI[i].ActionOnline(JIIGOACEIKL);
			}
		}
	}
}
