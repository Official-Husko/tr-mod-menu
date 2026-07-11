using UnityEngine;
using UnityEngine.UI;

namespace psai;

public class TooltipView : MonoBehaviour
{
	public bool TurnedOn;

	public Text tooltipText;

	private static TooltipView instance;

	public bool IsActive => ((Component)this).gameObject.activeSelf;

	public static TooltipView Instance
	{
		get
		{
			if ((Object)(object)instance == (Object)null)
			{
				instance = Object.FindObjectOfType<TooltipView>();
			}
			return instance;
		}
	}

	private void Awake()
	{
		instance = this;
		HideTooltip();
	}

	public void ShowTooltip(string text, Vector3 pos)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		if (TurnedOn)
		{
			if (tooltipText.text != text)
			{
				tooltipText.text = text;
			}
			((Component)this).transform.position = pos;
			((Component)this).gameObject.SetActive(true);
		}
	}

	public void HideTooltip()
	{
		((Component)this).gameObject.SetActive(false);
	}
}
