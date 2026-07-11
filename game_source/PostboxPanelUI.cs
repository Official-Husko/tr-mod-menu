using System;
using UnityEngine;

public class PostboxPanelUI : UIWindow
{
	[SerializeField]
	private GameObject buttonsToHide;

	public static PostboxPanelUI[] instances = new PostboxPanelUI[3];

	public static PostboxPanelUI PHDBJGOEKHB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static PostboxPanelUI JHOHGMODKGM(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static PostboxPanelUI MIAOGLENOHL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static PostboxPanelUI AKMJEPMHFMO(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public override void CloseUI()
	{
		if ((Object)(object)buttonsToHide != (Object)null)
		{
			buttonsToHide.SetActive(true);
		}
		base.CloseUI();
		PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
		player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(CloseUI));
		Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowClose), HOMFPAFAOGD: true, null, null, 0.4f);
	}

	public static PostboxPanelUI OMCDJAOBFCE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static PostboxPanelUI NIDHCIHFOHB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static PostboxPanelUI IGHMHMNPMLB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static PostboxPanelUI AEJKCONFPHB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static PostboxPanelUI IEABDMDELFO(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static PostboxPanelUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	protected override void Awake()
	{
		instances[numInstance] = this;
		base.Awake();
	}

	public static PostboxPanelUI PNCKAKBBKJL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public override void OpenUI()
	{
		base.OpenUI();
		PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
		player.OnPlayerMoving = (Action)Delegate.Combine(player.OnPlayerMoving, new Action(CloseUI));
		if ((Object)(object)buttonsToHide != (Object)null)
		{
			buttonsToHide.SetActive(false);
		}
		Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowOpen), HOMFPAFAOGD: true, null, null, 0.4f);
	}
}
