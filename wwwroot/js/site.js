document.addEventListener("DOMContentLoaded", function () {
    const token = localStorage.getItem('jwt_token');
    const logoutBtn = document.getElementById('logoutBtn');
    if (token && logoutBtn) {
        logoutBtn.style.display = 'block';
    }
});

function logout() {
    localStorage.removeItem('jwt_token');
    window.location.href = '/Auth/Login';
}