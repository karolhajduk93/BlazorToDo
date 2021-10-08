window.methods = {
    resize: function(elementId) {
        const myTextArea = document.getElementById(elementId);
        myTextArea.style.height = 'auto';
        myTextArea.style.height = (myTextArea.scrollHeight) + 'px';
    }
}