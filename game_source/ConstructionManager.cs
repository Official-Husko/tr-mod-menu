using System;
using UnityEngine;

public abstract class ConstructionManager : MonoBehaviour
{
	public static ConstructionManager current;

	public Action<EditorAction> OnEditorActionChanged = delegate
	{
	};

	public Action<int> OnActivated = delegate
	{
	};

	public Action<int> OnDeactivated = delegate
	{
	};

	protected bool PHGHJDMCKCN;

	protected EditorAction GDIFLANEEPG = EditorAction.AddFloor;

	public CameraController cameraTarget;

	[SerializeField]
	public static Placeable currentInstantiatedGO;

	protected AccessElement GOGANDEAPCA;

	public static bool NEOJLHDFFMJ
	{
		get
		{
			if ((Object)(object)current == (Object)null || !current.LNLJMCONDNE)
			{
				return false;
			}
			return true;
		}
	}

	public abstract bool LNLJMCONDNE { get; set; }

	public abstract EditorAction CHFHMMNELGP { get; set; }

	protected abstract void CMADPLAHBEG();

	public abstract void ChangeInstantiatedGO(GameObject DIEMDFCBEFB);

	public void RemoveAccessInstantiated()
	{
		if ((Object)(object)currentInstantiatedGO != (Object)null)
		{
			ButtonsContext.GetPlayer(FarmConstructionUI.GGFJGHHHEJC.JIIGOACEIKL).ResetButtons();
			HoverObject.GetPlayer(FarmConstructionUI.GGFJGHHHEJC.JIIGOACEIKL).Hover(null);
			currentInstantiatedGO.RemovePlaceable(EFNFMEIDGDN: true);
			currentInstantiatedGO = null;
		}
	}

	protected abstract void LAEIKGKFPKB(int JIIGOACEIKL);

	public abstract void CancelChanges();

	protected abstract void NFHHEMPGCNM(int JIIGOACEIKL);
}
