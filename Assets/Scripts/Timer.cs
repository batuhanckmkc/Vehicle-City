using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [Header("Timer UI references:")]
    public GameObject uiGameObject;
    [SerializeField] private Image uiFillImage;
    [SerializeField] private Text uiText;

    public int Duration { get; private set; }

    public static int remainingDuration;

    private UnityAction onTimerBeginAction;
    private UnityAction<int> onTimerChangeAction;
    private UnityAction onTimerEndAction;

    private void Awake()
    {
        ResetTimer();
    }

    private void ResetTimer()
    {
        uiText.text = "00:00";
        uiFillImage.fillAmount = 0f;

        Duration = remainingDuration = 0;

        onTimerBeginAction = null;
        onTimerChangeAction = null;
        onTimerEndAction = null;
    }

    public Timer SetDuration(int seconds)
    {
        Duration = remainingDuration = seconds;
        return this;
    }

    //- Events ----------------------------------

    public Timer OnBegin(UnityAction action)
    {
        onTimerBeginAction = action;
        return this;
    }
    public Timer OnChange(UnityAction<int> action)
    {
        onTimerChangeAction = action;
        return this;
    }
    public Timer OnEnd(UnityAction action)
    {
        onTimerEndAction = action;
        return this;
    }
    public void Begin()
    {
        if (onTimerBeginAction != null)
        {
            onTimerBeginAction.Invoke();
        }
        StopAllCoroutines();
        StartCoroutine(UpdateTimer());
    }

    private IEnumerator UpdateTimer()
    {
        while (remainingDuration >= 0)
        {
            if (onTimerChangeAction != null)
                onTimerChangeAction.Invoke(remainingDuration); 
            UpdateUI(remainingDuration);
            remainingDuration--;
            yield return new WaitForSeconds(1f);
        }
        End();
    }

    private void UpdateUI(int seconds)
    {
        uiText.text = string.Format("{0:D2}:{1:D2}", seconds/60, seconds % 60);
        uiFillImage.fillAmount = Mathf.InverseLerp(0, Duration, seconds);
    }

    public void End()
    {
        if (onTimerEndAction != null)
            onTimerEndAction.Invoke();
        ResetTimer();
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
    }
}

