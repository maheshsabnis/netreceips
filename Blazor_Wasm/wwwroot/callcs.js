console.log('CS to JS File');
 


window.addMethod = () => {
    DotNet.invokeMethodAsync('Blazor_Wasm', 'Addition',10,20)
        .then(data => {
            alert(data);
        });
};

window.display = () => {
    DotNet.invokeMethodAsync('Blazor_Wasm', 'ShowMessage')
        .then(data => {
            alert(data);
        });
};

window.getData = () => {
    DotNet.invokeMethodAsync('Blazor_Wasm', 'GetDepartments')
        .then(data => {
            alert(data);
        });
};