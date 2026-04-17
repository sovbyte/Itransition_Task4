async function apiRequest(url, method, body = null) {
    const token = localStorage.getItem('jwt_token');

    const options = {
        method: method,
        headers: {
            'Content-Type': 'application/json',
            'Authorization': `Bearer ${token}`
        }
    };
    if (body) options.body = JSON.stringify(body);

    const response = await fetch(url, options);

    if (response.status === 401 || response.status === 403) {
        localStorage.removeItem('jwt_token');
        window.location.href = '/Auth/Login';
        return null;
    }
    return response;
}

async function loadUsers() {
    const response = await apiRequest('/Users/GetUsers', 'GET');
    if (!response) return;

    const users = await response.json();
    const tbody = document.getElementById('userTableBody');

    tbody.innerHTML = users.map(user => {
        let statusText = "";
        let badgeClass = "";
        
        const s = user.status;
        if (s === 0 || s === "Unverified") {
            statusText = "Unverified";
            badgeClass = "bg-info text-dark";
        } else if (s === 1 || s === "Active") {
            statusText = "Active";
            badgeClass = "bg-success";
        } else if (s === 2 || s === "Blocked") {
            statusText = "Blocked";
            badgeClass = "bg-danger";
        } else {
            statusText = s;
            badgeClass = "bg-secondary";
        }

        return `
            <tr>
                <td class="ps-3">
                    <input type="checkbox" class="user-checkbox form-check-input" value="${user.id}">
                </td>
                <td>${user.id}</td>
                <td>${user.name}</td>
                <td>${user.email}</td>
                <td>${user.lastLoginTime ? new Date(user.lastLoginTime).toLocaleString() : 'Never'}</td>
                <td><span class="badge ${badgeClass}">${statusText}</span></td>
            </tr>
        `;
    }).join('');
}

document.addEventListener("DOMContentLoaded", () => {
    loadUsers();

    document.getElementById('selectAll').onchange = (e) => {
        document.querySelectorAll('.user-checkbox').forEach(cb => cb.checked = e.target.checked);
    };

    document.getElementById('blockBtn').onclick = async () => {
        const ids = Array.from(document.querySelectorAll('.user-checkbox:checked')).map(cb => parseInt(cb.value));
        if (ids.length > 0) {
            await apiRequest('/Users/Block', 'POST', ids);
            await loadUsers();
        }
    };

    document.getElementById('unblockBtn').onclick = async () => {
        const ids = Array.from(document.querySelectorAll('.user-checkbox:checked')).map(cb => parseInt(cb.value));
        if (ids.length > 0) {
            await apiRequest('/Users/Unblock', 'POST', ids);
            await loadUsers();
        }
    };

    document.getElementById('deleteBtn').onclick = async () => {
        const ids = Array.from(document.querySelectorAll('.user-checkbox:checked')).map(cb => parseInt(cb.value));
        if (ids.length > 0 && confirm("Delete selected users?")) {
            await apiRequest('/Users/Delete', 'DELETE', ids);
            await loadUsers();
        }
    };
});