using System;
using UnityEngine;
using UnityEngine.UI;

public class CityMapUI : UIWindow
{
	[SerializeField]
	private Scrollbar scrollbar;

	[SerializeField]
	private GameObject player;

	[SerializeField]
	private Transform[] playerLocation;

	[SerializeField]
	private Button firstElementSelected;

	public int playerLocationInt;

	public static CityMapUI[] instances = new CityMapUI[3];

	protected override void Awake()
	{
		instances[numInstance] = this;
		base.Awake();
	}

	public static CityMapUI BGIMGOJDLFG(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static CityMapUI AKMJEPMHFMO(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public override void OpenUI()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		if (!IsOpen())
		{
			scrollbar.value = 0f;
			player.transform.position = playerLocation[playerLocationInt].position;
			base.OpenUI();
			GameActionBarUI.Get(base.JIIGOACEIKL).CloseUI();
			PlayerController playerController = PlayerController.GetPlayer(base.JIIGOACEIKL);
			playerController.OnPlayerMoving = (Action)Delegate.Combine(playerController.OnPlayerMoving, new Action(CloseUI));
			if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)firstElementSelected);
			}
		}
	}

	public static CityMapUI FHOGLBPBGMI(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static CityMapUI JHOHGMODKGM(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static CityMapUI DPBGKDNKDGM(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static CityMapUI CJMILOMGFJL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public override void CloseUI()
	{
		base.CloseUI();
		GameActionBarUI.Get(base.JIIGOACEIKL).OpenUI();
		PlayerController playerController = PlayerController.GetPlayer(base.JIIGOACEIKL);
		playerController.OnPlayerMoving = (Action)Delegate.Remove(playerController.OnPlayerMoving, new Action(CloseUI));
	}

	public static CityMapUI IGHMHMNPMLB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static CityMapUI PNCKAKBBKJL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static CityMapUI OMCDJAOBFCE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static CityMapUI PHDBJGOEKHB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static CityMapUI MIAOGLENOHL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static CityMapUI IEABDMDELFO(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static CityMapUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static CityMapUI NDPAJCGHGOB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static CityMapUI AEJKCONFPHB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static CityMapUI NIDHCIHFOHB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}
}
