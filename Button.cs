public class Button {
    public event Action OnClick;

    public void Click() {
        OnClick?.Invoke();
    }
}