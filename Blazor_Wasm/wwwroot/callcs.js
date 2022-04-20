console.log('CS to JS File');
window.callCSMethods = {
    fn: function () {
        console.log('fs');
    },
    showMessage: function () {
        DotNet.invokeMethodAsync("Blazor_Wasm", "ShowMessage")
            .then((message) => {
                alert(`Message Received from CSharp is ${message}`);
            });
    },

    addMethod: function () {
        // passing parameters to CSharp method
        DotNet.invokeMethodAsync("Blazor_Wasm", "add", 300, 500)
            .then((message) => {
                alert(`Addition from CSharp is ${message}`);
            });
    },
    getDepartmentsMethod: function () {
        // passing parameters to CSharp method
        DotNet.invokeMethodAsync("Blazor_Wasm", "getDepartments")
            .then((message) => {
                alert(`Data Receivd From AJAX Call ${JSON.stringify(message)}`);
            });
    }
};