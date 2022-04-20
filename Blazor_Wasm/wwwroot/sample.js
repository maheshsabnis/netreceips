// no input parameter no return 
function display() {
    alert('Display Called');
}
// input parameters with return data
function add(x, y) {
    return x + y;
}
// function with Asynchronous execution
function getData() {
    return new Promise((resolve, reject) => {
        let http = new XMLHttpRequest();
        http.onload = function () {
            console.log(JSON.stringify(http.response));
            resolve(JSON.stringify(http.response));
        }
        http.onerror = function (error) {
            reject(error);
        }
        http.open("GET", "http://localhost:7011/api/departments");
        http.send();
    });
}
