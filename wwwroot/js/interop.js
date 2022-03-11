window.methods = {
    resizeTextBox: function(elementId) {
        const myTextArea = document.getElementById(elementId);
        myTextArea.style.height = 'auto';
        myTextArea.style.height = (myTextArea.scrollHeight) + 'px';
    },
    getWindowWidth: function () {
        return "" + window.innerWidth
    },
    customResize: function (elementId) {
        DotNet.invokeMethodAsync('BlazorToDoApp', 'ResizedWindow')
    },
    onLoad: function () {
        window.onresize = window.methods.customResize;
    }
}
