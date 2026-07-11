using UnityEngine;
using UnityEngine.EventSystems;

namespace psai;

public class TooltipTrigger : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler
{
	public string text;

	public void OnPointerEnter(PointerEventData eventData)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		StartHover(new Vector3(eventData.position.x, eventData.position.y - 18f, 0f));
	}

	public void OnSelect(BaseEventData eventData)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		StartHover(((Component)this).transform.position);
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		StopHover();
	}

	public void OnDeselect(BaseEventData eventData)
	{
		StopHover();
	}

	private void StartHover(Vector3 position)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)TooltipView.Instance))
		{
			TooltipView.Instance.ShowTooltip(text, position);
		}
	}

	private void StopHover()
	{
		if (Object.op_Implicit((Object)(object)TooltipView.Instance))
		{
			TooltipView.Instance.HideTooltip();
		}
	}
}
