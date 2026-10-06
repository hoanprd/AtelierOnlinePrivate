using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ExitGames.UtilityScripts
{
	public class ButtonInsideScrollList : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IEventSystemHandler
	{
		private ScrollRect scrollRect;

		private void Start()
		{
		}

		void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
		{
		}

		void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
		{
		}
	}
}
