 setInterval(() => {
    const clockElement = document.getElementById('clock');
    if (clockElement) {
        clockElement.innerText = new Date().toLocaleTimeString();
    }
}, 1000);

function getLocation() {
    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(showPosition);
    } else {
        alert("Geolocation is not supported by this browser.");
    }
}

function showPosition(position) {
    document.getElementById('latitude').textContent = position.coords.latitude;
    document.getElementById('longitude').textContent = position.coords.longitude;
}
