using System;
using UnityEngine.UI;

[Serializable]
public class BirdTooltipPanel : TooltipPanel
{
	public SlotUI slotUI;

	public Slider slider;

	public override void BKJKGMFLDCC(int JIIGOACEIKL, TooltipInfo BBJDPIJPLPA)
	{
		base.BKJKGMFLDCC(JIIGOACEIKL, BBJDPIJPLPA);
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, BBJDPIJPLPA.itemInstance.LHBPOPOIFLE().KDNBBPJCNDJ(BBJDPIJPLPA.itemInstance));
		slider.value = (BBJDPIJPLPA.itemInstance as BirdInstance).commentsQuality;
	}
}
