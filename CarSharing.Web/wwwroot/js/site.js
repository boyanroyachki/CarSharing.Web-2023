setInterval(() => {
    const clockElement = document.getElementById('clock');
    if (clockElement) {
        clockElement.innerText = new Date().toLocaleTimeString();
    }
}, 1000);
