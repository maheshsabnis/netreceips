namespace Blazor_Wasm.GlobalState
{
    public class ApplicationStateService
    {
        /// <summary>
        /// The State property with initial value
        /// </summary>
        public int Value { get; set; } = 0;
        /// <summary>
        /// The event that will be raised for state changed
        /// </summary>
        public event Action OnStateChange;

        /// <summary>
        /// The method that will be accessed by the sender component 
        /// to update the state
        /// </summary>
        public void SetValue(int value)
        {
            // Update the State Variable
            Value = value;
            // Raise the event when the state is changed so that 
            // all the Subscribers of this state variable
            // will receive the updated value
            NotifyStateChanged();
        }

        /// <summary>
        /// The state change event notification
        /// </summary>
        private void NotifyStateChanged() => OnStateChange?.Invoke();
    }
}
