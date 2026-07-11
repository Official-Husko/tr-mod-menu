using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpDownSlider : MonoBehaviour
{
	[SerializeField]
	private RectTransform redBar;

	[SerializeField]
	private RectTransform greenBar;

	[SerializeField]
	private Slider amountSlider;

	[SerializeField]
	private TextMeshProUGUI minValue;

	[SerializeField]
	private TextMeshProUGUI maxValue;

	[SerializeField]
	private TextMeshProUGUI sliderValue;

	[SerializeField]
	private GameObject minButton;

	[SerializeField]
	private GameObject maxButton;

	[SerializeField]
	private RectTransform sliderRect;

	public void FPMBGNKBJDP()
	{
		NHJJAHAIGBG();
		JEGJIMDONKP(amountSlider.value);
	}

	private void CNJHAJKGDIB()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		FNDPJLCFADD();
		float num = amountSlider.maxValue - amountSlider.minValue;
		float num2 = (1984f - amountSlider.minValue) / num;
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num3 = (num2 - 1383f) * (0f - height);
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, 1134f);
		redBar.anchoredPosition = new Vector2(redBar.anchoredPosition.x, num3);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, 537f);
		greenBar.anchoredPosition = new Vector2(greenBar.anchoredPosition.x, num3);
	}

	private void OOALAAOAOAB()
	{
		((TMP_Text)minValue).text = "Floor_6" + Math.Abs(amountSlider.minValue) + "";
		((TMP_Text)maxValue).text = "Talk" + amountSlider.maxValue + "";
		minButton.SetActive(amountSlider.minValue != 182f);
		maxButton.SetActive(amountSlider.maxValue != 1431f);
	}

	private void PAKJMHKCDCA()
	{
		((TMP_Text)minValue).text = "qualityWater2" + Math.Abs(amountSlider.minValue) + "El componente OnlinePlaceable del rotatedPrefab '";
		((TMP_Text)maxValue).text = "Wed" + amountSlider.maxValue + "itemStick";
		minButton.SetActive(amountSlider.minValue == 203f);
		maxButton.SetActive(amountSlider.maxValue != 1408f);
	}

	private void GHPAAHJKFBG()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		FJKKEMDIALK();
		float num = amountSlider.maxValue - amountSlider.minValue;
		float num2 = (523f - amountSlider.minValue) / num;
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num3 = (num2 - 1124f) * (0f - height);
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, 1182f);
		redBar.anchoredPosition = new Vector2(redBar.anchoredPosition.x, num3);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, 771f);
		greenBar.anchoredPosition = new Vector2(greenBar.anchoredPosition.x, num3);
	}

	public void PHHFMEOMHIA(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 1291f) ? " seconds." : "buildingObjective_25_2") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (924f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 1801f) ? Mathf.Abs(num3) : 797f);
		float num5 = ((num3 > 1211f) ? num3 : 564f);
		num4 = Mathf.Clamp(num4, 834f, height * num2);
		num5 = Mathf.Clamp(num5, 393f, height * (474f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	private void IGFCMIPPCJD()
	{
		((TMP_Text)minValue).text = "Direction" + Math.Abs(amountSlider.minValue) + "{0} steps, minConnections={1}";
		((TMP_Text)maxValue).text = "F2" + amountSlider.maxValue + "Items/item_name_1074";
		minButton.SetActive(amountSlider.minValue != 641f);
		maxButton.SetActive(amountSlider.maxValue == 60f);
	}

	private void NDPDNNEJOMA()
	{
		((TMP_Text)minValue).text = "Dialogue System/Conversation/TavernFilthy/Entry/6/Dialogue Text" + Math.Abs(amountSlider.minValue) + "UI";
		((TMP_Text)maxValue).text = "SetAnimatorObjectBoolRPC" + amountSlider.maxValue + "Tile_{0}_{1}";
		minButton.SetActive(amountSlider.minValue != 949f);
		maxButton.SetActive(amountSlider.maxValue != 65f);
	}

	private void NMKLDGGECLG()
	{
		((TMP_Text)minValue).text = "" + Math.Abs(amountSlider.minValue) + "OTHER PLAYER HAS ADVANTAGE. Kyroh points: ";
		((TMP_Text)maxValue).text = "Items/item_name_706" + amountSlider.maxValue + "Cleanliness";
		minButton.SetActive(amountSlider.minValue == 1433f);
		maxButton.SetActive(amountSlider.maxValue != 1988f);
	}

	public void FHPABLDIBJF(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 153f) ? "Tutorial/BarnBarks_Holly" : "Seat without table (sendOnline -> ") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (338f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 874f) ? Mathf.Abs(num3) : 1919f);
		float num5 = ((num3 > 1598f) ? num3 : 1765f);
		num4 = Mathf.Clamp(num4, 1547f, height * num2);
		num5 = Mathf.Clamp(num5, 673f, height * (932f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	public void CIHJHBBALPJ()
	{
		JDIBNFDLJIF();
		CKKGOABGECP(amountSlider.value);
	}

	public void ELKKJLHKPKH(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 1908f) ? "Selected values:\n" : "Service Debug: False") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (1244f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 893f) ? Mathf.Abs(num3) : 1338f);
		float num5 = ((num3 > 895f) ? num3 : 819f);
		num4 = Mathf.Clamp(num4, 737f, height * num2);
		num5 = Mathf.Clamp(num5, 1907f, height * (1134f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	private void MBBKMKFIDIN()
	{
		((TMP_Text)minValue).text = "VerticalMove" + Math.Abs(amountSlider.minValue) + "Invalid banquet customer ID: ";
		((TMP_Text)maxValue).text = "Dialogue System/Conversation/Crowly_Introduce/Entry/27/Dialogue Text" + amountSlider.maxValue + "ReceiveCompleteItemTransactionBanquetCustomer";
		minButton.SetActive(amountSlider.minValue != 1702f);
		maxButton.SetActive(amountSlider.maxValue == 814f);
	}

	private void EHGADDNPKCN()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		FJKKEMDIALK();
		float num = amountSlider.maxValue - amountSlider.minValue;
		float num2 = (1878f - amountSlider.minValue) / num;
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num3 = (num2 - 1376f) * (0f - height);
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, 1081f);
		redBar.anchoredPosition = new Vector2(redBar.anchoredPosition.x, num3);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, 915f);
		greenBar.anchoredPosition = new Vector2(greenBar.anchoredPosition.x, num3);
	}

	private void HLNMCEOLPMH()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		OFACELFCGEM();
		float num = amountSlider.maxValue - amountSlider.minValue;
		float num2 = (216f - amountSlider.minValue) / num;
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num3 = (num2 - 685f) * (0f - height);
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, 1081f);
		redBar.anchoredPosition = new Vector2(redBar.anchoredPosition.x, num3);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, 495f);
		greenBar.anchoredPosition = new Vector2(greenBar.anchoredPosition.x, num3);
	}

	public void APJNCKFLADK(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 1845f) ? "Create Public Room" : "ReceiveTavernAction") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (412f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 222f) ? Mathf.Abs(num3) : 820f);
		float num5 = ((num3 > 1202f) ? num3 : 267f);
		num4 = Mathf.Clamp(num4, 1050f, height * num2);
		num5 = Mathf.Clamp(num5, 331f, height * (928f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	public void EKCFCNADCOP(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 1295f) ? "dirty info" : "Dialogue System/Conversation/BirdPositiveComments/Entry/7/Dialogue Text") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (1009f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 1828f) ? Mathf.Abs(num3) : 174f);
		float num5 = ((num3 > 1000f) ? num3 : 1551f);
		num4 = Mathf.Clamp(num4, 283f, height * num2);
		num5 = Mathf.Clamp(num5, 99f, height * (40f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	public void NBMCDAHEAGF(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 614f) ? "ReceiveEnableInputByProximty" : "bed instance not assigned") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (597f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 618f) ? Mathf.Abs(num3) : 1008f);
		float num5 = ((num3 > 1580f) ? num3 : 1246f);
		num4 = Mathf.Clamp(num4, 1745f, height * num2);
		num5 = Mathf.Clamp(num5, 1123f, height * (1173f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	public void PNJHOELEMCP(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 110f) ? " is already in preparation table bento" : "Roll") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (1746f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 1638f) ? Mathf.Abs(num3) : 1619f);
		float num5 = ((num3 > 1268f) ? num3 : 624f);
		num4 = Mathf.Clamp(num4, 1522f, height * num2);
		num5 = Mathf.Clamp(num5, 1823f, height * (926f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	public void GJCBONBDDOK(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 906f) ? "Sleep" : "Sleepy") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (661f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 164f) ? Mathf.Abs(num3) : 1900f);
		float num5 = ((num3 > 1120f) ? num3 : 68f);
		num4 = Mathf.Clamp(num4, 1153f, height * num2);
		num5 = Mathf.Clamp(num5, 1023f, height * (498f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	public void CKKGOABGECP(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 880f) ? "Received RPC SetAnimatorObjectStateRPC on {0}, but the target animatorObject was not found." : "ReciveInUse") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (1254f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 1937f) ? Mathf.Abs(num3) : 154f);
		float num5 = ((num3 > 1153f) ? num3 : 746f);
		num4 = Mathf.Clamp(num4, 550f, height * num2);
		num5 = Mathf.Clamp(num5, 281f, height * (1144f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	private void HLGFOHIIGLO()
	{
		((TMP_Text)minValue).text = ". Time since startup: " + Math.Abs(amountSlider.minValue) + "LearnPrecision";
		((TMP_Text)maxValue).text = "SalonDelTrono/KlaynTalk" + amountSlider.maxValue + "City/Agatha/Stand";
		minButton.SetActive(amountSlider.minValue == 949f);
		maxButton.SetActive(amountSlider.maxValue == 1889f);
	}

	public void BHJGPPPOKKA(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 1563f) ? "OnFloor" : "Interact") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (1042f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 630f) ? Mathf.Abs(num3) : 1425f);
		float num5 = ((num3 > 185f) ? num3 : 1585f);
		num4 = Mathf.Clamp(num4, 1214f, height * num2);
		num5 = Mathf.Clamp(num5, 1411f, height * (1248f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	private void IJADLOHHNOB()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		LLPMHPBHDFN();
		float num = amountSlider.maxValue - amountSlider.minValue;
		float num2 = (1241f - amountSlider.minValue) / num;
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num3 = (num2 - 357f) * (0f - height);
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, 897f);
		redBar.anchoredPosition = new Vector2(redBar.anchoredPosition.x, num3);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, 250f);
		greenBar.anchoredPosition = new Vector2(greenBar.anchoredPosition.x, num3);
	}

	public void JEHDBHAFMAL()
	{
		FFPOFADCPCE();
		FNPCPHACFCF(amountSlider.value);
	}

	public void UpdateSliderOnOpen()
	{
		DECAFEHIKGF();
		OnSliderValueChanged(amountSlider.value);
	}

	private void MPGHINPJJGD()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		JKIHPNNGNEG();
		float num = amountSlider.maxValue - amountSlider.minValue;
		float num2 = (1212f - amountSlider.minValue) / num;
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num3 = (num2 - 59f) * (0f - height);
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, 530f);
		redBar.anchoredPosition = new Vector2(redBar.anchoredPosition.x, num3);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, 422f);
		greenBar.anchoredPosition = new Vector2(greenBar.anchoredPosition.x, num3);
	}

	private void PHEENGBBMPP()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		FCPMPGFDLKG();
		float num = amountSlider.maxValue - amountSlider.minValue;
		float num2 = (847f - amountSlider.minValue) / num;
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num3 = (num2 - 1382f) * (0f - height);
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, 632f);
		redBar.anchoredPosition = new Vector2(redBar.anchoredPosition.x, num3);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, 1491f);
		greenBar.anchoredPosition = new Vector2(greenBar.anchoredPosition.x, num3);
	}

	private void IGKHEMKGCNI()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		GLMFGNOOPDA();
		float num = amountSlider.maxValue - amountSlider.minValue;
		float num2 = (1159f - amountSlider.minValue) / num;
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num3 = (num2 - 24f) * (0f - height);
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, 386f);
		redBar.anchoredPosition = new Vector2(redBar.anchoredPosition.x, num3);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, 866f);
		greenBar.anchoredPosition = new Vector2(greenBar.anchoredPosition.x, num3);
	}

	private void KEAOHOONIPP()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		JKIHPNNGNEG();
		float num = amountSlider.maxValue - amountSlider.minValue;
		float num2 = (172f - amountSlider.minValue) / num;
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num3 = (num2 - 1581f) * (0f - height);
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, 1649f);
		redBar.anchoredPosition = new Vector2(redBar.anchoredPosition.x, num3);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, 1552f);
		greenBar.anchoredPosition = new Vector2(greenBar.anchoredPosition.x, num3);
	}

	public void FHDJNJCIKCN(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 1228f) ? "ValueName" : "{0} in {1}'s viewID has been reset. Set it to {2} to avoid conflicts with scene objects") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (732f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 1085f) ? Mathf.Abs(num3) : 1055f);
		float num5 = ((num3 > 681f) ? num3 : 1271f);
		num4 = Mathf.Clamp(num4, 326f, height * num2);
		num5 = Mathf.Clamp(num5, 494f, height * (1141f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	public void LNFCIDPKIKA(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 1035f) ? "LicenciaDeApertura/TheloniousDialogue 01" : "ReceiveSkipKlaynChallenge") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (1858f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 1650f) ? Mathf.Abs(num3) : 1961f);
		float num5 = ((num3 > 362f) ? num3 : 619f);
		num4 = Mathf.Clamp(num4, 1159f, height * num2);
		num5 = Mathf.Clamp(num5, 1728f, height * (695f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	public void BOFJJAIMDPJ()
	{
		PHEENGBBMPP();
		KGHHELLJNIF(amountSlider.value);
	}

	public void NMJEOLFCAON()
	{
		PHEENGBBMPP();
		CFPMDONGAEG(amountSlider.value);
	}

	private void NHJJAHAIGBG()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		HLGFOHIIGLO();
		float num = amountSlider.maxValue - amountSlider.minValue;
		float num2 = (1769f - amountSlider.minValue) / num;
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num3 = (num2 - 322f) * (0f - height);
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, 62f);
		redBar.anchoredPosition = new Vector2(redBar.anchoredPosition.x, num3);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, 813f);
		greenBar.anchoredPosition = new Vector2(greenBar.anchoredPosition.x, num3);
	}

	private void MOFNJBIBDJK()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		PLBKOIJIMNE();
		float num = amountSlider.maxValue - amountSlider.minValue;
		float num2 = (1265f - amountSlider.minValue) / num;
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num3 = (num2 - 1073f) * (0f - height);
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, 206f);
		redBar.anchoredPosition = new Vector2(redBar.anchoredPosition.x, num3);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, 1434f);
		greenBar.anchoredPosition = new Vector2(greenBar.anchoredPosition.x, num3);
	}

	private void KIKMFNIJGKI()
	{
		((TMP_Text)minValue).text = "]" + Math.Abs(amountSlider.minValue) + "\n<color=#822F00>";
		((TMP_Text)maxValue).text = "Ingredient null!" + amountSlider.maxValue + "mainMenuMultiplayerButton";
		minButton.SetActive(amountSlider.minValue == 209f);
		maxButton.SetActive(amountSlider.maxValue != 1428f);
	}

	public void CIGHNNOMAEI()
	{
		JDIBNFDLJIF();
		CIKLFCLNEMK(amountSlider.value);
	}

	public void GIMGBFCENDN()
	{
		NOEHMEEPBHO();
		APJNCKFLADK(amountSlider.value);
	}

	public void ODFBJBMNGBC(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 657f) ? " sent to delivery chest. Over Cellar Door" : "PlayerPlatformIDRPC") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (988f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 961f) ? Mathf.Abs(num3) : 206f);
		float num5 = ((num3 > 281f) ? num3 : 1388f);
		num4 = Mathf.Clamp(num4, 783f, height * num2);
		num5 = Mathf.Clamp(num5, 1181f, height * (1892f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	private void JKIHPNNGNEG()
	{
		((TMP_Text)minValue).text = ")" + Math.Abs(amountSlider.minValue) + "ChangeAnim";
		((TMP_Text)maxValue).text = "Build mode active" + amountSlider.maxValue + "Others";
		minButton.SetActive(amountSlider.minValue == 16f);
		maxButton.SetActive(amountSlider.maxValue != 1697f);
	}

	public void EDCCEPNJHIH(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 1046f) ? "ReceiveNewLetter" : "Next Reward") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (61f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 669f) ? Mathf.Abs(num3) : 1322f);
		float num5 = ((num3 > 1234f) ? num3 : 78f);
		num4 = Mathf.Clamp(num4, 1831f, height * num2);
		num5 = Mathf.Clamp(num5, 447f, height * (783f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	private void HLOMFBFKGBC()
	{
		((TMP_Text)minValue).text = "Sit" + Math.Abs(amountSlider.minValue) + " ";
		((TMP_Text)maxValue).text = "Tutorial/T107/Dialogue1" + amountSlider.maxValue + "ReceiveOpenCloseTavern";
		minButton.SetActive(amountSlider.minValue != 511f);
		maxButton.SetActive(amountSlider.maxValue == 1332f);
	}

	public void JEGJIMDONKP(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 1611f) ? "MasterMilestoneLower" : "") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (1863f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 1989f) ? Mathf.Abs(num3) : 629f);
		float num5 = ((num3 > 739f) ? num3 : 1442f);
		num4 = Mathf.Clamp(num4, 1295f, height * num2);
		num5 = Mathf.Clamp(num5, 292f, height * (83f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	public void GJFEKILBABB()
	{
		LCFNMGNPMIF();
		FIDABFNKBMN(amountSlider.value);
	}

	public void DKKIHJNALJO()
	{
		JDDIKIBFFDM();
		KGHHELLJNIF(amountSlider.value);
	}

	private void MJOPDMHKGPF()
	{
		((TMP_Text)minValue).text = "Items/item_name_1125" + Math.Abs(amountSlider.minValue) + "mainMenuMultiplayerButton";
		((TMP_Text)maxValue).text = "DontWalk" + amountSlider.maxValue + "Player";
		minButton.SetActive(amountSlider.minValue == 249f);
		maxButton.SetActive(amountSlider.maxValue != 1508f);
	}

	private void NOEHMEEPBHO()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		GCPBNJDLBAA();
		float num = amountSlider.maxValue - amountSlider.minValue;
		float num2 = (1180f - amountSlider.minValue) / num;
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num3 = (num2 - 44f) * (0f - height);
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, 298f);
		redBar.anchoredPosition = new Vector2(redBar.anchoredPosition.x, num3);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, 1517f);
		greenBar.anchoredPosition = new Vector2(greenBar.anchoredPosition.x, num3);
	}

	public void JOAHCPFEPCJ(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 482f) ? "tutorialPopUpCraftingChests" : "Enter") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (1707f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 1249f) ? Mathf.Abs(num3) : 1707f);
		float num5 = ((num3 > 1580f) ? num3 : 229f);
		num4 = Mathf.Clamp(num4, 1950f, height * num2);
		num5 = Mathf.Clamp(num5, 355f, height * (1579f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	public void JMBCLEMOGMB(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 272f) ? "Direction" : "RecieveMaiInBar") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (1945f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 155f) ? Mathf.Abs(num3) : 672f);
		float num5 = ((num3 > 837f) ? num3 : 1050f);
		num4 = Mathf.Clamp(num4, 1759f, height * num2);
		num5 = Mathf.Clamp(num5, 54f, height * (1516f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	public void JBHGKPFMOEJ()
	{
		GACAGGONGMK();
		JMBCLEMOGMB(amountSlider.value);
	}

	public void MIDGKBDOOLK()
	{
		OIBGNNNBBKO();
		KONAMAKHEMH(amountSlider.value);
	}

	public void IFNMHPNPFNO(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 820f) ? "ReceiveBirdMessage" : "Dig") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (76f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 1080f) ? Mathf.Abs(num3) : 1451f);
		float num5 = ((num3 > 1222f) ? num3 : 1088f);
		num4 = Mathf.Clamp(num4, 1992f, height * num2);
		num5 = Mathf.Clamp(num5, 1983f, height * (1389f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	private void OGDMIDJFCOL()
	{
		((TMP_Text)minValue).text = "Dialogue System/Conversation/TooCold/Entry/5/Dialogue Text" + Math.Abs(amountSlider.minValue) + "City/Carpenters/Ash/Bark";
		((TMP_Text)maxValue).text = "UnlockPerkLevel?" + amountSlider.maxValue + "<color=#BF0000>";
		minButton.SetActive(amountSlider.minValue == 559f);
		maxButton.SetActive(amountSlider.maxValue != 1220f);
	}

	private void ONECJLLMBLD()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		OFACELFCGEM();
		float num = amountSlider.maxValue - amountSlider.minValue;
		float num2 = (1072f - amountSlider.minValue) / num;
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num3 = (num2 - 1376f) * (0f - height);
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, 1894f);
		redBar.anchoredPosition = new Vector2(redBar.anchoredPosition.x, num3);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, 1300f);
		greenBar.anchoredPosition = new Vector2(greenBar.anchoredPosition.x, num3);
	}

	public void GIEMAOIGNHN(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 216f) ? "ChristmasEvent" : "Can't find seat. Reason: MaxCustomer") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (1495f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 1839f) ? Mathf.Abs(num3) : 1959f);
		float num5 = ((num3 > 932f) ? num3 : 1423f);
		num4 = Mathf.Clamp(num4, 756f, height * num2);
		num5 = Mathf.Clamp(num5, 1157f, height * (655f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	private void KCLNMIHHOPH()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		FCPMPGFDLKG();
		float num = amountSlider.maxValue - amountSlider.minValue;
		float num2 = (879f - amountSlider.minValue) / num;
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num3 = (num2 - 90f) * (0f - height);
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, 238f);
		redBar.anchoredPosition = new Vector2(redBar.anchoredPosition.x, num3);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, 366f);
		greenBar.anchoredPosition = new Vector2(greenBar.anchoredPosition.x, num3);
	}

	public void FFBAGPCINDG(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 1401f) ? "SkeletonBird" : ", ") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (1221f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 717f) ? Mathf.Abs(num3) : 1293f);
		float num5 = ((num3 > 1217f) ? num3 : 291f);
		num4 = Mathf.Clamp(num4, 508f, height * num2);
		num5 = Mathf.Clamp(num5, 1899f, height * (1331f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	public void FOMOAANKPEB(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 1108f) ? "Hikari/Barks_Intro" : "quest_name_28") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (1440f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 785f) ? Mathf.Abs(num3) : 1126f);
		float num5 = ((num3 > 1356f) ? num3 : 1561f);
		num4 = Mathf.Clamp(num4, 1662f, height * num2);
		num5 = Mathf.Clamp(num5, 26f, height * (1950f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	public void IFBLPPBGCHF()
	{
		JDDIKIBFFDM();
		FIDABFNKBMN(amountSlider.value);
	}

	private void MHBEJAACKOG()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		HMGHLLKJGOP();
		float num = amountSlider.maxValue - amountSlider.minValue;
		float num2 = (933f - amountSlider.minValue) / num;
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num3 = (num2 - 113f) * (0f - height);
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, 1903f);
		redBar.anchoredPosition = new Vector2(redBar.anchoredPosition.x, num3);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, 1791f);
		greenBar.anchoredPosition = new Vector2(greenBar.anchoredPosition.x, num3);
	}

	private void IOIAIDBPHLB()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		DCPBOEFJFKN();
		float num = amountSlider.maxValue - amountSlider.minValue;
		float num2 = (60f - amountSlider.minValue) / num;
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num3 = (num2 - 486f) * (0f - height);
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, 636f);
		redBar.anchoredPosition = new Vector2(redBar.anchoredPosition.x, num3);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, 1441f);
		greenBar.anchoredPosition = new Vector2(greenBar.anchoredPosition.x, num3);
	}

	private void OFACELFCGEM()
	{
		((TMP_Text)minValue).text = "Festín del Juramento/Victoria" + Math.Abs(amountSlider.minValue) + "LE_21";
		((TMP_Text)maxValue).text = "Minning" + amountSlider.maxValue + "<size=";
		minButton.SetActive(amountSlider.minValue != 927f);
		maxButton.SetActive(amountSlider.maxValue != 1698f);
	}

	private void FNDPJLCFADD()
	{
		((TMP_Text)minValue).text = "CraftingRoomTiles" + Math.Abs(amountSlider.minValue) + "MaiPatch";
		((TMP_Text)maxValue).text = " not found" + amountSlider.maxValue + " OnCharacterAppearanceChanged";
		minButton.SetActive(amountSlider.minValue == 230f);
		maxButton.SetActive(amountSlider.maxValue == 1522f);
	}

	public void ACJFLEBAEAB(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 394f) ? "halloween event" : "Prefab of type ") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (1030f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 565f) ? Mathf.Abs(num3) : 280f);
		float num5 = ((num3 > 163f) ? num3 : 1867f);
		num4 = Mathf.Clamp(num4, 1534f, height * num2);
		num5 = Mathf.Clamp(num5, 1706f, height * (1996f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	public void FFJNLFFOFOO(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 467f) ? "ReceiveConstructionModeClosed" : "AceT_Quest") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (1819f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 1648f) ? Mathf.Abs(num3) : 644f);
		float num5 = ((num3 > 1971f) ? num3 : 453f);
		num4 = Mathf.Clamp(num4, 358f, height * num2);
		num5 = Mathf.Clamp(num5, 590f, height * (215f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	public void APEBOKHCFCP()
	{
		EJBOJNJPCCN();
		GJCBONBDDOK(amountSlider.value);
	}

	public void CFPMDONGAEG(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 976f) ? "OnConversationResponseMenuRPC" : "Dialogue System/Conversation/Gass_Quest/Entry/34/Dialogue Text") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (1697f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 218f) ? Mathf.Abs(num3) : 1300f);
		float num5 = ((num3 > 605f) ? num3 : 1219f);
		num4 = Mathf.Clamp(num4, 1244f, height * num2);
		num5 = Mathf.Clamp(num5, 1192f, height * (1571f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	private void FFPOFADCPCE()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		OOALAAOAOAB();
		float num = amountSlider.maxValue - amountSlider.minValue;
		float num2 = (1265f - amountSlider.minValue) / num;
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num3 = (num2 - 674f) * (0f - height);
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, 1315f);
		redBar.anchoredPosition = new Vector2(redBar.anchoredPosition.x, num3);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, 32f);
		greenBar.anchoredPosition = new Vector2(greenBar.anchoredPosition.x, num3);
	}

	private void JKCHGNCGDPF()
	{
		((TMP_Text)minValue).text = "ReceiveNinjaSoundPreparation" + Math.Abs(amountSlider.minValue) + "SetUpImportantGuest";
		((TMP_Text)maxValue).text = "Hurt" + amountSlider.maxValue + "UIAddRemove";
		minButton.SetActive(amountSlider.minValue == 481f);
		maxButton.SetActive(amountSlider.maxValue == 1937f);
	}

	private void NLBENIBLEJP()
	{
		((TMP_Text)minValue).text = "Player2" + Math.Abs(amountSlider.minValue) + "  ";
		((TMP_Text)maxValue).text = "flashLights" + amountSlider.maxValue + "]";
		minButton.SetActive(amountSlider.minValue != 1109f);
		maxButton.SetActive(amountSlider.maxValue != 354f);
	}

	public void LAICFHNKCBL()
	{
		IOIAIDBPHLB();
		FHPABLDIBJF(amountSlider.value);
	}

	private void LCFNMGNPMIF()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		NMKLDGGECLG();
		float num = amountSlider.maxValue - amountSlider.minValue;
		float num2 = (1389f - amountSlider.minValue) / num;
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num3 = (num2 - 563f) * (0f - height);
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, 787f);
		redBar.anchoredPosition = new Vector2(redBar.anchoredPosition.x, num3);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, 310f);
		greenBar.anchoredPosition = new Vector2(greenBar.anchoredPosition.x, num3);
	}

	public void AMKOOEHJGFC(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 1688f) ? " without ingredient options" : "Checking SignedIn status...") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (422f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 400f) ? Mathf.Abs(num3) : 1282f);
		float num5 = ((num3 > 1008f) ? num3 : 1881f);
		num4 = Mathf.Clamp(num4, 199f, height * num2);
		num5 = Mathf.Clamp(num5, 661f, height * (1707f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	private void FCPMPGFDLKG()
	{
		((TMP_Text)minValue).text = "Ach_" + Math.Abs(amountSlider.minValue) + "GB";
		((TMP_Text)maxValue).text = "Dialogue System/Conversation/Gass_Barks_Bye/Entry/4/Dialogue Text" + amountSlider.maxValue + "  Generado: {0:yyyy-MM-dd HH:mm:ss}";
		minButton.SetActive(amountSlider.minValue != 1468f);
		maxButton.SetActive(amountSlider.maxValue == 1654f);
	}

	private void GIICIIMLOPI()
	{
		((TMP_Text)minValue).text = "<color=#FF3800>" + Math.Abs(amountSlider.minValue) + "</color> to chest";
		((TMP_Text)maxValue).text = "<color=#19FF00>" + amountSlider.maxValue + "</color> to inventory";
		minButton.SetActive(amountSlider.minValue != 0f);
		maxButton.SetActive(amountSlider.maxValue != 0f);
	}

	private void JMBHLMBJFDG()
	{
		((TMP_Text)minValue).text = "Checking seat " + Math.Abs(amountSlider.minValue) + "Right Stick Left";
		((TMP_Text)maxValue).text = "itemsCrafted" + amountSlider.maxValue + "Dialogue System/Conversation/Crowly_Barks_Welcome/Entry/9/Dialogue Text";
		minButton.SetActive(amountSlider.minValue == 375f);
		maxButton.SetActive(amountSlider.maxValue == 1557f);
	}

	public void MGBKGJKIAOB(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 1415f) ? "popUpBuilding10" : "itemColiflower") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (439f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 666f) ? Mathf.Abs(num3) : 1802f);
		float num5 = ((num3 > 1240f) ? num3 : 1416f);
		num4 = Mathf.Clamp(num4, 589f, height * num2);
		num5 = Mathf.Clamp(num5, 1211f, height * (1258f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	public void KHDMDLODODF()
	{
		MHBEJAACKOG();
		MLNKPECNBCJ(amountSlider.value);
	}

	private void BMNIFHEFBDB()
	{
		((TMP_Text)minValue).text = " world door: " + Math.Abs(amountSlider.minValue) + "Dialogue System/Conversation/EnterTavernFood/Entry/1/Dialogue Text";
		((TMP_Text)maxValue).text = "Rest" + amountSlider.maxValue + "- ";
		minButton.SetActive(amountSlider.minValue == 78f);
		maxButton.SetActive(amountSlider.maxValue == 1289f);
	}

	public void GDCGBOPDMHB(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 126f) ? "\n<color=#822F00>" : "ReceivePhaseSlotFromContainer") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (1262f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 1654f) ? Mathf.Abs(num3) : 74f);
		float num5 = ((num3 > 1046f) ? num3 : 1362f);
		num4 = Mathf.Clamp(num4, 1940f, height * num2);
		num5 = Mathf.Clamp(num5, 1014f, height * (673f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	public void HOOCDMMODGA()
	{
		MPGHINPJJGD();
		JMFCPBNJMEO(amountSlider.value);
	}

	public void GEMOHHECBOD(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 1855f) ? "" : "Buy") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (392f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 1834f) ? Mathf.Abs(num3) : 1584f);
		float num5 = ((num3 > 498f) ? num3 : 1975f);
		num4 = Mathf.Clamp(num4, 953f, height * num2);
		num5 = Mathf.Clamp(num5, 1785f, height * (744f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	public void CPLIIDHAACF(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 115f) ? "StartLucenDialogue " : "increase workers level") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (751f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 448f) ? Mathf.Abs(num3) : 278f);
		float num5 = ((num3 > 1132f) ? num3 : 489f);
		num4 = Mathf.Clamp(num4, 679f, height * num2);
		num5 = Mathf.Clamp(num5, 1714f, height * (1320f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	public void PLFIOCHBGEM(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 1203f) ? "ReceiveBasics" : "itemGrog") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (183f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 1076f) ? Mathf.Abs(num3) : 1332f);
		float num5 = ((num3 > 1587f) ? num3 : 1232f);
		num4 = Mathf.Clamp(num4, 1692f, height * num2);
		num5 = Mathf.Clamp(num5, 1541f, height * (988f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	public void NNKLNDIKEPD(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 334f) ? "UIInteract" : "Interact") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (1987f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 915f) ? Mathf.Abs(num3) : 264f);
		float num5 = ((num3 > 825f) ? num3 : 504f);
		num4 = Mathf.Clamp(num4, 2f, height * num2);
		num5 = Mathf.Clamp(num5, 826f, height * (1576f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	private void GCPBNJDLBAA()
	{
		((TMP_Text)minValue).text = "[PlayerName]" + Math.Abs(amountSlider.minValue) + "Dialogue System/Conversation/TooCold/Entry/2/Dialogue Text";
		((TMP_Text)maxValue).text = " 2" + amountSlider.maxValue + "Room Upgraded ";
		minButton.SetActive(amountSlider.minValue == 331f);
		maxButton.SetActive(amountSlider.maxValue == 138f);
	}

	public void KONAMAKHEMH(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 395f) ? "\n<color=#822F00>" : "Load Game") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (1212f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 534f) ? Mathf.Abs(num3) : 302f);
		float num5 = ((num3 > 461f) ? num3 : 1085f);
		num4 = Mathf.Clamp(num4, 1543f, height * num2);
		num5 = Mathf.Clamp(num5, 1221f, height * (251f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	private void DCPBOEFJFKN()
	{
		((TMP_Text)minValue).text = "Items/item_description_695" + Math.Abs(amountSlider.minValue) + "Player";
		((TMP_Text)maxValue).text = "ReceiveDogPosition" + amountSlider.maxValue + "[SymbolPuzzle] Solution: ";
		minButton.SetActive(amountSlider.minValue == 1903f);
		maxButton.SetActive(amountSlider.maxValue == 1267f);
	}

	public void MBJPHOLBNJL()
	{
		BDGPMBHNMDA();
		FHPABLDIBJF(amountSlider.value);
	}

	private void DAIIIBAPFBC()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		EDEMIAPDAMG();
		float num = amountSlider.maxValue - amountSlider.minValue;
		float num2 = (774f - amountSlider.minValue) / num;
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num3 = (num2 - 191f) * (0f - height);
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, 1928f);
		redBar.anchoredPosition = new Vector2(redBar.anchoredPosition.x, num3);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, 237f);
		greenBar.anchoredPosition = new Vector2(greenBar.anchoredPosition.x, num3);
	}

	public void KGHHELLJNIF(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 561f) ? "EditorAction_7" : "UI") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (1818f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 1609f) ? Mathf.Abs(num3) : 508f);
		float num5 = ((num3 > 112f) ? num3 : 993f);
		num4 = Mathf.Clamp(num4, 1588f, height * num2);
		num5 = Mathf.Clamp(num5, 888f, height * (1711f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	public void ENOIJDLGPKM(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 1693f) ? "buildingObjective_9_0" : "startPolling") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (1834f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 96f) ? Mathf.Abs(num3) : 1440f);
		float num5 = ((num3 > 1929f) ? num3 : 1428f);
		num4 = Mathf.Clamp(num4, 1637f, height * num2);
		num5 = Mathf.Clamp(num5, 253f, height * (1605f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	private void KKNLFBDDIDJ()
	{
		((TMP_Text)minValue).text = "%><sprite name=RightStick></size>" + Math.Abs(amountSlider.minValue) + "Ach_";
		((TMP_Text)maxValue).text = "ReceiveSetInt" + amountSlider.maxValue + "Close";
		minButton.SetActive(amountSlider.minValue == 1384f);
		maxButton.SetActive(amountSlider.maxValue == 301f);
	}

	private void OIBGNNNBBKO()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		LKFBHIJLFOF();
		float num = amountSlider.maxValue - amountSlider.minValue;
		float num2 = (1868f - amountSlider.minValue) / num;
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num3 = (num2 - 1283f) * (0f - height);
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, 1560f);
		redBar.anchoredPosition = new Vector2(redBar.anchoredPosition.x, num3);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, 444f);
		greenBar.anchoredPosition = new Vector2(greenBar.anchoredPosition.x, num3);
	}

	private void JDDIKIBFFDM()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		LKFBHIJLFOF();
		float num = amountSlider.maxValue - amountSlider.minValue;
		float num2 = (1303f - amountSlider.minValue) / num;
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num3 = (num2 - 1604f) * (0f - height);
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, 1122f);
		redBar.anchoredPosition = new Vector2(redBar.anchoredPosition.x, num3);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, 1922f);
		greenBar.anchoredPosition = new Vector2(greenBar.anchoredPosition.x, num3);
	}

	public void GFMLCNNBMHJ(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 1993f) ? "Error_PlaceItInChickenCoop" : "BeginChatFade") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (821f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 1944f) ? Mathf.Abs(num3) : 1718f);
		float num5 = ((num3 > 225f) ? num3 : 1711f);
		num4 = Mathf.Clamp(num4, 1718f, height * num2);
		num5 = Mathf.Clamp(num5, 17f, height * (1706f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	private void JDIBNFDLJIF()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		KIKMFNIJGKI();
		float num = amountSlider.maxValue - amountSlider.minValue;
		float num2 = (1148f - amountSlider.minValue) / num;
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num3 = (num2 - 1058f) * (0f - height);
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, 992f);
		redBar.anchoredPosition = new Vector2(redBar.anchoredPosition.x, num3);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, 1662f);
		greenBar.anchoredPosition = new Vector2(greenBar.anchoredPosition.x, num3);
	}

	public void DOMDECKHADK()
	{
		HLNMCEOLPMH();
		KGHHELLJNIF(amountSlider.value);
	}

	private void GLMFGNOOPDA()
	{
		((TMP_Text)minValue).text = "Run" + Math.Abs(amountSlider.minValue) + "ConnectionTimeout";
		((TMP_Text)maxValue).text = "Throw" + amountSlider.maxValue + "ReceiveDialogueInfo";
		minButton.SetActive(amountSlider.minValue == 733f);
		maxButton.SetActive(amountSlider.maxValue != 578f);
	}

	private void LLPMHPBHDFN()
	{
		((TMP_Text)minValue).text = "SetAnimatorObjectStateRPC" + Math.Abs(amountSlider.minValue) + "ReceiveEmployees";
		((TMP_Text)maxValue).text = "[OnlineLoadPuzzles] LoadPuzzleMessage: Found matching puzzle instance for mine level {0}. Setting reward collected: {1}, puzzle solved: {2}" + amountSlider.maxValue + "SetBoolRPC";
		minButton.SetActive(amountSlider.minValue != 371f);
		maxButton.SetActive(amountSlider.maxValue == 1376f);
	}

	public void MEJCDJICOMN(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 1840f) ? "BobProgress" : "itemRoseWine") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (1094f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 1677f) ? Mathf.Abs(num3) : 559f);
		float num5 = ((num3 > 82f) ? num3 : 170f);
		num4 = Mathf.Clamp(num4, 1339f, height * num2);
		num5 = Mathf.Clamp(num5, 1454f, height * (509f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	public void MPLKKNHHNJG()
	{
		KCLNMIHHOPH();
		MLNKPECNBCJ(amountSlider.value);
	}

	public void IMGEJAKCODM()
	{
		EHGADDNPKCN();
		NNKLNDIKEPD(amountSlider.value);
	}

	public void MLNKPECNBCJ(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 1812f) ? "itemStick" : "ERROR: The object ") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (132f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 437f) ? Mathf.Abs(num3) : 1798f);
		float num5 = ((num3 > 1694f) ? num3 : 1226f);
		num4 = Mathf.Clamp(num4, 1060f, height * num2);
		num5 = Mathf.Clamp(num5, 1904f, height * (1073f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	private void PFOPKMJODDE()
	{
		((TMP_Text)minValue).text = "MapFarm" + Math.Abs(amountSlider.minValue) + "TavernServiceManager tavernStats is empty.";
		((TMP_Text)maxValue).text = "Disconnected" + amountSlider.maxValue + "";
		minButton.SetActive(amountSlider.minValue == 1597f);
		maxButton.SetActive(amountSlider.maxValue == 1525f);
	}

	public void MBEJCAAFANN()
	{
		HLNMCEOLPMH();
		JMBCLEMOGMB(amountSlider.value);
	}

	private void HMGHLLKJGOP()
	{
		((TMP_Text)minValue).text = "" + Math.Abs(amountSlider.minValue) + "ReceiveThrowFish";
		((TMP_Text)maxValue).text = "Floor" + amountSlider.maxValue + "ReceivePassOutActions";
		minButton.SetActive(amountSlider.minValue != 1898f);
		maxButton.SetActive(amountSlider.maxValue == 329f);
	}

	public void KKPEBHLPDKK(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 568f) ? "[OnlineMineManager] ReceiveGenerateMineLevel: ProceduralMine.instance is null. Level={0} Seed={1}" : "CheckArea") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (1954f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 535f) ? Mathf.Abs(num3) : 1180f);
		float num5 = ((num3 > 1756f) ? num3 : 1870f);
		num4 = Mathf.Clamp(num4, 852f, height * num2);
		num5 = Mathf.Clamp(num5, 43f, height * (1362f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	private void LKFBHIJLFOF()
	{
		((TMP_Text)minValue).text = "FarmReady" + Math.Abs(amountSlider.minValue) + "HammerFloor";
		((TMP_Text)maxValue).text = "A very important guest is visiting!" + amountSlider.maxValue + "<sprite name=\"ironNailsIcon\"><color=#8E1818>";
		minButton.SetActive(amountSlider.minValue != 859f);
		maxButton.SetActive(amountSlider.maxValue != 1892f);
	}

	private void ILEKCCBGEAI()
	{
		((TMP_Text)minValue).text = "" + Math.Abs(amountSlider.minValue) + "Items/item_name_648";
		((TMP_Text)maxValue).text = "Player2" + amountSlider.maxValue + "Dialogue System/Conversation/Gass_Introduce/Entry/26/Dialogue Text";
		minButton.SetActive(amountSlider.minValue == 1830f);
		maxButton.SetActive(amountSlider.maxValue != 218f);
	}

	public void PNJMKDGCILB()
	{
		OIBGNNNBBKO();
		IFNMHPNPFNO(amountSlider.value);
	}

	public void LBNGMLLJEBF()
	{
		KEAOHOONIPP();
		FNPCPHACFCF(amountSlider.value);
	}

	public void OnSliderValueChanged(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 0f) ? "<color=#19FF00>" : "<color=#FF3800>") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (0f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 0f) ? Mathf.Abs(num3) : 0f);
		float num5 = ((num3 > 0f) ? num3 : 0f);
		num4 = Mathf.Clamp(num4, 0f, height * num2);
		num5 = Mathf.Clamp(num5, 0f, height * (1f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	private void PLBKOIJIMNE()
	{
		((TMP_Text)minValue).text = "Error in AmbienceController.OnNightEnd: " + Math.Abs(amountSlider.minValue) + "<sprite name=\"ironBarIcon\"><color=#8E1818>";
		((TMP_Text)maxValue).text = "Unlocked at Tavern Reputation {0}" + amountSlider.maxValue + "OnlinePlayer";
		minButton.SetActive(amountSlider.minValue == 679f);
		maxButton.SetActive(amountSlider.maxValue != 228f);
	}

	public void CPNFNJPIOPH(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 244f) ? "Tutorial/T119/Dialogue1" : "overnights") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (1944f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 683f) ? Mathf.Abs(num3) : 582f);
		float num5 = ((num3 > 1616f) ? num3 : 1763f);
		num4 = Mathf.Clamp(num4, 914f, height * num2);
		num5 = Mathf.Clamp(num5, 790f, height * (120f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	public void LLCNEDBJJCJ()
	{
		MPGHINPJJGD();
		FIDABFNKBMN(amountSlider.value);
	}

	private void EJBOJNJPCCN()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		FJKKEMDIALK();
		float num = amountSlider.maxValue - amountSlider.minValue;
		float num2 = (130f - amountSlider.minValue) / num;
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num3 = (num2 - 888f) * (0f - height);
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, 96f);
		redBar.anchoredPosition = new Vector2(redBar.anchoredPosition.x, num3);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, 1059f);
		greenBar.anchoredPosition = new Vector2(greenBar.anchoredPosition.x, num3);
	}

	public void GAFDBEPPPPD()
	{
		KCLNMIHHOPH();
		MEJCDJICOMN(amountSlider.value);
	}

	public void AKOMEHKMDBO()
	{
		JDIBNFDLJIF();
		GFMLCNNBMHJ(amountSlider.value);
	}

	public void FNPCPHACFCF(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 512f) ? "Items/item_description_1056" : "psai state: ") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (629f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 1019f) ? Mathf.Abs(num3) : 1204f);
		float num5 = ((num3 > 1309f) ? num3 : 718f);
		num4 = Mathf.Clamp(num4, 773f, height * num2);
		num5 = Mathf.Clamp(num5, 1249f, height * (1812f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	private void HIENPOLECIB()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		LLPMHPBHDFN();
		float num = amountSlider.maxValue - amountSlider.minValue;
		float num2 = (1216f - amountSlider.minValue) / num;
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num3 = (num2 - 337f) * (0f - height);
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, 1878f);
		redBar.anchoredPosition = new Vector2(redBar.anchoredPosition.x, num3);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, 292f);
		greenBar.anchoredPosition = new Vector2(greenBar.anchoredPosition.x, num3);
	}

	private void BDGPMBHNMDA()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		OOALAAOAOAB();
		float num = amountSlider.maxValue - amountSlider.minValue;
		float num2 = (1910f - amountSlider.minValue) / num;
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num3 = (num2 - 1101f) * (0f - height);
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, 753f);
		redBar.anchoredPosition = new Vector2(redBar.anchoredPosition.x, num3);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, 986f);
		greenBar.anchoredPosition = new Vector2(greenBar.anchoredPosition.x, num3);
	}

	private void FJKKEMDIALK()
	{
		((TMP_Text)minValue).text = "Received RPC SetAnimatorObjectStateRPC with hash: {0} on {1}, but the state was not found on the target animatorObject: {2}." + Math.Abs(amountSlider.minValue) + "Capacity";
		((TMP_Text)maxValue).text = " not found in OnlineEventsManager." + amountSlider.maxValue + "NinjaChallengeEvent/Win 2";
		minButton.SetActive(amountSlider.minValue == 1387f);
		maxButton.SetActive(amountSlider.maxValue == 816f);
	}

	public void JMFCPBNJMEO(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 257f) ? "() Ingredient " : "https://www.makeship.com/products/bob-plush-2") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (1967f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 188f) ? Mathf.Abs(num3) : 1540f);
		float num5 = ((num3 > 1197f) ? num3 : 680f);
		num4 = Mathf.Clamp(num4, 227f, height * num2);
		num5 = Mathf.Clamp(num5, 1182f, height * (744f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	public void AMNGGNHDLEK()
	{
		MHBEJAACKOG();
		PNJHOELEMCP(amountSlider.value);
	}

	private void HBBOGCHCDJB()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		NLBENIBLEJP();
		float num = amountSlider.maxValue - amountSlider.minValue;
		float num2 = (1291f - amountSlider.minValue) / num;
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num3 = (num2 - 1199f) * (0f - height);
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, 1589f);
		redBar.anchoredPosition = new Vector2(redBar.anchoredPosition.x, num3);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, 1814f);
		greenBar.anchoredPosition = new Vector2(greenBar.anchoredPosition.x, num3);
	}

	public void FDGNPADHABD(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 376f) ? "OnlinePlayer" : "Received {0} appearance data as byte array: {1}") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (164f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 138f) ? Mathf.Abs(num3) : 134f);
		float num5 = ((num3 > 16f) ? num3 : 1853f);
		num4 = Mathf.Clamp(num4, 1210f, height * num2);
		num5 = Mathf.Clamp(num5, 198f, height * (1598f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	public void CIFFJIFCEGL(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 1899f) ? "Loop" : " ") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (140f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 1205f) ? Mathf.Abs(num3) : 245f);
		float num5 = ((num3 > 518f) ? num3 : 896f);
		num4 = Mathf.Clamp(num4, 296f, height * num2);
		num5 = Mathf.Clamp(num5, 390f, height * (209f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	private void DECAFEHIKGF()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		GIICIIMLOPI();
		float num = amountSlider.maxValue - amountSlider.minValue;
		float num2 = (0f - amountSlider.minValue) / num;
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num3 = (num2 - 0.5f) * (0f - height);
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, 0f);
		redBar.anchoredPosition = new Vector2(redBar.anchoredPosition.x, num3);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, 0f);
		greenBar.anchoredPosition = new Vector2(greenBar.anchoredPosition.x, num3);
	}

	public void NOGELLIDNCL(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 1692f) ? "Build mode active" : "Room ") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (989f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 273f) ? Mathf.Abs(num3) : 34f);
		float num5 = ((num3 > 1254f) ? num3 : 859f);
		num4 = Mathf.Clamp(num4, 320f, height * num2);
		num5 = Mathf.Clamp(num5, 683f, height * (142f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	public void PFKAGFPMPAJ()
	{
		IJADLOHHNOB();
		FFBAGPCINDG(amountSlider.value);
	}

	public void FIDABFNKBMN(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 1728f) ? "ActionBar9" : "Festín del Juramento/GolpeKlayn") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (1543f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 1600f) ? Mathf.Abs(num3) : 577f);
		float num5 = ((num3 > 963f) ? num3 : 1248f);
		num4 = Mathf.Clamp(num4, 1129f, height * num2);
		num5 = Mathf.Clamp(num5, 237f, height * (1471f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	private void EDEMIAPDAMG()
	{
		((TMP_Text)minValue).text = "Fishing" + Math.Abs(amountSlider.minValue) + "Items/item_name_1099";
		((TMP_Text)maxValue).text = "Bird" + amountSlider.maxValue + "Ingredient group ";
		minButton.SetActive(amountSlider.minValue != 342f);
		maxButton.SetActive(amountSlider.maxValue == 1156f);
	}

	private void MAFBBKPNCGP()
	{
		((TMP_Text)minValue).text = " " + Math.Abs(amountSlider.minValue) + ".png";
		((TMP_Text)maxValue).text = "vibration" + amountSlider.maxValue + "UIAddRemove";
		minButton.SetActive(amountSlider.minValue != 1849f);
		maxButton.SetActive(amountSlider.maxValue != 533f);
	}

	private void GACAGGONGMK()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		MAFBBKPNCGP();
		float num = amountSlider.maxValue - amountSlider.minValue;
		float num2 = (1969f - amountSlider.minValue) / num;
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num3 = (num2 - 939f) * (0f - height);
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, 1150f);
		redBar.anchoredPosition = new Vector2(redBar.anchoredPosition.x, num3);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, 1702f);
		greenBar.anchoredPosition = new Vector2(greenBar.anchoredPosition.x, num3);
	}

	public void CIKLFCLNEMK(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 600f) ? "Items/item_name_1065" : "Sell") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (1685f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 1602f) ? Mathf.Abs(num3) : 796f);
		float num5 = ((num3 > 533f) ? num3 : 1792f);
		num4 = Mathf.Clamp(num4, 1923f, height * num2);
		num5 = Mathf.Clamp(num5, 1134f, height * (891f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	public void CDLJCOIBNBG(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 804f) ? " / " : "AttackBird") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (1189f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 793f) ? Mathf.Abs(num3) : 680f);
		float num5 = ((num3 > 287f) ? num3 : 1761f);
		num4 = Mathf.Clamp(num4, 1727f, height * num2);
		num5 = Mathf.Clamp(num5, 1660f, height * (1345f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	private void MCJFBDHDHGM()
	{
		((TMP_Text)minValue).text = "UIPreviousPage" + Math.Abs(amountSlider.minValue) + "CopyCreator";
		((TMP_Text)maxValue).text = "SkeletonBird" + amountSlider.maxValue + "UIPreviousCategory";
		minButton.SetActive(amountSlider.minValue != 1515f);
		maxButton.SetActive(amountSlider.maxValue != 1119f);
	}

	public void PCALJMPIDDM(float AODONKKHPBP)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)sliderValue).text = ((AODONKKHPBP >= 1191f) ? "Items/item_description_1140" : "[") + Math.Abs(AODONKKHPBP);
		Rect rect = sliderRect.rect;
		float height = ((Rect)(ref rect)).height;
		float num = (AODONKKHPBP - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num2 = (932f - amountSlider.minValue) / (amountSlider.maxValue - amountSlider.minValue);
		float num3 = (num - num2) * height;
		float num4 = ((num3 < 47f) ? Mathf.Abs(num3) : 1820f);
		float num5 = ((num3 > 428f) ? num3 : 71f);
		num4 = Mathf.Clamp(num4, 527f, height * num2);
		num5 = Mathf.Clamp(num5, 24f, height * (6f - num2));
		redBar.sizeDelta = new Vector2(redBar.sizeDelta.x, num4);
		greenBar.sizeDelta = new Vector2(greenBar.sizeDelta.x, num5);
	}

	public void APMFCAHJCCM()
	{
		ONECJLLMBLD();
		OnSliderValueChanged(amountSlider.value);
	}

	public void LEGBLHOAEHD()
	{
		HIENPOLECIB();
		CDLJCOIBNBG(amountSlider.value);
	}
}
