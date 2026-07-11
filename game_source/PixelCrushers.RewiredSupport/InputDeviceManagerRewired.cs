using Rewired;
using UnityEngine;

namespace PixelCrushers.RewiredSupport;

[AddComponentMenu("Pixel Crushers/Third Party/Rewired Support/Input Device Manager Rewired")]
public class InputDeviceManagerRewired : MonoBehaviour
{
	[Tooltip("Rewired player ID.")]
	public int playerId;

	private Player m_player;

	private void Start()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		if ((Object)(object)InputDeviceManager.instance == (Object)null)
		{
			Debug.LogWarning((object)"The scene is missing an Input Device Manager. Can't set up InputDeviceManagerRewired.", (Object)(object)this);
		}
		InputDeviceManager.instance.GetButtonDown = new GetButtonDownDelegate(RewiredGetButtonDown);
		InputDeviceManager.instance.GetInputAxis = new GetAxisDelegate(RewiredGetAxis);
		m_player = ReInput.players.GetPlayer(playerId);
		if (m_player == null)
		{
			Debug.LogWarning((object)("Didn't find a Rewired player #" + playerId), (Object)(object)this);
		}
	}

	public bool RewiredGetButtonDown(string buttonName)
	{
		if (m_player == null)
		{
			return Input.GetButtonDown(buttonName);
		}
		if (!m_player.GetButtonDown(buttonName))
		{
			return m_player.GetNegativeButtonDown(buttonName);
		}
		return true;
	}

	public float RewiredGetAxis(string axisName)
	{
		if (m_player == null)
		{
			return Input.GetAxis(axisName);
		}
		return m_player.GetAxis(axisName);
	}
}
