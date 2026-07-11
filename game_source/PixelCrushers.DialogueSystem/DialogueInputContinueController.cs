using TMPro;
using UnityEngine;

namespace PixelCrushers.DialogueSystem;

public class DialogueInputContinueController : MonoBehaviour
{
	public StandardUIContinueButtonFastForward standarUI;

	public GameObject button;

	public TextMeshProUGUI text;

	private void Start()
	{
	}

	private void Update()
	{
		if (PlayerInputs.GetPlayer(CommonReferences.GGFJGHHHEJC.playerDialogue).GetButtonDown("UIInteract") && ((TMP_Text)text).maxVisibleCharacters > 1)
		{
			standarUI.OnFastForward();
		}
		if ((Object)(object)standarUI.typewriterEffect != (Object)null && standarUI.typewriterEffect.isPlaying)
		{
			button.SetActive(false);
		}
		else
		{
			button.SetActive(true);
		}
	}
}
