using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ExitGames.UtilityScripts
{
	public class TextToggleIsOnTransition : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IEventSystemHandler
	{
		public Toggle toggle;

		private Text _text;

		public Color NormalOnColor;

		public Color NormalOffColor;

		public Color HoverOnColor;

		public Color HoverOffColor;

		private bool isHover;

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		public void OnValueChanged(bool isOn)
		{
		}

		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		public void OnPointerExit(PointerEventData eventData)
		{
		}
	}
}
